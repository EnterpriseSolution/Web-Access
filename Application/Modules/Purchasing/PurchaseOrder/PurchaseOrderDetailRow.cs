#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PurchaseOrderDetailRow.cs
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

    [ConnectionKey("Purchasing"), TableName("[dbo].[PUORDD]")]
    [DisplayName("Purchase Order Detail"), InstanceName("Purchase Order Detail"), TwoLevelCached]   
    public sealed class PurchaseOrderDetailRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Order No"), Column("ORDER_NO"), Size(16), PrimaryKey, ForeignKey("[dbo].[PUORDH]", "ORDER_NO"), LeftJoin("jOrderNo"), QuickSearch, TextualField("OrderNoPosted")]
        public String OrderNo
        {
            get { return Fields.OrderNo[this]; }
            set { Fields.OrderNo[this] = value; }
        }

        [DisplayName("Line No"), Column("LINE_NO"), Size(6), PrimaryKey]
        public Decimal? LineNo
        {
            get { return Fields.LineNo[this]; }
            set { Fields.LineNo[this] = value; }
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

        [DisplayName("Item No"), Column("ITEM_NO"), Size(30), NotNull]
        public String ItemNo
        {
            get { return Fields.ItemNo[this]; }
            set { Fields.ItemNo[this] = value; }
        }

        [DisplayName("Vendor Item No"), Column("VENDOR_ITEM_NO"), Size(30)]
        public String VendorItemNo
        {
            get { return Fields.VendorItemNo[this]; }
            set { Fields.VendorItemNo[this] = value; }
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

        [DisplayName("Price"), Column("PRICE"), Size(18), Scale(6), NotNull]
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

        [DisplayName("First Ship Qty"), Column("FIRST_SHIP_QTY"), Size(14), Scale(4)]
        public Decimal? FirstShipQty
        {
            get { return Fields.FirstShipQty[this]; }
            set { Fields.FirstShipQty[this] = value; }
        }

        [DisplayName("Other Ship Qty"), Column("OTHER_SHIP_QTY"), Size(14), Scale(4)]
        public Decimal? OtherShipQty
        {
            get { return Fields.OtherShipQty[this]; }
            set { Fields.OtherShipQty[this] = value; }
        }

        [DisplayName("Last Ship No"), Column("LAST_SHIP_NO"), Size(4)]
        public Decimal? LastShipNo
        {
            get { return Fields.LastShipNo[this]; }
            set { Fields.LastShipNo[this] = value; }
        }

        [DisplayName("Weight Uom"), Column("WEIGHT_UOM"), Size(4)]
        public String WeightUom
        {
            get { return Fields.WeightUom[this]; }
            set { Fields.WeightUom[this] = value; }
        }

        [DisplayName("Gross Wt"), Column("GROSS_WT"), Size(10), Scale(4)]
        public Decimal? GrossWt
        {
            get { return Fields.GrossWt[this]; }
            set { Fields.GrossWt[this] = value; }
        }

        [DisplayName("Net Wt"), Column("NET_WT"), Size(12), Scale(4)]
        public Decimal? NetWt
        {
            get { return Fields.NetWt[this]; }
            set { Fields.NetWt[this] = value; }
        }

        [DisplayName("Dimension Uom"), Column("DIMENSION_UOM"), Size(4)]
        public String DimensionUom
        {
            get { return Fields.DimensionUom[this]; }
            set { Fields.DimensionUom[this] = value; }
        }

        [DisplayName("Flength"), Column("FLENGTH"), Size(12), Scale(4)]
        public Decimal? Flength
        {
            get { return Fields.Flength[this]; }
            set { Fields.Flength[this] = value; }
        }

        [DisplayName("Width"), Column("WIDTH"), Size(12), Scale(4)]
        public Decimal? Width
        {
            get { return Fields.Width[this]; }
            set { Fields.Width[this] = value; }
        }

        [DisplayName("Height"), Column("HEIGHT"), Size(12), Scale(4)]
        public Decimal? Height
        {
            get { return Fields.Height[this]; }
            set { Fields.Height[this] = value; }
        }

        [DisplayName("Volume"), Column("VOLUME"), Size(14), Scale(6)]
        public Decimal? Volume
        {
            get { return Fields.Volume[this]; }
            set { Fields.Volume[this] = value; }
        }

        [DisplayName("Price Cpd"), Column("PRICE_CPD"), Size(18), Scale(6)]
        public Decimal? PriceCpd
        {
            get { return Fields.PriceCpd[this]; }
            set { Fields.PriceCpd[this] = value; }
        }

        [DisplayName("Ptax Cpd"), Column("PTAX_CPD"), Size(18), Scale(6)]
        public Decimal? PtaxCpd
        {
            get { return Fields.PtaxCpd[this]; }
            set { Fields.PtaxCpd[this] = value; }
        }

        [DisplayName("Atax Cpd"), Column("ATAX_CPD"), Size(18), Scale(6)]
        public Decimal? AtaxCpd
        {
            get { return Fields.AtaxCpd[this]; }
            set { Fields.AtaxCpd[this] = value; }
        }

        [DisplayName("Disc Cpd"), Column("DISC_CPD"), Size(14), Scale(2)]
        public Decimal? DiscCpd
        {
            get { return Fields.DiscCpd[this]; }
            set { Fields.DiscCpd[this] = value; }
        }

        [DisplayName("Gross Wt Cpd"), Column("GROSS_WT_CPD"), Size(10), Scale(4)]
        public Decimal? GrossWtCpd
        {
            get { return Fields.GrossWtCpd[this]; }
            set { Fields.GrossWtCpd[this] = value; }
        }

        [DisplayName("Net Wt Cpd"), Column("NET_WT_CPD"), Size(10), Scale(4)]
        public Decimal? NetWtCpd
        {
            get { return Fields.NetWtCpd[this]; }
            set { Fields.NetWtCpd[this] = value; }
        }

        [DisplayName("Volume Cpd"), Column("VOLUME_CPD"), Size(14), Scale(6)]
        public Decimal? VolumeCpd
        {
            get { return Fields.VolumeCpd[this]; }
            set { Fields.VolumeCpd[this] = value; }
        }

        [DisplayName("Inner Pkg Type"), Column("INNER_PKG_TYPE"), Size(6)]
        public String InnerPkgType
        {
            get { return Fields.InnerPkgType[this]; }
            set { Fields.InnerPkgType[this] = value; }
        }

        [DisplayName("Inner Qty"), Column("INNER_QTY"), Size(14), Scale(4)]
        public Decimal? InnerQty
        {
            get { return Fields.InnerQty[this]; }
            set { Fields.InnerQty[this] = value; }
        }

        [DisplayName("Inner Pkgs"), Column("INNER_PKGS"), Size(6)]
        public Decimal? InnerPkgs
        {
            get { return Fields.InnerPkgs[this]; }
            set { Fields.InnerPkgs[this] = value; }
        }

        [DisplayName("Inner Excs Qty"), Column("INNER_EXCS_QTY"), Size(14), Scale(4)]
        public Decimal? InnerExcsQty
        {
            get { return Fields.InnerExcsQty[this]; }
            set { Fields.InnerExcsQty[this] = value; }
        }

        [DisplayName("Outer Pkg Type"), Column("OUTER_PKG_TYPE"), Size(6)]
        public String OuterPkgType
        {
            get { return Fields.OuterPkgType[this]; }
            set { Fields.OuterPkgType[this] = value; }
        }

        [DisplayName("Outer Qty"), Column("OUTER_QTY"), Size(14), Scale(4)]
        public Decimal? OuterQty
        {
            get { return Fields.OuterQty[this]; }
            set { Fields.OuterQty[this] = value; }
        }

        [DisplayName("Outer Pkgs"), Column("OUTER_PKGS"), Size(6)]
        public Decimal? OuterPkgs
        {
            get { return Fields.OuterPkgs[this]; }
            set { Fields.OuterPkgs[this] = value; }
        }

        [DisplayName("Outer Excs Qty"), Column("OUTER_EXCS_QTY"), Size(14), Scale(4)]
        public Decimal? OuterExcsQty
        {
            get { return Fields.OuterExcsQty[this]; }
            set { Fields.OuterExcsQty[this] = value; }
        }

        [DisplayName("Qty Received"), Column("QTY_RECEIVED"), Size(14), Scale(4)]
        public Decimal? QtyReceived
        {
            get { return Fields.QtyReceived[this]; }
            set { Fields.QtyReceived[this] = value; }
        }

        [DisplayName("Sched Count"), Column("SCHED_COUNT"), Size(4)]
        public Decimal? SchedCount
        {
            get { return Fields.SchedCount[this]; }
            set { Fields.SchedCount[this] = value; }
        }

        [DisplayName("Ext Description"), Column("EXT_DESCRIPTION"), Size(1073741823)]
        public String ExtDescription
        {
            get { return Fields.ExtDescription[this]; }
            set { Fields.ExtDescription[this] = value; }
        }

        [DisplayName("Qty Pending"), Column("QTY_PENDING"), Size(14), Scale(4)]
        public Decimal? QtyPending
        {
            get { return Fields.QtyPending[this]; }
            set { Fields.QtyPending[this] = value; }
        }

        [DisplayName("Job No"), Column("JOB_NO"), Size(16)]
        public String JobNo
        {
            get { return Fields.JobNo[this]; }
            set { Fields.JobNo[this] = value; }
        }

        [DisplayName("Origin Qty"), Column("ORIGIN_QTY"), Size(14), Scale(4)]
        public Decimal? OriginQty
        {
            get { return Fields.OriginQty[this]; }
            set { Fields.OriginQty[this] = value; }
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

        [DisplayName("Tot Allocated Qty"), Column("TOT_ALLOCATED_QTY"), Size(14), Scale(4)]
        public Decimal? TotAllocatedQty
        {
            get { return Fields.TotAllocatedQty[this]; }
            set { Fields.TotAllocatedQty[this] = value; }
        }

        [DisplayName("Iweight Uom"), Column("IWEIGHT_UOM"), Size(6)]
        public String IweightUom
        {
            get { return Fields.IweightUom[this]; }
            set { Fields.IweightUom[this] = value; }
        }

        [DisplayName("Igross Wt"), Column("IGROSS_WT"), Size(10), Scale(4)]
        public Decimal? IgrossWt
        {
            get { return Fields.IgrossWt[this]; }
            set { Fields.IgrossWt[this] = value; }
        }

        [DisplayName("Inet Wt"), Column("INET_WT"), Size(12), Scale(4)]
        public Decimal? InetWt
        {
            get { return Fields.InetWt[this]; }
            set { Fields.InetWt[this] = value; }
        }

        [DisplayName("Ivolume"), Column("IVOLUME"), Size(14), Scale(6)]
        public Decimal? Ivolume
        {
            get { return Fields.Ivolume[this]; }
            set { Fields.Ivolume[this] = value; }
        }

        [DisplayName("Tot Gross Wt"), Column("TOT_GROSS_WT"), Size(12), Scale(4)]
        public Decimal? TotGrossWt
        {
            get { return Fields.TotGrossWt[this]; }
            set { Fields.TotGrossWt[this] = value; }
        }

        [DisplayName("Tot Net Wt"), Column("TOT_NET_WT"), Size(12), Scale(4)]
        public Decimal? TotNetWt
        {
            get { return Fields.TotNetWt[this]; }
            set { Fields.TotNetWt[this] = value; }
        }

        [DisplayName("Dimension"), Column("DIMENSION"), Size(60)]
        public String Dimension
        {
            get { return Fields.Dimension[this]; }
            set { Fields.Dimension[this] = value; }
        }

        [DisplayName("Reorder Qty"), Column("REORDER_QTY"), Size(14), Scale(4)]
        public Decimal? ReorderQty
        {
            get { return Fields.ReorderQty[this]; }
            set { Fields.ReorderQty[this] = value; }
        }

        [DisplayName("Remark"), Column("REMARK"), Size(60)]
        public String Remark
        {
            get { return Fields.Remark[this]; }
            set { Fields.Remark[this] = value; }
        }

        [DisplayName("Subcon Job"), Column("SUBCON_JOB"), Size(16)]
        public String SubconJob
        {
            get { return Fields.SubconJob[this]; }
            set { Fields.SubconJob[this] = value; }
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

        [DisplayName("Mrp Required Qty"), Column("MRP_REQUIRED_QTY"), Size(14), Scale(4)]
        public Decimal? MrpRequiredQty
        {
            get { return Fields.MrpRequiredQty[this]; }
            set { Fields.MrpRequiredQty[this] = value; }
        }

        [DisplayName("Over Receipt Pcent"), Column("OVER_RECEIPT_PCENT"), Size(5), Scale(2)]
        public Decimal? OverReceiptPcent
        {
            get { return Fields.OverReceiptPcent[this]; }
            set { Fields.OverReceiptPcent[this] = value; }
        }

        [DisplayName("Zero Price"), Column("ZERO_PRICE")]
        public Boolean? ZeroPrice
        {
            get { return Fields.ZeroPrice[this]; }
            set { Fields.ZeroPrice[this] = value; }
        }

        [DisplayName("Order No Recnum"), Expression("jOrderNo.[RECNUM]")]
        public Decimal? OrderNoRecnum
        {
            get { return Fields.OrderNoRecnum[this]; }
            set { Fields.OrderNoRecnum[this] = value; }
        }

        [DisplayName("Order No Posted"), Expression("jOrderNo.[POSTED]")]
        public String OrderNoPosted
        {
            get { return Fields.OrderNoPosted[this]; }
            set { Fields.OrderNoPosted[this] = value; }
        }

        [DisplayName("Order No Closed"), Expression("jOrderNo.[CLOSED]")]
        public String OrderNoClosed
        {
            get { return Fields.OrderNoClosed[this]; }
            set { Fields.OrderNoClosed[this] = value; }
        }

        [DisplayName("Order No Vendor No"), Expression("jOrderNo.[VENDOR_NO]")]
        public String OrderNoVendorNo
        {
            get { return Fields.OrderNoVendorNo[this]; }
            set { Fields.OrderNoVendorNo[this] = value; }
        }

        [DisplayName("Order No Vendor Name"), Expression("jOrderNo.[VENDOR_NAME]")]
        public String OrderNoVendorName
        {
            get { return Fields.OrderNoVendorName[this]; }
            set { Fields.OrderNoVendorName[this] = value; }
        }

        [DisplayName("Order No Vendor Address"), Expression("jOrderNo.[VENDOR_ADDRESS]")]
        public String OrderNoVendorAddress
        {
            get { return Fields.OrderNoVendorAddress[this]; }
            set { Fields.OrderNoVendorAddress[this] = value; }
        }

        [DisplayName("Order No Vendor Address2"), Expression("jOrderNo.[VENDOR_ADDRESS2]")]
        public String OrderNoVendorAddress2
        {
            get { return Fields.OrderNoVendorAddress2[this]; }
            set { Fields.OrderNoVendorAddress2[this] = value; }
        }

        [DisplayName("Order No Vendor Address3"), Expression("jOrderNo.[VENDOR_ADDRESS3]")]
        public String OrderNoVendorAddress3
        {
            get { return Fields.OrderNoVendorAddress3[this]; }
            set { Fields.OrderNoVendorAddress3[this] = value; }
        }

        [DisplayName("Order No Vendor Address4"), Expression("jOrderNo.[VENDOR_ADDRESS4]")]
        public String OrderNoVendorAddress4
        {
            get { return Fields.OrderNoVendorAddress4[this]; }
            set { Fields.OrderNoVendorAddress4[this] = value; }
        }

        [DisplayName("Order No Order Date"), Expression("jOrderNo.[ORDER_DATE]")]
        public DateTime? OrderNoOrderDate
        {
            get { return Fields.OrderNoOrderDate[this]; }
            set { Fields.OrderNoOrderDate[this] = value; }
        }

        [DisplayName("Order No Due Date"), Expression("jOrderNo.[DUE_DATE]")]
        public DateTime? OrderNoDueDate
        {
            get { return Fields.OrderNoDueDate[this]; }
            set { Fields.OrderNoDueDate[this] = value; }
        }

        [DisplayName("Order No Sched Date"), Expression("jOrderNo.[SCHED_DATE]")]
        public DateTime? OrderNoSchedDate
        {
            get { return Fields.OrderNoSchedDate[this]; }
            set { Fields.OrderNoSchedDate[this] = value; }
        }

        [DisplayName("Order No Ship To"), Expression("jOrderNo.[SHIP_TO]")]
        public String OrderNoShipTo
        {
            get { return Fields.OrderNoShipTo[this]; }
            set { Fields.OrderNoShipTo[this] = value; }
        }

        [DisplayName("Order No Address"), Expression("jOrderNo.[ADDRESS]")]
        public String OrderNoAddress
        {
            get { return Fields.OrderNoAddress[this]; }
            set { Fields.OrderNoAddress[this] = value; }
        }

        [DisplayName("Order No Address2"), Expression("jOrderNo.[ADDRESS2]")]
        public String OrderNoAddress2
        {
            get { return Fields.OrderNoAddress2[this]; }
            set { Fields.OrderNoAddress2[this] = value; }
        }

        [DisplayName("Order No Address3"), Expression("jOrderNo.[ADDRESS3]")]
        public String OrderNoAddress3
        {
            get { return Fields.OrderNoAddress3[this]; }
            set { Fields.OrderNoAddress3[this] = value; }
        }

        [DisplayName("Order No Address4"), Expression("jOrderNo.[ADDRESS4]")]
        public String OrderNoAddress4
        {
            get { return Fields.OrderNoAddress4[this]; }
            set { Fields.OrderNoAddress4[this] = value; }
        }

        [DisplayName("Order No Multi Ship"), Expression("jOrderNo.[MULTI_SHIP]")]
        public String OrderNoMultiShip
        {
            get { return Fields.OrderNoMultiShip[this]; }
            set { Fields.OrderNoMultiShip[this] = value; }
        }

        [DisplayName("Order No Compute Tax"), Expression("jOrderNo.[COMPUTE_TAX]")]
        public String OrderNoComputeTax
        {
            get { return Fields.OrderNoComputeTax[this]; }
            set { Fields.OrderNoComputeTax[this] = value; }
        }

        [DisplayName("Order No Ship Via"), Expression("jOrderNo.[SHIP_VIA]")]
        public String OrderNoShipVia
        {
            get { return Fields.OrderNoShipVia[this]; }
            set { Fields.OrderNoShipVia[this] = value; }
        }

        [DisplayName("Order No Shipment Terms"), Expression("jOrderNo.[SHIPMENT_TERMS]")]
        public String OrderNoShipmentTerms
        {
            get { return Fields.OrderNoShipmentTerms[this]; }
            set { Fields.OrderNoShipmentTerms[this] = value; }
        }

        [DisplayName("Order No Buyer"), Expression("jOrderNo.[BUYER]")]
        public String OrderNoBuyer
        {
            get { return Fields.OrderNoBuyer[this]; }
            set { Fields.OrderNoBuyer[this] = value; }
        }

        [DisplayName("Order No Pay Terms"), Expression("jOrderNo.[PAY_TERMS]")]
        public String OrderNoPayTerms
        {
            get { return Fields.OrderNoPayTerms[this]; }
            set { Fields.OrderNoPayTerms[this] = value; }
        }

        [DisplayName("Order No Anlys1"), Expression("jOrderNo.[ANLYS1]")]
        public String OrderNoAnlys1
        {
            get { return Fields.OrderNoAnlys1[this]; }
            set { Fields.OrderNoAnlys1[this] = value; }
        }

        [DisplayName("Order No Anlys2"), Expression("jOrderNo.[ANLYS2]")]
        public String OrderNoAnlys2
        {
            get { return Fields.OrderNoAnlys2[this]; }
            set { Fields.OrderNoAnlys2[this] = value; }
        }

        [DisplayName("Order No Ccy"), Expression("jOrderNo.[CCY]")]
        public String OrderNoCcy
        {
            get { return Fields.OrderNoCcy[this]; }
            set { Fields.OrderNoCcy[this] = value; }
        }

        [DisplayName("Order No Exch Rate"), Expression("jOrderNo.[EXCH_RATE]")]
        public Decimal? OrderNoExchRate
        {
            get { return Fields.OrderNoExchRate[this]; }
            set { Fields.OrderNoExchRate[this] = value; }
        }

        [DisplayName("Order No Source Type"), Expression("jOrderNo.[SOURCE_TYPE]")]
        public String OrderNoSourceType
        {
            get { return Fields.OrderNoSourceType[this]; }
            set { Fields.OrderNoSourceType[this] = value; }
        }

        [DisplayName("Order No Source Ref No"), Expression("jOrderNo.[SOURCE_REF_NO]")]
        public String OrderNoSourceRefNo
        {
            get { return Fields.OrderNoSourceRefNo[this]; }
            set { Fields.OrderNoSourceRefNo[this] = value; }
        }

        [DisplayName("Order No Last Sched No"), Expression("jOrderNo.[LAST_SCHED_NO]")]
        public Decimal? OrderNoLastSchedNo
        {
            get { return Fields.OrderNoLastSchedNo[this]; }
            set { Fields.OrderNoLastSchedNo[this] = value; }
        }

        [DisplayName("Order No Last Line No"), Expression("jOrderNo.[LAST_LINE_NO]")]
        public Decimal? OrderNoLastLineNo
        {
            get { return Fields.OrderNoLastLineNo[this]; }
            set { Fields.OrderNoLastLineNo[this] = value; }
        }

        [DisplayName("Order No Last Text No"), Expression("jOrderNo.[LAST_TEXT_NO]")]
        public Decimal? OrderNoLastTextNo
        {
            get { return Fields.OrderNoLastTextNo[this]; }
            set { Fields.OrderNoLastTextNo[this] = value; }
        }

        [DisplayName("Order No Tot Price Amt"), Expression("jOrderNo.[TOT_PRICE_AMT]")]
        public Decimal? OrderNoTotPriceAmt
        {
            get { return Fields.OrderNoTotPriceAmt[this]; }
            set { Fields.OrderNoTotPriceAmt[this] = value; }
        }

        [DisplayName("Order No Tot Ptax Amt"), Expression("jOrderNo.[TOT_PTAX_AMT]")]
        public Decimal? OrderNoTotPtaxAmt
        {
            get { return Fields.OrderNoTotPtaxAmt[this]; }
            set { Fields.OrderNoTotPtaxAmt[this] = value; }
        }

        [DisplayName("Order No Tot Ext Price"), Expression("jOrderNo.[TOT_EXT_PRICE]")]
        public Decimal? OrderNoTotExtPrice
        {
            get { return Fields.OrderNoTotExtPrice[this]; }
            set { Fields.OrderNoTotExtPrice[this] = value; }
        }

        [DisplayName("Order No Tot Ldisc Amt"), Expression("jOrderNo.[TOT_LDISC_AMT]")]
        public Decimal? OrderNoTotLdiscAmt
        {
            get { return Fields.OrderNoTotLdiscAmt[this]; }
            set { Fields.OrderNoTotLdiscAmt[this] = value; }
        }

        [DisplayName("Order No Tot Atax Amt"), Expression("jOrderNo.[TOT_ATAX_AMT]")]
        public Decimal? OrderNoTotAtaxAmt
        {
            get { return Fields.OrderNoTotAtaxAmt[this]; }
            set { Fields.OrderNoTotAtaxAmt[this] = value; }
        }

        [DisplayName("Order No Tot Item Amt"), Expression("jOrderNo.[TOT_ITEM_AMT]")]
        public Decimal? OrderNoTotItemAmt
        {
            get { return Fields.OrderNoTotItemAmt[this]; }
            set { Fields.OrderNoTotItemAmt[this] = value; }
        }

        [DisplayName("Order No Tdisc Pcent"), Expression("jOrderNo.[TDISC_PCENT]")]
        public Decimal? OrderNoTdiscPcent
        {
            get { return Fields.OrderNoTdiscPcent[this]; }
            set { Fields.OrderNoTdiscPcent[this] = value; }
        }

        [DisplayName("Order No Tot Tdisc Amt"), Expression("jOrderNo.[TOT_TDISC_AMT]")]
        public Decimal? OrderNoTotTdiscAmt
        {
            get { return Fields.OrderNoTotTdiscAmt[this]; }
            set { Fields.OrderNoTotTdiscAmt[this] = value; }
        }

        [DisplayName("Order No Net Trade Amt"), Expression("jOrderNo.[NET_TRADE_AMT]")]
        public Decimal? OrderNoNetTradeAmt
        {
            get { return Fields.OrderNoNetTradeAmt[this]; }
            set { Fields.OrderNoNetTradeAmt[this] = value; }
        }

        [DisplayName("Order No Tot Chgs Amt"), Expression("jOrderNo.[TOT_CHGS_AMT]")]
        public Decimal? OrderNoTotChgsAmt
        {
            get { return Fields.OrderNoTotChgsAmt[this]; }
            set { Fields.OrderNoTotChgsAmt[this] = value; }
        }

        [DisplayName("Order No Net Ordr Amt"), Expression("jOrderNo.[NET_ORDR_AMT]")]
        public Decimal? OrderNoNetOrdrAmt
        {
            get { return Fields.OrderNoNetOrdrAmt[this]; }
            set { Fields.OrderNoNetOrdrAmt[this] = value; }
        }

        [DisplayName("Order No Tot Gtax Amt"), Expression("jOrderNo.[TOT_GTAX_AMT]")]
        public Decimal? OrderNoTotGtaxAmt
        {
            get { return Fields.OrderNoTotGtaxAmt[this]; }
            set { Fields.OrderNoTotGtaxAmt[this] = value; }
        }

        [DisplayName("Order No Net Pay Amt"), Expression("jOrderNo.[NET_PAY_AMT]")]
        public Decimal? OrderNoNetPayAmt
        {
            get { return Fields.OrderNoNetPayAmt[this]; }
            set { Fields.OrderNoNetPayAmt[this] = value; }
        }

        [DisplayName("Order No Dps Pcent"), Expression("jOrderNo.[DPS_PCENT]")]
        public Decimal? OrderNoDpsPcent
        {
            get { return Fields.OrderNoDpsPcent[this]; }
            set { Fields.OrderNoDpsPcent[this] = value; }
        }

        [DisplayName("Order No Tot Dps Amt"), Expression("jOrderNo.[TOT_DPS_AMT]")]
        public Decimal? OrderNoTotDpsAmt
        {
            get { return Fields.OrderNoTotDpsAmt[this]; }
            set { Fields.OrderNoTotDpsAmt[this] = value; }
        }

        [DisplayName("Order No Net Bal Amt"), Expression("jOrderNo.[NET_BAL_AMT]")]
        public Decimal? OrderNoNetBalAmt
        {
            get { return Fields.OrderNoNetBalAmt[this]; }
            set { Fields.OrderNoNetBalAmt[this] = value; }
        }

        [DisplayName("Order No Tot Tdisc Cpd"), Expression("jOrderNo.[TOT_TDISC_CPD]")]
        public Decimal? OrderNoTotTdiscCpd
        {
            get { return Fields.OrderNoTotTdiscCpd[this]; }
            set { Fields.OrderNoTotTdiscCpd[this] = value; }
        }

        [DisplayName("Order No Tot Gtax Cpd"), Expression("jOrderNo.[TOT_GTAX_CPD]")]
        public Decimal? OrderNoTotGtaxCpd
        {
            get { return Fields.OrderNoTotGtaxCpd[this]; }
            set { Fields.OrderNoTotGtaxCpd[this] = value; }
        }

        [DisplayName("Order No Tot Dps Cpd"), Expression("jOrderNo.[TOT_DPS_CPD]")]
        public Decimal? OrderNoTotDpsCpd
        {
            get { return Fields.OrderNoTotDpsCpd[this]; }
            set { Fields.OrderNoTotDpsCpd[this] = value; }
        }

        [DisplayName("Order No Dps Ref No"), Expression("jOrderNo.[DPS_REF_NO]")]
        public String OrderNoDpsRefNo
        {
            get { return Fields.OrderNoDpsRefNo[this]; }
            set { Fields.OrderNoDpsRefNo[this] = value; }
        }

        [DisplayName("Order No Dps Fund Code"), Expression("jOrderNo.[DPS_FUND_CODE]")]
        public String OrderNoDpsFundCode
        {
            get { return Fields.OrderNoDpsFundCode[this]; }
            set { Fields.OrderNoDpsFundCode[this] = value; }
        }

        [DisplayName("Order No Dps Payee"), Expression("jOrderNo.[DPS_PAYEE]")]
        public String OrderNoDpsPayee
        {
            get { return Fields.OrderNoDpsPayee[this]; }
            set { Fields.OrderNoDpsPayee[this] = value; }
        }

        [DisplayName("Order No Dps Cheque No"), Expression("jOrderNo.[DPS_CHEQUE_NO]")]
        public String OrderNoDpsChequeNo
        {
            get { return Fields.OrderNoDpsChequeNo[this]; }
            set { Fields.OrderNoDpsChequeNo[this] = value; }
        }

        [DisplayName("Order No Dps Date"), Expression("jOrderNo.[DPS_DATE]")]
        public DateTime? OrderNoDpsDate
        {
            get { return Fields.OrderNoDpsDate[this]; }
            set { Fields.OrderNoDpsDate[this] = value; }
        }

        [DisplayName("Order No Created Date"), Expression("jOrderNo.[CREATED_DATE]")]
        public DateTime? OrderNoCreatedDate
        {
            get { return Fields.OrderNoCreatedDate[this]; }
            set { Fields.OrderNoCreatedDate[this] = value; }
        }

        [DisplayName("Order No Created By"), Expression("jOrderNo.[CREATED_BY]")]
        public String OrderNoCreatedBy
        {
            get { return Fields.OrderNoCreatedBy[this]; }
            set { Fields.OrderNoCreatedBy[this] = value; }
        }

        [DisplayName("Order No Revised Date"), Expression("jOrderNo.[REVISED_DATE]")]
        public DateTime? OrderNoRevisedDate
        {
            get { return Fields.OrderNoRevisedDate[this]; }
            set { Fields.OrderNoRevisedDate[this] = value; }
        }

        [DisplayName("Order No Revised By"), Expression("jOrderNo.[REVISED_BY]")]
        public String OrderNoRevisedBy
        {
            get { return Fields.OrderNoRevisedBy[this]; }
            set { Fields.OrderNoRevisedBy[this] = value; }
        }

        [DisplayName("Order No Posted Date"), Expression("jOrderNo.[POSTED_DATE]")]
        public DateTime? OrderNoPostedDate
        {
            get { return Fields.OrderNoPostedDate[this]; }
            set { Fields.OrderNoPostedDate[this] = value; }
        }

        [DisplayName("Order No Posted By"), Expression("jOrderNo.[POSTED_BY]")]
        public String OrderNoPostedBy
        {
            get { return Fields.OrderNoPostedBy[this]; }
            set { Fields.OrderNoPostedBy[this] = value; }
        }

        [DisplayName("Order No Lock Type"), Expression("jOrderNo.[LOCK_TYPE]")]
        public String OrderNoLockType
        {
            get { return Fields.OrderNoLockType[this]; }
            set { Fields.OrderNoLockType[this] = value; }
        }

        [DisplayName("Order No Lock Ref No"), Expression("jOrderNo.[LOCK_REF_NO]")]
        public String OrderNoLockRefNo
        {
            get { return Fields.OrderNoLockRefNo[this]; }
            set { Fields.OrderNoLockRefNo[this] = value; }
        }

        [DisplayName("Order No Last Log No"), Expression("jOrderNo.[LAST_LOG_NO]")]
        public Decimal? OrderNoLastLogNo
        {
            get { return Fields.OrderNoLastLogNo[this]; }
            set { Fields.OrderNoLastLogNo[this] = value; }
        }

        [DisplayName("Order No Owner Branch"), Expression("jOrderNo.[OWNER_BRANCH]")]
        public String OrderNoOwnerBranch
        {
            get { return Fields.OrderNoOwnerBranch[this]; }
            set { Fields.OrderNoOwnerBranch[this] = value; }
        }

        [DisplayName("Order No Source Branch"), Expression("jOrderNo.[SOURCE_BRANCH]")]
        public String OrderNoSourceBranch
        {
            get { return Fields.OrderNoSourceBranch[this]; }
            set { Fields.OrderNoSourceBranch[this] = value; }
        }

        [DisplayName("Order No Comments1"), Expression("jOrderNo.[COMMENTS1]")]
        public String OrderNoComments1
        {
            get { return Fields.OrderNoComments1[this]; }
            set { Fields.OrderNoComments1[this] = value; }
        }

        [DisplayName("Order No Comments2"), Expression("jOrderNo.[COMMENTS2]")]
        public String OrderNoComments2
        {
            get { return Fields.OrderNoComments2[this]; }
            set { Fields.OrderNoComments2[this] = value; }
        }

        [DisplayName("Order No Comments3"), Expression("jOrderNo.[COMMENTS3]")]
        public String OrderNoComments3
        {
            get { return Fields.OrderNoComments3[this]; }
            set { Fields.OrderNoComments3[this] = value; }
        }

        [DisplayName("Order No Comments4"), Expression("jOrderNo.[COMMENTS4]")]
        public String OrderNoComments4
        {
            get { return Fields.OrderNoComments4[this]; }
            set { Fields.OrderNoComments4[this] = value; }
        }

        [DisplayName("Order No Server Revised"), Expression("jOrderNo.[SERVER_REVISED]")]
        public String OrderNoServerRevised
        {
            get { return Fields.OrderNoServerRevised[this]; }
            set { Fields.OrderNoServerRevised[this] = value; }
        }

        [DisplayName("Order No Web Amended"), Expression("jOrderNo.[WEB_AMENDED]")]
        public String OrderNoWebAmended
        {
            get { return Fields.OrderNoWebAmended[this]; }
            set { Fields.OrderNoWebAmended[this] = value; }
        }

        [DisplayName("Order No Pub Access"), Expression("jOrderNo.[PUB_ACCESS]")]
        public String OrderNoPubAccess
        {
            get { return Fields.OrderNoPubAccess[this]; }
            set { Fields.OrderNoPubAccess[this] = value; }
        }

        [DisplayName("Order No Confirmed"), Expression("jOrderNo.[CONFIRMED]")]
        public String OrderNoConfirmed
        {
            get { return Fields.OrderNoConfirmed[this]; }
            set { Fields.OrderNoConfirmed[this] = value; }
        }

        [DisplayName("Order No Check Crlimit"), Expression("jOrderNo.[CHECK_CRLIMIT]")]
        public String OrderNoCheckCrlimit
        {
            get { return Fields.OrderNoCheckCrlimit[this]; }
            set { Fields.OrderNoCheckCrlimit[this] = value; }
        }

        [DisplayName("Order No Check Crbal"), Expression("jOrderNo.[CHECK_CRBAL]")]
        public Decimal? OrderNoCheckCrbal
        {
            get { return Fields.OrderNoCheckCrbal[this]; }
            set { Fields.OrderNoCheckCrbal[this] = value; }
        }

        [DisplayName("Order No Job No"), Expression("jOrderNo.[JOB_NO]")]
        public String OrderNoJobNo
        {
            get { return Fields.OrderNoJobNo[this]; }
            set { Fields.OrderNoJobNo[this] = value; }
        }

        [DisplayName("Order No Consign"), Expression("jOrderNo.[CONSIGN]")]
        public String OrderNoConsign
        {
            get { return Fields.OrderNoConsign[this]; }
            set { Fields.OrderNoConsign[this] = value; }
        }

        [DisplayName("Order No Port Loading"), Expression("jOrderNo.[PORT_LOADING]")]
        public String OrderNoPortLoading
        {
            get { return Fields.OrderNoPortLoading[this]; }
            set { Fields.OrderNoPortLoading[this] = value; }
        }

        [DisplayName("Order No Port Discharge"), Expression("jOrderNo.[PORT_DISCHARGE]")]
        public String OrderNoPortDischarge
        {
            get { return Fields.OrderNoPortDischarge[this]; }
            set { Fields.OrderNoPortDischarge[this] = value; }
        }

        [DisplayName("Order No Vessel Name"), Expression("jOrderNo.[VESSEL_NAME]")]
        public String OrderNoVesselName
        {
            get { return Fields.OrderNoVesselName[this]; }
            set { Fields.OrderNoVesselName[this] = value; }
        }

        [DisplayName("Order No Forwarder"), Expression("jOrderNo.[FORWARDER]")]
        public String OrderNoForwarder
        {
            get { return Fields.OrderNoForwarder[this]; }
            set { Fields.OrderNoForwarder[this] = value; }
        }

        [DisplayName("Order No Lc No"), Expression("jOrderNo.[LC_NO]")]
        public String OrderNoLcNo
        {
            get { return Fields.OrderNoLcNo[this]; }
            set { Fields.OrderNoLcNo[this] = value; }
        }

        [DisplayName("Order No Origin Country"), Expression("jOrderNo.[ORIGIN_COUNTRY]")]
        public String OrderNoOriginCountry
        {
            get { return Fields.OrderNoOriginCountry[this]; }
            set { Fields.OrderNoOriginCountry[this] = value; }
        }

        [DisplayName("Order No Putax Type"), Expression("jOrderNo.[PUTAX_TYPE]")]
        public String OrderNoPutaxType
        {
            get { return Fields.OrderNoPutaxType[this]; }
            set { Fields.OrderNoPutaxType[this] = value; }
        }

        [DisplayName("Order No Gputax Pcent"), Expression("jOrderNo.[GPUTAX_PCENT]")]
        public Decimal? OrderNoGputaxPcent
        {
            get { return Fields.OrderNoGputaxPcent[this]; }
            set { Fields.OrderNoGputaxPcent[this] = value; }
        }

        [DisplayName("Order No Tot Gputax Amt"), Expression("jOrderNo.[TOT_GPUTAX_AMT]")]
        public Decimal? OrderNoTotGputaxAmt
        {
            get { return Fields.OrderNoTotGputaxAmt[this]; }
            set { Fields.OrderNoTotGputaxAmt[this] = value; }
        }

        [DisplayName("Order No Tot Lputax Amt"), Expression("jOrderNo.[TOT_LPUTAX_AMT]")]
        public Decimal? OrderNoTotLputaxAmt
        {
            get { return Fields.OrderNoTotLputaxAmt[this]; }
            set { Fields.OrderNoTotLputaxAmt[this] = value; }
        }

        [DisplayName("Order No Anlys7"), Expression("jOrderNo.[ANLYS7]")]
        public String OrderNoAnlys7
        {
            get { return Fields.OrderNoAnlys7[this]; }
            set { Fields.OrderNoAnlys7[this] = value; }
        }

        [DisplayName("Order No Anlys8"), Expression("jOrderNo.[ANLYS8]")]
        public String OrderNoAnlys8
        {
            get { return Fields.OrderNoAnlys8[this]; }
            set { Fields.OrderNoAnlys8[this] = value; }
        }

        [DisplayName("Order No Last Link No"), Expression("jOrderNo.[LAST_LINK_NO]")]
        public Decimal? OrderNoLastLinkNo
        {
            get { return Fields.OrderNoLastLinkNo[this]; }
            set { Fields.OrderNoLastLinkNo[this] = value; }
        }

        [DisplayName("Order No Flag"), Expression("jOrderNo.[FLAG]")]
        public String OrderNoFlag
        {
            get { return Fields.OrderNoFlag[this]; }
            set { Fields.OrderNoFlag[this] = value; }
        }

        [DisplayName("Order No Hold By"), Expression("jOrderNo.[HOLD_BY]")]
        public String OrderNoHoldBy
        {
            get { return Fields.OrderNoHoldBy[this]; }
            set { Fields.OrderNoHoldBy[this] = value; }
        }

        [DisplayName("Order No Subcon Po"), Expression("jOrderNo.[SUBCON_PO]")]
        public String OrderNoSubconPo
        {
            get { return Fields.OrderNoSubconPo[this]; }
            set { Fields.OrderNoSubconPo[this] = value; }
        }

        [DisplayName("Order No Mrp Exclude"), Expression("jOrderNo.[MRP_EXCLUDE]")]
        public String OrderNoMrpExclude
        {
            get { return Fields.OrderNoMrpExclude[this]; }
            set { Fields.OrderNoMrpExclude[this] = value; }
        }

        [DisplayName("Order No From Pr"), Expression("jOrderNo.[FROM_PR]")]
        public String OrderNoFromPr
        {
            get { return Fields.OrderNoFromPr[this]; }
            set { Fields.OrderNoFromPr[this] = value; }
        }

        [DisplayName("Order No Anlys9"), Expression("jOrderNo.[ANLYS9]")]
        public String OrderNoAnlys9
        {
            get { return Fields.OrderNoAnlys9[this]; }
            set { Fields.OrderNoAnlys9[this] = value; }
        }

        [DisplayName("Order No Anlys10"), Expression("jOrderNo.[ANLYS10]")]
        public String OrderNoAnlys10
        {
            get { return Fields.OrderNoAnlys10[this]; }
            set { Fields.OrderNoAnlys10[this] = value; }
        }

        [DisplayName("Order No Anlys11"), Expression("jOrderNo.[ANLYS11]")]
        public String OrderNoAnlys11
        {
            get { return Fields.OrderNoAnlys11[this]; }
            set { Fields.OrderNoAnlys11[this] = value; }
        }

        [DisplayName("Order No Anlys12"), Expression("jOrderNo.[ANLYS12]")]
        public String OrderNoAnlys12
        {
            get { return Fields.OrderNoAnlys12[this]; }
            set { Fields.OrderNoAnlys12[this] = value; }
        }

        [DisplayName("Order No Anlys13"), Expression("jOrderNo.[ANLYS13]")]
        public String OrderNoAnlys13
        {
            get { return Fields.OrderNoAnlys13[this]; }
            set { Fields.OrderNoAnlys13[this] = value; }
        }

        [DisplayName("Order No Anlys14"), Expression("jOrderNo.[ANLYS14]")]
        public String OrderNoAnlys14
        {
            get { return Fields.OrderNoAnlys14[this]; }
            set { Fields.OrderNoAnlys14[this] = value; }
        }

        [DisplayName("Order No Ref Company Code"), Expression("jOrderNo.[REF_COMPANY_CODE]")]
        public String OrderNoRefCompanyCode
        {
            get { return Fields.OrderNoRefCompanyCode[this]; }
            set { Fields.OrderNoRefCompanyCode[this] = value; }
        }

        [DisplayName("Order No Ref Sales Order No"), Expression("jOrderNo.[REF_SALES_ORDER_NO]")]
        public String OrderNoRefSalesOrderNo
        {
            get { return Fields.OrderNoRefSalesOrderNo[this]; }
            set { Fields.OrderNoRefSalesOrderNo[this] = value; }
        }

        [DisplayName("Order No Tax Terms"), Expression("jOrderNo.[TAX_TERMS]")]
        public String OrderNoTaxTerms
        {
            get { return Fields.OrderNoTaxTerms[this]; }
            set { Fields.OrderNoTaxTerms[this] = value; }
        }

        [DisplayName("Order No Custom Terms"), Expression("jOrderNo.[CUSTOM_TERMS]")]
        public String OrderNoCustomTerms
        {
            get { return Fields.OrderNoCustomTerms[this]; }
            set { Fields.OrderNoCustomTerms[this] = value; }
        }

        [DisplayName("Order No Lme Cost"), Expression("jOrderNo.[LME_COST]")]
        public Decimal? OrderNoLmeCost
        {
            get { return Fields.OrderNoLmeCost[this]; }
            set { Fields.OrderNoLmeCost[this] = value; }
        }

        [DisplayName("Order No Lme Ccy"), Expression("jOrderNo.[LME_CCY]")]
        public String OrderNoLmeCcy
        {
            get { return Fields.OrderNoLmeCcy[this]; }
            set { Fields.OrderNoLmeCcy[this] = value; }
        }

        [DisplayName("Order No Lme Exch Rate"), Expression("jOrderNo.[LME_EXCH_RATE]")]
        public Decimal? OrderNoLmeExchRate
        {
            get { return Fields.OrderNoLmeExchRate[this]; }
            set { Fields.OrderNoLmeExchRate[this] = value; }
        }

        [DisplayName("Order No Address Code"), Expression("jOrderNo.[ADDRESS_CODE]")]
        public String OrderNoAddressCode
        {
            get { return Fields.OrderNoAddressCode[this]; }
            set { Fields.OrderNoAddressCode[this] = value; }
        }

        [DisplayName("Order No Contact Person"), Expression("jOrderNo.[CONTACT_PERSON]")]
        public String OrderNoContactPerson
        {
            get { return Fields.OrderNoContactPerson[this]; }
            set { Fields.OrderNoContactPerson[this] = value; }
        }

        [DisplayName("Order No Contact Title"), Expression("jOrderNo.[CONTACT_TITLE]")]
        public String OrderNoContactTitle
        {
            get { return Fields.OrderNoContactTitle[this]; }
            set { Fields.OrderNoContactTitle[this] = value; }
        }

        [DisplayName("Order No Tel No"), Expression("jOrderNo.[TEL_NO]")]
        public String OrderNoTelNo
        {
            get { return Fields.OrderNoTelNo[this]; }
            set { Fields.OrderNoTelNo[this] = value; }
        }

        [DisplayName("Order No Fax No"), Expression("jOrderNo.[FAX_NO]")]
        public String OrderNoFaxNo
        {
            get { return Fields.OrderNoFaxNo[this]; }
            set { Fields.OrderNoFaxNo[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.OrderNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PurchaseOrderDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField OrderNo;
            public DecimalField LineNo;
            public StringField Posted;
            public StringField Closed;
            public StringField ItemNo;
            public StringField VendorItemNo;
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
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField Anlys3;
            public StringField Anlys4;
            public StringField Anlys5;
            public StringField Anlys6;
            public DecimalField FirstShipQty;
            public DecimalField OtherShipQty;
            public DecimalField LastShipNo;
            public StringField WeightUom;
            public DecimalField GrossWt;
            public DecimalField NetWt;
            public StringField DimensionUom;
            public DecimalField Flength;
            public DecimalField Width;
            public DecimalField Height;
            public DecimalField Volume;
            public DecimalField PriceCpd;
            public DecimalField PtaxCpd;
            public DecimalField AtaxCpd;
            public DecimalField DiscCpd;
            public DecimalField GrossWtCpd;
            public DecimalField NetWtCpd;
            public DecimalField VolumeCpd;
            public StringField InnerPkgType;
            public DecimalField InnerQty;
            public DecimalField InnerPkgs;
            public DecimalField InnerExcsQty;
            public StringField OuterPkgType;
            public DecimalField OuterQty;
            public DecimalField OuterPkgs;
            public DecimalField OuterExcsQty;
            public DecimalField QtyReceived;
            public DecimalField SchedCount;
            public StringField ExtDescription;
            public DecimalField QtyPending;
            public StringField JobNo;
            public DecimalField OriginQty;
            public DecimalField PutaxPcent;
            public DecimalField PutaxAmt;
            public DecimalField TotAllocatedQty;
            public StringField IweightUom;
            public DecimalField IgrossWt;
            public DecimalField InetWt;
            public DecimalField Ivolume;
            public DecimalField TotGrossWt;
            public DecimalField TotNetWt;
            public StringField Dimension;
            public DecimalField ReorderQty;
            public StringField Remark;
            public StringField SubconJob;
            public StringField Anlys15;
            public StringField Anlys16;
            public StringField Anlys17;
            public StringField Anlys18;
            public StringField Anlys19;
            public StringField Anlys20;
            public DecimalField MrpRequiredQty;
            public DecimalField OverReceiptPcent;
            public BooleanField ZeroPrice;

            public DecimalField OrderNoRecnum;
            public StringField OrderNoPosted;
            public StringField OrderNoClosed;
            public StringField OrderNoVendorNo;
            public StringField OrderNoVendorName;
            public StringField OrderNoVendorAddress;
            public StringField OrderNoVendorAddress2;
            public StringField OrderNoVendorAddress3;
            public StringField OrderNoVendorAddress4;
            public DateTimeField OrderNoOrderDate;
            public DateTimeField OrderNoDueDate;
            public DateTimeField OrderNoSchedDate;
            public StringField OrderNoShipTo;
            public StringField OrderNoAddress;
            public StringField OrderNoAddress2;
            public StringField OrderNoAddress3;
            public StringField OrderNoAddress4;
            public StringField OrderNoMultiShip;
            public StringField OrderNoComputeTax;
            public StringField OrderNoShipVia;
            public StringField OrderNoShipmentTerms;
            public StringField OrderNoBuyer;
            public StringField OrderNoPayTerms;
            public StringField OrderNoAnlys1;
            public StringField OrderNoAnlys2;
            public StringField OrderNoCcy;
            public DecimalField OrderNoExchRate;
            public StringField OrderNoSourceType;
            public StringField OrderNoSourceRefNo;
            public DecimalField OrderNoLastSchedNo;
            public DecimalField OrderNoLastLineNo;
            public DecimalField OrderNoLastTextNo;
            public DecimalField OrderNoTotPriceAmt;
            public DecimalField OrderNoTotPtaxAmt;
            public DecimalField OrderNoTotExtPrice;
            public DecimalField OrderNoTotLdiscAmt;
            public DecimalField OrderNoTotAtaxAmt;
            public DecimalField OrderNoTotItemAmt;
            public DecimalField OrderNoTdiscPcent;
            public DecimalField OrderNoTotTdiscAmt;
            public DecimalField OrderNoNetTradeAmt;
            public DecimalField OrderNoTotChgsAmt;
            public DecimalField OrderNoNetOrdrAmt;
            public DecimalField OrderNoTotGtaxAmt;
            public DecimalField OrderNoNetPayAmt;
            public DecimalField OrderNoDpsPcent;
            public DecimalField OrderNoTotDpsAmt;
            public DecimalField OrderNoNetBalAmt;
            public DecimalField OrderNoTotTdiscCpd;
            public DecimalField OrderNoTotGtaxCpd;
            public DecimalField OrderNoTotDpsCpd;
            public StringField OrderNoDpsRefNo;
            public StringField OrderNoDpsFundCode;
            public StringField OrderNoDpsPayee;
            public StringField OrderNoDpsChequeNo;
            public DateTimeField OrderNoDpsDate;
            public DateTimeField OrderNoCreatedDate;
            public StringField OrderNoCreatedBy;
            public DateTimeField OrderNoRevisedDate;
            public StringField OrderNoRevisedBy;
            public DateTimeField OrderNoPostedDate;
            public StringField OrderNoPostedBy;
            public StringField OrderNoLockType;
            public StringField OrderNoLockRefNo;
            public DecimalField OrderNoLastLogNo;
            public StringField OrderNoOwnerBranch;
            public StringField OrderNoSourceBranch;
            public StringField OrderNoComments1;
            public StringField OrderNoComments2;
            public StringField OrderNoComments3;
            public StringField OrderNoComments4;
            public StringField OrderNoServerRevised;
            public StringField OrderNoWebAmended;
            public StringField OrderNoPubAccess;
            public StringField OrderNoConfirmed;
            public StringField OrderNoCheckCrlimit;
            public DecimalField OrderNoCheckCrbal;
            public StringField OrderNoJobNo;
            public StringField OrderNoConsign;
            public StringField OrderNoPortLoading;
            public StringField OrderNoPortDischarge;
            public StringField OrderNoVesselName;
            public StringField OrderNoForwarder;
            public StringField OrderNoLcNo;
            public StringField OrderNoOriginCountry;
            public StringField OrderNoPutaxType;
            public DecimalField OrderNoGputaxPcent;
            public DecimalField OrderNoTotGputaxAmt;
            public DecimalField OrderNoTotLputaxAmt;
            public StringField OrderNoAnlys7;
            public StringField OrderNoAnlys8;
            public DecimalField OrderNoLastLinkNo;
            public StringField OrderNoFlag;
            public StringField OrderNoHoldBy;
            public StringField OrderNoSubconPo;
            public StringField OrderNoMrpExclude;
            public StringField OrderNoFromPr;
            public StringField OrderNoAnlys9;
            public StringField OrderNoAnlys10;
            public StringField OrderNoAnlys11;
            public StringField OrderNoAnlys12;
            public StringField OrderNoAnlys13;
            public StringField OrderNoAnlys14;
            public StringField OrderNoRefCompanyCode;
            public StringField OrderNoRefSalesOrderNo;
            public StringField OrderNoTaxTerms;
            public StringField OrderNoCustomTerms;
            public DecimalField OrderNoLmeCost;
            public StringField OrderNoLmeCcy;
            public DecimalField OrderNoLmeExchRate;
            public StringField OrderNoAddressCode;
            public StringField OrderNoContactPerson;
            public StringField OrderNoContactTitle;
            public StringField OrderNoTelNo;
            public StringField OrderNoFaxNo;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Purchasing.PurchaseOrderDetail";
            }
        }
    }
}
