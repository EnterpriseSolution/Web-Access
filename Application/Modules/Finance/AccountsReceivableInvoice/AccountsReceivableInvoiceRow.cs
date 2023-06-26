#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsReceivableInvoiceRow.cs
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

    [ConnectionKey("Finance"), TableName("[dbo].[ARINVH]")]
    [DisplayName("Customer Invoice Registry"), InstanceName("Accounts Receivable Invoice"), TwoLevelCached]   
    public sealed class AccountsReceivableInvoiceRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Invoice No"), Column("INVOICE_NO"), Size(16), PrimaryKey, QuickSearch]
        public String InvoiceNo
        {
            get { return Fields.InvoiceNo[this]; }
            set { Fields.InvoiceNo[this] = value; }
        }

        [DisplayName("Direct Entry"), Column("DIRECT_ENTRY"), Size(1), NotNull]
        public String DirectEntry
        {
            get { return Fields.DirectEntry[this]; }
            set { Fields.DirectEntry[this] = value; }
        }

        [DisplayName("Posted"), Column("POSTED"), Size(1), NotNull]
        public String Posted
        {
            get { return Fields.Posted[this]; }
            set { Fields.Posted[this] = value; }
        }

        [DisplayName("Closed"), Column("CLOSED"), Size(1), NotNull]
        public String Closed
        {
            get { return Fields.Closed[this]; }
            set { Fields.Closed[this] = value; }
        }

        [DisplayName("Returned"), Column("RETURNED"), Size(1), NotNull]
        public String Returned
        {
            get { return Fields.Returned[this]; }
            set { Fields.Returned[this] = value; }
        }

        [DisplayName("Debit Note"), Column("DEBIT_NOTE"), Size(1), NotNull]
        public String DebitNote
        {
            get { return Fields.DebitNote[this]; }
            set { Fields.DebitNote[this] = value; }
        }

        [DisplayName("Customer No"), Column("CUSTOMER_NO"), Size(8), NotNull]
        public String CustomerNo
        {
            get { return Fields.CustomerNo[this]; }
            set { Fields.CustomerNo[this] = value; }
        }

        [DisplayName("Customer Name"), Column("CUSTOMER_NAME"), Size(50)]
        public String CustomerName
        {
            get { return Fields.CustomerName[this]; }
            set { Fields.CustomerName[this] = value; }
        }

        [DisplayName("Address"), Column("ADDRESS"), Size(50)]
        public String Address
        {
            get { return Fields.Address[this]; }
            set { Fields.Address[this] = value; }
        }

        [DisplayName(""), Column("ADDRESS2"), Size(50)]
        public String Address2
        {
            get { return Fields.Address2[this]; }
            set { Fields.Address2[this] = value; }
        }

        [DisplayName(""), Column("ADDRESS3"), Size(50)]
        public String Address3
        {
            get { return Fields.Address3[this]; }
            set { Fields.Address3[this] = value; }
        }

        [DisplayName(""), Column("ADDRESS4"), Size(50)]
        public String Address4
        {
            get { return Fields.Address4[this]; }
            set { Fields.Address4[this] = value; }
        }

        [DisplayName("Attention"), Column("ATTENTION"), Size(30)]
        public String Attention
        {
            get { return Fields.Attention[this]; }
            set { Fields.Attention[this] = value; }
        }

        [DisplayName("Invoice Date"), Column("INVOICE_DATE"), NotNull]
        public DateTime? InvoiceDate
        {
            get { return Fields.InvoiceDate[this]; }
            set { Fields.InvoiceDate[this] = value; }
        }

        [DisplayName("Period"), Column("PERIOD"), Size(7)]
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

        [DisplayName("Salesman"), Column("SALESMAN"), Size(6)]
        public String Salesman
        {
            get { return Fields.Salesman[this]; }
            set { Fields.Salesman[this] = value; }
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

        [DisplayName("Pay Terms"), Column("PAY_TERMS"), Size(6)]
        public String PayTerms
        {
            get { return Fields.PayTerms[this]; }
            set { Fields.PayTerms[this] = value; }
        }

        [DisplayName("Disc Days"), Column("DISC_DAYS"), Size(4)]
        public Decimal? DiscDays
        {
            get { return Fields.DiscDays[this]; }
            set { Fields.DiscDays[this] = value; }
        }

        [DisplayName("Disc Pcent"), Column("DISC_PCENT"), Size(6), Scale(2)]
        public Decimal? DiscPcent
        {
            get { return Fields.DiscPcent[this]; }
            set { Fields.DiscPcent[this] = value; }
        }

        [DisplayName("Due Days"), Column("DUE_DAYS"), Size(4)]
        public Decimal? DueDays
        {
            get { return Fields.DueDays[this]; }
            set { Fields.DueDays[this] = value; }
        }

        [DisplayName("Discount Date"), Column("DISCOUNT_DATE")]
        public DateTime? DiscountDate
        {
            get { return Fields.DiscountDate[this]; }
            set { Fields.DiscountDate[this] = value; }
        }

        [DisplayName("Due Date"), Column("DUE_DATE")]
        public DateTime? DueDate
        {
            get { return Fields.DueDate[this]; }
            set { Fields.DueDate[this] = value; }
        }

        [DisplayName("Expected Date"), Column("EXPECTED_DATE"), NotNull]
        public DateTime? ExpectedDate
        {
            get { return Fields.ExpectedDate[this]; }
            set { Fields.ExpectedDate[this] = value; }
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

        [DisplayName("Tot Price Amt"), Column("TOT_PRICE_AMT"), Size(16), Scale(2)]
        public Decimal? TotPriceAmt
        {
            get { return Fields.TotPriceAmt[this]; }
            set { Fields.TotPriceAmt[this] = value; }
        }

        [DisplayName("Loc Price Amt"), Column("LOC_PRICE_AMT"), Size(16), Scale(2)]
        public Decimal? LocPriceAmt
        {
            get { return Fields.LocPriceAmt[this]; }
            set { Fields.LocPriceAmt[this] = value; }
        }

        [DisplayName("Tot Ptax Amt"), Column("TOT_PTAX_AMT"), Size(16), Scale(2)]
        public Decimal? TotPtaxAmt
        {
            get { return Fields.TotPtaxAmt[this]; }
            set { Fields.TotPtaxAmt[this] = value; }
        }

        [DisplayName("Loc Ptax Amt"), Column("LOC_PTAX_AMT"), Size(16), Scale(2)]
        public Decimal? LocPtaxAmt
        {
            get { return Fields.LocPtaxAmt[this]; }
            set { Fields.LocPtaxAmt[this] = value; }
        }

        [DisplayName("Tot Ext Price"), Column("TOT_EXT_PRICE"), Size(16), Scale(2)]
        public Decimal? TotExtPrice
        {
            get { return Fields.TotExtPrice[this]; }
            set { Fields.TotExtPrice[this] = value; }
        }

        [DisplayName("Loc Ext Price"), Column("LOC_EXT_PRICE"), Size(16), Scale(2)]
        public Decimal? LocExtPrice
        {
            get { return Fields.LocExtPrice[this]; }
            set { Fields.LocExtPrice[this] = value; }
        }

        [DisplayName("Tot Ldisc Amt"), Column("TOT_LDISC_AMT"), Size(16), Scale(2)]
        public Decimal? TotLdiscAmt
        {
            get { return Fields.TotLdiscAmt[this]; }
            set { Fields.TotLdiscAmt[this] = value; }
        }

        [DisplayName("Loc Ldisc Amt"), Column("LOC_LDISC_AMT"), Size(16), Scale(2)]
        public Decimal? LocLdiscAmt
        {
            get { return Fields.LocLdiscAmt[this]; }
            set { Fields.LocLdiscAmt[this] = value; }
        }

        [DisplayName("Tot Atax Amt"), Column("TOT_ATAX_AMT"), Size(16), Scale(2)]
        public Decimal? TotAtaxAmt
        {
            get { return Fields.TotAtaxAmt[this]; }
            set { Fields.TotAtaxAmt[this] = value; }
        }

        [DisplayName("Loc Atax Amt"), Column("LOC_ATAX_AMT"), Size(16), Scale(2)]
        public Decimal? LocAtaxAmt
        {
            get { return Fields.LocAtaxAmt[this]; }
            set { Fields.LocAtaxAmt[this] = value; }
        }

        [DisplayName("Tot Item Amt"), Column("TOT_ITEM_AMT"), Size(16), Scale(2)]
        public Decimal? TotItemAmt
        {
            get { return Fields.TotItemAmt[this]; }
            set { Fields.TotItemAmt[this] = value; }
        }

        [DisplayName("Loc Item Amt"), Column("LOC_ITEM_AMT"), Size(16), Scale(2)]
        public Decimal? LocItemAmt
        {
            get { return Fields.LocItemAmt[this]; }
            set { Fields.LocItemAmt[this] = value; }
        }

        [DisplayName("Tdisc Pcent"), Column("TDISC_PCENT"), Size(6), Scale(2)]
        public Decimal? TdiscPcent
        {
            get { return Fields.TdiscPcent[this]; }
            set { Fields.TdiscPcent[this] = value; }
        }

        [DisplayName("Tdisc Amt"), Column("TDISC_AMT"), Size(16), Scale(2)]
        public Decimal? TdiscAmt
        {
            get { return Fields.TdiscAmt[this]; }
            set { Fields.TdiscAmt[this] = value; }
        }

        [DisplayName("Local Tdisc Amt"), Column("LOCAL_TDISC_AMT"), Size(16), Scale(2)]
        public Decimal? LocalTdiscAmt
        {
            get { return Fields.LocalTdiscAmt[this]; }
            set { Fields.LocalTdiscAmt[this] = value; }
        }

        [DisplayName("Chgs Amt"), Column("CHGS_AMT"), Size(16), Scale(2)]
        public Decimal? ChgsAmt
        {
            get { return Fields.ChgsAmt[this]; }
            set { Fields.ChgsAmt[this] = value; }
        }

        [DisplayName("Loc Chgs Amt"), Column("LOC_CHGS_AMT"), Size(16), Scale(2)]
        public Decimal? LocChgsAmt
        {
            get { return Fields.LocChgsAmt[this]; }
            set { Fields.LocChgsAmt[this] = value; }
        }

        [DisplayName("Gtax Amt"), Column("GTAX_AMT"), Size(16), Scale(2)]
        public Decimal? GtaxAmt
        {
            get { return Fields.GtaxAmt[this]; }
            set { Fields.GtaxAmt[this] = value; }
        }

        [DisplayName("Local Gtax Amt"), Column("LOCAL_GTAX_AMT"), Size(16), Scale(2)]
        public Decimal? LocalGtaxAmt
        {
            get { return Fields.LocalGtaxAmt[this]; }
            set { Fields.LocalGtaxAmt[this] = value; }
        }

        [DisplayName("Net Amt"), Column("NET_AMT"), Size(16), Scale(2)]
        public Decimal? NetAmt
        {
            get { return Fields.NetAmt[this]; }
            set { Fields.NetAmt[this] = value; }
        }

        [DisplayName("Local Net Amt"), Column("LOCAL_NET_AMT"), Size(16), Scale(2)]
        public Decimal? LocalNetAmt
        {
            get { return Fields.LocalNetAmt[this]; }
            set { Fields.LocalNetAmt[this] = value; }
        }

        [DisplayName("Tdisc Amt Cpd"), Column("TDISC_AMT_CPD"), Size(12), Scale(2)]
        public Decimal? TdiscAmtCpd
        {
            get { return Fields.TdiscAmtCpd[this]; }
            set { Fields.TdiscAmtCpd[this] = value; }
        }

        [DisplayName("Last Line No"), Column("LAST_LINE_NO"), Size(8)]
        public Decimal? LastLineNo
        {
            get { return Fields.LastLineNo[this]; }
            set { Fields.LastLineNo[this] = value; }
        }

        [DisplayName("Created Date"), Column("CREATED_DATE"), NotNull]
        public DateTime? CreatedDate
        {
            get { return Fields.CreatedDate[this]; }
            set { Fields.CreatedDate[this] = value; }
        }

        [DisplayName("Created By"), Column("CREATED_BY"), Size(10), NotNull]
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

        [DisplayName("Posted Date"), Column("POSTED_DATE")]
        public DateTime? PostedDate
        {
            get { return Fields.PostedDate[this]; }
            set { Fields.PostedDate[this] = value; }
        }

        [DisplayName("Posted By"), Column("POSTED_BY"), Size(10)]
        public String PostedBy
        {
            get { return Fields.PostedBy[this]; }
            set { Fields.PostedBy[this] = value; }
        }

        [DisplayName("Last Log No"), Column("LAST_LOG_NO"), Size(8)]
        public Decimal? LastLogNo
        {
            get { return Fields.LastLogNo[this]; }
            set { Fields.LastLogNo[this] = value; }
        }

        [DisplayName("Settled Amt"), Column("SETTLED_AMT"), Size(16), Scale(2)]
        public Decimal? SettledAmt
        {
            get { return Fields.SettledAmt[this]; }
            set { Fields.SettledAmt[this] = value; }
        }

        [DisplayName("Lsettled Amt"), Column("LSETTLED_AMT"), Size(16), Scale(2)]
        public Decimal? LsettledAmt
        {
            get { return Fields.LsettledAmt[this]; }
            set { Fields.LsettledAmt[this] = value; }
        }

        [DisplayName("Term Disc Amt"), Column("TERM_DISC_AMT"), Size(16), Scale(2)]
        public Decimal? TermDiscAmt
        {
            get { return Fields.TermDiscAmt[this]; }
            set { Fields.TermDiscAmt[this] = value; }
        }

        [DisplayName("Lterm Disc Amt"), Column("LTERM_DISC_AMT"), Size(16), Scale(2)]
        public Decimal? LtermDiscAmt
        {
            get { return Fields.LtermDiscAmt[this]; }
            set { Fields.LtermDiscAmt[this] = value; }
        }

        [DisplayName("Return Amt"), Column("RETURN_AMT"), Size(16), Scale(2)]
        public Decimal? ReturnAmt
        {
            get { return Fields.ReturnAmt[this]; }
            set { Fields.ReturnAmt[this] = value; }
        }

        [DisplayName("Lreturn Amt"), Column("LRETURN_AMT"), Size(16), Scale(2)]
        public Decimal? LreturnAmt
        {
            get { return Fields.LreturnAmt[this]; }
            set { Fields.LreturnAmt[this] = value; }
        }

        [DisplayName("Bal Amt"), Column("BAL_AMT"), Size(16), Scale(2)]
        public Decimal? BalAmt
        {
            get { return Fields.BalAmt[this]; }
            set { Fields.BalAmt[this] = value; }
        }

        [DisplayName("Bal Amt Local"), Column("BAL_AMT_LOCAL"), Size(16), Scale(2)]
        public Decimal? BalAmtLocal
        {
            get { return Fields.BalAmtLocal[this]; }
            set { Fields.BalAmtLocal[this] = value; }
        }

        [DisplayName("Over Alloc Amt"), Column("OVER_ALLOC_AMT"), Size(16), Scale(2)]
        public Decimal? OverAllocAmt
        {
            get { return Fields.OverAllocAmt[this]; }
            set { Fields.OverAllocAmt[this] = value; }
        }

        [DisplayName("Lover Alloc Amt"), Column("LOVER_ALLOC_AMT"), Size(16), Scale(2)]
        public Decimal? LoverAllocAmt
        {
            get { return Fields.LoverAllocAmt[this]; }
            set { Fields.LoverAllocAmt[this] = value; }
        }

        [DisplayName("Acct Customer"), Column("ACCT_CUSTOMER"), Size(30)]
        public String AcctCustomer
        {
            get { return Fields.AcctCustomer[this]; }
            set { Fields.AcctCustomer[this] = value; }
        }

        [DisplayName("Acct Tdisc"), Column("ACCT_TDISC"), Size(30)]
        public String AcctTdisc
        {
            get { return Fields.AcctTdisc[this]; }
            set { Fields.AcctTdisc[this] = value; }
        }

        [DisplayName("Acct Gtax"), Column("ACCT_GTAX"), Size(30)]
        public String AcctGtax
        {
            get { return Fields.AcctGtax[this]; }
            set { Fields.AcctGtax[this] = value; }
        }

        [DisplayName("Lock Type"), Column("LOCK_TYPE"), Size(12)]
        public String LockType
        {
            get { return Fields.LockType[this]; }
            set { Fields.LockType[this] = value; }
        }

        [DisplayName("Lock Ref No"), Column("LOCK_REF_NO"), Size(16)]
        public String LockRefNo
        {
            get { return Fields.LockRefNo[this]; }
            set { Fields.LockRefNo[this] = value; }
        }

        [DisplayName("Batch Select"), Column("BATCH_SELECT"), Size(1)]
        public String BatchSelect
        {
            get { return Fields.BatchSelect[this]; }
            set { Fields.BatchSelect[this] = value; }
        }

        [DisplayName("Gl Link"), Column("GL_LINK"), Size(1)]
        public String GlLink
        {
            get { return Fields.GlLink[this]; }
            set { Fields.GlLink[this] = value; }
        }

        [DisplayName("Gl Link Type"), Column("GL_LINK_TYPE"), Size(6)]
        public String GlLinkType
        {
            get { return Fields.GlLinkType[this]; }
            set { Fields.GlLinkType[this] = value; }
        }

        [DisplayName("Gl Link No"), Column("GL_LINK_NO"), Size(16)]
        public String GlLinkNo
        {
            get { return Fields.GlLinkNo[this]; }
            set { Fields.GlLinkNo[this] = value; }
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

        [DisplayName("Check Crlimit"), Column("CHECK_CRLIMIT"), Size(1)]
        public String CheckCrlimit
        {
            get { return Fields.CheckCrlimit[this]; }
            set { Fields.CheckCrlimit[this] = value; }
        }

        [DisplayName("Check Crbal"), Column("CHECK_CRBAL"), Size(16), Scale(2)]
        public Decimal? CheckCrbal
        {
            get { return Fields.CheckCrbal[this]; }
            set { Fields.CheckCrbal[this] = value; }
        }

        [DisplayName("Comments1"), Column("COMMENTS1"), Size(1073741823)]
        public String Comments1
        {
            get { return Fields.Comments1[this]; }
            set { Fields.Comments1[this] = value; }
        }

        [DisplayName("Comments2"), Column("COMMENTS2"), Size(1073741823)]
        public String Comments2
        {
            get { return Fields.Comments2[this]; }
            set { Fields.Comments2[this] = value; }
        }

        [DisplayName("Comments3"), Column("COMMENTS3"), Size(1073741823)]
        public String Comments3
        {
            get { return Fields.Comments3[this]; }
            set { Fields.Comments3[this] = value; }
        }

        [DisplayName("Comments4"), Column("COMMENTS4"), Size(1073741823)]
        public String Comments4
        {
            get { return Fields.Comments4[this]; }
            set { Fields.Comments4[this] = value; }
        }

        [DisplayName("Last Text No"), Column("LAST_TEXT_NO"), Size(4)]
        public Decimal? LastTextNo
        {
            get { return Fields.LastTextNo[this]; }
            set { Fields.LastTextNo[this] = value; }
        }

        [DisplayName("Ship To"), Column("SHIP_TO"), Size(6)]
        public String ShipTo
        {
            get { return Fields.ShipTo[this]; }
            set { Fields.ShipTo[this] = value; }
        }

        [DisplayName("Tel No"), Column("TEL_NO"), Size(30)]
        public String TelNo
        {
            get { return Fields.TelNo[this]; }
            set { Fields.TelNo[this] = value; }
        }

        [DisplayName("Fax No"), Column("FAX_NO"), Size(30)]
        public String FaxNo
        {
            get { return Fields.FaxNo[this]; }
            set { Fields.FaxNo[this] = value; }
        }

        [DisplayName("Sltax Type"), Column("SLTAX_TYPE"), Size(1)]
        public String SltaxType
        {
            get { return Fields.SltaxType[this]; }
            set { Fields.SltaxType[this] = value; }
        }

        [DisplayName("Gsltax Pcent"), Column("GSLTAX_PCENT"), Size(6), Scale(2)]
        public Decimal? GsltaxPcent
        {
            get { return Fields.GsltaxPcent[this]; }
            set { Fields.GsltaxPcent[this] = value; }
        }

        [DisplayName("Tot Gsltax Amt"), Column("TOT_GSLTAX_AMT"), Size(16), Scale(2)]
        public Decimal? TotGsltaxAmt
        {
            get { return Fields.TotGsltaxAmt[this]; }
            set { Fields.TotGsltaxAmt[this] = value; }
        }

        [DisplayName("Tot Lsltax Amt"), Column("TOT_LSLTAX_AMT"), Size(16), Scale(2)]
        public Decimal? TotLsltaxAmt
        {
            get { return Fields.TotLsltaxAmt[this]; }
            set { Fields.TotLsltaxAmt[this] = value; }
        }

        [DisplayName("Loc Gsltax Amt"), Column("LOC_GSLTAX_AMT"), Size(16), Scale(2)]
        public Decimal? LocGsltaxAmt
        {
            get { return Fields.LocGsltaxAmt[this]; }
            set { Fields.LocGsltaxAmt[this] = value; }
        }

        [DisplayName("Loc Lsltax Amt"), Column("LOC_LSLTAX_AMT"), Size(16), Scale(2)]
        public Decimal? LocLsltaxAmt
        {
            get { return Fields.LocLsltaxAmt[this]; }
            set { Fields.LocLsltaxAmt[this] = value; }
        }

        [DisplayName("Acct Sltax"), Column("ACCT_SLTAX"), Size(30)]
        public String AcctSltax
        {
            get { return Fields.AcctSltax[this]; }
            set { Fields.AcctSltax[this] = value; }
        }

        [DisplayName("Customer Po"), Column("CUSTOMER_PO"), Size(20)]
        public String CustomerPo
        {
            get { return Fields.CustomerPo[this]; }
            set { Fields.CustomerPo[this] = value; }
        }

        [DisplayName("Ai Link"), Column("AI_LINK"), Size(1), NotNull]
        public String AiLink
        {
            get { return Fields.AiLink[this]; }
            set { Fields.AiLink[this] = value; }
        }

        [DisplayName("Ai Link Type"), Column("AI_LINK_TYPE"), Size(6)]
        public String AiLinkType
        {
            get { return Fields.AiLinkType[this]; }
            set { Fields.AiLinkType[this] = value; }
        }

        [DisplayName("Ai Link No"), Column("AI_LINK_NO"), Size(16)]
        public String AiLinkNo
        {
            get { return Fields.AiLinkNo[this]; }
            set { Fields.AiLinkNo[this] = value; }
        }

        [DisplayName("Anlys7"), Column("ANLYS7"), Size(30)]
        public String Anlys7
        {
            get { return Fields.Anlys7[this]; }
            set { Fields.Anlys7[this] = value; }
        }

        [DisplayName("Anlys8"), Column("ANLYS8"), Size(30)]
        public String Anlys8
        {
            get { return Fields.Anlys8[this]; }
            set { Fields.Anlys8[this] = value; }
        }

        [DisplayName("Net Trade Amt"), Column("NET_TRADE_AMT"), Size(16), Scale(2)]
        public Decimal? NetTradeAmt
        {
            get { return Fields.NetTradeAmt[this]; }
            set { Fields.NetTradeAmt[this] = value; }
        }

        [DisplayName("Net Ordr Amt"), Column("NET_ORDR_AMT"), Size(16), Scale(2)]
        public Decimal? NetOrdrAmt
        {
            get { return Fields.NetOrdrAmt[this]; }
            set { Fields.NetOrdrAmt[this] = value; }
        }

        [DisplayName("Ship Amt"), Column("SHIP_AMT"), Size(16), Scale(2)]
        public Decimal? ShipAmt
        {
            get { return Fields.ShipAmt[this]; }
            set { Fields.ShipAmt[this] = value; }
        }

        [DisplayName("Lship Amt"), Column("LSHIP_AMT"), Size(16), Scale(2)]
        public Decimal? LshipAmt
        {
            get { return Fields.LshipAmt[this]; }
            set { Fields.LshipAmt[this] = value; }
        }

        [DisplayName("Varia Amt"), Column("VARIA_AMT"), Size(16), Scale(2)]
        public Decimal? VariaAmt
        {
            get { return Fields.VariaAmt[this]; }
            set { Fields.VariaAmt[this] = value; }
        }

        [DisplayName("Lvaria Amt"), Column("LVARIA_AMT"), Size(16), Scale(2)]
        public Decimal? LvariaAmt
        {
            get { return Fields.LvariaAmt[this]; }
            set { Fields.LvariaAmt[this] = value; }
        }

        [DisplayName("Item Varia Amt"), Column("ITEM_VARIA_AMT"), Size(16), Scale(2)]
        public Decimal? ItemVariaAmt
        {
            get { return Fields.ItemVariaAmt[this]; }
            set { Fields.ItemVariaAmt[this] = value; }
        }

        [DisplayName("Litem Varia Amt"), Column("LITEM_VARIA_AMT"), Size(16), Scale(2)]
        public Decimal? LitemVariaAmt
        {
            get { return Fields.LitemVariaAmt[this]; }
            set { Fields.LitemVariaAmt[this] = value; }
        }

        [DisplayName("Chgs Varia Amt"), Column("CHGS_VARIA_AMT"), Size(16), Scale(2)]
        public Decimal? ChgsVariaAmt
        {
            get { return Fields.ChgsVariaAmt[this]; }
            set { Fields.ChgsVariaAmt[this] = value; }
        }

        [DisplayName("Lchgs Varia Amt"), Column("LCHGS_VARIA_AMT"), Size(16), Scale(2)]
        public Decimal? LchgsVariaAmt
        {
            get { return Fields.LchgsVariaAmt[this]; }
            set { Fields.LchgsVariaAmt[this] = value; }
        }

        [DisplayName("Dps Applied"), Column("DPS_APPLIED"), Size(12), Scale(2)]
        public Decimal? DpsApplied
        {
            get { return Fields.DpsApplied[this]; }
            set { Fields.DpsApplied[this] = value; }
        }

        [DisplayName("Loc Dps Applied"), Column("LOC_DPS_APPLIED"), Size(12), Scale(2)]
        public Decimal? LocDpsApplied
        {
            get { return Fields.LocDpsApplied[this]; }
            set { Fields.LocDpsApplied[this] = value; }
        }

        [DisplayName("Ship Sltax Type"), Column("SHIP_SLTAX_TYPE"), Size(1)]
        public String ShipSltaxType
        {
            get { return Fields.ShipSltaxType[this]; }
            set { Fields.ShipSltaxType[this] = value; }
        }

        [DisplayName("Ship Gsltax Pcent"), Column("SHIP_GSLTAX_PCENT"), Size(6), Scale(2)]
        public Decimal? ShipGsltaxPcent
        {
            get { return Fields.ShipGsltaxPcent[this]; }
            set { Fields.ShipGsltaxPcent[this] = value; }
        }

        [DisplayName("Ship Count"), Column("SHIP_COUNT"), Size(4)]
        public Decimal? ShipCount
        {
            get { return Fields.ShipCount[this]; }
            set { Fields.ShipCount[this] = value; }
        }

        [DisplayName("Source Type"), Column("SOURCE_TYPE"), Size(1)]
        public String SourceType
        {
            get { return Fields.SourceType[this]; }
            set { Fields.SourceType[this] = value; }
        }

        [DisplayName("Last Chgs No"), Column("LAST_CHGS_NO"), Size(8)]
        public Decimal? LastChgsNo
        {
            get { return Fields.LastChgsNo[this]; }
            set { Fields.LastChgsNo[this] = value; }
        }

        [DisplayName("Doc Type"), Column("DOC_TYPE"), Size(30)]
        public String DocType
        {
            get { return Fields.DocType[this]; }
            set { Fields.DocType[this] = value; }
        }

        [DisplayName("Doc Id"), Column("DOC_ID"), Size(30)]
        public String DocId
        {
            get { return Fields.DocId[this]; }
            set { Fields.DocId[this] = value; }
        }

        [DisplayName("Anlys9"), Column("ANLYS9"), Size(30)]
        public String Anlys9
        {
            get { return Fields.Anlys9[this]; }
            set { Fields.Anlys9[this] = value; }
        }

        [DisplayName("Anlys10"), Column("ANLYS10"), Size(30)]
        public String Anlys10
        {
            get { return Fields.Anlys10[this]; }
            set { Fields.Anlys10[this] = value; }
        }

        [DisplayName("Anlys11"), Column("ANLYS11"), Size(30)]
        public String Anlys11
        {
            get { return Fields.Anlys11[this]; }
            set { Fields.Anlys11[this] = value; }
        }

        [DisplayName("Anlys12"), Column("ANLYS12"), Size(30)]
        public String Anlys12
        {
            get { return Fields.Anlys12[this]; }
            set { Fields.Anlys12[this] = value; }
        }

        [DisplayName("Anlys13"), Column("ANLYS13"), Size(30)]
        public String Anlys13
        {
            get { return Fields.Anlys13[this]; }
            set { Fields.Anlys13[this] = value; }
        }

        [DisplayName("Anlys14"), Column("ANLYS14"), Size(30)]
        public String Anlys14
        {
            get { return Fields.Anlys14[this]; }
            set { Fields.Anlys14[this] = value; }
        }

        [DisplayName("Break Debit Note"), Column("BREAK_DEBIT_NOTE")]
        public Boolean? BreakDebitNote
        {
            get { return Fields.BreakDebitNote[this]; }
            set { Fields.BreakDebitNote[this] = value; }
        }

        [DisplayName("Freezed"), Column("FREEZED")]
        public Boolean? Freezed
        {
            get { return Fields.Freezed[this]; }
            set { Fields.Freezed[this] = value; }
        }

        [DisplayName("Related Debit Note"), Column("RELATED_DEBIT_NOTE"), Size(16)]
        public String RelatedDebitNote
        {
            get { return Fields.RelatedDebitNote[this]; }
            set { Fields.RelatedDebitNote[this] = value; }
        }

        [DisplayName("Cloned"), Column("CLONED")]
        public Boolean? Cloned
        {
            get { return Fields.Cloned[this]; }
            set { Fields.Cloned[this] = value; }
        }

        [DisplayName("Cloned Company Code"), Column("CLONED_COMPANY_CODE"), Size(10)]
        public String ClonedCompanyCode
        {
            get { return Fields.ClonedCompanyCode[this]; }
            set { Fields.ClonedCompanyCode[this] = value; }
        }

        [DisplayName("Use Sample Acct"), Column("USE_SAMPLE_ACCT"), NotNull]
        public Boolean? UseSampleAcct
        {
            get { return Fields.UseSampleAcct[this]; }
            set { Fields.UseSampleAcct[this] = value; }
        }

        [DisplayName("Reference Date"), Column("REFERENCE_DATE")]
        public DateTime? ReferenceDate
        {
            get { return Fields.ReferenceDate[this]; }
            set { Fields.ReferenceDate[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.InvoiceNo; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.InvoiceNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        [MasterDetailRelation(foreignKey: "InvoiceNo")]
        [DisplayName("Detail List"), NotMapped]
        public System.Collections.Generic.List<AccountsReceivableInvoiceOrderRow> OrderList
        {
            get { return Fields.OrderList[this]; }
            set { Fields.OrderList[this] = value; }
        }

        [MasterDetailRelation(foreignKey: "InvoiceNo")]
        [DisplayName("Detail List"), NotMapped]
        public System.Collections.Generic.List<AccountsReceivableInvoiceDetailRow> DetailList
        {
            get { return Fields.DetailList[this]; }
            set { Fields.DetailList[this] = value; }
        }

        [MasterDetailRelation(foreignKey: "InvoiceNo")]
        [DisplayName("Detail List"), NotMapped]
        public System.Collections.Generic.List<AccountsReceivableCommissionRow> CommissionList
        {
            get { return Fields.CommissionList[this]; }
            set { Fields.CommissionList[this] = value; }
        }


        public AccountsReceivableInvoiceRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public RowListField<AccountsReceivableInvoiceOrderRow> OrderList;
            public RowListField<AccountsReceivableInvoiceDetailRow> DetailList;
            public RowListField<AccountsReceivableCommissionRow> CommissionList;

            public DecimalField Recnum;
            public StringField InvoiceNo;
            public StringField DirectEntry;
            public StringField Posted;
            public StringField Closed;
            public StringField Returned;
            public StringField DebitNote;
            public StringField CustomerNo;
            public StringField CustomerName;
            public StringField Address;
            public StringField Address2;
            public StringField Address3;
            public StringField Address4;
            public StringField Attention;
            public DateTimeField InvoiceDate;
            public StringField Period;
            public DecimalField FiscalYear;
            public DecimalField PeriodNo;
            public StringField Salesman;
            public StringField Ccy;
            public DecimalField ExchRate;
            public StringField PayTerms;
            public DecimalField DiscDays;
            public DecimalField DiscPcent;
            public DecimalField DueDays;
            public DateTimeField DiscountDate;
            public DateTimeField DueDate;
            public DateTimeField ExpectedDate;
            public StringField Anlys1;
            public StringField Anlys2;
            public DecimalField TotPriceAmt;
            public DecimalField LocPriceAmt;
            public DecimalField TotPtaxAmt;
            public DecimalField LocPtaxAmt;
            public DecimalField TotExtPrice;
            public DecimalField LocExtPrice;
            public DecimalField TotLdiscAmt;
            public DecimalField LocLdiscAmt;
            public DecimalField TotAtaxAmt;
            public DecimalField LocAtaxAmt;
            public DecimalField TotItemAmt;
            public DecimalField LocItemAmt;
            public DecimalField TdiscPcent;
            public DecimalField TdiscAmt;
            public DecimalField LocalTdiscAmt;
            public DecimalField ChgsAmt;
            public DecimalField LocChgsAmt;
            public DecimalField GtaxAmt;
            public DecimalField LocalGtaxAmt;
            public DecimalField NetAmt;
            public DecimalField LocalNetAmt;
            public DecimalField TdiscAmtCpd;
            public DecimalField LastLineNo;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DateTimeField PostedDate;
            public StringField PostedBy;
            public DecimalField LastLogNo;
            public DecimalField SettledAmt;
            public DecimalField LsettledAmt;
            public DecimalField TermDiscAmt;
            public DecimalField LtermDiscAmt;
            public DecimalField ReturnAmt;
            public DecimalField LreturnAmt;
            public DecimalField BalAmt;
            public DecimalField BalAmtLocal;
            public DecimalField OverAllocAmt;
            public DecimalField LoverAllocAmt;
            public StringField AcctCustomer;
            public StringField AcctTdisc;
            public StringField AcctGtax;
            public StringField LockType;
            public StringField LockRefNo;
            public StringField BatchSelect;
            public StringField GlLink;
            public StringField GlLinkType;
            public StringField GlLinkNo;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField CheckCrlimit;
            public DecimalField CheckCrbal;
            public StringField Comments1;
            public StringField Comments2;
            public StringField Comments3;
            public StringField Comments4;
            public DecimalField LastTextNo;
            public StringField ShipTo;
            public StringField TelNo;
            public StringField FaxNo;
            public StringField SltaxType;
            public DecimalField GsltaxPcent;
            public DecimalField TotGsltaxAmt;
            public DecimalField TotLsltaxAmt;
            public DecimalField LocGsltaxAmt;
            public DecimalField LocLsltaxAmt;
            public StringField AcctSltax;
            public StringField CustomerPo;
            public StringField AiLink;
            public StringField AiLinkType;
            public StringField AiLinkNo;
            public StringField Anlys7;
            public StringField Anlys8;
            public DecimalField NetTradeAmt;
            public DecimalField NetOrdrAmt;
            public DecimalField ShipAmt;
            public DecimalField LshipAmt;
            public DecimalField VariaAmt;
            public DecimalField LvariaAmt;
            public DecimalField ItemVariaAmt;
            public DecimalField LitemVariaAmt;
            public DecimalField ChgsVariaAmt;
            public DecimalField LchgsVariaAmt;
            public DecimalField DpsApplied;
            public DecimalField LocDpsApplied;
            public StringField ShipSltaxType;
            public DecimalField ShipGsltaxPcent;
            public DecimalField ShipCount;
            public StringField SourceType;
            public DecimalField LastChgsNo;
            public StringField DocType;
            public StringField DocId;
            public StringField Anlys9;
            public StringField Anlys10;
            public StringField Anlys11;
            public StringField Anlys12;
            public StringField Anlys13;
            public StringField Anlys14;
            public BooleanField BreakDebitNote;
            public BooleanField Freezed;
            public StringField RelatedDebitNote;
            public BooleanField Cloned;
            public StringField ClonedCompanyCode;
            public BooleanField UseSampleAcct;
            public DateTimeField ReferenceDate;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Finance.AccountsReceivableInvoice";
            }
        }
    }
}
