#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  InventoryMovementDetailRow.cs
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

    [ConnectionKey("Inventory"), TableName("[dbo].[ICMOVD]")]
    [DisplayName("Inventory Movement Detail"), InstanceName("Inventory Movement Detail"), TwoLevelCached]   
    public sealed class InventoryMovementDetailRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Ref No"), Column("REF_NO"), Size(16), PrimaryKey, ForeignKey("[dbo].[ICMOVH]", "REF_NO"), LeftJoin("jRefNo"), QuickSearch, TextualField("RefNoTranType")]
        public String RefNo
        {
            get { return Fields.RefNo[this]; }
            set { Fields.RefNo[this] = value; }
        }

        [DisplayName("Line No"), Column("LINE_NO"), Size(6), PrimaryKey]
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

        [DisplayName("Line Ref"), Column("LINE_REF"), Size(16)]
        public String LineRef
        {
            get { return Fields.LineRef[this]; }
            set { Fields.LineRef[this] = value; }
        }

        [DisplayName("Qty"), Column("QTY"), Size(16), Scale(4)]
        public Decimal? Qty
        {
            get { return Fields.Qty[this]; }
            set { Fields.Qty[this] = value; }
        }

        [DisplayName("Unit Cost"), Column("UNIT_COST"), Size(18), Scale(6)]
        public Decimal? UnitCost
        {
            get { return Fields.UnitCost[this]; }
            set { Fields.UnitCost[this] = value; }
        }

        [DisplayName("Total Cost"), Column("TOTAL_COST"), Size(14), Scale(2)]
        public Decimal? TotalCost
        {
            get { return Fields.TotalCost[this]; }
            set { Fields.TotalCost[this] = value; }
        }

        [DisplayName("Qty Per Rec"), Column("QTY_PER_REC"), Size(16), Scale(4)]
        public Decimal? QtyPerRec
        {
            get { return Fields.QtyPerRec[this]; }
            set { Fields.QtyPerRec[this] = value; }
        }

        [DisplayName("Qty Per Count"), Column("QTY_PER_COUNT"), Size(16), Scale(4)]
        public Decimal? QtyPerCount
        {
            get { return Fields.QtyPerCount[this]; }
            set { Fields.QtyPerCount[this] = value; }
        }

        [DisplayName("Bin Qty In"), Column("BIN_QTY_IN"), Size(12), Scale(4)]
        public Decimal? BinQtyIn
        {
            get { return Fields.BinQtyIn[this]; }
            set { Fields.BinQtyIn[this] = value; }
        }

        [DisplayName("Bin Qty Out"), Column("BIN_QTY_OUT"), Size(12), Scale(4)]
        public Decimal? BinQtyOut
        {
            get { return Fields.BinQtyOut[this]; }
            set { Fields.BinQtyOut[this] = value; }
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

        [DisplayName("Base Qty"), Column("BASE_QTY"), Size(16), Scale(4)]
        public Decimal? BaseQty
        {
            get { return Fields.BaseQty[this]; }
            set { Fields.BaseQty[this] = value; }
        }

        [DisplayName("Base Unit Cost"), Column("BASE_UNIT_COST"), Size(18), Scale(6)]
        public Decimal? BaseUnitCost
        {
            get { return Fields.BaseUnitCost[this]; }
            set { Fields.BaseUnitCost[this] = value; }
        }

        [DisplayName("Qty Committed"), Column("QTY_COMMITTED"), Size(16), Scale(4)]
        public Decimal? QtyCommitted
        {
            get { return Fields.QtyCommitted[this]; }
            set { Fields.QtyCommitted[this] = value; }
        }

        [DisplayName("Qty Required"), Column("QTY_REQUIRED"), Size(16), Scale(4)]
        public Decimal? QtyRequired
        {
            get { return Fields.QtyRequired[this]; }
            set { Fields.QtyRequired[this] = value; }
        }

        [DisplayName("Qty Issued"), Column("QTY_ISSUED"), Size(16), Scale(4)]
        public Decimal? QtyIssued
        {
            get { return Fields.QtyIssued[this]; }
            set { Fields.QtyIssued[this] = value; }
        }

        [DisplayName("Qty Balance"), Column("QTY_BALANCE"), Size(16), Scale(4)]
        public Decimal? QtyBalance
        {
            get { return Fields.QtyBalance[this]; }
            set { Fields.QtyBalance[this] = value; }
        }

        [DisplayName("Qty Per"), Column("QTY_PER"), Size(16), Scale(8)]
        public Decimal? QtyPer
        {
            get { return Fields.QtyPer[this]; }
            set { Fields.QtyPer[this] = value; }
        }

        [DisplayName("Final"), Column("FINAL"), Size(1)]
        public String Final
        {
            get { return Fields.Final[this]; }
            set { Fields.Final[this] = value; }
        }

        [DisplayName("Debit Acct"), Column("DEBIT_ACCT"), Size(30)]
        public String DebitAcct
        {
            get { return Fields.DebitAcct[this]; }
            set { Fields.DebitAcct[this] = value; }
        }

        [DisplayName("Credit Acct"), Column("CREDIT_ACCT"), Size(30)]
        public String CreditAcct
        {
            get { return Fields.CreditAcct[this]; }
            set { Fields.CreditAcct[this] = value; }
        }

        [DisplayName("Alloc Method"), Column("ALLOC_METHOD"), Size(1)]
        public String AllocMethod
        {
            get { return Fields.AllocMethod[this]; }
            set { Fields.AllocMethod[this] = value; }
        }

        [DisplayName("Source Type"), Column("SOURCE_TYPE"), Size(12), NotNull]
        public String SourceType
        {
            get { return Fields.SourceType[this]; }
            set { Fields.SourceType[this] = value; }
        }

        [DisplayName("Source Ref No"), Column("SOURCE_REF_NO"), Size(16), NotNull]
        public String SourceRefNo
        {
            get { return Fields.SourceRefNo[this]; }
            set { Fields.SourceRefNo[this] = value; }
        }

        [DisplayName("Source Entry No"), Column("SOURCE_ENTRY_NO"), Size(6), NotNull]
        public Decimal? SourceEntryNo
        {
            get { return Fields.SourceEntryNo[this]; }
            set { Fields.SourceEntryNo[this] = value; }
        }

        [DisplayName("Source Part No"), Column("SOURCE_PART_NO"), Size(6), NotNull]
        public Decimal? SourcePartNo
        {
            get { return Fields.SourcePartNo[this]; }
            set { Fields.SourcePartNo[this] = value; }
        }

        [DisplayName("Particulars"), Column("PARTICULARS"), Size(1073741823)]
        public String Particulars
        {
            get { return Fields.Particulars[this]; }
            set { Fields.Particulars[this] = value; }
        }

        [DisplayName("Revised Cost"), Column("REVISED_COST"), Size(14), Scale(2)]
        public Decimal? RevisedCost
        {
            get { return Fields.RevisedCost[this]; }
            set { Fields.RevisedCost[this] = value; }
        }

        [DisplayName("Cost Diff"), Column("COST_DIFF"), Size(14), Scale(2)]
        public Decimal? CostDiff
        {
            get { return Fields.CostDiff[this]; }
            set { Fields.CostDiff[this] = value; }
        }

        [DisplayName("Flow Type"), Column("FLOW_TYPE"), Size(1)]
        public String FlowType
        {
            get { return Fields.FlowType[this]; }
            set { Fields.FlowType[this] = value; }
        }

        [DisplayName("Loc From"), Column("LOC_FROM"), Size(4)]
        public String LocFrom
        {
            get { return Fields.LocFrom[this]; }
            set { Fields.LocFrom[this] = value; }
        }

        [DisplayName("Loc To"), Column("LOC_TO"), Size(4)]
        public String LocTo
        {
            get { return Fields.LocTo[this]; }
            set { Fields.LocTo[this] = value; }
        }

        [DisplayName("Temp Stub No"), Column("TEMP_STUB_NO"), Size(16)]
        public String TempStubNo
        {
            get { return Fields.TempStubNo[this]; }
            set { Fields.TempStubNo[this] = value; }
        }

        [DisplayName("Temp Loc"), Column("TEMP_LOC"), Size(4)]
        public String TempLoc
        {
            get { return Fields.TempLoc[this]; }
            set { Fields.TempLoc[this] = value; }
        }

        [DisplayName("Temp Reserved"), Column("TEMP_RESERVED"), Size(16), Scale(4)]
        public Decimal? TempReserved
        {
            get { return Fields.TempReserved[this]; }
            set { Fields.TempReserved[this] = value; }
        }

        [DisplayName("Temp Date Needed"), Column("TEMP_DATE_NEEDED")]
        public DateTime? TempDateNeeded
        {
            get { return Fields.TempDateNeeded[this]; }
            set { Fields.TempDateNeeded[this] = value; }
        }

        [DisplayName("Temp Remarks"), Column("TEMP_REMARKS"), Size(1073741823)]
        public String TempRemarks
        {
            get { return Fields.TempRemarks[this]; }
            set { Fields.TempRemarks[this] = value; }
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

        [DisplayName("Allocated Qty"), Column("ALLOCATED_QTY"), Size(16), Scale(4)]
        public Decimal? AllocatedQty
        {
            get { return Fields.AllocatedQty[this]; }
            set { Fields.AllocatedQty[this] = value; }
        }

        [DisplayName("Allocated Cost"), Column("ALLOCATED_COST"), Size(14), Scale(2)]
        public Decimal? AllocatedCost
        {
            get { return Fields.AllocatedCost[this]; }
            set { Fields.AllocatedCost[this] = value; }
        }

        [DisplayName("Qty Pick"), Column("QTY_PICK"), Size(16), Scale(4)]
        public Decimal? QtyPick
        {
            get { return Fields.QtyPick[this]; }
            set { Fields.QtyPick[this] = value; }
        }

        [DisplayName("Weight"), Column("WEIGHT"), Size(12), Scale(4)]
        public Decimal? Weight
        {
            get { return Fields.Weight[this]; }
            set { Fields.Weight[this] = value; }
        }

        [DisplayName("Total Weight"), Column("TOTAL_WEIGHT"), Size(18), Scale(4)]
        public Decimal? TotalWeight
        {
            get { return Fields.TotalWeight[this]; }
            set { Fields.TotalWeight[this] = value; }
        }

        [DisplayName("Qty Follow List"), Column("QTY_FOLLOW_LIST"), Size(16), Scale(4)]
        public Decimal? QtyFollowList
        {
            get { return Fields.QtyFollowList[this]; }
            set { Fields.QtyFollowList[this] = value; }
        }

        [DisplayName("Quotation Scrap Qty"), Column("QUOTATION_SCRAP_QTY"), Size(16), Scale(8)]
        public Decimal? QuotationScrapQty
        {
            get { return Fields.QuotationScrapQty[this]; }
            set { Fields.QuotationScrapQty[this] = value; }
        }

        [DisplayName("Quotation Scrap Rate"), Column("QUOTATION_SCRAP_RATE"), Size(6), Scale(2)]
        public Decimal? QuotationScrapRate
        {
            get { return Fields.QuotationScrapRate[this]; }
            set { Fields.QuotationScrapRate[this] = value; }
        }

        [DisplayName("Ref No Recnum"), Expression("jRefNo.[RECNUM]")]
        public Decimal? RefNoRecnum
        {
            get { return Fields.RefNoRecnum[this]; }
            set { Fields.RefNoRecnum[this] = value; }
        }

        [DisplayName("Ref No Tran Type"), Expression("jRefNo.[TRAN_TYPE]")]
        public String RefNoTranType
        {
            get { return Fields.RefNoTranType[this]; }
            set { Fields.RefNoTranType[this] = value; }
        }

        [DisplayName("Ref No Move Date"), Expression("jRefNo.[MOVE_DATE]")]
        public DateTime? RefNoMoveDate
        {
            get { return Fields.RefNoMoveDate[this]; }
            set { Fields.RefNoMoveDate[this] = value; }
        }

        [DisplayName("Ref No Value Date"), Expression("jRefNo.[VALUE_DATE]")]
        public DateTime? RefNoValueDate
        {
            get { return Fields.RefNoValueDate[this]; }
            set { Fields.RefNoValueDate[this] = value; }
        }

        [DisplayName("Ref No Posted"), Expression("jRefNo.[POSTED]")]
        public String RefNoPosted
        {
            get { return Fields.RefNoPosted[this]; }
            set { Fields.RefNoPosted[this] = value; }
        }

        [DisplayName("Ref No Posted Step1"), Expression("jRefNo.[POSTED_STEP1]")]
        public String RefNoPostedStep1
        {
            get { return Fields.RefNoPostedStep1[this]; }
            set { Fields.RefNoPostedStep1[this] = value; }
        }

        [DisplayName("Ref No Flow Type"), Expression("jRefNo.[FLOW_TYPE]")]
        public String RefNoFlowType
        {
            get { return Fields.RefNoFlowType[this]; }
            set { Fields.RefNoFlowType[this] = value; }
        }

        [DisplayName("Ref No Move Type"), Expression("jRefNo.[MOVE_TYPE]")]
        public String RefNoMoveType
        {
            get { return Fields.RefNoMoveType[this]; }
            set { Fields.RefNoMoveType[this] = value; }
        }

        [DisplayName("Ref No Loc From"), Expression("jRefNo.[LOC_FROM]")]
        public String RefNoLocFrom
        {
            get { return Fields.RefNoLocFrom[this]; }
            set { Fields.RefNoLocFrom[this] = value; }
        }

        [DisplayName("Ref No Loc To"), Expression("jRefNo.[LOC_TO]")]
        public String RefNoLocTo
        {
            get { return Fields.RefNoLocTo[this]; }
            set { Fields.RefNoLocTo[this] = value; }
        }

        [DisplayName("Ref No Reference"), Expression("jRefNo.[REFERENCE]")]
        public String RefNoReference
        {
            get { return Fields.RefNoReference[this]; }
            set { Fields.RefNoReference[this] = value; }
        }

        [DisplayName("Ref No Received From"), Expression("jRefNo.[RECEIVED_FROM]")]
        public String RefNoReceivedFrom
        {
            get { return Fields.RefNoReceivedFrom[this]; }
            set { Fields.RefNoReceivedFrom[this] = value; }
        }

        [DisplayName("Ref No Issued To"), Expression("jRefNo.[ISSUED_TO]")]
        public String RefNoIssuedTo
        {
            get { return Fields.RefNoIssuedTo[this]; }
            set { Fields.RefNoIssuedTo[this] = value; }
        }

        [DisplayName("Ref No Dept"), Expression("jRefNo.[DEPT]")]
        public String RefNoDept
        {
            get { return Fields.RefNoDept[this]; }
            set { Fields.RefNoDept[this] = value; }
        }

        [DisplayName("Ref No Total Cost"), Expression("jRefNo.[TOTAL_COST]")]
        public Decimal? RefNoTotalCost
        {
            get { return Fields.RefNoTotalCost[this]; }
            set { Fields.RefNoTotalCost[this] = value; }
        }

        [DisplayName("Ref No Last Line No"), Expression("jRefNo.[LAST_LINE_NO]")]
        public Decimal? RefNoLastLineNo
        {
            get { return Fields.RefNoLastLineNo[this]; }
            set { Fields.RefNoLastLineNo[this] = value; }
        }

        [DisplayName("Ref No Created By"), Expression("jRefNo.[CREATED_BY]")]
        public String RefNoCreatedBy
        {
            get { return Fields.RefNoCreatedBy[this]; }
            set { Fields.RefNoCreatedBy[this] = value; }
        }

        [DisplayName("Ref No Created Date"), Expression("jRefNo.[CREATED_DATE]")]
        public DateTime? RefNoCreatedDate
        {
            get { return Fields.RefNoCreatedDate[this]; }
            set { Fields.RefNoCreatedDate[this] = value; }
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

        [DisplayName("Ref No Source Type"), Expression("jRefNo.[SOURCE_TYPE]")]
        public String RefNoSourceType
        {
            get { return Fields.RefNoSourceType[this]; }
            set { Fields.RefNoSourceType[this] = value; }
        }

        [DisplayName("Ref No Source Ref"), Expression("jRefNo.[SOURCE_REF]")]
        public String RefNoSourceRef
        {
            get { return Fields.RefNoSourceRef[this]; }
            set { Fields.RefNoSourceRef[this] = value; }
        }

        [DisplayName("Ref No Anlys1"), Expression("jRefNo.[ANLYS1]")]
        public String RefNoAnlys1
        {
            get { return Fields.RefNoAnlys1[this]; }
            set { Fields.RefNoAnlys1[this] = value; }
        }

        [DisplayName("Ref No Anlys2"), Expression("jRefNo.[ANLYS2]")]
        public String RefNoAnlys2
        {
            get { return Fields.RefNoAnlys2[this]; }
            set { Fields.RefNoAnlys2[this] = value; }
        }

        [DisplayName("Ref No Period"), Expression("jRefNo.[PERIOD]")]
        public String RefNoPeriod
        {
            get { return Fields.RefNoPeriod[this]; }
            set { Fields.RefNoPeriod[this] = value; }
        }

        [DisplayName("Ref No Fiscal Year"), Expression("jRefNo.[FISCAL_YEAR]")]
        public Decimal? RefNoFiscalYear
        {
            get { return Fields.RefNoFiscalYear[this]; }
            set { Fields.RefNoFiscalYear[this] = value; }
        }

        [DisplayName("Ref No Period No"), Expression("jRefNo.[PERIOD_NO]")]
        public Decimal? RefNoPeriodNo
        {
            get { return Fields.RefNoPeriodNo[this]; }
            set { Fields.RefNoPeriodNo[this] = value; }
        }

        [DisplayName("Ref No Job No"), Expression("jRefNo.[JOB_NO]")]
        public String RefNoJobNo
        {
            get { return Fields.RefNoJobNo[this]; }
            set { Fields.RefNoJobNo[this] = value; }
        }

        [DisplayName("Ref No Batch No"), Expression("jRefNo.[BATCH_NO]")]
        public String RefNoBatchNo
        {
            get { return Fields.RefNoBatchNo[this]; }
            set { Fields.RefNoBatchNo[this] = value; }
        }

        [DisplayName("Ref No Start Date"), Expression("jRefNo.[START_DATE]")]
        public DateTime? RefNoStartDate
        {
            get { return Fields.RefNoStartDate[this]; }
            set { Fields.RefNoStartDate[this] = value; }
        }

        [DisplayName("Ref No Branch No"), Expression("jRefNo.[BRANCH_NO]")]
        public String RefNoBranchNo
        {
            get { return Fields.RefNoBranchNo[this]; }
            set { Fields.RefNoBranchNo[this] = value; }
        }

        [DisplayName("Ref No Final"), Expression("jRefNo.[FINAL]")]
        public String RefNoFinal
        {
            get { return Fields.RefNoFinal[this]; }
            set { Fields.RefNoFinal[this] = value; }
        }

        [DisplayName("Ref No Lots Pending"), Expression("jRefNo.[LOTS_PENDING]")]
        public Decimal? RefNoLotsPending
        {
            get { return Fields.RefNoLotsPending[this]; }
            set { Fields.RefNoLotsPending[this] = value; }
        }

        [DisplayName("Ref No Lots Issued"), Expression("jRefNo.[LOTS_ISSUED]")]
        public Decimal? RefNoLotsIssued
        {
            get { return Fields.RefNoLotsIssued[this]; }
            set { Fields.RefNoLotsIssued[this] = value; }
        }

        [DisplayName("Ref No Qty Issued"), Expression("jRefNo.[QTY_ISSUED]")]
        public Decimal? RefNoQtyIssued
        {
            get { return Fields.RefNoQtyIssued[this]; }
            set { Fields.RefNoQtyIssued[this] = value; }
        }

        [DisplayName("Ref No Std Output"), Expression("jRefNo.[STD_OUTPUT]")]
        public Decimal? RefNoStdOutput
        {
            get { return Fields.RefNoStdOutput[this]; }
            set { Fields.RefNoStdOutput[this] = value; }
        }

        [DisplayName("Ref No Batch Select"), Expression("jRefNo.[BATCH_SELECT]")]
        public String RefNoBatchSelect
        {
            get { return Fields.RefNoBatchSelect[this]; }
            set { Fields.RefNoBatchSelect[this] = value; }
        }

        [DisplayName("Ref No Gl Link"), Expression("jRefNo.[GL_LINK]")]
        public String RefNoGlLink
        {
            get { return Fields.RefNoGlLink[this]; }
            set { Fields.RefNoGlLink[this] = value; }
        }

        [DisplayName("Ref No Gl Link Type"), Expression("jRefNo.[GL_LINK_TYPE]")]
        public String RefNoGlLinkType
        {
            get { return Fields.RefNoGlLinkType[this]; }
            set { Fields.RefNoGlLinkType[this] = value; }
        }

        [DisplayName("Ref No Gl Link No"), Expression("jRefNo.[GL_LINK_NO]")]
        public String RefNoGlLinkNo
        {
            get { return Fields.RefNoGlLinkNo[this]; }
            set { Fields.RefNoGlLinkNo[this] = value; }
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

        [DisplayName("Ref No Particulars"), Expression("jRefNo.[PARTICULARS]")]
        public String RefNoParticulars
        {
            get { return Fields.RefNoParticulars[this]; }
            set { Fields.RefNoParticulars[this] = value; }
        }

        [DisplayName("Ref No Revised Cost"), Expression("jRefNo.[REVISED_COST]")]
        public Decimal? RefNoRevisedCost
        {
            get { return Fields.RefNoRevisedCost[this]; }
            set { Fields.RefNoRevisedCost[this] = value; }
        }

        [DisplayName("Ref No Cost Diff"), Expression("jRefNo.[COST_DIFF]")]
        public Decimal? RefNoCostDiff
        {
            get { return Fields.RefNoCostDiff[this]; }
            set { Fields.RefNoCostDiff[this] = value; }
        }

        [DisplayName("Ref No Diff Acct"), Expression("jRefNo.[DIFF_ACCT]")]
        public String RefNoDiffAcct
        {
            get { return Fields.RefNoDiffAcct[this]; }
            set { Fields.RefNoDiffAcct[this] = value; }
        }

        [DisplayName("Ref No Item No"), Expression("jRefNo.[ITEM_NO]")]
        public String RefNoItemNo
        {
            get { return Fields.RefNoItemNo[this]; }
            set { Fields.RefNoItemNo[this] = value; }
        }

        [DisplayName("Ref No Bom No"), Expression("jRefNo.[BOM_NO]")]
        public String RefNoBomNo
        {
            get { return Fields.RefNoBomNo[this]; }
            set { Fields.RefNoBomNo[this] = value; }
        }

        [DisplayName("Ref No Uom"), Expression("jRefNo.[UOM]")]
        public String RefNoUom
        {
            get { return Fields.RefNoUom[this]; }
            set { Fields.RefNoUom[this] = value; }
        }

        [DisplayName("Ref No Qty"), Expression("jRefNo.[QTY]")]
        public Decimal? RefNoQty
        {
            get { return Fields.RefNoQty[this]; }
            set { Fields.RefNoQty[this] = value; }
        }

        [DisplayName("Ref No Follow List"), Expression("jRefNo.[FOLLOW_LIST]")]
        public String RefNoFollowList
        {
            get { return Fields.RefNoFollowList[this]; }
            set { Fields.RefNoFollowList[this] = value; }
        }

        [DisplayName("Ref No Anlys7"), Expression("jRefNo.[ANLYS7]")]
        public String RefNoAnlys7
        {
            get { return Fields.RefNoAnlys7[this]; }
            set { Fields.RefNoAnlys7[this] = value; }
        }

        [DisplayName("Ref No Anlys8"), Expression("jRefNo.[ANLYS8]")]
        public String RefNoAnlys8
        {
            get { return Fields.RefNoAnlys8[this]; }
            set { Fields.RefNoAnlys8[this] = value; }
        }

        [DisplayName("Ref No Flag"), Expression("jRefNo.[FLAG]")]
        public String RefNoFlag
        {
            get { return Fields.RefNoFlag[this]; }
            set { Fields.RefNoFlag[this] = value; }
        }

        [DisplayName("Ref No Hold By"), Expression("jRefNo.[HOLD_BY]")]
        public String RefNoHoldBy
        {
            get { return Fields.RefNoHoldBy[this]; }
            set { Fields.RefNoHoldBy[this] = value; }
        }

        [DisplayName("Ref No Frozen"), Expression("jRefNo.[FROZEN]")]
        public String RefNoFrozen
        {
            get { return Fields.RefNoFrozen[this]; }
            set { Fields.RefNoFrozen[this] = value; }
        }

        [DisplayName("Ref No Exclude Scrap"), Expression("jRefNo.[EXCLUDE_SCRAP]")]
        public String RefNoExcludeScrap
        {
            get { return Fields.RefNoExcludeScrap[this]; }
            set { Fields.RefNoExcludeScrap[this] = value; }
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

        [DisplayName("Ref No Lots Returned"), Expression("jRefNo.[LOTS_RETURNED]")]
        public Decimal? RefNoLotsReturned
        {
            get { return Fields.RefNoLotsReturned[this]; }
            set { Fields.RefNoLotsReturned[this] = value; }
        }

        [DisplayName("Ref No Step No"), Expression("jRefNo.[STEP_NO]")]
        public Decimal? RefNoStepNo
        {
            get { return Fields.RefNoStepNo[this]; }
            set { Fields.RefNoStepNo[this] = value; }
        }

        [DisplayName("Ref No Cons Issue"), Expression("jRefNo.[CONS_ISSUE]")]
        public Boolean? RefNoConsIssue
        {
            get { return Fields.RefNoConsIssue[this]; }
            set { Fields.RefNoConsIssue[this] = value; }
        }

        [DisplayName("Ref No Cons Issue Ref No"), Expression("jRefNo.[CONS_ISSUE_REF_NO]")]
        public String RefNoConsIssueRefNo
        {
            get { return Fields.RefNoConsIssueRefNo[this]; }
            set { Fields.RefNoConsIssueRefNo[this] = value; }
        }

        [DisplayName("Ref No Cons Issue Line No"), Expression("jRefNo.[CONS_ISSUE_LINE_NO]")]
        public Int32? RefNoConsIssueLineNo
        {
            get { return Fields.RefNoConsIssueLineNo[this]; }
            set { Fields.RefNoConsIssueLineNo[this] = value; }
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

        public InventoryMovementDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField RefNo;
            public DecimalField LineNo;
            public StringField ItemNo;
            public StringField Description;
            public StringField Uom;
            public DecimalField LotSize;
            public StringField LineRef;
            public DecimalField Qty;
            public DecimalField UnitCost;
            public DecimalField TotalCost;
            public DecimalField QtyPerRec;
            public DecimalField QtyPerCount;
            public DecimalField BinQtyIn;
            public DecimalField BinQtyOut;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField Anlys3;
            public StringField Anlys4;
            public StringField Anlys5;
            public StringField Anlys6;
            public DecimalField BaseQty;
            public DecimalField BaseUnitCost;
            public DecimalField QtyCommitted;
            public DecimalField QtyRequired;
            public DecimalField QtyIssued;
            public DecimalField QtyBalance;
            public DecimalField QtyPer;
            public StringField Final;
            public StringField DebitAcct;
            public StringField CreditAcct;
            public StringField AllocMethod;
            public StringField SourceType;
            public StringField SourceRefNo;
            public DecimalField SourceEntryNo;
            public DecimalField SourcePartNo;
            public StringField Particulars;
            public DecimalField RevisedCost;
            public DecimalField CostDiff;
            public StringField FlowType;
            public StringField LocFrom;
            public StringField LocTo;
            public StringField TempStubNo;
            public StringField TempLoc;
            public DecimalField TempReserved;
            public DateTimeField TempDateNeeded;
            public StringField TempRemarks;
            public StringField Anlys15;
            public StringField Anlys16;
            public StringField Anlys17;
            public StringField Anlys18;
            public StringField Anlys19;
            public StringField Anlys20;
            public DecimalField AllocatedQty;
            public DecimalField AllocatedCost;
            public DecimalField QtyPick;
            public DecimalField Weight;
            public DecimalField TotalWeight;
            public DecimalField QtyFollowList;
            public DecimalField QuotationScrapQty;
            public DecimalField QuotationScrapRate;

            public DecimalField RefNoRecnum;
            public StringField RefNoTranType;
            public DateTimeField RefNoMoveDate;
            public DateTimeField RefNoValueDate;
            public StringField RefNoPosted;
            public StringField RefNoPostedStep1;
            public StringField RefNoFlowType;
            public StringField RefNoMoveType;
            public StringField RefNoLocFrom;
            public StringField RefNoLocTo;
            public StringField RefNoReference;
            public StringField RefNoReceivedFrom;
            public StringField RefNoIssuedTo;
            public StringField RefNoDept;
            public DecimalField RefNoTotalCost;
            public DecimalField RefNoLastLineNo;
            public StringField RefNoCreatedBy;
            public DateTimeField RefNoCreatedDate;
            public DateTimeField RefNoRevisedDate;
            public StringField RefNoRevisedBy;
            public DateTimeField RefNoPostedDate;
            public StringField RefNoPostedBy;
            public DecimalField RefNoLogNo;
            public StringField RefNoSourceType;
            public StringField RefNoSourceRef;
            public StringField RefNoAnlys1;
            public StringField RefNoAnlys2;
            public StringField RefNoPeriod;
            public DecimalField RefNoFiscalYear;
            public DecimalField RefNoPeriodNo;
            public StringField RefNoJobNo;
            public StringField RefNoBatchNo;
            public DateTimeField RefNoStartDate;
            public StringField RefNoBranchNo;
            public StringField RefNoFinal;
            public DecimalField RefNoLotsPending;
            public DecimalField RefNoLotsIssued;
            public DecimalField RefNoQtyIssued;
            public DecimalField RefNoStdOutput;
            public StringField RefNoBatchSelect;
            public StringField RefNoGlLink;
            public StringField RefNoGlLinkType;
            public StringField RefNoGlLinkNo;
            public StringField RefNoOwnerBranch;
            public StringField RefNoSourceBranch;
            public StringField RefNoParticulars;
            public DecimalField RefNoRevisedCost;
            public DecimalField RefNoCostDiff;
            public StringField RefNoDiffAcct;
            public StringField RefNoItemNo;
            public StringField RefNoBomNo;
            public StringField RefNoUom;
            public DecimalField RefNoQty;
            public StringField RefNoFollowList;
            public StringField RefNoAnlys7;
            public StringField RefNoAnlys8;
            public StringField RefNoFlag;
            public StringField RefNoHoldBy;
            public StringField RefNoFrozen;
            public StringField RefNoExcludeScrap;
            public StringField RefNoAnlys9;
            public StringField RefNoAnlys10;
            public StringField RefNoAnlys11;
            public StringField RefNoAnlys12;
            public StringField RefNoAnlys13;
            public StringField RefNoAnlys14;
            public DecimalField RefNoLotsReturned;
            public DecimalField RefNoStepNo;
            public BooleanField RefNoConsIssue;
            public StringField RefNoConsIssueRefNo;
            public Int32Field RefNoConsIssueLineNo;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Inventory.InventoryMovementDetail";
            }
        }
    }
}
