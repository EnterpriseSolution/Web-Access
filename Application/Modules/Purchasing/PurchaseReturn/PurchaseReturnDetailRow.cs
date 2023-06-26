#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PurchaseReturnDetailRow.cs
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

    [ConnectionKey("Purchasing"), TableName("[dbo].[PURETD]")]
    [DisplayName("Purchase Return Detail"), InstanceName("Purchase Return Detail"), TwoLevelCached]   
    public sealed class PurchaseReturnDetailRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Ref No"), Column("REF_NO"), Size(16), PrimaryKey, ForeignKey("[dbo].[PURETH]", "REF_NO"), LeftJoin("jRefNo"), QuickSearch, TextualField("RefNoEntryMethod")]
        public String RefNo
        {
            get { return Fields.RefNo[this]; }
            set { Fields.RefNo[this] = value; }
        }

        [DisplayName("Entry No"), Column("ENTRY_NO"), Size(6), PrimaryKey]
        public Decimal? EntryNo
        {
            get { return Fields.EntryNo[this]; }
            set { Fields.EntryNo[this] = value; }
        }

        [DisplayName("Order No"), Column("ORDER_NO"), Size(16)]
        public String OrderNo
        {
            get { return Fields.OrderNo[this]; }
            set { Fields.OrderNo[this] = value; }
        }

        [DisplayName("Line No"), Column("LINE_NO"), Size(6)]
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

        [DisplayName("Qty Balance"), Column("QTY_BALANCE"), Size(14), Scale(4)]
        public Decimal? QtyBalance
        {
            get { return Fields.QtyBalance[this]; }
            set { Fields.QtyBalance[this] = value; }
        }

        [DisplayName("Qty Returned"), Column("QTY_RETURNED"), Size(14), Scale(4)]
        public Decimal? QtyReturned
        {
            get { return Fields.QtyReturned[this]; }
            set { Fields.QtyReturned[this] = value; }
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

        [DisplayName("Refund Amt"), Column("REFUND_AMT"), Size(14), Scale(2)]
        public Decimal? RefundAmt
        {
            get { return Fields.RefundAmt[this]; }
            set { Fields.RefundAmt[this] = value; }
        }

        [DisplayName("Varia Amt"), Column("VARIA_AMT"), Size(14), Scale(2)]
        public Decimal? VariaAmt
        {
            get { return Fields.VariaAmt[this]; }
            set { Fields.VariaAmt[this] = value; }
        }

        [DisplayName("Ldisc Rate"), Column("LDISC_RATE"), Size(10), Scale(4)]
        public Decimal? LdiscRate
        {
            get { return Fields.LdiscRate[this]; }
            set { Fields.LdiscRate[this] = value; }
        }

        [DisplayName("Atax Rate"), Column("ATAX_RATE"), Size(10), Scale(4)]
        public Decimal? AtaxRate
        {
            get { return Fields.AtaxRate[this]; }
            set { Fields.AtaxRate[this] = value; }
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

        [DisplayName("Loc Refund Amt"), Column("LOC_REFUND_AMT"), Size(14), Scale(2)]
        public Decimal? LocRefundAmt
        {
            get { return Fields.LocRefundAmt[this]; }
            set { Fields.LocRefundAmt[this] = value; }
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

        [DisplayName("Cost Returned"), Column("COST_RETURNED"), Size(14), Scale(2)]
        public Decimal? CostReturned
        {
            get { return Fields.CostReturned[this]; }
            set { Fields.CostReturned[this] = value; }
        }

        [DisplayName("Loc"), Column("LOC"), Size(4)]
        public String Loc
        {
            get { return Fields.Loc[this]; }
            set { Fields.Loc[this] = value; }
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

        [DisplayName("Reorder"), Column("REORDER"), Size(1)]
        public String Reorder
        {
            get { return Fields.Reorder[this]; }
            set { Fields.Reorder[this] = value; }
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

        [DisplayName("Inspection Ref No"), Column("INSPECTION_REF_NO"), Size(16)]
        public String InspectionRefNo
        {
            get { return Fields.InspectionRefNo[this]; }
            set { Fields.InspectionRefNo[this] = value; }
        }

        [DisplayName("Remarks"), Column("REMARKS"), Size(1073741823)]
        public String Remarks
        {
            get { return Fields.Remarks[this]; }
            set { Fields.Remarks[this] = value; }
        }

        [DisplayName("Ref No Recnum"), Expression("jRefNo.[RECNUM]")]
        public Decimal? RefNoRecnum
        {
            get { return Fields.RefNoRecnum[this]; }
            set { Fields.RefNoRecnum[this] = value; }
        }

        [DisplayName("Ref No Entry Method"), Expression("jRefNo.[ENTRY_METHOD]")]
        public String RefNoEntryMethod
        {
            get { return Fields.RefNoEntryMethod[this]; }
            set { Fields.RefNoEntryMethod[this] = value; }
        }

        [DisplayName("Ref No Posted"), Expression("jRefNo.[POSTED]")]
        public String RefNoPosted
        {
            get { return Fields.RefNoPosted[this]; }
            set { Fields.RefNoPosted[this] = value; }
        }

        [DisplayName("Ref No Tran Date"), Expression("jRefNo.[TRAN_DATE]")]
        public DateTime? RefNoTranDate
        {
            get { return Fields.RefNoTranDate[this]; }
            set { Fields.RefNoTranDate[this] = value; }
        }

        [DisplayName("Ref No Grn No"), Expression("jRefNo.[GRN_NO]")]
        public String RefNoGrnNo
        {
            get { return Fields.RefNoGrnNo[this]; }
            set { Fields.RefNoGrnNo[this] = value; }
        }

        [DisplayName("Ref No Vendor No"), Expression("jRefNo.[VENDOR_NO]")]
        public String RefNoVendorNo
        {
            get { return Fields.RefNoVendorNo[this]; }
            set { Fields.RefNoVendorNo[this] = value; }
        }

        [DisplayName("Ref No Vendor Name"), Expression("jRefNo.[VENDOR_NAME]")]
        public String RefNoVendorName
        {
            get { return Fields.RefNoVendorName[this]; }
            set { Fields.RefNoVendorName[this] = value; }
        }

        [DisplayName("Ref No Do No"), Expression("jRefNo.[DO_NO]")]
        public String RefNoDoNo
        {
            get { return Fields.RefNoDoNo[this]; }
            set { Fields.RefNoDoNo[this] = value; }
        }

        [DisplayName("Ref No Invoice No"), Expression("jRefNo.[INVOICE_NO]")]
        public String RefNoInvoiceNo
        {
            get { return Fields.RefNoInvoiceNo[this]; }
            set { Fields.RefNoInvoiceNo[this] = value; }
        }

        [DisplayName("Ref No Hold Items"), Expression("jRefNo.[HOLD_ITEMS]")]
        public String RefNoHoldItems
        {
            get { return Fields.RefNoHoldItems[this]; }
            set { Fields.RefNoHoldItems[this] = value; }
        }

        [DisplayName("Ref No Loc"), Expression("jRefNo.[LOC]")]
        public String RefNoLoc
        {
            get { return Fields.RefNoLoc[this]; }
            set { Fields.RefNoLoc[this] = value; }
        }

        [DisplayName("Ref No Ccy"), Expression("jRefNo.[CCY]")]
        public String RefNoCcy
        {
            get { return Fields.RefNoCcy[this]; }
            set { Fields.RefNoCcy[this] = value; }
        }

        [DisplayName("Ref No Exch Rate"), Expression("jRefNo.[EXCH_RATE]")]
        public Decimal? RefNoExchRate
        {
            get { return Fields.RefNoExchRate[this]; }
            set { Fields.RefNoExchRate[this] = value; }
        }

        [DisplayName("Ref No Tot Price Amt"), Expression("jRefNo.[TOT_PRICE_AMT]")]
        public Decimal? RefNoTotPriceAmt
        {
            get { return Fields.RefNoTotPriceAmt[this]; }
            set { Fields.RefNoTotPriceAmt[this] = value; }
        }

        [DisplayName("Ref No Tot Ptax Amt"), Expression("jRefNo.[TOT_PTAX_AMT]")]
        public Decimal? RefNoTotPtaxAmt
        {
            get { return Fields.RefNoTotPtaxAmt[this]; }
            set { Fields.RefNoTotPtaxAmt[this] = value; }
        }

        [DisplayName("Ref No Tot Ext Price"), Expression("jRefNo.[TOT_EXT_PRICE]")]
        public Decimal? RefNoTotExtPrice
        {
            get { return Fields.RefNoTotExtPrice[this]; }
            set { Fields.RefNoTotExtPrice[this] = value; }
        }

        [DisplayName("Ref No Tot Ldisc Amt"), Expression("jRefNo.[TOT_LDISC_AMT]")]
        public Decimal? RefNoTotLdiscAmt
        {
            get { return Fields.RefNoTotLdiscAmt[this]; }
            set { Fields.RefNoTotLdiscAmt[this] = value; }
        }

        [DisplayName("Ref No Tot Atax Amt"), Expression("jRefNo.[TOT_ATAX_AMT]")]
        public Decimal? RefNoTotAtaxAmt
        {
            get { return Fields.RefNoTotAtaxAmt[this]; }
            set { Fields.RefNoTotAtaxAmt[this] = value; }
        }

        [DisplayName("Ref No Tot Item Amt"), Expression("jRefNo.[TOT_ITEM_AMT]")]
        public Decimal? RefNoTotItemAmt
        {
            get { return Fields.RefNoTotItemAmt[this]; }
            set { Fields.RefNoTotItemAmt[this] = value; }
        }

        [DisplayName("Ref No Tot Refund Amt"), Expression("jRefNo.[TOT_REFUND_AMT]")]
        public Decimal? RefNoTotRefundAmt
        {
            get { return Fields.RefNoTotRefundAmt[this]; }
            set { Fields.RefNoTotRefundAmt[this] = value; }
        }

        [DisplayName("Ref No Tot Varia Amt"), Expression("jRefNo.[TOT_VARIA_AMT]")]
        public Decimal? RefNoTotVariaAmt
        {
            get { return Fields.RefNoTotVariaAmt[this]; }
            set { Fields.RefNoTotVariaAmt[this] = value; }
        }

        [DisplayName("Ref No Tdisc Pcent"), Expression("jRefNo.[TDISC_PCENT]")]
        public Decimal? RefNoTdiscPcent
        {
            get { return Fields.RefNoTdiscPcent[this]; }
            set { Fields.RefNoTdiscPcent[this] = value; }
        }

        [DisplayName("Ref No Tot Tdisc Amt"), Expression("jRefNo.[TOT_TDISC_AMT]")]
        public Decimal? RefNoTotTdiscAmt
        {
            get { return Fields.RefNoTotTdiscAmt[this]; }
            set { Fields.RefNoTotTdiscAmt[this] = value; }
        }

        [DisplayName("Ref No Net Trade Amt"), Expression("jRefNo.[NET_TRADE_AMT]")]
        public Decimal? RefNoNetTradeAmt
        {
            get { return Fields.RefNoNetTradeAmt[this]; }
            set { Fields.RefNoNetTradeAmt[this] = value; }
        }

        [DisplayName("Ref No Tot Chgs Amt"), Expression("jRefNo.[TOT_CHGS_AMT]")]
        public Decimal? RefNoTotChgsAmt
        {
            get { return Fields.RefNoTotChgsAmt[this]; }
            set { Fields.RefNoTotChgsAmt[this] = value; }
        }

        [DisplayName("Ref No Net Ordr Amt"), Expression("jRefNo.[NET_ORDR_AMT]")]
        public Decimal? RefNoNetOrdrAmt
        {
            get { return Fields.RefNoNetOrdrAmt[this]; }
            set { Fields.RefNoNetOrdrAmt[this] = value; }
        }

        [DisplayName("Ref No Tot Gtax Amt"), Expression("jRefNo.[TOT_GTAX_AMT]")]
        public Decimal? RefNoTotGtaxAmt
        {
            get { return Fields.RefNoTotGtaxAmt[this]; }
            set { Fields.RefNoTotGtaxAmt[this] = value; }
        }

        [DisplayName("Ref No Net Pay Amt"), Expression("jRefNo.[NET_PAY_AMT]")]
        public Decimal? RefNoNetPayAmt
        {
            get { return Fields.RefNoNetPayAmt[this]; }
            set { Fields.RefNoNetPayAmt[this] = value; }
        }

        [DisplayName("Ref No Tot Tdisc Cpd"), Expression("jRefNo.[TOT_TDISC_CPD]")]
        public Decimal? RefNoTotTdiscCpd
        {
            get { return Fields.RefNoTotTdiscCpd[this]; }
            set { Fields.RefNoTotTdiscCpd[this] = value; }
        }

        [DisplayName("Ref No Loc Price Amt"), Expression("jRefNo.[LOC_PRICE_AMT]")]
        public Decimal? RefNoLocPriceAmt
        {
            get { return Fields.RefNoLocPriceAmt[this]; }
            set { Fields.RefNoLocPriceAmt[this] = value; }
        }

        [DisplayName("Ref No Loc Ptax Amt"), Expression("jRefNo.[LOC_PTAX_AMT]")]
        public Decimal? RefNoLocPtaxAmt
        {
            get { return Fields.RefNoLocPtaxAmt[this]; }
            set { Fields.RefNoLocPtaxAmt[this] = value; }
        }

        [DisplayName("Ref No Loc Ext Price"), Expression("jRefNo.[LOC_EXT_PRICE]")]
        public Decimal? RefNoLocExtPrice
        {
            get { return Fields.RefNoLocExtPrice[this]; }
            set { Fields.RefNoLocExtPrice[this] = value; }
        }

        [DisplayName("Ref No Loc Ldisc Amt"), Expression("jRefNo.[LOC_LDISC_AMT]")]
        public Decimal? RefNoLocLdiscAmt
        {
            get { return Fields.RefNoLocLdiscAmt[this]; }
            set { Fields.RefNoLocLdiscAmt[this] = value; }
        }

        [DisplayName("Ref No Loc Atax Amt"), Expression("jRefNo.[LOC_ATAX_AMT]")]
        public Decimal? RefNoLocAtaxAmt
        {
            get { return Fields.RefNoLocAtaxAmt[this]; }
            set { Fields.RefNoLocAtaxAmt[this] = value; }
        }

        [DisplayName("Ref No Loc Item Amt"), Expression("jRefNo.[LOC_ITEM_AMT]")]
        public Decimal? RefNoLocItemAmt
        {
            get { return Fields.RefNoLocItemAmt[this]; }
            set { Fields.RefNoLocItemAmt[this] = value; }
        }

        [DisplayName("Ref No Loc Refund Amt"), Expression("jRefNo.[LOC_REFUND_AMT]")]
        public Decimal? RefNoLocRefundAmt
        {
            get { return Fields.RefNoLocRefundAmt[this]; }
            set { Fields.RefNoLocRefundAmt[this] = value; }
        }

        [DisplayName("Ref No Loc Varia Amt"), Expression("jRefNo.[LOC_VARIA_AMT]")]
        public Decimal? RefNoLocVariaAmt
        {
            get { return Fields.RefNoLocVariaAmt[this]; }
            set { Fields.RefNoLocVariaAmt[this] = value; }
        }

        [DisplayName("Ref No Loc Tdisc Amt"), Expression("jRefNo.[LOC_TDISC_AMT]")]
        public Decimal? RefNoLocTdiscAmt
        {
            get { return Fields.RefNoLocTdiscAmt[this]; }
            set { Fields.RefNoLocTdiscAmt[this] = value; }
        }

        [DisplayName("Ref No Loc Chgs Amt"), Expression("jRefNo.[LOC_CHGS_AMT]")]
        public Decimal? RefNoLocChgsAmt
        {
            get { return Fields.RefNoLocChgsAmt[this]; }
            set { Fields.RefNoLocChgsAmt[this] = value; }
        }

        [DisplayName("Ref No Loc Gtax Amt"), Expression("jRefNo.[LOC_GTAX_AMT]")]
        public Decimal? RefNoLocGtaxAmt
        {
            get { return Fields.RefNoLocGtaxAmt[this]; }
            set { Fields.RefNoLocGtaxAmt[this] = value; }
        }

        [DisplayName("Ref No Loc Pay Amt"), Expression("jRefNo.[LOC_PAY_AMT]")]
        public Decimal? RefNoLocPayAmt
        {
            get { return Fields.RefNoLocPayAmt[this]; }
            set { Fields.RefNoLocPayAmt[this] = value; }
        }

        [DisplayName("Ref No Acct Vendor"), Expression("jRefNo.[ACCT_VENDOR]")]
        public String RefNoAcctVendor
        {
            get { return Fields.RefNoAcctVendor[this]; }
            set { Fields.RefNoAcctVendor[this] = value; }
        }

        [DisplayName("Ref No Acct Tdisc"), Expression("jRefNo.[ACCT_TDISC]")]
        public String RefNoAcctTdisc
        {
            get { return Fields.RefNoAcctTdisc[this]; }
            set { Fields.RefNoAcctTdisc[this] = value; }
        }

        [DisplayName("Ref No Acct Gtax"), Expression("jRefNo.[ACCT_GTAX]")]
        public String RefNoAcctGtax
        {
            get { return Fields.RefNoAcctGtax[this]; }
            set { Fields.RefNoAcctGtax[this] = value; }
        }

        [DisplayName("Ref No Created Date"), Expression("jRefNo.[CREATED_DATE]")]
        public DateTime? RefNoCreatedDate
        {
            get { return Fields.RefNoCreatedDate[this]; }
            set { Fields.RefNoCreatedDate[this] = value; }
        }

        [DisplayName("Ref No Created By"), Expression("jRefNo.[CREATED_BY]")]
        public String RefNoCreatedBy
        {
            get { return Fields.RefNoCreatedBy[this]; }
            set { Fields.RefNoCreatedBy[this] = value; }
        }

        [DisplayName("Ref No Revised Date"), Expression("jRefNo.[REVISED_DATE]")]
        public DateTime? RefNoRevisedDate
        {
            get { return Fields.RefNoRevisedDate[this]; }
            set { Fields.RefNoRevisedDate[this] = value; }
        }

        [DisplayName("Ref No Revised By"), Expression("jRefNo.[REVISED_BY]")]
        public String RefNoRevisedBy
        {
            get { return Fields.RefNoRevisedBy[this]; }
            set { Fields.RefNoRevisedBy[this] = value; }
        }

        [DisplayName("Ref No Posted Date"), Expression("jRefNo.[POSTED_DATE]")]
        public DateTime? RefNoPostedDate
        {
            get { return Fields.RefNoPostedDate[this]; }
            set { Fields.RefNoPostedDate[this] = value; }
        }

        [DisplayName("Ref No Posted By"), Expression("jRefNo.[POSTED_BY]")]
        public String RefNoPostedBy
        {
            get { return Fields.RefNoPostedBy[this]; }
            set { Fields.RefNoPostedBy[this] = value; }
        }

        [DisplayName("Ref No Log No"), Expression("jRefNo.[LOG_NO]")]
        public Decimal? RefNoLogNo
        {
            get { return Fields.RefNoLogNo[this]; }
            set { Fields.RefNoLogNo[this] = value; }
        }

        [DisplayName("Ref No Last Log No"), Expression("jRefNo.[LAST_LOG_NO]")]
        public Decimal? RefNoLastLogNo
        {
            get { return Fields.RefNoLastLogNo[this]; }
            set { Fields.RefNoLastLogNo[this] = value; }
        }

        [DisplayName("Ref No Owner Branch"), Expression("jRefNo.[OWNER_BRANCH]")]
        public String RefNoOwnerBranch
        {
            get { return Fields.RefNoOwnerBranch[this]; }
            set { Fields.RefNoOwnerBranch[this] = value; }
        }

        [DisplayName("Ref No Source Branch"), Expression("jRefNo.[SOURCE_BRANCH]")]
        public String RefNoSourceBranch
        {
            get { return Fields.RefNoSourceBranch[this]; }
            set { Fields.RefNoSourceBranch[this] = value; }
        }

        [DisplayName("Ref No Settle At"), Expression("jRefNo.[SETTLE_AT]")]
        public String RefNoSettleAt
        {
            get { return Fields.RefNoSettleAt[this]; }
            set { Fields.RefNoSettleAt[this] = value; }
        }

        [DisplayName("Ref No Reason"), Expression("jRefNo.[REASON]")]
        public String RefNoReason
        {
            get { return Fields.RefNoReason[this]; }
            set { Fields.RefNoReason[this] = value; }
        }

        [DisplayName("Ref No Anlys9"), Expression("jRefNo.[ANLYS9]")]
        public String RefNoAnlys9
        {
            get { return Fields.RefNoAnlys9[this]; }
            set { Fields.RefNoAnlys9[this] = value; }
        }

        [DisplayName("Ref No Anlys10"), Expression("jRefNo.[ANLYS10]")]
        public String RefNoAnlys10
        {
            get { return Fields.RefNoAnlys10[this]; }
            set { Fields.RefNoAnlys10[this] = value; }
        }

        [DisplayName("Ref No Anlys11"), Expression("jRefNo.[ANLYS11]")]
        public String RefNoAnlys11
        {
            get { return Fields.RefNoAnlys11[this]; }
            set { Fields.RefNoAnlys11[this] = value; }
        }

        [DisplayName("Ref No Anlys12"), Expression("jRefNo.[ANLYS12]")]
        public String RefNoAnlys12
        {
            get { return Fields.RefNoAnlys12[this]; }
            set { Fields.RefNoAnlys12[this] = value; }
        }

        [DisplayName("Ref No Anlys13"), Expression("jRefNo.[ANLYS13]")]
        public String RefNoAnlys13
        {
            get { return Fields.RefNoAnlys13[this]; }
            set { Fields.RefNoAnlys13[this] = value; }
        }

        [DisplayName("Ref No Anlys14"), Expression("jRefNo.[ANLYS14]")]
        public String RefNoAnlys14
        {
            get { return Fields.RefNoAnlys14[this]; }
            set { Fields.RefNoAnlys14[this] = value; }
        }

        [DisplayName("Ref No Anlys15"), Expression("jRefNo.[ANLYS15]")]
        public String RefNoAnlys15
        {
            get { return Fields.RefNoAnlys15[this]; }
            set { Fields.RefNoAnlys15[this] = value; }
        }

        [DisplayName("Ref No Anlys16"), Expression("jRefNo.[ANLYS16]")]
        public String RefNoAnlys16
        {
            get { return Fields.RefNoAnlys16[this]; }
            set { Fields.RefNoAnlys16[this] = value; }
        }

        [DisplayName("Ref No Anlys17"), Expression("jRefNo.[ANLYS17]")]
        public String RefNoAnlys17
        {
            get { return Fields.RefNoAnlys17[this]; }
            set { Fields.RefNoAnlys17[this] = value; }
        }

        [DisplayName("Ref No Anlys18"), Expression("jRefNo.[ANLYS18]")]
        public String RefNoAnlys18
        {
            get { return Fields.RefNoAnlys18[this]; }
            set { Fields.RefNoAnlys18[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.RefNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PurchaseReturnDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField RefNo;
            public DecimalField EntryNo;
            public StringField OrderNo;
            public DecimalField LineNo;
            public StringField ItemNo;
            public StringField Description;
            public StringField Uom;
            public DecimalField LotSize;
            public DecimalField QtyBalance;
            public DecimalField QtyReturned;
            public DecimalField Price;
            public DecimalField Ptax;
            public DecimalField NetPrice;
            public DecimalField ExtPrice;
            public DecimalField LdiscPcent;
            public DecimalField LdiscAmt;
            public DecimalField AtaxAmt;
            public DecimalField NetItemAmt;
            public DecimalField RefundAmt;
            public DecimalField VariaAmt;
            public DecimalField LdiscRate;
            public DecimalField AtaxRate;
            public DecimalField PriceAmt;
            public DecimalField PtaxAmt;
            public DecimalField LocPriceAmt;
            public DecimalField LocPtaxAmt;
            public DecimalField LocExtPrice;
            public DecimalField LocLdiscAmt;
            public DecimalField LocAtaxAmt;
            public DecimalField LocItemAmt;
            public DecimalField LocRefundAmt;
            public DecimalField LocVariaAmt;
            public StringField AcctPurchase;
            public StringField AcctLdisc;
            public StringField AcctPtax;
            public StringField AcctAtax;
            public StringField AcctVariance;
            public DecimalField CostReturned;
            public StringField Loc;
            public StringField Anlys3;
            public StringField Anlys4;
            public StringField Anlys5;
            public StringField Anlys6;
            public StringField Reorder;
            public StringField Anlys15;
            public StringField Anlys16;
            public StringField Anlys17;
            public StringField Anlys18;
            public StringField Anlys19;
            public StringField Anlys20;
            public StringField InspectionRefNo;
            public StringField Remarks;

            public DecimalField RefNoRecnum;
            public StringField RefNoEntryMethod;
            public StringField RefNoPosted;
            public DateTimeField RefNoTranDate;
            public StringField RefNoGrnNo;
            public StringField RefNoVendorNo;
            public StringField RefNoVendorName;
            public StringField RefNoDoNo;
            public StringField RefNoInvoiceNo;
            public StringField RefNoHoldItems;
            public StringField RefNoLoc;
            public StringField RefNoCcy;
            public DecimalField RefNoExchRate;
            public DecimalField RefNoTotPriceAmt;
            public DecimalField RefNoTotPtaxAmt;
            public DecimalField RefNoTotExtPrice;
            public DecimalField RefNoTotLdiscAmt;
            public DecimalField RefNoTotAtaxAmt;
            public DecimalField RefNoTotItemAmt;
            public DecimalField RefNoTotRefundAmt;
            public DecimalField RefNoTotVariaAmt;
            public DecimalField RefNoTdiscPcent;
            public DecimalField RefNoTotTdiscAmt;
            public DecimalField RefNoNetTradeAmt;
            public DecimalField RefNoTotChgsAmt;
            public DecimalField RefNoNetOrdrAmt;
            public DecimalField RefNoTotGtaxAmt;
            public DecimalField RefNoNetPayAmt;
            public DecimalField RefNoTotTdiscCpd;
            public DecimalField RefNoLocPriceAmt;
            public DecimalField RefNoLocPtaxAmt;
            public DecimalField RefNoLocExtPrice;
            public DecimalField RefNoLocLdiscAmt;
            public DecimalField RefNoLocAtaxAmt;
            public DecimalField RefNoLocItemAmt;
            public DecimalField RefNoLocRefundAmt;
            public DecimalField RefNoLocVariaAmt;
            public DecimalField RefNoLocTdiscAmt;
            public DecimalField RefNoLocChgsAmt;
            public DecimalField RefNoLocGtaxAmt;
            public DecimalField RefNoLocPayAmt;
            public StringField RefNoAcctVendor;
            public StringField RefNoAcctTdisc;
            public StringField RefNoAcctGtax;
            public DateTimeField RefNoCreatedDate;
            public StringField RefNoCreatedBy;
            public DateTimeField RefNoRevisedDate;
            public StringField RefNoRevisedBy;
            public DateTimeField RefNoPostedDate;
            public StringField RefNoPostedBy;
            public DecimalField RefNoLogNo;
            public DecimalField RefNoLastLogNo;
            public StringField RefNoOwnerBranch;
            public StringField RefNoSourceBranch;
            public StringField RefNoSettleAt;
            public StringField RefNoReason;
            public StringField RefNoAnlys9;
            public StringField RefNoAnlys10;
            public StringField RefNoAnlys11;
            public StringField RefNoAnlys12;
            public StringField RefNoAnlys13;
            public StringField RefNoAnlys14;
            public StringField RefNoAnlys15;
            public StringField RefNoAnlys16;
            public StringField RefNoAnlys17;
            public StringField RefNoAnlys18;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Purchasing.PurchaseReturnDetail";
            }
        }
    }
}
