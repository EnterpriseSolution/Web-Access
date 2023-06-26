#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsPayableInvoiceDetailRow.cs
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

    [ConnectionKey("Finance"), TableName("[dbo].[APINVD]")]
    [DisplayName("Accounts Payable Invoice Detail"), InstanceName("Accounts Payable Invoice Detail"), TwoLevelCached]   
    public sealed class AccountsPayableInvoiceDetailRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Control No"), Column("CONTROL_NO"), Size(16), PrimaryKey, ForeignKey("[dbo].[APINVH]", "CONTROL_NO"), LeftJoin("jControlNo"), QuickSearch, TextualField("ControlNoMiscellaneous")]
        public String ControlNo
        {
            get { return Fields.ControlNo[this]; }
            set { Fields.ControlNo[this] = value; }
        }

        [DisplayName("Grn No"), Column("GRN_NO"), Size(16), PrimaryKey]
        public String GrnNo
        {
            get { return Fields.GrnNo[this]; }
            set { Fields.GrnNo[this] = value; }
        }

        [DisplayName("Entry No"), Column("ENTRY_NO"), Size(6), PrimaryKey]
        public Decimal? EntryNo
        {
            get { return Fields.EntryNo[this]; }
            set { Fields.EntryNo[this] = value; }
        }

        [DisplayName("Posted"), Column("POSTED"), Size(1)]
        public String Posted
        {
            get { return Fields.Posted[this]; }
            set { Fields.Posted[this] = value; }
        }

        [DisplayName("Returned"), Column("RETURNED"), Size(1), NotNull]
        public String Returned
        {
            get { return Fields.Returned[this]; }
            set { Fields.Returned[this] = value; }
        }

        [DisplayName("Order No"), Column("ORDER_NO"), Size(16), NotNull]
        public String OrderNo
        {
            get { return Fields.OrderNo[this]; }
            set { Fields.OrderNo[this] = value; }
        }

        [DisplayName("Line No"), Column("LINE_NO"), Size(6), NotNull]
        public Decimal? LineNo
        {
            get { return Fields.LineNo[this]; }
            set { Fields.LineNo[this] = value; }
        }

        [DisplayName("Item No"), Column("ITEM_NO"), Size(30)]
        public String ItemNo
        {
            get { return Fields.ItemNo[this]; }
            set { Fields.ItemNo[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(60)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Uom"), Column("UOM"), Size(4)]
        public String Uom
        {
            get { return Fields.Uom[this]; }
            set { Fields.Uom[this] = value; }
        }

        [DisplayName("Lot Size"), Column("LOT_SIZE"), Size(10), Scale(4)]
        public Decimal? LotSize
        {
            get { return Fields.LotSize[this]; }
            set { Fields.LotSize[this] = value; }
        }

        [DisplayName("Qty"), Column("QTY"), Size(14), Scale(4)]
        public Decimal? Qty
        {
            get { return Fields.Qty[this]; }
            set { Fields.Qty[this] = value; }
        }

        [DisplayName("Price"), Column("PRICE"), Size(18), Scale(6)]
        public Decimal? Price
        {
            get { return Fields.Price[this]; }
            set { Fields.Price[this] = value; }
        }

        [DisplayName("Ptax"), Column("PTAX"), Size(18), Scale(6)]
        public Decimal? Ptax
        {
            get { return Fields.Ptax[this]; }
            set { Fields.Ptax[this] = value; }
        }

        [DisplayName("Net Price"), Column("NET_PRICE"), Size(18), Scale(6)]
        public Decimal? NetPrice
        {
            get { return Fields.NetPrice[this]; }
            set { Fields.NetPrice[this] = value; }
        }

        [DisplayName("Ext Price"), Column("EXT_PRICE"), Size(14), Scale(2)]
        public Decimal? ExtPrice
        {
            get { return Fields.ExtPrice[this]; }
            set { Fields.ExtPrice[this] = value; }
        }

        [DisplayName("Ldisc Pcent"), Column("LDISC_PCENT"), Size(6), Scale(2)]
        public Decimal? LdiscPcent
        {
            get { return Fields.LdiscPcent[this]; }
            set { Fields.LdiscPcent[this] = value; }
        }

        [DisplayName("Ldisc Amt"), Column("LDISC_AMT"), Size(14), Scale(2)]
        public Decimal? LdiscAmt
        {
            get { return Fields.LdiscAmt[this]; }
            set { Fields.LdiscAmt[this] = value; }
        }

        [DisplayName("Atax Amt"), Column("ATAX_AMT"), Size(14), Scale(2)]
        public Decimal? AtaxAmt
        {
            get { return Fields.AtaxAmt[this]; }
            set { Fields.AtaxAmt[this] = value; }
        }

        [DisplayName("Net Item Amt"), Column("NET_ITEM_AMT"), Size(14), Scale(2)]
        public Decimal? NetItemAmt
        {
            get { return Fields.NetItemAmt[this]; }
            set { Fields.NetItemAmt[this] = value; }
        }

        [DisplayName("Price Amt"), Column("PRICE_AMT"), Size(14), Scale(2)]
        public Decimal? PriceAmt
        {
            get { return Fields.PriceAmt[this]; }
            set { Fields.PriceAmt[this] = value; }
        }

        [DisplayName("Ptax Amt"), Column("PTAX_AMT"), Size(14), Scale(2)]
        public Decimal? PtaxAmt
        {
            get { return Fields.PtaxAmt[this]; }
            set { Fields.PtaxAmt[this] = value; }
        }

        [DisplayName("Loc Price Amt"), Column("LOC_PRICE_AMT"), Size(14), Scale(2)]
        public Decimal? LocPriceAmt
        {
            get { return Fields.LocPriceAmt[this]; }
            set { Fields.LocPriceAmt[this] = value; }
        }

        [DisplayName("Loc Ptax Amt"), Column("LOC_PTAX_AMT"), Size(14), Scale(2)]
        public Decimal? LocPtaxAmt
        {
            get { return Fields.LocPtaxAmt[this]; }
            set { Fields.LocPtaxAmt[this] = value; }
        }

        [DisplayName("Loc Ext Price"), Column("LOC_EXT_PRICE"), Size(14), Scale(2)]
        public Decimal? LocExtPrice
        {
            get { return Fields.LocExtPrice[this]; }
            set { Fields.LocExtPrice[this] = value; }
        }

        [DisplayName("Loc Ldisc Amt"), Column("LOC_LDISC_AMT"), Size(14), Scale(2)]
        public Decimal? LocLdiscAmt
        {
            get { return Fields.LocLdiscAmt[this]; }
            set { Fields.LocLdiscAmt[this] = value; }
        }

        [DisplayName("Loc Atax Amt"), Column("LOC_ATAX_AMT"), Size(14), Scale(2)]
        public Decimal? LocAtaxAmt
        {
            get { return Fields.LocAtaxAmt[this]; }
            set { Fields.LocAtaxAmt[this] = value; }
        }

        [DisplayName("Loc Item Amt"), Column("LOC_ITEM_AMT"), Size(14), Scale(2)]
        public Decimal? LocItemAmt
        {
            get { return Fields.LocItemAmt[this]; }
            set { Fields.LocItemAmt[this] = value; }
        }

        [DisplayName("Grn Item Amt"), Column("GRN_ITEM_AMT"), Size(14), Scale(2)]
        public Decimal? GrnItemAmt
        {
            get { return Fields.GrnItemAmt[this]; }
            set { Fields.GrnItemAmt[this] = value; }
        }

        [DisplayName("Lgrn Item Amt"), Column("LGRN_ITEM_AMT"), Size(14), Scale(2)]
        public Decimal? LgrnItemAmt
        {
            get { return Fields.LgrnItemAmt[this]; }
            set { Fields.LgrnItemAmt[this] = value; }
        }

        [DisplayName("Varia Amt"), Column("VARIA_AMT"), Size(14), Scale(2)]
        public Decimal? VariaAmt
        {
            get { return Fields.VariaAmt[this]; }
            set { Fields.VariaAmt[this] = value; }
        }

        [DisplayName("Loc Varia Amt"), Column("LOC_VARIA_AMT"), Size(14), Scale(2)]
        public Decimal? LocVariaAmt
        {
            get { return Fields.LocVariaAmt[this]; }
            set { Fields.LocVariaAmt[this] = value; }
        }

        [DisplayName("Acct Purchase"), Column("ACCT_PURCHASE"), Size(30)]
        public String AcctPurchase
        {
            get { return Fields.AcctPurchase[this]; }
            set { Fields.AcctPurchase[this] = value; }
        }

        [DisplayName("Acct Ldisc"), Column("ACCT_LDISC"), Size(30)]
        public String AcctLdisc
        {
            get { return Fields.AcctLdisc[this]; }
            set { Fields.AcctLdisc[this] = value; }
        }

        [DisplayName("Acct Ptax"), Column("ACCT_PTAX"), Size(30)]
        public String AcctPtax
        {
            get { return Fields.AcctPtax[this]; }
            set { Fields.AcctPtax[this] = value; }
        }

        [DisplayName("Acct Atax"), Column("ACCT_ATAX"), Size(30)]
        public String AcctAtax
        {
            get { return Fields.AcctAtax[this]; }
            set { Fields.AcctAtax[this] = value; }
        }

        [DisplayName("Acct Variance"), Column("ACCT_VARIANCE"), Size(30)]
        public String AcctVariance
        {
            get { return Fields.AcctVariance[this]; }
            set { Fields.AcctVariance[this] = value; }
        }

        [DisplayName("Return Qty"), Column("RETURN_QTY"), Size(12), Scale(4)]
        public Decimal? ReturnQty
        {
            get { return Fields.ReturnQty[this]; }
            set { Fields.ReturnQty[this] = value; }
        }

        [DisplayName("Return Amt"), Column("RETURN_AMT"), Size(14), Scale(2)]
        public Decimal? ReturnAmt
        {
            get { return Fields.ReturnAmt[this]; }
            set { Fields.ReturnAmt[this] = value; }
        }

        [DisplayName("Lreturn Amt"), Column("LRETURN_AMT"), Size(14), Scale(2)]
        public Decimal? LreturnAmt
        {
            get { return Fields.LreturnAmt[this]; }
            set { Fields.LreturnAmt[this] = value; }
        }

        [DisplayName("Putax Pcent"), Column("PUTAX_PCENT"), Size(6), Scale(2)]
        public Decimal? PutaxPcent
        {
            get { return Fields.PutaxPcent[this]; }
            set { Fields.PutaxPcent[this] = value; }
        }

        [DisplayName("Putax Amt"), Column("PUTAX_AMT"), Size(14), Scale(2)]
        public Decimal? PutaxAmt
        {
            get { return Fields.PutaxAmt[this]; }
            set { Fields.PutaxAmt[this] = value; }
        }

        [DisplayName("Loc Putax Amt"), Column("LOC_PUTAX_AMT"), Size(14), Scale(2)]
        public Decimal? LocPutaxAmt
        {
            get { return Fields.LocPutaxAmt[this]; }
            set { Fields.LocPutaxAmt[this] = value; }
        }

        [DisplayName("Acct Putax"), Column("ACCT_PUTAX"), Size(30)]
        public String AcctPutax
        {
            get { return Fields.AcctPutax[this]; }
            set { Fields.AcctPutax[this] = value; }
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

        [DisplayName("Anlys19"), Column("ANLYS19"), Size(30)]
        public String Anlys19
        {
            get { return Fields.Anlys19[this]; }
            set { Fields.Anlys19[this] = value; }
        }

        [DisplayName("Anlys20"), Column("ANLYS20"), Size(30)]
        public String Anlys20
        {
            get { return Fields.Anlys20[this]; }
            set { Fields.Anlys20[this] = value; }
        }

        [DisplayName("Control No Recnum"), Expression("jControlNo.[RECNUM]")]
        public Decimal? ControlNoRecnum
        {
            get { return Fields.ControlNoRecnum[this]; }
            set { Fields.ControlNoRecnum[this] = value; }
        }

        [DisplayName("Control No Miscellaneous"), Expression("jControlNo.[MISCELLANEOUS]")]
        public String ControlNoMiscellaneous
        {
            get { return Fields.ControlNoMiscellaneous[this]; }
            set { Fields.ControlNoMiscellaneous[this] = value; }
        }

        [DisplayName("Control No Posted"), Expression("jControlNo.[POSTED]")]
        public String ControlNoPosted
        {
            get { return Fields.ControlNoPosted[this]; }
            set { Fields.ControlNoPosted[this] = value; }
        }

        [DisplayName("Control No Closed"), Expression("jControlNo.[CLOSED]")]
        public String ControlNoClosed
        {
            get { return Fields.ControlNoClosed[this]; }
            set { Fields.ControlNoClosed[this] = value; }
        }

        [DisplayName("Control No Returned"), Expression("jControlNo.[RETURNED]")]
        public String ControlNoReturned
        {
            get { return Fields.ControlNoReturned[this]; }
            set { Fields.ControlNoReturned[this] = value; }
        }

        [DisplayName("Control No Vendor No"), Expression("jControlNo.[VENDOR_NO]")]
        public String ControlNoVendorNo
        {
            get { return Fields.ControlNoVendorNo[this]; }
            set { Fields.ControlNoVendorNo[this] = value; }
        }

        [DisplayName("Control No Vendor Name"), Expression("jControlNo.[VENDOR_NAME]")]
        public String ControlNoVendorName
        {
            get { return Fields.ControlNoVendorName[this]; }
            set { Fields.ControlNoVendorName[this] = value; }
        }

        [DisplayName("Control No Invoice No"), Expression("jControlNo.[INVOICE_NO]")]
        public String ControlNoInvoiceNo
        {
            get { return Fields.ControlNoInvoiceNo[this]; }
            set { Fields.ControlNoInvoiceNo[this] = value; }
        }

        [DisplayName("Control No Invoice Date"), Expression("jControlNo.[INVOICE_DATE]")]
        public DateTime? ControlNoInvoiceDate
        {
            get { return Fields.ControlNoInvoiceDate[this]; }
            set { Fields.ControlNoInvoiceDate[this] = value; }
        }

        [DisplayName("Control No Received Date"), Expression("jControlNo.[RECEIVED_DATE]")]
        public DateTime? ControlNoReceivedDate
        {
            get { return Fields.ControlNoReceivedDate[this]; }
            set { Fields.ControlNoReceivedDate[this] = value; }
        }

        [DisplayName("Control No Period"), Expression("jControlNo.[PERIOD]")]
        public String ControlNoPeriod
        {
            get { return Fields.ControlNoPeriod[this]; }
            set { Fields.ControlNoPeriod[this] = value; }
        }

        [DisplayName("Control No Fiscal Year"), Expression("jControlNo.[FISCAL_YEAR]")]
        public Decimal? ControlNoFiscalYear
        {
            get { return Fields.ControlNoFiscalYear[this]; }
            set { Fields.ControlNoFiscalYear[this] = value; }
        }

        [DisplayName("Control No Period No"), Expression("jControlNo.[PERIOD_NO]")]
        public Decimal? ControlNoPeriodNo
        {
            get { return Fields.ControlNoPeriodNo[this]; }
            set { Fields.ControlNoPeriodNo[this] = value; }
        }

        [DisplayName("Control No Pay Terms"), Expression("jControlNo.[PAY_TERMS]")]
        public String ControlNoPayTerms
        {
            get { return Fields.ControlNoPayTerms[this]; }
            set { Fields.ControlNoPayTerms[this] = value; }
        }

        [DisplayName("Control No Disc Percent"), Expression("jControlNo.[DISC_PERCENT]")]
        public Decimal? ControlNoDiscPercent
        {
            get { return Fields.ControlNoDiscPercent[this]; }
            set { Fields.ControlNoDiscPercent[this] = value; }
        }

        [DisplayName("Control No Disc Days"), Expression("jControlNo.[DISC_DAYS]")]
        public Decimal? ControlNoDiscDays
        {
            get { return Fields.ControlNoDiscDays[this]; }
            set { Fields.ControlNoDiscDays[this] = value; }
        }

        [DisplayName("Control No Net Days"), Expression("jControlNo.[NET_DAYS]")]
        public Decimal? ControlNoNetDays
        {
            get { return Fields.ControlNoNetDays[this]; }
            set { Fields.ControlNoNetDays[this] = value; }
        }

        [DisplayName("Control No Discount Date"), Expression("jControlNo.[DISCOUNT_DATE]")]
        public DateTime? ControlNoDiscountDate
        {
            get { return Fields.ControlNoDiscountDate[this]; }
            set { Fields.ControlNoDiscountDate[this] = value; }
        }

        [DisplayName("Control No Due Date"), Expression("jControlNo.[DUE_DATE]")]
        public DateTime? ControlNoDueDate
        {
            get { return Fields.ControlNoDueDate[this]; }
            set { Fields.ControlNoDueDate[this] = value; }
        }

        [DisplayName("Control No Planned Date"), Expression("jControlNo.[PLANNED_DATE]")]
        public DateTime? ControlNoPlannedDate
        {
            get { return Fields.ControlNoPlannedDate[this]; }
            set { Fields.ControlNoPlannedDate[this] = value; }
        }

        [DisplayName("Control No Payment Branch"), Expression("jControlNo.[PAYMENT_BRANCH]")]
        public String ControlNoPaymentBranch
        {
            get { return Fields.ControlNoPaymentBranch[this]; }
            set { Fields.ControlNoPaymentBranch[this] = value; }
        }

        [DisplayName("Control No Ccy"), Expression("jControlNo.[CCY]")]
        public String ControlNoCcy
        {
            get { return Fields.ControlNoCcy[this]; }
            set { Fields.ControlNoCcy[this] = value; }
        }

        [DisplayName("Control No Exch Rate"), Expression("jControlNo.[EXCH_RATE]")]
        public Decimal? ControlNoExchRate
        {
            get { return Fields.ControlNoExchRate[this]; }
            set { Fields.ControlNoExchRate[this] = value; }
        }

        [DisplayName("Control No Tot Price Amt"), Expression("jControlNo.[TOT_PRICE_AMT]")]
        public Decimal? ControlNoTotPriceAmt
        {
            get { return Fields.ControlNoTotPriceAmt[this]; }
            set { Fields.ControlNoTotPriceAmt[this] = value; }
        }

        [DisplayName("Control No Tot Ptax Amt"), Expression("jControlNo.[TOT_PTAX_AMT]")]
        public Decimal? ControlNoTotPtaxAmt
        {
            get { return Fields.ControlNoTotPtaxAmt[this]; }
            set { Fields.ControlNoTotPtaxAmt[this] = value; }
        }

        [DisplayName("Control No Tot Ext Price"), Expression("jControlNo.[TOT_EXT_PRICE]")]
        public Decimal? ControlNoTotExtPrice
        {
            get { return Fields.ControlNoTotExtPrice[this]; }
            set { Fields.ControlNoTotExtPrice[this] = value; }
        }

        [DisplayName("Control No Tot Ldisc Amt"), Expression("jControlNo.[TOT_LDISC_AMT]")]
        public Decimal? ControlNoTotLdiscAmt
        {
            get { return Fields.ControlNoTotLdiscAmt[this]; }
            set { Fields.ControlNoTotLdiscAmt[this] = value; }
        }

        [DisplayName("Control No Tot Atax Amt"), Expression("jControlNo.[TOT_ATAX_AMT]")]
        public Decimal? ControlNoTotAtaxAmt
        {
            get { return Fields.ControlNoTotAtaxAmt[this]; }
            set { Fields.ControlNoTotAtaxAmt[this] = value; }
        }

        [DisplayName("Control No Tot Item Amt"), Expression("jControlNo.[TOT_ITEM_AMT]")]
        public Decimal? ControlNoTotItemAmt
        {
            get { return Fields.ControlNoTotItemAmt[this]; }
            set { Fields.ControlNoTotItemAmt[this] = value; }
        }

        [DisplayName("Control No Tot Tdisc Amt"), Expression("jControlNo.[TOT_TDISC_AMT]")]
        public Decimal? ControlNoTotTdiscAmt
        {
            get { return Fields.ControlNoTotTdiscAmt[this]; }
            set { Fields.ControlNoTotTdiscAmt[this] = value; }
        }

        [DisplayName("Control No Net Trade Amt"), Expression("jControlNo.[NET_TRADE_AMT]")]
        public Decimal? ControlNoNetTradeAmt
        {
            get { return Fields.ControlNoNetTradeAmt[this]; }
            set { Fields.ControlNoNetTradeAmt[this] = value; }
        }

        [DisplayName("Control No Tot Chgs Amt"), Expression("jControlNo.[TOT_CHGS_AMT]")]
        public Decimal? ControlNoTotChgsAmt
        {
            get { return Fields.ControlNoTotChgsAmt[this]; }
            set { Fields.ControlNoTotChgsAmt[this] = value; }
        }

        [DisplayName("Control No Net Ordr Amt"), Expression("jControlNo.[NET_ORDR_AMT]")]
        public Decimal? ControlNoNetOrdrAmt
        {
            get { return Fields.ControlNoNetOrdrAmt[this]; }
            set { Fields.ControlNoNetOrdrAmt[this] = value; }
        }

        [DisplayName("Control No Tot Gtax Amt"), Expression("jControlNo.[TOT_GTAX_AMT]")]
        public Decimal? ControlNoTotGtaxAmt
        {
            get { return Fields.ControlNoTotGtaxAmt[this]; }
            set { Fields.ControlNoTotGtaxAmt[this] = value; }
        }

        [DisplayName("Control No Net Invo Amt"), Expression("jControlNo.[NET_INVO_AMT]")]
        public Decimal? ControlNoNetInvoAmt
        {
            get { return Fields.ControlNoNetInvoAmt[this]; }
            set { Fields.ControlNoNetInvoAmt[this] = value; }
        }

        [DisplayName("Control No Dps Applied"), Expression("jControlNo.[DPS_APPLIED]")]
        public Decimal? ControlNoDpsApplied
        {
            get { return Fields.ControlNoDpsApplied[this]; }
            set { Fields.ControlNoDpsApplied[this] = value; }
        }

        [DisplayName("Control No Net Bal Amt"), Expression("jControlNo.[NET_BAL_AMT]")]
        public Decimal? ControlNoNetBalAmt
        {
            get { return Fields.ControlNoNetBalAmt[this]; }
            set { Fields.ControlNoNetBalAmt[this] = value; }
        }

        [DisplayName("Control No Loc Price Amt"), Expression("jControlNo.[LOC_PRICE_AMT]")]
        public Decimal? ControlNoLocPriceAmt
        {
            get { return Fields.ControlNoLocPriceAmt[this]; }
            set { Fields.ControlNoLocPriceAmt[this] = value; }
        }

        [DisplayName("Control No Loc Ptax Amt"), Expression("jControlNo.[LOC_PTAX_AMT]")]
        public Decimal? ControlNoLocPtaxAmt
        {
            get { return Fields.ControlNoLocPtaxAmt[this]; }
            set { Fields.ControlNoLocPtaxAmt[this] = value; }
        }

        [DisplayName("Control No Loc Ext Price"), Expression("jControlNo.[LOC_EXT_PRICE]")]
        public Decimal? ControlNoLocExtPrice
        {
            get { return Fields.ControlNoLocExtPrice[this]; }
            set { Fields.ControlNoLocExtPrice[this] = value; }
        }

        [DisplayName("Control No Loc Ldisc Amt"), Expression("jControlNo.[LOC_LDISC_AMT]")]
        public Decimal? ControlNoLocLdiscAmt
        {
            get { return Fields.ControlNoLocLdiscAmt[this]; }
            set { Fields.ControlNoLocLdiscAmt[this] = value; }
        }

        [DisplayName("Control No Loc Atax Amt"), Expression("jControlNo.[LOC_ATAX_AMT]")]
        public Decimal? ControlNoLocAtaxAmt
        {
            get { return Fields.ControlNoLocAtaxAmt[this]; }
            set { Fields.ControlNoLocAtaxAmt[this] = value; }
        }

        [DisplayName("Control No Loc Item Amt"), Expression("jControlNo.[LOC_ITEM_AMT]")]
        public Decimal? ControlNoLocItemAmt
        {
            get { return Fields.ControlNoLocItemAmt[this]; }
            set { Fields.ControlNoLocItemAmt[this] = value; }
        }

        [DisplayName("Control No Loc Tdisc Amt"), Expression("jControlNo.[LOC_TDISC_AMT]")]
        public Decimal? ControlNoLocTdiscAmt
        {
            get { return Fields.ControlNoLocTdiscAmt[this]; }
            set { Fields.ControlNoLocTdiscAmt[this] = value; }
        }

        [DisplayName("Control No Loc Chgs Amt"), Expression("jControlNo.[LOC_CHGS_AMT]")]
        public Decimal? ControlNoLocChgsAmt
        {
            get { return Fields.ControlNoLocChgsAmt[this]; }
            set { Fields.ControlNoLocChgsAmt[this] = value; }
        }

        [DisplayName("Control No Loc Gtax Amt"), Expression("jControlNo.[LOC_GTAX_AMT]")]
        public Decimal? ControlNoLocGtaxAmt
        {
            get { return Fields.ControlNoLocGtaxAmt[this]; }
            set { Fields.ControlNoLocGtaxAmt[this] = value; }
        }

        [DisplayName("Control No Loc Invo Amt"), Expression("jControlNo.[LOC_INVO_AMT]")]
        public Decimal? ControlNoLocInvoAmt
        {
            get { return Fields.ControlNoLocInvoAmt[this]; }
            set { Fields.ControlNoLocInvoAmt[this] = value; }
        }

        [DisplayName("Control No Loc Dps Applied"), Expression("jControlNo.[LOC_DPS_APPLIED]")]
        public Decimal? ControlNoLocDpsApplied
        {
            get { return Fields.ControlNoLocDpsApplied[this]; }
            set { Fields.ControlNoLocDpsApplied[this] = value; }
        }

        [DisplayName("Control No Grn Net Amt"), Expression("jControlNo.[GRN_NET_AMT]")]
        public Decimal? ControlNoGrnNetAmt
        {
            get { return Fields.ControlNoGrnNetAmt[this]; }
            set { Fields.ControlNoGrnNetAmt[this] = value; }
        }

        [DisplayName("Control No Lgrn Net Amt"), Expression("jControlNo.[LGRN_NET_AMT]")]
        public Decimal? ControlNoLgrnNetAmt
        {
            get { return Fields.ControlNoLgrnNetAmt[this]; }
            set { Fields.ControlNoLgrnNetAmt[this] = value; }
        }

        [DisplayName("Control No Varia Amt"), Expression("jControlNo.[VARIA_AMT]")]
        public Decimal? ControlNoVariaAmt
        {
            get { return Fields.ControlNoVariaAmt[this]; }
            set { Fields.ControlNoVariaAmt[this] = value; }
        }

        [DisplayName("Control No Lvaria Amt"), Expression("jControlNo.[LVARIA_AMT]")]
        public Decimal? ControlNoLvariaAmt
        {
            get { return Fields.ControlNoLvariaAmt[this]; }
            set { Fields.ControlNoLvariaAmt[this] = value; }
        }

        [DisplayName("Control No Item Varia Amt"), Expression("jControlNo.[ITEM_VARIA_AMT]")]
        public Decimal? ControlNoItemVariaAmt
        {
            get { return Fields.ControlNoItemVariaAmt[this]; }
            set { Fields.ControlNoItemVariaAmt[this] = value; }
        }

        [DisplayName("Control No Litem Varia Amt"), Expression("jControlNo.[LITEM_VARIA_AMT]")]
        public Decimal? ControlNoLitemVariaAmt
        {
            get { return Fields.ControlNoLitemVariaAmt[this]; }
            set { Fields.ControlNoLitemVariaAmt[this] = value; }
        }

        [DisplayName("Control No Chgs Varia Amt"), Expression("jControlNo.[CHGS_VARIA_AMT]")]
        public Decimal? ControlNoChgsVariaAmt
        {
            get { return Fields.ControlNoChgsVariaAmt[this]; }
            set { Fields.ControlNoChgsVariaAmt[this] = value; }
        }

        [DisplayName("Control No Lchgs Varia Amt"), Expression("jControlNo.[LCHGS_VARIA_AMT]")]
        public Decimal? ControlNoLchgsVariaAmt
        {
            get { return Fields.ControlNoLchgsVariaAmt[this]; }
            set { Fields.ControlNoLchgsVariaAmt[this] = value; }
        }

        [DisplayName("Control No Last Line No"), Expression("jControlNo.[LAST_LINE_NO]")]
        public Decimal? ControlNoLastLineNo
        {
            get { return Fields.ControlNoLastLineNo[this]; }
            set { Fields.ControlNoLastLineNo[this] = value; }
        }

        [DisplayName("Control No Created Date"), Expression("jControlNo.[CREATED_DATE]")]
        public DateTime? ControlNoCreatedDate
        {
            get { return Fields.ControlNoCreatedDate[this]; }
            set { Fields.ControlNoCreatedDate[this] = value; }
        }

        [DisplayName("Control No Created By"), Expression("jControlNo.[CREATED_BY]")]
        public String ControlNoCreatedBy
        {
            get { return Fields.ControlNoCreatedBy[this]; }
            set { Fields.ControlNoCreatedBy[this] = value; }
        }

        [DisplayName("Control No Revised Date"), Expression("jControlNo.[REVISED_DATE]")]
        public DateTime? ControlNoRevisedDate
        {
            get { return Fields.ControlNoRevisedDate[this]; }
            set { Fields.ControlNoRevisedDate[this] = value; }
        }

        [DisplayName("Control No Revised By"), Expression("jControlNo.[REVISED_BY]")]
        public String ControlNoRevisedBy
        {
            get { return Fields.ControlNoRevisedBy[this]; }
            set { Fields.ControlNoRevisedBy[this] = value; }
        }

        [DisplayName("Control No Posted Date"), Expression("jControlNo.[POSTED_DATE]")]
        public DateTime? ControlNoPostedDate
        {
            get { return Fields.ControlNoPostedDate[this]; }
            set { Fields.ControlNoPostedDate[this] = value; }
        }

        [DisplayName("Control No Posted By"), Expression("jControlNo.[POSTED_BY]")]
        public String ControlNoPostedBy
        {
            get { return Fields.ControlNoPostedBy[this]; }
            set { Fields.ControlNoPostedBy[this] = value; }
        }

        [DisplayName("Control No Hold"), Expression("jControlNo.[HOLD]")]
        public String ControlNoHold
        {
            get { return Fields.ControlNoHold[this]; }
            set { Fields.ControlNoHold[this] = value; }
        }

        [DisplayName("Control No Hold Until"), Expression("jControlNo.[HOLD_UNTIL]")]
        public DateTime? ControlNoHoldUntil
        {
            get { return Fields.ControlNoHoldUntil[this]; }
            set { Fields.ControlNoHoldUntil[this] = value; }
        }

        [DisplayName("Control No Hold Date"), Expression("jControlNo.[HOLD_DATE]")]
        public DateTime? ControlNoHoldDate
        {
            get { return Fields.ControlNoHoldDate[this]; }
            set { Fields.ControlNoHoldDate[this] = value; }
        }

        [DisplayName("Control No Hold By"), Expression("jControlNo.[HOLD_BY]")]
        public String ControlNoHoldBy
        {
            get { return Fields.ControlNoHoldBy[this]; }
            set { Fields.ControlNoHoldBy[this] = value; }
        }

        [DisplayName("Control No Acct Vendor"), Expression("jControlNo.[ACCT_VENDOR]")]
        public String ControlNoAcctVendor
        {
            get { return Fields.ControlNoAcctVendor[this]; }
            set { Fields.ControlNoAcctVendor[this] = value; }
        }

        [DisplayName("Control No Acct Tdisc"), Expression("jControlNo.[ACCT_TDISC]")]
        public String ControlNoAcctTdisc
        {
            get { return Fields.ControlNoAcctTdisc[this]; }
            set { Fields.ControlNoAcctTdisc[this] = value; }
        }

        [DisplayName("Control No Acct Gtax"), Expression("jControlNo.[ACCT_GTAX]")]
        public String ControlNoAcctGtax
        {
            get { return Fields.ControlNoAcctGtax[this]; }
            set { Fields.ControlNoAcctGtax[this] = value; }
        }

        [DisplayName("Control No Acct Variance"), Expression("jControlNo.[ACCT_VARIANCE]")]
        public String ControlNoAcctVariance
        {
            get { return Fields.ControlNoAcctVariance[this]; }
            set { Fields.ControlNoAcctVariance[this] = value; }
        }

        [DisplayName("Control No Settled Amt"), Expression("jControlNo.[SETTLED_AMT]")]
        public Decimal? ControlNoSettledAmt
        {
            get { return Fields.ControlNoSettledAmt[this]; }
            set { Fields.ControlNoSettledAmt[this] = value; }
        }

        [DisplayName("Control No Lsettled Amt"), Expression("jControlNo.[LSETTLED_AMT]")]
        public Decimal? ControlNoLsettledAmt
        {
            get { return Fields.ControlNoLsettledAmt[this]; }
            set { Fields.ControlNoLsettledAmt[this] = value; }
        }

        [DisplayName("Control No Term Disc Amt"), Expression("jControlNo.[TERM_DISC_AMT]")]
        public Decimal? ControlNoTermDiscAmt
        {
            get { return Fields.ControlNoTermDiscAmt[this]; }
            set { Fields.ControlNoTermDiscAmt[this] = value; }
        }

        [DisplayName("Control No Lterm Disc Amt"), Expression("jControlNo.[LTERM_DISC_AMT]")]
        public Decimal? ControlNoLtermDiscAmt
        {
            get { return Fields.ControlNoLtermDiscAmt[this]; }
            set { Fields.ControlNoLtermDiscAmt[this] = value; }
        }

        [DisplayName("Control No Return Amt"), Expression("jControlNo.[RETURN_AMT]")]
        public Decimal? ControlNoReturnAmt
        {
            get { return Fields.ControlNoReturnAmt[this]; }
            set { Fields.ControlNoReturnAmt[this] = value; }
        }

        [DisplayName("Control No Lreturn Amt"), Expression("jControlNo.[LRETURN_AMT]")]
        public Decimal? ControlNoLreturnAmt
        {
            get { return Fields.ControlNoLreturnAmt[this]; }
            set { Fields.ControlNoLreturnAmt[this] = value; }
        }

        [DisplayName("Control No Bal Amt"), Expression("jControlNo.[BAL_AMT]")]
        public Decimal? ControlNoBalAmt
        {
            get { return Fields.ControlNoBalAmt[this]; }
            set { Fields.ControlNoBalAmt[this] = value; }
        }

        [DisplayName("Control No Bal Amt Local"), Expression("jControlNo.[BAL_AMT_LOCAL]")]
        public Decimal? ControlNoBalAmtLocal
        {
            get { return Fields.ControlNoBalAmtLocal[this]; }
            set { Fields.ControlNoBalAmtLocal[this] = value; }
        }

        [DisplayName("Control No Over Alloc Amt"), Expression("jControlNo.[OVER_ALLOC_AMT]")]
        public Decimal? ControlNoOverAllocAmt
        {
            get { return Fields.ControlNoOverAllocAmt[this]; }
            set { Fields.ControlNoOverAllocAmt[this] = value; }
        }

        [DisplayName("Control No Lover Alloc Amt"), Expression("jControlNo.[LOVER_ALLOC_AMT]")]
        public Decimal? ControlNoLoverAllocAmt
        {
            get { return Fields.ControlNoLoverAllocAmt[this]; }
            set { Fields.ControlNoLoverAllocAmt[this] = value; }
        }

        [DisplayName("Control No Batch Select"), Expression("jControlNo.[BATCH_SELECT]")]
        public String ControlNoBatchSelect
        {
            get { return Fields.ControlNoBatchSelect[this]; }
            set { Fields.ControlNoBatchSelect[this] = value; }
        }

        [DisplayName("Control No Gl Link"), Expression("jControlNo.[GL_LINK]")]
        public String ControlNoGlLink
        {
            get { return Fields.ControlNoGlLink[this]; }
            set { Fields.ControlNoGlLink[this] = value; }
        }

        [DisplayName("Control No Gl Link Type"), Expression("jControlNo.[GL_LINK_TYPE]")]
        public String ControlNoGlLinkType
        {
            get { return Fields.ControlNoGlLinkType[this]; }
            set { Fields.ControlNoGlLinkType[this] = value; }
        }

        [DisplayName("Control No Gl Link No"), Expression("jControlNo.[GL_LINK_NO]")]
        public String ControlNoGlLinkNo
        {
            get { return Fields.ControlNoGlLinkNo[this]; }
            set { Fields.ControlNoGlLinkNo[this] = value; }
        }

        [DisplayName("Control No Last Log No"), Expression("jControlNo.[LAST_LOG_NO]")]
        public Decimal? ControlNoLastLogNo
        {
            get { return Fields.ControlNoLastLogNo[this]; }
            set { Fields.ControlNoLastLogNo[this] = value; }
        }

        [DisplayName("Control No Lock Type"), Expression("jControlNo.[LOCK_TYPE]")]
        public String ControlNoLockType
        {
            get { return Fields.ControlNoLockType[this]; }
            set { Fields.ControlNoLockType[this] = value; }
        }

        [DisplayName("Control No Lock Ref No"), Expression("jControlNo.[LOCK_REF_NO]")]
        public String ControlNoLockRefNo
        {
            get { return Fields.ControlNoLockRefNo[this]; }
            set { Fields.ControlNoLockRefNo[this] = value; }
        }

        [DisplayName("Control No Hold Reason"), Expression("jControlNo.[HOLD_REASON]")]
        public String ControlNoHoldReason
        {
            get { return Fields.ControlNoHoldReason[this]; }
            set { Fields.ControlNoHoldReason[this] = value; }
        }

        [DisplayName("Control No Owner Branch"), Expression("jControlNo.[OWNER_BRANCH]")]
        public String ControlNoOwnerBranch
        {
            get { return Fields.ControlNoOwnerBranch[this]; }
            set { Fields.ControlNoOwnerBranch[this] = value; }
        }

        [DisplayName("Control No Source Branch"), Expression("jControlNo.[SOURCE_BRANCH]")]
        public String ControlNoSourceBranch
        {
            get { return Fields.ControlNoSourceBranch[this]; }
            set { Fields.ControlNoSourceBranch[this] = value; }
        }

        [DisplayName("Control No Particulars"), Expression("jControlNo.[PARTICULARS]")]
        public String ControlNoParticulars
        {
            get { return Fields.ControlNoParticulars[this]; }
            set { Fields.ControlNoParticulars[this] = value; }
        }

        [DisplayName("Control No Check Crlimit"), Expression("jControlNo.[CHECK_CRLIMIT]")]
        public String ControlNoCheckCrlimit
        {
            get { return Fields.ControlNoCheckCrlimit[this]; }
            set { Fields.ControlNoCheckCrlimit[this] = value; }
        }

        [DisplayName("Control No Check Crbal"), Expression("jControlNo.[CHECK_CRBAL]")]
        public Decimal? ControlNoCheckCrbal
        {
            get { return Fields.ControlNoCheckCrbal[this]; }
            set { Fields.ControlNoCheckCrbal[this] = value; }
        }

        [DisplayName("Control No Acct Putax"), Expression("jControlNo.[ACCT_PUTAX]")]
        public String ControlNoAcctPutax
        {
            get { return Fields.ControlNoAcctPutax[this]; }
            set { Fields.ControlNoAcctPutax[this] = value; }
        }

        [DisplayName("Control No Putax Type"), Expression("jControlNo.[PUTAX_TYPE]")]
        public String ControlNoPutaxType
        {
            get { return Fields.ControlNoPutaxType[this]; }
            set { Fields.ControlNoPutaxType[this] = value; }
        }

        [DisplayName("Control No Gputax Pcent"), Expression("jControlNo.[GPUTAX_PCENT]")]
        public Decimal? ControlNoGputaxPcent
        {
            get { return Fields.ControlNoGputaxPcent[this]; }
            set { Fields.ControlNoGputaxPcent[this] = value; }
        }

        [DisplayName("Control No Tot Gputax Amt"), Expression("jControlNo.[TOT_GPUTAX_AMT]")]
        public Decimal? ControlNoTotGputaxAmt
        {
            get { return Fields.ControlNoTotGputaxAmt[this]; }
            set { Fields.ControlNoTotGputaxAmt[this] = value; }
        }

        [DisplayName("Control No Tot Lputax Amt"), Expression("jControlNo.[TOT_LPUTAX_AMT]")]
        public Decimal? ControlNoTotLputaxAmt
        {
            get { return Fields.ControlNoTotLputaxAmt[this]; }
            set { Fields.ControlNoTotLputaxAmt[this] = value; }
        }

        [DisplayName("Control No Loc Gputax Amt"), Expression("jControlNo.[LOC_GPUTAX_AMT]")]
        public Decimal? ControlNoLocGputaxAmt
        {
            get { return Fields.ControlNoLocGputaxAmt[this]; }
            set { Fields.ControlNoLocGputaxAmt[this] = value; }
        }

        [DisplayName("Control No Loc Lputax Amt"), Expression("jControlNo.[LOC_LPUTAX_AMT]")]
        public Decimal? ControlNoLocLputaxAmt
        {
            get { return Fields.ControlNoLocLputaxAmt[this]; }
            set { Fields.ControlNoLocLputaxAmt[this] = value; }
        }

        [DisplayName("Control No Grn Putax Type"), Expression("jControlNo.[GRN_PUTAX_TYPE]")]
        public String ControlNoGrnPutaxType
        {
            get { return Fields.ControlNoGrnPutaxType[this]; }
            set { Fields.ControlNoGrnPutaxType[this] = value; }
        }

        [DisplayName("Control No Grn Gputax Pcent"), Expression("jControlNo.[GRN_GPUTAX_PCENT]")]
        public Decimal? ControlNoGrnGputaxPcent
        {
            get { return Fields.ControlNoGrnGputaxPcent[this]; }
            set { Fields.ControlNoGrnGputaxPcent[this] = value; }
        }

        [DisplayName("Control No Grn Count"), Expression("jControlNo.[GRN_COUNT]")]
        public Decimal? ControlNoGrnCount
        {
            get { return Fields.ControlNoGrnCount[this]; }
            set { Fields.ControlNoGrnCount[this] = value; }
        }

        [DisplayName("Control No Ai Link"), Expression("jControlNo.[AI_LINK]")]
        public String ControlNoAiLink
        {
            get { return Fields.ControlNoAiLink[this]; }
            set { Fields.ControlNoAiLink[this] = value; }
        }

        [DisplayName("Control No Ai Link Type"), Expression("jControlNo.[AI_LINK_TYPE]")]
        public String ControlNoAiLinkType
        {
            get { return Fields.ControlNoAiLinkType[this]; }
            set { Fields.ControlNoAiLinkType[this] = value; }
        }

        [DisplayName("Control No Ai Link No"), Expression("jControlNo.[AI_LINK_NO]")]
        public String ControlNoAiLinkNo
        {
            get { return Fields.ControlNoAiLinkNo[this]; }
            set { Fields.ControlNoAiLinkNo[this] = value; }
        }

        [DisplayName("Control No Anlys9"), Expression("jControlNo.[ANLYS9]")]
        public String ControlNoAnlys9
        {
            get { return Fields.ControlNoAnlys9[this]; }
            set { Fields.ControlNoAnlys9[this] = value; }
        }

        [DisplayName("Control No Anlys10"), Expression("jControlNo.[ANLYS10]")]
        public String ControlNoAnlys10
        {
            get { return Fields.ControlNoAnlys10[this]; }
            set { Fields.ControlNoAnlys10[this] = value; }
        }

        [DisplayName("Control No Anlys11"), Expression("jControlNo.[ANLYS11]")]
        public String ControlNoAnlys11
        {
            get { return Fields.ControlNoAnlys11[this]; }
            set { Fields.ControlNoAnlys11[this] = value; }
        }

        [DisplayName("Control No Anlys12"), Expression("jControlNo.[ANLYS12]")]
        public String ControlNoAnlys12
        {
            get { return Fields.ControlNoAnlys12[this]; }
            set { Fields.ControlNoAnlys12[this] = value; }
        }

        [DisplayName("Control No Anlys13"), Expression("jControlNo.[ANLYS13]")]
        public String ControlNoAnlys13
        {
            get { return Fields.ControlNoAnlys13[this]; }
            set { Fields.ControlNoAnlys13[this] = value; }
        }

        [DisplayName("Control No Anlys14"), Expression("jControlNo.[ANLYS14]")]
        public String ControlNoAnlys14
        {
            get { return Fields.ControlNoAnlys14[this]; }
            set { Fields.ControlNoAnlys14[this] = value; }
        }

        [DisplayName("Control No Anlys15"), Expression("jControlNo.[ANLYS15]")]
        public String ControlNoAnlys15
        {
            get { return Fields.ControlNoAnlys15[this]; }
            set { Fields.ControlNoAnlys15[this] = value; }
        }

        [DisplayName("Control No Anlys16"), Expression("jControlNo.[ANLYS16]")]
        public String ControlNoAnlys16
        {
            get { return Fields.ControlNoAnlys16[this]; }
            set { Fields.ControlNoAnlys16[this] = value; }
        }

        [DisplayName("Control No Anlys17"), Expression("jControlNo.[ANLYS17]")]
        public String ControlNoAnlys17
        {
            get { return Fields.ControlNoAnlys17[this]; }
            set { Fields.ControlNoAnlys17[this] = value; }
        }

        [DisplayName("Control No Anlys18"), Expression("jControlNo.[ANLYS18]")]
        public String ControlNoAnlys18
        {
            get { return Fields.ControlNoAnlys18[this]; }
            set { Fields.ControlNoAnlys18[this] = value; }
        }

        [DisplayName("Control No Po No"), Expression("jControlNo.[PO_NO]")]
        public String ControlNoPoNo
        {
            get { return Fields.ControlNoPoNo[this]; }
            set { Fields.ControlNoPoNo[this] = value; }
        }

        [DisplayName("Control No Origin Country"), Expression("jControlNo.[ORIGIN_COUNTRY]")]
        public String ControlNoOriginCountry
        {
            get { return Fields.ControlNoOriginCountry[this]; }
            set { Fields.ControlNoOriginCountry[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ControlNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AccountsPayableInvoiceDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField ControlNo;
            public StringField GrnNo;
            public DecimalField EntryNo;
            public StringField Posted;
            public StringField Returned;
            public StringField OrderNo;
            public DecimalField LineNo;
            public StringField ItemNo;
            public StringField Description;
            public StringField Uom;
            public DecimalField LotSize;
            public DecimalField Qty;
            public DecimalField Price;
            public DecimalField Ptax;
            public DecimalField NetPrice;
            public DecimalField ExtPrice;
            public DecimalField LdiscPcent;
            public DecimalField LdiscAmt;
            public DecimalField AtaxAmt;
            public DecimalField NetItemAmt;
            public DecimalField PriceAmt;
            public DecimalField PtaxAmt;
            public DecimalField LocPriceAmt;
            public DecimalField LocPtaxAmt;
            public DecimalField LocExtPrice;
            public DecimalField LocLdiscAmt;
            public DecimalField LocAtaxAmt;
            public DecimalField LocItemAmt;
            public DecimalField GrnItemAmt;
            public DecimalField LgrnItemAmt;
            public DecimalField VariaAmt;
            public DecimalField LocVariaAmt;
            public StringField AcctPurchase;
            public StringField AcctLdisc;
            public StringField AcctPtax;
            public StringField AcctAtax;
            public StringField AcctVariance;
            public DecimalField ReturnQty;
            public DecimalField ReturnAmt;
            public DecimalField LreturnAmt;
            public DecimalField PutaxPcent;
            public DecimalField PutaxAmt;
            public DecimalField LocPutaxAmt;
            public StringField AcctPutax;
            public StringField Anlys3;
            public StringField Anlys4;
            public StringField Anlys5;
            public StringField Anlys6;
            public StringField Anlys15;
            public StringField Anlys16;
            public StringField Anlys17;
            public StringField Anlys18;
            public StringField Anlys19;
            public StringField Anlys20;

            public DecimalField ControlNoRecnum;
            public StringField ControlNoMiscellaneous;
            public StringField ControlNoPosted;
            public StringField ControlNoClosed;
            public StringField ControlNoReturned;
            public StringField ControlNoVendorNo;
            public StringField ControlNoVendorName;
            public StringField ControlNoInvoiceNo;
            public DateTimeField ControlNoInvoiceDate;
            public DateTimeField ControlNoReceivedDate;
            public StringField ControlNoPeriod;
            public DecimalField ControlNoFiscalYear;
            public DecimalField ControlNoPeriodNo;
            public StringField ControlNoPayTerms;
            public DecimalField ControlNoDiscPercent;
            public DecimalField ControlNoDiscDays;
            public DecimalField ControlNoNetDays;
            public DateTimeField ControlNoDiscountDate;
            public DateTimeField ControlNoDueDate;
            public DateTimeField ControlNoPlannedDate;
            public StringField ControlNoPaymentBranch;
            public StringField ControlNoCcy;
            public DecimalField ControlNoExchRate;
            public DecimalField ControlNoTotPriceAmt;
            public DecimalField ControlNoTotPtaxAmt;
            public DecimalField ControlNoTotExtPrice;
            public DecimalField ControlNoTotLdiscAmt;
            public DecimalField ControlNoTotAtaxAmt;
            public DecimalField ControlNoTotItemAmt;
            public DecimalField ControlNoTotTdiscAmt;
            public DecimalField ControlNoNetTradeAmt;
            public DecimalField ControlNoTotChgsAmt;
            public DecimalField ControlNoNetOrdrAmt;
            public DecimalField ControlNoTotGtaxAmt;
            public DecimalField ControlNoNetInvoAmt;
            public DecimalField ControlNoDpsApplied;
            public DecimalField ControlNoNetBalAmt;
            public DecimalField ControlNoLocPriceAmt;
            public DecimalField ControlNoLocPtaxAmt;
            public DecimalField ControlNoLocExtPrice;
            public DecimalField ControlNoLocLdiscAmt;
            public DecimalField ControlNoLocAtaxAmt;
            public DecimalField ControlNoLocItemAmt;
            public DecimalField ControlNoLocTdiscAmt;
            public DecimalField ControlNoLocChgsAmt;
            public DecimalField ControlNoLocGtaxAmt;
            public DecimalField ControlNoLocInvoAmt;
            public DecimalField ControlNoLocDpsApplied;
            public DecimalField ControlNoGrnNetAmt;
            public DecimalField ControlNoLgrnNetAmt;
            public DecimalField ControlNoVariaAmt;
            public DecimalField ControlNoLvariaAmt;
            public DecimalField ControlNoItemVariaAmt;
            public DecimalField ControlNoLitemVariaAmt;
            public DecimalField ControlNoChgsVariaAmt;
            public DecimalField ControlNoLchgsVariaAmt;
            public DecimalField ControlNoLastLineNo;
            public DateTimeField ControlNoCreatedDate;
            public StringField ControlNoCreatedBy;
            public DateTimeField ControlNoRevisedDate;
            public StringField ControlNoRevisedBy;
            public DateTimeField ControlNoPostedDate;
            public StringField ControlNoPostedBy;
            public StringField ControlNoHold;
            public DateTimeField ControlNoHoldUntil;
            public DateTimeField ControlNoHoldDate;
            public StringField ControlNoHoldBy;
            public StringField ControlNoAcctVendor;
            public StringField ControlNoAcctTdisc;
            public StringField ControlNoAcctGtax;
            public StringField ControlNoAcctVariance;
            public DecimalField ControlNoSettledAmt;
            public DecimalField ControlNoLsettledAmt;
            public DecimalField ControlNoTermDiscAmt;
            public DecimalField ControlNoLtermDiscAmt;
            public DecimalField ControlNoReturnAmt;
            public DecimalField ControlNoLreturnAmt;
            public DecimalField ControlNoBalAmt;
            public DecimalField ControlNoBalAmtLocal;
            public DecimalField ControlNoOverAllocAmt;
            public DecimalField ControlNoLoverAllocAmt;
            public StringField ControlNoBatchSelect;
            public StringField ControlNoGlLink;
            public StringField ControlNoGlLinkType;
            public StringField ControlNoGlLinkNo;
            public DecimalField ControlNoLastLogNo;
            public StringField ControlNoLockType;
            public StringField ControlNoLockRefNo;
            public StringField ControlNoHoldReason;
            public StringField ControlNoOwnerBranch;
            public StringField ControlNoSourceBranch;
            public StringField ControlNoParticulars;
            public StringField ControlNoCheckCrlimit;
            public DecimalField ControlNoCheckCrbal;
            public StringField ControlNoAcctPutax;
            public StringField ControlNoPutaxType;
            public DecimalField ControlNoGputaxPcent;
            public DecimalField ControlNoTotGputaxAmt;
            public DecimalField ControlNoTotLputaxAmt;
            public DecimalField ControlNoLocGputaxAmt;
            public DecimalField ControlNoLocLputaxAmt;
            public StringField ControlNoGrnPutaxType;
            public DecimalField ControlNoGrnGputaxPcent;
            public DecimalField ControlNoGrnCount;
            public StringField ControlNoAiLink;
            public StringField ControlNoAiLinkType;
            public StringField ControlNoAiLinkNo;
            public StringField ControlNoAnlys9;
            public StringField ControlNoAnlys10;
            public StringField ControlNoAnlys11;
            public StringField ControlNoAnlys12;
            public StringField ControlNoAnlys13;
            public StringField ControlNoAnlys14;
            public StringField ControlNoAnlys15;
            public StringField ControlNoAnlys16;
            public StringField ControlNoAnlys17;
            public StringField ControlNoAnlys18;
            public StringField ControlNoPoNo;
            public StringField ControlNoOriginCountry;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Finance.AccountsPayableInvoiceDetail";
            }
        }
    }
}
