#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  UserDefinedQueryColumns.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Administration.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Administration.UserDefinedQuery")]
    [BasedOnRow(typeof(Entities.UserDefinedQueryRow))]
    public class UserDefinedQueryColumns
    {
        [EditLink]
        public String QueryId { get; set; }
        public String Description { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public Boolean AllowDuplicates { get; set; }
        public Boolean Suspended { get; set; }
        public Int32 DataSource { get; set; }
        public Boolean UseAsEnquiry { get; set; }
        public Boolean UseAsLookup { get; set; }
        public Boolean UseAsAlert { get; set; }
        public Boolean UseAsComparation { get; set; }
        //public String FunctionCode { get; set; }
        //public String PrimaryKeyFields { get; set; }
        //public String CustomerNoEntityName { get; set; }
        //public String CustomerNoFieldName { get; set; }
        //public String VendorNoEntityName { get; set; }
        //public String VendorNoFieldName { get; set; }
        public String Filter { get; set; }
        public String Sql { get; set; }
    }
}