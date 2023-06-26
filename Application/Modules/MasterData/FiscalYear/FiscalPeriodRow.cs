#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  FiscalPeriodRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.MasterData.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("MasterData"), TableName("[dbo].[GBPERD]")]
    [DisplayName("Fiscal Period"), InstanceName("Fiscal Period"), TwoLevelCached]   
    public sealed class FiscalPeriodRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Fiscal Year"), Column("FISCAL_YEAR"), Size(4), PrimaryKey, ForeignKey("[dbo].[GBPERH]", "FISCAL_YEAR"), LeftJoin("jFiscalYear"), TextualField("FiscalYearAllowEntries")]
        public Decimal? FiscalYear
        {
            get { return Fields.FiscalYear[this]; }
            set { Fields.FiscalYear[this] = value; }
        }

        [DisplayName("Period No"), Column("PERIOD_NO"), Size(2), PrimaryKey]
        public Decimal? PeriodNo
        {
            get { return Fields.PeriodNo[this]; }
            set { Fields.PeriodNo[this] = value; }
        }

        [DisplayName("Period"), Column("PERIOD"), Size(7), NotNull, QuickSearch]
        public String Period
        {
            get { return Fields.Period[this]; }
            set { Fields.Period[this] = value; }
        }

        [DisplayName("Start Date"), Column("START_DATE"), NotNull]
        public DateTime? StartDate
        {
            get { return Fields.StartDate[this]; }
            set { Fields.StartDate[this] = value; }
        }

        [DisplayName("End Date"), Column("END_DATE"), NotNull]
        public DateTime? EndDate
        {
            get { return Fields.EndDate[this]; }
            set { Fields.EndDate[this] = value; }
        }

        [DisplayName("Allow Entries"), Column("ALLOW_ENTRIES"), Size(1)]
        [BoolStringConverter]
        public bool? AllowEntries
        {
            get { return Fields.AllowEntries[this]; }
            set { Fields.AllowEntries[this] = value; }
        }

        [DisplayName("Closed Sl"), Column("CLOSED_SL"), Size(1)]
        public bool? ClosedSl
        {
            get { return Fields.ClosedSl[this]; }
            set { Fields.ClosedSl[this] = value; }
        }

        [DisplayName("Closed Pu"), Column("CLOSED_PU"), Size(1)]
        public bool? ClosedPu
        {
            get { return Fields.ClosedPu[this]; }
            set { Fields.ClosedPu[this] = value; }
        }

        [DisplayName("Closed Pr"), Column("CLOSED_PR"), Size(1)]
        public bool? ClosedPr
        {
            get { return Fields.ClosedPr[this]; }
            set { Fields.ClosedPr[this] = value; }
        }

        [DisplayName("Closed Ic"), Column("CLOSED_IC"), Size(1)]
        public bool? ClosedIc
        {
            get { return Fields.ClosedIc[this]; }
            set { Fields.ClosedIc[this] = value; }
        }

        [DisplayName("Closed Ar"), Column("CLOSED_AR"), Size(1)]
        public bool? ClosedAr
        {
            get { return Fields.ClosedAr[this]; }
            set { Fields.ClosedAr[this] = value; }
        }

        [DisplayName("Closed Ap"), Column("CLOSED_AP"), Size(1)]
        public bool? ClosedAp
        {
            get { return Fields.ClosedAp[this]; }
            set { Fields.ClosedAp[this] = value; }
        }

        [DisplayName("Closed Gl"), Column("CLOSED_GL"), Size(1)]
        public bool? ClosedGl
        {
            get { return Fields.ClosedGl[this]; }
            set { Fields.ClosedGl[this] = value; }
        }

        [DisplayName("Created Date"), Column("CREATED_DATE")]
        public DateTime? CreatedDate
        {
            get { return Fields.CreatedDate[this]; }
            set { Fields.CreatedDate[this] = value; }
        }

        [DisplayName("Created By"), Column("CREATED_BY"), Size(10)]
        public String CreatedBy
        {
            get { return Fields.CreatedBy[this]; }
            set { Fields.CreatedBy[this] = value; }
        }

        [DisplayName("Revised Date"), Column("REVISED_DATE")]
        public DateTime? RevisedDate
        {
            get { return Fields.RevisedDate[this]; }
            set { Fields.RevisedDate[this] = value; }
        }

        [DisplayName("Revised By"), Column("REVISED_BY"), Size(10)]
        public String RevisedBy
        {
            get { return Fields.RevisedBy[this]; }
            set { Fields.RevisedBy[this] = value; }
        }

        [DisplayName("Closed Date"), Column("CLOSED_DATE")]
        public DateTime? ClosedDate
        {
            get { return Fields.ClosedDate[this]; }
            set { Fields.ClosedDate[this] = value; }
        }

        [DisplayName("Closed By"), Column("CLOSED_BY"), Size(10)]
        public String ClosedBy
        {
            get { return Fields.ClosedBy[this]; }
            set { Fields.ClosedBy[this] = value; }
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

        [DisplayName("Ar Bal Beg"), Column("AR_BAL_BEG"), Size(16), Scale(2)]
        public Decimal? ArBalBeg
        {
            get { return Fields.ArBalBeg[this]; }
            set { Fields.ArBalBeg[this] = value; }
        }

        [DisplayName("Ar Invo Amt"), Column("AR_INVO_AMT"), Size(16), Scale(2)]
        public Decimal? ArInvoAmt
        {
            get { return Fields.ArInvoAmt[this]; }
            set { Fields.ArInvoAmt[this] = value; }
        }

        [DisplayName("Ar Memo Amt"), Column("AR_MEMO_AMT"), Size(16), Scale(2)]
        public Decimal? ArMemoAmt
        {
            get { return Fields.ArMemoAmt[this]; }
            set { Fields.ArMemoAmt[this] = value; }
        }

        [DisplayName("Ar Adj Amt"), Column("AR_ADJ_AMT"), Size(16), Scale(2)]
        public Decimal? ArAdjAmt
        {
            get { return Fields.ArAdjAmt[this]; }
            set { Fields.ArAdjAmt[this] = value; }
        }

        [DisplayName("Ar Pay Amt"), Column("AR_PAY_AMT"), Size(16), Scale(2)]
        public Decimal? ArPayAmt
        {
            get { return Fields.ArPayAmt[this]; }
            set { Fields.ArPayAmt[this] = value; }
        }

        [DisplayName("Ar Bal End"), Column("AR_BAL_END"), Size(16), Scale(2)]
        public Decimal? ArBalEnd
        {
            get { return Fields.ArBalEnd[this]; }
            set { Fields.ArBalEnd[this] = value; }
        }

        [DisplayName("Ap Bal Beg"), Column("AP_BAL_BEG"), Size(16), Scale(2)]
        public Decimal? ApBalBeg
        {
            get { return Fields.ApBalBeg[this]; }
            set { Fields.ApBalBeg[this] = value; }
        }

        [DisplayName("Ap Invo Amt"), Column("AP_INVO_AMT"), Size(16), Scale(2)]
        public Decimal? ApInvoAmt
        {
            get { return Fields.ApInvoAmt[this]; }
            set { Fields.ApInvoAmt[this] = value; }
        }

        [DisplayName("Ap Memo Amt"), Column("AP_MEMO_AMT"), Size(16), Scale(2)]
        public Decimal? ApMemoAmt
        {
            get { return Fields.ApMemoAmt[this]; }
            set { Fields.ApMemoAmt[this] = value; }
        }

        [DisplayName("Ap Adj Amt"), Column("AP_ADJ_AMT"), Size(16), Scale(2)]
        public Decimal? ApAdjAmt
        {
            get { return Fields.ApAdjAmt[this]; }
            set { Fields.ApAdjAmt[this] = value; }
        }

        [DisplayName("Ap Pay Amt"), Column("AP_PAY_AMT"), Size(16), Scale(2)]
        public Decimal? ApPayAmt
        {
            get { return Fields.ApPayAmt[this]; }
            set { Fields.ApPayAmt[this] = value; }
        }

        [DisplayName("Ap Bal End"), Column("AP_BAL_END"), Size(16), Scale(2)]
        public Decimal? ApBalEnd
        {
            get { return Fields.ApBalEnd[this]; }
            set { Fields.ApBalEnd[this] = value; }
        }

        [DisplayName("Active Gl"), Column("ACTIVE_GL"), Size(1), NotNull]
        public String ActiveGl
        {
            get { return Fields.ActiveGl[this]; }
            set { Fields.ActiveGl[this] = value; }
        }

        [DisplayName("Active Ap"), Column("ACTIVE_AP"), Size(1), NotNull]
        public String ActiveAp
        {
            get { return Fields.ActiveAp[this]; }
            set { Fields.ActiveAp[this] = value; }
        }

        [DisplayName("Active Ar"), Column("ACTIVE_AR"), Size(1), NotNull]
        public String ActiveAr
        {
            get { return Fields.ActiveAr[this]; }
            set { Fields.ActiveAr[this] = value; }
        }

        [DisplayName("Active Ic"), Column("ACTIVE_IC"), Size(1)]
        public String ActiveIc
        {
            get { return Fields.ActiveIc[this]; }
            set { Fields.ActiveIc[this] = value; }
        }

        [DisplayName("Active Pr"), Column("ACTIVE_PR"), Size(1)]
        public String ActivePr
        {
            get { return Fields.ActivePr[this]; }
            set { Fields.ActivePr[this] = value; }
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

        [DisplayName("Ar Disc Amt"), Column("AR_DISC_AMT"), Size(16), Scale(2)]
        public Decimal? ArDiscAmt
        {
            get { return Fields.ArDiscAmt[this]; }
            set { Fields.ArDiscAmt[this] = value; }
        }

        [DisplayName("Ar Diff Amt"), Column("AR_DIFF_AMT"), Size(16), Scale(2)]
        public Decimal? ArDiffAmt
        {
            get { return Fields.ArDiffAmt[this]; }
            set { Fields.ArDiffAmt[this] = value; }
        }

        [DisplayName("Ap Disc Amt"), Column("AP_DISC_AMT"), Size(16), Scale(2)]
        public Decimal? ApDiscAmt
        {
            get { return Fields.ApDiscAmt[this]; }
            set { Fields.ApDiscAmt[this] = value; }
        }

        [DisplayName("Ap Diff Amt"), Column("AP_DIFF_AMT"), Size(16), Scale(2)]
        public Decimal? ApDiffAmt
        {
            get { return Fields.ApDiffAmt[this]; }
            set { Fields.ApDiffAmt[this] = value; }
        }

        [DisplayName("Ap Rfd Amt"), Column("AP_RFD_AMT"), Size(16), Scale(2)]
        public Decimal? ApRfdAmt
        {
            get { return Fields.ApRfdAmt[this]; }
            set { Fields.ApRfdAmt[this] = value; }
        }

        [DisplayName("Ar Rfd Amt"), Column("AR_RFD_AMT"), Size(16), Scale(2)]
        public Decimal? ArRfdAmt
        {
            get { return Fields.ArRfdAmt[this]; }
            set { Fields.ArRfdAmt[this] = value; }
        }

        [DisplayName("Fiscal Year Recnum"), Expression("jFiscalYear.[RECNUM]")]
        public Decimal? FiscalYearRecnum
        {
            get { return Fields.FiscalYearRecnum[this]; }
            set { Fields.FiscalYearRecnum[this] = value; }
        }

        [DisplayName("Fiscal Year Allow Entries"), Expression("jFiscalYear.[ALLOW_ENTRIES]")]
        public String FiscalYearAllowEntries
        {
            get { return Fields.FiscalYearAllowEntries[this]; }
            set { Fields.FiscalYearAllowEntries[this] = value; }
        }

        [DisplayName("Fiscal Year Closed"), Expression("jFiscalYear.[CLOSED]")]
        public String FiscalYearClosed
        {
            get { return Fields.FiscalYearClosed[this]; }
            set { Fields.FiscalYearClosed[this] = value; }
        }

        [DisplayName("Fiscal Year Last Period"), Expression("jFiscalYear.[LAST_PERIOD]")]
        public Decimal? FiscalYearLastPeriod
        {
            get { return Fields.FiscalYearLastPeriod[this]; }
            set { Fields.FiscalYearLastPeriod[this] = value; }
        }

        [DisplayName("Fiscal Year Created Date"), Expression("jFiscalYear.[CREATED_DATE]")]
        public DateTime? FiscalYearCreatedDate
        {
            get { return Fields.FiscalYearCreatedDate[this]; }
            set { Fields.FiscalYearCreatedDate[this] = value; }
        }

        [DisplayName("Fiscal Year Created By"), Expression("jFiscalYear.[CREATED_BY]")]
        public String FiscalYearCreatedBy
        {
            get { return Fields.FiscalYearCreatedBy[this]; }
            set { Fields.FiscalYearCreatedBy[this] = value; }
        }

        [DisplayName("Fiscal Year Revised Date"), Expression("jFiscalYear.[REVISED_DATE]")]
        public DateTime? FiscalYearRevisedDate
        {
            get { return Fields.FiscalYearRevisedDate[this]; }
            set { Fields.FiscalYearRevisedDate[this] = value; }
        }

        [DisplayName("Fiscal Year Revised By"), Expression("jFiscalYear.[REVISED_BY]")]
        public String FiscalYearRevisedBy
        {
            get { return Fields.FiscalYearRevisedBy[this]; }
            set { Fields.FiscalYearRevisedBy[this] = value; }
        }

        [DisplayName("Fiscal Year Closed Date"), Expression("jFiscalYear.[CLOSED_DATE]")]
        public DateTime? FiscalYearClosedDate
        {
            get { return Fields.FiscalYearClosedDate[this]; }
            set { Fields.FiscalYearClosedDate[this] = value; }
        }

        [DisplayName("Fiscal Year Closed By"), Expression("jFiscalYear.[CLOSED_BY]")]
        public String FiscalYearClosedBy
        {
            get { return Fields.FiscalYearClosedBy[this]; }
            set { Fields.FiscalYearClosedBy[this] = value; }
        }

        [DisplayName("Fiscal Year Ytd Pl Credit"), Expression("jFiscalYear.[YTD_PL_CREDIT]")]
        public Decimal? FiscalYearYtdPlCredit
        {
            get { return Fields.FiscalYearYtdPlCredit[this]; }
            set { Fields.FiscalYearYtdPlCredit[this] = value; }
        }

        [DisplayName("Fiscal Year Ytd Pl Debit"), Expression("jFiscalYear.[YTD_PL_DEBIT]")]
        public Decimal? FiscalYearYtdPlDebit
        {
            get { return Fields.FiscalYearYtdPlDebit[this]; }
            set { Fields.FiscalYearYtdPlDebit[this] = value; }
        }

        [DisplayName("Fiscal Year Ytd Pl Net"), Expression("jFiscalYear.[YTD_PL_NET]")]
        public Decimal? FiscalYearYtdPlNet
        {
            get { return Fields.FiscalYearYtdPlNet[this]; }
            set { Fields.FiscalYearYtdPlNet[this] = value; }
        }

        [DisplayName("Fiscal Year Owner Branch"), Expression("jFiscalYear.[OWNER_BRANCH]")]
        public String FiscalYearOwnerBranch
        {
            get { return Fields.FiscalYearOwnerBranch[this]; }
            set { Fields.FiscalYearOwnerBranch[this] = value; }
        }

        [DisplayName("Fiscal Year Source Branch"), Expression("jFiscalYear.[SOURCE_BRANCH]")]
        public String FiscalYearSourceBranch
        {
            get { return Fields.FiscalYearSourceBranch[this]; }
            set { Fields.FiscalYearSourceBranch[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Period; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public FiscalPeriodRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public DecimalField FiscalYear;
            public DecimalField PeriodNo;
            public StringField Period;
            public DateTimeField StartDate;
            public DateTimeField EndDate;
            public BooleanField AllowEntries;
            public BooleanField ClosedSl;
            public BooleanField ClosedPu;
            public BooleanField ClosedPr;
            public BooleanField ClosedIc;
            public BooleanField ClosedAr;
            public BooleanField ClosedAp;
            public BooleanField ClosedGl;

            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DateTimeField ClosedDate;
            public StringField ClosedBy;
            public DecimalField BalBeg;
            public StringField BalBegSign;
            public DecimalField TotalDebit;
            public DecimalField TotalCredit;
            public DecimalField BalEnd;
            public StringField BalEndSign;
            public DecimalField ArBalBeg;
            public DecimalField ArInvoAmt;
            public DecimalField ArMemoAmt;
            public DecimalField ArAdjAmt;
            public DecimalField ArPayAmt;
            public DecimalField ArBalEnd;
            public DecimalField ApBalBeg;
            public DecimalField ApInvoAmt;
            public DecimalField ApMemoAmt;
            public DecimalField ApAdjAmt;
            public DecimalField ApPayAmt;
            public DecimalField ApBalEnd;
            public StringField ActiveGl;
            public StringField ActiveAp;
            public StringField ActiveAr;
            public StringField ActiveIc;
            public StringField ActivePr;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public DecimalField ArDiscAmt;
            public DecimalField ArDiffAmt;
            public DecimalField ApDiscAmt;
            public DecimalField ApDiffAmt;
            public DecimalField ApRfdAmt;
            public DecimalField ArRfdAmt;

            public DecimalField FiscalYearRecnum;
            public StringField FiscalYearAllowEntries;
            public StringField FiscalYearClosed;
            public DecimalField FiscalYearLastPeriod;
            public DateTimeField FiscalYearCreatedDate;
            public StringField FiscalYearCreatedBy;
            public DateTimeField FiscalYearRevisedDate;
            public StringField FiscalYearRevisedBy;
            public DateTimeField FiscalYearClosedDate;
            public StringField FiscalYearClosedBy;
            public DecimalField FiscalYearYtdPlCredit;
            public DecimalField FiscalYearYtdPlDebit;
            public DecimalField FiscalYearYtdPlNet;
            public StringField FiscalYearOwnerBranch;
            public StringField FiscalYearSourceBranch;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.FiscalPeriod";
            }
        }
    }
}
