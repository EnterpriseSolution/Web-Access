#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  TableExplorer.cs
// Date: 2018/04/03 20:51

#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using Serenity;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Services;

namespace Matrix.Modules.Development
{
    [ColumnsScript("Development.TableExplorerColumns")]
    public class TableExplorerColumns
    {
        [DisplayName("Line No"), AlignRight]
        public int LineNo { get; set; }
        [QuickFilter()]
        public string Table { get; set; }
        [QuickFilter()]
        public string Entity { get; set; }
    }

    [RoutePrefix("Services/Development/TableExplorer"), Route("{action}")]
    public class TableExplorerController : ServiceEndpoint
    {
        public ListResponse<TableExplorerColumns> List(ListRequest request)
        {
            var response = new ListResponse<TableExplorerColumns>();
            IEnumerable<TableExplorerColumns> data = new List<TableExplorerColumns>();
            int line = 1;
            using (var connection = SqlConnections.NewByKey("BasicInformation"))
            {
                DataTable tableEntity = null;
                string file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Bin", "Enterprise Edition.llblgenproj");
                if (System.IO.File.Exists(file))
                    tableEntity = processProjectFile(file);

                const string query = @"SELECT TABLE_NAME  FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'  ORDER BY TABLE_NAME  ";
                var result=connection.Query(query).ToList();
                var temp = new List<TableExplorerColumns>();
                foreach (var table in result)
                {
                    string identifier = string.Empty;
                    if (tableEntity != null)
                    {
                        DataRow row = tableEntity.Rows.Find(table.TABLE_NAME.ToString());
                        if (row != null)
                        {
                            identifier = Convert.ToString(row["Entity"]);
                            identifier = identifier.Substring(0, identifier.Length - 6);
                        }
                    }

                    temp.Add(new TableExplorerColumns()
                    {
                        LineNo = line++,
                        Table = table.TABLE_NAME,
                        Entity = identifier
                    });
                }

                data = temp;
            }

            response.TotalCount = data.Count();
            response.Skip = request.Skip;
            response.Take = request.Take;

            if (request.Skip > 0)
                data = data.Skip(request.Skip);

            if (request.Take > 0)
                data = data.Take(request.Take);

            response.Entities = data.ToList();

            return response;
        }

