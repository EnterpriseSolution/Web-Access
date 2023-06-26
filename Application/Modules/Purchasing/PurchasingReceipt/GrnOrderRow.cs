#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  GrnOrderRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Purchasing.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Purchasing"), TableName("[dbo].[PUGRNO]")]
    [DisplayName("Grn Order"), InstanceName("Grn Order"), TwoLevelCached]   
    public sealed class GrnOrderRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Grn No"), Column("GRN_NO"), Size(16), PrimaryKey, ForeignKey("[dbo].[PUGRNH]", "GRN_NO"), LeftJoin("jGrnNo"), QuickSearch, TextualField("GrnNoEntryMethod")]
        public String GrnNo
        {
            get { return Fields.GrnNo[this]; }
            set { Fields.GrnNo[this] = value; }
        }

        [DisplayName("Seq No"), Column("SEQ_NO"), Size(4), PrimaryKey]
        public Decimal? SeqNo
        {
            get { return Fields.SeqNo[this]; }
            set { Fields.SeqNo[this] = value; }
        }

        [DisplayName("Order No"), Column("ORDER_NO"), Size(16), NotNull]
        public String OrderNo
        {
            get { return Fields.OrderNo[this]; }
            set { Fields.OrderNo[this] = value; }
        }

        [DisplayName("Posted"), Column("POSTED"), Size(1)]
        public String Posted
        {
            get { return Fields.Posted[this]; }
            set { Fields.Posted[this] = value; }
        }

        [DisplayName("Order Date"), Column("ORDER_DATE")]
        public DateTime? OrderDate
        {
            get { return Fields.OrderDate[this]; }
            set { Fields.OrderDate[this] = value; }
        }

        [DisplayName("Next Due Date"), Column("NEXT_DUE_DATE")]
        public DateTime? NextDueDate
        {
            get { return Fields.NextDueDate[this]; }
            set { Fields.NextDueDate[this] = value; }
        }

        [DisplayName("Final"), Column("FINAL"), Size(1)]
        public String Final
        {
            get { return Fields.Final[this]; }
            set { Fields.Final[this] = value; }
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

        [DisplayName("Tdisc Pcent"), Column("TDISC_PCENT"), Size(6), Scale(2)]
        public Decimal? TdiscPcent
        {
            get { return Fields.TdiscPcent[this]; }
            set { Fields.TdiscPcent[this] = value; }
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

        [DisplayName("Dps Pcent"), Column("DPS_PCENT"), Size(6), Scale(2)]
        public Decimal? DpsPcent
        {
            get { return Fields.DpsPcent[this]; }
            set { Fields.DpsPcent[this] = value; }
        }

        [DisplayName("Dps Applied"), Column("DPS_APPLIED"), Size(16), Scale(2)]
        public Decimal? DpsApplied
        {
            get { return Fields.DpsApplied[this]; }
            set { Fields.DpsApplied[this] = value; }
        }

        [DisplayName("Loc Dps Applied"), Column("LOC_DPS_APPLIED"), Size(16), Scale(2)]
        public Decimal? LocDpsApplied
        {
            get { return Fields.LocDpsApplied[this]; }
            set { Fields.LocDpsApplied[this] = value; }
        }

        [DisplayName("Net Bal Amt"), Column("NET_BAL_AMT"), Size(16), Scale(2)]
        public Decimal? NetBalAmt
        {
            get { return Fields.NetBalAmt[this]; }
            set { Fields.NetBalAmt[this] = value; }
        }

        [DisplayName("Tdisc Rate"), Column("TDISC_RATE"), Size(10), Scale(4)]
        public Decimal? TdiscRate
        {
            get { return Fields.TdiscRate[this]; }
            set { Fields.TdiscRate[this] = value; }
        }

        [DisplayName("Gtax Rate"), Column("GTAX_RATE"), Size(10), Scale(4)]
        public Decimal? GtaxRate
        {
            get { return Fields.GtaxRate[this]; }
            set { Fields.GtaxRate[this] = value; }
        }

        [DisplayName("Dps Rate"), Column("DPS_RATE"), Size(10), Scale(4)]
        public Decimal? DpsRate
        {
            get { return Fields.DpsRate[this]; }
            set { Fields.DpsRate[this] = value; }
        }

        [DisplayName("Tot Tdisc Cpd"), Column("TOT_TDISC_CPD"), Size(16), Scale(2)]
        public Decimal? TotTdiscCpd
        {
            get { return Fields.TotTdiscCpd[this]; }
            set { Fields.TotTdiscCpd[this] = value; }
        }

        [DisplayName("Tot Gtax Cpd"), Column("TOT_GTAX_CPD"), Size(16), Scale(2)]
        public Decimal? TotGtaxCpd
        {
            get { return Fields.TotGtaxCpd[this]; }
            set { Fields.TotGtaxCpd[this] = value; }
        }

        [DisplayName("Dps Applied Cpd"), Column("DPS_APPLIED_CPD"), Size(16), Scale(2)]
        public Decimal? DpsAppliedCpd
        {
            get { return Fields.DpsAppliedCpd[this]; }
            set { Fields.DpsAppliedCpd[this] = value; }
        }

        [DisplayName("Last Line No"), Column("LAST_LINE_NO"), Size(8)]
        public Decimal? LastLineNo
        {
            get { return Fields.LastLineNo[this]; }
            set { Fields.LastLineNo[this] = value; }
        }

        [DisplayName("Last Chgs No"), Column("LAST_CHGS_NO"), Size(6)]
        public Decimal? LastChgsNo
        {
            get { return Fields.LastChgsNo[this]; }
            set { Fields.LastChgsNo[this] = value; }
        }

        [DisplayName("Log No"), Column("LOG_NO"), Size(8), NotNull]
        public Decimal? LogNo
        {
            get { return Fields.LogNo[this]; }
            set { Fields.LogNo[this] = value; }
        }

        [DisplayName("Last Log No"), Column("LAST_LOG_NO"), Size(8)]
        public Decimal? LastLogNo
        {
            get { return Fields.LastLogNo[this]; }
            set { Fields.LastLogNo[this] = value; }
        }

        [DisplayName("Buyer"), Column("BUYER"), Size(6), NotNull]
        public String Buyer
        {
            get { return Fields.Buyer[this]; }
            set { Fields.Buyer[this] = value; }
        }

        [DisplayName("Received Date"), Column("RECEIVED_DATE"), NotNull]
        public DateTime? ReceivedDate
        {
            get { return Fields.ReceivedDate[this]; }
            set { Fields.ReceivedDate[this] = value; }
        }

        [DisplayName("Detail Count"), Column("DETAIL_COUNT"), Size(6)]
        public Decimal? DetailCount
        {
            get { return Fields.DetailCount[this]; }
            set { Fields.DetailCount[this] = value; }
        }

        [DisplayName("Charges Count"), Column("CHARGES_COUNT"), Size(6)]
        public Decimal? ChargesCount
        {
            get { return Fields.ChargesCount[this]; }
            set { Fields.ChargesCount[this] = value; }
        }

        [DisplayName("Dps Entry No"), Column("DPS_ENTRY_NO"), Size(8)]
        public Decimal? DpsEntryNo
        {
            get { return Fields.DpsEntryNo[this]; }
            set { Fields.DpsEntryNo[this] = value; }
        }

        [DisplayName("Check Crbal"), Column("CHECK_CRBAL"), Size(16), Scale(2)]
        public Decimal? CheckCrbal
        {
            get { return Fields.CheckCrbal[this]; }
            set { Fields.CheckCrbal[this] = value; }
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

        [DisplayName("Receive All"), Column("RECEIVE_ALL"), Size(1)]
        public String ReceiveAll
        {
            get { return Fields.ReceiveAll[this]; }
            set { Fields.ReceiveAll[this] = value; }
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

        [DisplayName("Grn No Recnum"), Expression("jGrnNo.[RECNUM]")]
        public Decimal? GrnNoRecnum
        {
            get { return Fields.GrnNoRecnum[this]; }
            set { Fields.GrnNoRecnum[this] = value; }
        }

        [DisplayName("Grn No Entry Method"), Expression("jGrnNo.[ENTRY_METHOD]")]
        public String GrnNoEntryMethod
        {
            get { return Fields.GrnNoEntryMethod[this]; }
            set { Fields.GrnNoEntryMethod[this] = value; }
        }

        [DisplayName("Grn No With Invoice"), Expression("jGrnNo.[WITH_INVOICE]")]
        public String GrnNoWithInvoice
        {
            get { return Fields.GrnNoWithInvoice[this]; }
            set { Fields.GrnNoWithInvoice[this] = value; }
        }

        [DisplayName("Grn No Received Date"), Expression("jGrnNo.[RECEIVED_DATE]")]
        public DateTime? GrnNoReceivedDate
        {
            get { return Fields.GrnNoReceivedDate[this]; }
            set { Fields.GrnNoReceivedDate[this] = value; }
        }

        [DisplayName("Grn No Posted"), Expression("jGrnNo.[POSTED]")]
        public String GrnNoPosted
        {
            get { return Fields.GrnNoPosted[this]; }
            set { Fields.GrnNoPosted[this] = value; }
        }

        [DisplayName("Grn No Inspected"), Expression("jGrnNo.[INSPECTED]")]
        public String GrnNoInspected
        {
            get { return Fields.GrnNoInspected[this]; }
            set { Fields.GrnNoInspected[this] = value; }
        }

        [DisplayName("Grn No Returned"), Expression("jGrnNo.[RETURNED]")]
        public String GrnNoReturned
        {
            get { return Fields.GrnNoReturned[this]; }
            set { Fields.GrnNoReturned[this] = value; }
        }

        [DisplayName("Grn No Ship To"), Expression("jGrnNo.[SHIP_TO]")]
        public String GrnNoShipTo
        {
            get { return Fields.GrnNoShipTo[this]; }
            set { Fields.GrnNoShipTo[this] = value; }
        }

        [DisplayName("Grn No Owner Branch"), Expression("jGrnNo.[OWNER_BRANCH]")]
        public String GrnNoOwnerBranch
        {
            get { return Fields.GrnNoOwnerBranch[this]; }
            set { Fields.GrnNoOwnerBranch[this] = value; }
        }

        [DisplayName("Grn No Source Branch"), Expression("jGrnNo.[SOURCE_BRANCH]")]
        public String GrnNoSourceBranch
        {
            get { return Fields.GrnNoSourceBranch[this]; }
            set { Fields.GrnNoSourceBranch[this] = value; }
        }

        [DisplayName("Grn No Vendor No"), Expression("jGrnNo.[VENDOR_NO]")]
        public String GrnNoVendorNo
        {
            get { return Fields.GrnNoVendorNo[this]; }
            set { Fields.GrnNoVendorNo[this] = value; }
        }

        [DisplayName("Grn No Vendor Name"), Expression("jGrnNo.[VENDOR_NAME]")]
        public String GrnNoVendorName
        {
            get { return Fields.GrnNoVendorName[this]; }
            set { Fields.GrnNoVendorName[this] = value; }
        }

        [DisplayName("Grn No Do No"), Expression("jGrnNo.[DO_NO]")]
        public String GrnNoDoNo
        {
            get { return Fields.GrnNoDoNo[this]; }
            set { Fields.GrnNoDoNo[this] = value; }
        }

        [DisplayName("Grn No Invoice No"), Expression("jGrnNo.[INVOICE_NO]")]
        public String GrnNoInvoiceNo
        {
            get { return Fields.GrnNoInvoiceNo[this]; }
            set { Fields.GrnNoInvoiceNo[this] = value; }
        }

        [DisplayName("Grn No Pay Terms"), Expression("jGrnNo.[PAY_TERMS]")]
        public String GrnNoPayTerms
        {
            get { return Fields.GrnNoPayTerms[this]; }
            set { Fields.GrnNoPayTerms[this] = value; }
        }

        [DisplayName("Grn No Disc Days"), Expression("jGrnNo.[DISC_DAYS]")]
        public Decimal? GrnNoDiscDays
        {
            get { return Fields.GrnNoDiscDays[this]; }
            set { Fields.GrnNoDiscDays[this] = value; }
        }

        [DisplayName("Grn No Disc Pcent"), Expression("jGrnNo.[DISC_PCENT]")]
        public Decimal? GrnNoDiscPcent
        {
            get { return Fields.GrnNoDiscPcent[this]; }
            set { Fields.GrnNoDiscPcent[this] = value; }
        }

        [DisplayName("Grn No Due Days"), Expression("jGrnNo.[DUE_DAYS]")]
        public Decimal? GrnNoDueDays
        {
            get { return Fields.GrnNoDueDays[this]; }
            set { Fields.GrnNoDueDays[this] = value; }
        }

        [DisplayName("Grn No Discount Date"), Expression("jGrnNo.[DISCOUNT_DATE]")]
        public DateTime? GrnNoDiscountDate
        {
            get { return Fields.GrnNoDiscountDate[this]; }
            set { Fields.GrnNoDiscountDate[this] = value; }
        }

        [DisplayName("Grn No Due Date"), Expression("jGrnNo.[DUE_DATE]")]
        public DateTime? GrnNoDueDate
        {
            get { return Fields.GrnNoDueDate[this]; }
            set { Fields.GrnNoDueDate[this] = value; }
        }

        [DisplayName("Grn No Ccy"), Expression("jGrnNo.[CCY]")]
        public String GrnNoCcy
        {
            get { return Fields.GrnNoCcy[this]; }
            set { Fields.GrnNoCcy[this] = value; }
        }

        [DisplayName("Grn No Exch Rate"), Expression("jGrnNo.[EXCH_RATE]")]
        public Decimal? GrnNoExchRate
        {
            get { return Fields.GrnNoExchRate[this]; }
            set { Fields.GrnNoExchRate[this] = value; }
        }

        [DisplayName("Grn No Compute Tax"), Expression("jGrnNo.[COMPUTE_TAX]")]
        public String GrnNoComputeTax
        {
            get { return Fields.GrnNoComputeTax[this]; }
            set { Fields.GrnNoComputeTax[this] = value; }
        }

        [DisplayName("Grn No Tot Price Amt"), Expression("jGrnNo.[TOT_PRICE_AMT]")]
        public Decimal? GrnNoTotPriceAmt
        {
            get { return Fields.GrnNoTotPriceAmt[this]; }
            set { Fields.GrnNoTotPriceAmt[this] = value; }
        }

        [DisplayName("Grn No Tot Ptax Amt"), Expression("jGrnNo.[TOT_PTAX_AMT]")]
        public Decimal? GrnNoTotPtaxAmt
        {
            get { return Fields.GrnNoTotPtaxAmt[this]; }
            set { Fields.GrnNoTotPtaxAmt[this] = value; }
        }

        [DisplayName("Grn No Tot Ext Price"), Expression("jGrnNo.[TOT_EXT_PRICE]")]
        public Decimal? GrnNoTotExtPrice
        {
            get { return Fields.GrnNoTotExtPrice[this]; }
            set { Fields.GrnNoTotExtPrice[this] = value; }
        }

        [DisplayName("Grn No Tot Ldisc Amt"), Expression("jGrnNo.[TOT_LDISC_AMT]")]
        public Decimal? GrnNoTotLdiscAmt
        {
            get { return Fields.GrnNoTotLdiscAmt[this]; }
            set { Fields.GrnNoTotLdiscAmt[this] = value; }
        }

        [DisplayName("Grn No Tot Atax Amt"), Expression("jGrnNo.[TOT_ATAX_AMT]")]
        public Decimal? GrnNoTotAtaxAmt
        {
            get { return Fields.GrnNoTotAtaxAmt[this]; }
            set { Fields.GrnNoTotAtaxAmt[this] = value; }
        }

        [DisplayName("Grn No Tot Item Amt"), Expression("jGrnNo.[TOT_ITEM_AMT]")]
        public Decimal? GrnNoTotItemAmt
        {
            get { return Fields.GrnNoTotItemAmt[this]; }
            set { Fields.GrnNoTotItemAmt[this] = value; }
        }

        [DisplayName("Grn No Tot Tdisc Amt"), Expression("jGrnNo.[TOT_TDISC_AMT]")]
        public Decimal? GrnNoTotTdiscAmt
        {
            get { return Fields.GrnNoTotTdiscAmt[this]; }
            set { Fields.GrnNoTotTdiscAmt[this] = value; }
        }

        [DisplayName("Grn No Net Trade Amt"), Expression("jGrnNo.[NET_TRADE_AMT]")]
        public Decimal? GrnNoNetTradeAmt
        {
            get { return Fields.GrnNoNetTradeAmt[this]; }
            set { Fields.GrnNoNetTradeAmt[this] = value; }
        }

        [DisplayName("Grn No Tot Chgs Amt"), Expression("jGrnNo.[TOT_CHGS_AMT]")]
        public Decimal? GrnNoTotChgsAmt
        {
            get { return Fields.GrnNoTotChgsAmt[this]; }
            set { Fields.GrnNoTotChgsAmt[this] = value; }
        }

        [DisplayName("Grn No Net Ordr Amt"), Expression("jGrnNo.[NET_ORDR_AMT]")]
        public Decimal? GrnNoNetOrdrAmt
        {
            get { return Fields.GrnNoNetOrdrAmt[this]; }
            set { Fields.GrnNoNetOrdrAmt[this] = value; }
        }

        [DisplayName("Grn No Tot Gtax Amt"), Expression("jGrnNo.[TOT_GTAX_AMT]")]
        public Decimal? GrnNoTotGtaxAmt
        {
            get { return Fields.GrnNoTotGtaxAmt[this]; }
            set { Fields.GrnNoTotGtaxAmt[this] = value; }
        }

        [DisplayName("Grn No Net Pay Amt"), Expression("jGrnNo.[NET_PAY_AMT]")]
        public Decimal? GrnNoNetPayAmt
        {
            get { return Fields.GrnNoNetPayAmt[this]; }
            set { Fields.GrnNoNetPayAmt[this] = value; }
        }

        [DisplayName("Grn No Dps Cover"), Expression("jGrnNo.[DPS_COVER]")]
        public Decimal? GrnNoDpsCover
        {
            get { return Fields.GrnNoDpsCover[this]; }
            set { Fields.GrnNoDpsCover[this] = value; }
        }

        [DisplayName("Grn No Dps Applied"), Expression("jGrnNo.[DPS_APPLIED]")]
        public Decimal? GrnNoDpsApplied
        {
            get { return Fields.GrnNoDpsApplied[this]; }
            set { Fields.GrnNoDpsApplied[this] = value; }
        }

        [DisplayName("Grn No Net Bal Amt"), Expression("jGrnNo.[NET_BAL_AMT]")]
        public Decimal? GrnNoNetBalAmt
        {
            get { return Fields.GrnNoNetBalAmt[this]; }
            set { Fields.GrnNoNetBalAmt[this] = value; }
        }

        [DisplayName("Grn No Loc Price Amt"), Expression("jGrnNo.[LOC_PRICE_AMT]")]
        public Decimal? GrnNoLocPriceAmt
        {
            get { return Fields.GrnNoLocPriceAmt[this]; }
            set { Fields.GrnNoLocPriceAmt[this] = value; }
        }

        [DisplayName("Grn No Loc Ptax Amt"), Expression("jGrnNo.[LOC_PTAX_AMT]")]
        public Decimal? GrnNoLocPtaxAmt
        {
            get { return Fields.GrnNoLocPtaxAmt[this]; }
            set { Fields.GrnNoLocPtaxAmt[this] = value; }
        }

        [DisplayName("Grn No Loc Ext Price"), Expression("jGrnNo.[LOC_EXT_PRICE]")]
        public Decimal? GrnNoLocExtPrice
        {
            get { return Fields.GrnNoLocExtPrice[this]; }
            set { Fields.GrnNoLocExtPrice[this] = value; }
        }

        [DisplayName("Grn No Loc Ldisc Amt"), Expression("jGrnNo.[LOC_LDISC_AMT]")]
        public Decimal? GrnNoLocLdiscAmt
        {
            get { return Fields.GrnNoLocLdiscAmt[this]; }
            set { Fields.GrnNoLocLdiscAmt[this] = value; }
        }

        [DisplayName("Grn No Loc Atax Amt"), Expression("jGrnNo.[LOC_ATAX_AMT]")]
        public Decimal? GrnNoLocAtaxAmt
        {
            get { return Fields.GrnNoLocAtaxAmt[this]; }
            set { Fields.GrnNoLocAtaxAmt[this] = value; }
        }

        [DisplayName("Grn No Loc Item Amt"), Expression("jGrnNo.[LOC_ITEM_AMT]")]
        public Decimal? GrnNoLocItemAmt
        {
            get { return Fields.GrnNoLocItemAmt[this]; }
            set { Fields.GrnNoLocItemAmt[this] = value; }
        }

        [DisplayName("Grn No Loc Tdisc Amt"), Expression("jGrnNo.[LOC_TDISC_AMT]")]
        public Decimal? GrnNoLocTdiscAmt
        {
            get { return Fields.GrnNoLocTdiscAmt[this]; }
            set { Fields.GrnNoLocTdiscAmt[this] = value; }
        }

        [DisplayName("Grn No Loc Chgs Amt"), Expression("jGrnNo.[LOC_CHGS_AMT]")]
        public Decimal? GrnNoLocChgsAmt
        {
            get { return Fields.GrnNoLocChgsAmt[this]; }
            set { Fields.GrnNoLocChgsAmt[this] = value; }
        }

        [DisplayName("Grn No Loc Gtax Amt"), Expression("jGrnNo.[LOC_GTAX_AMT]")]
        public Decimal? GrnNoLocGtaxAmt
        {
            get { return Fields.GrnNoLocGtaxAmt[this]; }
            set { Fields.GrnNoLocGtaxAmt[this] = value; }
        }

        [DisplayName("Grn No Loc Pay Amt"), Expression("jGrnNo.[LOC_PAY_AMT]")]
        public Decimal? GrnNoLocPayAmt
        {
            get { return Fields.GrnNoLocPayAmt[this]; }
            set { Fields.GrnNoLocPayAmt[this] = value; }
        }

        [DisplayName("Grn No Loc Dps Applied"), Expression("jGrnNo.[LOC_DPS_APPLIED]")]
        public Decimal? GrnNoLocDpsApplied
        {
            get { return Fields.GrnNoLocDpsApplied[this]; }
            set { Fields.GrnNoLocDpsApplied[this] = value; }
        }

        [DisplayName("Grn No Created Date"), Expression("jGrnNo.[CREATED_DATE]")]
        public DateTime? GrnNoCreatedDate
        {
            get { return Fields.GrnNoCreatedDate[this]; }
            set { Fields.GrnNoCreatedDate[this] = value; }
        }

        [DisplayName("Grn No Created By"), Expression("jGrnNo.[CREATED_BY]")]
        public String GrnNoCreatedBy
        {
            get { return Fields.GrnNoCreatedBy[this]; }
            set { Fields.GrnNoCreatedBy[this] = value; }
        }

        [DisplayName("Grn No Revised Date"), Expression("jGrnNo.[REVISED_DATE]")]
        public DateTime? GrnNoRevisedDate
        {
            get { return Fields.GrnNoRevisedDate[this]; }
            set { Fields.GrnNoRevisedDate[this] = value; }
        }

        [DisplayName("Grn No Revised By"), Expression("jGrnNo.[REVISED_BY]")]
        public String GrnNoRevisedBy
        {
            get { return Fields.GrnNoRevisedBy[this]; }
            set { Fields.GrnNoRevisedBy[this] = value; }
        }

        [DisplayName("Grn No Posted Date"), Expression("jGrnNo.[POSTED_DATE]")]
        public DateTime? GrnNoPostedDate
        {
            get { return Fields.GrnNoPostedDate[this]; }
            set { Fields.GrnNoPostedDate[this] = value; }
        }

        [DisplayName("Grn No Posted By"), Expression("jGrnNo.[POSTED_BY]")]
        public String GrnNoPostedBy
        {
            get { return Fields.GrnNoPostedBy[this]; }
            set { Fields.GrnNoPostedBy[this] = value; }
        }

        [DisplayName("Grn No Last Order No"), Expression("jGrnNo.[LAST_ORDER_NO]")]
        public Decimal? GrnNoLastOrderNo
        {
            get { return Fields.GrnNoLastOrderNo[this]; }
            set { Fields.GrnNoLastOrderNo[this] = value; }
        }

        [DisplayName("Grn No Last Entry No"), Expression("jGrnNo.[LAST_ENTRY_NO]")]
        public Decimal? GrnNoLastEntryNo
        {
            get { return Fields.GrnNoLastEntryNo[this]; }
            set { Fields.GrnNoLastEntryNo[this] = value; }
        }

        [DisplayName("Grn No Last Chgs No"), Expression("jGrnNo.[LAST_CHGS_NO]")]
        public Decimal? GrnNoLastChgsNo
        {
            get { return Fields.GrnNoLastChgsNo[this]; }
            set { Fields.GrnNoLastChgsNo[this] = value; }
        }

        [DisplayName("Grn No Lock Type"), Expression("jGrnNo.[LOCK_TYPE]")]
        public String GrnNoLockType
        {
            get { return Fields.GrnNoLockType[this]; }
            set { Fields.GrnNoLockType[this] = value; }
        }

        [DisplayName("Grn No Lock Ref No"), Expression("jGrnNo.[LOCK_REF_NO]")]
        public String GrnNoLockRefNo
        {
            get { return Fields.GrnNoLockRefNo[this]; }
            set { Fields.GrnNoLockRefNo[this] = value; }
        }

        [DisplayName("Grn No Last Log No"), Expression("jGrnNo.[LAST_LOG_NO]")]
        public Decimal? GrnNoLastLogNo
        {
            get { return Fields.GrnNoLastLogNo[this]; }
            set { Fields.GrnNoLastLogNo[this] = value; }
        }

        [DisplayName("Grn No Acct Vendor"), Expression("jGrnNo.[ACCT_VENDOR]")]
        public String GrnNoAcctVendor
        {
            get { return Fields.GrnNoAcctVendor[this]; }
            set { Fields.GrnNoAcctVendor[this] = value; }
        }

        [DisplayName("Grn No Acct Tdisc"), Expression("jGrnNo.[ACCT_TDISC]")]
        public String GrnNoAcctTdisc
        {
            get { return Fields.GrnNoAcctTdisc[this]; }
            set { Fields.GrnNoAcctTdisc[this] = value; }
        }

        [DisplayName("Grn No Acct Gtax"), Expression("jGrnNo.[ACCT_GTAX]")]
        public String GrnNoAcctGtax
        {
            get { return Fields.GrnNoAcctGtax[this]; }
            set { Fields.GrnNoAcctGtax[this] = value; }
        }

        [DisplayName("Grn No Vend Tax Code"), Expression("jGrnNo.[VEND_TAX_CODE]")]
        public String GrnNoVendTaxCode
        {
            get { return Fields.GrnNoVendTaxCode[this]; }
            set { Fields.GrnNoVendTaxCode[this] = value; }
        }

        [DisplayName("Grn No Cust Tax Code"), Expression("jGrnNo.[CUST_TAX_CODE]")]
        public String GrnNoCustTaxCode
        {
            get { return Fields.GrnNoCustTaxCode[this]; }
            set { Fields.GrnNoCustTaxCode[this] = value; }
        }

        [DisplayName("Grn No Ret Price Amt"), Expression("jGrnNo.[RET_PRICE_AMT]")]
        public Decimal? GrnNoRetPriceAmt
        {
            get { return Fields.GrnNoRetPriceAmt[this]; }
            set { Fields.GrnNoRetPriceAmt[this] = value; }
        }

        [DisplayName("Grn No Ret Ptax Amt"), Expression("jGrnNo.[RET_PTAX_AMT]")]
        public Decimal? GrnNoRetPtaxAmt
        {
            get { return Fields.GrnNoRetPtaxAmt[this]; }
            set { Fields.GrnNoRetPtaxAmt[this] = value; }
        }

        [DisplayName("Grn No Ret Ext Price"), Expression("jGrnNo.[RET_EXT_PRICE]")]
        public Decimal? GrnNoRetExtPrice
        {
            get { return Fields.GrnNoRetExtPrice[this]; }
            set { Fields.GrnNoRetExtPrice[this] = value; }
        }

        [DisplayName("Grn No Ret Ldisc Amt"), Expression("jGrnNo.[RET_LDISC_AMT]")]
        public Decimal? GrnNoRetLdiscAmt
        {
            get { return Fields.GrnNoRetLdiscAmt[this]; }
            set { Fields.GrnNoRetLdiscAmt[this] = value; }
        }

        [DisplayName("Grn No Ret Atax Amt"), Expression("jGrnNo.[RET_ATAX_AMT]")]
        public Decimal? GrnNoRetAtaxAmt
        {
            get { return Fields.GrnNoRetAtaxAmt[this]; }
            set { Fields.GrnNoRetAtaxAmt[this] = value; }
        }

        [DisplayName("Grn No Ret Item Amt"), Expression("jGrnNo.[RET_ITEM_AMT]")]
        public Decimal? GrnNoRetItemAmt
        {
            get { return Fields.GrnNoRetItemAmt[this]; }
            set { Fields.GrnNoRetItemAmt[this] = value; }
        }

        [DisplayName("Grn No Ret Tdisc Amt"), Expression("jGrnNo.[RET_TDISC_AMT]")]
        public Decimal? GrnNoRetTdiscAmt
        {
            get { return Fields.GrnNoRetTdiscAmt[this]; }
            set { Fields.GrnNoRetTdiscAmt[this] = value; }
        }

        [DisplayName("Grn No Ret Gtax Amt"), Expression("jGrnNo.[RET_GTAX_AMT]")]
        public Decimal? GrnNoRetGtaxAmt
        {
            get { return Fields.GrnNoRetGtaxAmt[this]; }
            set { Fields.GrnNoRetGtaxAmt[this] = value; }
        }

        [DisplayName("Grn No Ret Chgs Amt"), Expression("jGrnNo.[RET_CHGS_AMT]")]
        public Decimal? GrnNoRetChgsAmt
        {
            get { return Fields.GrnNoRetChgsAmt[this]; }
            set { Fields.GrnNoRetChgsAmt[this] = value; }
        }

        [DisplayName("Grn No Ret Pay Amt"), Expression("jGrnNo.[RET_PAY_AMT]")]
        public Decimal? GrnNoRetPayAmt
        {
            get { return Fields.GrnNoRetPayAmt[this]; }
            set { Fields.GrnNoRetPayAmt[this] = value; }
        }

        [DisplayName("Grn No Lret Price Amt"), Expression("jGrnNo.[LRET_PRICE_AMT]")]
        public Decimal? GrnNoLretPriceAmt
        {
            get { return Fields.GrnNoLretPriceAmt[this]; }
            set { Fields.GrnNoLretPriceAmt[this] = value; }
        }

        [DisplayName("Grn No Lret Ptax Amt"), Expression("jGrnNo.[LRET_PTAX_AMT]")]
        public Decimal? GrnNoLretPtaxAmt
        {
            get { return Fields.GrnNoLretPtaxAmt[this]; }
            set { Fields.GrnNoLretPtaxAmt[this] = value; }
        }

        [DisplayName("Grn No Lret Ext Price"), Expression("jGrnNo.[LRET_EXT_PRICE]")]
        public Decimal? GrnNoLretExtPrice
        {
            get { return Fields.GrnNoLretExtPrice[this]; }
            set { Fields.GrnNoLretExtPrice[this] = value; }
        }

        [DisplayName("Grn No Lret Ldisc Amt"), Expression("jGrnNo.[LRET_LDISC_AMT]")]
        public Decimal? GrnNoLretLdiscAmt
        {
            get { return Fields.GrnNoLretLdiscAmt[this]; }
            set { Fields.GrnNoLretLdiscAmt[this] = value; }
        }

        [DisplayName("Grn No Lret Atax Amt"), Expression("jGrnNo.[LRET_ATAX_AMT]")]
        public Decimal? GrnNoLretAtaxAmt
        {
            get { return Fields.GrnNoLretAtaxAmt[this]; }
            set { Fields.GrnNoLretAtaxAmt[this] = value; }
        }

        [DisplayName("Grn No Lret Item Amt"), Expression("jGrnNo.[LRET_ITEM_AMT]")]
        public Decimal? GrnNoLretItemAmt
        {
            get { return Fields.GrnNoLretItemAmt[this]; }
            set { Fields.GrnNoLretItemAmt[this] = value; }
        }

        [DisplayName("Grn No Lret Tdisc Amt"), Expression("jGrnNo.[LRET_TDISC_AMT]")]
        public Decimal? GrnNoLretTdiscAmt
        {
            get { return Fields.GrnNoLretTdiscAmt[this]; }
            set { Fields.GrnNoLretTdiscAmt[this] = value; }
        }

        [DisplayName("Grn No Lret Gtax Amt"), Expression("jGrnNo.[LRET_GTAX_AMT]")]
        public Decimal? GrnNoLretGtaxAmt
        {
            get { return Fields.GrnNoLretGtaxAmt[this]; }
            set { Fields.GrnNoLretGtaxAmt[this] = value; }
        }

        [DisplayName("Grn No Lret Chgs Amt"), Expression("jGrnNo.[LRET_CHGS_AMT]")]
        public Decimal? GrnNoLretChgsAmt
        {
            get { return Fields.GrnNoLretChgsAmt[this]; }
            set { Fields.GrnNoLretChgsAmt[this] = value; }
        }

        [DisplayName("Grn No Lret Pay Amt"), Expression("jGrnNo.[LRET_PAY_AMT]")]
        public Decimal? GrnNoLretPayAmt
        {
            get { return Fields.GrnNoLretPayAmt[this]; }
            set { Fields.GrnNoLretPayAmt[this] = value; }
        }

        [DisplayName("Grn No Settle At"), Expression("jGrnNo.[SETTLE_AT]")]
        public String GrnNoSettleAt
        {
            get { return Fields.GrnNoSettleAt[this]; }
            set { Fields.GrnNoSettleAt[this] = value; }
        }

        [DisplayName("Grn No Check Crlimit"), Expression("jGrnNo.[CHECK_CRLIMIT]")]
        public String GrnNoCheckCrlimit
        {
            get { return Fields.GrnNoCheckCrlimit[this]; }
            set { Fields.GrnNoCheckCrlimit[this] = value; }
        }

        [DisplayName("Grn No Check Crbal"), Expression("jGrnNo.[CHECK_CRBAL]")]
        public Decimal? GrnNoCheckCrbal
        {
            get { return Fields.GrnNoCheckCrbal[this]; }
            set { Fields.GrnNoCheckCrbal[this] = value; }
        }

        [DisplayName("Grn No Manual"), Expression("jGrnNo.[MANUAL]")]
        public String GrnNoManual
        {
            get { return Fields.GrnNoManual[this]; }
            set { Fields.GrnNoManual[this] = value; }
        }

        [DisplayName("Grn No Putax Type"), Expression("jGrnNo.[PUTAX_TYPE]")]
        public String GrnNoPutaxType
        {
            get { return Fields.GrnNoPutaxType[this]; }
            set { Fields.GrnNoPutaxType[this] = value; }
        }

        [DisplayName("Grn No Gputax Pcent"), Expression("jGrnNo.[GPUTAX_PCENT]")]
        public Decimal? GrnNoGputaxPcent
        {
            get { return Fields.GrnNoGputaxPcent[this]; }
            set { Fields.GrnNoGputaxPcent[this] = value; }
        }

        [DisplayName("Grn No Tot Gputax Amt"), Expression("jGrnNo.[TOT_GPUTAX_AMT]")]
        public Decimal? GrnNoTotGputaxAmt
        {
            get { return Fields.GrnNoTotGputaxAmt[this]; }
            set { Fields.GrnNoTotGputaxAmt[this] = value; }
        }

        [DisplayName("Grn No Po Putax Type"), Expression("jGrnNo.[PO_PUTAX_TYPE]")]
        public String GrnNoPoPutaxType
        {
            get { return Fields.GrnNoPoPutaxType[this]; }
            set { Fields.GrnNoPoPutaxType[this] = value; }
        }

        [DisplayName("Grn No Po Gputax Pcent"), Expression("jGrnNo.[PO_GPUTAX_PCENT]")]
        public Decimal? GrnNoPoGputaxPcent
        {
            get { return Fields.GrnNoPoGputaxPcent[this]; }
            set { Fields.GrnNoPoGputaxPcent[this] = value; }
        }

        [DisplayName("Grn No Loc Gputax Amt"), Expression("jGrnNo.[LOC_GPUTAX_AMT]")]
        public Decimal? GrnNoLocGputaxAmt
        {
            get { return Fields.GrnNoLocGputaxAmt[this]; }
            set { Fields.GrnNoLocGputaxAmt[this] = value; }
        }

        [DisplayName("Grn No Order Count"), Expression("jGrnNo.[ORDER_COUNT]")]
        public Decimal? GrnNoOrderCount
        {
            get { return Fields.GrnNoOrderCount[this]; }
            set { Fields.GrnNoOrderCount[this] = value; }
        }

        [DisplayName("Grn No Tot Lputax Amt"), Expression("jGrnNo.[TOT_LPUTAX_AMT]")]
        public Decimal? GrnNoTotLputaxAmt
        {
            get { return Fields.GrnNoTotLputaxAmt[this]; }
            set { Fields.GrnNoTotLputaxAmt[this] = value; }
        }

        [DisplayName("Grn No Loc Lputax Amt"), Expression("jGrnNo.[LOC_LPUTAX_AMT]")]
        public Decimal? GrnNoLocLputaxAmt
        {
            get { return Fields.GrnNoLocLputaxAmt[this]; }
            set { Fields.GrnNoLocLputaxAmt[this] = value; }
        }

        [DisplayName("Grn No Cutoff Date"), Expression("jGrnNo.[CUTOFF_DATE]")]
        public DateTime? GrnNoCutoffDate
        {
            get { return Fields.GrnNoCutoffDate[this]; }
            set { Fields.GrnNoCutoffDate[this] = value; }
        }

        [DisplayName("Grn No Inspect Priority"), Expression("jGrnNo.[INSPECT_PRIORITY]")]
        public Decimal? GrnNoInspectPriority
        {
            get { return Fields.GrnNoInspectPriority[this]; }
            set { Fields.GrnNoInspectPriority[this] = value; }
        }

        [DisplayName("Grn No Anlys9"), Expression("jGrnNo.[ANLYS9]")]
        public String GrnNoAnlys9
        {
            get { return Fields.GrnNoAnlys9[this]; }
            set { Fields.GrnNoAnlys9[this] = value; }
        }

        [DisplayName("Grn No Anlys10"), Expression("jGrnNo.[ANLYS10]")]
        public String GrnNoAnlys10
        {
            get { return Fields.GrnNoAnlys10[this]; }
            set { Fields.GrnNoAnlys10[this] = value; }
        }

        [DisplayName("Grn No Anlys11"), Expression("jGrnNo.[ANLYS11]")]
        public String GrnNoAnlys11
        {
            get { return Fields.GrnNoAnlys11[this]; }
            set { Fields.GrnNoAnlys11[this] = value; }
        }

        [DisplayName("Grn No Anlys12"), Expression("jGrnNo.[ANLYS12]")]
        public String GrnNoAnlys12
        {
            get { return Fields.GrnNoAnlys12[this]; }
            set { Fields.GrnNoAnlys12[this] = value; }
        }

        [DisplayName("Grn No Flag"), Expression("jGrnNo.[FLAG]")]
        public String GrnNoFlag
        {
            get { return Fields.GrnNoFlag[this]; }
            set { Fields.GrnNoFlag[this] = value; }
        }

        [DisplayName("Grn No Hold By"), Expression("jGrnNo.[HOLD_BY]")]
        public String GrnNoHoldBy
        {
            get { return Fields.GrnNoHoldBy[this]; }
            set { Fields.GrnNoHoldBy[this] = value; }
        }

        [DisplayName("Grn No Comments1"), Expression("jGrnNo.[COMMENTS1]")]
        public String GrnNoComments1
        {
            get { return Fields.GrnNoComments1[this]; }
            set { Fields.GrnNoComments1[this] = value; }
        }

        [DisplayName("Grn No Comments2"), Expression("jGrnNo.[COMMENTS2]")]
        public String GrnNoComments2
        {
            get { return Fields.GrnNoComments2[this]; }
            set { Fields.GrnNoComments2[this] = value; }
        }

        [DisplayName("Grn No Comments3"), Expression("jGrnNo.[COMMENTS3]")]
        public String GrnNoComments3
        {
            get { return Fields.GrnNoComments3[this]; }
            set { Fields.GrnNoComments3[this] = value; }
        }

        [DisplayName("Grn No Comments4"), Expression("jGrnNo.[COMMENTS4]")]
        public String GrnNoComments4
        {
            get { return Fields.GrnNoComments4[this]; }
            set { Fields.GrnNoComments4[this] = value; }
        }

        [DisplayName("Grn No Last Text No"), Expression("jGrnNo.[LAST_TEXT_NO]")]
        public Decimal? GrnNoLastTextNo
        {
            get { return Fields.GrnNoLastTextNo[this]; }
            set { Fields.GrnNoLastTextNo[this] = value; }
        }

        [DisplayName("Grn No Anlys13"), Expression("jGrnNo.[ANLYS13]")]
        public String GrnNoAnlys13
        {
            get { return Fields.GrnNoAnlys13[this]; }
            set { Fields.GrnNoAnlys13[this] = value; }
        }

        [DisplayName("Grn No Anlys14"), Expression("jGrnNo.[ANLYS14]")]
        public String GrnNoAnlys14
        {
            get { return Fields.GrnNoAnlys14[this]; }
            set { Fields.GrnNoAnlys14[this] = value; }
        }

        [DisplayName("Grn No Anlys15"), Expression("jGrnNo.[ANLYS15]")]
        public String GrnNoAnlys15
        {
            get { return Fields.GrnNoAnlys15[this]; }
            set { Fields.GrnNoAnlys15[this] = value; }
        }

        [DisplayName("Grn No Anlys16"), Expression("jGrnNo.[ANLYS16]")]
        public String GrnNoAnlys16
        {
            get { return Fields.GrnNoAnlys16[this]; }
            set { Fields.GrnNoAnlys16[this] = value; }
        }

        [DisplayName("Grn No Anlys17"), Expression("jGrnNo.[ANLYS17]")]
        public String GrnNoAnlys17
        {
            get { return Fields.GrnNoAnlys17[this]; }
            set { Fields.GrnNoAnlys17[this] = value; }
        }

        [DisplayName("Grn No Anlys18"), Expression("jGrnNo.[ANLYS18]")]
        public String GrnNoAnlys18
        {
            get { return Fields.GrnNoAnlys18[this]; }
            set { Fields.GrnNoAnlys18[this] = value; }
        }

        [DisplayName("Grn No Ref Company Code"), Expression("jGrnNo.[REF_COMPANY_CODE]")]
        public String GrnNoRefCompanyCode
        {
            get { return Fields.GrnNoRefCompanyCode[this]; }
            set { Fields.GrnNoRefCompanyCode[this] = value; }
        }

        [DisplayName("Grn No Ref Shipment Ref No"), Expression("jGrnNo.[REF_SHIPMENT_REF_NO]")]
        public String GrnNoRefShipmentRefNo
        {
            get { return Fields.GrnNoRefShipmentRefNo[this]; }
            set { Fields.GrnNoRefShipmentRefNo[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.GrnNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public GrnOrderRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField GrnNo;
            public DecimalField SeqNo;
            public StringField OrderNo;
            public StringField Posted;
            public DateTimeField OrderDate;
            public DateTimeField NextDueDate;
            public StringField Final;
            public StringField Anlys1;
            public StringField Anlys2;
            public DecimalField TotPriceAmt;
            public DecimalField TotPtaxAmt;
            public DecimalField TotExtPrice;
            public DecimalField TotLdiscAmt;
            public DecimalField TotAtaxAmt;
            public DecimalField TotItemAmt;
            public DecimalField TdiscPcent;
            public DecimalField TotTdiscAmt;
            public DecimalField NetTradeAmt;
            public DecimalField TotChgsAmt;
            public DecimalField NetOrdrAmt;
            public DecimalField TotGtaxAmt;
            public DecimalField NetPayAmt;
            public DecimalField DpsCover;
            public DecimalField DpsPcent;
            public DecimalField DpsApplied;
            public DecimalField LocDpsApplied;
            public DecimalField NetBalAmt;
            public DecimalField TdiscRate;
            public DecimalField GtaxRate;
            public DecimalField DpsRate;
            public DecimalField TotTdiscCpd;
            public DecimalField TotGtaxCpd;
            public DecimalField DpsAppliedCpd;
            public DecimalField LastLineNo;
            public DecimalField LastChgsNo;
            public DecimalField LogNo;
            public DecimalField LastLogNo;
            public StringField Buyer;
            public DateTimeField ReceivedDate;
            public DecimalField DetailCount;
            public DecimalField ChargesCount;
            public DecimalField DpsEntryNo;
            public DecimalField CheckCrbal;
            public StringField PutaxType;
            public DecimalField GputaxPcent;
            public DecimalField TotGputaxAmt;
            public DecimalField TotLputaxAmt;
            public StringField Anlys7;
            public StringField Anlys8;
            public StringField ReceiveAll;
            public StringField Anlys9;
            public StringField Anlys10;
            public StringField Anlys11;
            public StringField Anlys12;
            public StringField Anlys13;
            public StringField Anlys14;

            public DecimalField GrnNoRecnum;
            public StringField GrnNoEntryMethod;
            public StringField GrnNoWithInvoice;
            public DateTimeField GrnNoReceivedDate;
            public StringField GrnNoPosted;
            public StringField GrnNoInspected;
            public StringField GrnNoReturned;
            public StringField GrnNoShipTo;
            public StringField GrnNoOwnerBranch;
            public StringField GrnNoSourceBranch;
            public StringField GrnNoVendorNo;
            public StringField GrnNoVendorName;
            public StringField GrnNoDoNo;
            public StringField GrnNoInvoiceNo;
            public StringField GrnNoPayTerms;
            public DecimalField GrnNoDiscDays;
            public DecimalField GrnNoDiscPcent;
            public DecimalField GrnNoDueDays;
            public DateTimeField GrnNoDiscountDate;
            public DateTimeField GrnNoDueDate;
            public StringField GrnNoCcy;
            public DecimalField GrnNoExchRate;
            public StringField GrnNoComputeTax;
            public DecimalField GrnNoTotPriceAmt;
            public DecimalField GrnNoTotPtaxAmt;
            public DecimalField GrnNoTotExtPrice;
            public DecimalField GrnNoTotLdiscAmt;
            public DecimalField GrnNoTotAtaxAmt;
            public DecimalField GrnNoTotItemAmt;
            public DecimalField GrnNoTotTdiscAmt;
            public DecimalField GrnNoNetTradeAmt;
            public DecimalField GrnNoTotChgsAmt;
            public DecimalField GrnNoNetOrdrAmt;
            public DecimalField GrnNoTotGtaxAmt;
            public DecimalField GrnNoNetPayAmt;
            public DecimalField GrnNoDpsCover;
            public DecimalField GrnNoDpsApplied;
            public DecimalField GrnNoNetBalAmt;
            public DecimalField GrnNoLocPriceAmt;
            public DecimalField GrnNoLocPtaxAmt;
            public DecimalField GrnNoLocExtPrice;
            public DecimalField GrnNoLocLdiscAmt;
            public DecimalField GrnNoLocAtaxAmt;
            public DecimalField GrnNoLocItemAmt;
            public DecimalField GrnNoLocTdiscAmt;
            public DecimalField GrnNoLocChgsAmt;
            public DecimalField GrnNoLocGtaxAmt;
            public DecimalField GrnNoLocPayAmt;
            public DecimalField GrnNoLocDpsApplied;
            public DateTimeField GrnNoCreatedDate;
            public StringField GrnNoCreatedBy;
            public DateTimeField GrnNoRevisedDate;
            public StringField GrnNoRevisedBy;
            public DateTimeField GrnNoPostedDate;
            public StringField GrnNoPostedBy;
            public DecimalField GrnNoLastOrderNo;
            public DecimalField GrnNoLastEntryNo;
            public DecimalField GrnNoLastChgsNo;
            public StringField GrnNoLockType;
            public StringField GrnNoLockRefNo;
            public DecimalField GrnNoLastLogNo;
            public StringField GrnNoAcctVendor;
            public StringField GrnNoAcctTdisc;
            public StringField GrnNoAcctGtax;
            public StringField GrnNoVendTaxCode;
            public StringField GrnNoCustTaxCode;
            public DecimalField GrnNoRetPriceAmt;
            public DecimalField GrnNoRetPtaxAmt;
            public DecimalField GrnNoRetExtPrice;
            public DecimalField GrnNoRetLdiscAmt;
            public DecimalField GrnNoRetAtaxAmt;
            public DecimalField GrnNoRetItemAmt;
            public DecimalField GrnNoRetTdiscAmt;
            public DecimalField GrnNoRetGtaxAmt;
            public DecimalField GrnNoRetChgsAmt;
            public DecimalField GrnNoRetPayAmt;
            public DecimalField GrnNoLretPriceAmt;
            public DecimalField GrnNoLretPtaxAmt;
            public DecimalField GrnNoLretExtPrice;
            public DecimalField GrnNoLretLdiscAmt;
            public DecimalField GrnNoLretAtaxAmt;
            public DecimalField GrnNoLretItemAmt;
            public DecimalField GrnNoLretTdiscAmt;
            public DecimalField GrnNoLretGtaxAmt;
            public DecimalField GrnNoLretChgsAmt;
            public DecimalField GrnNoLretPayAmt;
            public StringField GrnNoSettleAt;
            public StringField GrnNoCheckCrlimit;
            public DecimalField GrnNoCheckCrbal;
            public StringField GrnNoManual;
            public StringField GrnNoPutaxType;
            public DecimalField GrnNoGputaxPcent;
            public DecimalField GrnNoTotGputaxAmt;
            public StringField GrnNoPoPutaxType;
            public DecimalField GrnNoPoGputaxPcent;
            public DecimalField GrnNoLocGputaxAmt;
            public DecimalField GrnNoOrderCount;
            public DecimalField GrnNoTotLputaxAmt;
            public DecimalField GrnNoLocLputaxAmt;
            public DateTimeField GrnNoCutoffDate;
            public DecimalField GrnNoInspectPriority;
            public StringField GrnNoAnlys9;
            public StringField GrnNoAnlys10;
            public StringField GrnNoAnlys11;
            public StringField GrnNoAnlys12;
            public StringField GrnNoFlag;
            public StringField GrnNoHoldBy;
            public StringField GrnNoComments1;
            public StringField GrnNoComments2;
            public StringField GrnNoComments3;
            public StringField GrnNoComments4;
            public DecimalField GrnNoLastTextNo;
            public StringField GrnNoAnlys13;
            public StringField GrnNoAnlys14;
            public StringField GrnNoAnlys15;
            public StringField GrnNoAnlys16;
            public StringField GrnNoAnlys17;
            public StringField GrnNoAnlys18;
            public StringField GrnNoRefCompanyCode;
            public StringField GrnNoRefShipmentRefNo;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Purchasing.GrnOrder";
            }
        }
    }
}
