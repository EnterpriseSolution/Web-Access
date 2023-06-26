#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  GrnRow.cs
// Date: 2018/04/03 20:51

#endregion

using System.Collections.Generic;

namespace Matrix.Purchasing.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Purchasing"), TableName("[dbo].[PUGRNH]")]
    [DisplayName("Purchase Receipt Processing"), InstanceName("Purchase Receipt"), TwoLevelCached]   
    public sealed class GrnRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Grn No"), Column("GRN_NO"), Size(16), PrimaryKey, QuickSearch]
        public String GrnNo
        {
            get { return Fields.GrnNo[this]; }
            set { Fields.GrnNo[this] = value; }
        }

        [DisplayName("Entry Method"), Column("ENTRY_METHOD"), Size(1), NotNull]
        public String EntryMethod
        {
            get { return Fields.EntryMethod[this]; }
            set { Fields.EntryMethod[this] = value; }
        }

        [DisplayName("With Invoice"), Column("WITH_INVOICE"), Size(1), NotNull]
        public String WithInvoice
        {
            get { return Fields.WithInvoice[this]; }
            set { Fields.WithInvoice[this] = value; }
        }

        [DisplayName("Received Date"), Column("RECEIVED_DATE"), NotNull]
        public DateTime? ReceivedDate
        {
            get { return Fields.ReceivedDate[this]; }
            set { Fields.ReceivedDate[this] = value; }
        }

        [DisplayName("Posted"), Column("POSTED"), Size(1), NotNull]
        public String Posted
        {
            get { return Fields.Posted[this]; }
            set { Fields.Posted[this] = value; }
        }

        [DisplayName("Inspected"), Column("INSPECTED"), Size(1), NotNull]
        public String Inspected
        {
            get { return Fields.Inspected[this]; }
            set { Fields.Inspected[this] = value; }
        }

        [DisplayName("Returned"), Column("RETURNED"), Size(1)]
        public String Returned
        {
            get { return Fields.Returned[this]; }
            set { Fields.Returned[this] = value; }
        }

        [DisplayName("Ship To"), Column("SHIP_TO"), Size(4), NotNull]
        public String ShipTo
        {
            get { return Fields.ShipTo[this]; }
            set { Fields.ShipTo[this] = value; }
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

        [DisplayName("Do No"), Column("DO_NO"), Size(16), NotNull]
        public String DoNo
        {
            get { return Fields.DoNo[this]; }
            set { Fields.DoNo[this] = value; }
        }

        [DisplayName("Invoice No"), Column("INVOICE_NO"), Size(16)]
        public String InvoiceNo
        {
            get { return Fields.InvoiceNo[this]; }
            set { Fields.InvoiceNo[this] = value; }
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

        [DisplayName("Compute Tax"), Column("COMPUTE_TAX"), Size(1)]
        public String ComputeTax
        {
            get { return Fields.ComputeTax[this]; }
            set { Fields.ComputeTax[this] = value; }
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

        [DisplayName("Net Pay Amt"), Column("NET_PAY_AMT"), Size(16), Scale(2)]
        public Decimal? NetPayAmt
        {
            get { return Fields.NetPayAmt[this]; }
            set { Fields.NetPayAmt[this] = value; }
        }

        [DisplayName("Dps Cover"), Column("DPS_COVER"), Size(16), Scale(2)]
        public Decimal? DpsCover
        {
            get { return Fields.DpsCover[this]; }
            set { Fields.DpsCover[this] = value; }
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

        [DisplayName("Loc Pay Amt"), Column("LOC_PAY_AMT"), Size(16), Scale(2)]
        public Decimal? LocPayAmt
        {
            get { return Fields.LocPayAmt[this]; }
            set { Fields.LocPayAmt[this] = value; }
        }

        [DisplayName("Loc Dps Applied"), Column("LOC_DPS_APPLIED"), Size(16), Scale(2)]
        public Decimal? LocDpsApplied
        {
            get { return Fields.LocDpsApplied[this]; }
            set { Fields.LocDpsApplied[this] = value; }
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

        [DisplayName("Last Order No"), Column("LAST_ORDER_NO"), Size(4)]
        public Decimal? LastOrderNo
        {
            get { return Fields.LastOrderNo[this]; }
            set { Fields.LastOrderNo[this] = value; }
        }

        [DisplayName("Last Entry No"), Column("LAST_ENTRY_NO"), Size(8)]
        public Decimal? LastEntryNo
        {
            get { return Fields.LastEntryNo[this]; }
            set { Fields.LastEntryNo[this] = value; }
        }

        [DisplayName("Last Chgs No"), Column("LAST_CHGS_NO"), Size(6)]
        public Decimal? LastChgsNo
        {
            get { return Fields.LastChgsNo[this]; }
            set { Fields.LastChgsNo[this] = value; }
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

        [DisplayName("Last Log No"), Column("LAST_LOG_NO"), Size(8)]
        public Decimal? LastLogNo
        {
            get { return Fields.LastLogNo[this]; }
            set { Fields.LastLogNo[this] = value; }
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

        [DisplayName("Vend Tax Code"), Column("VEND_TAX_CODE"), Size(8)]
        public String VendTaxCode
        {
            get { return Fields.VendTaxCode[this]; }
            set { Fields.VendTaxCode[this] = value; }
        }

        [DisplayName("Cust Tax Code"), Column("CUST_TAX_CODE"), Size(8)]
        public String CustTaxCode
        {
            get { return Fields.CustTaxCode[this]; }
            set { Fields.CustTaxCode[this] = value; }
        }

        [DisplayName("Ret Price Amt"), Column("RET_PRICE_AMT"), Size(16), Scale(2)]
        public Decimal? RetPriceAmt
        {
            get { return Fields.RetPriceAmt[this]; }
            set { Fields.RetPriceAmt[this] = value; }
        }

        [DisplayName("Ret Ptax Amt"), Column("RET_PTAX_AMT"), Size(16), Scale(2)]
        public Decimal? RetPtaxAmt
        {
            get { return Fields.RetPtaxAmt[this]; }
            set { Fields.RetPtaxAmt[this] = value; }
        }

        [DisplayName("Ret Ext Price"), Column("RET_EXT_PRICE"), Size(16), Scale(2)]
        public Decimal? RetExtPrice
        {
            get { return Fields.RetExtPrice[this]; }
            set { Fields.RetExtPrice[this] = value; }
        }

        [DisplayName("Ret Ldisc Amt"), Column("RET_LDISC_AMT"), Size(16), Scale(2)]
        public Decimal? RetLdiscAmt
        {
            get { return Fields.RetLdiscAmt[this]; }
            set { Fields.RetLdiscAmt[this] = value; }
        }

        [DisplayName("Ret Atax Amt"), Column("RET_ATAX_AMT"), Size(16), Scale(2)]
        public Decimal? RetAtaxAmt
        {
            get { return Fields.RetAtaxAmt[this]; }
            set { Fields.RetAtaxAmt[this] = value; }
        }

        [DisplayName("Ret Item Amt"), Column("RET_ITEM_AMT"), Size(16), Scale(2)]
        public Decimal? RetItemAmt
        {
            get { return Fields.RetItemAmt[this]; }
            set { Fields.RetItemAmt[this] = value; }
        }

        [DisplayName("Ret Tdisc Amt"), Column("RET_TDISC_AMT"), Size(16), Scale(2)]
        public Decimal? RetTdiscAmt
        {
            get { return Fields.RetTdiscAmt[this]; }
            set { Fields.RetTdiscAmt[this] = value; }
        }

        [DisplayName("Ret Gtax Amt"), Column("RET_GTAX_AMT"), Size(16), Scale(2)]
        public Decimal? RetGtaxAmt
        {
            get { return Fields.RetGtaxAmt[this]; }
            set { Fields.RetGtaxAmt[this] = value; }
        }

        [DisplayName("Ret Chgs Amt"), Column("RET_CHGS_AMT"), Size(16), Scale(2)]
        public Decimal? RetChgsAmt
        {
            get { return Fields.RetChgsAmt[this]; }
            set { Fields.RetChgsAmt[this] = value; }
        }

        [DisplayName("Ret Pay Amt"), Column("RET_PAY_AMT"), Size(16), Scale(2)]
        public Decimal? RetPayAmt
        {
            get { return Fields.RetPayAmt[this]; }
            set { Fields.RetPayAmt[this] = value; }
        }

        [DisplayName("Lret Price Amt"), Column("LRET_PRICE_AMT"), Size(16), Scale(2)]
        public Decimal? LretPriceAmt
        {
            get { return Fields.LretPriceAmt[this]; }
            set { Fields.LretPriceAmt[this] = value; }
        }

        [DisplayName("Lret Ptax Amt"), Column("LRET_PTAX_AMT"), Size(16), Scale(2)]
        public Decimal? LretPtaxAmt
        {
            get { return Fields.LretPtaxAmt[this]; }
            set { Fields.LretPtaxAmt[this] = value; }
        }

        [DisplayName("Lret Ext Price"), Column("LRET_EXT_PRICE"), Size(16), Scale(2)]
        public Decimal? LretExtPrice
        {
            get { return Fields.LretExtPrice[this]; }
            set { Fields.LretExtPrice[this] = value; }
        }

        [DisplayName("Lret Ldisc Amt"), Column("LRET_LDISC_AMT"), Size(16), Scale(2)]
        public Decimal? LretLdiscAmt
        {
            get { return Fields.LretLdiscAmt[this]; }
            set { Fields.LretLdiscAmt[this] = value; }
        }

        [DisplayName("Lret Atax Amt"), Column("LRET_ATAX_AMT"), Size(16), Scale(2)]
        public Decimal? LretAtaxAmt
        {
            get { return Fields.LretAtaxAmt[this]; }
            set { Fields.LretAtaxAmt[this] = value; }
        }

        [DisplayName("Lret Item Amt"), Column("LRET_ITEM_AMT"), Size(16), Scale(2)]
        public Decimal? LretItemAmt
        {
            get { return Fields.LretItemAmt[this]; }
            set { Fields.LretItemAmt[this] = value; }
        }

        [DisplayName("Lret Tdisc Amt"), Column("LRET_TDISC_AMT"), Size(16), Scale(2)]
        public Decimal? LretTdiscAmt
        {
            get { return Fields.LretTdiscAmt[this]; }
            set { Fields.LretTdiscAmt[this] = value; }
        }

        [DisplayName("Lret Gtax Amt"), Column("LRET_GTAX_AMT"), Size(16), Scale(2)]
        public Decimal? LretGtaxAmt
        {
            get { return Fields.LretGtaxAmt[this]; }
            set { Fields.LretGtaxAmt[this] = value; }
        }

        [DisplayName("Lret Chgs Amt"), Column("LRET_CHGS_AMT"), Size(16), Scale(2)]
        public Decimal? LretChgsAmt
        {
            get { return Fields.LretChgsAmt[this]; }
            set { Fields.LretChgsAmt[this] = value; }
        }

        [DisplayName("Lret Pay Amt"), Column("LRET_PAY_AMT"), Size(16), Scale(2)]
        public Decimal? LretPayAmt
        {
            get { return Fields.LretPayAmt[this]; }
            set { Fields.LretPayAmt[this] = value; }
        }

        [DisplayName("Settle At"), Column("SETTLE_AT"), Size(4)]
        public String SettleAt
        {
            get { return Fields.SettleAt[this]; }
            set { Fields.SettleAt[this] = value; }
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

        [DisplayName("Manual"), Column("MANUAL"), Size(1)]
        public String Manual
        {
            get { return Fields.Manual[this]; }
            set { Fields.Manual[this] = value; }
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

        [DisplayName("Po Putax Type"), Column("PO_PUTAX_TYPE"), Size(1)]
        public String PoPutaxType
        {
            get { return Fields.PoPutaxType[this]; }
            set { Fields.PoPutaxType[this] = value; }
        }

        [DisplayName("Po Gputax Pcent"), Column("PO_GPUTAX_PCENT"), Size(6), Scale(2)]
        public Decimal? PoGputaxPcent
        {
            get { return Fields.PoGputaxPcent[this]; }
            set { Fields.PoGputaxPcent[this] = value; }
        }

        [DisplayName("Loc Gputax Amt"), Column("LOC_GPUTAX_AMT"), Size(16), Scale(2)]
        public Decimal? LocGputaxAmt
        {
            get { return Fields.LocGputaxAmt[this]; }
            set { Fields.LocGputaxAmt[this] = value; }
        }

        [DisplayName("Order Count"), Column("ORDER_COUNT"), Size(4)]
        public Decimal? OrderCount
        {
            get { return Fields.OrderCount[this]; }
            set { Fields.OrderCount[this] = value; }
        }

        [DisplayName("Tot Lputax Amt"), Column("TOT_LPUTAX_AMT"), Size(16), Scale(2)]
        public Decimal? TotLputaxAmt
        {
            get { return Fields.TotLputaxAmt[this]; }
            set { Fields.TotLputaxAmt[this] = value; }
        }

        [DisplayName("Loc Lputax Amt"), Column("LOC_LPUTAX_AMT"), Size(16), Scale(2)]
        public Decimal? LocLputaxAmt
        {
            get { return Fields.LocLputaxAmt[this]; }
            set { Fields.LocLputaxAmt[this] = value; }
        }

        [DisplayName("Cutoff Date"), Column("CUTOFF_DATE")]
        public DateTime? CutoffDate
        {
            get { return Fields.CutoffDate[this]; }
            set { Fields.CutoffDate[this] = value; }
        }

        [DisplayName("Inspect Priority"), Column("INSPECT_PRIORITY"), Size(4), NotNull]
        public Decimal? InspectPriority
        {
            get { return Fields.InspectPriority[this]; }
            set { Fields.InspectPriority[this] = value; }
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

        [DisplayName("Flag"), Column("FLAG"), Size(1)]
        public String Flag
        {
            get { return Fields.Flag[this]; }
            set { Fields.Flag[this] = value; }
        }

        [DisplayName("Hold By"), Column("HOLD_BY"), Size(15)]
        public String HoldBy
        {
            get { return Fields.HoldBy[this]; }
            set { Fields.HoldBy[this] = value; }
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

        [DisplayName("Last Text No"), Column("LAST_TEXT_NO"), Size(6)]
        public Decimal? LastTextNo
        {
            get { return Fields.LastTextNo[this]; }
            set { Fields.LastTextNo[this] = value; }
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

        [DisplayName("Ref Company Code"), Column("REF_COMPANY_CODE"), Size(20)]
        public String RefCompanyCode
        {
            get { return Fields.RefCompanyCode[this]; }
            set { Fields.RefCompanyCode[this] = value; }
        }

        [DisplayName("Ref Shipment Ref No"), Column("REF_SHIPMENT_REF_NO"), Size(32)]
        public String RefShipmentRefNo
        {
            get { return Fields.RefShipmentRefNo[this]; }
            set { Fields.RefShipmentRefNo[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.GrnNo; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.GrnNo; }
        }

        [MasterDetailRelation(foreignKey: "GrnNo")]
        [DisplayName("Item Detail List"), NotMapped]
        public List<GrnOrderDetailRow> ItemDetailList
        {
            get { return Fields.ItemDetailList[this]; }
            set { Fields.ItemDetailList[this] = value; }
        }

        [MasterDetailRelation(foreignKey: "GrnNo")]
        [DisplayName("Order Detail List"), NotMapped]
        public List<GrnOrderRow> OrderDetailList
        {
            get { return Fields.OrderDetailList[this]; }
            set { Fields.OrderDetailList[this] = value; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public GrnRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField GrnNo;
            public StringField EntryMethod;
            public StringField WithInvoice;
            public DateTimeField ReceivedDate;
            public StringField Posted;
            public StringField Inspected;
            public StringField Returned;
            public StringField ShipTo;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField VendorNo;
            public StringField VendorName;
            public StringField DoNo;
            public StringField InvoiceNo;
            public StringField PayTerms;
            public DecimalField DiscDays;
            public DecimalField DiscPcent;
            public DecimalField DueDays;
            public DateTimeField DiscountDate;
            public DateTimeField DueDate;
            public StringField Ccy;
            public DecimalField ExchRate;
            public StringField ComputeTax;
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
            public DecimalField NetPayAmt;
            public DecimalField DpsCover;
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
            public DecimalField LocPayAmt;
            public DecimalField LocDpsApplied;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DateTimeField PostedDate;
            public StringField PostedBy;
            public DecimalField LastOrderNo;
            public DecimalField LastEntryNo;
            public DecimalField LastChgsNo;
            public StringField LockType;
            public StringField LockRefNo;
            public DecimalField LastLogNo;
            public StringField AcctVendor;
            public StringField AcctTdisc;
            public StringField AcctGtax;
            public StringField VendTaxCode;
            public StringField CustTaxCode;
            public DecimalField RetPriceAmt;
            public DecimalField RetPtaxAmt;
            public DecimalField RetExtPrice;
            public DecimalField RetLdiscAmt;
            public DecimalField RetAtaxAmt;
            public DecimalField RetItemAmt;
            public DecimalField RetTdiscAmt;
            public DecimalField RetGtaxAmt;
            public DecimalField RetChgsAmt;
            public DecimalField RetPayAmt;
            public DecimalField LretPriceAmt;
            public DecimalField LretPtaxAmt;
            public DecimalField LretExtPrice;
            public DecimalField LretLdiscAmt;
            public DecimalField LretAtaxAmt;
            public DecimalField LretItemAmt;
            public DecimalField LretTdiscAmt;
            public DecimalField LretGtaxAmt;
            public DecimalField LretChgsAmt;
            public DecimalField LretPayAmt;
            public StringField SettleAt;
            public StringField CheckCrlimit;
            public DecimalField CheckCrbal;
            public StringField Manual;
            public StringField PutaxType;
            public DecimalField GputaxPcent;
            public DecimalField TotGputaxAmt;
            public StringField PoPutaxType;
            public DecimalField PoGputaxPcent;
            public DecimalField LocGputaxAmt;
            public DecimalField OrderCount;
            public DecimalField TotLputaxAmt;
            public DecimalField LocLputaxAmt;
            public DateTimeField CutoffDate;
            public DecimalField InspectPriority;
            public StringField Anlys9;
            public StringField Anlys10;
            public StringField Anlys11;
            public StringField Anlys12;
            public StringField Flag;
            public StringField HoldBy;
            public StringField Comments1;
            public StringField Comments2;
            public StringField Comments3;
            public StringField Comments4;
            public DecimalField LastTextNo;
            public StringField Anlys13;
            public StringField Anlys14;
            public StringField Anlys15;
            public StringField Anlys16;
            public StringField Anlys17;
            public StringField Anlys18;
            public StringField RefCompanyCode;
            public StringField RefShipmentRefNo;

            public RowListField<GrnOrderDetailRow> ItemDetailList;
            public RowListField<GrnOrderRow> OrderDetailList;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Purchasing.Grn";
            }
        }
    }
}
