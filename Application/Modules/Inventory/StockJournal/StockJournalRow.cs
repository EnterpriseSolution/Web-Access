#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  StockJournalRow.cs
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

    [ConnectionKey("Inventory"), TableName("[dbo].[ICJRNL]")]
    [DisplayName("Stock Journal"), InstanceName("Stock Journal"), TwoLevelCached]
    public sealed class StockJournalRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Loc"), Column("LOC"), Size(4), PrimaryKey, QuickSearch]
        public String Loc
        {
            get { return Fields.Loc[this]; }
            set { Fields.Loc[this] = value; }
        }

        [DisplayName("Item No"), Column("ITEM_NO"), Size(30), PrimaryKey]
        public String ItemNo
        {
            get { return Fields.ItemNo[this]; }
            set { Fields.ItemNo[this] = value; }
        }

        [DisplayName("Period"), Column("PERIOD"), Size(7), PrimaryKey]
        public String Period
        {
            get { return Fields.Period[this]; }
            set { Fields.Period[this] = value; }
        }

        [DisplayName("Value Date"), Column("VALUE_DATE"), PrimaryKey]
        public DateTime? ValueDate
        {
            get { return Fields.ValueDate[this]; }
            set { Fields.ValueDate[this] = value; }
        }

        [DisplayName("Log No"), Column("LOG_NO"), Size(8), PrimaryKey]
        public Decimal? LogNo
        {
            get { return Fields.LogNo[this]; }
            set { Fields.LogNo[this] = value; }
        }

        [DisplayName("Line No"), Column("LINE_NO"), Size(6), PrimaryKey]
        public Decimal? LineNo
        {
            get { return Fields.LineNo[this]; }
            set { Fields.LineNo[this] = value; }
        }

        [DisplayName("Move In"), Column("MOVE_IN"), Size(1), PrimaryKey]
        public String MoveIn
        {
            get { return Fields.MoveIn[this]; }
            set { Fields.MoveIn[this] = value; }
        }

        [DisplayName("Ref No"), Column("REF_NO"), Size(16), NotNull]
        public String RefNo
        {
            get { return Fields.RefNo[this]; }
            set { Fields.RefNo[this] = value; }
        }

        [DisplayName("Qty In"), Column("QTY_IN"), Size(16), Scale(4)]
        public Decimal? QtyIn
        {
            get { return Fields.QtyIn[this]; }
            set { Fields.QtyIn[this] = value; }
        }

        [DisplayName("Qty Out"), Column("QTY_OUT"), Size(16), Scale(4)]
        public Decimal? QtyOut
        {
            get { return Fields.QtyOut[this]; }
            set { Fields.QtyOut[this] = value; }
        }

        [DisplayName("Cost In"), Column("COST_IN"), Size(14), Scale(2)]
        public Decimal? CostIn
        {
            get { return Fields.CostIn[this]; }
            set { Fields.CostIn[this] = value; }
        }

        [DisplayName("Cost Out"), Column("COST_OUT"), Size(14), Scale(2)]
        public Decimal? CostOut
        {
            get { return Fields.CostOut[this]; }
            set { Fields.CostOut[this] = value; }
        }

        [DisplayName("Move Date"), Column("MOVE_DATE")]
        public DateTime? MoveDate
        {
            get { return Fields.MoveDate[this]; }
            set { Fields.MoveDate[this] = value; }
        }

        [DisplayName("Line Ref"), Column("LINE_REF"), Size(16)]
        public String LineRef
        {
            get { return Fields.LineRef[this]; }
            set { Fields.LineRef[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(30)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Move Type"), Column("MOVE_TYPE"), Size(6)]
        public String MoveType
        {
            get { return Fields.MoveType[this]; }
            set { Fields.MoveType[this] = value; }
        }

        [DisplayName("Reference"), Column("REFERENCE"), Size(30)]
        public String Reference
        {
            get { return Fields.Reference[this]; }
            set { Fields.Reference[this] = value; }
        }

        [DisplayName("Transfer"), Column("TRANSFER"), Size(1)]
        public String Transfer
        {
            get { return Fields.Transfer[this]; }
            set { Fields.Transfer[this] = value; }
        }

        [DisplayName("From To"), Column("FROM_TO"), Size(60)]
        public String FromTo
        {
            get { return Fields.FromTo[this]; }
            set { Fields.FromTo[this] = value; }
        }

        [DisplayName("Bal Qty"), Column("BAL_QTY"), Size(16), Scale(4)]
        public Decimal? BalQty
        {
            get { return Fields.BalQty[this]; }
            set { Fields.BalQty[this] = value; }
        }

        [DisplayName("Bal Cost"), Column("BAL_COST"), Size(16), Scale(2)]
        public Decimal? BalCost
        {
            get { return Fields.BalCost[this]; }
            set { Fields.BalCost[this] = value; }
        }

        [DisplayName("Bal Qty Item"), Column("BAL_QTY_ITEM"), Size(16), Scale(4)]
        public Decimal? BalQtyItem
        {
            get { return Fields.BalQtyItem[this]; }
            set { Fields.BalQtyItem[this] = value; }
        }

        [DisplayName("Bal Cost Item"), Column("BAL_COST_ITEM"), Size(16), Scale(2)]
        public Decimal? BalCostItem
        {
            get { return Fields.BalCostItem[this]; }
            set { Fields.BalCostItem[this] = value; }
        }

        [DisplayName("Unit Cost"), Column("UNIT_COST"), Size(18), Scale(6)]
        public Decimal? UnitCost
        {
            get { return Fields.UnitCost[this]; }
            set { Fields.UnitCost[this] = value; }
        }

        [DisplayName("Quantity"), Size(18), Scale(4),AlignRight]
        [Expression("(CASE MOVE_IN WHEN 'Y' THEN  QTY_IN ELSE  QTY_OUT END)")]
        public Decimal? Quantity
        {
            get  {  return Fields.Quantity[this];  }
            set  {   Fields.Quantity[this] = value; }
        }

        [DisplayName("Cost"), Size(18), Scale(4), AlignRight]
        [Expression("(CASE MOVE_IN WHEN 'Y' THEN  COST_IN ELSE  COST_OUT  END)")]
        public Decimal? Cost
        {
            get { return Fields.Cost[this]; }
            set { Fields.Cost[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Loc; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public StockJournalRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField Loc;
            public StringField ItemNo;
            public StringField Period;
            public DateTimeField ValueDate;
            public DecimalField LogNo;
            public DecimalField LineNo;
            public StringField MoveIn;
            public StringField RefNo;
            public DecimalField QtyIn;
            public DecimalField QtyOut;
            public DecimalField CostIn;
            public DecimalField CostOut;
            public DateTimeField MoveDate;
            public StringField LineRef;
            public StringField Description;
            public StringField MoveType;
            public StringField Reference;
            public StringField Transfer;
            public StringField FromTo;
            public DecimalField BalQty;
            public DecimalField BalCost;
            public DecimalField BalQtyItem;
            public DecimalField BalCostItem;
            public DecimalField UnitCost;

            public DecimalField Quantity;
            public DecimalField Cost;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Inventory.StockJournal";
            }
        }
    }
}
