#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VendorQuotationScheduleRow.cs
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

    [ConnectionKey("Purchasing"), TableName("[dbo].[PUQUOT]")]
    [DisplayName("Vendor Quotation Schedule"), InstanceName("Vendor Quotation Schedule"), TwoLevelCached]   
    public sealed class VendorQuotationScheduleRow : Row, IIdRow, INameRow
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

        [DisplayName("Ship No"), Column("SHIP_NO"), PrimaryKey]
        public Int16? ShipNo
        {
            get { return Fields.ShipNo[this]; }
            set { Fields.ShipNo[this] = value; }
        }

        [DisplayName("Due Date"), Column("DUE_DATE")]
        public DateTime? DueDate
        {
            get { return Fields.DueDate[this]; }
            set { Fields.DueDate[this] = value; }
        }

        [DisplayName("Sched Date"), Column("SCHED_DATE"), NotNull]
        public DateTime? SchedDate
        {
            get { return Fields.SchedDate[this]; }
            set { Fields.SchedDate[this] = value; }
        }

        [DisplayName("Ship Via"), Column("SHIP_VIA"), Size(30)]
        public String ShipVia
        {
            get { return Fields.ShipVia[this]; }
            set { Fields.ShipVia[this] = value; }
        }

        [DisplayName("Shipment Terms"), Column("SHIPMENT_TERMS"), Size(15)]
        public String ShipmentTerms
        {
            get { return Fields.ShipmentTerms[this]; }
            set { Fields.ShipmentTerms[this] = value; }
        }

        [DisplayName("Qty"), Column("QTY"), Size(14), Scale(4)]
        public Decimal? Qty
        {
            get { return Fields.Qty[this]; }
            set { Fields.Qty[this] = value; }
        }

        [DisplayName("Item No"), Column("ITEM_NO"), Size(30), NotNull]
        public String ItemNo
        {
            get { return Fields.ItemNo[this]; }
            set { Fields.ItemNo[this] = value; }
        }

        [DisplayName("Ship To"), Column("SHIP_TO"), Size(4)]
        public String ShipTo
        {
            get { return Fields.ShipTo[this]; }
            set { Fields.ShipTo[this] = value; }
        }

        [DisplayName("Uom"), Column("UOM"), Size(4)]
        public String Uom
        {
            get { return Fields.Uom[this]; }
            set { Fields.Uom[this] = value; }
        }

        [DisplayName("Lot Size"), Column("LOT_SIZE"), Size(10), Scale(4)]
        public Decimal? LotSize
        {
            get { return Fields.LotSize[this]; }
            set { Fields.LotSize[this] = value; }
        }

        [DisplayName("Vendor No"), Column("VENDOR_NO"), Size(8)]
        public String VendorNo
        {
            get { return Fields.VendorNo[this]; }
            set { Fields.VendorNo[this] = value; }
        }

        [DisplayName("Buyer"), Column("BUYER"), Size(6)]
        public String Buyer
        {
            get { return Fields.Buyer[this]; }
            set { Fields.Buyer[this] = value; }
        }

        [DisplayName("Vendor Name"), Column("VENDOR_NAME"), Size(50)]
        public String VendorName
        {
            get { return Fields.VendorName[this]; }
            set { Fields.VendorName[this] = value; }
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

        public VendorQuotationScheduleRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField OrderNo;
            public Int32Field LineNo;
            public Int16Field ShipNo;
            public DateTimeField DueDate;
            public DateTimeField SchedDate;
            public StringField ShipVia;
            public StringField ShipmentTerms;
            public DecimalField Qty;
            public StringField ItemNo;
            public StringField ShipTo;
            public StringField Uom;
            public DecimalField LotSize;
            public StringField VendorNo;
            public StringField Buyer;
            public StringField VendorName;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Purchasing.VendorQuotationSchedule";
            }
        }
    }
}
