#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  LedgerSummaryRow.cs
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

    [ConnectionKey("Finance"), TableName("[dbo].[GLLEDG]")]
    [DisplayName("Ledger Summary"), InstanceName("Ledger Summary"), TwoLevelCached]   
    public sealed class LedgerSummaryRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Acct No"), Column("ACCT_NO"), Size(30), PrimaryKey, ForeignKey("[dbo].[GBACCT]", "ACCT_NO"), LeftJoin("jAcctNo"), QuickSearch, TextualField("AcctNoAcctName")]
        public String AcctNo
        {
            get { return Fields.AcctNo[this]; }
            set { Fields.AcctNo[this] = value; }
        }

        [DisplayName("Period"), Column("PERIOD"), Size(7), PrimaryKey]
        public String Period
        {
            get { return Fields.Period[this]; }
            set { Fields.Period[this] = value; }
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

        [DisplayName("Bal Beg"), Column("BAL_BEG"), Size(16), Scale(2)]
        public Decimal? BalBeg
        {
            get { return Fields.BalBeg[this]; }
            set { Fields.BalBeg[this] = value; }
        }

        [DisplayName("Bal Beg Sign"), Column("BAL_BEG_SIGN"), Size(6)]
        public String BalBegSign
        {
            get { return Fields.BalBegSign[this]; }
            set { Fields.BalBegSign[this] = value; }
        }

        [DisplayName("Bal End"), Column("BAL_END"), Size(16), Scale(2)]
        public Decimal? BalEnd
        {
            get { return Fields.BalEnd[this]; }
            set { Fields.BalEnd[this] = value; }
        }

        [DisplayName("Bal End Sign"), Column("BAL_END_SIGN"), Size(6)]
        public String BalEndSign
        {
            get { return Fields.BalEndSign[this]; }
            set { Fields.BalEndSign[this] = value; }
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

        [DisplayName("Acct No Recnum"), Expression("jAcctNo.[RECNUM]")]
        public Decimal? AcctNoRecnum
        {
            get { return Fields.AcctNoRecnum[this]; }
            set { Fields.AcctNoRecnum[this] = value; }
        }

        [DisplayName("Acct No Acct Name"), Expression("jAcctNo.[ACCT_NAME]")]
        public String AcctNoAcctName
        {
            get { return Fields.AcctNoAcctName[this]; }
            set { Fields.AcctNoAcctName[this] = value; }
        }

        [DisplayName("Acct No Alt Acct No"), Expression("jAcctNo.[ALT_ACCT_NO]")]
        public String AcctNoAltAcctNo
        {
            get { return Fields.AcctNoAltAcctNo[this]; }
            set { Fields.AcctNoAltAcctNo[this] = value; }
        }

        [DisplayName("Acct No Normal Sign"), Expression("jAcctNo.[NORMAL_SIGN]")]
        public String AcctNoNormalSign
        {
            get { return Fields.AcctNoNormalSign[this]; }
            set { Fields.AcctNoNormalSign[this] = value; }
        }

        [DisplayName("Acct No Type Bs"), Expression("jAcctNo.[TYPE_BS]")]
        public String AcctNoTypeBs
        {
            get { return Fields.AcctNoTypeBs[this]; }
            set { Fields.AcctNoTypeBs[this] = value; }
        }

        [DisplayName("Acct No Type Pl"), Expression("jAcctNo.[TYPE_PL]")]
        public String AcctNoTypePl
        {
            get { return Fields.AcctNoTypePl[this]; }
            set { Fields.AcctNoTypePl[this] = value; }
        }

        [DisplayName("Acct No Type Debtor"), Expression("jAcctNo.[TYPE_DEBTOR]")]
        public String AcctNoTypeDebtor
        {
            get { return Fields.AcctNoTypeDebtor[this]; }
            set { Fields.AcctNoTypeDebtor[this] = value; }
        }

        [DisplayName("Acct No Type Creditor"), Expression("jAcctNo.[TYPE_CREDITOR]")]
        public String AcctNoTypeCreditor
        {
            get { return Fields.AcctNoTypeCreditor[this]; }
            set { Fields.AcctNoTypeCreditor[this] = value; }
        }

        [DisplayName("Acct No Type Memo"), Expression("jAcctNo.[TYPE_MEMO]")]
        public String AcctNoTypeMemo
        {
            get { return Fields.AcctNoTypeMemo[this]; }
            set { Fields.AcctNoTypeMemo[this] = value; }
        }

        [DisplayName("Acct No Default Ccy"), Expression("jAcctNo.[DEFAULT_CCY]")]
        public String AcctNoDefaultCcy
        {
            get { return Fields.AcctNoDefaultCcy[this]; }
            set { Fields.AcctNoDefaultCcy[this] = value; }
        }

        [DisplayName("Acct No Anlys1"), Expression("jAcctNo.[ANLYS1]")]
        public String AcctNoAnlys1
        {
            get { return Fields.AcctNoAnlys1[this]; }
            set { Fields.AcctNoAnlys1[this] = value; }
        }

        [DisplayName("Acct No Anlys2"), Expression("jAcctNo.[ANLYS2]")]
        public String AcctNoAnlys2
        {
            get { return Fields.AcctNoAnlys2[this]; }
            set { Fields.AcctNoAnlys2[this] = value; }
        }

        [DisplayName("Acct No Anlys3"), Expression("jAcctNo.[ANLYS3]")]
        public String AcctNoAnlys3
        {
            get { return Fields.AcctNoAnlys3[this]; }
            set { Fields.AcctNoAnlys3[this] = value; }
        }

        [DisplayName("Acct No Anlys4"), Expression("jAcctNo.[ANLYS4]")]
        public String AcctNoAnlys4
        {
            get { return Fields.AcctNoAnlys4[this]; }
            set { Fields.AcctNoAnlys4[this] = value; }
        }

        [DisplayName("Acct No Suspended"), Expression("jAcctNo.[SUSPENDED]")]
        public String AcctNoSuspended
        {
            get { return Fields.AcctNoSuspended[this]; }
            set { Fields.AcctNoSuspended[this] = value; }
        }

        [DisplayName("Acct No Fixed Currency"), Expression("jAcctNo.[FIXED_CURRENCY]")]
        public String AcctNoFixedCurrency
        {
            get { return Fields.AcctNoFixedCurrency[this]; }
            set { Fields.AcctNoFixedCurrency[this] = value; }
        }

        [DisplayName("Acct No Auto Dist"), Expression("jAcctNo.[AUTO_DIST]")]
        public String AcctNoAutoDist
        {
            get { return Fields.AcctNoAutoDist[this]; }
            set { Fields.AcctNoAutoDist[this] = value; }
        }

        [DisplayName("Acct No Budget Control"), Expression("jAcctNo.[BUDGET_CONTROL]")]
        public String AcctNoBudgetControl
        {
            get { return Fields.AcctNoBudgetControl[this]; }
            set { Fields.AcctNoBudgetControl[this] = value; }
        }

        [DisplayName("Acct No Suppr Anlys3"), Expression("jAcctNo.[SUPPR_ANLYS3]")]
        public String AcctNoSupprAnlys3
        {
            get { return Fields.AcctNoSupprAnlys3[this]; }
            set { Fields.AcctNoSupprAnlys3[this] = value; }
        }

        [DisplayName("Acct No Suppr Anlys4"), Expression("jAcctNo.[SUPPR_ANLYS4]")]
        public String AcctNoSupprAnlys4
        {
            get { return Fields.AcctNoSupprAnlys4[this]; }
            set { Fields.AcctNoSupprAnlys4[this] = value; }
        }

        [DisplayName("Acct No Suppr Anlys5"), Expression("jAcctNo.[SUPPR_ANLYS5]")]
        public String AcctNoSupprAnlys5
        {
            get { return Fields.AcctNoSupprAnlys5[this]; }
            set { Fields.AcctNoSupprAnlys5[this] = value; }
        }

        [DisplayName("Acct No Suppr Anlys6"), Expression("jAcctNo.[SUPPR_ANLYS6]")]
        public String AcctNoSupprAnlys6
        {
            get { return Fields.AcctNoSupprAnlys6[this]; }
            set { Fields.AcctNoSupprAnlys6[this] = value; }
        }

        [DisplayName("Acct No Suppr Reval"), Expression("jAcctNo.[SUPPR_REVAL]")]
        public String AcctNoSupprReval
        {
            get { return Fields.AcctNoSupprReval[this]; }
            set { Fields.AcctNoSupprReval[this] = value; }
        }

        [DisplayName("Acct No No Cost Centre"), Expression("jAcctNo.[NO_COST_CENTRE]")]
        public String AcctNoNoCostCentre
        {
            get { return Fields.AcctNoNoCostCentre[this]; }
            set { Fields.AcctNoNoCostCentre[this] = value; }
        }

        [DisplayName("Acct No No Dept"), Expression("jAcctNo.[NO_DEPT]")]
        public String AcctNoNoDept
        {
            get { return Fields.AcctNoNoDept[this]; }
            set { Fields.AcctNoNoDept[this] = value; }
        }

        [DisplayName("Acct No Oper1"), Expression("jAcctNo.[OPER1]")]
        public String AcctNoOper1
        {
            get { return Fields.AcctNoOper1[this]; }
            set { Fields.AcctNoOper1[this] = value; }
        }

        [DisplayName("Acct No Oper2"), Expression("jAcctNo.[OPER2]")]
        public String AcctNoOper2
        {
            get { return Fields.AcctNoOper2[this]; }
            set { Fields.AcctNoOper2[this] = value; }
        }

        [DisplayName("Acct No Oper3"), Expression("jAcctNo.[OPER3]")]
        public String AcctNoOper3
        {
            get { return Fields.AcctNoOper3[this]; }
            set { Fields.AcctNoOper3[this] = value; }
        }

        [DisplayName("Acct No Oper4"), Expression("jAcctNo.[OPER4]")]
        public String AcctNoOper4
        {
            get { return Fields.AcctNoOper4[this]; }
            set { Fields.AcctNoOper4[this] = value; }
        }

        [DisplayName("Acct No Oper5"), Expression("jAcctNo.[OPER5]")]
        public String AcctNoOper5
        {
            get { return Fields.AcctNoOper5[this]; }
            set { Fields.AcctNoOper5[this] = value; }
        }

        [DisplayName("Acct No Lines Bef Print"), Expression("jAcctNo.[LINES_BEF_PRINT]")]
        public Decimal? AcctNoLinesBefPrint
        {
            get { return Fields.AcctNoLinesBefPrint[this]; }
            set { Fields.AcctNoLinesBefPrint[this] = value; }
        }

        [DisplayName("Acct No Tran Acct"), Expression("jAcctNo.[TRAN_ACCT]")]
        public String AcctNoTranAcct
        {
            get { return Fields.AcctNoTranAcct[this]; }
            set { Fields.AcctNoTranAcct[this] = value; }
        }

        [DisplayName("Acct No Summary Pos"), Expression("jAcctNo.[SUMMARY_POS]")]
        public String AcctNoSummaryPos
        {
            get { return Fields.AcctNoSummaryPos[this]; }
            set { Fields.AcctNoSummaryPos[this] = value; }
        }

        [DisplayName("Acct No Created Date"), Expression("jAcctNo.[CREATED_DATE]")]
        public DateTime? AcctNoCreatedDate
        {
            get { return Fields.AcctNoCreatedDate[this]; }
            set { Fields.AcctNoCreatedDate[this] = value; }
        }

        [DisplayName("Acct No Created By"), Expression("jAcctNo.[CREATED_BY]")]
        public String AcctNoCreatedBy
        {
            get { return Fields.AcctNoCreatedBy[this]; }
            set { Fields.AcctNoCreatedBy[this] = value; }
        }

        [DisplayName("Acct No Revised Date"), Expression("jAcctNo.[REVISED_DATE]")]
        public DateTime? AcctNoRevisedDate
        {
            get { return Fields.AcctNoRevisedDate[this]; }
            set { Fields.AcctNoRevisedDate[this] = value; }
        }

        [DisplayName("Acct No Revised By"), Expression("jAcctNo.[REVISED_BY]")]
        public String AcctNoRevisedBy
        {
            get { return Fields.AcctNoRevisedBy[this]; }
            set { Fields.AcctNoRevisedBy[this] = value; }
        }

        [DisplayName("Acct No Recon Last Date"), Expression("jAcctNo.[RECON_LAST_DATE]")]
        public DateTime? AcctNoReconLastDate
        {
            get { return Fields.AcctNoReconLastDate[this]; }
            set { Fields.AcctNoReconLastDate[this] = value; }
        }

        [DisplayName("Acct No Recon Last Jrn"), Expression("jAcctNo.[RECON_LAST_JRN]")]
        public Decimal? AcctNoReconLastJrn
        {
            get { return Fields.AcctNoReconLastJrn[this]; }
            set { Fields.AcctNoReconLastJrn[this] = value; }
        }

        [DisplayName("Acct No Recon Bal"), Expression("jAcctNo.[RECON_BAL]")]
        public Decimal? AcctNoReconBal
        {
            get { return Fields.AcctNoReconBal[this]; }
            set { Fields.AcctNoReconBal[this] = value; }
        }

        [DisplayName("Acct No Recon Bal Sign"), Expression("jAcctNo.[RECON_BAL_SIGN]")]
        public String AcctNoReconBalSign
        {
            get { return Fields.AcctNoReconBalSign[this]; }
            set { Fields.AcctNoReconBalSign[this] = value; }
        }

        [DisplayName("Acct No Last Tran Date"), Expression("jAcctNo.[LAST_TRAN_DATE]")]
        public DateTime? AcctNoLastTranDate
        {
            get { return Fields.AcctNoLastTranDate[this]; }
            set { Fields.AcctNoLastTranDate[this] = value; }
        }

        [DisplayName("Acct No Last Jrn No"), Expression("jAcctNo.[LAST_JRN_NO]")]
        public Decimal? AcctNoLastJrnNo
        {
            get { return Fields.AcctNoLastJrnNo[this]; }
            set { Fields.AcctNoLastJrnNo[this] = value; }
        }

        [DisplayName("Acct No Dist Total Pct"), Expression("jAcctNo.[DIST_TOTAL_PCT]")]
        public Decimal? AcctNoDistTotalPct
        {
            get { return Fields.AcctNoDistTotalPct[this]; }
            set { Fields.AcctNoDistTotalPct[this] = value; }
        }

        [DisplayName("Acct No Dist Last Line"), Expression("jAcctNo.[DIST_LAST_LINE]")]
        public Decimal? AcctNoDistLastLine
        {
            get { return Fields.AcctNoDistLastLine[this]; }
            set { Fields.AcctNoDistLastLine[this] = value; }
        }

        [DisplayName("Acct No Recon Count"), Expression("jAcctNo.[RECON_COUNT]")]
        public Decimal? AcctNoReconCount
        {
            get { return Fields.AcctNoReconCount[this]; }
            set { Fields.AcctNoReconCount[this] = value; }
        }

        [DisplayName("Acct No Balance End"), Expression("jAcctNo.[BALANCE_END]")]
        public Decimal? AcctNoBalanceEnd
        {
            get { return Fields.AcctNoBalanceEnd[this]; }
            set { Fields.AcctNoBalanceEnd[this] = value; }
        }

        [DisplayName("Acct No Balance Sign"), Expression("jAcctNo.[BALANCE_SIGN]")]
        public String AcctNoBalanceSign
        {
            get { return Fields.AcctNoBalanceSign[this]; }
            set { Fields.AcctNoBalanceSign[this] = value; }
        }

        [DisplayName("Acct No Owner Branch"), Expression("jAcctNo.[OWNER_BRANCH]")]
        public String AcctNoOwnerBranch
        {
            get { return Fields.AcctNoOwnerBranch[this]; }
            set { Fields.AcctNoOwnerBranch[this] = value; }
        }

        [DisplayName("Acct No Source Branch"), Expression("jAcctNo.[SOURCE_BRANCH]")]
        public String AcctNoSourceBranch
        {
            get { return Fields.AcctNoSourceBranch[this]; }
            set { Fields.AcctNoSourceBranch[this] = value; }
        }

        [DisplayName("Acct No Allow Edit"), Expression("jAcctNo.[ALLOW_EDIT]")]
        public String AcctNoAllowEdit
        {
            get { return Fields.AcctNoAllowEdit[this]; }
            set { Fields.AcctNoAllowEdit[this] = value; }
        }

        [DisplayName("Acct No Anlys5"), Expression("jAcctNo.[ANLYS5]")]
        public String AcctNoAnlys5
        {
            get { return Fields.AcctNoAnlys5[this]; }
            set { Fields.AcctNoAnlys5[this] = value; }
        }

        [DisplayName("Acct No Anlys6"), Expression("jAcctNo.[ANLYS6]")]
        public String AcctNoAnlys6
        {
            get { return Fields.AcctNoAnlys6[this]; }
            set { Fields.AcctNoAnlys6[this] = value; }
        }

        [DisplayName("Acct No Anlys7"), Expression("jAcctNo.[ANLYS7]")]
        public String AcctNoAnlys7
        {
            get { return Fields.AcctNoAnlys7[this]; }
            set { Fields.AcctNoAnlys7[this] = value; }
        }

        [DisplayName("Acct No Anlys8"), Expression("jAcctNo.[ANLYS8]")]
        public String AcctNoAnlys8
        {
            get { return Fields.AcctNoAnlys8[this]; }
            set { Fields.AcctNoAnlys8[this] = value; }
        }

        [DisplayName("Acct No Anlys9"), Expression("jAcctNo.[ANLYS9]")]
        public String AcctNoAnlys9
        {
            get { return Fields.AcctNoAnlys9[this]; }
            set { Fields.AcctNoAnlys9[this] = value; }
        }

        [DisplayName("Acct No Anlys10"), Expression("jAcctNo.[ANLYS10]")]
        public String AcctNoAnlys10
        {
            get { return Fields.AcctNoAnlys10[this]; }
            set { Fields.AcctNoAnlys10[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.AcctNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public LedgerSummaryRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField AcctNo;
            public StringField Period;
            public DecimalField FiscalYear;
            public DecimalField PeriodNo;
            public DecimalField TotalDebit;
            public DecimalField TotalCredit;
            public DecimalField BalBeg;
            public StringField BalBegSign;
            public DecimalField BalEnd;
            public StringField BalEndSign;
            public StringField OwnerBranch;
            public StringField SourceBranch;

            public DecimalField AcctNoRecnum;
            public StringField AcctNoAcctName;
            public StringField AcctNoAltAcctNo;
            public StringField AcctNoNormalSign;
            public StringField AcctNoTypeBs;
            public StringField AcctNoTypePl;
            public StringField AcctNoTypeDebtor;
            public StringField AcctNoTypeCreditor;
            public StringField AcctNoTypeMemo;
            public StringField AcctNoDefaultCcy;
            public StringField AcctNoAnlys1;
            public StringField AcctNoAnlys2;
            public StringField AcctNoAnlys3;
            public StringField AcctNoAnlys4;
            public StringField AcctNoSuspended;
            public StringField AcctNoFixedCurrency;
            public StringField AcctNoAutoDist;
            public StringField AcctNoBudgetControl;
            public StringField AcctNoSupprAnlys3;
            public StringField AcctNoSupprAnlys4;
            public StringField AcctNoSupprAnlys5;
            public StringField AcctNoSupprAnlys6;
            public StringField AcctNoSupprReval;
            public StringField AcctNoNoCostCentre;
            public StringField AcctNoNoDept;
            public StringField AcctNoOper1;
            public StringField AcctNoOper2;
            public StringField AcctNoOper3;
            public StringField AcctNoOper4;
            public StringField AcctNoOper5;
            public DecimalField AcctNoLinesBefPrint;
            public StringField AcctNoTranAcct;
            public StringField AcctNoSummaryPos;
            public DateTimeField AcctNoCreatedDate;
            public StringField AcctNoCreatedBy;
            public DateTimeField AcctNoRevisedDate;
            public StringField AcctNoRevisedBy;
            public DateTimeField AcctNoReconLastDate;
            public DecimalField AcctNoReconLastJrn;
            public DecimalField AcctNoReconBal;
            public StringField AcctNoReconBalSign;
            public DateTimeField AcctNoLastTranDate;
            public DecimalField AcctNoLastJrnNo;
            public DecimalField AcctNoDistTotalPct;
            public DecimalField AcctNoDistLastLine;
            public DecimalField AcctNoReconCount;
            public DecimalField AcctNoBalanceEnd;
            public StringField AcctNoBalanceSign;
            public StringField AcctNoOwnerBranch;
            public StringField AcctNoSourceBranch;
            public StringField AcctNoAllowEdit;
            public StringField AcctNoAnlys5;
            public StringField AcctNoAnlys6;
            public StringField AcctNoAnlys7;
            public StringField AcctNoAnlys8;
            public StringField AcctNoAnlys9;
            public StringField AcctNoAnlys10;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Finance.LedgerSummary";
            }
        }
    }
}
