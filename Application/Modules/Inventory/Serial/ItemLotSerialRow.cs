#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ItemLotSerialRow.cs
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

    [ConnectionKey("Inventory"), TableName("[dbo].[ICSERS]")]
    [DisplayName("Item Lot Serial"), InstanceName("Item Lot Serial"), TwoLevelCached]
    [LookupScript(typeof(Matrix.Inventory.Columns.ItemLookup))]
    public sealed class ItemLotSerialRow : Row, IIdRow, INameRow
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

        [DisplayName("Serial No"), Column("SERIAL_NO"), Size(40), PrimaryKey]
        public String SerialNo
        {
            get { return Fields.SerialNo[this]; }
            set { Fields.SerialNo[this] = value; }
        }

        [DisplayName("Loc"), Column("LOC"), Size(4), NotNull]
        public String Loc
        {
            get { return Fields.Loc[this]; }
            set { Fields.Loc[this] = value; }
        }

        [DisplayName("Bin No"), Column("BIN_NO"), Size(30), NotNull]
        public String BinNo
        {
            get { return Fields.BinNo[this]; }
            set { Fields.BinNo[this] = value; }
        }

        [DisplayName("Lot No"), Column("LOT_NO"), Size(30), NotNull]
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

        [DisplayName("Expiry Date"), Column("EXPIRY_DATE")]
        public DateTime? ExpiryDate
        {
            get { return Fields.ExpiryDate[this]; }
            set { Fields.ExpiryDate[this] = value; }
        }

        [DisplayName("Source Type"), Column("SOURCE_TYPE"), Size(16)]
        public String SourceType
        {
            get { return Fields.SourceType[this]; }
            set { Fields.SourceType[this] = value; }
        }

        [DisplayName("Source Ref"), Column("SOURCE_REF"), Size(16)]
        public String SourceRef
        {
            get { return Fields.SourceRef[this]; }
            set { Fields.SourceRef[this] = value; }
        }

        [DisplayName("Source Entry No"), Column("SOURCE_ENTRY_NO"), Size(6)]
        public Decimal? SourceEntryNo
        {
            get { return Fields.SourceEntryNo[this]; }
            set { Fields.SourceEntryNo[this] = value; }
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

        public ItemLotSerialRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField ItemNo;
            public StringField SerialNo;
            public StringField Loc;
            public StringField BinNo;
            public StringField LotNo;
            public StringField Closed;
            public DateTimeField ExpiryDate;
            public StringField SourceType;
            public StringField SourceRef;
            public DecimalField SourceEntryNo;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Inventory.ItemLotSerial";
            }
        }
    }
}
