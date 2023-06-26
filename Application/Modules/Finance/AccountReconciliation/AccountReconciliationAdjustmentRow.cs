#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountReconciliationAdjustmentRow.cs
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

    [ConnectionKey("Finance"), TableName("[dbo].[GLRECA]")]
    [DisplayName("Account Reconciliation Adjustment"), InstanceName("Account Reconciliation Adjustment"), TwoLevelCached]   
    public sealed class AccountReconciliationAdjustmentRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Adj Acct No"), Column("ADJ_ACCT_NO"), Size(30), PrimaryKey, QuickSearch]
        public String AdjAcctNo
        {
            get { return Fields.AdjAcctNo[this]; }
            set { Fields.AdjAcctNo[this] = value; }
        }

        [DisplayName("Ref No"), Column("REF_NO"), Size(12), PrimaryKey]
        public String RefNo
        {
            get { return Fields.RefNo[this]; }
            set { Fields.RefNo[this] = value; }
        }

        [DisplayName("Line No"), Column("LINE_NO"), Size(6), PrimaryKey]
        public Decimal? LineNo
        {
            get { return Fields.LineNo[this]; }
            set { Fields.LineNo[this] = value; }
        }

        [DisplayName("Acct No"), Column("ACCT_NO"), Size(30)]
        public String AcctNo
        {
            get { return Fields.AcctNo[this]; }
            set { Fields.AcctNo[this] = value; }
        }

        [DisplayName("Cost Centre"), Column("COST_CENTRE"), Size(4)]
        public String CostCentre
        {
            get { return Fields.CostCentre[this]; }
            set { Fields.CostCentre[this] = value; }
        }

        [DisplayName("Dept"), Column("DEPT"), Size(4)]
        public String Dept
        {
            get { return Fields.Dept[this]; }
            set { Fields.Dept[this] = value; }
        }

        [DisplayName("Line Ref"), Column("LINE_REF"), Size(20)]
        public String LineRef
        {
            get { return Fields.LineRef[this]; }
            set { Fields.LineRef[this] = value; }
        }

        [DisplayName("Ccy"), Column("CCY"), Size(4)]
        public String Ccy
        {
            get { return Fields.Ccy[this]; }
            set { Fields.Ccy[this] = value; }
        }

        [DisplayName("Exch Rate"), Column("EXCH_RATE"), Size(12), Scale(6)]
        public Decimal? ExchRate
        {
            get { return Fields.ExchRate[this]; }
            set { Fields.ExchRate[this] = value; }
        }

        [DisplayName("Debit"), Column("DEBIT"), Size(16), Scale(2)]
        public Decimal? Debit
        {
            get { return Fields.Debit[this]; }
            set { Fields.Debit[this] = value; }
        }

        [DisplayName("Credit"), Column("CREDIT"), Size(16), Scale(2)]
        public Decimal? Credit
        {
            get { return Fields.Credit[this]; }
            set { Fields.Credit[this] = value; }
        }

        [DisplayName("Comp Ldg Debit"), Column("COMP_LDG_DEBIT"), Size(16), Scale(2)]
        public Decimal? CompLdgDebit
        {
            get { return Fields.CompLdgDebit[this]; }
            set { Fields.CompLdgDebit[this] = value; }
        }

        [DisplayName("Comp Ldg Credit"), Column("COMP_LDG_CREDIT"), Size(16), Scale(2)]
        public Decimal? CompLdgCredit
        {
            get { return Fields.CompLdgCredit[this]; }
            set { Fields.CompLdgCredit[this] = value; }
        }

        [DisplayName("Ledger Debit"), Column("LEDGER_DEBIT"), Size(16), Scale(2)]
        public Decimal? LedgerDebit
        {
            get { return Fields.LedgerDebit[this]; }
            set { Fields.LedgerDebit[this] = value; }
        }

        [DisplayName("Ledger Credit"), Column("LEDGER_CREDIT"), Size(16), Scale(2)]
        public Decimal? LedgerCredit
        {
            get { return Fields.LedgerCredit[this]; }
            set { Fields.LedgerCredit[this] = value; }
        }

        [DisplayName("Anlys1"), Column("ANLYS1"), Size(30)]
        public String Anlys1
        {
            get { return Fields.Anlys1[this]; }
            set { Fields.Anlys1[this] = value; }
        }

        [DisplayName("Anlys2"), Column("ANLYS2"), Size(30)]
        public String Anlys2
        {
            get { return Fields.Anlys2[this]; }
            set { Fields.Anlys2[this] = value; }
        }

        [DisplayName("Anlys3"), Column("ANLYS3"), Size(30)]
        public String Anlys3
        {
            get { return Fields.Anlys3[this]; }
            set { Fields.Anlys3[this] = value; }
        }

        [DisplayName("Anlys4"), Column("ANLYS4"), Size(30)]
        public String Anlys4
        {
            get { return Fields.Anlys4[this]; }
            set { Fields.Anlys4[this] = value; }
        }

        [DisplayName("Anlys5"), Column("ANLYS5"), Size(30)]
        public String Anlys5
        {
            get { return Fields.Anlys5[this]; }
            set { Fields.Anlys5[this] = value; }
        }

        [DisplayName("Anlys6"), Column("ANLYS6"), Size(30)]
        public String Anlys6
        {
            get { return Fields.Anlys6[this]; }
            set { Fields.Anlys6[this] = value; }
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

        [DisplayName("Particulars"), Column("PARTICULARS"), Size(1073741823)]
        public String Particulars
        {
            get { return Fields.Particulars[this]; }
            set { Fields.Particulars[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.AdjAcctNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AccountReconciliationAdjustmentRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField AdjAcctNo;
            public StringField RefNo;
            public DecimalField LineNo;
            public StringField AcctNo;
            public StringField CostCentre;
            public StringField Dept;
            public StringField LineRef;
            public StringField Ccy;
            public DecimalField ExchRate;
            public DecimalField Debit;
            public DecimalField Credit;
            public DecimalField CompLdgDebit;
            public DecimalField CompLdgCredit;
            public DecimalField LedgerDebit;
            public DecimalField LedgerCredit;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField Anlys3;
            public StringField Anlys4;
            public StringField Anlys5;
            public StringField Anlys6;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField Particulars;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Finance.AccountReconciliationAdjustment";
            }
        }
    }
}
