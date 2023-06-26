#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ReportDialogRow.cs
// Date: 2018/04/03 20:51

#endregion

using System.Collections.Generic;

namespace Matrix.EnterpriseSys.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey(SiteInitialization.Database), TableName("[dbo].[ReportDialog]")]
    [DisplayName("Report Dialog"), InstanceName("Report Dialog"), TwoLevelCached]
    public sealed class ReportDialogRow : Row, IIdRow, INameRow
    {
        [DisplayName("Report Id"), Size(16), PrimaryKey, QuickSearch]
        public String ReportId
        {
            get { return Fields.ReportId[this]; }
            set { Fields.ReportId[this] = value; }
        }

        [DisplayName("Description"), Size(100)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Suspended")]
        public Boolean? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
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

        [DisplayName("Filter By Salesman Code")]
        public Boolean? FilterBySalesmanCode
        {
            get { return Fields.FilterBySalesmanCode[this]; }
            set { Fields.FilterBySalesmanCode[this] = value; }
        }

        [DisplayName("Filter By Buyer Code")]
        public Boolean? FilterByBuyerCode
        {
            get { return Fields.FilterByBuyerCode[this]; }
            set { Fields.FilterByBuyerCode[this] = value; }
        }

        [DisplayName("Report Type")]
        public Int32? ReportType
        {
            get { return Fields.ReportType[this]; }
            set { Fields.ReportType[this] = value; }
        }

        [DisplayName("Data Source")]
        public Int32? DataSource
        {
            get { return Fields.DataSource[this]; }
            set { Fields.DataSource[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ReportId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Description; }
        }


        [MasterDetailRelation(foreignKey: "ReportId")]
        [DisplayName("Item Detail List"), NotMapped]
        public List<ReportDialogOptionRow> ItemDetailList
        {
            get { return Fields.ItemDetailList[this]; }
            set { Fields.ItemDetailList[this] = value; }
        }


        public static readonly RowFields Fields = new RowFields().Init();

        public ReportDialogRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField ReportId;
            public StringField Description;
            public BooleanField Suspended;
            public StringField CreatedBy;
            public DateTimeField CreatedDate;
            public StringField RevisedBy;
            public DateTimeField RevisedDate;
            public BooleanField FilterBySalesmanCode;
            public BooleanField FilterByBuyerCode;
            public Int32Field ReportType;
            public Int32Field DataSource;

            public RowListField<ReportDialogOptionRow> ItemDetailList;


            public RowFields()
                : base()
            {
                LocalTextPrefix = "EnterpriseSys.ReportDialog";
            }
        }
    }
}
