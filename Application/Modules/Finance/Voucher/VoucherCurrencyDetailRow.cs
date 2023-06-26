#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VoucherCurrencyDetailRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Finance.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Finance"), TableName("[dbo].[GLVOUC]")]
    [DisplayName("Voucher Currency Detail"), InstanceName("Voucher Currency Detail"), TwoLevelCached]   
    public sealed class VoucherCurrencyDetailRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Voucher Type"), Column("VOUCHER_TYPE"), Size(6), PrimaryKey, QuickSearch]
        public String VoucherType
        {
            get { return Fields.VoucherType[this]; }
            set { Fields.VoucherType[this] = value; }
        }

        [DisplayName("Voucher No"), Column("VOUCHER_NO"), Size(16), PrimaryKey]
        public String VoucherNo
        {
            get { return Fields.VoucherNo[this]; }
            set { Fields.VoucherNo[this] = value; }
        }

        [DisplayName("Ccy"), Column("CCY"), Size(4), PrimaryKey]
        public String Ccy
        {
            get { return Fields.Ccy[this]; }
            set { Fields.Ccy[this] = value; }
        }

        [DisplayName("Last Exch Rate"), Column("LAST_EXCH_RATE"), Size(12), Scale(6)]
        public Decimal? LastExchRate
        {
            get { return Fields.LastExchRate[this]; }
            set { Fields.LastExchRate[this] = value; }
        }

        [DisplayName("Total Debit"), Column("TOTAL_DEBIT"), Size(16), Scale(2)]
        public Decimal? TotalDebit
        {
            get { return Fields.TotalDebit[this]; }
            set { Fields.TotalDebit[this] = value; }
        }

        [DisplayName("Total Credit"), Column("TOTAL_CREDIT"), Size(16), Scale(2)]
        public Decimal? TotalCredit
        {
            get { return Fields.TotalCredit[this]; }
            set { Fields.TotalCredit[this] = value; }
        }

        [DisplayName("Owner Branch"), Column("OWNER_BRANCH"), Size(4)]
        public String OwnerBranch
        {
            get { return Fields.OwnerBranch[this]; }
            set { Fields.OwnerBranch[this] = value; }
        }

        [DisplayName("Source Branch"), Column("SOURCE_BRANCH"), Size(4)]
        public String SourceBranch
        {
            get { return Fields.SourceBranch[this]; }
            set { Fields.SourceBranch[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.VoucherType; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public VoucherCurrencyDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField VoucherType;
            public StringField VoucherNo;
            public StringField Ccy;
            public DecimalField LastExchRate;
            public DecimalField TotalDebit;
            public DecimalField TotalCredit;
            public StringField OwnerBranch;
            public StringField SourceBranch;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Finance.VoucherCurrencyDetail";
            }
        }
    }
}
