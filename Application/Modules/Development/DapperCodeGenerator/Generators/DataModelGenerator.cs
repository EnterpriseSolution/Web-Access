﻿#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  DataModelGenerator.cs
// Date: 2018/04/03 20:51

#endregion
using System.Linq;
using System.Text;
using DapperCodeGenerator.Core.Extensions;
using DapperCodeGenerator.Core.Models;

namespace DapperCodeGenerator.Core.Generators
{
    public static class DataModelGenerator
    {
        public static string GenerateDataModelFromTable(DatabaseTable table, string dataModelNamespace = "")
        {
            var stringBuilder = new StringBuilder();

            var usingNamespaces = table.Columns.Select(c => c.TypeNamespace).Distinct().ToList();
            usingNamespaces.Sort();
            if (usingNamespaces.Count > 0)
            {
                foreach (var usingNamespace in usingNamespaces)
                {
                    stringBuilder.AppendLine($"using {usingNamespace};");
                }

                stringBuilder.AppendLine();
            }

            if (string.IsNullOrEmpty(dataModelNamespace))
            {
                dataModelNamespace = $"DapperCodeGenerator.{table.DatabaseName}.Models";
            }

            stringBuilder.AppendLine($"namespace {dataModelNamespace}");
            stringBuilder.AppendLine("{");

            stringBuilder.AppendLine($"\tpublic class {table.TableName}DataModel");
            stringBuilder.AppendLine("\t{");

            foreach (var column in table.Columns)
            {
                stringBuilder.AppendLine($"\t\tpublic {column.Type.GetNameForCoding()} {column.ColumnName} {{ get; set; }}");
            }

            stringBuilder.AppendLine("\t}");

            stringBuilder.AppendLine("}");

            stringBuilder.AppendLine();

            return stringBuilder.ToString();
        }
    }
}
