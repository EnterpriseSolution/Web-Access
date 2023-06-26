#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  GrnOrderDetailRow.cs
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

    [ConnectionKey("Purchasing"), TableName("[dbo].[PUGRND]")]
    [DisplayName("Grn Order Detail"), InstanceName("Grn Order Detail"), TwoLevelCached]   
    public sealed class GrnOrderDetailRow : Row, IIdRow, INameRow
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

        [DisplayName("Entry No"), Column("ENTRY_NO"), Size(6), PrimaryKey]
        public Decimal? EntryNo
        {
            get { return Fields.EntryNo[this]; }
            set { Fields.EntryNo[this] = value; }
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

        [DisplayName("Item No"), Column("ITEM_NO"), Size(30), NotNull]
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

        [DisplayName("Qty Balance"), Column("QTY_BALANCE"), Size(16), Scale(4)]
        public Decimal? QtyBalance
        {
            get { return Fields.QtyBalance[this]; }
            set { Fields.QtyBalance[this] = value; }
        }

        [DisplayName("Qty Due"), Column("QTY_DUE"), Size(14), Scale(4)]
        public Decimal? QtyDue
        {
            get { return Fields.QtyDue[this]; }
            set { Fields.QtyDue[this] = value; }
        }

        [DisplayName("Qty Received"), Column("QTY_RECEIVED"), Size(14), Scale(4)]
        public Decimal? QtyReceived
        {
            get { return Fields.QtyReceived[this]; }
            set { Fields.QtyReceived[this] = value; }
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

        [DisplayName("Atax Rate"), Column("ATAX_RATE"), Size(10), Scale(4)]
        public Decimal? AtaxRate
        {
            get { return Fields.AtaxRate[this]; }
            set { Fields.AtaxRate[this] = value; }
        }

        [DisplayName("Ldisc Rate"), Column("LDISC_RATE"), Size(10), Scale(4)]
        public Decimal? LdiscRate
        {
            get { return Fields.LdiscRate[this]; }
            set { Fields.LdiscRate[this] = value; }
        }

        [DisplayName("Atax Amt Cpd"), Column("ATAX_AMT_CPD"), Size(14), Scale(2)]
        public Decimal? AtaxAmtCpd
        {
            get { return Fields.AtaxAmtCpd[this]; }
            set { Fields.AtaxAmtCpd[this] = value; }
        }

        [DisplayName("Ldisc Amt Cpd"), Column("LDISC_AMT_CPD"), Size(14), Scale(2)]
        public Decimal? LdiscAmtCpd
        {
            get { return Fields.LdiscAmtCpd[this]; }
            set { Fields.LdiscAmtCpd[this] = value; }
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

        [DisplayName("Posted"), Column("POSTED"), Size(1), NotNull]
        public String Posted
        {
            get { return Fields.Posted[this]; }
            set { Fields.Posted[this] = value; }
        }

        [DisplayName("Log No"), Column("LOG_NO"), Size(8), NotNull]
        public Decimal? LogNo
        {
            get { return Fields.LogNo[this]; }
            set { Fields.LogNo[this] = value; }
        }

        [DisplayName("Received Date"), Column("RECEIVED_DATE"), NotNull]
        public DateTime? ReceivedDate
        {
            get { return Fields.ReceivedDate[this]; }
            set { Fields.ReceivedDate[this] = value; }
        }

        [DisplayName("Vendor No"), Column("VENDOR_NO"), Size(8), NotNull]
        public String VendorNo
        {
            get { return Fields.VendorNo[this]; }
            set { Fields.VendorNo[this] = value; }
        }

        [DisplayName("Ship To"), Column("SHIP_TO"), Size(4), NotNull]
        public String ShipTo
        {
            get { return Fields.ShipTo[this]; }
            set { Fields.ShipTo[this] = value; }
        }

        [DisplayName("Inspected"), Column("INSPECTED"), Size(1), NotNull]
        public String Inspected
        {
            get { return Fields.Inspected[this]; }
            set { Fields.Inspected[this] = value; }
        }

        [DisplayName("Qty Inspected"), Column("QTY_INSPECTED"), Size(14), Scale(4)]
        public Decimal? QtyInspected
        {
            get { return Fields.QtyInspected[this]; }
            set { Fields.QtyInspected[this] = value; }
        }

        [DisplayName("Qty Accepted"), Column("QTY_ACCEPTED"), Size(14), Scale(4)]
        public Decimal? QtyAccepted
        {
            get { return Fields.QtyAccepted[this]; }
            set { Fields.QtyAccepted[this] = value; }
        }

        [DisplayName("Qty Rejected"), Column("QTY_REJECTED"), Size(14), Scale(4)]
        public Decimal? QtyRejected
        {
            get { return Fields.QtyRejected[this]; }
            set { Fields.QtyRejected[this] = value; }
        }

        [DisplayName("Returned"), Column("RETURNED"), Size(1)]
        public String Returned
        {
            get { return Fields.Returned[this]; }
            set { Fields.Returned[this] = value; }
        }

        [DisplayName("Qc Hold"), Column("QC_HOLD"), Size(1)]
        public String QcHold
        {
            get { return Fields.QcHold[this]; }
            set { Fields.QcHold[this] = value; }
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

        [DisplayName("Item Tax Code"), Column("ITEM_TAX_CODE"), Size(6)]
        public String ItemTaxCode
        {
            get { return Fields.ItemTaxCode[this]; }
            set { Fields.ItemTaxCode[this] = value; }
        }

        [DisplayName("Qty Returned"), Column("QTY_RETURNED"), Size(14), Scale(4)]
        public Decimal? QtyReturned
        {
            get { return Fields.QtyReturned[this]; }
            set { Fields.QtyReturned[this] = value; }
        }

        [DisplayName("Ret Price Amt"), Column("RET_PRICE_AMT"), Size(14), Scale(2)]
        public Decimal? RetPriceAmt
        {
            get { return Fields.RetPriceAmt[this]; }
            set { Fields.RetPriceAmt[this] = value; }
        }

        [DisplayName("Ret Ptax Amt"), Column("RET_PTAX_AMT"), Size(14), Scale(2)]
        public Decimal? RetPtaxAmt
        {
            get { return Fields.RetPtaxAmt[this]; }
            set { Fields.RetPtaxAmt[this] = value; }
        }

        [DisplayName("Ret Ext Price"), Column("RET_EXT_PRICE"), Size(14), Scale(2)]
        public Decimal? RetExtPrice
        {
            get { return Fields.RetExtPrice[this]; }
            set { Fields.RetExtPrice[this] = value; }
        }

        [DisplayName("Ret Ldisc Amt"), Column("RET_LDISC_AMT"), Size(14), Scale(2)]
        public Decimal? RetLdiscAmt
        {
            get { return Fields.RetLdiscAmt[this]; }
            set { Fields.RetLdiscAmt[this] = value; }
        }

        [DisplayName("Ret Atax Amt"), Column("RET_ATAX_AMT"), Size(14), Scale(2)]
        public Decimal? RetAtaxAmt
        {
            get { return Fields.RetAtaxAmt[this]; }
            set { Fields.RetAtaxAmt[this] = value; }
        }

        [DisplayName("Ret Item Amt"), Column("RET_ITEM_AMT"), Size(14), Scale(2)]
        public Decimal? RetItemAmt
        {
            get { return Fields.RetItemAmt[this]; }
            set { Fields.RetItemAmt[this] = value; }
        }

        [DisplayName("Lret Price Amt"), Column("LRET_PRICE_AMT"), Size(14), Scale(2)]
        public Decimal? LretPriceAmt
        {
            get { return Fields.LretPriceAmt[this]; }
            set { Fields.LretPriceAmt[this] = value; }
        }

        [DisplayName("Lret Ptax Amt"), Column("LRET_PTAX_AMT"), Size(14), Scale(2)]
        public Decimal? LretPtaxAmt
        {
            get { return Fields.LretPtaxAmt[this]; }
            set { Fields.LretPtaxAmt[this] = value; }
        }

        [DisplayName("Lret Ext Price"), Column("LRET_EXT_PRICE"), Size(14), Scale(2)]
        public Decimal? LretExtPrice
        {
            get { return Fields.LretExtPrice[this]; }
            set { Fields.LretExtPrice[this] = value; }
        }

        [DisplayName("Lret Ldisc Amt"), Column("LRET_LDISC_AMT"), Size(14), Scale(2)]
        public Decimal? LretLdiscAmt
        {
            get { return Fields.LretLdiscAmt[this]; }
            set { Fields.LretLdiscAmt[this] = value; }
        }

        [DisplayName("Lret Atax Amt"), Column("LRET_ATAX_AMT"), Size(14), Scale(2)]
        public Decimal? LretAtaxAmt
        {
            get { return Fields.LretAtaxAmt[this]; }
            set { Fields.LretAtaxAmt[this] = value; }
        }

        [DisplayName("Lret Item Amt"), Column("LRET_ITEM_AMT"), Size(14), Scale(2)]
        public Decimal? LretItemAmt
        {
            get { return Fields.LretItemAmt[this]; }
            set { Fields.LretItemAmt[this] = value; }
        }

        [DisplayName("Cost Accepted"), Column("COST_ACCEPTED"), Size(14), Scale(2)]
        public Decimal? CostAccepted
        {
            get { return Fields.CostAccepted[this]; }
            set { Fields.CostAccepted[this] = value; }
        }

        [DisplayName("Cost Rejected"), Column("COST_REJECTED"), Size(14), Scale(2)]
        public Decimal? CostRejected
        {
            get { return Fields.CostRejected[this]; }
            set { Fields.CostRejected[this] = value; }
        }

        [DisplayName("Cost Returned"), Column("COST_RETURNED"), Size(14), Scale(2)]
        public Decimal? CostReturned
        {
            get { return Fields.CostReturned[this]; }
            set { Fields.CostReturned[this] = value; }
        }

        [DisplayName("Ext Description"), Column("EXT_DESCRIPTION"), Size(1073741823)]
        public String ExtDescription
        {
            get { return Fields.ExtDescription[this]; }
            set { Fields.ExtDescription[this] = value; }
        }

        [DisplayName("Loc"), Column("LOC"), Size(4)]
        public String Loc
        {
            get { return Fields.Loc[this]; }
            set { Fields.Loc[this] = value; }
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

        [DisplayName("Inspect Priority"), Column("INSPECT_PRIORITY"), Size(4), NotNull]
        public Decimal? InspectPriority
        {
            get { return Fields.InspectPriority[this]; }
            set { Fields.InspectPriority[this] = value; }
        }

        [DisplayName("Qc Hold Loc"), Column("QC_HOLD_LOC"), Size(4)]
        public String QcHoldLoc
        {
            get { return Fields.QcHoldLoc[this]; }
            set { Fields.QcHoldLoc[this] = value; }
        }

        [DisplayName("Job No"), Column("JOB_NO"), Size(16)]
        public String JobNo
        {
            get { return Fields.JobNo[this]; }
            set { Fields.JobNo[this] = value; }
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

        [DisplayName("Material Cost"), Column("MATERIAL_COST"), Size(14), Scale(2)]
        public Decimal? MaterialCost
        {
            get { return Fields.MaterialCost[this]; }
            set { Fields.MaterialCost[this] = value; }
        }

        [DisplayName("Vendor Item No"), Column("VENDOR_ITEM_NO"), Size(30)]
        public String VendorItemNo
        {
            get { return Fields.VendorItemNo[this]; }
            set { Fields.VendorItemNo[this] = value; }
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

        public GrnOrderDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField GrnNo;
            public DecimalField EntryNo;
            public StringField OrderNo;
            public DecimalField LineNo;
            public StringField ItemNo;
            public StringField Description;
            public StringField Uom;
            public DecimalField LotSize;
            public DecimalField QtyBalance;
            public DecimalField QtyDue;
            public DecimalField QtyReceived;
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
            public DecimalField AtaxRate;
            public DecimalField LdiscRate;
            public DecimalField AtaxAmtCpd;
            public DecimalField LdiscAmtCpd;
            public DecimalField LocPriceAmt;
            public DecimalField LocPtaxAmt;
            public DecimalField LocExtPrice;
            public DecimalField LocLdiscAmt;
            public DecimalField LocAtaxAmt;
            public DecimalField LocItemAmt;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField Anlys3;
            public StringField Anlys4;
            public StringField Anlys5;
            public StringField Anlys6;
            public StringField Posted;
            public DecimalField LogNo;
            public DateTimeField ReceivedDate;
            public StringField VendorNo;
            public StringField ShipTo;
            public StringField Inspected;
            public DecimalField QtyInspected;
            public DecimalField QtyAccepted;
            public DecimalField QtyRejected;
            public StringField Returned;
            public StringField QcHold;
            public StringField AcctPurchase;
            public StringField AcctLdisc;
            public StringField AcctPtax;
            public StringField AcctAtax;
            public StringField ItemTaxCode;
            public DecimalField QtyReturned;
            public DecimalField RetPriceAmt;
            public DecimalField RetPtaxAmt;
            public DecimalField RetExtPrice;
            public DecimalField RetLdiscAmt;
            public DecimalField RetAtaxAmt;
            public DecimalField RetItemAmt;
            public DecimalField LretPriceAmt;
            public DecimalField LretPtaxAmt;
            public DecimalField LretExtPrice;
            public DecimalField LretLdiscAmt;
            public DecimalField LretAtaxAmt;
            public DecimalField LretItemAmt;
            public DecimalField CostAccepted;
            public DecimalField CostRejected;
            public DecimalField CostReturned;
            public StringField ExtDescription;
            public StringField Loc;
            public DecimalField PutaxPcent;
            public DecimalField PutaxAmt;
            public DecimalField LocPutaxAmt;
            public DecimalField InspectPriority;
            public StringField QcHoldLoc;
            public StringField JobNo;
            public StringField Anlys15;
            public StringField Anlys16;
            public StringField Anlys17;
            public StringField Anlys18;
            public StringField Anlys19;
            public StringField Anlys20;
            public DecimalField MaterialCost;
            public StringField VendorItemNo;

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
                LocalTextPrefix = "Purchasing.GrnOrderDetail";
            }
        }
    }
}
