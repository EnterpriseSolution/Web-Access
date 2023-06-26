#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  WorkflowRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.MasterData.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("MasterData"), TableName("[dbo].[GBWRKF]")]
    [DisplayName("Workflow"), InstanceName("Workflow"), TwoLevelCached]   
    public sealed class WorkflowRow : Row, IIdRow, INameRow
    {
        [DisplayName("Workflowname"), Column("WORKFLOWNAME"), Size(16), PrimaryKey, QuickSearch]
        public String Workflowname
        {
            get { return Fields.Workflowname[this]; }
            set { Fields.Workflowname[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(100)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Tablename"), Column("TABLENAME"), Size(30), NotNull]
        public String Tablename
        {
            get { return Fields.Tablename[this]; }
            set { Fields.Tablename[this] = value; }
        }

        [DisplayName("Workflowtype"), Column("WORKFLOWTYPE"), NotNull]
        public Int32? Workflowtype
        {
            get { return Fields.Workflowtype[this]; }
            set { Fields.Workflowtype[this] = value; }
        }

        [DisplayName("Seqno"), Column("SEQNO"), NotNull]
        public Int32? Seqno
        {
            get { return Fields.Seqno[this]; }
            set { Fields.Seqno[this] = value; }
        }

        [DisplayName("Xoml"), Column("XOML"), Size(1073741823)]
        public String Xoml
        {
            get { return Fields.Xoml[this]; }
            set { Fields.Xoml[this] = value; }
        }

        [DisplayName("Rules"), Column("RULES"), Size(1073741823)]
        public String Rules
        {
            get { return Fields.Rules[this]; }
            set { Fields.Rules[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED")]
        public Boolean? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Published"), Column("PUBLISHED")]
        public Boolean? Published
        {
            get { return Fields.Published[this]; }
            set { Fields.Published[this] = value; }
        }

        [DisplayName("Publishedxoml"), Column("PUBLISHEDXOML"), Size(1073741823)]
        public String Publishedxoml
        {
            get { return Fields.Publishedxoml[this]; }
            set { Fields.Publishedxoml[this] = value; }
        }

        [DisplayName("Publishedrules"), Column("PUBLISHEDRULES"), Size(1073741823)]
        public String Publishedrules
        {
            get { return Fields.Publishedrules[this]; }
            set { Fields.Publishedrules[this] = value; }
        }

        [DisplayName("Createdby"), Column("CREATEDBY"), Size(10)]
        public String Createdby
        {
            get { return Fields.Createdby[this]; }
            set { Fields.Createdby[this] = value; }
        }

        [DisplayName("Createddate"), Column("CREATEDDATE")]
        public DateTime? Createddate
        {
            get { return Fields.Createddate[this]; }
            set { Fields.Createddate[this] = value; }
        }

        [DisplayName("Revisedby"), Column("REVISEDBY"), Size(10)]
        public String Revisedby
        {
            get { return Fields.Revisedby[this]; }
            set { Fields.Revisedby[this] = value; }
        }

        [DisplayName("Reviseddate"), Column("REVISEDDATE")]
        public DateTime? Reviseddate
        {
            get { return Fields.Reviseddate[this]; }
            set { Fields.Reviseddate[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Workflowname; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Workflowname; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public WorkflowRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField Workflowname;
            public StringField Description;
            public StringField Tablename;
            public Int32Field Workflowtype;
            public Int32Field Seqno;
            public StringField Xoml;
            public StringField Rules;
            public BooleanField Suspended;
            public BooleanField Published;
            public StringField Publishedxoml;
            public StringField Publishedrules;
            public StringField Createdby;
            public DateTimeField Createddate;
            public StringField Revisedby;
            public DateTimeField Reviseddate;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.Workflow";
            }
        }
    }
}
