#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  StockLedgerRow.cs
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

    [ConnectionKey("Inventory"), TableName("[dbo].[ICLEDG]")]
    [DisplayName("Stock Ledger"), InstanceName("Stock Ledger"), TwoLevelCached]   
    public sealed class StockLedgerRow : Row, IIdRow, INameRow
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

        [DisplayName("Loc 2"), Column("LOC_2"), Size(4), NotNull]
        public String Loc2
        {
            get { return Fields.Loc2[this]; }
            set { Fields.Loc2[this] = value; }
        }

        [DisplayName("Item No 2"), Column("ITEM_NO_2"), Size(30), NotNull]
        public String ItemNo2
        {
            get { return Fields.ItemNo2[this]; }
            set { Fields.ItemNo2[this] = value; }
        }

        [DisplayName("Period 2"), Column("PERIOD_2"), Size(7), NotNull]
        public String Period2
        {
            get { return Fields.Period2[this]; }
            set { Fields.Period2[this] = value; }
        }

        [DisplayName("Fiscal Year"), Column("FISCAL_YEAR"), Size(4)]
        public Decimal? FiscalYear
        {
            get { return Fields.FiscalYear[this]; }
            set { Fields.FiscalYear[this] = value; }
        }

        [DisplayName("Period No"), Column("PERIOD_NO"), Size(2)]
        public Decimal? PeriodNo
        {
            get { return Fields.PeriodNo[this]; }
            set { Fields.PeriodNo[this] = value; }
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

        [DisplayName("Qty Out Alloc"), Column("QTY_OUT_ALLOC"), Size(16), Scale(4)]
        public Decimal? QtyOutAlloc
        {
            get { return Fields.QtyOutAlloc[this]; }
            set { Fields.QtyOutAlloc[this] = value; }
        }

        [DisplayName("Cost In"), Column("COST_IN"), Size(16), Scale(2)]
        public Decimal? CostIn
        {
            get { return Fields.CostIn[this]; }
            set { Fields.CostIn[this] = value; }
        }

        [DisplayName("Cost Out"), Column("COST_OUT"), Size(16), Scale(2)]
        public Decimal? CostOut
        {
            get { return Fields.CostOut[this]; }
            set { Fields.CostOut[this] = value; }
        }

        [DisplayName("Qty In Trf"), Column("QTY_IN_TRF"), Size(16), Scale(4)]
        public Decimal? QtyInTrf
        {
            get { return Fields.QtyInTrf[this]; }
            set { Fields.QtyInTrf[this] = value; }
        }

        [DisplayName("Qty Out Trf"), Column("QTY_OUT_TRF"), Size(16), Scale(4)]
        public Decimal? QtyOutTrf
        {
            get { return Fields.QtyOutTrf[this]; }
            set { Fields.QtyOutTrf[this] = value; }
        }

        [DisplayName("Cost In Trf"), Column("COST_IN_TRF"), Size(16), Scale(2)]
        public Decimal? CostInTrf
        {
            get { return Fields.CostInTrf[this]; }
            set { Fields.CostInTrf[this] = value; }
        }

        [DisplayName("Cost Out Trf"), Column("COST_OUT_TRF"), Size(16), Scale(2)]
        public Decimal? CostOutTrf
        {
            get { return Fields.CostOutTrf[this]; }
            set { Fields.CostOutTrf[this] = value; }
        }

        [DisplayName("Qty Beg"), Column("QTY_BEG"), Size(16), Scale(4)]
        public Decimal? QtyBeg
        {
            get { return Fields.QtyBeg[this]; }
            set { Fields.QtyBeg[this] = value; }
        }

        [DisplayName("Qty End"), Column("QTY_END"), Size(16), Scale(4)]
        public Decimal? QtyEnd
        {
            get { return Fields.QtyEnd[this]; }
            set { Fields.QtyEnd[this] = value; }
        }

        [DisplayName("Value Beg"), Column("VALUE_BEG"), Size(16), Scale(2)]
        public Decimal? ValueBeg
        {
            get { return Fields.ValueBeg[this]; }
            set { Fields.ValueBeg[this] = value; }
        }

        [DisplayName("Value End"), Column("VALUE_END"), Size(16), Scale(2)]
        public Decimal? ValueEnd
        {
            get { return Fields.ValueEnd[this]; }
            set { Fields.ValueEnd[this] = value; }
        }

        [DisplayName("Ledger"),Expression("(t0.Loc + ' ' + t0.ItemNo+'' + t0.Period)"), QuickSearch]
        public String Fullname
        {
            get { return Fields.Fullname[this]; }
            set { Fields.Fullname[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Fullname; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public StockLedgerRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public readonly StringField Fullname;

            public DecimalField Recnum;
            public StringField Loc;
            public StringField ItemNo;
            public StringField Period;
            public StringField Loc2;
            public StringField ItemNo2;
            public StringField Period2;
            public DecimalField FiscalYear;
            public DecimalField PeriodNo;
            public DecimalField QtyIn;
            public DecimalField QtyOut;
            public DecimalField QtyOutAlloc;
            public DecimalField CostIn;
            public DecimalField CostOut;
            public DecimalField QtyInTrf;
            public DecimalField QtyOutTrf;
            public DecimalField CostInTrf;
            public DecimalField CostOutTrf;
            public DecimalField QtyBeg;
            public DecimalField QtyEnd;
            public DecimalField ValueBeg;
            public DecimalField ValueEnd;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Inventory.StockLedger";
            }
        }
    }
}
