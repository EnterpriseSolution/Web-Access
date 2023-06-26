#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  InventoryBalanceRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Inventory.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Inventory"), TableName("[dbo].[ICBALN]")]
    [DisplayName("Inventory Balance"), InstanceName("Inventory Balance"), TwoLevelCached]   
    public sealed class InventoryBalanceRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Loc"), Column("LOC"), Size(4), PrimaryKey, ForeignKey("[dbo].[GBLOCN]", "LOC"), LeftJoin("jLoc"), QuickSearch, TextualField("LocDescription")]
        public String Loc
        {
            get { return Fields.Loc[this]; }
            set { Fields.Loc[this] = value; }
        }

        [DisplayName("Item No"), Column("ITEM_NO"), Size(30), PrimaryKey, ForeignKey("[dbo].[GBITEM]", "ITEM_NO"), LeftJoin("jItemNo"), TextualField("ItemNoDescription")]
        public String ItemNo
        {
            get { return Fields.ItemNo[this]; }
            set { Fields.ItemNo[this] = value; }
        }

        [DisplayName("Loc 2"), Column("LOC_2"), Size(4), NotNull]
        public String Loc2
        {
            get { return Fields.Loc2[this]; }
            set { Fields.Loc2[this] = value; }
        }

        [DisplayName("Item No 2"), Column("ITEM_NO_2"), Size(30), NotNull]
        public String ItemNo2
        {
            get { return Fields.ItemNo2[this]; }
            set { Fields.ItemNo2[this] = value; }
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

        [DisplayName("Qty Waitlisted"), Column("QTY_WAITLISTED"), Size(16), Scale(4)]
        [DisplayFormat("###,###,###,##0.####")]
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
        [DisplayFormat("###,###,###,##0.####")]
        public Decimal? QtyCommitted
        {
            get { return Fields.QtyCommitted[this]; }
            set { Fields.QtyCommitted[this] = value; }
        }

        [DisplayName("Qty Available"), Column("QTY_AVAILABLE"), Size(16), Scale(4)]
        [DisplayFormat("###,###,###,##0.####")]
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
        [DisplayFormat("###,###,###,##0.##")]
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
        //[DisplayFormat("#,##0.####")]
        public String AverageCost
        {
            get { return Fields.AverageCost[this]; }
            set { Fields.AverageCost[this] = value; }
        }

        [DisplayFormat("###,###,###,##0.######")]
        [DisplayName("Latest Cost"), Column("LATEST_COST"), Size(18), Scale(6)]
        public Decimal? LatestCost
        {
            get { return Fields.LatestCost[this]; }
            set { Fields.LatestCost[this] = value; }
        }

        [DisplayName("Last Count Date"), Column("LAST_COUNT_DATE")]
        public DateTime? LastCountDate
        {
            get { return Fields.LastCountDate[this]; }
            set { Fields.LastCountDate[this] = value; }
        }

        [DisplayName("Default Bin No"), Column("DEFAULT_BIN_NO"), Size(30)]
        public String DefaultBinNo
        {
            get { return Fields.DefaultBinNo[this]; }
            set { Fields.DefaultBinNo[this] = value; }
        }

        [DisplayName("Qty On Inspect"), Column("QTY_ON_INSPECT"), Size(16), Scale(4)]
        public Decimal? QtyOnInspect
        {
            get { return Fields.QtyOnInspect[this]; }
            set { Fields.QtyOnInspect[this] = value; }
        }

        [DisplayName("Qty On Transfer"), Column("QTY_ON_TRANSFER"), Size(16), Scale(4)]
        public Decimal? QtyOnTransfer
        {
            get { return Fields.QtyOnTransfer[this]; }
            set { Fields.QtyOnTransfer[this] = value; }
        }

        [DisplayName("Loc Recnum"), Expression("jLoc.[RECNUM]")]
        public Decimal? LocRecnum
        {
            get { return Fields.LocRecnum[this]; }
            set { Fields.LocRecnum[this] = value; }
        }

        [DisplayName("Loc Description"), Expression("jLoc.[DESCRIPTION]")]
        public String LocDescription
        {
            get { return Fields.LocDescription[this]; }
            set { Fields.LocDescription[this] = value; }
        }

        [DisplayName("Loc Suspended"), Expression("jLoc.[SUSPENDED]")]
        public String LocSuspended
        {
            get { return Fields.LocSuspended[this]; }
            set { Fields.LocSuspended[this] = value; }
        }

        [DisplayName("Loc Address"), Expression("jLoc.[ADDRESS]")]
        public String LocAddress
        {
            get { return Fields.LocAddress[this]; }
            set { Fields.LocAddress[this] = value; }
        }

        [DisplayName("Loc Address2"), Expression("jLoc.[ADDRESS2]")]
        public String LocAddress2
        {
            get { return Fields.LocAddress2[this]; }
            set { Fields.LocAddress2[this] = value; }
        }

        [DisplayName("Loc Address3"), Expression("jLoc.[ADDRESS3]")]
        public String LocAddress3
        {
            get { return Fields.LocAddress3[this]; }
            set { Fields.LocAddress3[this] = value; }
        }

        [DisplayName("Loc Address4"), Expression("jLoc.[ADDRESS4]")]
        public String LocAddress4
        {
            get { return Fields.LocAddress4[this]; }
            set { Fields.LocAddress4[this] = value; }
        }

        [DisplayName("Loc Branch No"), Expression("jLoc.[BRANCH_NO]")]
        public String LocBranchNo
        {
            get { return Fields.LocBranchNo[this]; }
            set { Fields.LocBranchNo[this] = value; }
        }

        [DisplayName("Loc No Reservation"), Expression("jLoc.[NO_RESERVATION]")]
        public String LocNoReservation
        {
            get { return Fields.LocNoReservation[this]; }
            set { Fields.LocNoReservation[this] = value; }
        }

        [DisplayName("Loc No Waitlist"), Expression("jLoc.[NO_WAITLIST]")]
        public String LocNoWaitlist
        {
            get { return Fields.LocNoWaitlist[this]; }
            set { Fields.LocNoWaitlist[this] = value; }
        }

        [DisplayName("Loc No Available"), Expression("jLoc.[NO_AVAILABLE]")]
        public String LocNoAvailable
        {
            get { return Fields.LocNoAvailable[this]; }
            set { Fields.LocNoAvailable[this] = value; }
        }

        [DisplayName("Loc No Planning"), Expression("jLoc.[NO_PLANNING]")]
        public String LocNoPlanning
        {
            get { return Fields.LocNoPlanning[this]; }
            set { Fields.LocNoPlanning[this] = value; }
        }

        [DisplayName("Loc No Issuance"), Expression("jLoc.[NO_ISSUANCE]")]
        public String LocNoIssuance
        {
            get { return Fields.LocNoIssuance[this]; }
            set { Fields.LocNoIssuance[this] = value; }
        }

        [DisplayName("Loc No Receipts"), Expression("jLoc.[NO_RECEIPTS]")]
        public String LocNoReceipts
        {
            get { return Fields.LocNoReceipts[this]; }
            set { Fields.LocNoReceipts[this] = value; }
        }

        [DisplayName("Loc No Mat Issue"), Expression("jLoc.[NO_MAT_ISSUE]")]
        public String LocNoMatIssue
        {
            get { return Fields.LocNoMatIssue[this]; }
            set { Fields.LocNoMatIssue[this] = value; }
        }

        [DisplayName("Loc No Fg Return"), Expression("jLoc.[NO_FG_RETURN]")]
        public String LocNoFgReturn
        {
            get { return Fields.LocNoFgReturn[this]; }
            set { Fields.LocNoFgReturn[this] = value; }
        }

        [DisplayName("Loc No Shipment"), Expression("jLoc.[NO_SHIPMENT]")]
        public String LocNoShipment
        {
            get { return Fields.LocNoShipment[this]; }
            set { Fields.LocNoShipment[this] = value; }
        }

        [DisplayName("Loc No Grn"), Expression("jLoc.[NO_GRN]")]
        public String LocNoGrn
        {
            get { return Fields.LocNoGrn[this]; }
            set { Fields.LocNoGrn[this] = value; }
        }

        [DisplayName("Loc With Backlog"), Expression("jLoc.[WITH_BACKLOG]")]
        public String LocWithBacklog
        {
            get { return Fields.LocWithBacklog[this]; }
            set { Fields.LocWithBacklog[this] = value; }
        }

        [DisplayName("Loc On Sorder Count"), Expression("jLoc.[ON_SORDER_COUNT]")]
        public Decimal? LocOnSorderCount
        {
            get { return Fields.LocOnSorderCount[this]; }
            set { Fields.LocOnSorderCount[this] = value; }
        }

        [DisplayName("Loc On Porder Count"), Expression("jLoc.[ON_PORDER_COUNT]")]
        public Decimal? LocOnPorderCount
        {
            get { return Fields.LocOnPorderCount[this]; }
            set { Fields.LocOnPorderCount[this] = value; }
        }

        [DisplayName("Loc On Jorder Count"), Expression("jLoc.[ON_JORDER_COUNT]")]
        public Decimal? LocOnJorderCount
        {
            get { return Fields.LocOnJorderCount[this]; }
            set { Fields.LocOnJorderCount[this] = value; }
        }

        [DisplayName("Loc Invt Cost Avail"), Expression("jLoc.[INVT_COST_AVAIL]")]
        public Decimal? LocInvtCostAvail
        {
            get { return Fields.LocInvtCostAvail[this]; }
            set { Fields.LocInvtCostAvail[this] = value; }
        }

        [DisplayName("Loc Invt Cost Ldg"), Expression("jLoc.[INVT_COST_LDG]")]
        public Decimal? LocInvtCostLdg
        {
            get { return Fields.LocInvtCostLdg[this]; }
            set { Fields.LocInvtCostLdg[this] = value; }
        }

        [DisplayName("Loc Created Date"), Expression("jLoc.[CREATED_DATE]")]
        public DateTime? LocCreatedDate
        {
            get { return Fields.LocCreatedDate[this]; }
            set { Fields.LocCreatedDate[this] = value; }
        }

        [DisplayName("Loc Created By"), Expression("jLoc.[CREATED_BY]")]
        public String LocCreatedBy
        {
            get { return Fields.LocCreatedBy[this]; }
            set { Fields.LocCreatedBy[this] = value; }
        }

        [DisplayName("Loc Revised Date"), Expression("jLoc.[REVISED_DATE]")]
        public DateTime? LocRevisedDate
        {
            get { return Fields.LocRevisedDate[this]; }
            set { Fields.LocRevisedDate[this] = value; }
        }

        [DisplayName("Loc Revised By"), Expression("jLoc.[REVISED_BY]")]
        public String LocRevisedBy
        {
            get { return Fields.LocRevisedBy[this]; }
            set { Fields.LocRevisedBy[this] = value; }
        }

        [DisplayName("Loc Owner Branch"), Expression("jLoc.[OWNER_BRANCH]")]
        public String LocOwnerBranch
        {
            get { return Fields.LocOwnerBranch[this]; }
            set { Fields.LocOwnerBranch[this] = value; }
        }

        [DisplayName("Loc Source Branch"), Expression("jLoc.[SOURCE_BRANCH]")]
        public String LocSourceBranch
        {
            get { return Fields.LocSourceBranch[this]; }
            set { Fields.LocSourceBranch[this] = value; }
        }

        [DisplayName("Loc With Bin Ctrl"), Expression("jLoc.[WITH_BIN_CTRL]")]
        public String LocWithBinCtrl
        {
            get { return Fields.LocWithBinCtrl[this]; }
            set { Fields.LocWithBinCtrl[this] = value; }
        }

        [DisplayName("Loc With Packing Box"), Expression("jLoc.[WITH_PACKING_BOX]")]
        public Boolean? LocWithPackingBox
        {
            get { return Fields.LocWithPackingBox[this]; }
            set { Fields.LocWithPackingBox[this] = value; }
        }

        [DisplayName("Item No Recnum"), Expression("jItemNo.[RECNUM]")]
        public Decimal? ItemNoRecnum
        {
            get { return Fields.ItemNoRecnum[this]; }
            set { Fields.ItemNoRecnum[this] = value; }
        }

        [DisplayName("Item No Description"), Expression("jItemNo.[DESCRIPTION]")]
        public String ItemNoDescription
        {
            get { return Fields.ItemNoDescription[this]; }
            set { Fields.ItemNoDescription[this] = value; }
        }

        [DisplayName("Item No Suspended"), Expression("jItemNo.[SUSPENDED]")]
        public String ItemNoSuspended
        {
            get { return Fields.ItemNoSuspended[this]; }
            set { Fields.ItemNoSuspended[this] = value; }
        }

        [DisplayName("Item No Item Group"), Expression("jItemNo.[ITEM_GROUP]")]
        public String ItemNoItemGroup
        {
            get { return Fields.ItemNoItemGroup[this]; }
            set { Fields.ItemNoItemGroup[this] = value; }
        }

        [DisplayName("Item No Charges"), Expression("jItemNo.[CHARGES]")]
        public String ItemNoCharges
        {
            get { return Fields.ItemNoCharges[this]; }
            set { Fields.ItemNoCharges[this] = value; }
        }

        [DisplayName("Item No Product"), Expression("jItemNo.[PRODUCT]")]
        public String ItemNoProduct
        {
            get { return Fields.ItemNoProduct[this]; }
            set { Fields.ItemNoProduct[this] = value; }
        }

        [DisplayName("Item No Material"), Expression("jItemNo.[MATERIAL]")]
        public String ItemNoMaterial
        {
            get { return Fields.ItemNoMaterial[this]; }
            set { Fields.ItemNoMaterial[this] = value; }
        }

        [DisplayName("Item No Inspected"), Expression("jItemNo.[INSPECTED]")]
        public String ItemNoInspected
        {
            get { return Fields.ItemNoInspected[this]; }
            set { Fields.ItemNoInspected[this] = value; }
        }

        [DisplayName("Item No Item Type"), Expression("jItemNo.[ITEM_TYPE]")]
        public String ItemNoItemType
        {
            get { return Fields.ItemNoItemType[this]; }
            set { Fields.ItemNoItemType[this] = value; }
        }

        [DisplayName("Item No Stock Uom"), Expression("jItemNo.[STOCK_UOM]")]
        public String ItemNoStockUom
        {
            get { return Fields.ItemNoStockUom[this]; }
            set { Fields.ItemNoStockUom[this] = value; }
        }

        [DisplayName("Item No Main Loc"), Expression("jItemNo.[MAIN_LOC]")]
        public String ItemNoMainLoc
        {
            get { return Fields.ItemNoMainLoc[this]; }
            set { Fields.ItemNoMainLoc[this] = value; }
        }

        [DisplayName("Item No Make Buy"), Expression("jItemNo.[MAKE_BUY]")]
        public String ItemNoMakeBuy
        {
            get { return Fields.ItemNoMakeBuy[this]; }
            set { Fields.ItemNoMakeBuy[this] = value; }
        }

        [DisplayName("Item No Alloc Method"), Expression("jItemNo.[ALLOC_METHOD]")]
        public String ItemNoAllocMethod
        {
            get { return Fields.ItemNoAllocMethod[this]; }
            set { Fields.ItemNoAllocMethod[this] = value; }
        }

        [DisplayName("Item No Std Cost Ok"), Expression("jItemNo.[STD_COST_OK]")]
        public String ItemNoStdCostOk
        {
            get { return Fields.ItemNoStdCostOk[this]; }
            set { Fields.ItemNoStdCostOk[this] = value; }
        }

        [DisplayName("Item No Cost Centre"), Expression("jItemNo.[COST_CENTRE]")]
        public String ItemNoCostCentre
        {
            get { return Fields.ItemNoCostCentre[this]; }
            set { Fields.ItemNoCostCentre[this] = value; }
        }

        [DisplayName("Item No Cycle Code"), Expression("jItemNo.[CYCLE_CODE]")]
        public String ItemNoCycleCode
        {
            get { return Fields.ItemNoCycleCode[this]; }
            set { Fields.ItemNoCycleCode[this] = value; }
        }

        [DisplayName("Item No Anlys1"), Expression("jItemNo.[ANLYS1]")]
        public String ItemNoAnlys1
        {
            get { return Fields.ItemNoAnlys1[this]; }
            set { Fields.ItemNoAnlys1[this] = value; }
        }

        [DisplayName("Item No Anlys2"), Expression("jItemNo.[ANLYS2]")]
        public String ItemNoAnlys2
        {
            get { return Fields.ItemNoAnlys2[this]; }
            set { Fields.ItemNoAnlys2[this] = value; }
        }

        [DisplayName("Item No Anlys3"), Expression("jItemNo.[ANLYS3]")]
        public String ItemNoAnlys3
        {
            get { return Fields.ItemNoAnlys3[this]; }
            set { Fields.ItemNoAnlys3[this] = value; }
        }

        [DisplayName("Item No Anlys4"), Expression("jItemNo.[ANLYS4]")]
        public String ItemNoAnlys4
        {
            get { return Fields.ItemNoAnlys4[this]; }
            set { Fields.ItemNoAnlys4[this] = value; }
        }

        [DisplayName("Item No Def Spec No"), Expression("jItemNo.[DEF_SPEC_NO]")]
        public String ItemNoDefSpecNo
        {
            get { return Fields.ItemNoDefSpecNo[this]; }
            set { Fields.ItemNoDefSpecNo[this] = value; }
        }

        [DisplayName("Item No Def Spec Count"), Expression("jItemNo.[DEF_SPEC_COUNT]")]
        public Decimal? ItemNoDefSpecCount
        {
            get { return Fields.ItemNoDefSpecCount[this]; }
            set { Fields.ItemNoDefSpecCount[this] = value; }
        }

        [DisplayName("Item No Created Date"), Expression("jItemNo.[CREATED_DATE]")]
        public DateTime? ItemNoCreatedDate
        {
            get { return Fields.ItemNoCreatedDate[this]; }
            set { Fields.ItemNoCreatedDate[this] = value; }
        }

        [DisplayName("Item No Created By"), Expression("jItemNo.[CREATED_BY]")]
        public String ItemNoCreatedBy
        {
            get { return Fields.ItemNoCreatedBy[this]; }
            set { Fields.ItemNoCreatedBy[this] = value; }
        }

        [DisplayName("Item No Revised Date"), Expression("jItemNo.[REVISED_DATE]")]
        public DateTime? ItemNoRevisedDate
        {
            get { return Fields.ItemNoRevisedDate[this]; }
            set { Fields.ItemNoRevisedDate[this] = value; }
        }

        [DisplayName("Item No Revised By"), Expression("jItemNo.[REVISED_BY]")]
        public String ItemNoRevisedBy
        {
            get { return Fields.ItemNoRevisedBy[this]; }
            set { Fields.ItemNoRevisedBy[this] = value; }
        }

        [DisplayName("Item No With Backlog"), Expression("jItemNo.[WITH_BACKLOG]")]
        public String ItemNoWithBacklog
        {
            get { return Fields.ItemNoWithBacklog[this]; }
            set { Fields.ItemNoWithBacklog[this] = value; }
        }

        [DisplayName("Item No With Balance"), Expression("jItemNo.[WITH_BALANCE]")]
        public String ItemNoWithBalance
        {
            get { return Fields.ItemNoWithBalance[this]; }
            set { Fields.ItemNoWithBalance[this] = value; }
        }

        [DisplayName("Item No Qty On Hand"), Expression("jItemNo.[QTY_ON_HAND]")]
        public Decimal? ItemNoQtyOnHand
        {
            get { return Fields.ItemNoQtyOnHand[this]; }
            set { Fields.ItemNoQtyOnHand[this] = value; }
        }

        [DisplayName("Item No Qty On Sorder"), Expression("jItemNo.[QTY_ON_SORDER]")]
        public Decimal? ItemNoQtyOnSorder
        {
            get { return Fields.ItemNoQtyOnSorder[this]; }
            set { Fields.ItemNoQtyOnSorder[this] = value; }
        }

        [DisplayName("Item No Qty On Porder"), Expression("jItemNo.[QTY_ON_PORDER]")]
        public Decimal? ItemNoQtyOnPorder
        {
            get { return Fields.ItemNoQtyOnPorder[this]; }
            set { Fields.ItemNoQtyOnPorder[this] = value; }
        }

        [DisplayName("Item No Qty On Jorder"), Expression("jItemNo.[QTY_ON_JORDER]")]
        public Decimal? ItemNoQtyOnJorder
        {
            get { return Fields.ItemNoQtyOnJorder[this]; }
            set { Fields.ItemNoQtyOnJorder[this] = value; }
        }

        [DisplayName("Item No Qty On Inspect"), Expression("jItemNo.[QTY_ON_INSPECT]")]
        public Decimal? ItemNoQtyOnInspect
        {
            get { return Fields.ItemNoQtyOnInspect[this]; }
            set { Fields.ItemNoQtyOnInspect[this] = value; }
        }

        [DisplayName("Item No Qty Waitlisted"), Expression("jItemNo.[QTY_WAITLISTED]")]
        public Decimal? ItemNoQtyWaitlisted
        {
            get { return Fields.ItemNoQtyWaitlisted[this]; }
            set { Fields.ItemNoQtyWaitlisted[this] = value; }
        }

        [DisplayName("Item No Qty Reserved"), Expression("jItemNo.[QTY_RESERVED]")]
        public Decimal? ItemNoQtyReserved
        {
            get { return Fields.ItemNoQtyReserved[this]; }
            set { Fields.ItemNoQtyReserved[this] = value; }
        }

        [DisplayName("Item No Qty Committed"), Expression("jItemNo.[QTY_COMMITTED]")]
        public Decimal? ItemNoQtyCommitted
        {
            get { return Fields.ItemNoQtyCommitted[this]; }
            set { Fields.ItemNoQtyCommitted[this] = value; }
        }

        [DisplayName("Item No Qty Available"), Expression("jItemNo.[QTY_AVAILABLE]")]
        public Decimal? ItemNoQtyAvailable
        {
            get { return Fields.ItemNoQtyAvailable[this]; }
            set { Fields.ItemNoQtyAvailable[this] = value; }
        }

        [DisplayName("Item No Qty Unallocated"), Expression("jItemNo.[QTY_UNALLOCATED]")]
        public Decimal? ItemNoQtyUnallocated
        {
            get { return Fields.ItemNoQtyUnallocated[this]; }
            set { Fields.ItemNoQtyUnallocated[this] = value; }
        }

        [DisplayName("Item No Invt Cost Avail"), Expression("jItemNo.[INVT_COST_AVAIL]")]
        public Decimal? ItemNoInvtCostAvail
        {
            get { return Fields.ItemNoInvtCostAvail[this]; }
            set { Fields.ItemNoInvtCostAvail[this] = value; }
        }

        [DisplayName("Item No Invt Cost Ldg"), Expression("jItemNo.[INVT_COST_LDG]")]
        public Decimal? ItemNoInvtCostLdg
        {
            get { return Fields.ItemNoInvtCostLdg[this]; }
            set { Fields.ItemNoInvtCostLdg[this] = value; }
        }

        [DisplayName("Item No Average Cost"), Expression("jItemNo.[AVERAGE_COST]")]
        public String ItemNoAverageCost
        {
            get { return Fields.ItemNoAverageCost[this]; }
            set { Fields.ItemNoAverageCost[this] = value; }
        }

        [DisplayName("Item No Latest Cost"), Expression("jItemNo.[LATEST_COST]")]
        public Decimal? ItemNoLatestCost
        {
            get { return Fields.ItemNoLatestCost[this]; }
            set { Fields.ItemNoLatestCost[this] = value; }
        }

        [DisplayName("Item No Std Cost"), Expression("jItemNo.[STD_COST]")]
        public Decimal? ItemNoStdCost
        {
            get { return Fields.ItemNoStdCost[this]; }
            set { Fields.ItemNoStdCost[this] = value; }
        }

        [DisplayName("Item No Last Count Date"), Expression("jItemNo.[LAST_COUNT_DATE]")]
        public DateTime? ItemNoLastCountDate
        {
            get { return Fields.ItemNoLastCountDate[this]; }
            set { Fields.ItemNoLastCountDate[this] = value; }
        }

        [DisplayName("Item No Last Date In"), Expression("jItemNo.[LAST_DATE_IN]")]
        public DateTime? ItemNoLastDateIn
        {
            get { return Fields.ItemNoLastDateIn[this]; }
            set { Fields.ItemNoLastDateIn[this] = value; }
        }

        [DisplayName("Item No Last Date Out"), Expression("jItemNo.[LAST_DATE_OUT]")]
        public DateTime? ItemNoLastDateOut
        {
            get { return Fields.ItemNoLastDateOut[this]; }
            set { Fields.ItemNoLastDateOut[this] = value; }
        }

        [DisplayName("Item No Sales Uom"), Expression("jItemNo.[SALES_UOM]")]
        public String ItemNoSalesUom
        {
            get { return Fields.ItemNoSalesUom[this]; }
            set { Fields.ItemNoSalesUom[this] = value; }
        }

        [DisplayName("Item No Sales Lot Size"), Expression("jItemNo.[SALES_LOT_SIZE]")]
        public Decimal? ItemNoSalesLotSize
        {
            get { return Fields.ItemNoSalesLotSize[this]; }
            set { Fields.ItemNoSalesLotSize[this] = value; }
        }

        [DisplayName("Item No Price Ccy"), Expression("jItemNo.[PRICE_CCY]")]
        public String ItemNoPriceCcy
        {
            get { return Fields.ItemNoPriceCcy[this]; }
            set { Fields.ItemNoPriceCcy[this] = value; }
        }

        [DisplayName("Item No Base Price"), Expression("jItemNo.[BASE_PRICE]")]
        public Decimal? ItemNoBasePrice
        {
            get { return Fields.ItemNoBasePrice[this]; }
            set { Fields.ItemNoBasePrice[this] = value; }
        }

        [DisplayName("Item No Pricea"), Expression("jItemNo.[PRICEA]")]
        public Decimal? ItemNoPricea
        {
            get { return Fields.ItemNoPricea[this]; }
            set { Fields.ItemNoPricea[this] = value; }
        }

        [DisplayName("Item No Priceb"), Expression("jItemNo.[PRICEB]")]
        public Decimal? ItemNoPriceb
        {
            get { return Fields.ItemNoPriceb[this]; }
            set { Fields.ItemNoPriceb[this] = value; }
        }

        [DisplayName("Item No Pricec"), Expression("jItemNo.[PRICEC]")]
        public Decimal? ItemNoPricec
        {
            get { return Fields.ItemNoPricec[this]; }
            set { Fields.ItemNoPricec[this] = value; }
        }

        [DisplayName("Item No Min Price"), Expression("jItemNo.[MIN_PRICE]")]
        public Decimal? ItemNoMinPrice
        {
            get { return Fields.ItemNoMinPrice[this]; }
            set { Fields.ItemNoMinPrice[this] = value; }
        }

        [DisplayName("Item No Max Price"), Expression("jItemNo.[MAX_PRICE]")]
        public Decimal? ItemNoMaxPrice
        {
            get { return Fields.ItemNoMaxPrice[this]; }
            set { Fields.ItemNoMaxPrice[this] = value; }
        }

        [DisplayName("Item No Min Order Qty"), Expression("jItemNo.[MIN_ORDER_QTY]")]
        public Decimal? ItemNoMinOrderQty
        {
            get { return Fields.ItemNoMinOrderQty[this]; }
            set { Fields.ItemNoMinOrderQty[this] = value; }
        }

        [DisplayName("Item No Max Order Qty"), Expression("jItemNo.[MAX_ORDER_QTY]")]
        public Decimal? ItemNoMaxOrderQty
        {
            get { return Fields.ItemNoMaxOrderQty[this]; }
            set { Fields.ItemNoMaxOrderQty[this] = value; }
        }

        [DisplayName("Item No Min Order Days"), Expression("jItemNo.[MIN_ORDER_DAYS]")]
        public Decimal? ItemNoMinOrderDays
        {
            get { return Fields.ItemNoMinOrderDays[this]; }
            set { Fields.ItemNoMinOrderDays[this] = value; }
        }

        [DisplayName("Item No Inner Pkg Type"), Expression("jItemNo.[INNER_PKG_TYPE]")]
        public String ItemNoInnerPkgType
        {
            get { return Fields.ItemNoInnerPkgType[this]; }
            set { Fields.ItemNoInnerPkgType[this] = value; }
        }

        [DisplayName("Item No Inner Qty"), Expression("jItemNo.[INNER_QTY]")]
        public Decimal? ItemNoInnerQty
        {
            get { return Fields.ItemNoInnerQty[this]; }
            set { Fields.ItemNoInnerQty[this] = value; }
        }

        [DisplayName("Item No Outer Pkg Type"), Expression("jItemNo.[OUTER_PKG_TYPE]")]
        public String ItemNoOuterPkgType
        {
            get { return Fields.ItemNoOuterPkgType[this]; }
            set { Fields.ItemNoOuterPkgType[this] = value; }
        }

        [DisplayName("Item No Outer Qty"), Expression("jItemNo.[OUTER_QTY]")]
        public Decimal? ItemNoOuterQty
        {
            get { return Fields.ItemNoOuterQty[this]; }
            set { Fields.ItemNoOuterQty[this] = value; }
        }

        [DisplayName("Item No Article Code"), Expression("jItemNo.[ARTICLE_CODE]")]
        public String ItemNoArticleCode
        {
            get { return Fields.ItemNoArticleCode[this]; }
            set { Fields.ItemNoArticleCode[this] = value; }
        }

        [DisplayName("Item No Quota Category"), Expression("jItemNo.[QUOTA_CATEGORY]")]
        public String ItemNoQuotaCategory
        {
            get { return Fields.ItemNoQuotaCategory[this]; }
            set { Fields.ItemNoQuotaCategory[this] = value; }
        }

        [DisplayName("Item No Weight Uom"), Expression("jItemNo.[WEIGHT_UOM]")]
        public String ItemNoWeightUom
        {
            get { return Fields.ItemNoWeightUom[this]; }
            set { Fields.ItemNoWeightUom[this] = value; }
        }

        [DisplayName("Item No Gross Wt"), Expression("jItemNo.[GROSS_WT]")]
        public Decimal? ItemNoGrossWt
        {
            get { return Fields.ItemNoGrossWt[this]; }
            set { Fields.ItemNoGrossWt[this] = value; }
        }

        [DisplayName("Item No Net Wt"), Expression("jItemNo.[NET_WT]")]
        public Decimal? ItemNoNetWt
        {
            get { return Fields.ItemNoNetWt[this]; }
            set { Fields.ItemNoNetWt[this] = value; }
        }

        [DisplayName("Item No Dimension Uom"), Expression("jItemNo.[DIMENSION_UOM]")]
        public String ItemNoDimensionUom
        {
            get { return Fields.ItemNoDimensionUom[this]; }
            set { Fields.ItemNoDimensionUom[this] = value; }
        }

        [DisplayName("Item No Flength"), Expression("jItemNo.[FLENGTH]")]
        public Decimal? ItemNoFlength
        {
            get { return Fields.ItemNoFlength[this]; }
            set { Fields.ItemNoFlength[this] = value; }
        }

        [DisplayName("Item No Width"), Expression("jItemNo.[WIDTH]")]
        public Decimal? ItemNoWidth
        {
            get { return Fields.ItemNoWidth[this]; }
            set { Fields.ItemNoWidth[this] = value; }
        }

        [DisplayName("Item No Height"), Expression("jItemNo.[HEIGHT]")]
        public Decimal? ItemNoHeight
        {
            get { return Fields.ItemNoHeight[this]; }
            set { Fields.ItemNoHeight[this] = value; }
        }

        [DisplayName("Item No Computed Vol"), Expression("jItemNo.[COMPUTED_VOL]")]
        public Decimal? ItemNoComputedVol
        {
            get { return Fields.ItemNoComputedVol[this]; }
            set { Fields.ItemNoComputedVol[this] = value; }
        }

        [DisplayName("Item No Declared Vol"), Expression("jItemNo.[DECLARED_VOL]")]
        public Decimal? ItemNoDeclaredVol
        {
            get { return Fields.ItemNoDeclaredVol[this]; }
            set { Fields.ItemNoDeclaredVol[this] = value; }
        }

        [DisplayName("Item No Srevised Date"), Expression("jItemNo.[SREVISED_DATE]")]
        public DateTime? ItemNoSrevisedDate
        {
            get { return Fields.ItemNoSrevisedDate[this]; }
            set { Fields.ItemNoSrevisedDate[this] = value; }
        }

        [DisplayName("Item No Srevised By"), Expression("jItemNo.[SREVISED_BY]")]
        public String ItemNoSrevisedBy
        {
            get { return Fields.ItemNoSrevisedBy[this]; }
            set { Fields.ItemNoSrevisedBy[this] = value; }
        }

        [DisplayName("Item No Mps Item"), Expression("jItemNo.[MPS_ITEM]")]
        public String ItemNoMpsItem
        {
            get { return Fields.ItemNoMpsItem[this]; }
            set { Fields.ItemNoMpsItem[this] = value; }
        }

        [DisplayName("Item No Order Policy"), Expression("jItemNo.[ORDER_POLICY]")]
        public String ItemNoOrderPolicy
        {
            get { return Fields.ItemNoOrderPolicy[this]; }
            set { Fields.ItemNoOrderPolicy[this] = value; }
        }

        [DisplayName("Item No Min Planord Qty"), Expression("jItemNo.[MIN_PLANORD_QTY]")]
        public Decimal? ItemNoMinPlanordQty
        {
            get { return Fields.ItemNoMinPlanordQty[this]; }
            set { Fields.ItemNoMinPlanordQty[this] = value; }
        }

        [DisplayName("Item No Max Planord Qty"), Expression("jItemNo.[MAX_PLANORD_QTY]")]
        public Decimal? ItemNoMaxPlanordQty
        {
            get { return Fields.ItemNoMaxPlanordQty[this]; }
            set { Fields.ItemNoMaxPlanordQty[this] = value; }
        }

        [DisplayName("Item No Std Planord Qty"), Expression("jItemNo.[STD_PLANORD_QTY]")]
        public Decimal? ItemNoStdPlanordQty
        {
            get { return Fields.ItemNoStdPlanordQty[this]; }
            set { Fields.ItemNoStdPlanordQty[this] = value; }
        }

        [DisplayName("Item No Min Planord Prd"), Expression("jItemNo.[MIN_PLANORD_PRD]")]
        public Decimal? ItemNoMinPlanordPrd
        {
            get { return Fields.ItemNoMinPlanordPrd[this]; }
            set { Fields.ItemNoMinPlanordPrd[this] = value; }
        }

        [DisplayName("Item No Max Planord Prd"), Expression("jItemNo.[MAX_PLANORD_PRD]")]
        public Decimal? ItemNoMaxPlanordPrd
        {
            get { return Fields.ItemNoMaxPlanordPrd[this]; }
            set { Fields.ItemNoMaxPlanordPrd[this] = value; }
        }

        [DisplayName("Item No Std Planord Prd"), Expression("jItemNo.[STD_PLANORD_PRD]")]
        public Decimal? ItemNoStdPlanordPrd
        {
            get { return Fields.ItemNoStdPlanordPrd[this]; }
            set { Fields.ItemNoStdPlanordPrd[this] = value; }
        }

        [DisplayName("Item No Reorder Pt"), Expression("jItemNo.[REORDER_PT]")]
        public Decimal? ItemNoReorderPt
        {
            get { return Fields.ItemNoReorderPt[this]; }
            set { Fields.ItemNoReorderPt[this] = value; }
        }

        [DisplayName("Item No Reorder Qty"), Expression("jItemNo.[REORDER_QTY]")]
        public Decimal? ItemNoReorderQty
        {
            get { return Fields.ItemNoReorderQty[this]; }
            set { Fields.ItemNoReorderQty[this] = value; }
        }

        [DisplayName("Item No Min Mthly Prod"), Expression("jItemNo.[MIN_MTHLY_PROD]")]
        public Decimal? ItemNoMinMthlyProd
        {
            get { return Fields.ItemNoMinMthlyProd[this]; }
            set { Fields.ItemNoMinMthlyProd[this] = value; }
        }

        [DisplayName("Item No Max Mthly Prod"), Expression("jItemNo.[MAX_MTHLY_PROD]")]
        public Decimal? ItemNoMaxMthlyProd
        {
            get { return Fields.ItemNoMaxMthlyProd[this]; }
            set { Fields.ItemNoMaxMthlyProd[this] = value; }
        }

        [DisplayName("Item No Min Mthly Pur"), Expression("jItemNo.[MIN_MTHLY_PUR]")]
        public Decimal? ItemNoMinMthlyPur
        {
            get { return Fields.ItemNoMinMthlyPur[this]; }
            set { Fields.ItemNoMinMthlyPur[this] = value; }
        }

        [DisplayName("Item No Max Mthly Pur"), Expression("jItemNo.[MAX_MTHLY_PUR]")]
        public Decimal? ItemNoMaxMthlyPur
        {
            get { return Fields.ItemNoMaxMthlyPur[this]; }
            set { Fields.ItemNoMaxMthlyPur[this] = value; }
        }

        [DisplayName("Item No Follow Min Prod"), Expression("jItemNo.[FOLLOW_MIN_PROD]")]
        public String ItemNoFollowMinProd
        {
            get { return Fields.ItemNoFollowMinProd[this]; }
            set { Fields.ItemNoFollowMinProd[this] = value; }
        }

        [DisplayName("Item No Follow Max Prod"), Expression("jItemNo.[FOLLOW_MAX_PROD]")]
        public String ItemNoFollowMaxProd
        {
            get { return Fields.ItemNoFollowMaxProd[this]; }
            set { Fields.ItemNoFollowMaxProd[this] = value; }
        }

        [DisplayName("Item No Follow Min Pur"), Expression("jItemNo.[FOLLOW_MIN_PUR]")]
        public String ItemNoFollowMinPur
        {
            get { return Fields.ItemNoFollowMinPur[this]; }
            set { Fields.ItemNoFollowMinPur[this] = value; }
        }

        [DisplayName("Item No Follow Max Pur"), Expression("jItemNo.[FOLLOW_MAX_PUR]")]
        public String ItemNoFollowMaxPur
        {
            get { return Fields.ItemNoFollowMaxPur[this]; }
            set { Fields.ItemNoFollowMaxPur[this] = value; }
        }

        [DisplayName("Item No Allow Mix Mode"), Expression("jItemNo.[ALLOW_MIX_MODE]")]
        public String ItemNoAllowMixMode
        {
            get { return Fields.ItemNoAllowMixMode[this]; }
            set { Fields.ItemNoAllowMixMode[this] = value; }
        }

        [DisplayName("Item No Pref Vend Only"), Expression("jItemNo.[PREF_VEND_ONLY]")]
        public String ItemNoPrefVendOnly
        {
            get { return Fields.ItemNoPrefVendOnly[this]; }
            set { Fields.ItemNoPrefVendOnly[this] = value; }
        }

        [DisplayName("Item No Pref Vend 1"), Expression("jItemNo.[PREF_VEND_1]")]
        public String ItemNoPrefVend1
        {
            get { return Fields.ItemNoPrefVend1[this]; }
            set { Fields.ItemNoPrefVend1[this] = value; }
        }

        [DisplayName("Item No Pref Vend 2"), Expression("jItemNo.[PREF_VEND_2]")]
        public String ItemNoPrefVend2
        {
            get { return Fields.ItemNoPrefVend2[this]; }
            set { Fields.ItemNoPrefVend2[this] = value; }
        }

        [DisplayName("Item No Prod Lead Time"), Expression("jItemNo.[PROD_LEAD_TIME]")]
        public Decimal? ItemNoProdLeadTime
        {
            get { return Fields.ItemNoProdLeadTime[this]; }
            set { Fields.ItemNoProdLeadTime[this] = value; }
        }

        [DisplayName("Item No Prod Lead Unit"), Expression("jItemNo.[PROD_LEAD_UNIT]")]
        public String ItemNoProdLeadUnit
        {
            get { return Fields.ItemNoProdLeadUnit[this]; }
            set { Fields.ItemNoProdLeadUnit[this] = value; }
        }

        [DisplayName("Item No Pur Lead Time"), Expression("jItemNo.[PUR_LEAD_TIME]")]
        public Decimal? ItemNoPurLeadTime
        {
            get { return Fields.ItemNoPurLeadTime[this]; }
            set { Fields.ItemNoPurLeadTime[this] = value; }
        }

        [DisplayName("Item No Pur Lead Unit"), Expression("jItemNo.[PUR_LEAD_UNIT]")]
        public String ItemNoPurLeadUnit
        {
            get { return Fields.ItemNoPurLeadUnit[this]; }
            set { Fields.ItemNoPurLeadUnit[this] = value; }
        }

        [DisplayName("Item No Planner"), Expression("jItemNo.[PLANNER]")]
        public String ItemNoPlanner
        {
            get { return Fields.ItemNoPlanner[this]; }
            set { Fields.ItemNoPlanner[this] = value; }
        }

        [DisplayName("Item No Mrp Parm Date"), Expression("jItemNo.[MRP_PARM_DATE]")]
        public DateTime? ItemNoMrpParmDate
        {
            get { return Fields.ItemNoMrpParmDate[this]; }
            set { Fields.ItemNoMrpParmDate[this] = value; }
        }

        [DisplayName("Item No Mrp Parm By"), Expression("jItemNo.[MRP_PARM_BY]")]
        public String ItemNoMrpParmBy
        {
            get { return Fields.ItemNoMrpParmBy[this]; }
            set { Fields.ItemNoMrpParmBy[this] = value; }
        }

        [DisplayName("Item No Alt Description"), Expression("jItemNo.[ALT_DESCRIPTION]")]
        public String ItemNoAltDescription
        {
            get { return Fields.ItemNoAltDescription[this]; }
            set { Fields.ItemNoAltDescription[this] = value; }
        }

        [DisplayName("Item No Picture File"), Expression("jItemNo.[PICTURE_FILE]")]
        public String ItemNoPictureFile
        {
            get { return Fields.ItemNoPictureFile[this]; }
            set { Fields.ItemNoPictureFile[this] = value; }
        }

        [DisplayName("Item No Acct Itm Asset"), Expression("jItemNo.[ACCT_ITM_ASSET]")]
        public String ItemNoAcctItmAsset
        {
            get { return Fields.ItemNoAcctItmAsset[this]; }
            set { Fields.ItemNoAcctItmAsset[this] = value; }
        }

        [DisplayName("Item No Acct Itm Wip"), Expression("jItemNo.[ACCT_ITM_WIP]")]
        public String ItemNoAcctItmWip
        {
            get { return Fields.ItemNoAcctItmWip[this]; }
            set { Fields.ItemNoAcctItmWip[this] = value; }
        }

        [DisplayName("Item No Acct Itm Consum"), Expression("jItemNo.[ACCT_ITM_CONSUM]")]
        public String ItemNoAcctItmConsum
        {
            get { return Fields.ItemNoAcctItmConsum[this]; }
            set { Fields.ItemNoAcctItmConsum[this] = value; }
        }

        [DisplayName("Item No Acct Itm Scrap"), Expression("jItemNo.[ACCT_ITM_SCRAP]")]
        public String ItemNoAcctItmScrap
        {
            get { return Fields.ItemNoAcctItmScrap[this]; }
            set { Fields.ItemNoAcctItmScrap[this] = value; }
        }

        [DisplayName("Item No Acct Itm Pvar"), Expression("jItemNo.[ACCT_ITM_PVAR]")]
        public String ItemNoAcctItmPvar
        {
            get { return Fields.ItemNoAcctItmPvar[this]; }
            set { Fields.ItemNoAcctItmPvar[this] = value; }
        }

        [DisplayName("Item No Acct Itm Reval"), Expression("jItemNo.[ACCT_ITM_REVAL]")]
        public String ItemNoAcctItmReval
        {
            get { return Fields.ItemNoAcctItmReval[this]; }
            set { Fields.ItemNoAcctItmReval[this] = value; }
        }

        [DisplayName("Item No Acct Itm Varia"), Expression("jItemNo.[ACCT_ITM_VARIA]")]
        public String ItemNoAcctItmVaria
        {
            get { return Fields.ItemNoAcctItmVaria[this]; }
            set { Fields.ItemNoAcctItmVaria[this] = value; }
        }

        [DisplayName("Item No Acct Itm Sales"), Expression("jItemNo.[ACCT_ITM_SALES]")]
        public String ItemNoAcctItmSales
        {
            get { return Fields.ItemNoAcctItmSales[this]; }
            set { Fields.ItemNoAcctItmSales[this] = value; }
        }

        [DisplayName("Item No Acct Itm Slret"), Expression("jItemNo.[ACCT_ITM_SLRET]")]
        public String ItemNoAcctItmSlret
        {
            get { return Fields.ItemNoAcctItmSlret[this]; }
            set { Fields.ItemNoAcctItmSlret[this] = value; }
        }

        [DisplayName("Item No Acct Itm Sldisc"), Expression("jItemNo.[ACCT_ITM_SLDISC]")]
        public String ItemNoAcctItmSldisc
        {
            get { return Fields.ItemNoAcctItmSldisc[this]; }
            set { Fields.ItemNoAcctItmSldisc[this] = value; }
        }

        [DisplayName("Item No Acct Itm Cogs"), Expression("jItemNo.[ACCT_ITM_COGS]")]
        public String ItemNoAcctItmCogs
        {
            get { return Fields.ItemNoAcctItmCogs[this]; }
            set { Fields.ItemNoAcctItmCogs[this] = value; }
        }

        [DisplayName("Item No Acct Itm Purch"), Expression("jItemNo.[ACCT_ITM_PURCH]")]
        public String ItemNoAcctItmPurch
        {
            get { return Fields.ItemNoAcctItmPurch[this]; }
            set { Fields.ItemNoAcctItmPurch[this] = value; }
        }

        [DisplayName("Item No Acct Itm Puret"), Expression("jItemNo.[ACCT_ITM_PURET]")]
        public String ItemNoAcctItmPuret
        {
            get { return Fields.ItemNoAcctItmPuret[this]; }
            set { Fields.ItemNoAcctItmPuret[this] = value; }
        }

        [DisplayName("Item No Acct Itm Pudisc"), Expression("jItemNo.[ACCT_ITM_PUDISC]")]
        public String ItemNoAcctItmPudisc
        {
            get { return Fields.ItemNoAcctItmPudisc[this]; }
            set { Fields.ItemNoAcctItmPudisc[this] = value; }
        }

        [DisplayName("Item No Acct Itm Putax"), Expression("jItemNo.[ACCT_ITM_PUTAX]")]
        public String ItemNoAcctItmPutax
        {
            get { return Fields.ItemNoAcctItmPutax[this]; }
            set { Fields.ItemNoAcctItmPutax[this] = value; }
        }

        [DisplayName("Item No Acct Machine"), Expression("jItemNo.[ACCT_MACHINE]")]
        public String ItemNoAcctMachine
        {
            get { return Fields.ItemNoAcctMachine[this]; }
            set { Fields.ItemNoAcctMachine[this] = value; }
        }

        [DisplayName("Item No Acct Energy"), Expression("jItemNo.[ACCT_ENERGY]")]
        public String ItemNoAcctEnergy
        {
            get { return Fields.ItemNoAcctEnergy[this]; }
            set { Fields.ItemNoAcctEnergy[this] = value; }
        }

        [DisplayName("Item No Acct Water"), Expression("jItemNo.[ACCT_WATER]")]
        public String ItemNoAcctWater
        {
            get { return Fields.ItemNoAcctWater[this]; }
            set { Fields.ItemNoAcctWater[this] = value; }
        }

        [DisplayName("Item No Acct Rental"), Expression("jItemNo.[ACCT_RENTAL]")]
        public String ItemNoAcctRental
        {
            get { return Fields.ItemNoAcctRental[this]; }
            set { Fields.ItemNoAcctRental[this] = value; }
        }

        [DisplayName("Item No Acct Labor"), Expression("jItemNo.[ACCT_LABOR]")]
        public String ItemNoAcctLabor
        {
            get { return Fields.ItemNoAcctLabor[this]; }
            set { Fields.ItemNoAcctLabor[this] = value; }
        }

        [DisplayName("Item No Acct Inlab"), Expression("jItemNo.[ACCT_INLAB]")]
        public String ItemNoAcctInlab
        {
            get { return Fields.ItemNoAcctInlab[this]; }
            set { Fields.ItemNoAcctInlab[this] = value; }
        }

        [DisplayName("Item No Acct Inmat"), Expression("jItemNo.[ACCT_INMAT]")]
        public String ItemNoAcctInmat
        {
            get { return Fields.ItemNoAcctInmat[this]; }
            set { Fields.ItemNoAcctInmat[this] = value; }
        }

        [DisplayName("Item No Acct Misc"), Expression("jItemNo.[ACCT_MISC]")]
        public String ItemNoAcctMisc
        {
            get { return Fields.ItemNoAcctMisc[this]; }
            set { Fields.ItemNoAcctMisc[this] = value; }
        }

        [DisplayName("Item No Arevised Date"), Expression("jItemNo.[AREVISED_DATE]")]
        public DateTime? ItemNoArevisedDate
        {
            get { return Fields.ItemNoArevisedDate[this]; }
            set { Fields.ItemNoArevisedDate[this] = value; }
        }

        [DisplayName("Item No Arevised By"), Expression("jItemNo.[AREVISED_BY]")]
        public String ItemNoArevisedBy
        {
            get { return Fields.ItemNoArevisedBy[this]; }
            set { Fields.ItemNoArevisedBy[this] = value; }
        }

        [DisplayName("Item No Brevised Date"), Expression("jItemNo.[BREVISED_DATE]")]
        public DateTime? ItemNoBrevisedDate
        {
            get { return Fields.ItemNoBrevisedDate[this]; }
            set { Fields.ItemNoBrevisedDate[this] = value; }
        }

        [DisplayName("Item No Brevised By"), Expression("jItemNo.[BREVISED_BY]")]
        public String ItemNoBrevisedBy
        {
            get { return Fields.ItemNoBrevisedBy[this]; }
            set { Fields.ItemNoBrevisedBy[this] = value; }
        }

        [DisplayName("Item No Sales Ltax Code"), Expression("jItemNo.[SALES_LTAX_CODE]")]
        public String ItemNoSalesLtaxCode
        {
            get { return Fields.ItemNoSalesLtaxCode[this]; }
            set { Fields.ItemNoSalesLtaxCode[this] = value; }
        }

        [DisplayName("Item No Purch Ltax Code"), Expression("jItemNo.[PURCH_LTAX_CODE]")]
        public String ItemNoPurchLtaxCode
        {
            get { return Fields.ItemNoPurchLtaxCode[this]; }
            set { Fields.ItemNoPurchLtaxCode[this] = value; }
        }

        [DisplayName("Item No Trevised Date"), Expression("jItemNo.[TREVISED_DATE]")]
        public DateTime? ItemNoTrevisedDate
        {
            get { return Fields.ItemNoTrevisedDate[this]; }
            set { Fields.ItemNoTrevisedDate[this] = value; }
        }

        [DisplayName("Item No Trevised By"), Expression("jItemNo.[TREVISED_BY]")]
        public String ItemNoTrevisedBy
        {
            get { return Fields.ItemNoTrevisedBy[this]; }
            set { Fields.ItemNoTrevisedBy[this] = value; }
        }

        [DisplayName("Item No Specs Count"), Expression("jItemNo.[SPECS_COUNT]")]
        public Decimal? ItemNoSpecsCount
        {
            get { return Fields.ItemNoSpecsCount[this]; }
            set { Fields.ItemNoSpecsCount[this] = value; }
        }

        [DisplayName("Item No Def Bom No"), Expression("jItemNo.[DEF_BOM_NO]")]
        public String ItemNoDefBomNo
        {
            get { return Fields.ItemNoDefBomNo[this]; }
            set { Fields.ItemNoDefBomNo[this] = value; }
        }

        [DisplayName("Item No Last Snap No"), Expression("jItemNo.[LAST_SNAP_NO]")]
        public Decimal? ItemNoLastSnapNo
        {
            get { return Fields.ItemNoLastSnapNo[this]; }
            set { Fields.ItemNoLastSnapNo[this] = value; }
        }

        [DisplayName("Item No Commis Type"), Expression("jItemNo.[COMMIS_TYPE]")]
        public String ItemNoCommisType
        {
            get { return Fields.ItemNoCommisType[this]; }
            set { Fields.ItemNoCommisType[this] = value; }
        }

        [DisplayName("Item No Prod Branch"), Expression("jItemNo.[PROD_BRANCH]")]
        public String ItemNoProdBranch
        {
            get { return Fields.ItemNoProdBranch[this]; }
            set { Fields.ItemNoProdBranch[this] = value; }
        }

        [DisplayName("Item No Owner Branch"), Expression("jItemNo.[OWNER_BRANCH]")]
        public String ItemNoOwnerBranch
        {
            get { return Fields.ItemNoOwnerBranch[this]; }
            set { Fields.ItemNoOwnerBranch[this] = value; }
        }

        [DisplayName("Item No Source Branch"), Expression("jItemNo.[SOURCE_BRANCH]")]
        public String ItemNoSourceBranch
        {
            get { return Fields.ItemNoSourceBranch[this]; }
            set { Fields.ItemNoSourceBranch[this] = value; }
        }

        [DisplayName("Item No Scrap Rate"), Expression("jItemNo.[SCRAP_RATE]")]
        public Decimal? ItemNoScrapRate
        {
            get { return Fields.ItemNoScrapRate[this]; }
            set { Fields.ItemNoScrapRate[this] = value; }
        }

        [DisplayName("Item No Alt Ext Desc"), Expression("jItemNo.[ALT_EXT_DESC]")]
        public String ItemNoAltExtDesc
        {
            get { return Fields.ItemNoAltExtDesc[this]; }
            set { Fields.ItemNoAltExtDesc[this] = value; }
        }

        [DisplayName("Item No Extended Desc"), Expression("jItemNo.[EXTENDED_DESC]")]
        public String ItemNoExtendedDesc
        {
            get { return Fields.ItemNoExtendedDesc[this]; }
            set { Fields.ItemNoExtendedDesc[this] = value; }
        }

        [DisplayName("Item No Pur Price Ctrl"), Expression("jItemNo.[PUR_PRICE_CTRL]")]
        public String ItemNoPurPriceCtrl
        {
            get { return Fields.ItemNoPurPriceCtrl[this]; }
            set { Fields.ItemNoPurPriceCtrl[this] = value; }
        }

        [DisplayName("Item No Pur Max Dev"), Expression("jItemNo.[PUR_MAX_DEV]")]
        public Decimal? ItemNoPurMaxDev
        {
            get { return Fields.ItemNoPurMaxDev[this]; }
            set { Fields.ItemNoPurMaxDev[this] = value; }
        }

        [DisplayName("Item No Web Item"), Expression("jItemNo.[WEB_ITEM]")]
        public String ItemNoWebItem
        {
            get { return Fields.ItemNoWebItem[this]; }
            set { Fields.ItemNoWebItem[this] = value; }
        }

        [DisplayName("Item No Acct Itm Subcon"), Expression("jItemNo.[ACCT_ITM_SUBCON]")]
        public String ItemNoAcctItmSubcon
        {
            get { return Fields.ItemNoAcctItmSubcon[this]; }
            set { Fields.ItemNoAcctItmSubcon[this] = value; }
        }

        [DisplayName("Item No With Bin Ctrl"), Expression("jItemNo.[WITH_BIN_CTRL]")]
        public String ItemNoWithBinCtrl
        {
            get { return Fields.ItemNoWithBinCtrl[this]; }
            set { Fields.ItemNoWithBinCtrl[this] = value; }
        }

        [DisplayName("Item No Consign"), Expression("jItemNo.[CONSIGN]")]
        public String ItemNoConsign
        {
            get { return Fields.ItemNoConsign[this]; }
            set { Fields.ItemNoConsign[this] = value; }
        }

        [DisplayName("Item No Prod Devt01"), Expression("jItemNo.[PROD_DEVT01]")]
        public String ItemNoProdDevt01
        {
            get { return Fields.ItemNoProdDevt01[this]; }
            set { Fields.ItemNoProdDevt01[this] = value; }
        }

        [DisplayName("Item No Prod Devt02"), Expression("jItemNo.[PROD_DEVT02]")]
        public String ItemNoProdDevt02
        {
            get { return Fields.ItemNoProdDevt02[this]; }
            set { Fields.ItemNoProdDevt02[this] = value; }
        }

        [DisplayName("Item No Prod Devt03"), Expression("jItemNo.[PROD_DEVT03]")]
        public String ItemNoProdDevt03
        {
            get { return Fields.ItemNoProdDevt03[this]; }
            set { Fields.ItemNoProdDevt03[this] = value; }
        }

        [DisplayName("Item No Prod Devt04"), Expression("jItemNo.[PROD_DEVT04]")]
        public String ItemNoProdDevt04
        {
            get { return Fields.ItemNoProdDevt04[this]; }
            set { Fields.ItemNoProdDevt04[this] = value; }
        }

        [DisplayName("Item No Prod Devt05"), Expression("jItemNo.[PROD_DEVT05]")]
        public String ItemNoProdDevt05
        {
            get { return Fields.ItemNoProdDevt05[this]; }
            set { Fields.ItemNoProdDevt05[this] = value; }
        }

        [DisplayName("Item No Prod Devt06"), Expression("jItemNo.[PROD_DEVT06]")]
        public String ItemNoProdDevt06
        {
            get { return Fields.ItemNoProdDevt06[this]; }
            set { Fields.ItemNoProdDevt06[this] = value; }
        }

        [DisplayName("Item No Prod Devt07"), Expression("jItemNo.[PROD_DEVT07]")]
        public String ItemNoProdDevt07
        {
            get { return Fields.ItemNoProdDevt07[this]; }
            set { Fields.ItemNoProdDevt07[this] = value; }
        }

        [DisplayName("Item No Prod Devt08"), Expression("jItemNo.[PROD_DEVT08]")]
        public String ItemNoProdDevt08
        {
            get { return Fields.ItemNoProdDevt08[this]; }
            set { Fields.ItemNoProdDevt08[this] = value; }
        }

        [DisplayName("Item No Prod Devt09"), Expression("jItemNo.[PROD_DEVT09]")]
        public String ItemNoProdDevt09
        {
            get { return Fields.ItemNoProdDevt09[this]; }
            set { Fields.ItemNoProdDevt09[this] = value; }
        }

        [DisplayName("Item No Prod Devt10"), Expression("jItemNo.[PROD_DEVT10]")]
        public String ItemNoProdDevt10
        {
            get { return Fields.ItemNoProdDevt10[this]; }
            set { Fields.ItemNoProdDevt10[this] = value; }
        }

        [DisplayName("Item No Prod Devt11"), Expression("jItemNo.[PROD_DEVT11]")]
        public String ItemNoProdDevt11
        {
            get { return Fields.ItemNoProdDevt11[this]; }
            set { Fields.ItemNoProdDevt11[this] = value; }
        }

        [DisplayName("Item No Prod Devt12"), Expression("jItemNo.[PROD_DEVT12]")]
        public String ItemNoProdDevt12
        {
            get { return Fields.ItemNoProdDevt12[this]; }
            set { Fields.ItemNoProdDevt12[this] = value; }
        }

        [DisplayName("Item No Prod Devt13"), Expression("jItemNo.[PROD_DEVT13]")]
        public String ItemNoProdDevt13
        {
            get { return Fields.ItemNoProdDevt13[this]; }
            set { Fields.ItemNoProdDevt13[this] = value; }
        }

        [DisplayName("Item No Prod Devt14"), Expression("jItemNo.[PROD_DEVT14]")]
        public String ItemNoProdDevt14
        {
            get { return Fields.ItemNoProdDevt14[this]; }
            set { Fields.ItemNoProdDevt14[this] = value; }
        }

        [DisplayName("Item No Prod Devt15"), Expression("jItemNo.[PROD_DEVT15]")]
        public String ItemNoProdDevt15
        {
            get { return Fields.ItemNoProdDevt15[this]; }
            set { Fields.ItemNoProdDevt15[this] = value; }
        }

        [DisplayName("Item No Prod Devt16"), Expression("jItemNo.[PROD_DEVT16]")]
        public String ItemNoProdDevt16
        {
            get { return Fields.ItemNoProdDevt16[this]; }
            set { Fields.ItemNoProdDevt16[this] = value; }
        }

        [DisplayName("Item No Prod Devt17"), Expression("jItemNo.[PROD_DEVT17]")]
        public String ItemNoProdDevt17
        {
            get { return Fields.ItemNoProdDevt17[this]; }
            set { Fields.ItemNoProdDevt17[this] = value; }
        }

        [DisplayName("Item No Prod Devt18"), Expression("jItemNo.[PROD_DEVT18]")]
        public String ItemNoProdDevt18
        {
            get { return Fields.ItemNoProdDevt18[this]; }
            set { Fields.ItemNoProdDevt18[this] = value; }
        }

        [DisplayName("Item No Prod Devt19"), Expression("jItemNo.[PROD_DEVT19]")]
        public String ItemNoProdDevt19
        {
            get { return Fields.ItemNoProdDevt19[this]; }
            set { Fields.ItemNoProdDevt19[this] = value; }
        }

        [DisplayName("Item No Prod Devt20"), Expression("jItemNo.[PROD_DEVT20]")]
        public String ItemNoProdDevt20
        {
            get { return Fields.ItemNoProdDevt20[this]; }
            set { Fields.ItemNoProdDevt20[this] = value; }
        }

        [DisplayName("Item No Prod Check01"), Expression("jItemNo.[PROD_CHECK01]")]
        public String ItemNoProdCheck01
        {
            get { return Fields.ItemNoProdCheck01[this]; }
            set { Fields.ItemNoProdCheck01[this] = value; }
        }

        [DisplayName("Item No Prod Check02"), Expression("jItemNo.[PROD_CHECK02]")]
        public String ItemNoProdCheck02
        {
            get { return Fields.ItemNoProdCheck02[this]; }
            set { Fields.ItemNoProdCheck02[this] = value; }
        }

        [DisplayName("Item No Prod Check03"), Expression("jItemNo.[PROD_CHECK03]")]
        public String ItemNoProdCheck03
        {
            get { return Fields.ItemNoProdCheck03[this]; }
            set { Fields.ItemNoProdCheck03[this] = value; }
        }

        [DisplayName("Item No Prod Check04"), Expression("jItemNo.[PROD_CHECK04]")]
        public String ItemNoProdCheck04
        {
            get { return Fields.ItemNoProdCheck04[this]; }
            set { Fields.ItemNoProdCheck04[this] = value; }
        }

        [DisplayName("Item No Prod Check05"), Expression("jItemNo.[PROD_CHECK05]")]
        public String ItemNoProdCheck05
        {
            get { return Fields.ItemNoProdCheck05[this]; }
            set { Fields.ItemNoProdCheck05[this] = value; }
        }

        [DisplayName("Item No Prod Check06"), Expression("jItemNo.[PROD_CHECK06]")]
        public String ItemNoProdCheck06
        {
            get { return Fields.ItemNoProdCheck06[this]; }
            set { Fields.ItemNoProdCheck06[this] = value; }
        }

        [DisplayName("Item No Prod Check07"), Expression("jItemNo.[PROD_CHECK07]")]
        public String ItemNoProdCheck07
        {
            get { return Fields.ItemNoProdCheck07[this]; }
            set { Fields.ItemNoProdCheck07[this] = value; }
        }

        [DisplayName("Item No Prod Check08"), Expression("jItemNo.[PROD_CHECK08]")]
        public String ItemNoProdCheck08
        {
            get { return Fields.ItemNoProdCheck08[this]; }
            set { Fields.ItemNoProdCheck08[this] = value; }
        }

        [DisplayName("Item No Prod Check09"), Expression("jItemNo.[PROD_CHECK09]")]
        public String ItemNoProdCheck09
        {
            get { return Fields.ItemNoProdCheck09[this]; }
            set { Fields.ItemNoProdCheck09[this] = value; }
        }

        [DisplayName("Item No Prod Check10"), Expression("jItemNo.[PROD_CHECK10]")]
        public String ItemNoProdCheck10
        {
            get { return Fields.ItemNoProdCheck10[this]; }
            set { Fields.ItemNoProdCheck10[this] = value; }
        }

        [DisplayName("Item No Prod Check11"), Expression("jItemNo.[PROD_CHECK11]")]
        public String ItemNoProdCheck11
        {
            get { return Fields.ItemNoProdCheck11[this]; }
            set { Fields.ItemNoProdCheck11[this] = value; }
        }

        [DisplayName("Item No Prod Check12"), Expression("jItemNo.[PROD_CHECK12]")]
        public String ItemNoProdCheck12
        {
            get { return Fields.ItemNoProdCheck12[this]; }
            set { Fields.ItemNoProdCheck12[this] = value; }
        }

        [DisplayName("Item No Prod Check13"), Expression("jItemNo.[PROD_CHECK13]")]
        public String ItemNoProdCheck13
        {
            get { return Fields.ItemNoProdCheck13[this]; }
            set { Fields.ItemNoProdCheck13[this] = value; }
        }

        [DisplayName("Item No Prod Check14"), Expression("jItemNo.[PROD_CHECK14]")]
        public String ItemNoProdCheck14
        {
            get { return Fields.ItemNoProdCheck14[this]; }
            set { Fields.ItemNoProdCheck14[this] = value; }
        }

        [DisplayName("Item No Prod Check15"), Expression("jItemNo.[PROD_CHECK15]")]
        public String ItemNoProdCheck15
        {
            get { return Fields.ItemNoProdCheck15[this]; }
            set { Fields.ItemNoProdCheck15[this] = value; }
        }

        [DisplayName("Item No Prod Check16"), Expression("jItemNo.[PROD_CHECK16]")]
        public String ItemNoProdCheck16
        {
            get { return Fields.ItemNoProdCheck16[this]; }
            set { Fields.ItemNoProdCheck16[this] = value; }
        }

        [DisplayName("Item No Prod Check17"), Expression("jItemNo.[PROD_CHECK17]")]
        public String ItemNoProdCheck17
        {
            get { return Fields.ItemNoProdCheck17[this]; }
            set { Fields.ItemNoProdCheck17[this] = value; }
        }

        [DisplayName("Item No Prod Check18"), Expression("jItemNo.[PROD_CHECK18]")]
        public String ItemNoProdCheck18
        {
            get { return Fields.ItemNoProdCheck18[this]; }
            set { Fields.ItemNoProdCheck18[this] = value; }
        }

        [DisplayName("Item No Prod Check19"), Expression("jItemNo.[PROD_CHECK19]")]
        public String ItemNoProdCheck19
        {
            get { return Fields.ItemNoProdCheck19[this]; }
            set { Fields.ItemNoProdCheck19[this] = value; }
        }

        [DisplayName("Item No Prod Check20"), Expression("jItemNo.[PROD_CHECK20]")]
        public String ItemNoProdCheck20
        {
            get { return Fields.ItemNoProdCheck20[this]; }
            set { Fields.ItemNoProdCheck20[this] = value; }
        }

        [DisplayName("Item No Last Pack Line No"), Expression("jItemNo.[LAST_PACK_LINE_NO]")]
        public Decimal? ItemNoLastPackLineNo
        {
            get { return Fields.ItemNoLastPackLineNo[this]; }
            set { Fields.ItemNoLastPackLineNo[this] = value; }
        }

        [DisplayName("Item No Putax Pcent"), Expression("jItemNo.[PUTAX_PCENT]")]
        public Decimal? ItemNoPutaxPcent
        {
            get { return Fields.ItemNoPutaxPcent[this]; }
            set { Fields.ItemNoPutaxPcent[this] = value; }
        }

        [DisplayName("Item No Acct Itm Sltax"), Expression("jItemNo.[ACCT_ITM_SLTAX]")]
        public String ItemNoAcctItmSltax
        {
            get { return Fields.ItemNoAcctItmSltax[this]; }
            set { Fields.ItemNoAcctItmSltax[this] = value; }
        }

        [DisplayName("Item No Sltax Pcent"), Expression("jItemNo.[SLTAX_PCENT]")]
        public Decimal? ItemNoSltaxPcent
        {
            get { return Fields.ItemNoSltaxPcent[this]; }
            set { Fields.ItemNoSltaxPcent[this] = value; }
        }

        [DisplayName("Item No Pur Uom"), Expression("jItemNo.[PUR_UOM]")]
        public String ItemNoPurUom
        {
            get { return Fields.ItemNoPurUom[this]; }
            set { Fields.ItemNoPurUom[this] = value; }
        }

        [DisplayName("Item No Pur Lot Size"), Expression("jItemNo.[PUR_LOT_SIZE]")]
        public Decimal? ItemNoPurLotSize
        {
            get { return Fields.ItemNoPurLotSize[this]; }
            set { Fields.ItemNoPurLotSize[this] = value; }
        }

        [DisplayName("Item No Pur Ccy"), Expression("jItemNo.[PUR_CCY]")]
        public String ItemNoPurCcy
        {
            get { return Fields.ItemNoPurCcy[this]; }
            set { Fields.ItemNoPurCcy[this] = value; }
        }

        [DisplayName("Item No Pur Base Price"), Expression("jItemNo.[PUR_BASE_PRICE]")]
        public Decimal? ItemNoPurBasePrice
        {
            get { return Fields.ItemNoPurBasePrice[this]; }
            set { Fields.ItemNoPurBasePrice[this] = value; }
        }

        [DisplayName("Item No Qty Net Available"), Expression("jItemNo.[QTY_NET_AVAILABLE]")]
        public Decimal? ItemNoQtyNetAvailable
        {
            get { return Fields.ItemNoQtyNetAvailable[this]; }
            set { Fields.ItemNoQtyNetAvailable[this] = value; }
        }

        [DisplayName("Item No Use Std Prod Lead Time"), Expression("jItemNo.[USE_STD_PROD_LEAD_TIME]")]
        public String ItemNoUseStdProdLeadTime
        {
            get { return Fields.ItemNoUseStdProdLeadTime[this]; }
            set { Fields.ItemNoUseStdProdLeadTime[this] = value; }
        }

        [DisplayName("Item No Daily Prod Qty"), Expression("jItemNo.[DAILY_PROD_QTY]")]
        public Decimal? ItemNoDailyProdQty
        {
            get { return Fields.ItemNoDailyProdQty[this]; }
            set { Fields.ItemNoDailyProdQty[this] = value; }
        }

        [DisplayName("Item No Issue Lot Size"), Expression("jItemNo.[ISSUE_LOT_SIZE]")]
        public Decimal? ItemNoIssueLotSize
        {
            get { return Fields.ItemNoIssueLotSize[this]; }
            set { Fields.ItemNoIssueLotSize[this] = value; }
        }

        [DisplayName("Item No Mrp Exclude"), Expression("jItemNo.[MRP_EXCLUDE]")]
        public String ItemNoMrpExclude
        {
            get { return Fields.ItemNoMrpExclude[this]; }
            set { Fields.ItemNoMrpExclude[this] = value; }
        }

        [DisplayName("Item No Enable Lot"), Expression("jItemNo.[ENABLE_LOT]")]
        public String ItemNoEnableLot
        {
            get { return Fields.ItemNoEnableLot[this]; }
            set { Fields.ItemNoEnableLot[this] = value; }
        }

        [DisplayName("Item No Enable Serial"), Expression("jItemNo.[ENABLE_SERIAL]")]
        public String ItemNoEnableSerial
        {
            get { return Fields.ItemNoEnableSerial[this]; }
            set { Fields.ItemNoEnableSerial[this] = value; }
        }

        [DisplayName("Item No Lot No Length"), Expression("jItemNo.[LOT_NO_LENGTH]")]
        public Decimal? ItemNoLotNoLength
        {
            get { return Fields.ItemNoLotNoLength[this]; }
            set { Fields.ItemNoLotNoLength[this] = value; }
        }

        [DisplayName("Item No Serial No Length"), Expression("jItemNo.[SERIAL_NO_LENGTH]")]
        public Decimal? ItemNoSerialNoLength
        {
            get { return Fields.ItemNoSerialNoLength[this]; }
            set { Fields.ItemNoSerialNoLength[this] = value; }
        }

        [DisplayName("Item No Next Lot No"), Expression("jItemNo.[NEXT_LOT_NO]")]
        public Decimal? ItemNoNextLotNo
        {
            get { return Fields.ItemNoNextLotNo[this]; }
            set { Fields.ItemNoNextLotNo[this] = value; }
        }

        [DisplayName("Item No Next Serial No"), Expression("jItemNo.[NEXT_SERIAL_NO]")]
        public Decimal? ItemNoNextSerialNo
        {
            get { return Fields.ItemNoNextSerialNo[this]; }
            set { Fields.ItemNoNextSerialNo[this] = value; }
        }

        [DisplayName("Item No Max Lot Size"), Expression("jItemNo.[MAX_LOT_SIZE]")]
        public Decimal? ItemNoMaxLotSize
        {
            get { return Fields.ItemNoMaxLotSize[this]; }
            set { Fields.ItemNoMaxLotSize[this] = value; }
        }

        [DisplayName("Item No Lot No Prefix"), Expression("jItemNo.[LOT_NO_PREFIX]")]
        public String ItemNoLotNoPrefix
        {
            get { return Fields.ItemNoLotNoPrefix[this]; }
            set { Fields.ItemNoLotNoPrefix[this] = value; }
        }

        [DisplayName("Item No Serial No Prefix"), Expression("jItemNo.[SERIAL_NO_PREFIX]")]
        public String ItemNoSerialNoPrefix
        {
            get { return Fields.ItemNoSerialNoPrefix[this]; }
            set { Fields.ItemNoSerialNoPrefix[this] = value; }
        }

        [DisplayName("Item No Safe Stock Lvl"), Expression("jItemNo.[SAFE_STOCK_LVL]")]
        public Decimal? ItemNoSafeStockLvl
        {
            get { return Fields.ItemNoSafeStockLvl[this]; }
            set { Fields.ItemNoSafeStockLvl[this] = value; }
        }

        [DisplayName("Item No Main Bin"), Expression("jItemNo.[MAIN_BIN]")]
        public String ItemNoMainBin
        {
            get { return Fields.ItemNoMainBin[this]; }
            set { Fields.ItemNoMainBin[this] = value; }
        }

        [DisplayName("Item No Custom Prod Code"), Expression("jItemNo.[CUSTOM_PROD_CODE]")]
        public String ItemNoCustomProdCode
        {
            get { return Fields.ItemNoCustomProdCode[this]; }
            set { Fields.ItemNoCustomProdCode[this] = value; }
        }

        [DisplayName("Item No Custom Lot Size"), Expression("jItemNo.[CUSTOM_LOT_SIZE]")]
        public Decimal? ItemNoCustomLotSize
        {
            get { return Fields.ItemNoCustomLotSize[this]; }
            set { Fields.ItemNoCustomLotSize[this] = value; }
        }

        [DisplayName("Item No Custom Gr Uom"), Expression("jItemNo.[CUSTOM_GR_UOM]")]
        public String ItemNoCustomGrUom
        {
            get { return Fields.ItemNoCustomGrUom[this]; }
            set { Fields.ItemNoCustomGrUom[this] = value; }
        }

        [DisplayName("Item No Custom Gr Wt"), Expression("jItemNo.[CUSTOM_GR_WT]")]
        public Decimal? ItemNoCustomGrWt
        {
            get { return Fields.ItemNoCustomGrWt[this]; }
            set { Fields.ItemNoCustomGrWt[this] = value; }
        }

        [DisplayName("Item No Custom Nt Wt"), Expression("jItemNo.[CUSTOM_NT_WT]")]
        public Decimal? ItemNoCustomNtWt
        {
            get { return Fields.ItemNoCustomNtWt[this]; }
            set { Fields.ItemNoCustomNtWt[this] = value; }
        }

        [DisplayName("Item No Custom Origin"), Expression("jItemNo.[CUSTOM_ORIGIN]")]
        public String ItemNoCustomOrigin
        {
            get { return Fields.ItemNoCustomOrigin[this]; }
            set { Fields.ItemNoCustomOrigin[this] = value; }
        }

        [DisplayName("Item No Is Approved"), Expression("jItemNo.[IS_APPROVED]")]
        public String ItemNoIsApproved
        {
            get { return Fields.ItemNoIsApproved[this]; }
            set { Fields.ItemNoIsApproved[this] = value; }
        }

        [DisplayName("Item No Approved By"), Expression("jItemNo.[APPROVED_BY]")]
        public String ItemNoApprovedBy
        {
            get { return Fields.ItemNoApprovedBy[this]; }
            set { Fields.ItemNoApprovedBy[this] = value; }
        }

        [DisplayName("Item No Preapprove"), Expression("jItemNo.[PREAPPROVE]")]
        public String ItemNoPreapprove
        {
            get { return Fields.ItemNoPreapprove[this]; }
            set { Fields.ItemNoPreapprove[this] = value; }
        }

        [DisplayName("Item No Approved Date"), Expression("jItemNo.[APPROVED_DATE]")]
        public DateTime? ItemNoApprovedDate
        {
            get { return Fields.ItemNoApprovedDate[this]; }
            set { Fields.ItemNoApprovedDate[this] = value; }
        }

        [DisplayName("Item No Qty On Transfer"), Expression("jItemNo.[QTY_ON_TRANSFER]")]
        public Decimal? ItemNoQtyOnTransfer
        {
            get { return Fields.ItemNoQtyOnTransfer[this]; }
            set { Fields.ItemNoQtyOnTransfer[this] = value; }
        }

        [DisplayName("Item No With Reset Lot"), Expression("jItemNo.[WITH_RESET_LOT]")]
        public String ItemNoWithResetLot
        {
            get { return Fields.ItemNoWithResetLot[this]; }
            set { Fields.ItemNoWithResetLot[this] = value; }
        }

        [DisplayName("Item No With Reset Serial"), Expression("jItemNo.[WITH_RESET_SERIAL]")]
        public String ItemNoWithResetSerial
        {
            get { return Fields.ItemNoWithResetSerial[this]; }
            set { Fields.ItemNoWithResetSerial[this] = value; }
        }

        [DisplayName("Item No Prev Reset Lot Date"), Expression("jItemNo.[PREV_RESET_LOT_DATE]")]
        public DateTime? ItemNoPrevResetLotDate
        {
            get { return Fields.ItemNoPrevResetLotDate[this]; }
            set { Fields.ItemNoPrevResetLotDate[this] = value; }
        }

        [DisplayName("Item No Prev Reset Serial Date"), Expression("jItemNo.[PREV_RESET_SERIAL_DATE]")]
        public DateTime? ItemNoPrevResetSerialDate
        {
            get { return Fields.ItemNoPrevResetSerialDate[this]; }
            set { Fields.ItemNoPrevResetSerialDate[this] = value; }
        }

        [DisplayName("Item No Autogen Lot"), Expression("jItemNo.[AUTOGEN_LOT]")]
        public String ItemNoAutogenLot
        {
            get { return Fields.ItemNoAutogenLot[this]; }
            set { Fields.ItemNoAutogenLot[this] = value; }
        }

        [DisplayName("Item No Autogen Serial"), Expression("jItemNo.[AUTOGEN_SERIAL]")]
        public String ItemNoAutogenSerial
        {
            get { return Fields.ItemNoAutogenSerial[this]; }
            set { Fields.ItemNoAutogenSerial[this] = value; }
        }

        [DisplayName("Item No Fab Item"), Expression("jItemNo.[FAB_ITEM]")]
        public String ItemNoFabItem
        {
            get { return Fields.ItemNoFabItem[this]; }
            set { Fields.ItemNoFabItem[this] = value; }
        }

        [DisplayName("Item No Anlys5"), Expression("jItemNo.[ANLYS5]")]
        public String ItemNoAnlys5
        {
            get { return Fields.ItemNoAnlys5[this]; }
            set { Fields.ItemNoAnlys5[this] = value; }
        }

        [DisplayName("Item No Anlys6"), Expression("jItemNo.[ANLYS6]")]
        public String ItemNoAnlys6
        {
            get { return Fields.ItemNoAnlys6[this]; }
            set { Fields.ItemNoAnlys6[this] = value; }
        }

        [DisplayName("Item No Anlys7"), Expression("jItemNo.[ANLYS7]")]
        public String ItemNoAnlys7
        {
            get { return Fields.ItemNoAnlys7[this]; }
            set { Fields.ItemNoAnlys7[this] = value; }
        }

        [DisplayName("Item No Anlys8"), Expression("jItemNo.[ANLYS8]")]
        public String ItemNoAnlys8
        {
            get { return Fields.ItemNoAnlys8[this]; }
            set { Fields.ItemNoAnlys8[this] = value; }
        }

        [DisplayName("Item No Anlys9"), Expression("jItemNo.[ANLYS9]")]
        public String ItemNoAnlys9
        {
            get { return Fields.ItemNoAnlys9[this]; }
            set { Fields.ItemNoAnlys9[this] = value; }
        }

        [DisplayName("Item No Anlys10"), Expression("jItemNo.[ANLYS10]")]
        public String ItemNoAnlys10
        {
            get { return Fields.ItemNoAnlys10[this]; }
            set { Fields.ItemNoAnlys10[this] = value; }
        }

        [DisplayName("Item No User Defined Field 1"), Expression("jItemNo.[USER_DEFINED_FIELD_1]")]
        public String ItemNoUserDefinedField1
        {
            get { return Fields.ItemNoUserDefinedField1[this]; }
            set { Fields.ItemNoUserDefinedField1[this] = value; }
        }

        [DisplayName("Item No User Defined Field 2"), Expression("jItemNo.[USER_DEFINED_FIELD_2]")]
        public String ItemNoUserDefinedField2
        {
            get { return Fields.ItemNoUserDefinedField2[this]; }
            set { Fields.ItemNoUserDefinedField2[this] = value; }
        }

        [DisplayName("Item No User Defined Field 3"), Expression("jItemNo.[USER_DEFINED_FIELD_3]")]
        public String ItemNoUserDefinedField3
        {
            get { return Fields.ItemNoUserDefinedField3[this]; }
            set { Fields.ItemNoUserDefinedField3[this] = value; }
        }

        [DisplayName("Item No User Defined Field 4"), Expression("jItemNo.[USER_DEFINED_FIELD_4]")]
        public String ItemNoUserDefinedField4
        {
            get { return Fields.ItemNoUserDefinedField4[this]; }
            set { Fields.ItemNoUserDefinedField4[this] = value; }
        }

        [DisplayName("Item No User Defined Field 5"), Expression("jItemNo.[USER_DEFINED_FIELD_5]")]
        public String ItemNoUserDefinedField5
        {
            get { return Fields.ItemNoUserDefinedField5[this]; }
            set { Fields.ItemNoUserDefinedField5[this] = value; }
        }

        [DisplayName("Item No User Defined Field 6"), Expression("jItemNo.[USER_DEFINED_FIELD_6]")]
        public String ItemNoUserDefinedField6
        {
            get { return Fields.ItemNoUserDefinedField6[this]; }
            set { Fields.ItemNoUserDefinedField6[this] = value; }
        }

        [DisplayName("Item No User Defined Field 7"), Expression("jItemNo.[USER_DEFINED_FIELD_7]")]
        public String ItemNoUserDefinedField7
        {
            get { return Fields.ItemNoUserDefinedField7[this]; }
            set { Fields.ItemNoUserDefinedField7[this] = value; }
        }

        [DisplayName("Item No User Defined Field 8"), Expression("jItemNo.[USER_DEFINED_FIELD_8]")]
        public String ItemNoUserDefinedField8
        {
            get { return Fields.ItemNoUserDefinedField8[this]; }
            set { Fields.ItemNoUserDefinedField8[this] = value; }
        }

        [DisplayName("Item No User Defined Field 9"), Expression("jItemNo.[USER_DEFINED_FIELD_9]")]
        public String ItemNoUserDefinedField9
        {
            get { return Fields.ItemNoUserDefinedField9[this]; }
            set { Fields.ItemNoUserDefinedField9[this] = value; }
        }

        [DisplayName("Item No User Defined Field 10"), Expression("jItemNo.[USER_DEFINED_FIELD_10]")]
        public String ItemNoUserDefinedField10
        {
            get { return Fields.ItemNoUserDefinedField10[this]; }
            set { Fields.ItemNoUserDefinedField10[this] = value; }
        }

        [DisplayName("Item No User Defined Field 11"), Expression("jItemNo.[USER_DEFINED_FIELD_11]")]
        public String ItemNoUserDefinedField11
        {
            get { return Fields.ItemNoUserDefinedField11[this]; }
            set { Fields.ItemNoUserDefinedField11[this] = value; }
        }

        [DisplayName("Item No User Defined Field 12"), Expression("jItemNo.[USER_DEFINED_FIELD_12]")]
        public String ItemNoUserDefinedField12
        {
            get { return Fields.ItemNoUserDefinedField12[this]; }
            set { Fields.ItemNoUserDefinedField12[this] = value; }
        }

        [DisplayName("Item No User Defined Field 13"), Expression("jItemNo.[USER_DEFINED_FIELD_13]")]
        public String ItemNoUserDefinedField13
        {
            get { return Fields.ItemNoUserDefinedField13[this]; }
            set { Fields.ItemNoUserDefinedField13[this] = value; }
        }

        [DisplayName("Item No User Defined Field 14"), Expression("jItemNo.[USER_DEFINED_FIELD_14]")]
        public String ItemNoUserDefinedField14
        {
            get { return Fields.ItemNoUserDefinedField14[this]; }
            set { Fields.ItemNoUserDefinedField14[this] = value; }
        }

        [DisplayName("Item No User Defined Field 15"), Expression("jItemNo.[USER_DEFINED_FIELD_15]")]
        public String ItemNoUserDefinedField15
        {
            get { return Fields.ItemNoUserDefinedField15[this]; }
            set { Fields.ItemNoUserDefinedField15[this] = value; }
        }

        [DisplayName("Item No User Defined Field 16"), Expression("jItemNo.[USER_DEFINED_FIELD_16]")]
        public String ItemNoUserDefinedField16
        {
            get { return Fields.ItemNoUserDefinedField16[this]; }
            set { Fields.ItemNoUserDefinedField16[this] = value; }
        }

        [DisplayName("Item No User Defined Field 17"), Expression("jItemNo.[USER_DEFINED_FIELD_17]")]
        public String ItemNoUserDefinedField17
        {
            get { return Fields.ItemNoUserDefinedField17[this]; }
            set { Fields.ItemNoUserDefinedField17[this] = value; }
        }

        [DisplayName("Item No User Defined Field 18"), Expression("jItemNo.[USER_DEFINED_FIELD_18]")]
        public String ItemNoUserDefinedField18
        {
            get { return Fields.ItemNoUserDefinedField18[this]; }
            set { Fields.ItemNoUserDefinedField18[this] = value; }
        }

        [DisplayName("Item No User Defined Field 19"), Expression("jItemNo.[USER_DEFINED_FIELD_19]")]
        public String ItemNoUserDefinedField19
        {
            get { return Fields.ItemNoUserDefinedField19[this]; }
            set { Fields.ItemNoUserDefinedField19[this] = value; }
        }

        [DisplayName("Item No User Defined Field 20"), Expression("jItemNo.[USER_DEFINED_FIELD_20]")]
        public String ItemNoUserDefinedField20
        {
            get { return Fields.ItemNoUserDefinedField20[this]; }
            set { Fields.ItemNoUserDefinedField20[this] = value; }
        }

        [DisplayName("Item No Rohs Compliance"), Expression("jItemNo.[ROHS_COMPLIANCE]")]
        public Boolean? ItemNoRohsCompliance
        {
            get { return Fields.ItemNoRohsCompliance[this]; }
            set { Fields.ItemNoRohsCompliance[this] = value; }
        }

        [DisplayName("Item No Def Mold Bom No"), Expression("jItemNo.[DEF_MOLD_BOM_NO]")]
        public String ItemNoDefMoldBomNo
        {
            get { return Fields.ItemNoDefMoldBomNo[this]; }
            set { Fields.ItemNoDefMoldBomNo[this] = value; }
        }

        [DisplayName("Item No Def Formula Code"), Expression("jItemNo.[DEF_FORMULA_CODE]")]
        public String ItemNoDefFormulaCode
        {
            get { return Fields.ItemNoDefFormulaCode[this]; }
            set { Fields.ItemNoDefFormulaCode[this] = value; }
        }

        [DisplayName("Item No Box Type"), Expression("jItemNo.[BOX_TYPE]")]
        public String ItemNoBoxType
        {
            get { return Fields.ItemNoBoxType[this]; }
            set { Fields.ItemNoBoxType[this] = value; }
        }

        [DisplayName("Item No Box Length"), Expression("jItemNo.[BOX_LENGTH]")]
        public Decimal? ItemNoBoxLength
        {
            get { return Fields.ItemNoBoxLength[this]; }
            set { Fields.ItemNoBoxLength[this] = value; }
        }

        [DisplayName("Item No Box Width"), Expression("jItemNo.[BOX_WIDTH]")]
        public Decimal? ItemNoBoxWidth
        {
            get { return Fields.ItemNoBoxWidth[this]; }
            set { Fields.ItemNoBoxWidth[this] = value; }
        }

        [DisplayName("Item No Box Height"), Expression("jItemNo.[BOX_HEIGHT]")]
        public Decimal? ItemNoBoxHeight
        {
            get { return Fields.ItemNoBoxHeight[this]; }
            set { Fields.ItemNoBoxHeight[this] = value; }
        }

        [DisplayName("Item No Box D Uom"), Expression("jItemNo.[BOX_D_UOM]")]
        public String ItemNoBoxDUom
        {
            get { return Fields.ItemNoBoxDUom[this]; }
            set { Fields.ItemNoBoxDUom[this] = value; }
        }

        [DisplayName("Item No Wd"), Expression("jItemNo.[WD]")]
        public Decimal? ItemNoWd
        {
            get { return Fields.ItemNoWd[this]; }
            set { Fields.ItemNoWd[this] = value; }
        }

        [DisplayName("Item No Wd Uom"), Expression("jItemNo.[WD_UOM]")]
        public String ItemNoWdUom
        {
            get { return Fields.ItemNoWdUom[this]; }
            set { Fields.ItemNoWdUom[this] = value; }
        }

        [DisplayName("Item No Cs Length"), Expression("jItemNo.[CS_LENGTH]")]
        public Decimal? ItemNoCsLength
        {
            get { return Fields.ItemNoCsLength[this]; }
            set { Fields.ItemNoCsLength[this] = value; }
        }

        [DisplayName("Item No Cs Width"), Expression("jItemNo.[CS_WIDTH]")]
        public Decimal? ItemNoCsWidth
        {
            get { return Fields.ItemNoCsWidth[this]; }
            set { Fields.ItemNoCsWidth[this] = value; }
        }

        [DisplayName("Item No User Defined Field 21"), Expression("jItemNo.[USER_DEFINED_FIELD_21]")]
        public String ItemNoUserDefinedField21
        {
            get { return Fields.ItemNoUserDefinedField21[this]; }
            set { Fields.ItemNoUserDefinedField21[this] = value; }
        }

        [DisplayName("Item No Cost Wmove"), Expression("jItemNo.[COST_WMOVE]")]
        public Decimal? ItemNoCostWmove
        {
            get { return Fields.ItemNoCostWmove[this]; }
            set { Fields.ItemNoCostWmove[this] = value; }
        }

        [DisplayName("Item No Cost Wcase"), Expression("jItemNo.[COST_WCASE]")]
        public Decimal? ItemNoCostWcase
        {
            get { return Fields.ItemNoCostWcase[this]; }
            set { Fields.ItemNoCostWcase[this] = value; }
        }

        [DisplayName("Item No Cost Wband"), Expression("jItemNo.[COST_WBAND]")]
        public Decimal? ItemNoCostWband
        {
            get { return Fields.ItemNoCostWband[this]; }
            set { Fields.ItemNoCostWband[this] = value; }
        }

        [DisplayName("Item No Cost Batt"), Expression("jItemNo.[COST_BATT]")]
        public Decimal? ItemNoCostBatt
        {
            get { return Fields.ItemNoCostBatt[this]; }
            set { Fields.ItemNoCostBatt[this] = value; }
        }

        [DisplayName("Item No Desc Wmove"), Expression("jItemNo.[DESC_WMOVE]")]
        public String ItemNoDescWmove
        {
            get { return Fields.ItemNoDescWmove[this]; }
            set { Fields.ItemNoDescWmove[this] = value; }
        }

        [DisplayName("Item No Desc Wcase"), Expression("jItemNo.[DESC_WCASE]")]
        public String ItemNoDescWcase
        {
            get { return Fields.ItemNoDescWcase[this]; }
            set { Fields.ItemNoDescWcase[this] = value; }
        }

        [DisplayName("Item No Desc Wband"), Expression("jItemNo.[DESC_WBAND]")]
        public String ItemNoDescWband
        {
            get { return Fields.ItemNoDescWband[this]; }
            set { Fields.ItemNoDescWband[this] = value; }
        }

        [DisplayName("Item No Desc Batt"), Expression("jItemNo.[DESC_BATT]")]
        public String ItemNoDescBatt
        {
            get { return Fields.ItemNoDescBatt[this]; }
            set { Fields.ItemNoDescBatt[this] = value; }
        }

        [DisplayName("Item No Po Bal"), Expression("jItemNo.[PO_BAL]")]
        public Decimal? ItemNoPoBal
        {
            get { return Fields.ItemNoPoBal[this]; }
            set { Fields.ItemNoPoBal[this] = value; }
        }

        [DisplayName("Item No Po Max Bal"), Expression("jItemNo.[PO_MAX_BAL]")]
        public Decimal? ItemNoPoMaxBal
        {
            get { return Fields.ItemNoPoMaxBal[this]; }
            set { Fields.ItemNoPoMaxBal[this] = value; }
        }

        [DisplayName("Item No Include Job"), Expression("jItemNo.[INCLUDE_JOB]")]
        public Boolean? ItemNoIncludeJob
        {
            get { return Fields.ItemNoIncludeJob[this]; }
            set { Fields.ItemNoIncludeJob[this] = value; }
        }

        [DisplayName("Item No Cs Thickness"), Expression("jItemNo.[CS_THICKNESS]")]
        public Decimal? ItemNoCsThickness
        {
            get { return Fields.ItemNoCsThickness[this]; }
            set { Fields.ItemNoCsThickness[this] = value; }
        }

        [DisplayName("Item No Cs Thickness Uom"), Expression("jItemNo.[CS_THICKNESS_UOM]")]
        public String ItemNoCsThicknessUom
        {
            get { return Fields.ItemNoCsThicknessUom[this]; }
            set { Fields.ItemNoCsThicknessUom[this] = value; }
        }

        [DisplayName("Item No Cs Proportion"), Expression("jItemNo.[CS_PROPORTION]")]
        public Decimal? ItemNoCsProportion
        {
            get { return Fields.ItemNoCsProportion[this]; }
            set { Fields.ItemNoCsProportion[this] = value; }
        }

        [DisplayName("Item No Cs Proportion Uom"), Expression("jItemNo.[CS_PROPORTION_UOM]")]
        public String ItemNoCsProportionUom
        {
            get { return Fields.ItemNoCsProportionUom[this]; }
            set { Fields.ItemNoCsProportionUom[this] = value; }
        }

        [DisplayName("Item No Die Cutter"), Expression("jItemNo.[DIE_CUTTER]")]
        public Decimal? ItemNoDieCutter
        {
            get { return Fields.ItemNoDieCutter[this]; }
            set { Fields.ItemNoDieCutter[this] = value; }
        }

        [DisplayName("Item No Mat Inspect Lead Time"), Expression("jItemNo.[MAT_INSPECT_LEAD_TIME]")]
        public Decimal? ItemNoMatInspectLeadTime
        {
            get { return Fields.ItemNoMatInspectLeadTime[this]; }
            set { Fields.ItemNoMatInspectLeadTime[this] = value; }
        }

        [DisplayName("Item No Mat Prepare Lead Time"), Expression("jItemNo.[MAT_PREPARE_LEAD_TIME]")]
        public Decimal? ItemNoMatPrepareLeadTime
        {
            get { return Fields.ItemNoMatPrepareLeadTime[this]; }
            set { Fields.ItemNoMatPrepareLeadTime[this] = value; }
        }

        [DisplayName("Item No Mat Inspect Lead Unit"), Expression("jItemNo.[MAT_INSPECT_LEAD_UNIT]")]
        public String ItemNoMatInspectLeadUnit
        {
            get { return Fields.ItemNoMatInspectLeadUnit[this]; }
            set { Fields.ItemNoMatInspectLeadUnit[this] = value; }
        }

        [DisplayName("Item No Mat Prepare Lead Unit"), Expression("jItemNo.[MAT_PREPARE_LEAD_UNIT]")]
        public String ItemNoMatPrepareLeadUnit
        {
            get { return Fields.ItemNoMatPrepareLeadUnit[this]; }
            set { Fields.ItemNoMatPrepareLeadUnit[this] = value; }
        }

        [DisplayName("Item No Color Code"), Expression("jItemNo.[COLOR_CODE]")]
        public String ItemNoColorCode
        {
            get { return Fields.ItemNoColorCode[this]; }
            set { Fields.ItemNoColorCode[this] = value; }
        }

        [DisplayName("Item No Collection Code"), Expression("jItemNo.[COLLECTION_CODE]")]
        public String ItemNoCollectionCode
        {
            get { return Fields.ItemNoCollectionCode[this]; }
            set { Fields.ItemNoCollectionCode[this] = value; }
        }

        [DisplayName("Item No Style Code"), Expression("jItemNo.[STYLE_CODE]")]
        public String ItemNoStyleCode
        {
            get { return Fields.ItemNoStyleCode[this]; }
            set { Fields.ItemNoStyleCode[this] = value; }
        }

        [DisplayName("Item No X"), Expression("jItemNo.[X]")]
        public Decimal? ItemNoX
        {
            get { return Fields.ItemNoX[this]; }
            set { Fields.ItemNoX[this] = value; }
        }

        [DisplayName("Item No Y"), Expression("jItemNo.[Y]")]
        public Decimal? ItemNoY
        {
            get { return Fields.ItemNoY[this]; }
            set { Fields.ItemNoY[this] = value; }
        }

        [DisplayName("Item No Temp Description"), Expression("jItemNo.[TEMP_DESCRIPTION]")]
        public String ItemNoTempDescription
        {
            get { return Fields.ItemNoTempDescription[this]; }
            set { Fields.ItemNoTempDescription[this] = value; }
        }

        [DisplayName("Item No Specification"), Expression("jItemNo.[SPECIFICATION]")]
        public String ItemNoSpecification
        {
            get { return Fields.ItemNoSpecification[this]; }
            set { Fields.ItemNoSpecification[this] = value; }
        }

        [DisplayName("Item No X Uom"), Expression("jItemNo.[X_UOM]")]
        public String ItemNoXUom
        {
            get { return Fields.ItemNoXUom[this]; }
            set { Fields.ItemNoXUom[this] = value; }
        }

        [DisplayName("Item No Y Uom"), Expression("jItemNo.[Y_UOM]")]
        public String ItemNoYUom
        {
            get { return Fields.ItemNoYUom[this]; }
            set { Fields.ItemNoYUom[this] = value; }
        }

        [DisplayName("Item No Production Uom Conversion Rate"), Expression("jItemNo.[PRODUCTION_UOM_CONVERSION_RATE]")]
        public Decimal? ItemNoProductionUomConversionRate
        {
            get { return Fields.ItemNoProductionUomConversionRate[this]; }
            set { Fields.ItemNoProductionUomConversionRate[this] = value; }
        }

        [DisplayName("Item No Purchase Uom Conversion Rate"), Expression("jItemNo.[PURCHASE_UOM_CONVERSION_RATE]")]
        public Decimal? ItemNoPurchaseUomConversionRate
        {
            get { return Fields.ItemNoPurchaseUomConversionRate[this]; }
            set { Fields.ItemNoPurchaseUomConversionRate[this] = value; }
        }

        [DisplayName("Item No Autogen Lot Issue"), Expression("jItemNo.[AUTOGEN_LOT_ISSUE]")]
        public Boolean? ItemNoAutogenLotIssue
        {
            get { return Fields.ItemNoAutogenLotIssue[this]; }
            set { Fields.ItemNoAutogenLotIssue[this] = value; }
        }

        [DisplayName("Item No Autogen Serial Issue"), Expression("jItemNo.[AUTOGEN_SERIAL_ISSUE]")]
        public Boolean? ItemNoAutogenSerialIssue
        {
            get { return Fields.ItemNoAutogenSerialIssue[this]; }
            set { Fields.ItemNoAutogenSerialIssue[this] = value; }
        }

        [DisplayName("Item No Wc Cost Ccy"), Expression("jItemNo.[WC_COST_CCY]")]
        public String ItemNoWcCostCcy
        {
            get { return Fields.ItemNoWcCostCcy[this]; }
            set { Fields.ItemNoWcCostCcy[this] = value; }
        }

        [DisplayName("Item No Wc Cost"), Expression("jItemNo.[WC_COST]")]
        public Decimal? ItemNoWcCost
        {
            get { return Fields.ItemNoWcCost[this]; }
            set { Fields.ItemNoWcCost[this] = value; }
        }

        [DisplayName("Item No Wc Cost Disc"), Expression("jItemNo.[WC_COST_DISC]")]
        public Decimal? ItemNoWcCostDisc
        {
            get { return Fields.ItemNoWcCostDisc[this]; }
            set { Fields.ItemNoWcCostDisc[this] = value; }
        }

        [DisplayName("Item No Wc Cost Exch"), Expression("jItemNo.[WC_COST_EXCH]")]
        public Decimal? ItemNoWcCostExch
        {
            get { return Fields.ItemNoWcCostExch[this]; }
            set { Fields.ItemNoWcCostExch[this] = value; }
        }

        [DisplayName("Item No Wc Freight"), Expression("jItemNo.[WC_FREIGHT]")]
        public Decimal? ItemNoWcFreight
        {
            get { return Fields.ItemNoWcFreight[this]; }
            set { Fields.ItemNoWcFreight[this] = value; }
        }

        [DisplayName("Item No Wc Margin"), Expression("jItemNo.[WC_MARGIN]")]
        public Decimal? ItemNoWcMargin
        {
            get { return Fields.ItemNoWcMargin[this]; }
            set { Fields.ItemNoWcMargin[this] = value; }
        }

        [DisplayName("Item No Ceiling Price"), Expression("jItemNo.[CEILING_PRICE]")]
        public Decimal? ItemNoCeilingPrice
        {
            get { return Fields.ItemNoCeilingPrice[this]; }
            set { Fields.ItemNoCeilingPrice[this] = value; }
        }

        [DisplayName("Item No Bottom Ratio"), Expression("jItemNo.[BOTTOM_RATIO]")]
        public Decimal? ItemNoBottomRatio
        {
            get { return Fields.ItemNoBottomRatio[this]; }
            set { Fields.ItemNoBottomRatio[this] = value; }
        }

        [DisplayName("Item No Bottom Price"), Expression("jItemNo.[BOTTOM_PRICE]")]
        public Decimal? ItemNoBottomPrice
        {
            get { return Fields.ItemNoBottomPrice[this]; }
            set { Fields.ItemNoBottomPrice[this] = value; }
        }

        [DisplayName("Item No Drawing No"), Expression("jItemNo.[DRAWING_NO]")]
        public String ItemNoDrawingNo
        {
            get { return Fields.ItemNoDrawingNo[this]; }
            set { Fields.ItemNoDrawingNo[this] = value; }
        }

        [DisplayName("Item No Material Type"), Expression("jItemNo.[MATERIAL_TYPE]")]
        public String ItemNoMaterialType
        {
            get { return Fields.ItemNoMaterialType[this]; }
            set { Fields.ItemNoMaterialType[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Loc; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public InventoryBalanceRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField Loc;
            public StringField ItemNo;
            public StringField Loc2;
            public StringField ItemNo2;
            public StringField Description;
            public StringField Uom;
            public DateTimeField LastDateIn;
            public DateTimeField LastDateOut;
            public StringField WithBalance;
            public DecimalField QtyOnHand;
            public DecimalField QtyWaitlisted;
            public DecimalField QtyReserved;
            public DecimalField QtyCommitted;
            public DecimalField QtyAvailable;
            public DecimalField QtyUnallocated;
            public DecimalField InvtCostAvail;
            public DecimalField InvtCostLdg;
            public StringField AverageCost;
            public DecimalField LatestCost;
            public DateTimeField LastCountDate;
            public StringField DefaultBinNo;
            public DecimalField QtyOnInspect;
            public DecimalField QtyOnTransfer;

            public DecimalField LocRecnum;
            public StringField LocDescription;
            public StringField LocSuspended;
            public StringField LocAddress;
            public StringField LocAddress2;
            public StringField LocAddress3;
            public StringField LocAddress4;
            public StringField LocBranchNo;
            public StringField LocNoReservation;
            public StringField LocNoWaitlist;
            public StringField LocNoAvailable;
            public StringField LocNoPlanning;
            public StringField LocNoIssuance;
            public StringField LocNoReceipts;
            public StringField LocNoMatIssue;
            public StringField LocNoFgReturn;
            public StringField LocNoShipment;
            public StringField LocNoGrn;
            public StringField LocWithBacklog;
            public DecimalField LocOnSorderCount;
            public DecimalField LocOnPorderCount;
            public DecimalField LocOnJorderCount;
            public DecimalField LocInvtCostAvail;
            public DecimalField LocInvtCostLdg;
            public DateTimeField LocCreatedDate;
            public StringField LocCreatedBy;
            public DateTimeField LocRevisedDate;
            public StringField LocRevisedBy;
            public StringField LocOwnerBranch;
            public StringField LocSourceBranch;
            public StringField LocWithBinCtrl;
            public BooleanField LocWithPackingBox;

            public DecimalField ItemNoRecnum;
            public StringField ItemNoDescription;
            public StringField ItemNoSuspended;
            public StringField ItemNoItemGroup;
            public StringField ItemNoCharges;
            public StringField ItemNoProduct;
            public StringField ItemNoMaterial;
            public StringField ItemNoInspected;
            public StringField ItemNoItemType;
            public StringField ItemNoStockUom;
            public StringField ItemNoMainLoc;
            public StringField ItemNoMakeBuy;
            public StringField ItemNoAllocMethod;
            public StringField ItemNoStdCostOk;
            public StringField ItemNoCostCentre;
            public StringField ItemNoCycleCode;
            public StringField ItemNoAnlys1;
            public StringField ItemNoAnlys2;
            public StringField ItemNoAnlys3;
            public StringField ItemNoAnlys4;
            public StringField ItemNoDefSpecNo;
            public DecimalField ItemNoDefSpecCount;
            public DateTimeField ItemNoCreatedDate;
            public StringField ItemNoCreatedBy;
            public DateTimeField ItemNoRevisedDate;
            public StringField ItemNoRevisedBy;
            public StringField ItemNoWithBacklog;
            public StringField ItemNoWithBalance;
            public DecimalField ItemNoQtyOnHand;
            public DecimalField ItemNoQtyOnSorder;
            public DecimalField ItemNoQtyOnPorder;
            public DecimalField ItemNoQtyOnJorder;
            public DecimalField ItemNoQtyOnInspect;
            public DecimalField ItemNoQtyWaitlisted;
            public DecimalField ItemNoQtyReserved;
            public DecimalField ItemNoQtyCommitted;
            public DecimalField ItemNoQtyAvailable;
            public DecimalField ItemNoQtyUnallocated;
            public DecimalField ItemNoInvtCostAvail;
            public DecimalField ItemNoInvtCostLdg;
            public StringField ItemNoAverageCost;
            public DecimalField ItemNoLatestCost;
            public DecimalField ItemNoStdCost;
            public DateTimeField ItemNoLastCountDate;
            public DateTimeField ItemNoLastDateIn;
            public DateTimeField ItemNoLastDateOut;
            public StringField ItemNoSalesUom;
            public DecimalField ItemNoSalesLotSize;
            public StringField ItemNoPriceCcy;
            public DecimalField ItemNoBasePrice;
            public DecimalField ItemNoPricea;
            public DecimalField ItemNoPriceb;
            public DecimalField ItemNoPricec;
            public DecimalField ItemNoMinPrice;
            public DecimalField ItemNoMaxPrice;
            public DecimalField ItemNoMinOrderQty;
            public DecimalField ItemNoMaxOrderQty;
            public DecimalField ItemNoMinOrderDays;
            public StringField ItemNoInnerPkgType;
            public DecimalField ItemNoInnerQty;
            public StringField ItemNoOuterPkgType;
            public DecimalField ItemNoOuterQty;
            public StringField ItemNoArticleCode;
            public StringField ItemNoQuotaCategory;
            public StringField ItemNoWeightUom;
            public DecimalField ItemNoGrossWt;
            public DecimalField ItemNoNetWt;
            public StringField ItemNoDimensionUom;
            public DecimalField ItemNoFlength;
            public DecimalField ItemNoWidth;
            public DecimalField ItemNoHeight;
            public DecimalField ItemNoComputedVol;
            public DecimalField ItemNoDeclaredVol;
            public DateTimeField ItemNoSrevisedDate;
            public StringField ItemNoSrevisedBy;
            public StringField ItemNoMpsItem;
            public StringField ItemNoOrderPolicy;
            public DecimalField ItemNoMinPlanordQty;
            public DecimalField ItemNoMaxPlanordQty;
            public DecimalField ItemNoStdPlanordQty;
            public DecimalField ItemNoMinPlanordPrd;
            public DecimalField ItemNoMaxPlanordPrd;
            public DecimalField ItemNoStdPlanordPrd;
            public DecimalField ItemNoReorderPt;
            public DecimalField ItemNoReorderQty;
            public DecimalField ItemNoMinMthlyProd;
            public DecimalField ItemNoMaxMthlyProd;
            public DecimalField ItemNoMinMthlyPur;
            public DecimalField ItemNoMaxMthlyPur;
            public StringField ItemNoFollowMinProd;
            public StringField ItemNoFollowMaxProd;
            public StringField ItemNoFollowMinPur;
            public StringField ItemNoFollowMaxPur;
            public StringField ItemNoAllowMixMode;
            public StringField ItemNoPrefVendOnly;
            public StringField ItemNoPrefVend1;
            public StringField ItemNoPrefVend2;
            public DecimalField ItemNoProdLeadTime;
            public StringField ItemNoProdLeadUnit;
            public DecimalField ItemNoPurLeadTime;
            public StringField ItemNoPurLeadUnit;
            public StringField ItemNoPlanner;
            public DateTimeField ItemNoMrpParmDate;
            public StringField ItemNoMrpParmBy;
            public StringField ItemNoAltDescription;
            public StringField ItemNoPictureFile;
            public StringField ItemNoAcctItmAsset;
            public StringField ItemNoAcctItmWip;
            public StringField ItemNoAcctItmConsum;
            public StringField ItemNoAcctItmScrap;
            public StringField ItemNoAcctItmPvar;
            public StringField ItemNoAcctItmReval;
            public StringField ItemNoAcctItmVaria;
            public StringField ItemNoAcctItmSales;
            public StringField ItemNoAcctItmSlret;
            public StringField ItemNoAcctItmSldisc;
            public StringField ItemNoAcctItmCogs;
            public StringField ItemNoAcctItmPurch;
            public StringField ItemNoAcctItmPuret;
            public StringField ItemNoAcctItmPudisc;
            public StringField ItemNoAcctItmPutax;
            public StringField ItemNoAcctMachine;
            public StringField ItemNoAcctEnergy;
            public StringField ItemNoAcctWater;
            public StringField ItemNoAcctRental;
            public StringField ItemNoAcctLabor;
            public StringField ItemNoAcctInlab;
            public StringField ItemNoAcctInmat;
            public StringField ItemNoAcctMisc;
            public DateTimeField ItemNoArevisedDate;
            public StringField ItemNoArevisedBy;
            public DateTimeField ItemNoBrevisedDate;
            public StringField ItemNoBrevisedBy;
            public StringField ItemNoSalesLtaxCode;
            public StringField ItemNoPurchLtaxCode;
            public DateTimeField ItemNoTrevisedDate;
            public StringField ItemNoTrevisedBy;
            public DecimalField ItemNoSpecsCount;
            public StringField ItemNoDefBomNo;
            public DecimalField ItemNoLastSnapNo;
            public StringField ItemNoCommisType;
            public StringField ItemNoProdBranch;
            public StringField ItemNoOwnerBranch;
            public StringField ItemNoSourceBranch;
            public DecimalField ItemNoScrapRate;
            public StringField ItemNoAltExtDesc;
            public StringField ItemNoExtendedDesc;
            public StringField ItemNoPurPriceCtrl;
            public DecimalField ItemNoPurMaxDev;
            public StringField ItemNoWebItem;
            public StringField ItemNoAcctItmSubcon;
            public StringField ItemNoWithBinCtrl;
            public StringField ItemNoConsign;
            public StringField ItemNoProdDevt01;
            public StringField ItemNoProdDevt02;
            public StringField ItemNoProdDevt03;
            public StringField ItemNoProdDevt04;
            public StringField ItemNoProdDevt05;
            public StringField ItemNoProdDevt06;
            public StringField ItemNoProdDevt07;
            public StringField ItemNoProdDevt08;
            public StringField ItemNoProdDevt09;
            public StringField ItemNoProdDevt10;
            public StringField ItemNoProdDevt11;
            public StringField ItemNoProdDevt12;
            public StringField ItemNoProdDevt13;
            public StringField ItemNoProdDevt14;
            public StringField ItemNoProdDevt15;
            public StringField ItemNoProdDevt16;
            public StringField ItemNoProdDevt17;
            public StringField ItemNoProdDevt18;
            public StringField ItemNoProdDevt19;
            public StringField ItemNoProdDevt20;
            public StringField ItemNoProdCheck01;
            public StringField ItemNoProdCheck02;
            public StringField ItemNoProdCheck03;
            public StringField ItemNoProdCheck04;
            public StringField ItemNoProdCheck05;
            public StringField ItemNoProdCheck06;
            public StringField ItemNoProdCheck07;
            public StringField ItemNoProdCheck08;
            public StringField ItemNoProdCheck09;
            public StringField ItemNoProdCheck10;
            public StringField ItemNoProdCheck11;
            public StringField ItemNoProdCheck12;
            public StringField ItemNoProdCheck13;
            public StringField ItemNoProdCheck14;
            public StringField ItemNoProdCheck15;
            public StringField ItemNoProdCheck16;
            public StringField ItemNoProdCheck17;
            public StringField ItemNoProdCheck18;
            public StringField ItemNoProdCheck19;
            public StringField ItemNoProdCheck20;
            public DecimalField ItemNoLastPackLineNo;
            public DecimalField ItemNoPutaxPcent;
            public StringField ItemNoAcctItmSltax;
            public DecimalField ItemNoSltaxPcent;
            public StringField ItemNoPurUom;
            public DecimalField ItemNoPurLotSize;
            public StringField ItemNoPurCcy;
            public DecimalField ItemNoPurBasePrice;
            public DecimalField ItemNoQtyNetAvailable;
            public StringField ItemNoUseStdProdLeadTime;
            public DecimalField ItemNoDailyProdQty;
            public DecimalField ItemNoIssueLotSize;
            public StringField ItemNoMrpExclude;
            public StringField ItemNoEnableLot;
            public StringField ItemNoEnableSerial;
            public DecimalField ItemNoLotNoLength;
            public DecimalField ItemNoSerialNoLength;
            public DecimalField ItemNoNextLotNo;
            public DecimalField ItemNoNextSerialNo;
            public DecimalField ItemNoMaxLotSize;
            public StringField ItemNoLotNoPrefix;
            public StringField ItemNoSerialNoPrefix;
            public DecimalField ItemNoSafeStockLvl;
            public StringField ItemNoMainBin;
            public StringField ItemNoCustomProdCode;
            public DecimalField ItemNoCustomLotSize;
            public StringField ItemNoCustomGrUom;
            public DecimalField ItemNoCustomGrWt;
            public DecimalField ItemNoCustomNtWt;
            public StringField ItemNoCustomOrigin;
            public StringField ItemNoIsApproved;
            public StringField ItemNoApprovedBy;
            public StringField ItemNoPreapprove;
            public DateTimeField ItemNoApprovedDate;
            public DecimalField ItemNoQtyOnTransfer;
            public StringField ItemNoWithResetLot;
            public StringField ItemNoWithResetSerial;
            public DateTimeField ItemNoPrevResetLotDate;
            public DateTimeField ItemNoPrevResetSerialDate;
            public StringField ItemNoAutogenLot;
            public StringField ItemNoAutogenSerial;
            public StringField ItemNoFabItem;
            public StringField ItemNoAnlys5;
            public StringField ItemNoAnlys6;
            public StringField ItemNoAnlys7;
            public StringField ItemNoAnlys8;
            public StringField ItemNoAnlys9;
            public StringField ItemNoAnlys10;
            public StringField ItemNoUserDefinedField1;
            public StringField ItemNoUserDefinedField2;
            public StringField ItemNoUserDefinedField3;
            public StringField ItemNoUserDefinedField4;
            public StringField ItemNoUserDefinedField5;
            public StringField ItemNoUserDefinedField6;
            public StringField ItemNoUserDefinedField7;
            public StringField ItemNoUserDefinedField8;
            public StringField ItemNoUserDefinedField9;
            public StringField ItemNoUserDefinedField10;
            public StringField ItemNoUserDefinedField11;
            public StringField ItemNoUserDefinedField12;
            public StringField ItemNoUserDefinedField13;
            public StringField ItemNoUserDefinedField14;
            public StringField ItemNoUserDefinedField15;
            public StringField ItemNoUserDefinedField16;
            public StringField ItemNoUserDefinedField17;
            public StringField ItemNoUserDefinedField18;
            public StringField ItemNoUserDefinedField19;
            public StringField ItemNoUserDefinedField20;
            public BooleanField ItemNoRohsCompliance;
            public StringField ItemNoDefMoldBomNo;
            public StringField ItemNoDefFormulaCode;
            public StringField ItemNoBoxType;
            public DecimalField ItemNoBoxLength;
            public DecimalField ItemNoBoxWidth;
            public DecimalField ItemNoBoxHeight;
            public StringField ItemNoBoxDUom;
            public DecimalField ItemNoWd;
            public StringField ItemNoWdUom;
            public DecimalField ItemNoCsLength;
            public DecimalField ItemNoCsWidth;
            public StringField ItemNoUserDefinedField21;
            public DecimalField ItemNoCostWmove;
            public DecimalField ItemNoCostWcase;
            public DecimalField ItemNoCostWband;
            public DecimalField ItemNoCostBatt;
            public StringField ItemNoDescWmove;
            public StringField ItemNoDescWcase;
            public StringField ItemNoDescWband;
            public StringField ItemNoDescBatt;
            public DecimalField ItemNoPoBal;
            public DecimalField ItemNoPoMaxBal;
            public BooleanField ItemNoIncludeJob;
            public DecimalField ItemNoCsThickness;
            public StringField ItemNoCsThicknessUom;
            public DecimalField ItemNoCsProportion;
            public StringField ItemNoCsProportionUom;
            public DecimalField ItemNoDieCutter;
            public DecimalField ItemNoMatInspectLeadTime;
            public DecimalField ItemNoMatPrepareLeadTime;
            public StringField ItemNoMatInspectLeadUnit;
            public StringField ItemNoMatPrepareLeadUnit;
            public StringField ItemNoColorCode;
            public StringField ItemNoCollectionCode;
            public StringField ItemNoStyleCode;
            public DecimalField ItemNoX;
            public DecimalField ItemNoY;
            public StringField ItemNoTempDescription;
            public StringField ItemNoSpecification;
            public StringField ItemNoXUom;
            public StringField ItemNoYUom;
            public DecimalField ItemNoProductionUomConversionRate;
            public DecimalField ItemNoPurchaseUomConversionRate;
            public BooleanField ItemNoAutogenLotIssue;
            public BooleanField ItemNoAutogenSerialIssue;
            public StringField ItemNoWcCostCcy;
            public DecimalField ItemNoWcCost;
            public DecimalField ItemNoWcCostDisc;
            public DecimalField ItemNoWcCostExch;
            public DecimalField ItemNoWcFreight;
            public DecimalField ItemNoWcMargin;
            public DecimalField ItemNoCeilingPrice;
            public DecimalField ItemNoBottomRatio;
            public DecimalField ItemNoBottomPrice;
            public StringField ItemNoDrawingNo;
            public StringField ItemNoMaterialType;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Inventory.InventoryBalance";
            }
        }
    }
}
