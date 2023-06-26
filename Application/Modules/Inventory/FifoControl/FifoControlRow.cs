#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  FifoControlRow.cs
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

    [ConnectionKey("Inventory"), TableName("[dbo].[ICFIFO]")]
    [DisplayName("Fifo Control"), InstanceName("Fifo Control"), TwoLevelCached]   
    public sealed class FifoControlRow : Row, INameRow, IIdRow
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

        [DisplayName("Allocated"), Column("ALLOCATED"), Size(1), PrimaryKey]
        public String Allocated
        {
            get { return Fields.Allocated[this]; }
            set { Fields.Allocated[this] = value; }
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

        [DisplayName("Log No Out"), Column("LOG_NO_OUT"), Size(8), PrimaryKey]
        public Decimal? LogNoOut
        {
            get { return Fields.LogNoOut[this]; }
            set { Fields.LogNoOut[this] = value; }
        }

        [DisplayName("Line No Out"), Column("LINE_NO_OUT"), Size(8), PrimaryKey]
        public Decimal? LineNoOut
        {
            get { return Fields.LineNoOut[this]; }
            set { Fields.LineNoOut[this] = value; }
        }

        [DisplayName("Qty"), Column("QTY"), Size(16), Scale(4)]
        public Decimal? Qty
        {
            get { return Fields.Qty[this]; }
            set { Fields.Qty[this] = value; }
        }

        [DisplayName("Cost"), Column("COST"), Size(18), Scale(6)]
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

        public FifoControlRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField Loc;
            public StringField ItemNo;
            public StringField Allocated;
            public DateTimeField ValueDate;
            public DecimalField LogNo;
            public DecimalField LineNo;
            public DecimalField LogNoOut;
            public DecimalField LineNoOut;
            public DecimalField Qty;
            public DecimalField Cost;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Inventory.FifoControl";
            }
        }
    }
}
