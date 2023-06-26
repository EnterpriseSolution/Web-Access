#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ReportDialogOptionRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.EnterpriseSys.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey(SiteInitialization.Database), TableName("[dbo].[ReportDialogOption]")]
    [DisplayName("Report Dialog Option"), InstanceName("Report Dialog Option"), TwoLevelCached]
    public sealed class ReportDialogOptionRow : Row, INameRow,IIdRow
    {
        [DisplayName("Report"), Size(16), PrimaryKey, ForeignKey("[dbo].[ReportDialog]", "ReportId"), LeftJoin("jReport"), QuickSearch, TextualField("ReportDescription")]
        public String ReportId
        {
            get { return Fields.ReportId[this]; }
            set { Fields.ReportId[this] = value; }
        }

        [DisplayName("Option No"), PrimaryKey]
        public Int32? OptionNo
        {
            get { return Fields.OptionNo[this]; }
            set { Fields.OptionNo[this] = value; }
        }

        [DisplayName("Seq No")]
        public Int32? SeqNo
        {
            get { return Fields.SeqNo[this]; }
            set { Fields.SeqNo[this] = value; }
        }

        [DisplayName("Caption"), Size(30)]
        public String Caption
        {
            get { return Fields.Caption[this]; }
            set { Fields.Caption[this] = value; }
        }

        [DisplayName("Field Name"), Size(64)]
        public String FieldName
        {
            get { return Fields.FieldName[this]; }
            set { Fields.FieldName[this] = value; }
        }

        [DisplayName("Field Type")]
        public Int32? FieldType
        {
            get { return Fields.FieldType[this]; }
            set { Fields.FieldType[this] = value; }
        }

        [DisplayName("Style")]
        public Int32? Style
        {
            get { return Fields.Style[this]; }
            set { Fields.Style[this] = value; }
        }

        [DisplayName("Data Type")]
        public Int32? DataType
        {
            get { return Fields.DataType[this]; }
            set { Fields.DataType[this] = value; }
        }

        [DisplayName("Caps Lock")]
        public Boolean? CapsLock
        {
            get { return Fields.CapsLock[this]; }
            set { Fields.CapsLock[this] = value; }
        }

        [DisplayName("Lookup Name"), Size(64)]
        public String LookupName
        {
            get { return Fields.LookupName[this]; }
            set { Fields.LookupName[this] = value; }
        }

        [DisplayName("Lookup Filter Name"), Size(64)]
        public String LookupFilterName
        {
            get { return Fields.LookupFilterName[this]; }
            set { Fields.LookupFilterName[this] = value; }
        }

        [DisplayName("Required")]
        public Boolean? Required
        {
            get { return Fields.Required[this]; }
            set { Fields.Required[this] = value; }
        }

        //[DisplayName("Report Description"), Expression("jReport.[Description]")]
        //public String ReportDescription
        //{
        //    get { return Fields.ReportDescription[this]; }
        //    set { Fields.ReportDescription[this] = value; }
        //}

        //[DisplayName("Report Suspended"), Expression("jReport.[Suspended]")]
        //public Boolean? ReportSuspended
        //{
        //    get { return Fields.ReportSuspended[this]; }
        //    set { Fields.ReportSuspended[this] = value; }
        //}

        //[DisplayName("Report Created By"), Expression("jReport.[CreatedBy]")]
        //public String ReportCreatedBy
        //{
        //    get { return Fields.ReportCreatedBy[this]; }
        //    set { Fields.ReportCreatedBy[this] = value; }
        //}

        //[DisplayName("Report Created Date"), Expression("jReport.[CreatedDate]")]
        //public DateTime? ReportCreatedDate
        //{
        //    get { return Fields.ReportCreatedDate[this]; }
        //    set { Fields.ReportCreatedDate[this] = value; }
        //}

        //[DisplayName("Report Revised By"), Expression("jReport.[RevisedBy]")]
        //public String ReportRevisedBy
        //{
        //    get { return Fields.ReportRevisedBy[this]; }
        //    set { Fields.ReportRevisedBy[this] = value; }
        //}

        //[DisplayName("Report Revised Date"), Expression("jReport.[RevisedDate]")]
        //public DateTime? ReportRevisedDate
        //{
        //    get { return Fields.ReportRevisedDate[this]; }
        //    set { Fields.ReportRevisedDate[this] = value; }
        //}

        //[DisplayName("Report Filter By Salesman Code"), Expression("jReport.[FilterBySalesmanCode]")]
        //public Boolean? ReportFilterBySalesmanCode
        //{
        //    get { return Fields.ReportFilterBySalesmanCode[this]; }
        //    set { Fields.ReportFilterBySalesmanCode[this] = value; }
        //}

        //[DisplayName("Report Filter By Buyer Code"), Expression("jReport.[FilterByBuyerCode]")]
        //public Boolean? ReportFilterByBuyerCode
        //{
        //    get { return Fields.ReportFilterByBuyerCode[this]; }
        //    set { Fields.ReportFilterByBuyerCode[this] = value; }
        //}

        //[DisplayName("Report Report Type"), Expression("jReport.[ReportType]")]
        //public Int32? ReportReportType
        //{
        //    get { return Fields.ReportReportType[this]; }
        //    set { Fields.ReportReportType[this] = value; }
        //}

        //[DisplayName("Report Data Source"), Expression("jReport.[DataSource]")]
        //public Int32? ReportDataSource
        //{
        //    get { return Fields.ReportDataSource[this]; }
        //    set { Fields.ReportDataSource[this] = value; }
        //}

        IIdField IIdRow.IdField
        {
            get { return Fields.OptionNo; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Caption; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ReportDialogOptionRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField ReportId;
            public Int32Field OptionNo;
            public Int32Field SeqNo;
            public StringField Caption;
            public StringField FieldName;
            public Int32Field FieldType;
            public Int32Field Style;
            public Int32Field DataType;
            public BooleanField CapsLock;
            public StringField LookupName;
            public StringField LookupFilterName;
            public BooleanField Required;

            //public StringField ReportDescription;
            //public BooleanField ReportSuspended;
            //public StringField ReportCreatedBy;
            //public DateTimeField ReportCreatedDate;
            //public StringField ReportRevisedBy;
            //public DateTimeField ReportRevisedDate;
            //public BooleanField ReportFilterBySalesmanCode;
            //public BooleanField ReportFilterByBuyerCode;
            //public Int32Field ReportReportType;
            //public Int32Field ReportDataSource;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "EnterpriseSys.ReportDialogOption";
            }
        }
    }
}
