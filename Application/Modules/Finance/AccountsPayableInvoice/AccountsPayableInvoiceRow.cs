#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsPayableInvoiceRow.cs
// Date: 2018/04/03 20:51

#endregion

using System.Collections.Generic;

namespace Matrix.Finance.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Finance"), TableName("[dbo].[APINVH]")]
    [DisplayName("Vendor Invoice Registry"), InstanceName("Accounts Payable Invoice"), TwoLevelCached]   
    public sealed class AccountsPayableInvoiceRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Control No"), Column("CONTROL_NO"), Size(16), PrimaryKey, QuickSearch]
        public String ControlNo
        {
            get { return Fields.ControlNo[this]; }
            set { Fields.ControlNo[this] = value; }
        }

        [DisplayName("Miscellaneous"), Column("MISCELLANEOUS"), Size(1), NotNull]
        public String Miscellaneous
        {
            get { return Fields.Miscellaneous[this]; }
            set { Fields.Miscellaneous[this] = value; }
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

        [DisplayName("Vendor No"), Column("VENDOR_NO"), Size(8), NotNull]
        public String VendorNo
        {
            get { return Fields.VendorNo[this]; }
            set { Fields.VendorNo[this] = value; }
        }

        [DisplayName("Vendor Name"), Column("VENDOR_NAME"), Size(50)]
        public String VendorName
        {
            get { return Fields.VendorName[this]; }
            set { Fields.VendorName[this] = value; }
        }

        [DisplayName("Invoice No"), Column("INVOICE_NO"), Size(16), NotNull]
        public String InvoiceNo
        {
            get { return Fields.InvoiceNo[this]; }
            set { Fields.InvoiceNo[this] = value; }
        }

        [DisplayName("Invoice Date"), Column("INVOICE_DATE"), NotNull]
        public DateTime? InvoiceDate
        {
            get { return Fields.InvoiceDate[this]; }
            set { Fields.InvoiceDate[this] = value; }
        }

        [DisplayName("Received Date"), Column("RECEIVED_DATE")]
        public DateTime? ReceivedDate
        {
            get { return Fields.ReceivedDate[this]; }
            set { Fields.ReceivedDate[this] = value; }
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

        [DisplayName("Pay Terms"), Column("PAY_TERMS"), Size(6)]
        public String PayTerms
        {
            get { return Fields.PayTerms[this]; }
            set { Fields.PayTerms[this] = value; }
        }

        [DisplayName("Disc Percent"), Column("DISC_PERCENT"), Size(6), Scale(2)]
        public Decimal? DiscPercent
        {
            get { return Fields.DiscPercent[this]; }
            set { Fields.DiscPercent[this] = value; }
        }

        [DisplayName("Disc Days"), Column("DISC_DAYS"), Size(4)]
        public Decimal? DiscDays
        {
            get { return Fields.DiscDays[this]; }
            set { Fields.DiscDays[this] = value; }
        }

        [DisplayName("Net Days"), Column("NET_DAYS"), Size(4)]
        public Decimal? NetDays
        {
            get { return Fields.NetDays[this]; }
            set { Fields.NetDays[this] = value; }
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

        [DisplayName("Planned Date"), Column("PLANNED_DATE"), NotNull]
        public DateTime? PlannedDate
        {
            get { return Fields.PlannedDate[this]; }
            set { Fields.PlannedDate[this] = value; }
        }

        [DisplayName("Payment Branch"), Column("PAYMENT_BRANCH"), Size(4)]
        public String PaymentBranch
        {
            get { return Fields.PaymentBranch[this]; }
            set { Fields.PaymentBranch[this] = value; }
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

        [DisplayName("Tot Price Amt"), Column("TOT_PRICE_AMT"), Size(16), Scale(2)]
        public Decimal? TotPriceAmt
        {
            get { return Fields.TotPriceAmt[this]; }
            set { Fields.TotPriceAmt[this] = value; }
        }

        [DisplayName("Tot Ptax Amt"), Column("TOT_PTAX_AMT"), Size(16), Scale(2)]
        public Decimal? TotPtaxAmt
        {
            get { return Fields.TotPtaxAmt[this]; }
            set { Fields.TotPtaxAmt[this] = value; }
        }

        [DisplayName("Tot Ext Price"), Column("TOT_EXT_PRICE"), Size(16), Scale(2)]
        public Decimal? TotExtPrice
        {
            get { return Fields.TotExtPrice[this]; }
            set { Fields.TotExtPrice[this] = value; }
        }

        [DisplayName("Tot Ldisc Amt"), Column("TOT_LDISC_AMT"), Size(16), Scale(2)]
        public Decimal? TotLdiscAmt
        {
            get { return Fields.TotLdiscAmt[this]; }
            set { Fields.TotLdiscAmt[this] = value; }
        }

        [DisplayName("Tot Atax Amt"), Column("TOT_ATAX_AMT"), Size(16), Scale(2)]
        public Decimal? TotAtaxAmt
        {
            get { return Fields.TotAtaxAmt[this]; }
            set { Fields.TotAtaxAmt[this] = value; }
        }

        [DisplayName("Tot Item Amt"), Column("TOT_ITEM_AMT"), Size(16), Scale(2)]
        public Decimal? TotItemAmt
        {
            get { return Fields.TotItemAmt[this]; }
            set { Fields.TotItemAmt[this] = value; }
        }

        [DisplayName("Tot Tdisc Amt"), Column("TOT_TDISC_AMT"), Size(16), Scale(2)]
        public Decimal? TotTdiscAmt
        {
            get { return Fields.TotTdiscAmt[this]; }
            set { Fields.TotTdiscAmt[this] = value; }
        }

        [DisplayName("Net Trade Amt"), Column("NET_TRADE_AMT"), Size(16), Scale(2)]
        public Decimal? NetTradeAmt
        {
            get { return Fields.NetTradeAmt[this]; }
            set { Fields.NetTradeAmt[this] = value; }
        }

        [DisplayName("Tot Chgs Amt"), Column("TOT_CHGS_AMT"), Size(16), Scale(2)]
        public Decimal? TotChgsAmt
        {
            get { return Fields.TotChgsAmt[this]; }
            set { Fields.TotChgsAmt[this] = value; }
        }

        [DisplayName("Net Ordr Amt"), Column("NET_ORDR_AMT"), Size(16), Scale(2)]
        public Decimal? NetOrdrAmt
        {
            get { return Fields.NetOrdrAmt[this]; }
            set { Fields.NetOrdrAmt[this] = value; }
        }

        [DisplayName("Tot Gtax Amt"), Column("TOT_GTAX_AMT"), Size(16), Scale(2)]
        public Decimal? TotGtaxAmt
        {
            get { return Fields.TotGtaxAmt[this]; }
            set { Fields.TotGtaxAmt[this] = value; }
        }

        [DisplayName("Net Invo Amt"), Column("NET_INVO_AMT"), Size(16), Scale(2)]
        public Decimal? NetInvoAmt
        {
            get { return Fields.NetInvoAmt[this]; }
            set { Fields.NetInvoAmt[this] = value; }
        }

        [DisplayName("Dps Applied"), Column("DPS_APPLIED"), Size(16), Scale(2)]
        public Decimal? DpsApplied
        {
            get { return Fields.DpsApplied[this]; }
            set { Fields.DpsApplied[this] = value; }
        }

        [DisplayName("Net Bal Amt"), Column("NET_BAL_AMT"), Size(16), Scale(2)]
        public Decimal? NetBalAmt
        {
            get { return Fields.NetBalAmt[this]; }
            set { Fields.NetBalAmt[this] = value; }
        }

        [DisplayName("Loc Price Amt"), Column("LOC_PRICE_AMT"), Size(16), Scale(2)]
        public Decimal? LocPriceAmt
        {
            get { return Fields.LocPriceAmt[this]; }
            set { Fields.LocPriceAmt[this] = value; }
        }

        [DisplayName("Loc Ptax Amt"), Column("LOC_PTAX_AMT"), Size(16), Scale(2)]
        public Decimal? LocPtaxAmt
        {
            get { return Fields.LocPtaxAmt[this]; }
            set { Fields.LocPtaxAmt[this] = value; }
        }

        [DisplayName("Loc Ext Price"), Column("LOC_EXT_PRICE"), Size(16), Scale(2)]
        public Decimal? LocExtPrice
        {
            get { return Fields.LocExtPrice[this]; }
            set { Fields.LocExtPrice[this] = value; }
        }

        [DisplayName("Loc Ldisc Amt"), Column("LOC_LDISC_AMT"), Size(16), Scale(2)]
        public Decimal? LocLdiscAmt
        {
            get { return Fields.LocLdiscAmt[this]; }
            set { Fields.LocLdiscAmt[this] = value; }
        }

        [DisplayName("Loc Atax Amt"), Column("LOC_ATAX_AMT"), Size(16), Scale(2)]
        public Decimal? LocAtaxAmt
        {
            get { return Fields.LocAtaxAmt[this]; }
            set { Fields.LocAtaxAmt[this] = value; }
        }

        [DisplayName("Loc Item Amt"), Column("LOC_ITEM_AMT"), Size(16), Scale(2)]
        public Decimal? LocItemAmt
        {
            get { return Fields.LocItemAmt[this]; }
            set { Fields.LocItemAmt[this] = value; }
        }

        [DisplayName("Loc Tdisc Amt"), Column("LOC_TDISC_AMT"), Size(16), Scale(2)]
        public Decimal? LocTdiscAmt
        {
            get { return Fields.LocTdiscAmt[this]; }
            set { Fields.LocTdiscAmt[this] = value; }
        }

        [DisplayName("Loc Chgs Amt"), Column("LOC_CHGS_AMT"), Size(16), Scale(2)]
        public Decimal? LocChgsAmt
        {
            get { return Fields.LocChgsAmt[this]; }
            set { Fields.LocChgsAmt[this] = value; }
        }

        [DisplayName("Loc Gtax Amt"), Column("LOC_GTAX_AMT"), Size(16), Scale(2)]
        public Decimal? LocGtaxAmt
        {
            get { return Fields.LocGtaxAmt[this]; }
            set { Fields.LocGtaxAmt[this] = value; }
        }

        [DisplayName("Loc Invo Amt"), Column("LOC_INVO_AMT"), Size(16), Scale(2)]
        public Decimal? LocInvoAmt
        {
            get { return Fields.LocInvoAmt[this]; }
            set { Fields.LocInvoAmt[this] = value; }
        }

        [DisplayName("Loc Dps Applied"), Column("LOC_DPS_APPLIED"), Size(16), Scale(2)]
        public Decimal? LocDpsApplied
        {
            get { return Fields.LocDpsApplied[this]; }
            set { Fields.LocDpsApplied[this] = value; }
        }

        [DisplayName("Grn Net Amt"), Column("GRN_NET_AMT"), Size(16), Scale(2)]
        public Decimal? GrnNetAmt
        {
            get { return Fields.GrnNetAmt[this]; }
            set { Fields.GrnNetAmt[this] = value; }
        }

        [DisplayName("Lgrn Net Amt"), Column("LGRN_NET_AMT"), Size(16), Scale(2)]
        public Decimal? LgrnNetAmt
        {
            get { return Fields.LgrnNetAmt[this]; }
            set { Fields.LgrnNetAmt[this] = value; }
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

        [DisplayName("Hold"), Column("HOLD"), Size(1), NotNull]
        public String Hold
        {
            get { return Fields.Hold[this]; }
            set { Fields.Hold[this] = value; }
        }

        [DisplayName("Hold Until"), Column("HOLD_UNTIL")]
        public DateTime? HoldUntil
        {
            get { return Fields.HoldUntil[this]; }
            set { Fields.HoldUntil[this] = value; }
        }

        [DisplayName("Hold Date"), Column("HOLD_DATE")]
        public DateTime? HoldDate
        {
            get { return Fields.HoldDate[this]; }
            set { Fields.HoldDate[this] = value; }
        }

        [DisplayName("Hold By"), Column("HOLD_BY"), Size(10)]
        public String HoldBy
        {
            get { return Fields.HoldBy[this]; }
            set { Fields.HoldBy[this] = value; }
        }

        [DisplayName("Acct Vendor"), Column("ACCT_VENDOR"), Size(30)]
        public String AcctVendor
        {
            get { return Fields.AcctVendor[this]; }
            set { Fields.AcctVendor[this] = value; }
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

        [DisplayName("Acct Variance"), Column("ACCT_VARIANCE"), Size(30)]
        public String AcctVariance
        {
            get { return Fields.AcctVariance[this]; }
            set { Fields.AcctVariance[this] = value; }
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

        [DisplayName("Last Log No"), Column("LAST_LOG_NO"), Size(8)]
        public Decimal? LastLogNo
        {
            get { return Fields.LastLogNo[this]; }
            set { Fields.LastLogNo[this] = value; }
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

        [DisplayName("Hold Reason"), Column("HOLD_REASON"), Size(240)]
        public String HoldReason
        {
            get { return Fields.HoldReason[this]; }
            set { Fields.HoldReason[this] = value; }
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

        [DisplayName("Acct Putax"), Column("ACCT_PUTAX"), Size(30)]
        public String AcctPutax
        {
            get { return Fields.AcctPutax[this]; }
            set { Fields.AcctPutax[this] = value; }
        }

        [DisplayName("Putax Type"), Column("PUTAX_TYPE"), Size(1)]
        public String PutaxType
        {
            get { return Fields.PutaxType[this]; }
            set { Fields.PutaxType[this] = value; }
        }

        [DisplayName("Gputax Pcent"), Column("GPUTAX_PCENT"), Size(6), Scale(2)]
        public Decimal? GputaxPcent
        {
            get { return Fields.GputaxPcent[this]; }
            set { Fields.GputaxPcent[this] = value; }
        }

        [DisplayName("Tot Gputax Amt"), Column("TOT_GPUTAX_AMT"), Size(16), Scale(2)]
        public Decimal? TotGputaxAmt
        {
            get { return Fields.TotGputaxAmt[this]; }
            set { Fields.TotGputaxAmt[this] = value; }
        }

        [DisplayName("Tot Lputax Amt"), Column("TOT_LPUTAX_AMT"), Size(16), Scale(2)]
        public Decimal? TotLputaxAmt
        {
            get { return Fields.TotLputaxAmt[this]; }
            set { Fields.TotLputaxAmt[this] = value; }
        }

        [DisplayName("Loc Gputax Amt"), Column("LOC_GPUTAX_AMT"), Size(16), Scale(2)]
        public Decimal? LocGputaxAmt
        {
            get { return Fields.LocGputaxAmt[this]; }
            set { Fields.LocGputaxAmt[this] = value; }
        }

        [DisplayName("Loc Lputax Amt"), Column("LOC_LPUTAX_AMT"), Size(16), Scale(2)]
        public Decimal? LocLputaxAmt
        {
            get { return Fields.LocLputaxAmt[this]; }
            set { Fields.LocLputaxAmt[this] = value; }
        }

        [DisplayName("Grn Putax Type"), Column("GRN_PUTAX_TYPE"), Size(1)]
        public String GrnPutaxType
        {
            get { return Fields.GrnPutaxType[this]; }
            set { Fields.GrnPutaxType[this] = value; }
        }

        [DisplayName("Grn Gputax Pcent"), Column("GRN_GPUTAX_PCENT"), Size(6), Scale(2)]
        public Decimal? GrnGputaxPcent
        {
            get { return Fields.GrnGputaxPcent[this]; }
            set { Fields.GrnGputaxPcent[this] = value; }
        }

        [DisplayName("Grn Count"), Column("GRN_COUNT"), Size(4)]
        public Decimal? GrnCount
        {
            get { return Fields.GrnCount[this]; }
            set { Fields.GrnCount[this] = value; }
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

        [DisplayName("Anlys15"), Column("ANLYS15"), Size(30)]
        public String Anlys15
        {
            get { return Fields.Anlys15[this]; }
            set { Fields.Anlys15[this] = value; }
        }

        [DisplayName("Anlys16"), Column("ANLYS16"), Size(30)]
        public String Anlys16
        {
            get { return Fields.Anlys16[this]; }
            set { Fields.Anlys16[this] = value; }
        }

        [DisplayName("Anlys17"), Column("ANLYS17"), Size(30)]
        public String Anlys17
        {
            get { return Fields.Anlys17[this]; }
            set { Fields.Anlys17[this] = value; }
        }

        [DisplayName("Anlys18"), Column("ANLYS18"), Size(30)]
        public String Anlys18
        {
            get { return Fields.Anlys18[this]; }
            set { Fields.Anlys18[this] = value; }
        }

        [DisplayName("Po No"), Column("PO_NO"), Size(16)]
        public String PoNo
        {
            get { return Fields.PoNo[this]; }
            set { Fields.PoNo[this] = value; }
        }

        [DisplayName("Origin Country"), Column("ORIGIN_COUNTRY"), Size(25)]
        public String OriginCountry
        {
            get { return Fields.OriginCountry[this]; }
            set { Fields.OriginCountry[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ControlNo; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ControlNo; }
        }

        [MasterDetailRelation(foreignKey: "ControlNo")]
        [DisplayName("Detail List"), NotMapped]
        public List<AccountsPayableInvoiceOrderRow> DetailList
        {
            get { return Fields.DetailList[this]; }
            set { Fields.DetailList[this] = value; }
        }

        [MasterDetailRelation(foreignKey: "ControlNo")]
        [DisplayName("Detail List"), NotMapped]
        public List<AccountsPayableInvoiceDetailRow> ItemDetailList
        {
            get { return Fields.ItemDetailList[this]; }
            set { Fields.ItemDetailList[this] = value; }
        }


        public static readonly RowFields Fields = new RowFields().Init();

        public AccountsPayableInvoiceRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public RowListField<AccountsPayableInvoiceOrderRow> DetailList;
            public RowListField<AccountsPayableInvoiceDetailRow> ItemDetailList;
            
            public DecimalField Recnum;
            public StringField ControlNo;
            public StringField Miscellaneous;
            public StringField Posted;
            public StringField Closed;
            public StringField Returned;
            public StringField VendorNo;
            public StringField VendorName;
            public StringField InvoiceNo;
            public DateTimeField InvoiceDate;
            public DateTimeField ReceivedDate;
            public StringField Period;
            public DecimalField FiscalYear;
            public DecimalField PeriodNo;
            public StringField PayTerms;
            public DecimalField DiscPercent;
            public DecimalField DiscDays;
            public DecimalField NetDays;
            public DateTimeField DiscountDate;
            public DateTimeField DueDate;
            public DateTimeField PlannedDate;
            public StringField PaymentBranch;
            public StringField Ccy;
            public DecimalField ExchRate;
            public DecimalField TotPriceAmt;
            public DecimalField TotPtaxAmt;
            public DecimalField TotExtPrice;
            public DecimalField TotLdiscAmt;
            public DecimalField TotAtaxAmt;
            public DecimalField TotItemAmt;
            public DecimalField TotTdiscAmt;
            public DecimalField NetTradeAmt;
            public DecimalField TotChgsAmt;
            public DecimalField NetOrdrAmt;
            public DecimalField TotGtaxAmt;
            public DecimalField NetInvoAmt;
            public DecimalField DpsApplied;
            public DecimalField NetBalAmt;
            public DecimalField LocPriceAmt;
            public DecimalField LocPtaxAmt;
            public DecimalField LocExtPrice;
            public DecimalField LocLdiscAmt;
            public DecimalField LocAtaxAmt;
            public DecimalField LocItemAmt;
            public DecimalField LocTdiscAmt;
            public DecimalField LocChgsAmt;
            public DecimalField LocGtaxAmt;
            public DecimalField LocInvoAmt;
            public DecimalField LocDpsApplied;
            public DecimalField GrnNetAmt;
            public DecimalField LgrnNetAmt;
            public DecimalField VariaAmt;
            public DecimalField LvariaAmt;
            public DecimalField ItemVariaAmt;
            public DecimalField LitemVariaAmt;
            public DecimalField ChgsVariaAmt;
            public DecimalField LchgsVariaAmt;
            public DecimalField LastLineNo;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DateTimeField PostedDate;
            public StringField PostedBy;
            public StringField Hold;
            public DateTimeField HoldUntil;
            public DateTimeField HoldDate;
            public StringField HoldBy;
            public StringField AcctVendor;
            public StringField AcctTdisc;
            public StringField AcctGtax;
            public StringField AcctVariance;
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
            public StringField BatchSelect;
            public StringField GlLink;
            public StringField GlLinkType;
            public StringField GlLinkNo;
            public DecimalField LastLogNo;
            public StringField LockType;
            public StringField LockRefNo;
            public StringField HoldReason;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField Particulars;
            public StringField CheckCrlimit;
            public DecimalField CheckCrbal;
            public StringField AcctPutax;
            public StringField PutaxType;
            public DecimalField GputaxPcent;
            public DecimalField TotGputaxAmt;
            public DecimalField TotLputaxAmt;
            public DecimalField LocGputaxAmt;
            public DecimalField LocLputaxAmt;
            public StringField GrnPutaxType;
            public DecimalField GrnGputaxPcent;
            public DecimalField GrnCount;
            public StringField AiLink;
            public StringField AiLinkType;
            public StringField AiLinkNo;
            public StringField Anlys9;
            public StringField Anlys10;
            public StringField Anlys11;
            public StringField Anlys12;
            public StringField Anlys13;
            public StringField Anlys14;
            public StringField Anlys15;
            public StringField Anlys16;
            public StringField Anlys17;
            public StringField Anlys18;
            public StringField PoNo;
            public StringField OriginCountry;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Finance.AccountsPayableInvoice";
            }
        }
    }
}