        private DataTable processProjectFile(string projectFile)
        {
            XDocument doc = XDocument.Load(projectFile);
            XElement EntityModel = doc.Root.Elements("EntityModel").First();
            XElement EntityDefinitions = EntityModel.Elements("EntityDefinitions").First();

            _entityDefinitions = new Dictionary<string, List<EntityMappingClass>>();
            List<EntityMappingClass> fields = null;
            foreach (XElement item in EntityDefinitions.Elements())
            {
                fields = new List<EntityMappingClass>();
                //<Field Name="AttmFile" Type="byte[]" IsOptional="true" MaxLength="2147483647" FieldIndex="16" />
                foreach (XElement field in item.Elements("Fields").Elements())
                {
                    EntityMappingClass mappingClass = new EntityMappingClass();
                    mappingClass.Name = Convert.ToString(field.Attribute("Name").Value);

                    if (field.Attribute("FieldIndex") != null)
                        mappingClass.FieldIndex = Convert.ToInt16(field.Attribute("FieldIndex").Value);

                    if (field.Attribute("Type") != null)
                        mappingClass.Type = Convert.ToString(field.Attribute("Type").Value);

                    if (field.Attribute("MaxLength") != null)
                        mappingClass.MaxLength = Convert.ToDecimal(field.Attribute("MaxLength").Value);

                    if (field.Attribute("Precision") != null)
                        mappingClass.Precision = Convert.ToInt16(field.Attribute("Precision").Value);

                    if (field.Attribute("IsOptional") != null)
                        mappingClass.IsOptional = Convert.ToBoolean(field.Attribute("IsOptional").Value);

                    fields.Add(mappingClass);
                }
                _entityDefinitions.Add(item.Attribute("Name").Value + "Entity", fields);
            }

            // var MappingStores = doc.Root.Elements("MappingStores/MappingStore/EntityMappings").Elements();
            //XElement EntityModel = MappingStores.Elements().First()

            var EntityMappings = doc.Root.Elements("MappingStores").First().Elements().First().Elements().First();

            string EntityName = string.Empty;
            string TargetName = string.Empty;

            _tableEntity = new Dictionary<string, string>();

            foreach (XElement entity in EntityMappings.Elements())
            {
                //EntityName=":Attachment" TargetName="Framework:dbo:Attachment"
                EntityName = entity.Attribute("EntityName").Value;
                TargetName = entity.Attribute("TargetName").Value;

                EntityName = EntityName.Substring(1) + "Entity";
                TargetName = TargetName.Substring(TargetName.LastIndexOf(":") + 1);
                _tableEntity.Add(TargetName, EntityName);

                List<EntityMappingClass> targetfields = null;
                if (_entityDefinitions.TryGetValue(EntityName, out targetfields))
                {
                    foreach (XElement field in entity.Elements().First().Elements())
                    {
                        //<FieldMapping FieldName="AttmFile" TargetFieldName="File" 
                        var items = (from item in targetfields
                                     where item.Name == field.Attribute("FieldName").Value
                                     select item).First();

                        items.TargetFieldName = field.Attribute("TargetFieldName").Value;
                    }
                }
            }

            string entityName = string.Empty;
            bool IsPrimaryKey = false;
            var catalogs = doc.Root.Elements("TargetDatabases").First().Elements().First().Elements().Last();
            var tables = catalogs.Elements().First().Elements().First().Elements().First().Elements();
            foreach (XElement xElement in tables.Elements())
            {
                string tableName = xElement.Attribute("Name").Value;
                entityName = null;
                if (_tableEntity.TryGetValue(tableName, out entityName))
                {
                    List<EntityMappingClass> targetfields = null;
                    if (_entityDefinitions.TryGetValue(entityName, out targetfields))
                    {
                        foreach (XElement field in xElement.Elements().First().Elements())
                        {
                            IsPrimaryKey = false;
                            //<Field Name="Recnum" Ordinal="1"  IsPrimaryKey="true" IsIdentity="true" DbType="5" Precision="8" />
                            if (field.Attribute("IsPrimaryKey") != null)
                                IsPrimaryKey = Convert.ToBoolean(field.Attribute("IsPrimaryKey").Value);

                            int count = (from item in targetfields
                                         where item.TargetFieldName == field.Attribute("Name").Value
                                         select item).Count();
                            if (count > 0)
                            {
                                var items = (from item in targetfields
                                             where item.TargetFieldName == field.Attribute("Name").Value
                                             select item).First();
                                items.IsPrimarykKey = IsPrimaryKey;
                            }
                        }
                    }
                }
            }

            tableEntity = new DataTable();
            tableEntity.Columns.Add("Table", typeof(string));
            tableEntity.Columns.Add("Entity", typeof(string));
            tableEntity.PrimaryKey = new DataColumn[] { tableEntity.Columns["Table"] };

            foreach (KeyValuePair<string, string> keyValuePair in _tableEntity)
            {
                DataRow row = tableEntity.NewRow();
                row["Table"] = keyValuePair.Key;
                row["Entity"] = keyValuePair.Value;
                tableEntity.Rows.Add(row);
            }

            //bindingSource.DataSource = tableEntity;
            //dg.DataSource = bindingSource;

            return tableEntity;
        }

        private Dictionary<string, List<EntityMappingClass>> _entityDefinitions;
        private Dictionary<string, string> _tableEntity;

        private DataTable tableEntity;

        internal class EntityMappingClass
        {
            //程序中的实体属性名称
            public string Name;
            public string Type;
            public bool IsOptional;
            public Decimal MaxLength;
            public int FieldIndex;
            public int Precision;

            //数据库中的字段名称
            public string TargetFieldName;

            public bool IsPrimarykKey;

        }
    }
}