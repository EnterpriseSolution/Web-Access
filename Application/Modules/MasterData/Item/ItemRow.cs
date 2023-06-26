#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ItemRow.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.Modules.Common;

namespace Matrix.MasterData.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("MasterData"), TableName("[dbo].[GBITEM]")]
    [DisplayName("Item"), InstanceName("Item"), TwoLevelCached]   
    [LookupScript("MasterData.ItemRow")]
    //[LookupScript(typeof(Matrix.MasterData.Pages.ItemLookup))]
    public sealed class ItemRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Item No"), Column("ITEM_NO"), Size(30), PrimaryKey, QuickSearch]
        public String ItemNo
        {
            get { return Fields.ItemNo[this]; }
            set { Fields.ItemNo[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(60), NotNull]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1), NotNull]
        [BoolStringConverter]
        public bool? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Item Group"), Column("ITEM_GROUP"), Size(10), NotNull, ForeignKey("[dbo].[GBIGRP]", "ITEM_GROUP"), LeftJoin("jItemGroup"), TextualField("ItemGroupDescription")]
        public String ItemGroup
        {
            get { return Fields.ItemGroup[this]; }
            set { Fields.ItemGroup[this] = value; }
        }

        [DisplayName("Charges"), Column("CHARGES"), Size(1), NotNull]
        public String Charges
        {
            get { return Fields.Charges[this]; }
            set { Fields.Charges[this] = value; }
        }

        [DisplayName("Product"), Column("PRODUCT"), Size(1)]
        [BoolStringConverter]
        public bool? Product
        {
            get { return Fields.Product[this]; }
            set { Fields.Product[this] = value; }
        }

        [DisplayName("Material"), Column("MATERIAL"), Size(1)]
        [BoolStringConverter]
        public bool? Material
        {
            get { return Fields.Material[this]; }
            set { Fields.Material[this] = value; }
        }

        [DisplayName("Inspected"), Column("INSPECTED"), Size(1)]
        public String Inspected
        {
            get { return Fields.Inspected[this]; }
            set { Fields.Inspected[this] = value; }
        }

        [DisplayName("Item Type"), Column("ITEM_TYPE"), Size(3)]
        public String ItemType
        {
            get { return Fields.ItemType[this]; }
            set { Fields.ItemType[this] = value; }
        }

        [DisplayName("Stock Uom"), Column("STOCK_UOM"), Size(4)]
        public String StockUom
        {
            get { return Fields.StockUom[this]; }
            set { Fields.StockUom[this] = value; }
        }

        [DisplayName("Main Loc"), Column("MAIN_LOC"), Size(4)]
        public String MainLoc
        {
            get { return Fields.MainLoc[this]; }
            set { Fields.MainLoc[this] = value; }
        }

        [DisplayName("Make Buy"), Column("MAKE_BUY"), Size(1)]
        [BoolStringConverter]
        public bool? MakeBuy
        {
            get { return Fields.MakeBuy[this]; }
            set { Fields.MakeBuy[this] = value; }
        }

        [DisplayName("Alloc Method"), Column("ALLOC_METHOD"), Size(1)]
        public String AllocMethod
        {
            get { return Fields.AllocMethod[this]; }
            set { Fields.AllocMethod[this] = value; }
        }

        [DisplayName("Std Cost Ok"), Column("STD_COST_OK"), Size(1)]
        public String StdCostOk
        {
            get { return Fields.StdCostOk[this]; }
            set { Fields.StdCostOk[this] = value; }
        }

        [DisplayName("Cost Centre"), Column("COST_CENTRE"), Size(4)]
        public String CostCentre
        {
            get { return Fields.CostCentre[this]; }
            set { Fields.CostCentre[this] = value; }
        }

        [DisplayName("Cycle Code"), Column("CYCLE_CODE"), Size(6), NotNull]
        public String CycleCode
        {
            get { return Fields.CycleCode[this]; }
            set { Fields.CycleCode[this] = value; }
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

        [DisplayName("Def Spec No"), Column("DEF_SPEC_NO"), Size(15)]
        public String DefSpecNo
        {
            get { return Fields.DefSpecNo[this]; }
            set { Fields.DefSpecNo[this] = value; }
        }

        [DisplayName("Def Spec Count"), Column("DEF_SPEC_COUNT"), Size(2)]
        public Decimal? DefSpecCount
        {
            get { return Fields.DefSpecCount[this]; }
            set { Fields.DefSpecCount[this] = value; }
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

        [DisplayName("With Backlog"), Column("WITH_BACKLOG"), Size(1), NotNull]
        public String WithBacklog
        {
            get { return Fields.WithBacklog[this]; }
            set { Fields.WithBacklog[this] = value; }
        }

        [DisplayName("With Balance"), Column("WITH_BALANCE"), Size(1), NotNull]
        public String WithBalance
        {
            get { return Fields.WithBalance[this]; }
            set { Fields.WithBalance[this] = value; }
        }

        [DisplayName("Qty On Hand"), Column("QTY_ON_HAND"), Size(16), Scale(4)]
        public Decimal? QtyOnHand
        {
            get { return Fields.QtyOnHand[this]; }
            set { Fields.QtyOnHand[this] = value; }
        }

        [DisplayName("Qty On Sorder"), Column("QTY_ON_SORDER"), Size(16), Scale(4)]
        public Decimal? QtyOnSorder
        {
            get { return Fields.QtyOnSorder[this]; }
            set { Fields.QtyOnSorder[this] = value; }
        }

        [DisplayName("Qty On Porder"), Column("QTY_ON_PORDER"), Size(16), Scale(4)]
        public Decimal? QtyOnPorder
        {
            get { return Fields.QtyOnPorder[this]; }
            set { Fields.QtyOnPorder[this] = value; }
        }

        [DisplayName("Qty On Jorder"), Column("QTY_ON_JORDER"), Size(16), Scale(4)]
        public Decimal? QtyOnJorder
        {
            get { return Fields.QtyOnJorder[this]; }
            set { Fields.QtyOnJorder[this] = value; }
        }

        [DisplayName("Qty On Inspect"), Column("QTY_ON_INSPECT"), Size(16), Scale(4)]
        public Decimal? QtyOnInspect
        {
            get { return Fields.QtyOnInspect[this]; }
            set { Fields.QtyOnInspect[this] = value; }
        }

        [DisplayName("Qty Waitlisted"), Column("QTY_WAITLISTED"), Size(16), Scale(4)]
        public Decimal? QtyWaitlisted
        {
            get { return Fields.QtyWaitlisted[this]; }
            set { Fields.QtyWaitlisted[this] = value; }
        }

        [DisplayName("Qty Reserved"), Column("QTY_RESERVED"), Size(16), Scale(4)]
        public Decimal? QtyReserved
        {
            get { return Fields.QtyReserved[this]; }
            set { Fields.QtyReserved[this] = value; }
        }

        [DisplayName("Qty Committed"), Column("QTY_COMMITTED"), Size(16), Scale(4)]
        public Decimal? QtyCommitted
        {
            get { return Fields.QtyCommitted[this]; }
            set { Fields.QtyCommitted[this] = value; }
        }

        [DisplayName("Qty Available"), Column("QTY_AVAILABLE"), Size(16), Scale(4)]
        public Decimal? QtyAvailable
        {
            get { return Fields.QtyAvailable[this]; }
            set { Fields.QtyAvailable[this] = value; }
        }

        [DisplayName("Qty Unallocated"), Column("QTY_UNALLOCATED"), Size(16), Scale(4)]
        public Decimal? QtyUnallocated
        {
            get { return Fields.QtyUnallocated[this]; }
            set { Fields.QtyUnallocated[this] = value; }
        }

        [DisplayName("Invt Cost Avail"), Column("INVT_COST_AVAIL"), Size(16), Scale(2)]
        public Decimal? InvtCostAvail
        {
            get { return Fields.InvtCostAvail[this]; }
            set { Fields.InvtCostAvail[this] = value; }
        }

        [DisplayName("Invt Cost Ldg"), Column("INVT_COST_LDG"), Size(16), Scale(2)]
        public Decimal? InvtCostLdg
        {
            get { return Fields.InvtCostLdg[this]; }
            set { Fields.InvtCostLdg[this] = value; }
        }

        [DisplayName("Average Cost"), Column("AVERAGE_COST"), Size(19)]
        [AlignRight]
        public String AverageCost
        {
            get { return Fields.AverageCost[this]; }
            set { Fields.AverageCost[this] = value; }
        }

        [DisplayName("Latest Cost"), Column("LATEST_COST"), Size(18), Scale(6)]
        [DisplayFormat(DecimalUtil.Decimal186)]
        [AlignRight]
        public Decimal? LatestCost
        {
            get { return Fields.LatestCost[this]; }
            set { Fields.LatestCost[this] = value; }
        }

        [DisplayFormat(DecimalUtil.Decimal186)]
        [DisplayName("Std Cost"), Column("STD_COST"), Size(18), Scale(6)]
        [AlignRight]
        public Decimal? StdCost
        {
            get { return Fields.StdCost[this]; }
            set { Fields.StdCost[this] = value; }
        }

        [DisplayName("Last Count Date"), Column("LAST_COUNT_DATE")]
        public DateTime? LastCountDate
        {
            get { return Fields.LastCountDate[this]; }
            set { Fields.LastCountDate[this] = value; }
        }

        [DisplayName("Last Date In"), Column("LAST_DATE_IN")]
        public DateTime? LastDateIn
        {
            get { return Fields.LastDateIn[this]; }
            set { Fields.LastDateIn[this] = value; }
        }

        [DisplayName("Last Date Out"), Column("LAST_DATE_OUT")]
        public DateTime? LastDateOut
        {
            get { return Fields.LastDateOut[this]; }
            set { Fields.LastDateOut[this] = value; }
        }

        [DisplayName("Sales Uom"), Column("SALES_UOM"), Size(4)]
        public String SalesUom
        {
            get { return Fields.SalesUom[this]; }
            set { Fields.SalesUom[this] = value; }
        }

        [DisplayName("Sales Lot Size"), Column("SALES_LOT_SIZE"), Size(10), Scale(4)]
        public Decimal? SalesLotSize
        {
            get { return Fields.SalesLotSize[this]; }
            set { Fields.SalesLotSize[this] = value; }
        }

        [DisplayName("Price Ccy"), Column("PRICE_CCY"), Size(4)]
        public String PriceCcy
        {
            get { return Fields.PriceCcy[this]; }
            set { Fields.PriceCcy[this] = value; }
        }

        [DisplayName("Base Price"), Column("BASE_PRICE"), Size(18), Scale(6)]
        public Decimal? BasePrice
        {
            get { return Fields.BasePrice[this]; }
            set { Fields.BasePrice[this] = value; }
        }

        [DisplayName("Pricea"), Column("PRICEA"), Size(18), Scale(6)]
        public Decimal? Pricea
        {
            get { return Fields.Pricea[this]; }
            set { Fields.Pricea[this] = value; }
        }

        [DisplayName("Priceb"), Column("PRICEB"), Size(18), Scale(6)]
        public Decimal? Priceb
        {
            get { return Fields.Priceb[this]; }
            set { Fields.Priceb[this] = value; }
        }

        [DisplayName("Pricec"), Column("PRICEC"), Size(18), Scale(6)]
        public Decimal? Pricec
        {
            get { return Fields.Pricec[this]; }
            set { Fields.Pricec[this] = value; }
        }

        [DisplayName("Min Price"), Column("MIN_PRICE"), Size(18), Scale(6)]
        public Decimal? MinPrice
        {
            get { return Fields.MinPrice[this]; }
            set { Fields.MinPrice[this] = value; }
        }

        [DisplayName("Max Price"), Column("MAX_PRICE"), Size(18), Scale(6)]
        public Decimal? MaxPrice
        {
            get { return Fields.MaxPrice[this]; }
            set { Fields.MaxPrice[this] = value; }
        }

        [DisplayName("Min Order Qty"), Column("MIN_ORDER_QTY"), Size(12), Scale(4)]
        public Decimal? MinOrderQty
        {
            get { return Fields.MinOrderQty[this]; }
            set { Fields.MinOrderQty[this] = value; }
        }

        [DisplayName("Max Order Qty"), Column("MAX_ORDER_QTY"), Size(12), Scale(4)]
        public Decimal? MaxOrderQty
        {
            get { return Fields.MaxOrderQty[this]; }
            set { Fields.MaxOrderQty[this] = value; }
        }

        [DisplayName("Min Order Days"), Column("MIN_ORDER_DAYS"), Size(4)]
        public Decimal? MinOrderDays
        {
            get { return Fields.MinOrderDays[this]; }
            set { Fields.MinOrderDays[this] = value; }
        }

        [DisplayName("Inner Pkg Type"), Column("INNER_PKG_TYPE"), Size(6)]
        public String InnerPkgType
        {
            get { return Fields.InnerPkgType[this]; }
            set { Fields.InnerPkgType[this] = value; }
        }

        [DisplayName("Inner Qty"), Column("INNER_QTY"), Size(12), Scale(4)]
        public Decimal? InnerQty
        {
            get { return Fields.InnerQty[this]; }
            set { Fields.InnerQty[this] = value; }
        }

        [DisplayName("Outer Pkg Type"), Column("OUTER_PKG_TYPE"), Size(6)]
        public String OuterPkgType
        {
            get { return Fields.OuterPkgType[this]; }
            set { Fields.OuterPkgType[this] = value; }
        }

        [DisplayName("Outer Qty"), Column("OUTER_QTY"), Size(12), Scale(4)]
        public Decimal? OuterQty
        {
            get { return Fields.OuterQty[this]; }
            set { Fields.OuterQty[this] = value; }
        }

        [DisplayName("Article Code"), Column("ARTICLE_CODE"), Size(16)]
        public String ArticleCode
        {
            get { return Fields.ArticleCode[this]; }
            set { Fields.ArticleCode[this] = value; }
        }

        [DisplayName("Quota Category"), Column("QUOTA_CATEGORY"), Size(16)]
        public String QuotaCategory
        {
            get { return Fields.QuotaCategory[this]; }
            set { Fields.QuotaCategory[this] = value; }
        }

        [DisplayName("Weight Uom"), Column("WEIGHT_UOM"), Size(6)]
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

        [DisplayName("Computed Vol"), Column("COMPUTED_VOL"), Size(14), Scale(6)]
        public Decimal? ComputedVol
        {
            get { return Fields.ComputedVol[this]; }
            set { Fields.ComputedVol[this] = value; }
        }

        [DisplayName("Declared Vol"), Column("DECLARED_VOL"), Size(14), Scale(6)]
        public Decimal? DeclaredVol
        {
            get { return Fields.DeclaredVol[this]; }
            set { Fields.DeclaredVol[this] = value; }
        }

        [DisplayName("Srevised Date"), Column("SREVISED_DATE")]
        public DateTime? SrevisedDate
        {
            get { return Fields.SrevisedDate[this]; }
            set { Fields.SrevisedDate[this] = value; }
        }

        [DisplayName("Srevised By"), Column("SREVISED_BY"), Size(10)]
        public String SrevisedBy
        {
            get { return Fields.SrevisedBy[this]; }
            set { Fields.SrevisedBy[this] = value; }
        }

        [DisplayName("Mps Item"), Column("MPS_ITEM"), Size(1), NotNull]
        public String MpsItem
        {
            get { return Fields.MpsItem[this]; }
            set { Fields.MpsItem[this] = value; }
        }

        [DisplayName("Order Policy"), Column("ORDER_POLICY"), Size(4)]
        public String OrderPolicy
        {
            get { return Fields.OrderPolicy[this]; }
            set { Fields.OrderPolicy[this] = value; }
        }

        [DisplayName("Min Planord Qty"), Column("MIN_PLANORD_QTY"), Size(12), Scale(4)]
        public Decimal? MinPlanordQty
        {
            get { return Fields.MinPlanordQty[this]; }
            set { Fields.MinPlanordQty[this] = value; }
        }

        [DisplayName("Max Planord Qty"), Column("MAX_PLANORD_QTY"), Size(12), Scale(4)]
        public Decimal? MaxPlanordQty
        {
            get { return Fields.MaxPlanordQty[this]; }
            set { Fields.MaxPlanordQty[this] = value; }
        }

        [DisplayName("Std Planord Qty"), Column("STD_PLANORD_QTY"), Size(12), Scale(4)]
        public Decimal? StdPlanordQty
        {
            get { return Fields.StdPlanordQty[this]; }
            set { Fields.StdPlanordQty[this] = value; }
        }

        [DisplayName("Min Planord Prd"), Column("MIN_PLANORD_PRD"), Size(4)]
        public Decimal? MinPlanordPrd
        {
            get { return Fields.MinPlanordPrd[this]; }
            set { Fields.MinPlanordPrd[this] = value; }
        }

        [DisplayName("Max Planord Prd"), Column("MAX_PLANORD_PRD"), Size(4)]
        public Decimal? MaxPlanordPrd
        {
            get { return Fields.MaxPlanordPrd[this]; }
            set { Fields.MaxPlanordPrd[this] = value; }
        }

        [DisplayName("Std Planord Prd"), Column("STD_PLANORD_PRD"), Size(4)]
        public Decimal? StdPlanordPrd
        {
            get { return Fields.StdPlanordPrd[this]; }
            set { Fields.StdPlanordPrd[this] = value; }
        }

        [DisplayName("Reorder Pt"), Column("REORDER_PT"), Size(12), Scale(4)]
        public Decimal? ReorderPt
        {
            get { return Fields.ReorderPt[this]; }
            set { Fields.ReorderPt[this] = value; }
        }

        [DisplayName("Reorder Qty"), Column("REORDER_QTY"), Size(12), Scale(4)]
        public Decimal? ReorderQty
        {
            get { return Fields.ReorderQty[this]; }
            set { Fields.ReorderQty[this] = value; }
        }

        [DisplayName("Min Mthly Prod"), Column("MIN_MTHLY_PROD"), Size(12), Scale(4)]
        public Decimal? MinMthlyProd
        {
            get { return Fields.MinMthlyProd[this]; }
            set { Fields.MinMthlyProd[this] = value; }
        }

        [DisplayName("Max Mthly Prod"), Column("MAX_MTHLY_PROD"), Size(12), Scale(4)]
        public Decimal? MaxMthlyProd
        {
            get { return Fields.MaxMthlyProd[this]; }
            set { Fields.MaxMthlyProd[this] = value; }
        }

        [DisplayName("Min Mthly Pur"), Column("MIN_MTHLY_PUR"), Size(12), Scale(4)]
        public Decimal? MinMthlyPur
        {
            get { return Fields.MinMthlyPur[this]; }
            set { Fields.MinMthlyPur[this] = value; }
        }

        [DisplayName("Max Mthly Pur"), Column("MAX_MTHLY_PUR"), Size(12), Scale(4)]
        public Decimal? MaxMthlyPur
        {
            get { return Fields.MaxMthlyPur[this]; }
            set { Fields.MaxMthlyPur[this] = value; }
        }

        [DisplayName("Follow Min Prod"), Column("FOLLOW_MIN_PROD"), Size(1)]
        public String FollowMinProd
        {
            get { return Fields.FollowMinProd[this]; }
            set { Fields.FollowMinProd[this] = value; }
        }

        [DisplayName("Follow Max Prod"), Column("FOLLOW_MAX_PROD"), Size(1)]
        public String FollowMaxProd
        {
            get { return Fields.FollowMaxProd[this]; }
            set { Fields.FollowMaxProd[this] = value; }
        }

        [DisplayName("Follow Min Pur"), Column("FOLLOW_MIN_PUR"), Size(1)]
        public String FollowMinPur
        {
            get { return Fields.FollowMinPur[this]; }
            set { Fields.FollowMinPur[this] = value; }
        }

        [DisplayName("Follow Max Pur"), Column("FOLLOW_MAX_PUR"), Size(1)]
        public String FollowMaxPur
        {
            get { return Fields.FollowMaxPur[this]; }
            set { Fields.FollowMaxPur[this] = value; }
        }

        [DisplayName("Allow Mix Mode"), Column("ALLOW_MIX_MODE"), Size(1)]
        public String AllowMixMode
        {
            get { return Fields.AllowMixMode[this]; }
            set { Fields.AllowMixMode[this] = value; }
        }

        [DisplayName("Pref Vend Only"), Column("PREF_VEND_ONLY"), Size(1)]
        public String PrefVendOnly
        {
            get { return Fields.PrefVendOnly[this]; }
            set { Fields.PrefVendOnly[this] = value; }
        }

        [DisplayName("Pref Vend 1"), Column("PREF_VEND_1"), Size(8)]
        public String PrefVend1
        {
            get { return Fields.PrefVend1[this]; }
            set { Fields.PrefVend1[this] = value; }
        }

        [DisplayName("Pref Vend 2"), Column("PREF_VEND_2"), Size(8)]
        public String PrefVend2
        {
            get { return Fields.PrefVend2[this]; }
            set { Fields.PrefVend2[this] = value; }
        }

        [DisplayName("Prod Lead Time"), Column("PROD_LEAD_TIME"), Size(4)]
        public Decimal? ProdLeadTime
        {
            get { return Fields.ProdLeadTime[this]; }
            set { Fields.ProdLeadTime[this] = value; }
        }

        [DisplayName("Prod Lead Unit"), Column("PROD_LEAD_UNIT"), Size(1)]
        public String ProdLeadUnit
        {
            get { return Fields.ProdLeadUnit[this]; }
            set { Fields.ProdLeadUnit[this] = value; }
        }

        [DisplayName("Pur Lead Time"), Column("PUR_LEAD_TIME"), Size(4)]
        public Decimal? PurLeadTime
        {
            get { return Fields.PurLeadTime[this]; }
            set { Fields.PurLeadTime[this] = value; }
        }

        [DisplayName("Pur Lead Unit"), Column("PUR_LEAD_UNIT"), Size(1)]
        public String PurLeadUnit
        {
            get { return Fields.PurLeadUnit[this]; }
            set { Fields.PurLeadUnit[this] = value; }
        }

        [DisplayName("Planner"), Column("PLANNER"), Size(10)]
        public String Planner
        {
            get { return Fields.Planner[this]; }
            set { Fields.Planner[this] = value; }
        }

        [DisplayName("Mrp Parm Date"), Column("MRP_PARM_DATE")]
        public DateTime? MrpParmDate
        {
            get { return Fields.MrpParmDate[this]; }
            set { Fields.MrpParmDate[this] = value; }
        }

        [DisplayName("Mrp Parm By"), Column("MRP_PARM_BY"), Size(10)]
        public String MrpParmBy
        {
            get { return Fields.MrpParmBy[this]; }
            set { Fields.MrpParmBy[this] = value; }
        }

        [DisplayName("Alt Description"), Column("ALT_DESCRIPTION"), Size(60)]
        public String AltDescription
        {
            get { return Fields.AltDescription[this]; }
            set { Fields.AltDescription[this] = value; }
        }

        [DisplayName("Picture File"), Column("PICTURE_FILE"), Size(255)]
        public String PictureFile
        {
            get { return Fields.PictureFile[this]; }
            set { Fields.PictureFile[this] = value; }
        }

        [DisplayName("Acct Itm Asset"), Column("ACCT_ITM_ASSET"), Size(30)]
        public String AcctItmAsset
        {
            get { return Fields.AcctItmAsset[this]; }
            set { Fields.AcctItmAsset[this] = value; }
        }

        [DisplayName("Acct Itm Wip"), Column("ACCT_ITM_WIP"), Size(30)]
        public String AcctItmWip
        {
            get { return Fields.AcctItmWip[this]; }
            set { Fields.AcctItmWip[this] = value; }
        }

        [DisplayName("Acct Itm Consum"), Column("ACCT_ITM_CONSUM"), Size(30)]
        public String AcctItmConsum
        {
            get { return Fields.AcctItmConsum[this]; }
            set { Fields.AcctItmConsum[this] = value; }
        }

        [DisplayName("Acct Itm Scrap"), Column("ACCT_ITM_SCRAP"), Size(30)]
        public String AcctItmScrap
        {
            get { return Fields.AcctItmScrap[this]; }
            set { Fields.AcctItmScrap[this] = value; }
        }

        [DisplayName("Acct Itm Pvar"), Column("ACCT_ITM_PVAR"), Size(30)]
        public String AcctItmPvar
        {
            get { return Fields.AcctItmPvar[this]; }
            set { Fields.AcctItmPvar[this] = value; }
        }

        [DisplayName("Acct Itm Reval"), Column("ACCT_ITM_REVAL"), Size(30)]
        public String AcctItmReval
        {
            get { return Fields.AcctItmReval[this]; }
            set { Fields.AcctItmReval[this] = value; }
        }

        [DisplayName("Acct Itm Varia"), Column("ACCT_ITM_VARIA"), Size(30)]
        public String AcctItmVaria
        {
            get { return Fields.AcctItmVaria[this]; }
            set { Fields.AcctItmVaria[this] = value; }
        }

        [DisplayName("Acct Itm Sales"), Column("ACCT_ITM_SALES"), Size(30)]
        public String AcctItmSales
        {
            get { return Fields.AcctItmSales[this]; }
            set { Fields.AcctItmSales[this] = value; }
        }

        [DisplayName("Acct Itm Slret"), Column("ACCT_ITM_SLRET"), Size(30)]
        public String AcctItmSlret
        {
            get { return Fields.AcctItmSlret[this]; }
            set { Fields.AcctItmSlret[this] = value; }
        }

        [DisplayName("Acct Itm Sldisc"), Column("ACCT_ITM_SLDISC"), Size(30)]
        public String AcctItmSldisc
        {
            get { return Fields.AcctItmSldisc[this]; }
            set { Fields.AcctItmSldisc[this] = value; }
        }

        [DisplayName("Acct Itm Cogs"), Column("ACCT_ITM_COGS"), Size(30)]
        public String AcctItmCogs
        {
            get { return Fields.AcctItmCogs[this]; }
            set { Fields.AcctItmCogs[this] = value; }
        }

        [DisplayName("Acct Itm Purch"), Column("ACCT_ITM_PURCH"), Size(30)]
        public String AcctItmPurch
        {
            get { return Fields.AcctItmPurch[this]; }
            set { Fields.AcctItmPurch[this] = value; }
        }

        [DisplayName("Acct Itm Puret"), Column("ACCT_ITM_PURET"), Size(30)]
        public String AcctItmPuret
        {
            get { return Fields.AcctItmPuret[this]; }
            set { Fields.AcctItmPuret[this] = value; }
        }

        [DisplayName("Acct Itm Pudisc"), Column("ACCT_ITM_PUDISC"), Size(30)]
        public String AcctItmPudisc
        {
            get { return Fields.AcctItmPudisc[this]; }
            set { Fields.AcctItmPudisc[this] = value; }
        }

        [DisplayName("Acct Itm Putax"), Column("ACCT_ITM_PUTAX"), Size(30)]
        public String AcctItmPutax
        {
            get { return Fields.AcctItmPutax[this]; }
            set { Fields.AcctItmPutax[this] = value; }
        }

        [DisplayName("Acct Machine"), Column("ACCT_MACHINE"), Size(30)]
        public String AcctMachine
        {
            get { return Fields.AcctMachine[this]; }
            set { Fields.AcctMachine[this] = value; }
        }

        [DisplayName("Acct Energy"), Column("ACCT_ENERGY"), Size(30)]
        public String AcctEnergy
        {
            get { return Fields.AcctEnergy[this]; }
            set { Fields.AcctEnergy[this] = value; }
        }

        [DisplayName("Acct Water"), Column("ACCT_WATER"), Size(30)]
        public String AcctWater
        {
            get { return Fields.AcctWater[this]; }
            set { Fields.AcctWater[this] = value; }
        }

        [DisplayName("Acct Rental"), Column("ACCT_RENTAL"), Size(30)]
        public String AcctRental
        {
            get { return Fields.AcctRental[this]; }
            set { Fields.AcctRental[this] = value; }
        }

        [DisplayName("Acct Labor"), Column("ACCT_LABOR"), Size(30)]
        public String AcctLabor
        {
            get { return Fields.AcctLabor[this]; }
            set { Fields.AcctLabor[this] = value; }
        }

        [DisplayName("Acct Inlab"), Column("ACCT_INLAB"), Size(30)]
        public String AcctInlab
        {
            get { return Fields.AcctInlab[this]; }
            set { Fields.AcctInlab[this] = value; }
        }

        [DisplayName("Acct Inmat"), Column("ACCT_INMAT"), Size(30)]
        public String AcctInmat
        {
            get { return Fields.AcctInmat[this]; }
            set { Fields.AcctInmat[this] = value; }
        }

        [DisplayName("Acct Misc"), Column("ACCT_MISC"), Size(30)]
        public String AcctMisc
        {
            get { return Fields.AcctMisc[this]; }
            set { Fields.AcctMisc[this] = value; }
        }

        [DisplayName("Arevised Date"), Column("AREVISED_DATE")]
        public DateTime? ArevisedDate
        {
            get { return Fields.ArevisedDate[this]; }
            set { Fields.ArevisedDate[this] = value; }
        }

        [DisplayName("Arevised By"), Column("AREVISED_BY"), Size(10)]
        public String ArevisedBy
        {
            get { return Fields.ArevisedBy[this]; }
            set { Fields.ArevisedBy[this] = value; }
        }

        [DisplayName("Brevised Date"), Column("BREVISED_DATE")]
        public DateTime? BrevisedDate
        {
            get { return Fields.BrevisedDate[this]; }
            set { Fields.BrevisedDate[this] = value; }
        }

        [DisplayName("Brevised By"), Column("BREVISED_BY"), Size(10)]
        public String BrevisedBy
        {
            get { return Fields.BrevisedBy[this]; }
            set { Fields.BrevisedBy[this] = value; }
        }

        [DisplayName("Sales Ltax Code"), Column("SALES_LTAX_CODE"), Size(6)]
        public String SalesLtaxCode
        {
            get { return Fields.SalesLtaxCode[this]; }
            set { Fields.SalesLtaxCode[this] = value; }
        }

        [DisplayName("Purch Ltax Code"), Column("PURCH_LTAX_CODE"), Size(6)]
        public String PurchLtaxCode
        {
            get { return Fields.PurchLtaxCode[this]; }
            set { Fields.PurchLtaxCode[this] = value; }
        }

        [DisplayName("Trevised Date"), Column("TREVISED_DATE")]
        public DateTime? TrevisedDate
        {
            get { return Fields.TrevisedDate[this]; }
            set { Fields.TrevisedDate[this] = value; }
        }

        [DisplayName("Trevised By"), Column("TREVISED_BY"), Size(10)]
        public String TrevisedBy
        {
            get { return Fields.TrevisedBy[this]; }
            set { Fields.TrevisedBy[this] = value; }
        }

        [DisplayName("Specs Count"), Column("SPECS_COUNT"), Size(8)]
        public Decimal? SpecsCount
        {
            get { return Fields.SpecsCount[this]; }
            set { Fields.SpecsCount[this] = value; }
        }

        [DisplayName("Def Bom No"), Column("DEF_BOM_NO"), Size(30)]
        public String DefBomNo
        {
            get { return Fields.DefBomNo[this]; }
            set { Fields.DefBomNo[this] = value; }
        }

        [DisplayName("Last Snap No"), Column("LAST_SNAP_NO"), Size(8)]
        public Decimal? LastSnapNo
        {
            get { return Fields.LastSnapNo[this]; }
            set { Fields.LastSnapNo[this] = value; }
        }

        [DisplayName("Commis Type"), Column("COMMIS_TYPE"), Size(6)]
        public String CommisType
        {
            get { return Fields.CommisType[this]; }
            set { Fields.CommisType[this] = value; }
        }

        [DisplayName("Prod Branch"), Column("PROD_BRANCH"), Size(4)]
        public String ProdBranch
        {
            get { return Fields.ProdBranch[this]; }
            set { Fields.ProdBranch[this] = value; }
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

        [DisplayName("Scrap Rate"), Column("SCRAP_RATE"), Size(6), Scale(2)]
        public Decimal? ScrapRate
        {
            get { return Fields.ScrapRate[this]; }
            set { Fields.ScrapRate[this] = value; }
        }

        [DisplayName("Alt Ext Desc"), Column("ALT_EXT_DESC"), Size(240)]
        public String AltExtDesc
        {
            get { return Fields.AltExtDesc[this]; }
            set { Fields.AltExtDesc[this] = value; }
        }

        [DisplayName("Extended Desc"), Column("EXTENDED_DESC"), Size(1073741823)]
        public String ExtendedDesc
        {
            get { return Fields.ExtendedDesc[this]; }
            set { Fields.ExtendedDesc[this] = value; }
        }

        [DisplayName("Pur Price Ctrl"), Column("PUR_PRICE_CTRL"), Size(1)]
        public String PurPriceCtrl
        {
            get { return Fields.PurPriceCtrl[this]; }
            set { Fields.PurPriceCtrl[this] = value; }
        }

        [DisplayName("Pur Max Dev"), Column("PUR_MAX_DEV"), Size(8), Scale(2)]
        public Decimal? PurMaxDev
        {
            get { return Fields.PurMaxDev[this]; }
            set { Fields.PurMaxDev[this] = value; }
        }

        [DisplayName("Web Item"), Column("WEB_ITEM"), Size(1)]
        public String WebItem
        {
            get { return Fields.WebItem[this]; }
            set { Fields.WebItem[this] = value; }
        }

        [DisplayName("Acct Itm Subcon"), Column("ACCT_ITM_SUBCON"), Size(30)]
        public String AcctItmSubcon
        {
            get { return Fields.AcctItmSubcon[this]; }
            set { Fields.AcctItmSubcon[this] = value; }
        }

        [DisplayName("With Bin Ctrl"), Column("WITH_BIN_CTRL"), Size(1)]
        public String WithBinCtrl
        {
            get { return Fields.WithBinCtrl[this]; }
            set { Fields.WithBinCtrl[this] = value; }
        }

        [DisplayName("Consign"), Column("CONSIGN"), Size(1)]
        public String Consign
        {
            get { return Fields.Consign[this]; }
            set { Fields.Consign[this] = value; }
        }

        [DisplayName("Prod Devt01"), Column("PROD_DEVT01"), Size(200)]
        public String ProdDevt01
        {
            get { return Fields.ProdDevt01[this]; }
            set { Fields.ProdDevt01[this] = value; }
        }

        [DisplayName("Prod Devt02"), Column("PROD_DEVT02"), Size(200)]
        public String ProdDevt02
        {
            get { return Fields.ProdDevt02[this]; }
            set { Fields.ProdDevt02[this] = value; }
        }

        [DisplayName("Prod Devt03"), Column("PROD_DEVT03"), Size(200)]
        public String ProdDevt03
        {
            get { return Fields.ProdDevt03[this]; }
            set { Fields.ProdDevt03[this] = value; }
        }

        [DisplayName("Prod Devt04"), Column("PROD_DEVT04"), Size(200)]
        public String ProdDevt04
        {
            get { return Fields.ProdDevt04[this]; }
            set { Fields.ProdDevt04[this] = value; }
        }

        [DisplayName("Prod Devt05"), Column("PROD_DEVT05"), Size(200)]
        public String ProdDevt05
        {
            get { return Fields.ProdDevt05[this]; }
            set { Fields.ProdDevt05[this] = value; }
        }

        [DisplayName("Prod Devt06"), Column("PROD_DEVT06"), Size(200)]
        public String ProdDevt06
        {
            get { return Fields.ProdDevt06[this]; }
            set { Fields.ProdDevt06[this] = value; }
        }

        [DisplayName("Prod Devt07"), Column("PROD_DEVT07"), Size(200)]
        public String ProdDevt07
        {
            get { return Fields.ProdDevt07[this]; }
            set { Fields.ProdDevt07[this] = value; }
        }

        [DisplayName("Prod Devt08"), Column("PROD_DEVT08"), Size(200)]
        public String ProdDevt08
        {
            get { return Fields.ProdDevt08[this]; }
            set { Fields.ProdDevt08[this] = value; }
        }

        [DisplayName("Prod Devt09"), Column("PROD_DEVT09"), Size(200)]
        public String ProdDevt09
        {
            get { return Fields.ProdDevt09[this]; }
            set { Fields.ProdDevt09[this] = value; }
        }

        [DisplayName("Prod Devt10"), Column("PROD_DEVT10"), Size(200)]
        public String ProdDevt10
        {
            get { return Fields.ProdDevt10[this]; }
            set { Fields.ProdDevt10[this] = value; }
        }

        [DisplayName("Prod Devt11"), Column("PROD_DEVT11"), Size(200)]
        public String ProdDevt11
        {
            get { return Fields.ProdDevt11[this]; }
            set { Fields.ProdDevt11[this] = value; }
        }

        [DisplayName("Prod Devt12"), Column("PROD_DEVT12"), Size(200)]
        public String ProdDevt12
        {
            get { return Fields.ProdDevt12[this]; }
            set { Fields.ProdDevt12[this] = value; }
        }

        [DisplayName("Prod Devt13"), Column("PROD_DEVT13"), Size(200)]
        public String ProdDevt13
        {
            get { return Fields.ProdDevt13[this]; }
            set { Fields.ProdDevt13[this] = value; }
        }

        [DisplayName("Prod Devt14"), Column("PROD_DEVT14"), Size(200)]
        public String ProdDevt14
        {
            get { return Fields.ProdDevt14[this]; }
            set { Fields.ProdDevt14[this] = value; }
        }

        [DisplayName("Prod Devt15"), Column("PROD_DEVT15"), Size(200)]
        public String ProdDevt15
        {
            get { return Fields.ProdDevt15[this]; }
            set { Fields.ProdDevt15[this] = value; }
        }

        [DisplayName("Prod Devt16"), Column("PROD_DEVT16"), Size(200)]
        public String ProdDevt16
        {
            get { return Fields.ProdDevt16[this]; }
            set { Fields.ProdDevt16[this] = value; }
        }

        [DisplayName("Prod Devt17"), Column("PROD_DEVT17"), Size(200)]
        public String ProdDevt17
        {
            get { return Fields.ProdDevt17[this]; }
            set { Fields.ProdDevt17[this] = value; }
        }

        [DisplayName("Prod Devt18"), Column("PROD_DEVT18"), Size(200)]
        public String ProdDevt18
        {
            get { return Fields.ProdDevt18[this]; }
            set { Fields.ProdDevt18[this] = value; }
        }

        [DisplayName("Prod Devt19"), Column("PROD_DEVT19"), Size(200)]
        public String ProdDevt19
        {
            get { return Fields.ProdDevt19[this]; }
            set { Fields.ProdDevt19[this] = value; }
        }

        [DisplayName("Prod Devt20"), Column("PROD_DEVT20"), Size(200)]
        public String ProdDevt20
        {
            get { return Fields.ProdDevt20[this]; }
            set { Fields.ProdDevt20[this] = value; }
        }

        [DisplayName("Prod Check01"), Column("PROD_CHECK01"), Size(1)]
        public String ProdCheck01
        {
            get { return Fields.ProdCheck01[this]; }
            set { Fields.ProdCheck01[this] = value; }
        }

        [DisplayName("Prod Check02"), Column("PROD_CHECK02"), Size(1)]
        public String ProdCheck02
        {
            get { return Fields.ProdCheck02[this]; }
            set { Fields.ProdCheck02[this] = value; }
        }

        [DisplayName("Prod Check03"), Column("PROD_CHECK03"), Size(1)]
        public String ProdCheck03
        {
            get { return Fields.ProdCheck03[this]; }
            set { Fields.ProdCheck03[this] = value; }
        }

        [DisplayName("Prod Check04"), Column("PROD_CHECK04"), Size(1)]
        public String ProdCheck04
        {
            get { return Fields.ProdCheck04[this]; }
            set { Fields.ProdCheck04[this] = value; }
        }

        [DisplayName("Prod Check05"), Column("PROD_CHECK05"), Size(1)]
        public String ProdCheck05
        {
            get { return Fields.ProdCheck05[this]; }
            set { Fields.ProdCheck05[this] = value; }
        }

        [DisplayName("Prod Check06"), Column("PROD_CHECK06"), Size(1)]
        public String ProdCheck06
        {
            get { return Fields.ProdCheck06[this]; }
            set { Fields.ProdCheck06[this] = value; }
        }

        [DisplayName("Prod Check07"), Column("PROD_CHECK07"), Size(1)]
        public String ProdCheck07
        {
            get { return Fields.ProdCheck07[this]; }
            set { Fields.ProdCheck07[this] = value; }
        }

        [DisplayName("Prod Check08"), Column("PROD_CHECK08"), Size(1)]
        public String ProdCheck08
        {
            get { return Fields.ProdCheck08[this]; }
            set { Fields.ProdCheck08[this] = value; }
        }

        [DisplayName("Prod Check09"), Column("PROD_CHECK09"), Size(1)]
        public String ProdCheck09
        {
            get { return Fields.ProdCheck09[this]; }
            set { Fields.ProdCheck09[this] = value; }
        }

        [DisplayName("Prod Check10"), Column("PROD_CHECK10"), Size(1)]
        public String ProdCheck10
        {
            get { return Fields.ProdCheck10[this]; }
            set { Fields.ProdCheck10[this] = value; }
        }

        [DisplayName("Prod Check11"), Column("PROD_CHECK11"), Size(1)]
        public String ProdCheck11
        {
            get { return Fields.ProdCheck11[this]; }
            set { Fields.ProdCheck11[this] = value; }
        }

        [DisplayName("Prod Check12"), Column("PROD_CHECK12"), Size(1)]
        public String ProdCheck12
        {
            get { return Fields.ProdCheck12[this]; }
            set { Fields.ProdCheck12[this] = value; }
        }

        [DisplayName("Prod Check13"), Column("PROD_CHECK13"), Size(1)]
        public String ProdCheck13
        {
            get { return Fields.ProdCheck13[this]; }
            set { Fields.ProdCheck13[this] = value; }
        }

        [DisplayName("Prod Check14"), Column("PROD_CHECK14"), Size(1)]
        public String ProdCheck14
        {
            get { return Fields.ProdCheck14[this]; }
            set { Fields.ProdCheck14[this] = value; }
        }

        [DisplayName("Prod Check15"), Column("PROD_CHECK15"), Size(1)]
        public String ProdCheck15
        {
            get { return Fields.ProdCheck15[this]; }
            set { Fields.ProdCheck15[this] = value; }
        }

        [DisplayName("Prod Check16"), Column("PROD_CHECK16"), Size(1)]
        public String ProdCheck16
        {
            get { return Fields.ProdCheck16[this]; }
            set { Fields.ProdCheck16[this] = value; }
        }

        [DisplayName("Prod Check17"), Column("PROD_CHECK17"), Size(1)]
        public String ProdCheck17
        {
            get { return Fields.ProdCheck17[this]; }
            set { Fields.ProdCheck17[this] = value; }
        }

        [DisplayName("Prod Check18"), Column("PROD_CHECK18"), Size(1)]
        public String ProdCheck18
        {
            get { return Fields.ProdCheck18[this]; }
            set { Fields.ProdCheck18[this] = value; }
        }

        [DisplayName("Prod Check19"), Column("PROD_CHECK19"), Size(1)]
        public String ProdCheck19
        {
            get { return Fields.ProdCheck19[this]; }
            set { Fields.ProdCheck19[this] = value; }
        }

        [DisplayName("Prod Check20"), Column("PROD_CHECK20"), Size(1)]
        public String ProdCheck20
        {
            get { return Fields.ProdCheck20[this]; }
            set { Fields.ProdCheck20[this] = value; }
        }

        [DisplayName("Last Pack Line No"), Column("LAST_PACK_LINE_NO"), Size(12), Scale(4)]
        public Decimal? LastPackLineNo
        {
            get { return Fields.LastPackLineNo[this]; }
            set { Fields.LastPackLineNo[this] = value; }
        }

        [DisplayName("Putax Pcent"), Column("PUTAX_PCENT"), Size(6), Scale(2)]
        public Decimal? PutaxPcent
        {
            get { return Fields.PutaxPcent[this]; }
            set { Fields.PutaxPcent[this] = value; }
        }

        [DisplayName("Acct Itm Sltax"), Column("ACCT_ITM_SLTAX"), Size(30)]
        public String AcctItmSltax
        {
            get { return Fields.AcctItmSltax[this]; }
            set { Fields.AcctItmSltax[this] = value; }
        }

        [DisplayName("Sltax Pcent"), Column("SLTAX_PCENT"), Size(6), Scale(2)]
        public Decimal? SltaxPcent
        {
            get { return Fields.SltaxPcent[this]; }
            set { Fields.SltaxPcent[this] = value; }
        }

        [DisplayName("Pur Uom"), Column("PUR_UOM"), Size(4)]
        public String PurUom
        {
            get { return Fields.PurUom[this]; }
            set { Fields.PurUom[this] = value; }
        }

        [DisplayName("Pur Lot Size"), Column("PUR_LOT_SIZE"), Size(10), Scale(4)]
        public Decimal? PurLotSize
        {
            get { return Fields.PurLotSize[this]; }
            set { Fields.PurLotSize[this] = value; }
        }

        [DisplayName("Pur Ccy"), Column("PUR_CCY"), Size(4)]
        public String PurCcy
        {
            get { return Fields.PurCcy[this]; }
            set { Fields.PurCcy[this] = value; }
        }

        [DisplayName("Pur Base Price"), Column("PUR_BASE_PRICE"), Size(18), Scale(6)]
        public Decimal? PurBasePrice
        {
            get { return Fields.PurBasePrice[this]; }
            set { Fields.PurBasePrice[this] = value; }
        }

        [DisplayName("Qty Net Available"), Column("QTY_NET_AVAILABLE"), Size(16), Scale(4)]
        public Decimal? QtyNetAvailable
        {
            get { return Fields.QtyNetAvailable[this]; }
            set { Fields.QtyNetAvailable[this] = value; }
        }

        [DisplayName("Use Std Prod Lead Time"), Column("USE_STD_PROD_LEAD_TIME"), Size(1)]
        public String UseStdProdLeadTime
        {
            get { return Fields.UseStdProdLeadTime[this]; }
            set { Fields.UseStdProdLeadTime[this] = value; }
        }

        [DisplayName("Daily Prod Qty"), Column("DAILY_PROD_QTY"), Size(16), Scale(4)]
        public Decimal? DailyProdQty
        {
            get { return Fields.DailyProdQty[this]; }
            set { Fields.DailyProdQty[this] = value; }
        }

        [DisplayName("Issue Lot Size"), Column("ISSUE_LOT_SIZE"), Size(10), Scale(4)]
        public Decimal? IssueLotSize
        {
            get { return Fields.IssueLotSize[this]; }
            set { Fields.IssueLotSize[this] = value; }
        }

        [DisplayName("Mrp Exclude"), Column("MRP_EXCLUDE"), Size(1)]
        public String MrpExclude
        {
            get { return Fields.MrpExclude[this]; }
            set { Fields.MrpExclude[this] = value; }
        }

        [DisplayName("Enable Lot"), Column("ENABLE_LOT"), Size(1), NotNull]
        public String EnableLot
        {
            get { return Fields.EnableLot[this]; }
            set { Fields.EnableLot[this] = value; }
        }

        [DisplayName("Enable Serial"), Column("ENABLE_SERIAL"), Size(1), NotNull]
        public String EnableSerial
        {
            get { return Fields.EnableSerial[this]; }
            set { Fields.EnableSerial[this] = value; }
        }

        [DisplayName("Lot No Length"), Column("LOT_NO_LENGTH"), Size(2)]
        public Decimal? LotNoLength
        {
            get { return Fields.LotNoLength[this]; }
            set { Fields.LotNoLength[this] = value; }
        }

        [DisplayName("Serial No Length"), Column("SERIAL_NO_LENGTH"), Size(2)]
        public Decimal? SerialNoLength
        {
            get { return Fields.SerialNoLength[this]; }
            set { Fields.SerialNoLength[this] = value; }
        }

        [DisplayName("Next Lot No"), Column("NEXT_LOT_NO"), Size(28)]
        public Decimal? NextLotNo
        {
            get { return Fields.NextLotNo[this]; }
            set { Fields.NextLotNo[this] = value; }
        }

        [DisplayName("Next Serial No"), Column("NEXT_SERIAL_NO"), Size(28)]
        public Decimal? NextSerialNo
        {
            get { return Fields.NextSerialNo[this]; }
            set { Fields.NextSerialNo[this] = value; }
        }

        [DisplayName("Max Lot Size"), Column("MAX_LOT_SIZE"), Size(14), Scale(4)]
        public Decimal? MaxLotSize
        {
            get { return Fields.MaxLotSize[this]; }
            set { Fields.MaxLotSize[this] = value; }
        }

        [DisplayName("Lot No Prefix"), Column("LOT_NO_PREFIX"), Size(30)]
        public String LotNoPrefix
        {
            get { return Fields.LotNoPrefix[this]; }
            set { Fields.LotNoPrefix[this] = value; }
        }

        [DisplayName("Serial No Prefix"), Column("SERIAL_NO_PREFIX"), Size(40)]
        public String SerialNoPrefix
        {
            get { return Fields.SerialNoPrefix[this]; }
            set { Fields.SerialNoPrefix[this] = value; }
        }

        [DisplayName("Safe Stock Lvl"), Column("SAFE_STOCK_LVL"), Size(16), Scale(4)]
        public Decimal? SafeStockLvl
        {
            get { return Fields.SafeStockLvl[this]; }
            set { Fields.SafeStockLvl[this] = value; }
        }

        [DisplayName("Main Bin"), Column("MAIN_BIN"), Size(30)]
        public String MainBin
        {
            get { return Fields.MainBin[this]; }
            set { Fields.MainBin[this] = value; }
        }

        [DisplayName("Custom Prod Code"), Column("CUSTOM_PROD_CODE"), Size(30)]
        public String CustomProdCode
        {
            get { return Fields.CustomProdCode[this]; }
            set { Fields.CustomProdCode[this] = value; }
        }

        [DisplayName("Custom Lot Size"), Column("CUSTOM_LOT_SIZE"), Size(13), Scale(4)]
        public Decimal? CustomLotSize
        {
            get { return Fields.CustomLotSize[this]; }
            set { Fields.CustomLotSize[this] = value; }
        }

        [DisplayName("Custom Gr Uom"), Column("CUSTOM_GR_UOM"), Size(16)]
        public String CustomGrUom
        {
            get { return Fields.CustomGrUom[this]; }
            set { Fields.CustomGrUom[this] = value; }
        }

        [DisplayName("Custom Gr Wt"), Column("CUSTOM_GR_WT"), Size(13), Scale(4)]
        public Decimal? CustomGrWt
        {
            get { return Fields.CustomGrWt[this]; }
            set { Fields.CustomGrWt[this] = value; }
        }

        [DisplayName("Custom Nt Wt"), Column("CUSTOM_NT_WT"), Size(13), Scale(4)]
        public Decimal? CustomNtWt
        {
            get { return Fields.CustomNtWt[this]; }
            set { Fields.CustomNtWt[this] = value; }
        }

        [DisplayName("Custom Origin"), Column("CUSTOM_ORIGIN"), Size(16)]
        public String CustomOrigin
        {
            get { return Fields.CustomOrigin[this]; }
            set { Fields.CustomOrigin[this] = value; }
        }

        [DisplayName("Is Approved"), Column("IS_APPROVED"), Size(1)]
        public String IsApproved
        {
            get { return Fields.IsApproved[this]; }
            set { Fields.IsApproved[this] = value; }
        }

        [DisplayName("Approved By"), Column("APPROVED_BY"), Size(20)]
        public String ApprovedBy
        {
            get { return Fields.ApprovedBy[this]; }
            set { Fields.ApprovedBy[this] = value; }
        }

        [DisplayName("Preapprove"), Column("PREAPPROVE"), Size(1)]
        public String Preapprove
        {
            get { return Fields.Preapprove[this]; }
            set { Fields.Preapprove[this] = value; }
        }

        [DisplayName("Approved Date"), Column("APPROVED_DATE")]
        public DateTime? ApprovedDate
        {
            get { return Fields.ApprovedDate[this]; }
            set { Fields.ApprovedDate[this] = value; }
        }

        [DisplayName("Qty On Transfer"), Column("QTY_ON_TRANSFER"), Size(16), Scale(4)]
        public Decimal? QtyOnTransfer
        {
            get { return Fields.QtyOnTransfer[this]; }
            set { Fields.QtyOnTransfer[this] = value; }
        }

        [DisplayName("With Reset Lot"), Column("WITH_RESET_LOT"), Size(1)]
        public String WithResetLot
        {
            get { return Fields.WithResetLot[this]; }
            set { Fields.WithResetLot[this] = value; }
        }

        [DisplayName("With Reset Serial"), Column("WITH_RESET_SERIAL"), Size(1)]
        public String WithResetSerial
        {
            get { return Fields.WithResetSerial[this]; }
            set { Fields.WithResetSerial[this] = value; }
        }

        [DisplayName("Prev Reset Lot Date"), Column("PREV_RESET_LOT_DATE")]
        public DateTime? PrevResetLotDate
        {
            get { return Fields.PrevResetLotDate[this]; }
            set { Fields.PrevResetLotDate[this] = value; }
        }

        [DisplayName("Prev Reset Serial Date"), Column("PREV_RESET_SERIAL_DATE")]
        public DateTime? PrevResetSerialDate
        {
            get { return Fields.PrevResetSerialDate[this]; }
            set { Fields.PrevResetSerialDate[this] = value; }
        }

        [DisplayName("Autogen Lot"), Column("AUTOGEN_LOT"), Size(1)]
        public String AutogenLot
        {
            get { return Fields.AutogenLot[this]; }
            set { Fields.AutogenLot[this] = value; }
        }

        [DisplayName("Autogen Serial"), Column("AUTOGEN_SERIAL"), Size(1)]
        public String AutogenSerial
        {
            get { return Fields.AutogenSerial[this]; }
            set { Fields.AutogenSerial[this] = value; }
        }

        [DisplayName("Fab Item"), Column("FAB_ITEM"), Size(1)]
        public String FabItem
        {
            get { return Fields.FabItem[this]; }
            set { Fields.FabItem[this] = value; }
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

        [DisplayName("User Defined Field 1"), Column("USER_DEFINED_FIELD_1"), Size(100)]
        public String UserDefinedField1
        {
            get { return Fields.UserDefinedField1[this]; }
            set { Fields.UserDefinedField1[this] = value; }
        }

        [DisplayName("User Defined Field 2"), Column("USER_DEFINED_FIELD_2"), Size(100)]
        public String UserDefinedField2
        {
            get { return Fields.UserDefinedField2[this]; }
            set { Fields.UserDefinedField2[this] = value; }
        }

        [DisplayName("User Defined Field 3"), Column("USER_DEFINED_FIELD_3"), Size(100)]
        public String UserDefinedField3
        {
            get { return Fields.UserDefinedField3[this]; }
            set { Fields.UserDefinedField3[this] = value; }
        }

        [DisplayName("User Defined Field 4"), Column("USER_DEFINED_FIELD_4"), Size(100)]
        public String UserDefinedField4
        {
            get { return Fields.UserDefinedField4[this]; }
            set { Fields.UserDefinedField4[this] = value; }
        }

        [DisplayName("User Defined Field 5"), Column("USER_DEFINED_FIELD_5"), Size(100)]
        public String UserDefinedField5
        {
            get { return Fields.UserDefinedField5[this]; }
            set { Fields.UserDefinedField5[this] = value; }
        }

        [DisplayName("User Defined Field 6"), Column("USER_DEFINED_FIELD_6"), Size(100)]
        public String UserDefinedField6
        {
            get { return Fields.UserDefinedField6[this]; }
            set { Fields.UserDefinedField6[this] = value; }
        }

        [DisplayName("User Defined Field 7"), Column("USER_DEFINED_FIELD_7"), Size(100)]
        public String UserDefinedField7
        {
            get { return Fields.UserDefinedField7[this]; }
            set { Fields.UserDefinedField7[this] = value; }
        }

        [DisplayName("User Defined Field 8"), Column("USER_DEFINED_FIELD_8"), Size(100)]
        public String UserDefinedField8
        {
            get { return Fields.UserDefinedField8[this]; }
            set { Fields.UserDefinedField8[this] = value; }
        }

        [DisplayName("User Defined Field 9"), Column("USER_DEFINED_FIELD_9"), Size(100)]
        public String UserDefinedField9
        {
            get { return Fields.UserDefinedField9[this]; }
            set { Fields.UserDefinedField9[this] = value; }
        }

        [DisplayName("User Defined Field 10"), Column("USER_DEFINED_FIELD_10"), Size(100)]
        public String UserDefinedField10
        {
            get { return Fields.UserDefinedField10[this]; }
            set { Fields.UserDefinedField10[this] = value; }
        }

        [DisplayName("User Defined Field 11"), Column("USER_DEFINED_FIELD_11"), Size(100)]
        public String UserDefinedField11
        {
            get { return Fields.UserDefinedField11[this]; }
            set { Fields.UserDefinedField11[this] = value; }
        }

        [DisplayName("User Defined Field 12"), Column("USER_DEFINED_FIELD_12"), Size(100)]
        public String UserDefinedField12
        {
            get { return Fields.UserDefinedField12[this]; }
            set { Fields.UserDefinedField12[this] = value; }
        }

        [DisplayName("User Defined Field 13"), Column("USER_DEFINED_FIELD_13"), Size(100)]
        public String UserDefinedField13
        {
            get { return Fields.UserDefinedField13[this]; }
            set { Fields.UserDefinedField13[this] = value; }
        }

        [DisplayName("User Defined Field 14"), Column("USER_DEFINED_FIELD_14"), Size(100)]
        public String UserDefinedField14
        {
            get { return Fields.UserDefinedField14[this]; }
            set { Fields.UserDefinedField14[this] = value; }
        }

        [DisplayName("User Defined Field 15"), Column("USER_DEFINED_FIELD_15"), Size(100)]
        public String UserDefinedField15
        {
            get { return Fields.UserDefinedField15[this]; }
            set { Fields.UserDefinedField15[this] = value; }
        }

        [DisplayName("User Defined Field 16"), Column("USER_DEFINED_FIELD_16"), Size(100)]
        public String UserDefinedField16
        {
            get { return Fields.UserDefinedField16[this]; }
            set { Fields.UserDefinedField16[this] = value; }
        }

        [DisplayName("User Defined Field 17"), Column("USER_DEFINED_FIELD_17"), Size(100)]
        public String UserDefinedField17
        {
            get { return Fields.UserDefinedField17[this]; }
            set { Fields.UserDefinedField17[this] = value; }
        }

        [DisplayName("User Defined Field 18"), Column("USER_DEFINED_FIELD_18"), Size(100)]
        public String UserDefinedField18
        {
            get { return Fields.UserDefinedField18[this]; }
            set { Fields.UserDefinedField18[this] = value; }
        }

        [DisplayName("User Defined Field 19"), Column("USER_DEFINED_FIELD_19"), Size(100)]
        public String UserDefinedField19
        {
            get { return Fields.UserDefinedField19[this]; }
            set { Fields.UserDefinedField19[this] = value; }
        }

        [DisplayName("User Defined Field 20"), Column("USER_DEFINED_FIELD_20"), Size(100)]
        public String UserDefinedField20
        {
            get { return Fields.UserDefinedField20[this]; }
            set { Fields.UserDefinedField20[this] = value; }
        }

        [DisplayName("Rohs Compliance"), Column("ROHS_COMPLIANCE")]
        public Boolean? RohsCompliance
        {
            get { return Fields.RohsCompliance[this]; }
            set { Fields.RohsCompliance[this] = value; }
        }

        [DisplayName("Def Mold Bom No"), Column("DEF_MOLD_BOM_NO"), Size(30)]
        public String DefMoldBomNo
        {
            get { return Fields.DefMoldBomNo[this]; }
            set { Fields.DefMoldBomNo[this] = value; }
        }

        [DisplayName("Def Formula Code"), Column("DEF_FORMULA_CODE"), Size(30)]
        public String DefFormulaCode
        {
            get { return Fields.DefFormulaCode[this]; }
            set { Fields.DefFormulaCode[this] = value; }
        }

        [DisplayName("Box Type"), Column("BOX_TYPE"), Size(6)]
        public String BoxType
        {
            get { return Fields.BoxType[this]; }
            set { Fields.BoxType[this] = value; }
        }

        [DisplayName("Box Length"), Column("BOX_LENGTH"), Size(6), Scale(2)]
        public Decimal? BoxLength
        {
            get { return Fields.BoxLength[this]; }
            set { Fields.BoxLength[this] = value; }
        }

        [DisplayName("Box Width"), Column("BOX_WIDTH"), Size(6), Scale(2)]
        public Decimal? BoxWidth
        {
            get { return Fields.BoxWidth[this]; }
            set { Fields.BoxWidth[this] = value; }
        }

        [DisplayName("Box Height"), Column("BOX_HEIGHT"), Size(6), Scale(2)]
        public Decimal? BoxHeight
        {
            get { return Fields.BoxHeight[this]; }
            set { Fields.BoxHeight[this] = value; }
        }

        [DisplayName("Box D Uom"), Column("BOX_D_UOM"), Size(4)]
        public String BoxDUom
        {
            get { return Fields.BoxDUom[this]; }
            set { Fields.BoxDUom[this] = value; }
        }

        [DisplayName("Wd"), Column("WD"), Size(12), Scale(4)]
        public Decimal? Wd
        {
            get { return Fields.Wd[this]; }
            set { Fields.Wd[this] = value; }
        }

        [DisplayName("Wd Uom"), Column("WD_UOM"), Size(4)]
        public String WdUom
        {
            get { return Fields.WdUom[this]; }
            set { Fields.WdUom[this] = value; }
        }

        [DisplayName("Cs Length"), Column("CS_LENGTH"), Size(12), Scale(4)]
        public Decimal? CsLength
        {
            get { return Fields.CsLength[this]; }
            set { Fields.CsLength[this] = value; }
        }

        [DisplayName("Cs Width"), Column("CS_WIDTH"), Size(12), Scale(4)]
        public Decimal? CsWidth
        {
            get { return Fields.CsWidth[this]; }
            set { Fields.CsWidth[this] = value; }
        }

        [DisplayName("User Defined Field 21"), Column("USER_DEFINED_FIELD_21"), Size(1073741823)]
        public String UserDefinedField21
        {
            get { return Fields.UserDefinedField21[this]; }
            set { Fields.UserDefinedField21[this] = value; }
        }

        [DisplayName("Cost Wmove"), Column("COST_WMOVE"), Size(5), Scale(2)]
        public Decimal? CostWmove
        {
            get { return Fields.CostWmove[this]; }
            set { Fields.CostWmove[this] = value; }
        }

        [DisplayName("Cost Wcase"), Column("COST_WCASE"), Size(5), Scale(2)]
        public Decimal? CostWcase
        {
            get { return Fields.CostWcase[this]; }
            set { Fields.CostWcase[this] = value; }
        }

        [DisplayName("Cost Wband"), Column("COST_WBAND"), Size(5), Scale(2)]
        public Decimal? CostWband
        {
            get { return Fields.CostWband[this]; }
            set { Fields.CostWband[this] = value; }
        }

        [DisplayName("Cost Batt"), Column("COST_BATT"), Size(5), Scale(2)]
        public Decimal? CostBatt
        {
            get { return Fields.CostBatt[this]; }
            set { Fields.CostBatt[this] = value; }
        }

        [DisplayName("Desc Wmove"), Column("DESC_WMOVE"), Size(60)]
        public String DescWmove
        {
            get { return Fields.DescWmove[this]; }
            set { Fields.DescWmove[this] = value; }
        }

        [DisplayName("Desc Wcase"), Column("DESC_WCASE"), Size(60)]
        public String DescWcase
        {
            get { return Fields.DescWcase[this]; }
            set { Fields.DescWcase[this] = value; }
        }

        [DisplayName("Desc Wband"), Column("DESC_WBAND"), Size(60)]
        public String DescWband
        {
            get { return Fields.DescWband[this]; }
            set { Fields.DescWband[this] = value; }
        }

        [DisplayName("Desc Batt"), Column("DESC_BATT"), Size(60)]
        public String DescBatt
        {
            get { return Fields.DescBatt[this]; }
            set { Fields.DescBatt[this] = value; }
        }

        [DisplayName("Po Bal"), Column("PO_BAL"), Size(14), Scale(4)]
        public Decimal? PoBal
        {
            get { return Fields.PoBal[this]; }
            set { Fields.PoBal[this] = value; }
        }

        [DisplayName("Po Max Bal"), Column("PO_MAX_BAL"), Size(14), Scale(4)]
        public Decimal? PoMaxBal
        {
            get { return Fields.PoMaxBal[this]; }
            set { Fields.PoMaxBal[this] = value; }
        }

        [DisplayName("Include Job"), Column("INCLUDE_JOB")]
        public Boolean? IncludeJob
        {
            get { return Fields.IncludeJob[this]; }
            set { Fields.IncludeJob[this] = value; }
        }

        [DisplayName("Cs Thickness"), Column("CS_THICKNESS"), Size(12), Scale(4)]
        public Decimal? CsThickness
        {
            get { return Fields.CsThickness[this]; }
            set { Fields.CsThickness[this] = value; }
        }

        [DisplayName("Cs Thickness Uom"), Column("CS_THICKNESS_UOM"), Size(4)]
        public String CsThicknessUom
        {
            get { return Fields.CsThicknessUom[this]; }
            set { Fields.CsThicknessUom[this] = value; }
        }

        [DisplayName("Cs Proportion"), Column("CS_PROPORTION"), Size(14), Scale(6)]
        public Decimal? CsProportion
        {
            get { return Fields.CsProportion[this]; }
            set { Fields.CsProportion[this] = value; }
        }

        [DisplayName("Cs Proportion Uom"), Column("CS_PROPORTION_UOM"), Size(4)]
        public String CsProportionUom
        {
            get { return Fields.CsProportionUom[this]; }
            set { Fields.CsProportionUom[this] = value; }
        }

        [DisplayName("Die Cutter"), Column("DIE_CUTTER"), Size(16), Scale(2)]
        public Decimal? DieCutter
        {
            get { return Fields.DieCutter[this]; }
            set { Fields.DieCutter[this] = value; }
        }

        [DisplayName("Mat Inspect Lead Time"), Column("MAT_INSPECT_LEAD_TIME"), Size(4)]
        public Decimal? MatInspectLeadTime
        {
            get { return Fields.MatInspectLeadTime[this]; }
            set { Fields.MatInspectLeadTime[this] = value; }
        }

        [DisplayName("Mat Prepare Lead Time"), Column("MAT_PREPARE_LEAD_TIME"), Size(4)]
        public Decimal? MatPrepareLeadTime
        {
            get { return Fields.MatPrepareLeadTime[this]; }
            set { Fields.MatPrepareLeadTime[this] = value; }
        }

        [DisplayName("Mat Inspect Lead Unit"), Column("MAT_INSPECT_LEAD_UNIT"), Size(1)]
        public String MatInspectLeadUnit
        {
            get { return Fields.MatInspectLeadUnit[this]; }
            set { Fields.MatInspectLeadUnit[this] = value; }
        }

        [DisplayName("Mat Prepare Lead Unit"), Column("MAT_PREPARE_LEAD_UNIT"), Size(1)]
        public String MatPrepareLeadUnit
        {
            get { return Fields.MatPrepareLeadUnit[this]; }
            set { Fields.MatPrepareLeadUnit[this] = value; }
        }

        [DisplayName("Color Code"), Column("COLOR_CODE"), Size(30)]
        public String ColorCode
        {
            get { return Fields.ColorCode[this]; }
            set { Fields.ColorCode[this] = value; }
        }

        [DisplayName("Collection Code"), Column("COLLECTION_CODE"), Size(30)]
        public String CollectionCode
        {
            get { return Fields.CollectionCode[this]; }
            set { Fields.CollectionCode[this] = value; }
        }

        [DisplayName("Style Code"), Column("STYLE_CODE"), Size(30)]
        public String StyleCode
        {
            get { return Fields.StyleCode[this]; }
            set { Fields.StyleCode[this] = value; }
        }

        [DisplayName("X"), Size(12), Scale(4)]
        public Decimal? X
        {
            get { return Fields.X[this]; }
            set { Fields.X[this] = value; }
        }

        [DisplayName("Y"), Size(12), Scale(4)]
        public Decimal? Y
        {
            get { return Fields.Y[this]; }
            set { Fields.Y[this] = value; }
        }

        [DisplayName("Temp Description"), Column("TEMP_DESCRIPTION"), Size(60)]
        public String TempDescription
        {
            get { return Fields.TempDescription[this]; }
            set { Fields.TempDescription[this] = value; }
        }

        [DisplayName("Specification"), Column("SPECIFICATION"), Size(60)]
        public String Specification
        {
            get { return Fields.Specification[this]; }
            set { Fields.Specification[this] = value; }
        }

        [DisplayName("X Uom"), Column("X_UOM"), Size(4)]
        public String XUom
        {
            get { return Fields.XUom[this]; }
            set { Fields.XUom[this] = value; }
        }

        [DisplayName("Y Uom"), Column("Y_UOM"), Size(4)]
        public String YUom
        {
            get { return Fields.YUom[this]; }
            set { Fields.YUom[this] = value; }
        }

        [DisplayName("Production Uom Conversion Rate"), Column("PRODUCTION_UOM_CONVERSION_RATE"), Size(12), Scale(4)]
        public Decimal? ProductionUomConversionRate
        {
            get { return Fields.ProductionUomConversionRate[this]; }
            set { Fields.ProductionUomConversionRate[this] = value; }
        }

        [DisplayName("Purchase Uom Conversion Rate"), Column("PURCHASE_UOM_CONVERSION_RATE"), Size(12), Scale(4)]
        public Decimal? PurchaseUomConversionRate
        {
            get { return Fields.PurchaseUomConversionRate[this]; }
            set { Fields.PurchaseUomConversionRate[this] = value; }
        }

        [DisplayName("Autogen Lot Issue"), Column("AUTOGEN_LOT_ISSUE")]
        public Boolean? AutogenLotIssue
        {
            get { return Fields.AutogenLotIssue[this]; }
            set { Fields.AutogenLotIssue[this] = value; }
        }

        [DisplayName("Autogen Serial Issue"), Column("AUTOGEN_SERIAL_ISSUE")]
        public Boolean? AutogenSerialIssue
        {
            get { return Fields.AutogenSerialIssue[this]; }
            set { Fields.AutogenSerialIssue[this] = value; }
        }

        [DisplayName("Wc Cost Ccy"), Column("WC_COST_CCY"), Size(4)]
        public String WcCostCcy
        {
            get { return Fields.WcCostCcy[this]; }
            set { Fields.WcCostCcy[this] = value; }
        }

        [DisplayName("Wc Cost"), Column("WC_COST"), Size(18), Scale(6)]
        public Decimal? WcCost
        {
            get { return Fields.WcCost[this]; }
            set { Fields.WcCost[this] = value; }
        }

        [DisplayName("Wc Cost Disc"), Column("WC_COST_DISC"), Size(18), Scale(6)]
        public Decimal? WcCostDisc
        {
            get { return Fields.WcCostDisc[this]; }
            set { Fields.WcCostDisc[this] = value; }
        }

        [DisplayName("Wc Cost Exch"), Column("WC_COST_EXCH"), Size(18), Scale(6)]
        public Decimal? WcCostExch
        {
            get { return Fields.WcCostExch[this]; }
            set { Fields.WcCostExch[this] = value; }
        }

        [DisplayName("Wc Freight"), Column("WC_FREIGHT"), Size(18), Scale(6)]
        public Decimal? WcFreight
        {
            get { return Fields.WcFreight[this]; }
            set { Fields.WcFreight[this] = value; }
        }

        [DisplayName("Wc Margin"), Column("WC_MARGIN"), Size(18), Scale(6)]
        public Decimal? WcMargin
        {
            get { return Fields.WcMargin[this]; }
            set { Fields.WcMargin[this] = value; }
        }

        [DisplayName("Ceiling Price"), Column("CEILING_PRICE"), Size(18), Scale(6)]
        public Decimal? CeilingPrice
        {
            get { return Fields.CeilingPrice[this]; }
            set { Fields.CeilingPrice[this] = value; }
        }

        [DisplayName("Bottom Ratio"), Column("BOTTOM_RATIO"), Size(18), Scale(6)]
        public Decimal? BottomRatio
        {
            get { return Fields.BottomRatio[this]; }
            set { Fields.BottomRatio[this] = value; }
        }

        [DisplayName("Bottom Price"), Column("BOTTOM_PRICE"), Size(18), Scale(6)]
        public Decimal? BottomPrice
        {
            get { return Fields.BottomPrice[this]; }
            set { Fields.BottomPrice[this] = value; }
        }

        [DisplayName("Drawing No"), Column("DRAWING_NO"), Size(120)]
        public String DrawingNo
        {
            get { return Fields.DrawingNo[this]; }
            set { Fields.DrawingNo[this] = value; }
        }

        [DisplayName("Material Type"), Column("MATERIAL_TYPE"), Size(30)]
        public String MaterialType
        {
            get { return Fields.MaterialType[this]; }
            set { Fields.MaterialType[this] = value; }
        }

        [DisplayName("Item Group Recnum"), Expression("jItemGroup.[RECNUM]")]
        public Decimal? ItemGroupRecnum
        {
            get { return Fields.ItemGroupRecnum[this]; }
            set { Fields.ItemGroupRecnum[this] = value; }
        }

        [DisplayName("Item Group Description"), Expression("jItemGroup.[DESCRIPTION]")]
        public String ItemGroupDescription
        {
            get { return Fields.ItemGroupDescription[this]; }
            set { Fields.ItemGroupDescription[this] = value; }
        }

        [DisplayName("Item Group Suspended"), Expression("jItemGroup.[SUSPENDED]")]
        public String ItemGroupSuspended
        {
            get { return Fields.ItemGroupSuspended[this]; }
            set { Fields.ItemGroupSuspended[this] = value; }
        }

        [DisplayName("Item Group Product"), Expression("jItemGroup.[PRODUCT]")]
        public String ItemGroupProduct
        {
            get { return Fields.ItemGroupProduct[this]; }
            set { Fields.ItemGroupProduct[this] = value; }
        }

        [DisplayName("Item Group Material"), Expression("jItemGroup.[MATERIAL]")]
        public String ItemGroupMaterial
        {
            get { return Fields.ItemGroupMaterial[this]; }
            set { Fields.ItemGroupMaterial[this] = value; }
        }

        [DisplayName("Item Group Inspected"), Expression("jItemGroup.[INSPECTED]")]
        public String ItemGroupInspected
        {
            get { return Fields.ItemGroupInspected[this]; }
            set { Fields.ItemGroupInspected[this] = value; }
        }

        [DisplayName("Item Group Cost Centre"), Expression("jItemGroup.[COST_CENTRE]")]
        public String ItemGroupCostCentre
        {
            get { return Fields.ItemGroupCostCentre[this]; }
            set { Fields.ItemGroupCostCentre[this] = value; }
        }

        [DisplayName("Item Group Item Type"), Expression("jItemGroup.[ITEM_TYPE]")]
        public String ItemGroupItemType
        {
            get { return Fields.ItemGroupItemType[this]; }
            set { Fields.ItemGroupItemType[this] = value; }
        }

        [DisplayName("Item Group Alloc Method"), Expression("jItemGroup.[ALLOC_METHOD]")]
        public String ItemGroupAllocMethod
        {
            get { return Fields.ItemGroupAllocMethod[this]; }
            set { Fields.ItemGroupAllocMethod[this] = value; }
        }

        [DisplayName("Item Group Prod Branch"), Expression("jItemGroup.[PROD_BRANCH]")]
        public String ItemGroupProdBranch
        {
            get { return Fields.ItemGroupProdBranch[this]; }
            set { Fields.ItemGroupProdBranch[this] = value; }
        }

        [DisplayName("Item Group Acct Itm Asset"), Expression("jItemGroup.[ACCT_ITM_ASSET]")]
        public String ItemGroupAcctItmAsset
        {
            get { return Fields.ItemGroupAcctItmAsset[this]; }
            set { Fields.ItemGroupAcctItmAsset[this] = value; }
        }

        [DisplayName("Item Group Acct Itm Wip"), Expression("jItemGroup.[ACCT_ITM_WIP]")]
        public String ItemGroupAcctItmWip
        {
            get { return Fields.ItemGroupAcctItmWip[this]; }
            set { Fields.ItemGroupAcctItmWip[this] = value; }
        }

        [DisplayName("Item Group Acct Itm Consum"), Expression("jItemGroup.[ACCT_ITM_CONSUM]")]
        public String ItemGroupAcctItmConsum
        {
            get { return Fields.ItemGroupAcctItmConsum[this]; }
            set { Fields.ItemGroupAcctItmConsum[this] = value; }
        }

        [DisplayName("Item Group Acct Itm Scrap"), Expression("jItemGroup.[ACCT_ITM_SCRAP]")]
        public String ItemGroupAcctItmScrap
        {
            get { return Fields.ItemGroupAcctItmScrap[this]; }
            set { Fields.ItemGroupAcctItmScrap[this] = value; }
        }

        [DisplayName("Item Group Acct Itm Pvar"), Expression("jItemGroup.[ACCT_ITM_PVAR]")]
        public String ItemGroupAcctItmPvar
        {
            get { return Fields.ItemGroupAcctItmPvar[this]; }
            set { Fields.ItemGroupAcctItmPvar[this] = value; }
        }

        [DisplayName("Item Group Acct Itm Reval"), Expression("jItemGroup.[ACCT_ITM_REVAL]")]
        public String ItemGroupAcctItmReval
        {
            get { return Fields.ItemGroupAcctItmReval[this]; }
            set { Fields.ItemGroupAcctItmReval[this] = value; }
        }

        [DisplayName("Item Group Acct Itm Varia"), Expression("jItemGroup.[ACCT_ITM_VARIA]")]
        public String ItemGroupAcctItmVaria
        {
            get { return Fields.ItemGroupAcctItmVaria[this]; }
            set { Fields.ItemGroupAcctItmVaria[this] = value; }
        }

        [DisplayName("Item Group Acct Itm Sales"), Expression("jItemGroup.[ACCT_ITM_SALES]")]
        public String ItemGroupAcctItmSales
        {
            get { return Fields.ItemGroupAcctItmSales[this]; }
            set { Fields.ItemGroupAcctItmSales[this] = value; }
        }

        [DisplayName("Item Group Acct Itm Slret"), Expression("jItemGroup.[ACCT_ITM_SLRET]")]
        public String ItemGroupAcctItmSlret
        {
            get { return Fields.ItemGroupAcctItmSlret[this]; }
            set { Fields.ItemGroupAcctItmSlret[this] = value; }
        }

        [DisplayName("Item Group Acct Itm Sldisc"), Expression("jItemGroup.[ACCT_ITM_SLDISC]")]
        public String ItemGroupAcctItmSldisc
        {
            get { return Fields.ItemGroupAcctItmSldisc[this]; }
            set { Fields.ItemGroupAcctItmSldisc[this] = value; }
        }

        [DisplayName("Item Group Acct Itm Cogs"), Expression("jItemGroup.[ACCT_ITM_COGS]")]
        public String ItemGroupAcctItmCogs
        {
            get { return Fields.ItemGroupAcctItmCogs[this]; }
            set { Fields.ItemGroupAcctItmCogs[this] = value; }
        }

        [DisplayName("Item Group Acct Itm Purch"), Expression("jItemGroup.[ACCT_ITM_PURCH]")]
        public String ItemGroupAcctItmPurch
        {
            get { return Fields.ItemGroupAcctItmPurch[this]; }
            set { Fields.ItemGroupAcctItmPurch[this] = value; }
        }

        [DisplayName("Item Group Acct Itm Puret"), Expression("jItemGroup.[ACCT_ITM_PURET]")]
        public String ItemGroupAcctItmPuret
        {
            get { return Fields.ItemGroupAcctItmPuret[this]; }
            set { Fields.ItemGroupAcctItmPuret[this] = value; }
        }

        [DisplayName("Item Group Acct Itm Pudisc"), Expression("jItemGroup.[ACCT_ITM_PUDISC]")]
        public String ItemGroupAcctItmPudisc
        {
            get { return Fields.ItemGroupAcctItmPudisc[this]; }
            set { Fields.ItemGroupAcctItmPudisc[this] = value; }
        }

        [DisplayName("Item Group Acct Itm Putax"), Expression("jItemGroup.[ACCT_ITM_PUTAX]")]
        public String ItemGroupAcctItmPutax
        {
            get { return Fields.ItemGroupAcctItmPutax[this]; }
            set { Fields.ItemGroupAcctItmPutax[this] = value; }
        }

        [DisplayName("Item Group Acct Machine"), Expression("jItemGroup.[ACCT_MACHINE]")]
        public String ItemGroupAcctMachine
        {
            get { return Fields.ItemGroupAcctMachine[this]; }
            set { Fields.ItemGroupAcctMachine[this] = value; }
        }

        [DisplayName("Item Group Acct Energy"), Expression("jItemGroup.[ACCT_ENERGY]")]
        public String ItemGroupAcctEnergy
        {
            get { return Fields.ItemGroupAcctEnergy[this]; }
            set { Fields.ItemGroupAcctEnergy[this] = value; }
        }

        [DisplayName("Item Group Acct Water"), Expression("jItemGroup.[ACCT_WATER]")]
        public String ItemGroupAcctWater
        {
            get { return Fields.ItemGroupAcctWater[this]; }
            set { Fields.ItemGroupAcctWater[this] = value; }
        }

        [DisplayName("Item Group Acct Rental"), Expression("jItemGroup.[ACCT_RENTAL]")]
        public String ItemGroupAcctRental
        {
            get { return Fields.ItemGroupAcctRental[this]; }
            set { Fields.ItemGroupAcctRental[this] = value; }
        }

        [DisplayName("Item Group Acct Labor"), Expression("jItemGroup.[ACCT_LABOR]")]
        public String ItemGroupAcctLabor
        {
            get { return Fields.ItemGroupAcctLabor[this]; }
            set { Fields.ItemGroupAcctLabor[this] = value; }
        }

        [DisplayName("Item Group Acct Inlab"), Expression("jItemGroup.[ACCT_INLAB]")]
        public String ItemGroupAcctInlab
        {
            get { return Fields.ItemGroupAcctInlab[this]; }
            set { Fields.ItemGroupAcctInlab[this] = value; }
        }

        [DisplayName("Item Group Acct Inmat"), Expression("jItemGroup.[ACCT_INMAT]")]
        public String ItemGroupAcctInmat
        {
            get { return Fields.ItemGroupAcctInmat[this]; }
            set { Fields.ItemGroupAcctInmat[this] = value; }
        }

        [DisplayName("Item Group Acct Misc"), Expression("jItemGroup.[ACCT_MISC]")]
        public String ItemGroupAcctMisc
        {
            get { return Fields.ItemGroupAcctMisc[this]; }
            set { Fields.ItemGroupAcctMisc[this] = value; }
        }

        [DisplayName("Item Group Arevised Date"), Expression("jItemGroup.[AREVISED_DATE]")]
        public DateTime? ItemGroupArevisedDate
        {
            get { return Fields.ItemGroupArevisedDate[this]; }
            set { Fields.ItemGroupArevisedDate[this] = value; }
        }

        [DisplayName("Item Group Arevised By"), Expression("jItemGroup.[AREVISED_BY]")]
        public String ItemGroupArevisedBy
        {
            get { return Fields.ItemGroupArevisedBy[this]; }
            set { Fields.ItemGroupArevisedBy[this] = value; }
        }

        [DisplayName("Item Group Brevised Date"), Expression("jItemGroup.[BREVISED_DATE]")]
        public DateTime? ItemGroupBrevisedDate
        {
            get { return Fields.ItemGroupBrevisedDate[this]; }
            set { Fields.ItemGroupBrevisedDate[this] = value; }
        }

        [DisplayName("Item Group Brevised By"), Expression("jItemGroup.[BREVISED_BY]")]
        public String ItemGroupBrevisedBy
        {
            get { return Fields.ItemGroupBrevisedBy[this]; }
            set { Fields.ItemGroupBrevisedBy[this] = value; }
        }

        [DisplayName("Item Group Make Or Buy"), Expression("jItemGroup.[MAKE_OR_BUY]")]
        public String ItemGroupMakeOrBuy
        {
            get { return Fields.ItemGroupMakeOrBuy[this]; }
            set { Fields.ItemGroupMakeOrBuy[this] = value; }
        }

        [DisplayName("Item Group Typical Uom"), Expression("jItemGroup.[TYPICAL_UOM]")]
        public String ItemGroupTypicalUom
        {
            get { return Fields.ItemGroupTypicalUom[this]; }
            set { Fields.ItemGroupTypicalUom[this] = value; }
        }

        [DisplayName("Item Group Cycle Code"), Expression("jItemGroup.[CYCLE_CODE]")]
        public String ItemGroupCycleCode
        {
            get { return Fields.ItemGroupCycleCode[this]; }
            set { Fields.ItemGroupCycleCode[this] = value; }
        }

        [DisplayName("Item Group Sales Ltax Code"), Expression("jItemGroup.[SALES_LTAX_CODE]")]
        public String ItemGroupSalesLtaxCode
        {
            get { return Fields.ItemGroupSalesLtaxCode[this]; }
            set { Fields.ItemGroupSalesLtaxCode[this] = value; }
        }

        [DisplayName("Item Group Purch Ltax Code"), Expression("jItemGroup.[PURCH_LTAX_CODE]")]
        public String ItemGroupPurchLtaxCode
        {
            get { return Fields.ItemGroupPurchLtaxCode[this]; }
            set { Fields.ItemGroupPurchLtaxCode[this] = value; }
        }

        [DisplayName("Item Group Inner Pkg Type"), Expression("jItemGroup.[INNER_PKG_TYPE]")]
        public String ItemGroupInnerPkgType
        {
            get { return Fields.ItemGroupInnerPkgType[this]; }
            set { Fields.ItemGroupInnerPkgType[this] = value; }
        }

        [DisplayName("Item Group Inner Qty"), Expression("jItemGroup.[INNER_QTY]")]
        public Decimal? ItemGroupInnerQty
        {
            get { return Fields.ItemGroupInnerQty[this]; }
            set { Fields.ItemGroupInnerQty[this] = value; }
        }

        [DisplayName("Item Group Outer Pkg Type"), Expression("jItemGroup.[OUTER_PKG_TYPE]")]
        public String ItemGroupOuterPkgType
        {
            get { return Fields.ItemGroupOuterPkgType[this]; }
            set { Fields.ItemGroupOuterPkgType[this] = value; }
        }

        [DisplayName("Item Group Outer Qty"), Expression("jItemGroup.[OUTER_QTY]")]
        public Decimal? ItemGroupOuterQty
        {
            get { return Fields.ItemGroupOuterQty[this]; }
            set { Fields.ItemGroupOuterQty[this] = value; }
        }

        [DisplayName("Item Group Anlys1"), Expression("jItemGroup.[ANLYS1]")]
        public String ItemGroupAnlys1
        {
            get { return Fields.ItemGroupAnlys1[this]; }
            set { Fields.ItemGroupAnlys1[this] = value; }
        }

        [DisplayName("Item Group Anlys2"), Expression("jItemGroup.[ANLYS2]")]
        public String ItemGroupAnlys2
        {
            get { return Fields.ItemGroupAnlys2[this]; }
            set { Fields.ItemGroupAnlys2[this] = value; }
        }

        [DisplayName("Item Group Anlys3"), Expression("jItemGroup.[ANLYS3]")]
        public String ItemGroupAnlys3
        {
            get { return Fields.ItemGroupAnlys3[this]; }
            set { Fields.ItemGroupAnlys3[this] = value; }
        }

        [DisplayName("Item Group Anlys4"), Expression("jItemGroup.[ANLYS4]")]
        public String ItemGroupAnlys4
        {
            get { return Fields.ItemGroupAnlys4[this]; }
            set { Fields.ItemGroupAnlys4[this] = value; }
        }

        [DisplayName("Item Group Item Count"), Expression("jItemGroup.[ITEM_COUNT]")]
        public Decimal? ItemGroupItemCount
        {
            get { return Fields.ItemGroupItemCount[this]; }
            set { Fields.ItemGroupItemCount[this] = value; }
        }

        [DisplayName("Item Group Created Date"), Expression("jItemGroup.[CREATED_DATE]")]
        public DateTime? ItemGroupCreatedDate
        {
            get { return Fields.ItemGroupCreatedDate[this]; }
            set { Fields.ItemGroupCreatedDate[this] = value; }
        }

        [DisplayName("Item Group Created By"), Expression("jItemGroup.[CREATED_BY]")]
        public String ItemGroupCreatedBy
        {
            get { return Fields.ItemGroupCreatedBy[this]; }
            set { Fields.ItemGroupCreatedBy[this] = value; }
        }

        [DisplayName("Item Group Revised Date"), Expression("jItemGroup.[REVISED_DATE]")]
        public DateTime? ItemGroupRevisedDate
        {
            get { return Fields.ItemGroupRevisedDate[this]; }
            set { Fields.ItemGroupRevisedDate[this] = value; }
        }

        [DisplayName("Item Group Revised By"), Expression("jItemGroup.[REVISED_BY]")]
        public String ItemGroupRevisedBy
        {
            get { return Fields.ItemGroupRevisedBy[this]; }
            set { Fields.ItemGroupRevisedBy[this] = value; }
        }

        [DisplayName("Item Group Trevised Date"), Expression("jItemGroup.[TREVISED_DATE]")]
        public DateTime? ItemGroupTrevisedDate
        {
            get { return Fields.ItemGroupTrevisedDate[this]; }
            set { Fields.ItemGroupTrevisedDate[this] = value; }
        }

        [DisplayName("Item Group Trevised By"), Expression("jItemGroup.[TREVISED_BY]")]
        public String ItemGroupTrevisedBy
        {
            get { return Fields.ItemGroupTrevisedBy[this]; }
            set { Fields.ItemGroupTrevisedBy[this] = value; }
        }

        [DisplayName("Item Group Commis Type"), Expression("jItemGroup.[COMMIS_TYPE]")]
        public String ItemGroupCommisType
        {
            get { return Fields.ItemGroupCommisType[this]; }
            set { Fields.ItemGroupCommisType[this] = value; }
        }

        [DisplayName("Item Group Owner Branch"), Expression("jItemGroup.[OWNER_BRANCH]")]
        public String ItemGroupOwnerBranch
        {
            get { return Fields.ItemGroupOwnerBranch[this]; }
            set { Fields.ItemGroupOwnerBranch[this] = value; }
        }

        [DisplayName("Item Group Source Branch"), Expression("jItemGroup.[SOURCE_BRANCH]")]
        public String ItemGroupSourceBranch
        {
            get { return Fields.ItemGroupSourceBranch[this]; }
            set { Fields.ItemGroupSourceBranch[this] = value; }
        }

        [DisplayName("Item Group Scrap Rate"), Expression("jItemGroup.[SCRAP_RATE]")]
        public Decimal? ItemGroupScrapRate
        {
            get { return Fields.ItemGroupScrapRate[this]; }
            set { Fields.ItemGroupScrapRate[this] = value; }
        }

        [DisplayName("Item Group Pur Price Ctrl"), Expression("jItemGroup.[PUR_PRICE_CTRL]")]
        public String ItemGroupPurPriceCtrl
        {
            get { return Fields.ItemGroupPurPriceCtrl[this]; }
            set { Fields.ItemGroupPurPriceCtrl[this] = value; }
        }

        [DisplayName("Item Group Pur Max Dev"), Expression("jItemGroup.[PUR_MAX_DEV]")]
        public Decimal? ItemGroupPurMaxDev
        {
            get { return Fields.ItemGroupPurMaxDev[this]; }
            set { Fields.ItemGroupPurMaxDev[this] = value; }
        }

        [DisplayName("Item Group Acct Itm Subcon"), Expression("jItemGroup.[ACCT_ITM_SUBCON]")]
        public String ItemGroupAcctItmSubcon
        {
            get { return Fields.ItemGroupAcctItmSubcon[this]; }
            set { Fields.ItemGroupAcctItmSubcon[this] = value; }
        }

        [DisplayName("Item Group Consolidate"), Expression("jItemGroup.[CONSOLIDATE]")]
        public String ItemGroupConsolidate
        {
            get { return Fields.ItemGroupConsolidate[this]; }
            set { Fields.ItemGroupConsolidate[this] = value; }
        }

        [DisplayName("Item Group Putax Pcent"), Expression("jItemGroup.[PUTAX_PCENT]")]
        public Decimal? ItemGroupPutaxPcent
        {
            get { return Fields.ItemGroupPutaxPcent[this]; }
            set { Fields.ItemGroupPutaxPcent[this] = value; }
        }

        [DisplayName("Item Group Acct Itm Sltax"), Expression("jItemGroup.[ACCT_ITM_SLTAX]")]
        public String ItemGroupAcctItmSltax
        {
            get { return Fields.ItemGroupAcctItmSltax[this]; }
            set { Fields.ItemGroupAcctItmSltax[this] = value; }
        }

        [DisplayName("Item Group Sltax Pcent"), Expression("jItemGroup.[SLTAX_PCENT]")]
        public Decimal? ItemGroupSltaxPcent
        {
            get { return Fields.ItemGroupSltaxPcent[this]; }
            set { Fields.ItemGroupSltaxPcent[this] = value; }
        }

        [DisplayName("Item Group Enable Lot"), Expression("jItemGroup.[ENABLE_LOT]")]
        public String ItemGroupEnableLot
        {
            get { return Fields.ItemGroupEnableLot[this]; }
            set { Fields.ItemGroupEnableLot[this] = value; }
        }

        [DisplayName("Item Group Enable Serial"), Expression("jItemGroup.[ENABLE_SERIAL]")]
        public String ItemGroupEnableSerial
        {
            get { return Fields.ItemGroupEnableSerial[this]; }
            set { Fields.ItemGroupEnableSerial[this] = value; }
        }

        [DisplayName("Item Group Lot No Length"), Expression("jItemGroup.[LOT_NO_LENGTH]")]
        public Decimal? ItemGroupLotNoLength
        {
            get { return Fields.ItemGroupLotNoLength[this]; }
            set { Fields.ItemGroupLotNoLength[this] = value; }
        }

        [DisplayName("Item Group Serial No Length"), Expression("jItemGroup.[SERIAL_NO_LENGTH]")]
        public Decimal? ItemGroupSerialNoLength
        {
            get { return Fields.ItemGroupSerialNoLength[this]; }
            set { Fields.ItemGroupSerialNoLength[this] = value; }
        }

        [DisplayName("Item Group Next Lot No"), Expression("jItemGroup.[NEXT_LOT_NO]")]
        public Decimal? ItemGroupNextLotNo
        {
            get { return Fields.ItemGroupNextLotNo[this]; }
            set { Fields.ItemGroupNextLotNo[this] = value; }
        }

        [DisplayName("Item Group Next Serial No"), Expression("jItemGroup.[NEXT_SERIAL_NO]")]
        public Decimal? ItemGroupNextSerialNo
        {
            get { return Fields.ItemGroupNextSerialNo[this]; }
            set { Fields.ItemGroupNextSerialNo[this] = value; }
        }

        [DisplayName("Item Group Max Lot Size"), Expression("jItemGroup.[MAX_LOT_SIZE]")]
        public Decimal? ItemGroupMaxLotSize
        {
            get { return Fields.ItemGroupMaxLotSize[this]; }
            set { Fields.ItemGroupMaxLotSize[this] = value; }
        }

        [DisplayName("Item Group Lot No Prefix"), Expression("jItemGroup.[LOT_NO_PREFIX]")]
        public String ItemGroupLotNoPrefix
        {
            get { return Fields.ItemGroupLotNoPrefix[this]; }
            set { Fields.ItemGroupLotNoPrefix[this] = value; }
        }

        [DisplayName("Item Group Serial No Prefix"), Expression("jItemGroup.[SERIAL_NO_PREFIX]")]
        public String ItemGroupSerialNoPrefix
        {
            get { return Fields.ItemGroupSerialNoPrefix[this]; }
            set { Fields.ItemGroupSerialNoPrefix[this] = value; }
        }

        [DisplayName("Item Group Devt Cat01"), Expression("jItemGroup.[DEVT_CAT01]")]
        public String ItemGroupDevtCat01
        {
            get { return Fields.ItemGroupDevtCat01[this]; }
            set { Fields.ItemGroupDevtCat01[this] = value; }
        }

        [DisplayName("Item Group Devt Cat02"), Expression("jItemGroup.[DEVT_CAT02]")]
        public String ItemGroupDevtCat02
        {
            get { return Fields.ItemGroupDevtCat02[this]; }
            set { Fields.ItemGroupDevtCat02[this] = value; }
        }

        [DisplayName("Item Group Devt Cat03"), Expression("jItemGroup.[DEVT_CAT03]")]
        public String ItemGroupDevtCat03
        {
            get { return Fields.ItemGroupDevtCat03[this]; }
            set { Fields.ItemGroupDevtCat03[this] = value; }
        }

        [DisplayName("Item Group Devt Cat04"), Expression("jItemGroup.[DEVT_CAT04]")]
        public String ItemGroupDevtCat04
        {
            get { return Fields.ItemGroupDevtCat04[this]; }
            set { Fields.ItemGroupDevtCat04[this] = value; }
        }

        [DisplayName("Item Group Devt Cat05"), Expression("jItemGroup.[DEVT_CAT05]")]
        public String ItemGroupDevtCat05
        {
            get { return Fields.ItemGroupDevtCat05[this]; }
            set { Fields.ItemGroupDevtCat05[this] = value; }
        }

        [DisplayName("Item Group Devt Cat06"), Expression("jItemGroup.[DEVT_CAT06]")]
        public String ItemGroupDevtCat06
        {
            get { return Fields.ItemGroupDevtCat06[this]; }
            set { Fields.ItemGroupDevtCat06[this] = value; }
        }

        [DisplayName("Item Group Devt Cat07"), Expression("jItemGroup.[DEVT_CAT07]")]
        public String ItemGroupDevtCat07
        {
            get { return Fields.ItemGroupDevtCat07[this]; }
            set { Fields.ItemGroupDevtCat07[this] = value; }
        }

        [DisplayName("Item Group Devt Cat08"), Expression("jItemGroup.[DEVT_CAT08]")]
        public String ItemGroupDevtCat08
        {
            get { return Fields.ItemGroupDevtCat08[this]; }
            set { Fields.ItemGroupDevtCat08[this] = value; }
        }

        [DisplayName("Item Group Devt Cat09"), Expression("jItemGroup.[DEVT_CAT09]")]
        public String ItemGroupDevtCat09
        {
            get { return Fields.ItemGroupDevtCat09[this]; }
            set { Fields.ItemGroupDevtCat09[this] = value; }
        }

        [DisplayName("Item Group Devt Cat10"), Expression("jItemGroup.[DEVT_CAT10]")]
        public String ItemGroupDevtCat10
        {
            get { return Fields.ItemGroupDevtCat10[this]; }
            set { Fields.ItemGroupDevtCat10[this] = value; }
        }

        [DisplayName("Item Group Devt Cat11"), Expression("jItemGroup.[DEVT_CAT11]")]
        public String ItemGroupDevtCat11
        {
            get { return Fields.ItemGroupDevtCat11[this]; }
            set { Fields.ItemGroupDevtCat11[this] = value; }
        }

        [DisplayName("Item Group Devt Cat12"), Expression("jItemGroup.[DEVT_CAT12]")]
        public String ItemGroupDevtCat12
        {
            get { return Fields.ItemGroupDevtCat12[this]; }
            set { Fields.ItemGroupDevtCat12[this] = value; }
        }

        [DisplayName("Item Group Devt Cat13"), Expression("jItemGroup.[DEVT_CAT13]")]
        public String ItemGroupDevtCat13
        {
            get { return Fields.ItemGroupDevtCat13[this]; }
            set { Fields.ItemGroupDevtCat13[this] = value; }
        }

        [DisplayName("Item Group Devt Cat14"), Expression("jItemGroup.[DEVT_CAT14]")]
        public String ItemGroupDevtCat14
        {
            get { return Fields.ItemGroupDevtCat14[this]; }
            set { Fields.ItemGroupDevtCat14[this] = value; }
        }

        [DisplayName("Item Group Devt Cat15"), Expression("jItemGroup.[DEVT_CAT15]")]
        public String ItemGroupDevtCat15
        {
            get { return Fields.ItemGroupDevtCat15[this]; }
            set { Fields.ItemGroupDevtCat15[this] = value; }
        }

        [DisplayName("Item Group Devt Cat16"), Expression("jItemGroup.[DEVT_CAT16]")]
        public String ItemGroupDevtCat16
        {
            get { return Fields.ItemGroupDevtCat16[this]; }
            set { Fields.ItemGroupDevtCat16[this] = value; }
        }

        [DisplayName("Item Group Devt Cat17"), Expression("jItemGroup.[DEVT_CAT17]")]
        public String ItemGroupDevtCat17
        {
            get { return Fields.ItemGroupDevtCat17[this]; }
            set { Fields.ItemGroupDevtCat17[this] = value; }
        }

        [DisplayName("Item Group Devt Cat18"), Expression("jItemGroup.[DEVT_CAT18]")]
        public String ItemGroupDevtCat18
        {
            get { return Fields.ItemGroupDevtCat18[this]; }
            set { Fields.ItemGroupDevtCat18[this] = value; }
        }

        [DisplayName("Item Group Devt Cat19"), Expression("jItemGroup.[DEVT_CAT19]")]
        public String ItemGroupDevtCat19
        {
            get { return Fields.ItemGroupDevtCat19[this]; }
            set { Fields.ItemGroupDevtCat19[this] = value; }
        }

        [DisplayName("Item Group Devt Cat20"), Expression("jItemGroup.[DEVT_CAT20]")]
        public String ItemGroupDevtCat20
        {
            get { return Fields.ItemGroupDevtCat20[this]; }
            set { Fields.ItemGroupDevtCat20[this] = value; }
        }

        [DisplayName("Item Group Main Loc"), Expression("jItemGroup.[MAIN_LOC]")]
        public String ItemGroupMainLoc
        {
            get { return Fields.ItemGroupMainLoc[this]; }
            set { Fields.ItemGroupMainLoc[this] = value; }
        }

        [DisplayName("Item Group Main Bin"), Expression("jItemGroup.[MAIN_BIN]")]
        public String ItemGroupMainBin
        {
            get { return Fields.ItemGroupMainBin[this]; }
            set { Fields.ItemGroupMainBin[this] = value; }
        }

        [DisplayName("Item Group With Reset Lot"), Expression("jItemGroup.[WITH_RESET_LOT]")]
        public String ItemGroupWithResetLot
        {
            get { return Fields.ItemGroupWithResetLot[this]; }
            set { Fields.ItemGroupWithResetLot[this] = value; }
        }

        [DisplayName("Item Group With Reset Serial"), Expression("jItemGroup.[WITH_RESET_SERIAL]")]
        public String ItemGroupWithResetSerial
        {
            get { return Fields.ItemGroupWithResetSerial[this]; }
            set { Fields.ItemGroupWithResetSerial[this] = value; }
        }

        [DisplayName("Item Group Prev Reset Lot Date"), Expression("jItemGroup.[PREV_RESET_LOT_DATE]")]
        public DateTime? ItemGroupPrevResetLotDate
        {
            get { return Fields.ItemGroupPrevResetLotDate[this]; }
            set { Fields.ItemGroupPrevResetLotDate[this] = value; }
        }

        [DisplayName("Item Group Prev Reset Serial Date"), Expression("jItemGroup.[PREV_RESET_SERIAL_DATE]")]
        public DateTime? ItemGroupPrevResetSerialDate
        {
            get { return Fields.ItemGroupPrevResetSerialDate[this]; }
            set { Fields.ItemGroupPrevResetSerialDate[this] = value; }
        }

        [DisplayName("Item Group Bom Rohs Control"), Expression("jItemGroup.[BOM_ROHS_CONTROL]")]
        public Boolean? ItemGroupBomRohsControl
        {
            get { return Fields.ItemGroupBomRohsControl[this]; }
            set { Fields.ItemGroupBomRohsControl[this] = value; }
        }

        [DisplayName("Item Group Anlys5"), Expression("jItemGroup.[ANLYS5]")]
        public String ItemGroupAnlys5
        {
            get { return Fields.ItemGroupAnlys5[this]; }
            set { Fields.ItemGroupAnlys5[this] = value; }
        }

        [DisplayName("Item Group Anlys6"), Expression("jItemGroup.[ANLYS6]")]
        public String ItemGroupAnlys6
        {
            get { return Fields.ItemGroupAnlys6[this]; }
            set { Fields.ItemGroupAnlys6[this] = value; }
        }

        [DisplayName("Item Group Anlys7"), Expression("jItemGroup.[ANLYS7]")]
        public String ItemGroupAnlys7
        {
            get { return Fields.ItemGroupAnlys7[this]; }
            set { Fields.ItemGroupAnlys7[this] = value; }
        }

        [DisplayName("Item Group Anlys8"), Expression("jItemGroup.[ANLYS8]")]
        public String ItemGroupAnlys8
        {
            get { return Fields.ItemGroupAnlys8[this]; }
            set { Fields.ItemGroupAnlys8[this] = value; }
        }

        [DisplayName("Item Group Anlys9"), Expression("jItemGroup.[ANLYS9]")]
        public String ItemGroupAnlys9
        {
            get { return Fields.ItemGroupAnlys9[this]; }
            set { Fields.ItemGroupAnlys9[this] = value; }
        }

        [DisplayName("Item Group Anlys10"), Expression("jItemGroup.[ANLYS10]")]
        public String ItemGroupAnlys10
        {
            get { return Fields.ItemGroupAnlys10[this]; }
            set { Fields.ItemGroupAnlys10[this] = value; }
        }

        [DisplayName("Item Group Autogen Lot"), Expression("jItemGroup.[AUTOGEN_LOT]")]
        public Boolean? ItemGroupAutogenLot
        {
            get { return Fields.ItemGroupAutogenLot[this]; }
            set { Fields.ItemGroupAutogenLot[this] = value; }
        }

        [DisplayName("Item Group Autogen Serial"), Expression("jItemGroup.[AUTOGEN_SERIAL]")]
        public Boolean? ItemGroupAutogenSerial
        {
            get { return Fields.ItemGroupAutogenSerial[this]; }
            set { Fields.ItemGroupAutogenSerial[this] = value; }
        }

        [DisplayName("Item Group No Scrap In Mat Issue"), Expression("jItemGroup.[NO_SCRAP_IN_MAT_ISSUE]")]
        public Boolean? ItemGroupNoScrapInMatIssue
        {
            get { return Fields.ItemGroupNoScrapInMatIssue[this]; }
            set { Fields.ItemGroupNoScrapInMatIssue[this] = value; }
        }

        [DisplayName("Item Group Autogen Lot Issue"), Expression("jItemGroup.[AUTOGEN_LOT_ISSUE]")]
        public Boolean? ItemGroupAutogenLotIssue
        {
            get { return Fields.ItemGroupAutogenLotIssue[this]; }
            set { Fields.ItemGroupAutogenLotIssue[this] = value; }
        }

        [DisplayName("Item Group Autogen Serial Issue"), Expression("jItemGroup.[AUTOGEN_SERIAL_ISSUE]")]
        public Boolean? ItemGroupAutogenSerialIssue
        {
            get { return Fields.ItemGroupAutogenSerialIssue[this]; }
            set { Fields.ItemGroupAutogenSerialIssue[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ItemNo; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ItemNo; }
        }

        [Expression("T0.[Item_No] + ' ' + T0.[Description]")]
        public String LookupDescription
        {
            get { return Fields.LookupDescription[this]; }
            set { Fields.LookupDescription[this] = value; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ItemRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField LookupDescription;

            public DecimalField Recnum;
            public StringField ItemNo;
            public StringField Description;
            public BooleanField Suspended;
            public StringField ItemGroup;
            public StringField Charges;
            public BooleanField Product;
            public BooleanField Material;
            public StringField Inspected;
            public StringField ItemType;
            public StringField StockUom;
            public StringField MainLoc;
            public BooleanField MakeBuy;
            public StringField AllocMethod;
            public StringField StdCostOk;
            public StringField CostCentre;
            public StringField CycleCode;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField Anlys3;
            public StringField Anlys4;
            public StringField DefSpecNo;
            public DecimalField DefSpecCount;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public StringField WithBacklog;
            public StringField WithBalance;
            public DecimalField QtyOnHand;
            public DecimalField QtyOnSorder;
            public DecimalField QtyOnPorder;
            public DecimalField QtyOnJorder;
            public DecimalField QtyOnInspect;
            public DecimalField QtyWaitlisted;
            public DecimalField QtyReserved;
            public DecimalField QtyCommitted;
            public DecimalField QtyAvailable;
            public DecimalField QtyUnallocated;
            public DecimalField InvtCostAvail;
            public DecimalField InvtCostLdg;
            public StringField AverageCost;
            public DecimalField LatestCost;
            public DecimalField StdCost;
            public DateTimeField LastCountDate;
            public DateTimeField LastDateIn;
            public DateTimeField LastDateOut;
            public StringField SalesUom;
            public DecimalField SalesLotSize;
            public StringField PriceCcy;
            public DecimalField BasePrice;
            public DecimalField Pricea;
            public DecimalField Priceb;
            public DecimalField Pricec;
            public DecimalField MinPrice;
            public DecimalField MaxPrice;
            public DecimalField MinOrderQty;
            public DecimalField MaxOrderQty;
            public DecimalField MinOrderDays;
            public StringField InnerPkgType;
            public DecimalField InnerQty;
            public StringField OuterPkgType;
            public DecimalField OuterQty;
            public StringField ArticleCode;
            public StringField QuotaCategory;
            public StringField WeightUom;
            public DecimalField GrossWt;
            public DecimalField NetWt;
            public StringField DimensionUom;
            public DecimalField Flength;
            public DecimalField Width;
            public DecimalField Height;
            public DecimalField ComputedVol;
            public DecimalField DeclaredVol;
            public DateTimeField SrevisedDate;
            public StringField SrevisedBy;
            public StringField MpsItem;
            public StringField OrderPolicy;
            public DecimalField MinPlanordQty;
            public DecimalField MaxPlanordQty;
            public DecimalField StdPlanordQty;
            public DecimalField MinPlanordPrd;
            public DecimalField MaxPlanordPrd;
            public DecimalField StdPlanordPrd;
            public DecimalField ReorderPt;
            public DecimalField ReorderQty;
            public DecimalField MinMthlyProd;
            public DecimalField MaxMthlyProd;
            public DecimalField MinMthlyPur;
            public DecimalField MaxMthlyPur;
            public StringField FollowMinProd;
            public StringField FollowMaxProd;
            public StringField FollowMinPur;
            public StringField FollowMaxPur;
            public StringField AllowMixMode;
            public StringField PrefVendOnly;
            public StringField PrefVend1;
            public StringField PrefVend2;
            public DecimalField ProdLeadTime;
            public StringField ProdLeadUnit;
            public DecimalField PurLeadTime;
            public StringField PurLeadUnit;
            public StringField Planner;
            public DateTimeField MrpParmDate;
            public StringField MrpParmBy;
            public StringField AltDescription;
            public StringField PictureFile;
            public StringField AcctItmAsset;
            public StringField AcctItmWip;
            public StringField AcctItmConsum;
            public StringField AcctItmScrap;
            public StringField AcctItmPvar;
            public StringField AcctItmReval;
            public StringField AcctItmVaria;
            public StringField AcctItmSales;
            public StringField AcctItmSlret;
            public StringField AcctItmSldisc;
            public StringField AcctItmCogs;
            public StringField AcctItmPurch;
            public StringField AcctItmPuret;
            public StringField AcctItmPudisc;
            public StringField AcctItmPutax;
            public StringField AcctMachine;
            public StringField AcctEnergy;
            public StringField AcctWater;
            public StringField AcctRental;
            public StringField AcctLabor;
            public StringField AcctInlab;
            public StringField AcctInmat;
            public StringField AcctMisc;
            public DateTimeField ArevisedDate;
            public StringField ArevisedBy;
            public DateTimeField BrevisedDate;
            public StringField BrevisedBy;
            public StringField SalesLtaxCode;
            public StringField PurchLtaxCode;
            public DateTimeField TrevisedDate;
            public StringField TrevisedBy;
            public DecimalField SpecsCount;
            public StringField DefBomNo;
            public DecimalField LastSnapNo;
            public StringField CommisType;
            public StringField ProdBranch;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public DecimalField ScrapRate;
            public StringField AltExtDesc;
            public StringField ExtendedDesc;
            public StringField PurPriceCtrl;
            public DecimalField PurMaxDev;
            public StringField WebItem;
            public StringField AcctItmSubcon;
            public StringField WithBinCtrl;
            public StringField Consign;
            public StringField ProdDevt01;
            public StringField ProdDevt02;
            public StringField ProdDevt03;
            public StringField ProdDevt04;
            public StringField ProdDevt05;
            public StringField ProdDevt06;
            public StringField ProdDevt07;
            public StringField ProdDevt08;
            public StringField ProdDevt09;
            public StringField ProdDevt10;
            public StringField ProdDevt11;
            public StringField ProdDevt12;
            public StringField ProdDevt13;
            public StringField ProdDevt14;
            public StringField ProdDevt15;
            public StringField ProdDevt16;
            public StringField ProdDevt17;
            public StringField ProdDevt18;
            public StringField ProdDevt19;
            public StringField ProdDevt20;
            public StringField ProdCheck01;
            public StringField ProdCheck02;
            public StringField ProdCheck03;
            public StringField ProdCheck04;
            public StringField ProdCheck05;
            public StringField ProdCheck06;
            public StringField ProdCheck07;
            public StringField ProdCheck08;
            public StringField ProdCheck09;
            public StringField ProdCheck10;
            public StringField ProdCheck11;
            public StringField ProdCheck12;
            public StringField ProdCheck13;
            public StringField ProdCheck14;
            public StringField ProdCheck15;
            public StringField ProdCheck16;
            public StringField ProdCheck17;
            public StringField ProdCheck18;
            public StringField ProdCheck19;
            public StringField ProdCheck20;
            public DecimalField LastPackLineNo;
            public DecimalField PutaxPcent;
            public StringField AcctItmSltax;
            public DecimalField SltaxPcent;
            public StringField PurUom;
            public DecimalField PurLotSize;
            public StringField PurCcy;
            public DecimalField PurBasePrice;
            public DecimalField QtyNetAvailable;
            public StringField UseStdProdLeadTime;
            public DecimalField DailyProdQty;
            public DecimalField IssueLotSize;
            public StringField MrpExclude;
            public StringField EnableLot;
            public StringField EnableSerial;
            public DecimalField LotNoLength;
            public DecimalField SerialNoLength;
            public DecimalField NextLotNo;
            public DecimalField NextSerialNo;
            public DecimalField MaxLotSize;
            public StringField LotNoPrefix;
            public StringField SerialNoPrefix;
            public DecimalField SafeStockLvl;
            public StringField MainBin;
            public StringField CustomProdCode;
            public DecimalField CustomLotSize;
            public StringField CustomGrUom;
            public DecimalField CustomGrWt;
            public DecimalField CustomNtWt;
            public StringField CustomOrigin;
            public StringField IsApproved;
            public StringField ApprovedBy;
            public StringField Preapprove;
            public DateTimeField ApprovedDate;
            public DecimalField QtyOnTransfer;
            public StringField WithResetLot;
            public StringField WithResetSerial;
            public DateTimeField PrevResetLotDate;
            public DateTimeField PrevResetSerialDate;
            public StringField AutogenLot;
            public StringField AutogenSerial;
            public StringField FabItem;
            public StringField Anlys5;
            public StringField Anlys6;
            public StringField Anlys7;
            public StringField Anlys8;
            public StringField Anlys9;
            public StringField Anlys10;
            public StringField UserDefinedField1;
            public StringField UserDefinedField2;
            public StringField UserDefinedField3;
            public StringField UserDefinedField4;
            public StringField UserDefinedField5;
            public StringField UserDefinedField6;
            public StringField UserDefinedField7;
            public StringField UserDefinedField8;
            public StringField UserDefinedField9;
            public StringField UserDefinedField10;
            public StringField UserDefinedField11;
            public StringField UserDefinedField12;
            public StringField UserDefinedField13;
            public StringField UserDefinedField14;
            public StringField UserDefinedField15;
            public StringField UserDefinedField16;
            public StringField UserDefinedField17;
            public StringField UserDefinedField18;
            public StringField UserDefinedField19;
            public StringField UserDefinedField20;
            public BooleanField RohsCompliance;
            public StringField DefMoldBomNo;
            public StringField DefFormulaCode;
            public StringField BoxType;
            public DecimalField BoxLength;
            public DecimalField BoxWidth;
            public DecimalField BoxHeight;
            public StringField BoxDUom;
            public DecimalField Wd;
            public StringField WdUom;
            public DecimalField CsLength;
            public DecimalField CsWidth;
            public StringField UserDefinedField21;
            public DecimalField CostWmove;
            public DecimalField CostWcase;
            public DecimalField CostWband;
            public DecimalField CostBatt;
            public StringField DescWmove;
            public StringField DescWcase;
            public StringField DescWband;
            public StringField DescBatt;
            public DecimalField PoBal;
            public DecimalField PoMaxBal;
            public BooleanField IncludeJob;
            public DecimalField CsThickness;
            public StringField CsThicknessUom;
            public DecimalField CsProportion;
            public StringField CsProportionUom;
            public DecimalField DieCutter;
            public DecimalField MatInspectLeadTime;
            public DecimalField MatPrepareLeadTime;
            public StringField MatInspectLeadUnit;
            public StringField MatPrepareLeadUnit;
            public StringField ColorCode;
            public StringField CollectionCode;
            public StringField StyleCode;
            public DecimalField X;
            public DecimalField Y;
            public StringField TempDescription;
            public StringField Specification;
            public StringField XUom;
            public StringField YUom;
            public DecimalField ProductionUomConversionRate;
            public DecimalField PurchaseUomConversionRate;
            public BooleanField AutogenLotIssue;
            public BooleanField AutogenSerialIssue;
            public StringField WcCostCcy;
            public DecimalField WcCost;
            public DecimalField WcCostDisc;
            public DecimalField WcCostExch;
            public DecimalField WcFreight;
            public DecimalField WcMargin;
            public DecimalField CeilingPrice;
            public DecimalField BottomRatio;
            public DecimalField BottomPrice;
            public StringField DrawingNo;
            public StringField MaterialType;

            public DecimalField ItemGroupRecnum;
            public StringField ItemGroupDescription;
            public StringField ItemGroupSuspended;
            public StringField ItemGroupProduct;
            public StringField ItemGroupMaterial;
            public StringField ItemGroupInspected;
            public StringField ItemGroupCostCentre;
            public StringField ItemGroupItemType;
            public StringField ItemGroupAllocMethod;
            public StringField ItemGroupProdBranch;
            public StringField ItemGroupAcctItmAsset;
            public StringField ItemGroupAcctItmWip;
            public StringField ItemGroupAcctItmConsum;
            public StringField ItemGroupAcctItmScrap;
            public StringField ItemGroupAcctItmPvar;
            public StringField ItemGroupAcctItmReval;
            public StringField ItemGroupAcctItmVaria;
            public StringField ItemGroupAcctItmSales;
            public StringField ItemGroupAcctItmSlret;
            public StringField ItemGroupAcctItmSldisc;
            public StringField ItemGroupAcctItmCogs;
            public StringField ItemGroupAcctItmPurch;
            public StringField ItemGroupAcctItmPuret;
            public StringField ItemGroupAcctItmPudisc;
            public StringField ItemGroupAcctItmPutax;
            public StringField ItemGroupAcctMachine;
            public StringField ItemGroupAcctEnergy;
            public StringField ItemGroupAcctWater;
            public StringField ItemGroupAcctRental;
            public StringField ItemGroupAcctLabor;
            public StringField ItemGroupAcctInlab;
            public StringField ItemGroupAcctInmat;
            public StringField ItemGroupAcctMisc;
            public DateTimeField ItemGroupArevisedDate;
            public StringField ItemGroupArevisedBy;
            public DateTimeField ItemGroupBrevisedDate;
            public StringField ItemGroupBrevisedBy;
            public StringField ItemGroupMakeOrBuy;
            public StringField ItemGroupTypicalUom;
            public StringField ItemGroupCycleCode;
            public StringField ItemGroupSalesLtaxCode;
            public StringField ItemGroupPurchLtaxCode;
            public StringField ItemGroupInnerPkgType;
            public DecimalField ItemGroupInnerQty;
            public StringField ItemGroupOuterPkgType;
            public DecimalField ItemGroupOuterQty;
            public StringField ItemGroupAnlys1;
            public StringField ItemGroupAnlys2;
            public StringField ItemGroupAnlys3;
            public StringField ItemGroupAnlys4;
            public DecimalField ItemGroupItemCount;
            public DateTimeField ItemGroupCreatedDate;
            public StringField ItemGroupCreatedBy;
            public DateTimeField ItemGroupRevisedDate;
            public StringField ItemGroupRevisedBy;
            public DateTimeField ItemGroupTrevisedDate;
            public StringField ItemGroupTrevisedBy;
            public StringField ItemGroupCommisType;
            public StringField ItemGroupOwnerBranch;
            public StringField ItemGroupSourceBranch;
            public DecimalField ItemGroupScrapRate;
            public StringField ItemGroupPurPriceCtrl;
            public DecimalField ItemGroupPurMaxDev;
            public StringField ItemGroupAcctItmSubcon;
            public StringField ItemGroupConsolidate;
            public DecimalField ItemGroupPutaxPcent;
            public StringField ItemGroupAcctItmSltax;
            public DecimalField ItemGroupSltaxPcent;
            public StringField ItemGroupEnableLot;
            public StringField ItemGroupEnableSerial;
            public DecimalField ItemGroupLotNoLength;
            public DecimalField ItemGroupSerialNoLength;
            public DecimalField ItemGroupNextLotNo;
            public DecimalField ItemGroupNextSerialNo;
            public DecimalField ItemGroupMaxLotSize;
            public StringField ItemGroupLotNoPrefix;
            public StringField ItemGroupSerialNoPrefix;
            public StringField ItemGroupDevtCat01;
            public StringField ItemGroupDevtCat02;
            public StringField ItemGroupDevtCat03;
            public StringField ItemGroupDevtCat04;
            public StringField ItemGroupDevtCat05;
            public StringField ItemGroupDevtCat06;
            public StringField ItemGroupDevtCat07;
            public StringField ItemGroupDevtCat08;
            public StringField ItemGroupDevtCat09;
            public StringField ItemGroupDevtCat10;
            public StringField ItemGroupDevtCat11;
            public StringField ItemGroupDevtCat12;
            public StringField ItemGroupDevtCat13;
            public StringField ItemGroupDevtCat14;
            public StringField ItemGroupDevtCat15;
            public StringField ItemGroupDevtCat16;
            public StringField ItemGroupDevtCat17;
            public StringField ItemGroupDevtCat18;
            public StringField ItemGroupDevtCat19;
            public StringField ItemGroupDevtCat20;
            public StringField ItemGroupMainLoc;
            public StringField ItemGroupMainBin;
            public StringField ItemGroupWithResetLot;
            public StringField ItemGroupWithResetSerial;
            public DateTimeField ItemGroupPrevResetLotDate;
            public DateTimeField ItemGroupPrevResetSerialDate;
            public BooleanField ItemGroupBomRohsControl;
            public StringField ItemGroupAnlys5;
            public StringField ItemGroupAnlys6;
            public StringField ItemGroupAnlys7;
            public StringField ItemGroupAnlys8;
            public StringField ItemGroupAnlys9;
            public StringField ItemGroupAnlys10;
            public BooleanField ItemGroupAutogenLot;
            public BooleanField ItemGroupAutogenSerial;
            public BooleanField ItemGroupNoScrapInMatIssue;
            public BooleanField ItemGroupAutogenLotIssue;
            public BooleanField ItemGroupAutogenSerialIssue;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.Item";
            }
        }
    }
}
