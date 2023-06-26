#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CurrencyBalanceRow.cs
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

    [ConnectionKey("Finance"), TableName("[dbo].[GLCBAL]")]
    [DisplayName("Currency Balance"), InstanceName("Currency Balance"), TwoLevelCached]   
    public sealed class CurrencyBalanceRow : Row, IIdRow, INameRow
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

        [DisplayName("Ccy"), Column("CCY"), Size(4), PrimaryKey, ForeignKey("[dbo].[GBCURR]", "CCY"), LeftJoin("jCcy"), TextualField("CcyDescription")]
        public String Ccy
        {
            get { return Fields.Ccy[this]; }
            set { Fields.Ccy[this] = value; }
        }

        [DisplayName("Acct Name"), Column("ACCT_NAME"), Size(50)]
        public String AcctName
        {
            get { return Fields.AcctName[this]; }
            set { Fields.AcctName[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(25)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Forex Balance"), Column("FOREX_BALANCE"), Size(16), Scale(2)]
        public Decimal? ForexBalance
        {
            get { return Fields.ForexBalance[this]; }
            set { Fields.ForexBalance[this] = value; }
        }

        [DisplayName("Forex Sign"), Column("FOREX_SIGN"), Size(6)]
        public String ForexSign
        {
            get { return Fields.ForexSign[this]; }
            set { Fields.ForexSign[this] = value; }
        }

        [DisplayName("Local Balance"), Column("LOCAL_BALANCE"), Size(16), Scale(2)]
        public Decimal? LocalBalance
        {
            get { return Fields.LocalBalance[this]; }
            set { Fields.LocalBalance[this] = value; }
        }

        [DisplayName("Local Sign"), Column("LOCAL_SIGN"), Size(6)]
        public String LocalSign
        {
            get { return Fields.LocalSign[this]; }
            set { Fields.LocalSign[this] = value; }
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

        [DisplayName("Ccy Recnum"), Expression("jCcy.[RECNUM]")]
        public Decimal? CcyRecnum
        {
            get { return Fields.CcyRecnum[this]; }
            set { Fields.CcyRecnum[this] = value; }
        }

        [DisplayName("Ccy Description"), Expression("jCcy.[DESCRIPTION]")]
        public String CcyDescription
        {
            get { return Fields.CcyDescription[this]; }
            set { Fields.CcyDescription[this] = value; }
        }

        [DisplayName("Ccy Suspended"), Expression("jCcy.[SUSPENDED]")]
        public String CcySuspended
        {
            get { return Fields.CcySuspended[this]; }
            set { Fields.CcySuspended[this] = value; }
        }

        [DisplayName("Ccy Default Rate"), Expression("jCcy.[DEFAULT_RATE]")]
        public Decimal? CcyDefaultRate
        {
            get { return Fields.CcyDefaultRate[this]; }
            set { Fields.CcyDefaultRate[this] = value; }
        }

        [DisplayName("Ccy Acct Ar Forex"), Expression("jCcy.[ACCT_AR_FOREX]")]
        public String CcyAcctArForex
        {
            get { return Fields.CcyAcctArForex[this]; }
            set { Fields.CcyAcctArForex[this] = value; }
        }

        [DisplayName("Ccy Acct Ap Forex"), Expression("jCcy.[ACCT_AP_FOREX]")]
        public String CcyAcctApForex
        {
            get { return Fields.CcyAcctApForex[this]; }
            set { Fields.CcyAcctApForex[this] = value; }
        }

        [DisplayName("Ccy Last Entry No"), Expression("jCcy.[LAST_ENTRY_NO]")]
        public Decimal? CcyLastEntryNo
        {
            get { return Fields.CcyLastEntryNo[this]; }
            set { Fields.CcyLastEntryNo[this] = value; }
        }

        [DisplayName("Ccy Rate Use Count"), Expression("jCcy.[RATE_USE_COUNT]")]
        public Decimal? CcyRateUseCount
        {
            get { return Fields.CcyRateUseCount[this]; }
            set { Fields.CcyRateUseCount[this] = value; }
        }

        [DisplayName("Ccy Created Date"), Expression("jCcy.[CREATED_DATE]")]
        public DateTime? CcyCreatedDate
        {
            get { return Fields.CcyCreatedDate[this]; }
            set { Fields.CcyCreatedDate[this] = value; }
        }

        [DisplayName("Ccy Created By"), Expression("jCcy.[CREATED_BY]")]
        public String CcyCreatedBy
        {
            get { return Fields.CcyCreatedBy[this]; }
            set { Fields.CcyCreatedBy[this] = value; }
        }

        [DisplayName("Ccy Revised Date"), Expression("jCcy.[REVISED_DATE]")]
        public DateTime? CcyRevisedDate
        {
            get { return Fields.CcyRevisedDate[this]; }
            set { Fields.CcyRevisedDate[this] = value; }
        }

        [DisplayName("Ccy Revised By"), Expression("jCcy.[REVISED_BY]")]
        public String CcyRevisedBy
        {
            get { return Fields.CcyRevisedBy[this]; }
            set { Fields.CcyRevisedBy[this] = value; }
        }

        [DisplayName("Ccy Arevised Date"), Expression("jCcy.[AREVISED_DATE]")]
        public DateTime? CcyArevisedDate
        {
            get { return Fields.CcyArevisedDate[this]; }
            set { Fields.CcyArevisedDate[this] = value; }
        }

        [DisplayName("Ccy Arevised By"), Expression("jCcy.[AREVISED_BY]")]
        public String CcyArevisedBy
        {
            get { return Fields.CcyArevisedBy[this]; }
            set { Fields.CcyArevisedBy[this] = value; }
        }

        [DisplayName("Ccy Owner Branch"), Expression("jCcy.[OWNER_BRANCH]")]
        public String CcyOwnerBranch
        {
            get { return Fields.CcyOwnerBranch[this]; }
            set { Fields.CcyOwnerBranch[this] = value; }
        }

        [DisplayName("Ccy Source Branch"), Expression("jCcy.[SOURCE_BRANCH]")]
        public String CcySourceBranch
        {
            get { return Fields.CcySourceBranch[this]; }
            set { Fields.CcySourceBranch[this] = value; }
        }

        [DisplayName("Ccy Ap Invo Bal"), Expression("jCcy.[AP_INVO_BAL]")]
        public Decimal? CcyApInvoBal
        {
            get { return Fields.CcyApInvoBal[this]; }
            set { Fields.CcyApInvoBal[this] = value; }
        }

        [DisplayName("Ccy Ap Open Bal"), Expression("jCcy.[AP_OPEN_BAL]")]
        public Decimal? CcyApOpenBal
        {
            get { return Fields.CcyApOpenBal[this]; }
            set { Fields.CcyApOpenBal[this] = value; }
        }

        [DisplayName("Ccy Ap Net Bal"), Expression("jCcy.[AP_NET_BAL]")]
        public Decimal? CcyApNetBal
        {
            get { return Fields.CcyApNetBal[this]; }
            set { Fields.CcyApNetBal[this] = value; }
        }

        [DisplayName("Ccy Ap Linvo Bal"), Expression("jCcy.[AP_LINVO_BAL]")]
        public Decimal? CcyApLinvoBal
        {
            get { return Fields.CcyApLinvoBal[this]; }
            set { Fields.CcyApLinvoBal[this] = value; }
        }

        [DisplayName("Ccy Ap Lopen Bal"), Expression("jCcy.[AP_LOPEN_BAL]")]
        public Decimal? CcyApLopenBal
        {
            get { return Fields.CcyApLopenBal[this]; }
            set { Fields.CcyApLopenBal[this] = value; }
        }

        [DisplayName("Ccy Ap Lnet Bal"), Expression("jCcy.[AP_LNET_BAL]")]
        public Decimal? CcyApLnetBal
        {
            get { return Fields.CcyApLnetBal[this]; }
            set { Fields.CcyApLnetBal[this] = value; }
        }

        [DisplayName("Ccy Ar Invo Bal"), Expression("jCcy.[AR_INVO_BAL]")]
        public Decimal? CcyArInvoBal
        {
            get { return Fields.CcyArInvoBal[this]; }
            set { Fields.CcyArInvoBal[this] = value; }
        }

        [DisplayName("Ccy Ar Open Bal"), Expression("jCcy.[AR_OPEN_BAL]")]
        public Decimal? CcyArOpenBal
        {
            get { return Fields.CcyArOpenBal[this]; }
            set { Fields.CcyArOpenBal[this] = value; }
        }

        [DisplayName("Ccy Ar Net Bal"), Expression("jCcy.[AR_NET_BAL]")]
        public Decimal? CcyArNetBal
        {
            get { return Fields.CcyArNetBal[this]; }
            set { Fields.CcyArNetBal[this] = value; }
        }

        [DisplayName("Ccy Ar Linvo Bal"), Expression("jCcy.[AR_LINVO_BAL]")]
        public Decimal? CcyArLinvoBal
        {
            get { return Fields.CcyArLinvoBal[this]; }
            set { Fields.CcyArLinvoBal[this] = value; }
        }

        [DisplayName("Ccy Ar Lopen Bal"), Expression("jCcy.[AR_LOPEN_BAL]")]
        public Decimal? CcyArLopenBal
        {
            get { return Fields.CcyArLopenBal[this]; }
            set { Fields.CcyArLopenBal[this] = value; }
        }

        [DisplayName("Ccy Ar Lnet Bal"), Expression("jCcy.[AR_LNET_BAL]")]
        public Decimal? CcyArLnetBal
        {
            get { return Fields.CcyArLnetBal[this]; }
            set { Fields.CcyArLnetBal[this] = value; }
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

        public CurrencyBalanceRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField AcctNo;
            public StringField Ccy;
            public StringField AcctName;
            public StringField Description;
            public DecimalField ForexBalance;
            public StringField ForexSign;
            public DecimalField LocalBalance;
            public StringField LocalSign;

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

            public DecimalField CcyRecnum;
            public StringField CcyDescription;
            public StringField CcySuspended;
            public DecimalField CcyDefaultRate;
            public StringField CcyAcctArForex;
            public StringField CcyAcctApForex;
            public DecimalField CcyLastEntryNo;
            public DecimalField CcyRateUseCount;
            public DateTimeField CcyCreatedDate;
            public StringField CcyCreatedBy;
            public DateTimeField CcyRevisedDate;
            public StringField CcyRevisedBy;
            public DateTimeField CcyArevisedDate;
            public StringField CcyArevisedBy;
            public StringField CcyOwnerBranch;
            public StringField CcySourceBranch;
            public DecimalField CcyApInvoBal;
            public DecimalField CcyApOpenBal;
            public DecimalField CcyApNetBal;
            public DecimalField CcyApLinvoBal;
            public DecimalField CcyApLopenBal;
            public DecimalField CcyApLnetBal;
            public DecimalField CcyArInvoBal;
            public DecimalField CcyArOpenBal;
            public DecimalField CcyArNetBal;
            public DecimalField CcyArLinvoBal;
            public DecimalField CcyArLopenBal;
            public DecimalField CcyArLnetBal;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Finance.CurrencyBalance";
            }
        }
    }
}
