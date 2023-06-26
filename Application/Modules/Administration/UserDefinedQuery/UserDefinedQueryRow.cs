#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  UserDefinedQueryRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Administration.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Administration"), TableName("[dbo].[Udq]")]
    [DisplayName("User Defined Query"), InstanceName("User Defined Query"), TwoLevelCached]   
    public sealed class UserDefinedQueryRow : Row, IIdRow, INameRow
    {
        [DisplayName("Query Id"), Size(16), PrimaryKey, QuickSearch]
        public String QueryId
        {
            get { return Fields.QueryId[this]; }
            set { Fields.QueryId[this] = value; }
        }

        [DisplayName("Description"), Size(100), NotNull]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Created By"), Size(10)]
        public String CreatedBy
        {
            get { return Fields.CreatedBy[this]; }
            set { Fields.CreatedBy[this] = value; }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get { return Fields.CreatedDate[this]; }
            set { Fields.CreatedDate[this] = value; }
        }

        [DisplayName("Revised By"), Size(10)]
        public String RevisedBy
        {
            get { return Fields.RevisedBy[this]; }
            set { Fields.RevisedBy[this] = value; }
        }

        [DisplayName("Revised Date")]
        public DateTime? RevisedDate
        {
            get { return Fields.RevisedDate[this]; }
            set { Fields.RevisedDate[this] = value; }
        }

        [DisplayName("Allow Duplicates")]
        public Boolean? AllowDuplicates
        {
            get { return Fields.AllowDuplicates[this]; }
            set { Fields.AllowDuplicates[this] = value; }
        }

        [DisplayName("Suspended")]
        public Boolean? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Data Source")]
        public Int32? DataSource
        {
            get { return Fields.DataSource[this]; }
            set { Fields.DataSource[this] = value; }
        }

        [DisplayName("Use As Enquiry")]
        public Boolean? UseAsEnquiry
        {
            get { return Fields.UseAsEnquiry[this]; }
            set { Fields.UseAsEnquiry[this] = value; }
        }

        [DisplayName("Use As Lookup")]
        public Boolean? UseAsLookup
        {
            get { return Fields.UseAsLookup[this]; }
            set { Fields.UseAsLookup[this] = value; }
        }

        [DisplayName("Use As Alert")]
        public Boolean? UseAsAlert
        {
            get { return Fields.UseAsAlert[this]; }
            set { Fields.UseAsAlert[this] = value; }
        }

        [DisplayName("Use As Comparation")]
        public Boolean? UseAsComparation
        {
            get { return Fields.UseAsComparation[this]; }
            set { Fields.UseAsComparation[this] = value; }
        }

        [DisplayName("Function Code"), Size(10)]
        public String FunctionCode
        {
            get { return Fields.FunctionCode[this]; }
            set { Fields.FunctionCode[this] = value; }
        }

        [DisplayName("Primary Key Fields"), Size(64)]
        public String PrimaryKeyFields
        {
            get { return Fields.PrimaryKeyFields[this]; }
            set { Fields.PrimaryKeyFields[this] = value; }
        }

        [DisplayName("Customer No Entity Name"), Size(64)]
        public String CustomerNoEntityName
        {
            get { return Fields.CustomerNoEntityName[this]; }
            set { Fields.CustomerNoEntityName[this] = value; }
        }

        [DisplayName("Customer No Field Name"), Size(64)]
        public String CustomerNoFieldName
        {
            get { return Fields.CustomerNoFieldName[this]; }
            set { Fields.CustomerNoFieldName[this] = value; }
        }

        [DisplayName("Vendor No Entity Name"), Size(64)]
        public String VendorNoEntityName
        {
            get { return Fields.VendorNoEntityName[this]; }
            set { Fields.VendorNoEntityName[this] = value; }
        }

        [DisplayName("Vendor No Field Name"), Size(64)]
        public String VendorNoFieldName
        {
            get { return Fields.VendorNoFieldName[this]; }
            set { Fields.VendorNoFieldName[this] = value; }
        }

        [DisplayName("Filter"), Size(1073741823)]
        public String Filter
        {
            get { return Fields.Filter[this]; }
            set { Fields.Filter[this] = value; }
        }

        [DisplayName("Sql"), Size(1073741823)]
        public String Sql
        {
            get { return Fields.Sql[this]; }
            set { Fields.Sql[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.QueryId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Description; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public UserDefinedQueryRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField QueryId;
            public StringField Description;
            public StringField CreatedBy;
            public DateTimeField CreatedDate;
            public StringField RevisedBy;
            public DateTimeField RevisedDate;
            public BooleanField AllowDuplicates;
            public BooleanField Suspended;
            public Int32Field DataSource;
            public BooleanField UseAsEnquiry;
            public BooleanField UseAsLookup;
            public BooleanField UseAsAlert;
            public BooleanField UseAsComparation;
            public StringField FunctionCode;
            public StringField PrimaryKeyFields;
            public StringField CustomerNoEntityName;
            public StringField CustomerNoFieldName;
            public StringField VendorNoEntityName;
            public StringField VendorNoFieldName;
            public StringField Filter;
            public StringField Sql;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Administration.UserDefinedQuery";
            }
        }
    }
}
