#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CommodityRow.cs
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

    [ConnectionKey("MasterData"), TableName("[dbo].[GBCOMM]")]
    [DisplayName("Commodity"), InstanceName("Commodity"), TwoLevelCached]   
    public sealed class CommodityRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(28), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Custom Prod Code"), Column("CUSTOM_PROD_CODE"), Size(30), PrimaryKey, QuickSearch]
        public String CustomProdCode
        {
            get { return Fields.CustomProdCode[this]; }
            set { Fields.CustomProdCode[this] = value; }
        }

        [DisplayName("Custom Serial No"), Column("CUSTOM_SERIAL_NO"), Size(9)]
        public String CustomSerialNo
        {
            get { return Fields.CustomSerialNo[this]; }
            set { Fields.CustomSerialNo[this] = value; }
        }

        [DisplayName("Custom Prod Desc"), Column("CUSTOM_PROD_DESC"), Size(50)]
        public String CustomProdDesc
        {
            get { return Fields.CustomProdDesc[this]; }
            set { Fields.CustomProdDesc[this] = value; }
        }

        [DisplayName("Custom Prod No"), Column("CUSTOM_PROD_NO"), Size(50)]
        public String CustomProdNo
        {
            get { return Fields.CustomProdNo[this]; }
            set { Fields.CustomProdNo[this] = value; }
        }

        [DisplayName("Custom Eng"), Column("CUSTOM_ENG"), Size(50)]
        public String CustomEng
        {
            get { return Fields.CustomEng[this]; }
            set { Fields.CustomEng[this] = value; }
        }

        [DisplayName("Custom Eng No"), Column("CUSTOM_ENG_NO"), Size(50)]
        public String CustomEngNo
        {
            get { return Fields.CustomEngNo[this]; }
            set { Fields.CustomEngNo[this] = value; }
        }

        [DisplayName("Custom Meas Uom"), Column("CUSTOM_MEAS_UOM"), Size(16)]
        public String CustomMeasUom
        {
            get { return Fields.CustomMeasUom[this]; }
            set { Fields.CustomMeasUom[this] = value; }
        }

        [DisplayName("Custom Ccy"), Column("CUSTOM_CCY"), Size(16)]
        public String CustomCcy
        {
            get { return Fields.CustomCcy[this]; }
            set { Fields.CustomCcy[this] = value; }
        }

        [DisplayName("Custom Price"), Column("CUSTOM_PRICE"), Size(14), Scale(4)]
        public Decimal? CustomPrice
        {
            get { return Fields.CustomPrice[this]; }
            set { Fields.CustomPrice[this] = value; }
        }

        [DisplayName("Custom Exempt"), Column("CUSTOM_EXEMPT"), Size(1)]
        public String CustomExempt
        {
            get { return Fields.CustomExempt[this]; }
            set { Fields.CustomExempt[this] = value; }
        }

        [DisplayName("Custom Fee"), Column("CUSTOM_FEE"), Size(14), Scale(4)]
        public Decimal? CustomFee
        {
            get { return Fields.CustomFee[this]; }
            set { Fields.CustomFee[this] = value; }
        }

        [DisplayName("Custom Remark"), Column("CUSTOM_REMARK"), Size(100)]
        public String CustomRemark
        {
            get { return Fields.CustomRemark[this]; }
            set { Fields.CustomRemark[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        [BoolStringConverter]
        public bool? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Created Date"), Column("CREATED_DATE")]
        public DateTime? CreatedDate
        {
            get { return Fields.CreatedDate[this]; }
            set { Fields.CreatedDate[this] = value; }
        }

        [DisplayName("Created By"), Column("CREATED_BY"), Size(10)]
        public String CreatedBy
        {
            get { return Fields.CreatedBy[this]; }
            set { Fields.CreatedBy[this] = value; }
        }

        [DisplayName("Revised Date"), Column("REVISED_DATE")]
        public DateTime? RevisedDate
        {
            get { return Fields.RevisedDate[this]; }
            set { Fields.RevisedDate[this] = value; }
        }

        [DisplayName("Revised By"), Column("REVISED_BY"), Size(10)]
        public String RevisedBy
        {
            get { return Fields.RevisedBy[this]; }
            set { Fields.RevisedBy[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CustomProdCode; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CommodityRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField CustomProdCode;
            public StringField CustomSerialNo;
            public StringField CustomProdDesc;
            public StringField CustomProdNo;
            public StringField CustomEng;
            public StringField CustomEngNo;
            public StringField CustomMeasUom;
            public StringField CustomCcy;
            public DecimalField CustomPrice;
            public StringField CustomExempt;
            public DecimalField CustomFee;
            public StringField CustomRemark;
            public BooleanField Suspended;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.Commodity";
            }
        }
    }
}
