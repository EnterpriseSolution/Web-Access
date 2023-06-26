#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  JobOrderRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Production.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Production"), TableName("[dbo].[PRJOBH]")]
    [DisplayName("Job Order"), InstanceName("Job Order"), TwoLevelCached]   
    public sealed class JobOrderRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Job No"), Column("JOB_NO"), Size(16), PrimaryKey, QuickSearch]
        public String JobNo
        {
            get { return Fields.JobNo[this]; }
            set { Fields.JobNo[this] = value; }
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

        [DisplayName("Issued"), Column("ISSUED"), Size(1)]
        public String Issued
        {
            get { return Fields.Issued[this]; }
            set { Fields.Issued[this] = value; }
        }

        [DisplayName("Finished"), Column("FINISHED"), Size(1), NotNull]
        public String Finished
        {
            get { return Fields.Finished[this]; }
            set { Fields.Finished[this] = value; }
        }

        [DisplayName("Assembly Type"), Column("ASSEMBLY_TYPE"), Size(1), NotNull]
        public String AssemblyType
        {
            get { return Fields.AssemblyType[this]; }
            set { Fields.AssemblyType[this] = value; }
        }

        [DisplayName("Source Subjob"), Column("SOURCE_SUBJOB"), Size(1), NotNull]
        public String SourceSubjob
        {
            get { return Fields.SourceSubjob[this]; }
            set { Fields.SourceSubjob[this] = value; }
        }

        [DisplayName("Source Sales"), Column("SOURCE_SALES"), Size(1), NotNull]
        public String SourceSales
        {
            get { return Fields.SourceSales[this]; }
            set { Fields.SourceSales[this] = value; }
        }

        [DisplayName("Source Assort"), Column("SOURCE_ASSORT"), Size(1), NotNull]
        public String SourceAssort
        {
            get { return Fields.SourceAssort[this]; }
            set { Fields.SourceAssort[this] = value; }
        }

        [DisplayName("Source Ref No"), Column("SOURCE_REF_NO"), Size(16), NotNull]
        public String SourceRefNo
        {
            get { return Fields.SourceRefNo[this]; }
            set { Fields.SourceRefNo[this] = value; }
        }

        [DisplayName("Source Line No"), Column("SOURCE_LINE_NO"), Size(6), NotNull]
        public Decimal? SourceLineNo
        {
            get { return Fields.SourceLineNo[this]; }
            set { Fields.SourceLineNo[this] = value; }
        }

        [DisplayName("Source Part No"), Column("SOURCE_PART_NO"), Size(4), NotNull]
        public Decimal? SourcePartNo
        {
            get { return Fields.SourcePartNo[this]; }
            set { Fields.SourcePartNo[this] = value; }
        }

        [DisplayName("Issue Date"), Column("ISSUE_DATE")]
        public DateTime? IssueDate
        {
            get { return Fields.IssueDate[this]; }
            set { Fields.IssueDate[this] = value; }
        }

        [DisplayName("Due Date"), Column("DUE_DATE")]
        public DateTime? DueDate
        {
            get { return Fields.DueDate[this]; }
            set { Fields.DueDate[this] = value; }
        }

        [DisplayName("Start Date"), Column("START_DATE"), NotNull]
        public DateTime? StartDate
        {
            get { return Fields.StartDate[this]; }
            set { Fields.StartDate[this] = value; }
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

        [DisplayName("Total Qty"), Column("TOTAL_QTY"), Size(12), Scale(4)]
        public Decimal? TotalQty
        {
            get { return Fields.TotalQty[this]; }
            set { Fields.TotalQty[this] = value; }
        }

        [DisplayName("Spec No"), Column("SPEC_NO"), Size(16)]
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

        [DisplayName("Std Output"), Column("STD_OUTPUT"), Size(12), Scale(4)]
        public Decimal? StdOutput
        {
            get { return Fields.StdOutput[this]; }
            set { Fields.StdOutput[this] = value; }
        }

        [DisplayName("Prod Lot Size"), Column("PROD_LOT_SIZE"), Size(12), Scale(4)]
        public Decimal? ProdLotSize
        {
            get { return Fields.ProdLotSize[this]; }
            set { Fields.ProdLotSize[this] = value; }
        }

        [DisplayName("No Of Lots"), Column("NO_OF_LOTS"), Size(8)]
        public Decimal? NoOfLots
        {
            get { return Fields.NoOfLots[this]; }
            set { Fields.NoOfLots[this] = value; }
        }

        [DisplayName("Batched Lots"), Column("BATCHED_LOTS"), Size(8)]
        public Decimal? BatchedLots
        {
            get { return Fields.BatchedLots[this]; }
            set { Fields.BatchedLots[this] = value; }
        }

        [DisplayName("Hrs Per Lot"), Column("HRS_PER_LOT"), Size(10), Scale(2)]
        public Decimal? HrsPerLot
        {
            get { return Fields.HrsPerLot[this]; }
            set { Fields.HrsPerLot[this] = value; }
        }

        [DisplayName("Hrs Per Lot Cpd"), Column("HRS_PER_LOT_CPD"), Size(8), Scale(2)]
        public Decimal? HrsPerLotCpd
        {
            get { return Fields.HrsPerLotCpd[this]; }
            set { Fields.HrsPerLotCpd[this] = value; }
        }

        [DisplayName("Branch No"), Column("BRANCH_NO"), Size(4), NotNull]
        public String BranchNo
        {
            get { return Fields.BranchNo[this]; }
            set { Fields.BranchNo[this] = value; }
        }

        [DisplayName("Assembly Line"), Column("ASSEMBLY_LINE"), Size(6)]
        public String AssemblyLine
        {
            get { return Fields.AssemblyLine[this]; }
            set { Fields.AssemblyLine[this] = value; }
        }

        [DisplayName("Job Category"), Column("JOB_CATEGORY"), Size(10)]
        public String JobCategory
        {
            get { return Fields.JobCategory[this]; }
            set { Fields.JobCategory[this] = value; }
        }

        [DisplayName("Job Priority"), Column("JOB_PRIORITY"), Size(4)]
        public Decimal? JobPriority
        {
            get { return Fields.JobPriority[this]; }
            set { Fields.JobPriority[this] = value; }
        }

        [DisplayName("Header Verified"), Column("HEADER_VERIFIED"), Size(1)]
        public String HeaderVerified
        {
            get { return Fields.HeaderVerified[this]; }
            set { Fields.HeaderVerified[this] = value; }
        }

        [DisplayName("Byprod Verified"), Column("BYPROD_VERIFIED"), Size(1)]
        public String ByprodVerified
        {
            get { return Fields.ByprodVerified[this]; }
            set { Fields.ByprodVerified[this] = value; }
        }

        [DisplayName("Batch Verified"), Column("BATCH_VERIFIED"), Size(1)]
        public String BatchVerified
        {
            get { return Fields.BatchVerified[this]; }
            set { Fields.BatchVerified[this] = value; }
        }

        [DisplayName("Bom Verified"), Column("BOM_VERIFIED"), Size(1)]
        public String BomVerified
        {
            get { return Fields.BomVerified[this]; }
            set { Fields.BomVerified[this] = value; }
        }

        [DisplayName("Routing Verifed"), Column("ROUTING_VERIFED"), Size(1)]
        public String RoutingVerifed
        {
            get { return Fields.RoutingVerifed[this]; }
            set { Fields.RoutingVerifed[this] = value; }
        }

        [DisplayName("Matsch Verified"), Column("MATSCH_VERIFIED"), Size(1)]
        public String MatschVerified
        {
            get { return Fields.MatschVerified[this]; }
            set { Fields.MatschVerified[this] = value; }
        }

        [DisplayName("Wrksch Verified"), Column("WRKSCH_VERIFIED"), Size(1)]
        public String WrkschVerified
        {
            get { return Fields.WrkschVerified[this]; }
            set { Fields.WrkschVerified[this] = value; }
        }

        [DisplayName("Cost Verified"), Column("COST_VERIFIED"), Size(1)]
        public String CostVerified
        {
            get { return Fields.CostVerified[this]; }
            set { Fields.CostVerified[this] = value; }
        }

        [DisplayName("Bypr Cost Share"), Column("BYPR_COST_SHARE"), Size(6), Scale(2)]
        public Decimal? ByprCostShare
        {
            get { return Fields.ByprCostShare[this]; }
            set { Fields.ByprCostShare[this] = value; }
        }

        [DisplayName("Ticket Needed"), Column("TICKET_NEEDED"), Size(1), NotNull]
        public String TicketNeeded
        {
            get { return Fields.TicketNeeded[this]; }
            set { Fields.TicketNeeded[this] = value; }
        }

        [DisplayName("Ticket Closed"), Column("TICKET_CLOSED"), Size(1), NotNull]
        public String TicketClosed
        {
            get { return Fields.TicketClosed[this]; }
            set { Fields.TicketClosed[this] = value; }
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

        [DisplayName("Last Line No"), Column("LAST_LINE_NO"), Size(8)]
        public Decimal? LastLineNo
        {
            get { return Fields.LastLineNo[this]; }
            set { Fields.LastLineNo[this] = value; }
        }

        [DisplayName("Last Byprod No"), Column("LAST_BYPROD_NO"), Size(4)]
        public Decimal? LastByprodNo
        {
            get { return Fields.LastByprodNo[this]; }
            set { Fields.LastByprodNo[this] = value; }
        }

        [DisplayName("Batch Count"), Column("BATCH_COUNT"), Size(8)]
        public Decimal? BatchCount
        {
            get { return Fields.BatchCount[this]; }
            set { Fields.BatchCount[this] = value; }
        }

        [DisplayName("Last Log No"), Column("LAST_LOG_NO"), Size(8)]
        public Decimal? LastLogNo
        {
            get { return Fields.LastLogNo[this]; }
            set { Fields.LastLogNo[this] = value; }
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

        [DisplayName("Fg Loc"), Column("FG_LOC"), Size(4)]
        public String FgLoc
        {
            get { return Fields.FgLoc[this]; }
            set { Fields.FgLoc[this] = value; }
        }

        [DisplayName("Rm Loc"), Column("RM_LOC"), Size(4)]
        public String RmLoc
        {
            get { return Fields.RmLoc[this]; }
            set { Fields.RmLoc[this] = value; }
        }

        [DisplayName("Cost Material"), Column("COST_MATERIAL"), Size(16), Scale(2)]
        public Decimal? CostMaterial
        {
            get { return Fields.CostMaterial[this]; }
            set { Fields.CostMaterial[this] = value; }
        }

        [DisplayName("Cost Labor"), Column("COST_LABOR"), Size(16), Scale(2)]
        public Decimal? CostLabor
        {
            get { return Fields.CostLabor[this]; }
            set { Fields.CostLabor[this] = value; }
        }

        [DisplayName("Cost Subcon"), Column("COST_SUBCON"), Size(16), Scale(2)]
        public Decimal? CostSubcon
        {
            get { return Fields.CostSubcon[this]; }
            set { Fields.CostSubcon[this] = value; }
        }

        [DisplayName("Cost Machine"), Column("COST_MACHINE"), Size(16), Scale(2)]
        public Decimal? CostMachine
        {
            get { return Fields.CostMachine[this]; }
            set { Fields.CostMachine[this] = value; }
        }

        [DisplayName("Cost Energy"), Column("COST_ENERGY"), Size(16), Scale(2)]
        public Decimal? CostEnergy
        {
            get { return Fields.CostEnergy[this]; }
            set { Fields.CostEnergy[this] = value; }
        }

        [DisplayName("Cost Water"), Column("COST_WATER"), Size(16), Scale(2)]
        public Decimal? CostWater
        {
            get { return Fields.CostWater[this]; }
            set { Fields.CostWater[this] = value; }
        }

        [DisplayName("Cost Rental"), Column("COST_RENTAL"), Size(16), Scale(2)]
        public Decimal? CostRental
        {
            get { return Fields.CostRental[this]; }
            set { Fields.CostRental[this] = value; }
        }

        [DisplayName("Cost Inlab"), Column("COST_INLAB"), Size(16), Scale(2)]
        public Decimal? CostInlab
        {
            get { return Fields.CostInlab[this]; }
            set { Fields.CostInlab[this] = value; }
        }

        [DisplayName("Cost Inmat"), Column("COST_INMAT"), Size(16), Scale(2)]
        public Decimal? CostInmat
        {
            get { return Fields.CostInmat[this]; }
            set { Fields.CostInmat[this] = value; }
        }

        [DisplayName("Cost Misc"), Column("COST_MISC"), Size(16), Scale(2)]
        public Decimal? CostMisc
        {
            get { return Fields.CostMisc[this]; }
            set { Fields.CostMisc[this] = value; }
        }

        [DisplayName("Cost Overhead"), Column("COST_OVERHEAD"), Size(16), Scale(2)]
        public Decimal? CostOverhead
        {
            get { return Fields.CostOverhead[this]; }
            set { Fields.CostOverhead[this] = value; }
        }

        [DisplayName("Cost Estimate"), Column("COST_ESTIMATE"), Size(16), Scale(2)]
        public Decimal? CostEstimate
        {
            get { return Fields.CostEstimate[this]; }
            set { Fields.CostEstimate[this] = value; }
        }

        [DisplayName("Cost Finished"), Column("COST_FINISHED"), Size(16), Scale(2)]
        public Decimal? CostFinished
        {
            get { return Fields.CostFinished[this]; }
            set { Fields.CostFinished[this] = value; }
        }

        [DisplayName("Cost Scrapped"), Column("COST_SCRAPPED"), Size(16), Scale(2)]
        public Decimal? CostScrapped
        {
            get { return Fields.CostScrapped[this]; }
            set { Fields.CostScrapped[this] = value; }
        }

        [DisplayName("Cost Charged"), Column("COST_CHARGED"), Size(16), Scale(2)]
        public Decimal? CostCharged
        {
            get { return Fields.CostCharged[this]; }
            set { Fields.CostCharged[this] = value; }
        }

        [DisplayName("Coac Rm Consu"), Column("COAC_RM_CONSU"), Size(16), Scale(2)]
        public Decimal? CoacRmConsu
        {
            get { return Fields.CoacRmConsu[this]; }
            set { Fields.CoacRmConsu[this] = value; }
        }

        [DisplayName("Coac Rm Scrap"), Column("COAC_RM_SCRAP"), Size(16), Scale(2)]
        public Decimal? CoacRmScrap
        {
            get { return Fields.CoacRmScrap[this]; }
            set { Fields.CoacRmScrap[this] = value; }
        }

        [DisplayName("Coac Material"), Column("COAC_MATERIAL"), Size(16), Scale(2)]
        public Decimal? CoacMaterial
        {
            get { return Fields.CoacMaterial[this]; }
            set { Fields.CoacMaterial[this] = value; }
        }

        [DisplayName("Coac Labor"), Column("COAC_LABOR"), Size(16), Scale(2)]
        public Decimal? CoacLabor
        {
            get { return Fields.CoacLabor[this]; }
            set { Fields.CoacLabor[this] = value; }
        }

        [DisplayName("Coac Subcon"), Column("COAC_SUBCON"), Size(16), Scale(2)]
        public Decimal? CoacSubcon
        {
            get { return Fields.CoacSubcon[this]; }
            set { Fields.CoacSubcon[this] = value; }
        }

        [DisplayName("Coac Machine"), Column("COAC_MACHINE"), Size(16), Scale(2)]
        public Decimal? CoacMachine
        {
            get { return Fields.CoacMachine[this]; }
            set { Fields.CoacMachine[this] = value; }
        }

        [DisplayName("Coac Energy"), Column("COAC_ENERGY"), Size(16), Scale(2)]
        public Decimal? CoacEnergy
        {
            get { return Fields.CoacEnergy[this]; }
            set { Fields.CoacEnergy[this] = value; }
        }

        [DisplayName("Coac Water"), Column("COAC_WATER"), Size(16), Scale(2)]
        public Decimal? CoacWater
        {
            get { return Fields.CoacWater[this]; }
            set { Fields.CoacWater[this] = value; }
        }

        [DisplayName("Coac Rental"), Column("COAC_RENTAL"), Size(16), Scale(2)]
        public Decimal? CoacRental
        {
            get { return Fields.CoacRental[this]; }
            set { Fields.CoacRental[this] = value; }
        }

        [DisplayName("Coac Inlab"), Column("COAC_INLAB"), Size(16), Scale(2)]
        public Decimal? CoacInlab
        {
            get { return Fields.CoacInlab[this]; }
            set { Fields.CoacInlab[this] = value; }
        }

        [DisplayName("Coac Inmat"), Column("COAC_INMAT"), Size(16), Scale(2)]
        public Decimal? CoacInmat
        {
            get { return Fields.CoacInmat[this]; }
            set { Fields.CoacInmat[this] = value; }
        }

        [DisplayName("Coac Misc"), Column("COAC_MISC"), Size(16), Scale(2)]
        public Decimal? CoacMisc
        {
            get { return Fields.CoacMisc[this]; }
            set { Fields.CoacMisc[this] = value; }
        }

        [DisplayName("Coac Overhead"), Column("COAC_OVERHEAD"), Size(16), Scale(2)]
        public Decimal? CoacOverhead
        {
            get { return Fields.CoacOverhead[this]; }
            set { Fields.CoacOverhead[this] = value; }
        }

        [DisplayName("Cost Actual"), Column("COST_ACTUAL"), Size(16), Scale(2)]
        public Decimal? CostActual
        {
            get { return Fields.CostActual[this]; }
            set { Fields.CostActual[this] = value; }
        }

        [DisplayName("Cost Variance"), Column("COST_VARIANCE"), Size(16), Scale(2)]
        public Decimal? CostVariance
        {
            get { return Fields.CostVariance[this]; }
            set { Fields.CostVariance[this] = value; }
        }

        [DisplayName("Cost Wip"), Column("COST_WIP"), Size(16), Scale(2)]
        public Decimal? CostWip
        {
            get { return Fields.CostWip[this]; }
            set { Fields.CostWip[this] = value; }
        }

        [DisplayName("Acct Wip"), Column("ACCT_WIP"), Size(30)]
        public String AcctWip
        {
            get { return Fields.AcctWip[this]; }
            set { Fields.AcctWip[this] = value; }
        }

        [DisplayName("Acct Pvar"), Column("ACCT_PVAR"), Size(30)]
        public String AcctPvar
        {
            get { return Fields.AcctPvar[this]; }
            set { Fields.AcctPvar[this] = value; }
        }

        [DisplayName("Acct Prod Cost"), Column("ACCT_PROD_COST"), Size(30)]
        public String AcctProdCost
        {
            get { return Fields.AcctProdCost[this]; }
            set { Fields.AcctProdCost[this] = value; }
        }

        [DisplayName("Can Edit"), Column("CAN_EDIT"), Size(1)]
        public String CanEdit
        {
            get { return Fields.CanEdit[this]; }
            set { Fields.CanEdit[this] = value; }
        }

        [DisplayName("Last Sub No"), Column("LAST_SUB_NO"), Size(4)]
        public Decimal? LastSubNo
        {
            get { return Fields.LastSubNo[this]; }
            set { Fields.LastSubNo[this] = value; }
        }

        [DisplayName("Subjob Verified"), Column("SUBJOB_VERIFIED"), Size(1)]
        public String SubjobVerified
        {
            get { return Fields.SubjobVerified[this]; }
            set { Fields.SubjobVerified[this] = value; }
        }

        [DisplayName("Lots Issued"), Column("LOTS_ISSUED"), Size(8)]
        public Decimal? LotsIssued
        {
            get { return Fields.LotsIssued[this]; }
            set { Fields.LotsIssued[this] = value; }
        }

        [DisplayName("Lots Finished"), Column("LOTS_FINISHED"), Size(8)]
        public Decimal? LotsFinished
        {
            get { return Fields.LotsFinished[this]; }
            set { Fields.LotsFinished[this] = value; }
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

        [DisplayName("Finished Type"), Column("FINISHED_TYPE"), Size(12)]
        public String FinishedType
        {
            get { return Fields.FinishedType[this]; }
            set { Fields.FinishedType[this] = value; }
        }

        [DisplayName("Finished Date"), Column("FINISHED_DATE")]
        public DateTime? FinishedDate
        {
            get { return Fields.FinishedDate[this]; }
            set { Fields.FinishedDate[this] = value; }
        }

        [DisplayName("Specifications"), Column("SPECIFICATIONS"), Size(1073741823)]
        public String Specifications
        {
            get { return Fields.Specifications[this]; }
            set { Fields.Specifications[this] = value; }
        }

        [DisplayName("Qty Needed"), Column("QTY_NEEDED"), Size(12), Scale(4)]
        public Decimal? QtyNeeded
        {
            get { return Fields.QtyNeeded[this]; }
            set { Fields.QtyNeeded[this] = value; }
        }

        [DisplayName("Scrap Rate"), Column("SCRAP_RATE"), Size(6), Scale(2)]
        public Decimal? ScrapRate
        {
            get { return Fields.ScrapRate[this]; }
            set { Fields.ScrapRate[this] = value; }
        }

        [DisplayName("Scrap Qty"), Column("SCRAP_QTY"), Size(12), Scale(4)]
        public Decimal? ScrapQty
        {
            get { return Fields.ScrapQty[this]; }
            set { Fields.ScrapQty[this] = value; }
        }

        [DisplayName("Qty Adjusted"), Column("QTY_ADJUSTED"), Size(12), Scale(4)]
        public Decimal? QtyAdjusted
        {
            get { return Fields.QtyAdjusted[this]; }
            set { Fields.QtyAdjusted[this] = value; }
        }

        [DisplayName("Net Wt"), Column("NET_WT"), Size(12), Scale(4)]
        public Decimal? NetWt
        {
            get { return Fields.NetWt[this]; }
            set { Fields.NetWt[this] = value; }
        }

        [DisplayName("Net Wt Uom"), Column("NET_WT_UOM"), Size(4)]
        public String NetWtUom
        {
            get { return Fields.NetWtUom[this]; }
            set { Fields.NetWtUom[this] = value; }
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

        [DisplayName("Blow Thru"), Column("BLOW_THRU"), Size(1)]
        public String BlowThru
        {
            get { return Fields.BlowThru[this]; }
            set { Fields.BlowThru[this] = value; }
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

        [DisplayName("Bom Revision"), Column("BOM_REVISION"), Size(8)]
        public String BomRevision
        {
            get { return Fields.BomRevision[this]; }
            set { Fields.BomRevision[this] = value; }
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

        [DisplayName("Last Link No"), Column("LAST_LINK_NO"), Size(6)]
        public Decimal? LastLinkNo
        {
            get { return Fields.LastLinkNo[this]; }
            set { Fields.LastLinkNo[this] = value; }
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

        [DisplayName("Include Scrap Rate"), Column("INCLUDE_SCRAP_RATE"), Size(1)]
        public String IncludeScrapRate
        {
            get { return Fields.IncludeScrapRate[this]; }
            set { Fields.IncludeScrapRate[this] = value; }
        }

        [DisplayName("Use Item Master Scrap"), Column("USE_ITEM_MASTER_SCRAP"), Size(1)]
        public String UseItemMasterScrap
        {
            get { return Fields.UseItemMasterScrap[this]; }
            set { Fields.UseItemMasterScrap[this] = value; }
        }

        [DisplayName("Wc Backflush"), Column("WC_BACKFLUSH"), Size(1)]
        public String WcBackflush
        {
            get { return Fields.WcBackflush[this]; }
            set { Fields.WcBackflush[this] = value; }
        }

        [DisplayName("Reorder"), Column("REORDER"), Size(1)]
        public String Reorder
        {
            get { return Fields.Reorder[this]; }
            set { Fields.Reorder[this] = value; }
        }

        [DisplayName("Cost Rework"), Column("COST_REWORK"), Size(16), Scale(2)]
        public Decimal? CostRework
        {
            get { return Fields.CostRework[this]; }
            set { Fields.CostRework[this] = value; }
        }

        [DisplayName("Mold Job"), Column("MOLD_JOB"), Size(1)]
        public String MoldJob
        {
            get { return Fields.MoldJob[this]; }
            set { Fields.MoldJob[this] = value; }
        }

        [DisplayName("Mold Desc"), Column("MOLD_DESC"), Size(60)]
        public String MoldDesc
        {
            get { return Fields.MoldDesc[this]; }
            set { Fields.MoldDesc[this] = value; }
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

        [DisplayName("Project No"), Column("PROJECT_NO"), Size(16)]
        public String ProjectNo
        {
            get { return Fields.ProjectNo[this]; }
            set { Fields.ProjectNo[this] = value; }
        }

        [DisplayName("Source Mrp No"), Column("SOURCE_MRP_NO"), Size(16)]
        public String SourceMrpNo
        {
            get { return Fields.SourceMrpNo[this]; }
            set { Fields.SourceMrpNo[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.JobNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public JobOrderRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField JobNo;
            public StringField Posted;
            public StringField Closed;
            public StringField Issued;
            public StringField Finished;
            public StringField AssemblyType;
            public StringField SourceSubjob;
            public StringField SourceSales;
            public StringField SourceAssort;
            public StringField SourceRefNo;
            public DecimalField SourceLineNo;
            public DecimalField SourcePartNo;
            public DateTimeField IssueDate;
            public DateTimeField DueDate;
            public DateTimeField StartDate;
            public StringField ItemNo;
            public StringField Description;
            public StringField Uom;
            public DecimalField TotalQty;
            public StringField SpecNo;
            public StringField BomNo;
            public DecimalField StdOutput;
            public DecimalField ProdLotSize;
            public DecimalField NoOfLots;
            public DecimalField BatchedLots;
            public DecimalField HrsPerLot;
            public DecimalField HrsPerLotCpd;
            public StringField BranchNo;
            public StringField AssemblyLine;
            public StringField JobCategory;
            public DecimalField JobPriority;
            public StringField HeaderVerified;
            public StringField ByprodVerified;
            public StringField BatchVerified;
            public StringField BomVerified;
            public StringField RoutingVerifed;
            public StringField MatschVerified;
            public StringField WrkschVerified;
            public StringField CostVerified;
            public DecimalField ByprCostShare;
            public StringField TicketNeeded;
            public StringField TicketClosed;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DateTimeField PostedDate;
            public StringField PostedBy;
            public DecimalField LastLineNo;
            public DecimalField LastByprodNo;
            public DecimalField BatchCount;
            public DecimalField LastLogNo;
            public StringField LockType;
            public StringField LockRefNo;
            public StringField FgLoc;
            public StringField RmLoc;
            public DecimalField CostMaterial;
            public DecimalField CostLabor;
            public DecimalField CostSubcon;
            public DecimalField CostMachine;
            public DecimalField CostEnergy;
            public DecimalField CostWater;
            public DecimalField CostRental;
            public DecimalField CostInlab;
            public DecimalField CostInmat;
            public DecimalField CostMisc;
            public DecimalField CostOverhead;
            public DecimalField CostEstimate;
            public DecimalField CostFinished;
            public DecimalField CostScrapped;
            public DecimalField CostCharged;
            public DecimalField CoacRmConsu;
            public DecimalField CoacRmScrap;
            public DecimalField CoacMaterial;
            public DecimalField CoacLabor;
            public DecimalField CoacSubcon;
            public DecimalField CoacMachine;
            public DecimalField CoacEnergy;
            public DecimalField CoacWater;
            public DecimalField CoacRental;
            public DecimalField CoacInlab;
            public DecimalField CoacInmat;
            public DecimalField CoacMisc;
            public DecimalField CoacOverhead;
            public DecimalField CostActual;
            public DecimalField CostVariance;
            public DecimalField CostWip;
            public StringField AcctWip;
            public StringField AcctPvar;
            public StringField AcctProdCost;
            public StringField CanEdit;
            public DecimalField LastSubNo;
            public StringField SubjobVerified;
            public DecimalField LotsIssued;
            public DecimalField LotsFinished;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField FinishedType;
            public DateTimeField FinishedDate;
            public StringField Specifications;
            public DecimalField QtyNeeded;
            public DecimalField ScrapRate;
            public DecimalField ScrapQty;
            public DecimalField QtyAdjusted;
            public DecimalField NetWt;
            public StringField NetWtUom;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField BlowThru;
            public StringField Comments1;
            public StringField Comments2;
            public StringField Comments3;
            public StringField Comments4;
            public DecimalField LastTextNo;
            public StringField BomRevision;
            public StringField Anlys7;
            public StringField Anlys8;
            public DecimalField LastLinkNo;
            public StringField Flag;
            public StringField HoldBy;
            public StringField IncludeScrapRate;
            public StringField UseItemMasterScrap;
            public StringField WcBackflush;
            public StringField Reorder;
            public DecimalField CostRework;
            public StringField MoldJob;
            public StringField MoldDesc;
            public StringField Anlys9;
            public StringField Anlys10;
            public StringField Anlys11;
            public StringField Anlys12;
            public StringField Anlys13;
            public StringField Anlys14;
            public StringField ProjectNo;
            public StringField SourceMrpNo;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Production.JobOrder";
            }
        }
    }
}
