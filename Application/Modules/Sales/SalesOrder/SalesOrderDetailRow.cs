#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  SalesOrderDetailRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Sales.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Sales"), TableName("[dbo].[SLORDD]")]
    [DisplayName("Sales Order Detail"), InstanceName("Sales Order Detail"), TwoLevelCached]   
    public sealed class SalesOrderDetailRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Order No"), Column("ORDER_NO"), Size(16), PrimaryKey, ForeignKey("[dbo].[SLORDH]", "ORDER_NO"), LeftJoin("jOrderNo"), QuickSearch, TextualField("OrderNoPosted")]
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

        [DisplayName("Commis Type"), Column("COMMIS_TYPE"), Size(6)]
        public String CommisType
        {
            get { return Fields.CommisType[this]; }
            set { Fields.CommisType[this] = value; }
        }

        [DisplayName("Commis Ref No"), Column("COMMIS_REF_NO"), Size(16)]
        public String CommisRefNo
        {
            get { return Fields.CommisRefNo[this]; }
            set { Fields.CommisRefNo[this] = value; }
        }

        [DisplayName("Configurable"), Column("CONFIGURABLE"), Size(1), NotNull]
        public String Configurable
        {
            get { return Fields.Configurable[this]; }
            set { Fields.Configurable[this] = value; }
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

        [DisplayName("Reserved"), Column("RESERVED"), Size(1)]
        public String Reserved
        {
            get { return Fields.Reserved[this]; }
            set { Fields.Reserved[this] = value; }
        }

        [DisplayName("Resv Stub No"), Column("RESV_STUB_NO"), Size(16)]
        public String ResvStubNo
        {
            get { return Fields.ResvStubNo[this]; }
            set { Fields.ResvStubNo[this] = value; }
        }

        [DisplayName("Waitlisted"), Column("WAITLISTED"), Size(1)]
        public String Waitlisted
        {
            get { return Fields.Waitlisted[this]; }
            set { Fields.Waitlisted[this] = value; }
        }

        [DisplayName("Waitlist No"), Column("WAITLIST_NO"), Size(16)]
        public String WaitlistNo
        {
            get { return Fields.WaitlistNo[this]; }
            set { Fields.WaitlistNo[this] = value; }
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

        [DisplayName("Unit Volume"), Column("UNIT_VOLUME"), Size(14), Scale(6)]
        public Decimal? UnitVolume
        {
            get { return Fields.UnitVolume[this]; }
            set { Fields.UnitVolume[this] = value; }
        }

        [DisplayName("Volume"), Column("VOLUME"), Size(14), Scale(6)]
        public Decimal? Volume
        {
            get { return Fields.Volume[this]; }
            set { Fields.Volume[this] = value; }
        }

        [DisplayName("Price Cpd"), Column("PRICE_CPD"), Size(12), Scale(4)]
        public Decimal? PriceCpd
        {
            get { return Fields.PriceCpd[this]; }
            set { Fields.PriceCpd[this] = value; }
        }

        [DisplayName("Ptax Cpd"), Column("PTAX_CPD"), Size(12), Scale(4)]
        public Decimal? PtaxCpd
        {
            get { return Fields.PtaxCpd[this]; }
            set { Fields.PtaxCpd[this] = value; }
        }

        [DisplayName("Atax Cpd"), Column("ATAX_CPD"), Size(12), Scale(4)]
        public Decimal? AtaxCpd
        {
            get { return Fields.AtaxCpd[this]; }
            set { Fields.AtaxCpd[this] = value; }
        }

        [DisplayName("Disc Cpd"), Column("DISC_CPD"), Size(10), Scale(2)]
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

        [DisplayName("Start Ctn No"), Column("START_CTN_NO"), Size(6)]
        public Decimal? StartCtnNo
        {
            get { return Fields.StartCtnNo[this]; }
            set { Fields.StartCtnNo[this] = value; }
        }

        [DisplayName("Qty Shipped"), Column("QTY_SHIPPED"), Size(14), Scale(4)]
        public Decimal? QtyShipped
        {
            get { return Fields.QtyShipped[this]; }
            set { Fields.QtyShipped[this] = value; }
        }

        [DisplayName("Item Tax Code"), Column("ITEM_TAX_CODE"), Size(6)]
        public String ItemTaxCode
        {
            get { return Fields.ItemTaxCode[this]; }
            set { Fields.ItemTaxCode[this] = value; }
        }

        [DisplayName("Cust Item No"), Column("CUST_ITEM_NO"), Size(30)]
        public String CustItemNo
        {
            get { return Fields.CustItemNo[this]; }
            set { Fields.CustItemNo[this] = value; }
        }

        [DisplayName("Spec No"), Column("SPEC_NO"), Size(12)]
        public String SpecNo
        {
            get { return Fields.SpecNo[this]; }
            set { Fields.SpecNo[this] = value; }
        }

        [DisplayName("Bom No"), Column("BOM_NO"), Size(30)]
        public String BomNo
        {
            get { return Fields.BomNo[this]; }
            set { Fields.BomNo[this] = value; }
        }

        [DisplayName("Qty Packed"), Column("QTY_PACKED"), Size(14), Scale(4)]
        public Decimal? QtyPacked
        {
            get { return Fields.QtyPacked[this]; }
            set { Fields.QtyPacked[this] = value; }
        }

        [DisplayName("Job No"), Column("JOB_NO"), Size(16)]
        public String JobNo
        {
            get { return Fields.JobNo[this]; }
            set { Fields.JobNo[this] = value; }
        }

        [DisplayName("Prod Branch"), Column("PROD_BRANCH"), Size(4)]
        public String ProdBranch
        {
            get { return Fields.ProdBranch[this]; }
            set { Fields.ProdBranch[this] = value; }
        }

        [DisplayName("Assembly Line"), Column("ASSEMBLY_LINE"), Size(6)]
        public String AssemblyLine
        {
            get { return Fields.AssemblyLine[this]; }
            set { Fields.AssemblyLine[this] = value; }
        }

        [DisplayName("Prod Due Date"), Column("PROD_DUE_DATE")]
        public DateTime? ProdDueDate
        {
            get { return Fields.ProdDueDate[this]; }
            set { Fields.ProdDueDate[this] = value; }
        }

        [DisplayName("Make It"), Column("MAKE_IT"), Size(1)]
        public String MakeIt
        {
            get { return Fields.MakeIt[this]; }
            set { Fields.MakeIt[this] = value; }
        }

        [DisplayName("Prod Start Date"), Column("PROD_START_DATE")]
        public DateTime? ProdStartDate
        {
            get { return Fields.ProdStartDate[this]; }
            set { Fields.ProdStartDate[this] = value; }
        }

        [DisplayName("Sched Count"), Column("SCHED_COUNT"), Size(4)]
        public Decimal? SchedCount
        {
            get { return Fields.SchedCount[this]; }
            set { Fields.SchedCount[this] = value; }
        }

        [DisplayName("Std Assort"), Column("STD_ASSORT"), Size(1)]
        public String StdAssort
        {
            get { return Fields.StdAssort[this]; }
            set { Fields.StdAssort[this] = value; }
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

        [DisplayName("Vendor No"), Column("VENDOR_NO"), Size(8)]
        public String VendorNo
        {
            get { return Fields.VendorNo[this]; }
            set { Fields.VendorNo[this] = value; }
        }

        [DisplayName("Vendor Price"), Column("VENDOR_PRICE"), Size(18), Scale(6)]
        public Decimal? VendorPrice
        {
            get { return Fields.VendorPrice[this]; }
            set { Fields.VendorPrice[this] = value; }
        }

        [DisplayName("Vendor Pack"), Column("VENDOR_PACK"), Size(15)]
        public String VendorPack
        {
            get { return Fields.VendorPack[this]; }
            set { Fields.VendorPack[this] = value; }
        }

        [DisplayName("Vendor Ccy"), Column("VENDOR_CCY"), Size(4)]
        public String VendorCcy
        {
            get { return Fields.VendorCcy[this]; }
            set { Fields.VendorCcy[this] = value; }
        }

        [DisplayName("Origin Qty"), Column("ORIGIN_QTY"), Size(14), Scale(4)]
        public Decimal? OriginQty
        {
            get { return Fields.OriginQty[this]; }
            set { Fields.OriginQty[this] = value; }
        }

        [DisplayName("Sltax Pcent"), Column("SLTAX_PCENT"), Size(6), Scale(2)]
        public Decimal? SltaxPcent
        {
            get { return Fields.SltaxPcent[this]; }
            set { Fields.SltaxPcent[this] = value; }
        }

        [DisplayName("Sltax Amt"), Column("SLTAX_AMT"), Size(14), Scale(2)]
        public Decimal? SltaxAmt
        {
            get { return Fields.SltaxAmt[this]; }
            set { Fields.SltaxAmt[this] = value; }
        }

        [DisplayName("Reorder Qty"), Column("REORDER_QTY"), Size(14), Scale(4)]
        public Decimal? ReorderQty
        {
            get { return Fields.ReorderQty[this]; }
            set { Fields.ReorderQty[this] = value; }
        }

        [DisplayName("Include Scrap Rate"), Column("INCLUDE_SCRAP_RATE"), Size(1)]
        public String IncludeScrapRate
        {
            get { return Fields.IncludeScrapRate[this]; }
            set { Fields.IncludeScrapRate[this] = value; }
        }

        [DisplayName("Markup Pcent "), Column("MARKUP_PCENT "), Size(6), Scale(2)]
        public Decimal? MarkupPcent
        {
            get { return Fields.MarkupPcent[this]; }
            set { Fields.MarkupPcent[this] = value; }
        }

        [DisplayName("Markup"), Column("MARKUP"), Size(18), Scale(6)]
        public Decimal? Markup
        {
            get { return Fields.Markup[this]; }
            set { Fields.Markup[this] = value; }
        }

        [DisplayName("Item Code"), Column("ITEM_CODE"), Size(14)]
        public String ItemCode
        {
            get { return Fields.ItemCode[this]; }
            set { Fields.ItemCode[this] = value; }
        }

        [DisplayName("Mold Bom No"), Column("MOLD_BOM_NO"), Size(30)]
        public String MoldBomNo
        {
            get { return Fields.MoldBomNo[this]; }
            set { Fields.MoldBomNo[this] = value; }
        }

        [DisplayName("Mold Formula Code"), Column("MOLD_FORMULA_CODE"), Size(30)]
        public String MoldFormulaCode
        {
            get { return Fields.MoldFormulaCode[this]; }
            set { Fields.MoldFormulaCode[this] = value; }
        }

        [DisplayName("Mold Expected Qty"), Column("MOLD_EXPECTED_QTY"), Size(14), Scale(4)]
        public Decimal? MoldExpectedQty
        {
            get { return Fields.MoldExpectedQty[this]; }
            set { Fields.MoldExpectedQty[this] = value; }
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

        [DisplayName("Shipmark Rmk"), Column("SHIPMARK_RMK"), Size(1073741823)]
        public String ShipmarkRmk
        {
            get { return Fields.ShipmarkRmk[this]; }
            set { Fields.ShipmarkRmk[this] = value; }
        }

        [DisplayName("Lot Size Cost"), Column("LOT_SIZE_COST"), Size(18), Scale(6)]
        public Decimal? LotSizeCost
        {
            get { return Fields.LotSizeCost[this]; }
            set { Fields.LotSizeCost[this] = value; }
        }

        [DisplayName("Release Qty"), Column("RELEASE_QTY"), Size(14), Scale(4)]
        public Decimal? ReleaseQty
        {
            get { return Fields.ReleaseQty[this]; }
            set { Fields.ReleaseQty[this] = value; }
        }

        [DisplayName("Blanket Ref"), Column("BLANKET_REF"), Size(16)]
        public String BlanketRef
        {
            get { return Fields.BlanketRef[this]; }
            set { Fields.BlanketRef[this] = value; }
        }

        [DisplayName("Blanket Line No"), Column("BLANKET_LINE_NO"), Size(6)]
        public Decimal? BlanketLineNo
        {
            get { return Fields.BlanketLineNo[this]; }
            set { Fields.BlanketLineNo[this] = value; }
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

        [DisplayName("Order No Customer No"), Expression("jOrderNo.[CUSTOMER_NO]")]
        public String OrderNoCustomerNo
        {
            get { return Fields.OrderNoCustomerNo[this]; }
            set { Fields.OrderNoCustomerNo[this] = value; }
        }

        [DisplayName("Order No Customer Name"), Expression("jOrderNo.[CUSTOMER_NAME]")]
        public String OrderNoCustomerName
        {
            get { return Fields.OrderNoCustomerName[this]; }
            set { Fields.OrderNoCustomerName[this] = value; }
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

        [DisplayName("Order No Customer Po"), Expression("jOrderNo.[CUSTOMER_PO]")]
        public String OrderNoCustomerPo
        {
            get { return Fields.OrderNoCustomerPo[this]; }
            set { Fields.OrderNoCustomerPo[this] = value; }
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

        [DisplayName("Order No Auto Po"), Expression("jOrderNo.[AUTO_PO]")]
        public String OrderNoAutoPo
        {
            get { return Fields.OrderNoAutoPo[this]; }
            set { Fields.OrderNoAutoPo[this] = value; }
        }

        [DisplayName("Order No Auto Job"), Expression("jOrderNo.[AUTO_JOB]")]
        public String OrderNoAutoJob
        {
            get { return Fields.OrderNoAutoJob[this]; }
            set { Fields.OrderNoAutoJob[this] = value; }
        }

        [DisplayName("Order No Compute Tax"), Expression("jOrderNo.[COMPUTE_TAX]")]
        public String OrderNoComputeTax
        {
            get { return Fields.OrderNoComputeTax[this]; }
            set { Fields.OrderNoComputeTax[this] = value; }
        }

        [DisplayName("Order No Auto Resv"), Expression("jOrderNo.[AUTO_RESV]")]
        public String OrderNoAutoResv
        {
            get { return Fields.OrderNoAutoResv[this]; }
            set { Fields.OrderNoAutoResv[this] = value; }
        }

        [DisplayName("Order No Auto Wait"), Expression("jOrderNo.[AUTO_WAIT]")]
        public String OrderNoAutoWait
        {
            get { return Fields.OrderNoAutoWait[this]; }
            set { Fields.OrderNoAutoWait[this] = value; }
        }

        [DisplayName("Order No Vendor No"), Expression("jOrderNo.[VENDOR_NO]")]
        public String OrderNoVendorNo
        {
            get { return Fields.OrderNoVendorNo[this]; }
            set { Fields.OrderNoVendorNo[this] = value; }
        }

        [DisplayName("Order No Po No"), Expression("jOrderNo.[PO_NO]")]
        public String OrderNoPoNo
        {
            get { return Fields.OrderNoPoNo[this]; }
            set { Fields.OrderNoPoNo[this] = value; }
        }

        [DisplayName("Order No Po Pay Terms"), Expression("jOrderNo.[PO_PAY_TERMS]")]
        public String OrderNoPoPayTerms
        {
            get { return Fields.OrderNoPoPayTerms[this]; }
            set { Fields.OrderNoPoPayTerms[this] = value; }
        }

        [DisplayName("Order No Po Ship To"), Expression("jOrderNo.[PO_SHIP_TO]")]
        public String OrderNoPoShipTo
        {
            get { return Fields.OrderNoPoShipTo[this]; }
            set { Fields.OrderNoPoShipTo[this] = value; }
        }

        [DisplayName("Order No Po Buyer"), Expression("jOrderNo.[PO_BUYER]")]
        public String OrderNoPoBuyer
        {
            get { return Fields.OrderNoPoBuyer[this]; }
            set { Fields.OrderNoPoBuyer[this] = value; }
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

        [DisplayName("Order No Salesman"), Expression("jOrderNo.[SALESMAN]")]
        public String OrderNoSalesman
        {
            get { return Fields.OrderNoSalesman[this]; }
            set { Fields.OrderNoSalesman[this] = value; }
        }

        [DisplayName("Order No Pay Terms"), Expression("jOrderNo.[PAY_TERMS]")]
        public String OrderNoPayTerms
        {
            get { return Fields.OrderNoPayTerms[this]; }
            set { Fields.OrderNoPayTerms[this] = value; }
        }

        [DisplayName("Order No Price Code"), Expression("jOrderNo.[PRICE_CODE]")]
        public String OrderNoPriceCode
        {
            get { return Fields.OrderNoPriceCode[this]; }
            set { Fields.OrderNoPriceCode[this] = value; }
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

        [DisplayName("Order No Ship From"), Expression("jOrderNo.[SHIP_FROM]")]
        public String OrderNoShipFrom
        {
            get { return Fields.OrderNoShipFrom[this]; }
            set { Fields.OrderNoShipFrom[this] = value; }
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

        [DisplayName("Order No Last Ctn No"), Expression("jOrderNo.[LAST_CTN_NO]")]
        public Decimal? OrderNoLastCtnNo
        {
            get { return Fields.OrderNoLastCtnNo[this]; }
            set { Fields.OrderNoLastCtnNo[this] = value; }
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

        [DisplayName("Order No Dps Receipt No"), Expression("jOrderNo.[DPS_RECEIPT_NO]")]
        public String OrderNoDpsReceiptNo
        {
            get { return Fields.OrderNoDpsReceiptNo[this]; }
            set { Fields.OrderNoDpsReceiptNo[this] = value; }
        }

        [DisplayName("Order No Dps Fund Code"), Expression("jOrderNo.[DPS_FUND_CODE]")]
        public String OrderNoDpsFundCode
        {
            get { return Fields.OrderNoDpsFundCode[this]; }
            set { Fields.OrderNoDpsFundCode[this] = value; }
        }

        [DisplayName("Order No Dps Reference"), Expression("jOrderNo.[DPS_REFERENCE]")]
        public String OrderNoDpsReference
        {
            get { return Fields.OrderNoDpsReference[this]; }
            set { Fields.OrderNoDpsReference[this] = value; }
        }

        [DisplayName("Order No Dps Rcpt Date"), Expression("jOrderNo.[DPS_RCPT_DATE]")]
        public DateTime? OrderNoDpsRcptDate
        {
            get { return Fields.OrderNoDpsRcptDate[this]; }
            set { Fields.OrderNoDpsRcptDate[this] = value; }
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

        [DisplayName("Order No Prevised Date"), Expression("jOrderNo.[PREVISED_DATE]")]
        public DateTime? OrderNoPrevisedDate
        {
            get { return Fields.OrderNoPrevisedDate[this]; }
            set { Fields.OrderNoPrevisedDate[this] = value; }
        }

        [DisplayName("Order No Prevised By"), Expression("jOrderNo.[PREVISED_BY]")]
        public String OrderNoPrevisedBy
        {
            get { return Fields.OrderNoPrevisedBy[this]; }
            set { Fields.OrderNoPrevisedBy[this] = value; }
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

        [DisplayName("Order No Vend Tax Code"), Expression("jOrderNo.[VEND_TAX_CODE]")]
        public String OrderNoVendTaxCode
        {
            get { return Fields.OrderNoVendTaxCode[this]; }
            set { Fields.OrderNoVendTaxCode[this] = value; }
        }

        [DisplayName("Order No Cust Tax Code"), Expression("jOrderNo.[CUST_TAX_CODE]")]
        public String OrderNoCustTaxCode
        {
            get { return Fields.OrderNoCustTaxCode[this]; }
            set { Fields.OrderNoCustTaxCode[this] = value; }
        }

        [DisplayName("Order No Packing Ok"), Expression("jOrderNo.[PACKING_OK]")]
        public String OrderNoPackingOk
        {
            get { return Fields.OrderNoPackingOk[this]; }
            set { Fields.OrderNoPackingOk[this] = value; }
        }

        [DisplayName("Order No Weight Uom"), Expression("jOrderNo.[WEIGHT_UOM]")]
        public String OrderNoWeightUom
        {
            get { return Fields.OrderNoWeightUom[this]; }
            set { Fields.OrderNoWeightUom[this] = value; }
        }

        [DisplayName("Order No Gr Wt"), Expression("jOrderNo.[GR_WT]")]
        public Decimal? OrderNoGrWt
        {
            get { return Fields.OrderNoGrWt[this]; }
            set { Fields.OrderNoGrWt[this] = value; }
        }

        [DisplayName("Order No Nt Wt"), Expression("jOrderNo.[NT_WT]")]
        public Decimal? OrderNoNtWt
        {
            get { return Fields.OrderNoNtWt[this]; }
            set { Fields.OrderNoNtWt[this] = value; }
        }

        [DisplayName("Order No Dimension Uom"), Expression("jOrderNo.[DIMENSION_UOM]")]
        public String OrderNoDimensionUom
        {
            get { return Fields.OrderNoDimensionUom[this]; }
            set { Fields.OrderNoDimensionUom[this] = value; }
        }

        [DisplayName("Order No Volume"), Expression("jOrderNo.[VOLUME]")]
        public Decimal? OrderNoVolume
        {
            get { return Fields.OrderNoVolume[this]; }
            set { Fields.OrderNoVolume[this] = value; }
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

        [DisplayName("Order No Web Published"), Expression("jOrderNo.[WEB_PUBLISHED]")]
        public String OrderNoWebPublished
        {
            get { return Fields.OrderNoWebPublished[this]; }
            set { Fields.OrderNoWebPublished[this] = value; }
        }

        [DisplayName("Order No Send Web Msg"), Expression("jOrderNo.[SEND_WEB_MSG]")]
        public String OrderNoSendWebMsg
        {
            get { return Fields.OrderNoSendWebMsg[this]; }
            set { Fields.OrderNoSendWebMsg[this] = value; }
        }

        [DisplayName("Order No Web User Name"), Expression("jOrderNo.[WEB_USER_NAME]")]
        public String OrderNoWebUserName
        {
            get { return Fields.OrderNoWebUserName[this]; }
            set { Fields.OrderNoWebUserName[this] = value; }
        }

        [DisplayName("Order No Attention"), Expression("jOrderNo.[ATTENTION]")]
        public String OrderNoAttention
        {
            get { return Fields.OrderNoAttention[this]; }
            set { Fields.OrderNoAttention[this] = value; }
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

        [DisplayName("Order No Mrp Exclude"), Expression("jOrderNo.[MRP_EXCLUDE]")]
        public String OrderNoMrpExclude
        {
            get { return Fields.OrderNoMrpExclude[this]; }
            set { Fields.OrderNoMrpExclude[this] = value; }
        }

        [DisplayName("Order No Sltax Type"), Expression("jOrderNo.[SLTAX_TYPE]")]
        public String OrderNoSltaxType
        {
            get { return Fields.OrderNoSltaxType[this]; }
            set { Fields.OrderNoSltaxType[this] = value; }
        }

        [DisplayName("Order No Gsltax Pcent"), Expression("jOrderNo.[GSLTAX_PCENT]")]
        public Decimal? OrderNoGsltaxPcent
        {
            get { return Fields.OrderNoGsltaxPcent[this]; }
            set { Fields.OrderNoGsltaxPcent[this] = value; }
        }

        [DisplayName("Order No Tot Gsltax Amt"), Expression("jOrderNo.[TOT_GSLTAX_AMT]")]
        public Decimal? OrderNoTotGsltaxAmt
        {
            get { return Fields.OrderNoTotGsltaxAmt[this]; }
            set { Fields.OrderNoTotGsltaxAmt[this] = value; }
        }

        [DisplayName("Order No Tot Lsltax Amt"), Expression("jOrderNo.[TOT_LSLTAX_AMT]")]
        public Decimal? OrderNoTotLsltaxAmt
        {
            get { return Fields.OrderNoTotLsltaxAmt[this]; }
            set { Fields.OrderNoTotLsltaxAmt[this] = value; }
        }

        [DisplayName("Order No Last Text No1"), Expression("jOrderNo.[LAST_TEXT_NO1]")]
        public Decimal? OrderNoLastTextNo1
        {
            get { return Fields.OrderNoLastTextNo1[this]; }
            set { Fields.OrderNoLastTextNo1[this] = value; }
        }

        [DisplayName("Order No Comments5"), Expression("jOrderNo.[COMMENTS5]")]
        public String OrderNoComments5
        {
            get { return Fields.OrderNoComments5[this]; }
            set { Fields.OrderNoComments5[this] = value; }
        }

        [DisplayName("Order No Comments6"), Expression("jOrderNo.[COMMENTS6]")]
        public String OrderNoComments6
        {
            get { return Fields.OrderNoComments6[this]; }
            set { Fields.OrderNoComments6[this] = value; }
        }

        [DisplayName("Order No Comments7"), Expression("jOrderNo.[COMMENTS7]")]
        public String OrderNoComments7
        {
            get { return Fields.OrderNoComments7[this]; }
            set { Fields.OrderNoComments7[this] = value; }
        }

        [DisplayName("Order No Comments8"), Expression("jOrderNo.[COMMENTS8]")]
        public String OrderNoComments8
        {
            get { return Fields.OrderNoComments8[this]; }
            set { Fields.OrderNoComments8[this] = value; }
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

        [DisplayName("Order No Quo Ref No"), Expression("jOrderNo.[QUO_REF_NO]")]
        public String OrderNoQuoRefNo
        {
            get { return Fields.OrderNoQuoRefNo[this]; }
            set { Fields.OrderNoQuoRefNo[this] = value; }
        }

        [DisplayName("Order No Brand Code"), Expression("jOrderNo.[BRAND_CODE]")]
        public String OrderNoBrandCode
        {
            get { return Fields.OrderNoBrandCode[this]; }
            set { Fields.OrderNoBrandCode[this] = value; }
        }

        [DisplayName("Order No Item Code"), Expression("jOrderNo.[ITEM_CODE]")]
        public String OrderNoItemCode
        {
            get { return Fields.OrderNoItemCode[this]; }
            set { Fields.OrderNoItemCode[this] = value; }
        }

        [DisplayName("Order No Pkg Unit"), Expression("jOrderNo.[PKG_UNIT]")]
        public String OrderNoPkgUnit
        {
            get { return Fields.OrderNoPkgUnit[this]; }
            set { Fields.OrderNoPkgUnit[this] = value; }
        }

        [DisplayName("Order No Weight Unit"), Expression("jOrderNo.[WEIGHT_UNIT]")]
        public String OrderNoWeightUnit
        {
            get { return Fields.OrderNoWeightUnit[this]; }
            set { Fields.OrderNoWeightUnit[this] = value; }
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

        [DisplayName("Order No Order Type"), Expression("jOrderNo.[ORDER_TYPE]")]
        public String OrderNoOrderType
        {
            get { return Fields.OrderNoOrderType[this]; }
            set { Fields.OrderNoOrderType[this] = value; }
        }

        [DisplayName("Order No Ref Company Code"), Expression("jOrderNo.[REF_COMPANY_CODE]")]
        public String OrderNoRefCompanyCode
        {
            get { return Fields.OrderNoRefCompanyCode[this]; }
            set { Fields.OrderNoRefCompanyCode[this] = value; }
        }

        [DisplayName("Order No Ref Purchase Order No"), Expression("jOrderNo.[REF_PURCHASE_ORDER_NO]")]
        public String OrderNoRefPurchaseOrderNo
        {
            get { return Fields.OrderNoRefPurchaseOrderNo[this]; }
            set { Fields.OrderNoRefPurchaseOrderNo[this] = value; }
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

        public SalesOrderDetailRow()
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
            public StringField CommisType;
            public StringField CommisRefNo;
            public StringField Configurable;
            public DecimalField FirstShipQty;
            public DecimalField OtherShipQty;
            public DecimalField LastShipNo;
            public StringField Reserved;
            public StringField ResvStubNo;
            public StringField Waitlisted;
            public StringField WaitlistNo;
            public StringField WeightUom;
            public DecimalField GrossWt;
            public DecimalField NetWt;
            public StringField DimensionUom;
            public DecimalField Flength;
            public DecimalField Width;
            public DecimalField Height;
            public DecimalField UnitVolume;
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
            public DecimalField StartCtnNo;
            public DecimalField QtyShipped;
            public StringField ItemTaxCode;
            public StringField CustItemNo;
            public StringField SpecNo;
            public StringField BomNo;
            public DecimalField QtyPacked;
            public StringField JobNo;
            public StringField ProdBranch;
            public StringField AssemblyLine;
            public DateTimeField ProdDueDate;
            public StringField MakeIt;
            public DateTimeField ProdStartDate;
            public DecimalField SchedCount;
            public StringField StdAssort;
            public StringField ExtDescription;
            public DecimalField QtyPending;
            public StringField VendorNo;
            public DecimalField VendorPrice;
            public StringField VendorPack;
            public StringField VendorCcy;
            public DecimalField OriginQty;
            public DecimalField SltaxPcent;
            public DecimalField SltaxAmt;
            public DecimalField ReorderQty;
            public StringField IncludeScrapRate;
            public DecimalField MarkupPcent;
            public DecimalField Markup;
            public StringField ItemCode;
            public StringField MoldBomNo;
            public StringField MoldFormulaCode;
            public DecimalField MoldExpectedQty;
            public StringField Anlys15;
            public StringField Anlys16;
            public StringField Anlys17;
            public StringField Anlys18;
            public StringField Anlys19;
            public StringField Anlys20;
            public StringField ShipmarkRmk;
            public DecimalField LotSizeCost;
            public DecimalField ReleaseQty;
            public StringField BlanketRef;
            public DecimalField BlanketLineNo;

            public DecimalField OrderNoRecnum;
            public StringField OrderNoPosted;
            public StringField OrderNoClosed;
            public StringField OrderNoCustomerNo;
            public StringField OrderNoCustomerName;
            public DateTimeField OrderNoOrderDate;
            public DateTimeField OrderNoDueDate;
            public DateTimeField OrderNoSchedDate;
            public StringField OrderNoCustomerPo;
            public StringField OrderNoShipTo;
            public StringField OrderNoAddress;
            public StringField OrderNoAddress2;
            public StringField OrderNoAddress3;
            public StringField OrderNoAddress4;
            public StringField OrderNoMultiShip;
            public StringField OrderNoAutoPo;
            public StringField OrderNoAutoJob;
            public StringField OrderNoComputeTax;
            public StringField OrderNoAutoResv;
            public StringField OrderNoAutoWait;
            public StringField OrderNoVendorNo;
            public StringField OrderNoPoNo;
            public StringField OrderNoPoPayTerms;
            public StringField OrderNoPoShipTo;
            public StringField OrderNoPoBuyer;
            public StringField OrderNoShipVia;
            public StringField OrderNoShipmentTerms;
            public StringField OrderNoSalesman;
            public StringField OrderNoPayTerms;
            public StringField OrderNoPriceCode;
            public StringField OrderNoAnlys1;
            public StringField OrderNoAnlys2;
            public StringField OrderNoCcy;
            public DecimalField OrderNoExchRate;
            public StringField OrderNoShipFrom;
            public DecimalField OrderNoLastSchedNo;
            public DecimalField OrderNoLastLineNo;
            public DecimalField OrderNoLastTextNo;
            public DecimalField OrderNoLastCtnNo;
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
            public StringField OrderNoDpsReceiptNo;
            public StringField OrderNoDpsFundCode;
            public StringField OrderNoDpsReference;
            public DateTimeField OrderNoDpsRcptDate;
            public DateTimeField OrderNoCreatedDate;
            public StringField OrderNoCreatedBy;
            public DateTimeField OrderNoRevisedDate;
            public StringField OrderNoRevisedBy;
            public DateTimeField OrderNoPostedDate;
            public StringField OrderNoPostedBy;
            public DateTimeField OrderNoPrevisedDate;
            public StringField OrderNoPrevisedBy;
            public StringField OrderNoLockType;
            public StringField OrderNoLockRefNo;
            public DecimalField OrderNoLastLogNo;
            public StringField OrderNoVendTaxCode;
            public StringField OrderNoCustTaxCode;
            public StringField OrderNoPackingOk;
            public StringField OrderNoWeightUom;
            public DecimalField OrderNoGrWt;
            public DecimalField OrderNoNtWt;
            public StringField OrderNoDimensionUom;
            public DecimalField OrderNoVolume;
            public StringField OrderNoOwnerBranch;
            public StringField OrderNoSourceBranch;
            public StringField OrderNoComments1;
            public StringField OrderNoComments2;
            public StringField OrderNoComments3;
            public StringField OrderNoComments4;
            public StringField OrderNoCheckCrlimit;
            public DecimalField OrderNoCheckCrbal;
            public StringField OrderNoWebPublished;
            public StringField OrderNoSendWebMsg;
            public StringField OrderNoWebUserName;
            public StringField OrderNoAttention;
            public StringField OrderNoTelNo;
            public StringField OrderNoFaxNo;
            public StringField OrderNoPortLoading;
            public StringField OrderNoPortDischarge;
            public StringField OrderNoVesselName;
            public StringField OrderNoForwarder;
            public StringField OrderNoLcNo;
            public StringField OrderNoOriginCountry;
            public StringField OrderNoMrpExclude;
            public StringField OrderNoSltaxType;
            public DecimalField OrderNoGsltaxPcent;
            public DecimalField OrderNoTotGsltaxAmt;
            public DecimalField OrderNoTotLsltaxAmt;
            public DecimalField OrderNoLastTextNo1;
            public StringField OrderNoComments5;
            public StringField OrderNoComments6;
            public StringField OrderNoComments7;
            public StringField OrderNoComments8;
            public StringField OrderNoAnlys7;
            public StringField OrderNoAnlys8;
            public StringField OrderNoFlag;
            public StringField OrderNoHoldBy;
            public StringField OrderNoQuoRefNo;
            public StringField OrderNoBrandCode;
            public StringField OrderNoItemCode;
            public StringField OrderNoPkgUnit;
            public StringField OrderNoWeightUnit;
            public StringField OrderNoAnlys9;
            public StringField OrderNoAnlys10;
            public StringField OrderNoAnlys11;
            public StringField OrderNoAnlys12;
            public StringField OrderNoAnlys13;
            public StringField OrderNoAnlys14;
            public StringField OrderNoOrderType;
            public StringField OrderNoRefCompanyCode;
            public StringField OrderNoRefPurchaseOrderNo;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Sales.SalesOrderDetail";
            }
        }
    }
}
