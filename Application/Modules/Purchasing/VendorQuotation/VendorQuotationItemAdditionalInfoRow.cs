#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VendorQuotationItemAdditionalInfoRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Purchasing.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Purchasing"), TableName("[dbo].[PUQUOI]")]
    [DisplayName("Vendor Quotation Item Additional Info"), InstanceName("Vendor Quotation Item Additional Info"), TwoLevelCached]   
    public sealed class VendorQuotationItemAdditionalInfoRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(28), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Order No"), Column("ORDER_NO"), Size(16), PrimaryKey, QuickSearch]
        public String OrderNo
        {
            get { return Fields.OrderNo[this]; }
            set { Fields.OrderNo[this] = value; }
        }

        [DisplayName("Line No"), Column("LINE_NO"), PrimaryKey]
        public Int32? LineNo
        {
            get { return Fields.LineNo[this]; }
            set { Fields.LineNo[this] = value; }
        }

        [DisplayName("Entry No"), Column("ENTRY_NO"), PrimaryKey]
        public Int32? EntryNo
        {
            get { return Fields.EntryNo[this]; }
            set { Fields.EntryNo[this] = value; }
        }

        [DisplayName("Caption"), Column("CAPTION"), Size(100)]
        public String Caption
        {
            get { return Fields.Caption[this]; }
            set { Fields.Caption[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(250)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Bitmap Path"), Column("BITMAP_PATH"), Size(255)]
        public String BitmapPath
        {
            get { return Fields.BitmapPath[this]; }
            set { Fields.BitmapPath[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.OrderNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public VendorQuotationItemAdditionalInfoRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField OrderNo;
            public Int32Field LineNo;
            public Int32Field EntryNo;
            public StringField Caption;
            public StringField Description;
            public StringField BitmapPath;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Purchasing.VendorQuotationItemAdditionalInfo";
            }
        }
    }
}
