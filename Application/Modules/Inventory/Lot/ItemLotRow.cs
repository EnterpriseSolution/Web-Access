#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ItemLotRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Inventory.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Inventory"), TableName("[dbo].[ICLOTS]")]
    [DisplayName("Item Lot"), InstanceName("Item Lot"), TwoLevelCached]
    [LookupScript(typeof(Matrix.Modules.Administration.Company.ItemLookup))]
    public sealed class ItemLotRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Item No"), Column("ITEM_NO"), Size(30), PrimaryKey, QuickSearch]
        public String ItemNo
        {
            get { return Fields.ItemNo[this]; }
            set { Fields.ItemNo[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(60)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Loc"), Column("LOC"), Size(4), PrimaryKey]
        public String Loc
        {
            get { return Fields.Loc[this]; }
            set { Fields.Loc[this] = value; }
        }

        [DisplayName("Bin No"), Column("BIN_NO"), Size(30), PrimaryKey]
        public String BinNo
        {
            get { return Fields.BinNo[this]; }
            set { Fields.BinNo[this] = value; }
        }

        [DisplayName("Lot No"), Column("LOT_NO"), Size(30), PrimaryKey]
        public String LotNo
        {
            get { return Fields.LotNo[this]; }
            set { Fields.LotNo[this] = value; }
        }

        [DisplayName("Closed"), Column("CLOSED"), Size(1), NotNull]
        public String Closed
        {
            get { return Fields.Closed[this]; }
            set { Fields.Closed[this] = value; }
        }

        [DisplayName("Loc Summary"), Column("LOC_SUMMARY"), Size(1), NotNull]
        public String LocSummary
        {
            get { return Fields.LocSummary[this]; }
            set { Fields.LocSummary[this] = value; }
        }

        [DisplayName("Qty Shipped"), Column("QTY_SHIPPED"), Size(16), Scale(4)]
        public Decimal? QtyShipped
        {
            get { return Fields.QtyShipped[this]; }
            set { Fields.QtyShipped[this] = value; }
        }

        [DisplayName("Qty Received"), Column("QTY_RECEIVED"), Size(16), Scale(4)]
        public Decimal? QtyReceived
        {
            get { return Fields.QtyReceived[this]; }
            set { Fields.QtyReceived[this] = value; }
        }

        [DisplayName("Qty Issued"), Column("QTY_ISSUED"), Size(16), Scale(4)]
        public Decimal? QtyIssued
        {
            get { return Fields.QtyIssued[this]; }
            set { Fields.QtyIssued[this] = value; }
        }

        [DisplayName("Qty Finished"), Column("QTY_FINISHED"), Size(16), Scale(4)]
        public Decimal? QtyFinished
        {
            get { return Fields.QtyFinished[this]; }
            set { Fields.QtyFinished[this] = value; }
        }

        [DisplayName("Qty Balance"), Column("QTY_BALANCE"), Size(16), Scale(4)]
        public Decimal? QtyBalance
        {
            get { return Fields.QtyBalance[this]; }
            set { Fields.QtyBalance[this] = value; }
        }

        [DisplayName("Expiry Date"), Column("EXPIRY_DATE")]
        public DateTime? ExpiryDate
        {
            get { return Fields.ExpiryDate[this]; }
            set { Fields.ExpiryDate[this] = value; }
        }

        [DisplayName("Uom"), Column("UOM"), Size(4)]
        public String Uom
        {
            get { return Fields.Uom[this]; }
            set { Fields.Uom[this] = value; }
        }

        [DisplayName("Remarks"), Column("REMARKS"), Size(1073741823)]
        public String Remarks
        {
            get { return Fields.Remarks[this]; }
            set { Fields.Remarks[this] = value; }
        }

        [DisplayName("Unit Cost"), Column("UNIT_COST"), Size(18), Scale(6)]
        public Decimal? UnitCost
        {
            get { return Fields.UnitCost[this]; }
            set { Fields.UnitCost[this] = value; }
        }

        [DisplayName("User Defined Field 01"), Column("USER_DEFINED_FIELD_01"), Size(100)]
        public String UserDefinedField01
        {
            get { return Fields.UserDefinedField01[this]; }
            set { Fields.UserDefinedField01[this] = value; }
        }

        [DisplayName("User Defined Field 02"), Column("USER_DEFINED_FIELD_02"), Size(100)]
        public String UserDefinedField02
        {
            get { return Fields.UserDefinedField02[this]; }
            set { Fields.UserDefinedField02[this] = value; }
        }

        [DisplayName("User Defined Field 03"), Column("USER_DEFINED_FIELD_03"), Size(100)]
        public String UserDefinedField03
        {
            get { return Fields.UserDefinedField03[this]; }
            set { Fields.UserDefinedField03[this] = value; }
        }

        [DisplayName("User Defined Field 04"), Column("USER_DEFINED_FIELD_04"), Size(100)]
        public String UserDefinedField04
        {
            get { return Fields.UserDefinedField04[this]; }
            set { Fields.UserDefinedField04[this] = value; }
        }

        [DisplayName("User Defined Field 05"), Column("USER_DEFINED_FIELD_05"), Size(100)]
        public String UserDefinedField05
        {
            get { return Fields.UserDefinedField05[this]; }
            set { Fields.UserDefinedField05[this] = value; }
        }

        [DisplayName("Fifo Log No"), Column("FIFO_LOG_NO"), Size(8)]
        public Decimal? FifoLogNo
        {
            get { return Fields.FifoLogNo[this]; }
            set { Fields.FifoLogNo[this] = value; }
        }

        [DisplayName("Fifo Line No"), Column("FIFO_LINE_NO"), Size(6)]
        public Decimal? FifoLineNo
        {
            get { return Fields.FifoLineNo[this]; }
            set { Fields.FifoLineNo[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ItemNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ItemLotRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField ItemNo;
            public StringField Description;
            public StringField Loc;
            public StringField BinNo;
            public StringField LotNo;
            public StringField Closed;
            public StringField LocSummary;
            public DecimalField QtyShipped;
            public DecimalField QtyReceived;
            public DecimalField QtyIssued;
            public DecimalField QtyFinished;
            public DecimalField QtyBalance;
            public DateTimeField ExpiryDate;
            public StringField Uom;
            public StringField Remarks;
            public DecimalField UnitCost;
            public StringField UserDefinedField01;
            public StringField UserDefinedField02;
            public StringField UserDefinedField03;
            public StringField UserDefinedField04;
            public StringField UserDefinedField05;
            public DecimalField FifoLogNo;
            public DecimalField FifoLineNo;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Inventory.ItemLot";
            }
        }
    }
}
