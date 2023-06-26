#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  JobOrderRoutingStepRow.cs
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

    [ConnectionKey("Production"), TableName("[dbo].[PRJOBR]")]
    [DisplayName("Job Order Routing Step"), InstanceName("Job Order Routing Step"), TwoLevelCached]   
    public sealed class JobOrderRoutingStepRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Job No"), Column("JOB_NO"), Size(16), PrimaryKey, ForeignKey("[dbo].[PRJOBH]", "JOB_NO"), LeftJoin("jJobNo"), QuickSearch, TextualField("JobNoPosted")]
        public String JobNo
        {
            get { return Fields.JobNo[this]; }
            set { Fields.JobNo[this] = value; }
        }

        [DisplayName("Step No"), Column("STEP_NO"), Size(2), PrimaryKey]
        public Decimal? StepNo
        {
            get { return Fields.StepNo[this]; }
            set { Fields.StepNo[this] = value; }
        }

        [DisplayName("Op Code"), Column("OP_CODE"), Size(8)]
        public String OpCode
        {
            get { return Fields.OpCode[this]; }
            set { Fields.OpCode[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(40)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Prodn Mode"), Column("PRODN_MODE"), Size(6)]
        public String ProdnMode
        {
            get { return Fields.ProdnMode[this]; }
            set { Fields.ProdnMode[this] = value; }
        }

        [DisplayName("Ticketed"), Column("TICKETED"), Size(1)]
        public String Ticketed
        {
            get { return Fields.Ticketed[this]; }
            set { Fields.Ticketed[this] = value; }
        }

        [DisplayName("Reported"), Column("REPORTED"), Size(1)]
        public String Reported
        {
            get { return Fields.Reported[this]; }
            set { Fields.Reported[this] = value; }
        }

        [DisplayName("Work Centre"), Column("WORK_CENTRE"), Size(10)]
        public String WorkCentre
        {
            get { return Fields.WorkCentre[this]; }
            set { Fields.WorkCentre[this] = value; }
        }

        [DisplayName("Hrs Per Lot"), Column("HRS_PER_LOT"), Size(8), Scale(4)]
        public Decimal? HrsPerLot
        {
            get { return Fields.HrsPerLot[this]; }
            set { Fields.HrsPerLot[this] = value; }
        }

        [DisplayName("Piece Rate"), Column("PIECE_RATE"), Size(12), Scale(4)]
        public Decimal? PieceRate
        {
            get { return Fields.PieceRate[this]; }
            set { Fields.PieceRate[this] = value; }
        }

        [DisplayName("Sub Vendor No"), Column("SUB_VENDOR_NO"), Size(8)]
        public String SubVendorNo
        {
            get { return Fields.SubVendorNo[this]; }
            set { Fields.SubVendorNo[this] = value; }
        }

        [DisplayName("Sub Contract No"), Column("SUB_CONTRACT_NO"), Size(16)]
        public String SubContractNo
        {
            get { return Fields.SubContractNo[this]; }
            set { Fields.SubContractNo[this] = value; }
        }

        [DisplayName("Sub Issue Date"), Column("SUB_ISSUE_DATE")]
        public DateTime? SubIssueDate
        {
            get { return Fields.SubIssueDate[this]; }
            set { Fields.SubIssueDate[this] = value; }
        }

        [DisplayName("Sub Due Date"), Column("SUB_DUE_DATE")]
        public DateTime? SubDueDate
        {
            get { return Fields.SubDueDate[this]; }
            set { Fields.SubDueDate[this] = value; }
        }

        [DisplayName("Sub Lot Rate"), Column("SUB_LOT_RATE"), Size(10), Scale(4)]
        public Decimal? SubLotRate
        {
            get { return Fields.SubLotRate[this]; }
            set { Fields.SubLotRate[this] = value; }
        }

        [DisplayName("Cost Machine"), Column("COST_MACHINE"), Size(14), Scale(2)]
        public Decimal? CostMachine
        {
            get { return Fields.CostMachine[this]; }
            set { Fields.CostMachine[this] = value; }
        }

        [DisplayName("Cost Energy"), Column("COST_ENERGY"), Size(14), Scale(2)]
        public Decimal? CostEnergy
        {
            get { return Fields.CostEnergy[this]; }
            set { Fields.CostEnergy[this] = value; }
        }

        [DisplayName("Cost Water"), Column("COST_WATER"), Size(14), Scale(2)]
        public Decimal? CostWater
        {
            get { return Fields.CostWater[this]; }
            set { Fields.CostWater[this] = value; }
        }

        [DisplayName("Cost Rental"), Column("COST_RENTAL"), Size(14), Scale(2)]
        public Decimal? CostRental
        {
            get { return Fields.CostRental[this]; }
            set { Fields.CostRental[this] = value; }
        }

        [DisplayName("Cost Labor"), Column("COST_LABOR"), Size(14), Scale(2)]
        public Decimal? CostLabor
        {
            get { return Fields.CostLabor[this]; }
            set { Fields.CostLabor[this] = value; }
        }

        [DisplayName("Cost Inlab"), Column("COST_INLAB"), Size(14), Scale(2)]
        public Decimal? CostInlab
        {
            get { return Fields.CostInlab[this]; }
            set { Fields.CostInlab[this] = value; }
        }

        [DisplayName("Cost Inmat"), Column("COST_INMAT"), Size(14), Scale(2)]
        public Decimal? CostInmat
        {
            get { return Fields.CostInmat[this]; }
            set { Fields.CostInmat[this] = value; }
        }

        [DisplayName("Cost Misc"), Column("COST_MISC"), Size(14), Scale(2)]
        public Decimal? CostMisc
        {
            get { return Fields.CostMisc[this]; }
            set { Fields.CostMisc[this] = value; }
        }

        [DisplayName("Cost Subcon"), Column("COST_SUBCON"), Size(14), Scale(2)]
        public Decimal? CostSubcon
        {
            get { return Fields.CostSubcon[this]; }
            set { Fields.CostSubcon[this] = value; }
        }

        [DisplayName("Cost Mach Cpd"), Column("COST_MACH_CPD"), Size(14), Scale(2)]
        public Decimal? CostMachCpd
        {
            get { return Fields.CostMachCpd[this]; }
            set { Fields.CostMachCpd[this] = value; }
        }

        [DisplayName("Cost Energy Cpd"), Column("COST_ENERGY_CPD"), Size(14), Scale(2)]
        public Decimal? CostEnergyCpd
        {
            get { return Fields.CostEnergyCpd[this]; }
            set { Fields.CostEnergyCpd[this] = value; }
        }

        [DisplayName("Cost Water Cpd"), Column("COST_WATER_CPD"), Size(14), Scale(2)]
        public Decimal? CostWaterCpd
        {
            get { return Fields.CostWaterCpd[this]; }
            set { Fields.CostWaterCpd[this] = value; }
        }

        [DisplayName("Cost Rental Cpd"), Column("COST_RENTAL_CPD"), Size(14), Scale(2)]
        public Decimal? CostRentalCpd
        {
            get { return Fields.CostRentalCpd[this]; }
            set { Fields.CostRentalCpd[this] = value; }
        }

        [DisplayName("Cost Labor Cpd"), Column("COST_LABOR_CPD"), Size(14), Scale(2)]
        public Decimal? CostLaborCpd
        {
            get { return Fields.CostLaborCpd[this]; }
            set { Fields.CostLaborCpd[this] = value; }
        }

        [DisplayName("Cost Inlab Cpd"), Column("COST_INLAB_CPD"), Size(14), Scale(2)]
        public Decimal? CostInlabCpd
        {
            get { return Fields.CostInlabCpd[this]; }
            set { Fields.CostInlabCpd[this] = value; }
        }

        [DisplayName("Cost Inmat Cpd"), Column("COST_INMAT_CPD"), Size(14), Scale(2)]
        public Decimal? CostInmatCpd
        {
            get { return Fields.CostInmatCpd[this]; }
            set { Fields.CostInmatCpd[this] = value; }
        }

        [DisplayName("Cost Misc Cpd"), Column("COST_MISC_CPD"), Size(14), Scale(2)]
        public Decimal? CostMiscCpd
        {
            get { return Fields.CostMiscCpd[this]; }
            set { Fields.CostMiscCpd[this] = value; }
        }

        [DisplayName("Cost Sub Cpd"), Column("COST_SUB_CPD"), Size(14), Scale(2)]
        public Decimal? CostSubCpd
        {
            get { return Fields.CostSubCpd[this]; }
            set { Fields.CostSubCpd[this] = value; }
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

        [DisplayName("Specifications"), Column("SPECIFICATIONS"), Size(1073741823)]
        public String Specifications
        {
            get { return Fields.Specifications[this]; }
            set { Fields.Specifications[this] = value; }
        }

        [DisplayName("Eod"), Column("EOD")]
        public DateTime? Eod
        {
            get { return Fields.Eod[this]; }
            set { Fields.Eod[this] = value; }
        }

        [DisplayName("Edd"), Column("EDD")]
        public DateTime? Edd
        {
            get { return Fields.Edd[this]; }
            set { Fields.Edd[this] = value; }
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

        [DisplayName("Hrs Per Lot1"), Column("HRS_PER_LOT1"), Size(8), Scale(4)]
        public Decimal? HrsPerLot1
        {
            get { return Fields.HrsPerLot1[this]; }
            set { Fields.HrsPerLot1[this] = value; }
        }

        [DisplayName("Total Man Hrs"), Column("TOTAL_MAN_HRS"), Size(22), Scale(4)]
        public Decimal? TotalManHrs
        {
            get { return Fields.TotalManHrs[this]; }
            set { Fields.TotalManHrs[this] = value; }
        }

        [DisplayName("Total Mach Hrs"), Column("TOTAL_MACH_HRS"), Size(22), Scale(4)]
        public Decimal? TotalMachHrs
        {
            get { return Fields.TotalMachHrs[this]; }
            set { Fields.TotalMachHrs[this] = value; }
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

        [DisplayName("Job No Recnum"), Expression("jJobNo.[RECNUM]")]
        public Decimal? JobNoRecnum
        {
            get { return Fields.JobNoRecnum[this]; }
            set { Fields.JobNoRecnum[this] = value; }
        }

        [DisplayName("Job No Posted"), Expression("jJobNo.[POSTED]")]
        public String JobNoPosted
        {
            get { return Fields.JobNoPosted[this]; }
            set { Fields.JobNoPosted[this] = value; }
        }

        [DisplayName("Job No Closed"), Expression("jJobNo.[CLOSED]")]
        public String JobNoClosed
        {
            get { return Fields.JobNoClosed[this]; }
            set { Fields.JobNoClosed[this] = value; }
        }

        [DisplayName("Job No Issued"), Expression("jJobNo.[ISSUED]")]
        public String JobNoIssued
        {
            get { return Fields.JobNoIssued[this]; }
            set { Fields.JobNoIssued[this] = value; }
        }

        [DisplayName("Job No Finished"), Expression("jJobNo.[FINISHED]")]
        public String JobNoFinished
        {
            get { return Fields.JobNoFinished[this]; }
            set { Fields.JobNoFinished[this] = value; }
        }

        [DisplayName("Job No Assembly Type"), Expression("jJobNo.[ASSEMBLY_TYPE]")]
        public String JobNoAssemblyType
        {
            get { return Fields.JobNoAssemblyType[this]; }
            set { Fields.JobNoAssemblyType[this] = value; }
        }

        [DisplayName("Job No Source Subjob"), Expression("jJobNo.[SOURCE_SUBJOB]")]
        public String JobNoSourceSubjob
        {
            get { return Fields.JobNoSourceSubjob[this]; }
            set { Fields.JobNoSourceSubjob[this] = value; }
        }

        [DisplayName("Job No Source Sales"), Expression("jJobNo.[SOURCE_SALES]")]
        public String JobNoSourceSales
        {
            get { return Fields.JobNoSourceSales[this]; }
            set { Fields.JobNoSourceSales[this] = value; }
        }

        [DisplayName("Job No Source Assort"), Expression("jJobNo.[SOURCE_ASSORT]")]
        public String JobNoSourceAssort
        {
            get { return Fields.JobNoSourceAssort[this]; }
            set { Fields.JobNoSourceAssort[this] = value; }
        }

        [DisplayName("Job No Source Ref No"), Expression("jJobNo.[SOURCE_REF_NO]")]
        public String JobNoSourceRefNo
        {
            get { return Fields.JobNoSourceRefNo[this]; }
            set { Fields.JobNoSourceRefNo[this] = value; }
        }

        [DisplayName("Job No Source Line No"), Expression("jJobNo.[SOURCE_LINE_NO]")]
        public Decimal? JobNoSourceLineNo
        {
            get { return Fields.JobNoSourceLineNo[this]; }
            set { Fields.JobNoSourceLineNo[this] = value; }
        }

        [DisplayName("Job No Source Part No"), Expression("jJobNo.[SOURCE_PART_NO]")]
        public Decimal? JobNoSourcePartNo
        {
            get { return Fields.JobNoSourcePartNo[this]; }
            set { Fields.JobNoSourcePartNo[this] = value; }
        }

        [DisplayName("Job No Issue Date"), Expression("jJobNo.[ISSUE_DATE]")]
        public DateTime? JobNoIssueDate
        {
            get { return Fields.JobNoIssueDate[this]; }
            set { Fields.JobNoIssueDate[this] = value; }
        }

        [DisplayName("Job No Due Date"), Expression("jJobNo.[DUE_DATE]")]
        public DateTime? JobNoDueDate
        {
            get { return Fields.JobNoDueDate[this]; }
            set { Fields.JobNoDueDate[this] = value; }
        }

        [DisplayName("Job No Start Date"), Expression("jJobNo.[START_DATE]")]
        public DateTime? JobNoStartDate
        {
            get { return Fields.JobNoStartDate[this]; }
            set { Fields.JobNoStartDate[this] = value; }
        }

        [DisplayName("Job No Item No"), Expression("jJobNo.[ITEM_NO]")]
        public String JobNoItemNo
        {
            get { return Fields.JobNoItemNo[this]; }
            set { Fields.JobNoItemNo[this] = value; }
        }

        [DisplayName("Job No Description"), Expression("jJobNo.[DESCRIPTION]")]
        public String JobNoDescription
        {
            get { return Fields.JobNoDescription[this]; }
            set { Fields.JobNoDescription[this] = value; }
        }

        [DisplayName("Job No Uom"), Expression("jJobNo.[UOM]")]
        public String JobNoUom
        {
            get { return Fields.JobNoUom[this]; }
            set { Fields.JobNoUom[this] = value; }
        }

        [DisplayName("Job No Total Qty"), Expression("jJobNo.[TOTAL_QTY]")]
        public Decimal? JobNoTotalQty
        {
            get { return Fields.JobNoTotalQty[this]; }
            set { Fields.JobNoTotalQty[this] = value; }
        }

        [DisplayName("Job No Spec No"), Expression("jJobNo.[SPEC_NO]")]
        public String JobNoSpecNo
        {
            get { return Fields.JobNoSpecNo[this]; }
            set { Fields.JobNoSpecNo[this] = value; }
        }

        [DisplayName("Job No Bom No"), Expression("jJobNo.[BOM_NO]")]
        public String JobNoBomNo
        {
            get { return Fields.JobNoBomNo[this]; }
            set { Fields.JobNoBomNo[this] = value; }
        }

        [DisplayName("Job No Std Output"), Expression("jJobNo.[STD_OUTPUT]")]
        public Decimal? JobNoStdOutput
        {
            get { return Fields.JobNoStdOutput[this]; }
            set { Fields.JobNoStdOutput[this] = value; }
        }

        [DisplayName("Job No Prod Lot Size"), Expression("jJobNo.[PROD_LOT_SIZE]")]
        public Decimal? JobNoProdLotSize
        {
            get { return Fields.JobNoProdLotSize[this]; }
            set { Fields.JobNoProdLotSize[this] = value; }
        }

        [DisplayName("Job No No Of Lots"), Expression("jJobNo.[NO_OF_LOTS]")]
        public Decimal? JobNoNoOfLots
        {
            get { return Fields.JobNoNoOfLots[this]; }
            set { Fields.JobNoNoOfLots[this] = value; }
        }

        [DisplayName("Job No Batched Lots"), Expression("jJobNo.[BATCHED_LOTS]")]
        public Decimal? JobNoBatchedLots
        {
            get { return Fields.JobNoBatchedLots[this]; }
            set { Fields.JobNoBatchedLots[this] = value; }
        }

        [DisplayName("Job No Hrs Per Lot"), Expression("jJobNo.[HRS_PER_LOT]")]
        public Decimal? JobNoHrsPerLot
        {
            get { return Fields.JobNoHrsPerLot[this]; }
            set { Fields.JobNoHrsPerLot[this] = value; }
        }

        [DisplayName("Job No Hrs Per Lot Cpd"), Expression("jJobNo.[HRS_PER_LOT_CPD]")]
        public Decimal? JobNoHrsPerLotCpd
        {
            get { return Fields.JobNoHrsPerLotCpd[this]; }
            set { Fields.JobNoHrsPerLotCpd[this] = value; }
        }

        [DisplayName("Job No Branch No"), Expression("jJobNo.[BRANCH_NO]")]
        public String JobNoBranchNo
        {
            get { return Fields.JobNoBranchNo[this]; }
            set { Fields.JobNoBranchNo[this] = value; }
        }

        [DisplayName("Job No Assembly Line"), Expression("jJobNo.[ASSEMBLY_LINE]")]
        public String JobNoAssemblyLine
        {
            get { return Fields.JobNoAssemblyLine[this]; }
            set { Fields.JobNoAssemblyLine[this] = value; }
        }

        [DisplayName("Job No Job Category"), Expression("jJobNo.[JOB_CATEGORY]")]
        public String JobNoJobCategory
        {
            get { return Fields.JobNoJobCategory[this]; }
            set { Fields.JobNoJobCategory[this] = value; }
        }

        [DisplayName("Job No Job Priority"), Expression("jJobNo.[JOB_PRIORITY]")]
        public Decimal? JobNoJobPriority
        {
            get { return Fields.JobNoJobPriority[this]; }
            set { Fields.JobNoJobPriority[this] = value; }
        }

        [DisplayName("Job No Header Verified"), Expression("jJobNo.[HEADER_VERIFIED]")]
        public String JobNoHeaderVerified
        {
            get { return Fields.JobNoHeaderVerified[this]; }
            set { Fields.JobNoHeaderVerified[this] = value; }
        }

        [DisplayName("Job No Byprod Verified"), Expression("jJobNo.[BYPROD_VERIFIED]")]
        public String JobNoByprodVerified
        {
            get { return Fields.JobNoByprodVerified[this]; }
            set { Fields.JobNoByprodVerified[this] = value; }
        }

        [DisplayName("Job No Batch Verified"), Expression("jJobNo.[BATCH_VERIFIED]")]
        public String JobNoBatchVerified
        {
            get { return Fields.JobNoBatchVerified[this]; }
            set { Fields.JobNoBatchVerified[this] = value; }
        }

        [DisplayName("Job No Bom Verified"), Expression("jJobNo.[BOM_VERIFIED]")]
        public String JobNoBomVerified
        {
            get { return Fields.JobNoBomVerified[this]; }
            set { Fields.JobNoBomVerified[this] = value; }
        }

        [DisplayName("Job No Routing Verifed"), Expression("jJobNo.[ROUTING_VERIFED]")]
        public String JobNoRoutingVerifed
        {
            get { return Fields.JobNoRoutingVerifed[this]; }
            set { Fields.JobNoRoutingVerifed[this] = value; }
        }

        [DisplayName("Job No Matsch Verified"), Expression("jJobNo.[MATSCH_VERIFIED]")]
        public String JobNoMatschVerified
        {
            get { return Fields.JobNoMatschVerified[this]; }
            set { Fields.JobNoMatschVerified[this] = value; }
        }

        [DisplayName("Job No Wrksch Verified"), Expression("jJobNo.[WRKSCH_VERIFIED]")]
        public String JobNoWrkschVerified
        {
            get { return Fields.JobNoWrkschVerified[this]; }
            set { Fields.JobNoWrkschVerified[this] = value; }
        }

        [DisplayName("Job No Cost Verified"), Expression("jJobNo.[COST_VERIFIED]")]
        public String JobNoCostVerified
        {
            get { return Fields.JobNoCostVerified[this]; }
            set { Fields.JobNoCostVerified[this] = value; }
        }

        [DisplayName("Job No Bypr Cost Share"), Expression("jJobNo.[BYPR_COST_SHARE]")]
        public Decimal? JobNoByprCostShare
        {
            get { return Fields.JobNoByprCostShare[this]; }
            set { Fields.JobNoByprCostShare[this] = value; }
        }

        [DisplayName("Job No Ticket Needed"), Expression("jJobNo.[TICKET_NEEDED]")]
        public String JobNoTicketNeeded
        {
            get { return Fields.JobNoTicketNeeded[this]; }
            set { Fields.JobNoTicketNeeded[this] = value; }
        }

        [DisplayName("Job No Ticket Closed"), Expression("jJobNo.[TICKET_CLOSED]")]
        public String JobNoTicketClosed
        {
            get { return Fields.JobNoTicketClosed[this]; }
            set { Fields.JobNoTicketClosed[this] = value; }
        }

        [DisplayName("Job No Created Date"), Expression("jJobNo.[CREATED_DATE]")]
        public DateTime? JobNoCreatedDate
        {
            get { return Fields.JobNoCreatedDate[this]; }
            set { Fields.JobNoCreatedDate[this] = value; }
        }

        [DisplayName("Job No Created By"), Expression("jJobNo.[CREATED_BY]")]
        public String JobNoCreatedBy
        {
            get { return Fields.JobNoCreatedBy[this]; }
            set { Fields.JobNoCreatedBy[this] = value; }
        }

        [DisplayName("Job No Revised Date"), Expression("jJobNo.[REVISED_DATE]")]
        public DateTime? JobNoRevisedDate
        {
            get { return Fields.JobNoRevisedDate[this]; }
            set { Fields.JobNoRevisedDate[this] = value; }
        }

        [DisplayName("Job No Revised By"), Expression("jJobNo.[REVISED_BY]")]
        public String JobNoRevisedBy
        {
            get { return Fields.JobNoRevisedBy[this]; }
            set { Fields.JobNoRevisedBy[this] = value; }
        }

        [DisplayName("Job No Posted Date"), Expression("jJobNo.[POSTED_DATE]")]
        public DateTime? JobNoPostedDate
        {
            get { return Fields.JobNoPostedDate[this]; }
            set { Fields.JobNoPostedDate[this] = value; }
        }

        [DisplayName("Job No Posted By"), Expression("jJobNo.[POSTED_BY]")]
        public String JobNoPostedBy
        {
            get { return Fields.JobNoPostedBy[this]; }
            set { Fields.JobNoPostedBy[this] = value; }
        }

        [DisplayName("Job No Last Line No"), Expression("jJobNo.[LAST_LINE_NO]")]
        public Decimal? JobNoLastLineNo
        {
            get { return Fields.JobNoLastLineNo[this]; }
            set { Fields.JobNoLastLineNo[this] = value; }
        }

        [DisplayName("Job No Last Byprod No"), Expression("jJobNo.[LAST_BYPROD_NO]")]
        public Decimal? JobNoLastByprodNo
        {
            get { return Fields.JobNoLastByprodNo[this]; }
            set { Fields.JobNoLastByprodNo[this] = value; }
        }

        [DisplayName("Job No Batch Count"), Expression("jJobNo.[BATCH_COUNT]")]
        public Decimal? JobNoBatchCount
        {
            get { return Fields.JobNoBatchCount[this]; }
            set { Fields.JobNoBatchCount[this] = value; }
        }

        [DisplayName("Job No Last Log No"), Expression("jJobNo.[LAST_LOG_NO]")]
        public Decimal? JobNoLastLogNo
        {
            get { return Fields.JobNoLastLogNo[this]; }
            set { Fields.JobNoLastLogNo[this] = value; }
        }

        [DisplayName("Job No Lock Type"), Expression("jJobNo.[LOCK_TYPE]")]
        public String JobNoLockType
        {
            get { return Fields.JobNoLockType[this]; }
            set { Fields.JobNoLockType[this] = value; }
        }

        [DisplayName("Job No Lock Ref No"), Expression("jJobNo.[LOCK_REF_NO]")]
        public String JobNoLockRefNo
        {
            get { return Fields.JobNoLockRefNo[this]; }
            set { Fields.JobNoLockRefNo[this] = value; }
        }

        [DisplayName("Job No Fg Loc"), Expression("jJobNo.[FG_LOC]")]
        public String JobNoFgLoc
        {
            get { return Fields.JobNoFgLoc[this]; }
            set { Fields.JobNoFgLoc[this] = value; }
        }

        [DisplayName("Job No Rm Loc"), Expression("jJobNo.[RM_LOC]")]
        public String JobNoRmLoc
        {
            get { return Fields.JobNoRmLoc[this]; }
            set { Fields.JobNoRmLoc[this] = value; }
        }

        [DisplayName("Job No Cost Material"), Expression("jJobNo.[COST_MATERIAL]")]
        public Decimal? JobNoCostMaterial
        {
            get { return Fields.JobNoCostMaterial[this]; }
            set { Fields.JobNoCostMaterial[this] = value; }
        }

        [DisplayName("Job No Cost Labor"), Expression("jJobNo.[COST_LABOR]")]
        public Decimal? JobNoCostLabor
        {
            get { return Fields.JobNoCostLabor[this]; }
            set { Fields.JobNoCostLabor[this] = value; }
        }

        [DisplayName("Job No Cost Subcon"), Expression("jJobNo.[COST_SUBCON]")]
        public Decimal? JobNoCostSubcon
        {
            get { return Fields.JobNoCostSubcon[this]; }
            set { Fields.JobNoCostSubcon[this] = value; }
        }

        [DisplayName("Job No Cost Machine"), Expression("jJobNo.[COST_MACHINE]")]
        public Decimal? JobNoCostMachine
        {
            get { return Fields.JobNoCostMachine[this]; }
            set { Fields.JobNoCostMachine[this] = value; }
        }

        [DisplayName("Job No Cost Energy"), Expression("jJobNo.[COST_ENERGY]")]
        public Decimal? JobNoCostEnergy
        {
            get { return Fields.JobNoCostEnergy[this]; }
            set { Fields.JobNoCostEnergy[this] = value; }
        }

        [DisplayName("Job No Cost Water"), Expression("jJobNo.[COST_WATER]")]
        public Decimal? JobNoCostWater
        {
            get { return Fields.JobNoCostWater[this]; }
            set { Fields.JobNoCostWater[this] = value; }
        }

        [DisplayName("Job No Cost Rental"), Expression("jJobNo.[COST_RENTAL]")]
        public Decimal? JobNoCostRental
        {
            get { return Fields.JobNoCostRental[this]; }
            set { Fields.JobNoCostRental[this] = value; }
        }

        [DisplayName("Job No Cost Inlab"), Expression("jJobNo.[COST_INLAB]")]
        public Decimal? JobNoCostInlab
        {
            get { return Fields.JobNoCostInlab[this]; }
            set { Fields.JobNoCostInlab[this] = value; }
        }

        [DisplayName("Job No Cost Inmat"), Expression("jJobNo.[COST_INMAT]")]
        public Decimal? JobNoCostInmat
        {
            get { return Fields.JobNoCostInmat[this]; }
            set { Fields.JobNoCostInmat[this] = value; }
        }

        [DisplayName("Job No Cost Misc"), Expression("jJobNo.[COST_MISC]")]
        public Decimal? JobNoCostMisc
        {
            get { return Fields.JobNoCostMisc[this]; }
            set { Fields.JobNoCostMisc[this] = value; }
        }

        [DisplayName("Job No Cost Overhead"), Expression("jJobNo.[COST_OVERHEAD]")]
        public Decimal? JobNoCostOverhead
        {
            get { return Fields.JobNoCostOverhead[this]; }
            set { Fields.JobNoCostOverhead[this] = value; }
        }

        [DisplayName("Job No Cost Estimate"), Expression("jJobNo.[COST_ESTIMATE]")]
        public Decimal? JobNoCostEstimate
        {
            get { return Fields.JobNoCostEstimate[this]; }
            set { Fields.JobNoCostEstimate[this] = value; }
        }

        [DisplayName("Job No Cost Finished"), Expression("jJobNo.[COST_FINISHED]")]
        public Decimal? JobNoCostFinished
        {
            get { return Fields.JobNoCostFinished[this]; }
            set { Fields.JobNoCostFinished[this] = value; }
        }

        [DisplayName("Job No Cost Scrapped"), Expression("jJobNo.[COST_SCRAPPED]")]
        public Decimal? JobNoCostScrapped
        {
            get { return Fields.JobNoCostScrapped[this]; }
            set { Fields.JobNoCostScrapped[this] = value; }
        }

        [DisplayName("Job No Cost Charged"), Expression("jJobNo.[COST_CHARGED]")]
        public Decimal? JobNoCostCharged
        {
            get { return Fields.JobNoCostCharged[this]; }
            set { Fields.JobNoCostCharged[this] = value; }
        }

        [DisplayName("Job No Coac Rm Consu"), Expression("jJobNo.[COAC_RM_CONSU]")]
        public Decimal? JobNoCoacRmConsu
        {
            get { return Fields.JobNoCoacRmConsu[this]; }
            set { Fields.JobNoCoacRmConsu[this] = value; }
        }

        [DisplayName("Job No Coac Rm Scrap"), Expression("jJobNo.[COAC_RM_SCRAP]")]
        public Decimal? JobNoCoacRmScrap
        {
            get { return Fields.JobNoCoacRmScrap[this]; }
            set { Fields.JobNoCoacRmScrap[this] = value; }
        }

        [DisplayName("Job No Coac Material"), Expression("jJobNo.[COAC_MATERIAL]")]
        public Decimal? JobNoCoacMaterial
        {
            get { return Fields.JobNoCoacMaterial[this]; }
            set { Fields.JobNoCoacMaterial[this] = value; }
        }

        [DisplayName("Job No Coac Labor"), Expression("jJobNo.[COAC_LABOR]")]
        public Decimal? JobNoCoacLabor
        {
            get { return Fields.JobNoCoacLabor[this]; }
            set { Fields.JobNoCoacLabor[this] = value; }
        }

        [DisplayName("Job No Coac Subcon"), Expression("jJobNo.[COAC_SUBCON]")]
        public Decimal? JobNoCoacSubcon
        {
            get { return Fields.JobNoCoacSubcon[this]; }
            set { Fields.JobNoCoacSubcon[this] = value; }
        }

        [DisplayName("Job No Coac Machine"), Expression("jJobNo.[COAC_MACHINE]")]
        public Decimal? JobNoCoacMachine
        {
            get { return Fields.JobNoCoacMachine[this]; }
            set { Fields.JobNoCoacMachine[this] = value; }
        }

        [DisplayName("Job No Coac Energy"), Expression("jJobNo.[COAC_ENERGY]")]
        public Decimal? JobNoCoacEnergy
        {
            get { return Fields.JobNoCoacEnergy[this]; }
            set { Fields.JobNoCoacEnergy[this] = value; }
        }

        [DisplayName("Job No Coac Water"), Expression("jJobNo.[COAC_WATER]")]
        public Decimal? JobNoCoacWater
        {
            get { return Fields.JobNoCoacWater[this]; }
            set { Fields.JobNoCoacWater[this] = value; }
        }

        [DisplayName("Job No Coac Rental"), Expression("jJobNo.[COAC_RENTAL]")]
        public Decimal? JobNoCoacRental
        {
            get { return Fields.JobNoCoacRental[this]; }
            set { Fields.JobNoCoacRental[this] = value; }
        }

        [DisplayName("Job No Coac Inlab"), Expression("jJobNo.[COAC_INLAB]")]
        public Decimal? JobNoCoacInlab
        {
            get { return Fields.JobNoCoacInlab[this]; }
            set { Fields.JobNoCoacInlab[this] = value; }
        }

        [DisplayName("Job No Coac Inmat"), Expression("jJobNo.[COAC_INMAT]")]
        public Decimal? JobNoCoacInmat
        {
            get { return Fields.JobNoCoacInmat[this]; }
            set { Fields.JobNoCoacInmat[this] = value; }
        }

        [DisplayName("Job No Coac Misc"), Expression("jJobNo.[COAC_MISC]")]
        public Decimal? JobNoCoacMisc
        {
            get { return Fields.JobNoCoacMisc[this]; }
            set { Fields.JobNoCoacMisc[this] = value; }
        }

        [DisplayName("Job No Coac Overhead"), Expression("jJobNo.[COAC_OVERHEAD]")]
        public Decimal? JobNoCoacOverhead
        {
            get { return Fields.JobNoCoacOverhead[this]; }
            set { Fields.JobNoCoacOverhead[this] = value; }
        }

        [DisplayName("Job No Cost Actual"), Expression("jJobNo.[COST_ACTUAL]")]
        public Decimal? JobNoCostActual
        {
            get { return Fields.JobNoCostActual[this]; }
            set { Fields.JobNoCostActual[this] = value; }
        }

        [DisplayName("Job No Cost Variance"), Expression("jJobNo.[COST_VARIANCE]")]
        public Decimal? JobNoCostVariance
        {
            get { return Fields.JobNoCostVariance[this]; }
            set { Fields.JobNoCostVariance[this] = value; }
        }

        [DisplayName("Job No Cost Wip"), Expression("jJobNo.[COST_WIP]")]
        public Decimal? JobNoCostWip
        {
            get { return Fields.JobNoCostWip[this]; }
            set { Fields.JobNoCostWip[this] = value; }
        }

        [DisplayName("Job No Acct Wip"), Expression("jJobNo.[ACCT_WIP]")]
        public String JobNoAcctWip
        {
            get { return Fields.JobNoAcctWip[this]; }
            set { Fields.JobNoAcctWip[this] = value; }
        }

        [DisplayName("Job No Acct Pvar"), Expression("jJobNo.[ACCT_PVAR]")]
        public String JobNoAcctPvar
        {
            get { return Fields.JobNoAcctPvar[this]; }
            set { Fields.JobNoAcctPvar[this] = value; }
        }

        [DisplayName("Job No Acct Prod Cost"), Expression("jJobNo.[ACCT_PROD_COST]")]
        public String JobNoAcctProdCost
        {
            get { return Fields.JobNoAcctProdCost[this]; }
            set { Fields.JobNoAcctProdCost[this] = value; }
        }

        [DisplayName("Job No Can Edit"), Expression("jJobNo.[CAN_EDIT]")]
        public String JobNoCanEdit
        {
            get { return Fields.JobNoCanEdit[this]; }
            set { Fields.JobNoCanEdit[this] = value; }
        }

        [DisplayName("Job No Last Sub No"), Expression("jJobNo.[LAST_SUB_NO]")]
        public Decimal? JobNoLastSubNo
        {
            get { return Fields.JobNoLastSubNo[this]; }
            set { Fields.JobNoLastSubNo[this] = value; }
        }

        [DisplayName("Job No Subjob Verified"), Expression("jJobNo.[SUBJOB_VERIFIED]")]
        public String JobNoSubjobVerified
        {
            get { return Fields.JobNoSubjobVerified[this]; }
            set { Fields.JobNoSubjobVerified[this] = value; }
        }

        [DisplayName("Job No Lots Issued"), Expression("jJobNo.[LOTS_ISSUED]")]
        public Decimal? JobNoLotsIssued
        {
            get { return Fields.JobNoLotsIssued[this]; }
            set { Fields.JobNoLotsIssued[this] = value; }
        }

        [DisplayName("Job No Lots Finished"), Expression("jJobNo.[LOTS_FINISHED]")]
        public Decimal? JobNoLotsFinished
        {
            get { return Fields.JobNoLotsFinished[this]; }
            set { Fields.JobNoLotsFinished[this] = value; }
        }

        [DisplayName("Job No Owner Branch"), Expression("jJobNo.[OWNER_BRANCH]")]
        public String JobNoOwnerBranch
        {
            get { return Fields.JobNoOwnerBranch[this]; }
            set { Fields.JobNoOwnerBranch[this] = value; }
        }

        [DisplayName("Job No Source Branch"), Expression("jJobNo.[SOURCE_BRANCH]")]
        public String JobNoSourceBranch
        {
            get { return Fields.JobNoSourceBranch[this]; }
            set { Fields.JobNoSourceBranch[this] = value; }
        }

        [DisplayName("Job No Finished Type"), Expression("jJobNo.[FINISHED_TYPE]")]
        public String JobNoFinishedType
        {
            get { return Fields.JobNoFinishedType[this]; }
            set { Fields.JobNoFinishedType[this] = value; }
        }

        [DisplayName("Job No Finished Date"), Expression("jJobNo.[FINISHED_DATE]")]
        public DateTime? JobNoFinishedDate
        {
            get { return Fields.JobNoFinishedDate[this]; }
            set { Fields.JobNoFinishedDate[this] = value; }
        }

        [DisplayName("Job No Specifications"), Expression("jJobNo.[SPECIFICATIONS]")]
        public String JobNoSpecifications
        {
            get { return Fields.JobNoSpecifications[this]; }
            set { Fields.JobNoSpecifications[this] = value; }
        }

        [DisplayName("Job No Qty Needed"), Expression("jJobNo.[QTY_NEEDED]")]
        public Decimal? JobNoQtyNeeded
        {
            get { return Fields.JobNoQtyNeeded[this]; }
            set { Fields.JobNoQtyNeeded[this] = value; }
        }

        [DisplayName("Job No Scrap Rate"), Expression("jJobNo.[SCRAP_RATE]")]
        public Decimal? JobNoScrapRate
        {
            get { return Fields.JobNoScrapRate[this]; }
            set { Fields.JobNoScrapRate[this] = value; }
        }

        [DisplayName("Job No Scrap Qty"), Expression("jJobNo.[SCRAP_QTY]")]
        public Decimal? JobNoScrapQty
        {
            get { return Fields.JobNoScrapQty[this]; }
            set { Fields.JobNoScrapQty[this] = value; }
        }

        [DisplayName("Job No Qty Adjusted"), Expression("jJobNo.[QTY_ADJUSTED]")]
        public Decimal? JobNoQtyAdjusted
        {
            get { return Fields.JobNoQtyAdjusted[this]; }
            set { Fields.JobNoQtyAdjusted[this] = value; }
        }

        [DisplayName("Job No Net Wt"), Expression("jJobNo.[NET_WT]")]
        public Decimal? JobNoNetWt
        {
            get { return Fields.JobNoNetWt[this]; }
            set { Fields.JobNoNetWt[this] = value; }
        }

        [DisplayName("Job No Net Wt Uom"), Expression("jJobNo.[NET_WT_UOM]")]
        public String JobNoNetWtUom
        {
            get { return Fields.JobNoNetWtUom[this]; }
            set { Fields.JobNoNetWtUom[this] = value; }
        }

        [DisplayName("Job No Anlys1"), Expression("jJobNo.[ANLYS1]")]
        public String JobNoAnlys1
        {
            get { return Fields.JobNoAnlys1[this]; }
            set { Fields.JobNoAnlys1[this] = value; }
        }

        [DisplayName("Job No Anlys2"), Expression("jJobNo.[ANLYS2]")]
        public String JobNoAnlys2
        {
            get { return Fields.JobNoAnlys2[this]; }
            set { Fields.JobNoAnlys2[this] = value; }
        }

        [DisplayName("Job No Blow Thru"), Expression("jJobNo.[BLOW_THRU]")]
        public String JobNoBlowThru
        {
            get { return Fields.JobNoBlowThru[this]; }
            set { Fields.JobNoBlowThru[this] = value; }
        }

        [DisplayName("Job No Comments1"), Expression("jJobNo.[COMMENTS1]")]
        public String JobNoComments1
        {
            get { return Fields.JobNoComments1[this]; }
            set { Fields.JobNoComments1[this] = value; }
        }

        [DisplayName("Job No Comments2"), Expression("jJobNo.[COMMENTS2]")]
        public String JobNoComments2
        {
            get { return Fields.JobNoComments2[this]; }
            set { Fields.JobNoComments2[this] = value; }
        }

        [DisplayName("Job No Comments3"), Expression("jJobNo.[COMMENTS3]")]
        public String JobNoComments3
        {
            get { return Fields.JobNoComments3[this]; }
            set { Fields.JobNoComments3[this] = value; }
        }

        [DisplayName("Job No Comments4"), Expression("jJobNo.[COMMENTS4]")]
        public String JobNoComments4
        {
            get { return Fields.JobNoComments4[this]; }
            set { Fields.JobNoComments4[this] = value; }
        }

        [DisplayName("Job No Last Text No"), Expression("jJobNo.[LAST_TEXT_NO]")]
        public Decimal? JobNoLastTextNo
        {
            get { return Fields.JobNoLastTextNo[this]; }
            set { Fields.JobNoLastTextNo[this] = value; }
        }

        [DisplayName("Job No Bom Revision"), Expression("jJobNo.[BOM_REVISION]")]
        public String JobNoBomRevision
        {
            get { return Fields.JobNoBomRevision[this]; }
            set { Fields.JobNoBomRevision[this] = value; }
        }

        [DisplayName("Job No Anlys7"), Expression("jJobNo.[ANLYS7]")]
        public String JobNoAnlys7
        {
            get { return Fields.JobNoAnlys7[this]; }
            set { Fields.JobNoAnlys7[this] = value; }
        }

        [DisplayName("Job No Anlys8"), Expression("jJobNo.[ANLYS8]")]
        public String JobNoAnlys8
        {
            get { return Fields.JobNoAnlys8[this]; }
            set { Fields.JobNoAnlys8[this] = value; }
        }

        [DisplayName("Job No Last Link No"), Expression("jJobNo.[LAST_LINK_NO]")]
        public Decimal? JobNoLastLinkNo
        {
            get { return Fields.JobNoLastLinkNo[this]; }
            set { Fields.JobNoLastLinkNo[this] = value; }
        }

        [DisplayName("Job No Flag"), Expression("jJobNo.[FLAG]")]
        public String JobNoFlag
        {
            get { return Fields.JobNoFlag[this]; }
            set { Fields.JobNoFlag[this] = value; }
        }

        [DisplayName("Job No Hold By"), Expression("jJobNo.[HOLD_BY]")]
        public String JobNoHoldBy
        {
            get { return Fields.JobNoHoldBy[this]; }
            set { Fields.JobNoHoldBy[this] = value; }
        }

        [DisplayName("Job No Include Scrap Rate"), Expression("jJobNo.[INCLUDE_SCRAP_RATE]")]
        public String JobNoIncludeScrapRate
        {
            get { return Fields.JobNoIncludeScrapRate[this]; }
            set { Fields.JobNoIncludeScrapRate[this] = value; }
        }

        [DisplayName("Job No Use Item Master Scrap"), Expression("jJobNo.[USE_ITEM_MASTER_SCRAP]")]
        public String JobNoUseItemMasterScrap
        {
            get { return Fields.JobNoUseItemMasterScrap[this]; }
            set { Fields.JobNoUseItemMasterScrap[this] = value; }
        }

        [DisplayName("Job No Wc Backflush"), Expression("jJobNo.[WC_BACKFLUSH]")]
        public String JobNoWcBackflush
        {
            get { return Fields.JobNoWcBackflush[this]; }
            set { Fields.JobNoWcBackflush[this] = value; }
        }

        [DisplayName("Job No Reorder"), Expression("jJobNo.[REORDER]")]
        public String JobNoReorder
        {
            get { return Fields.JobNoReorder[this]; }
            set { Fields.JobNoReorder[this] = value; }
        }

        [DisplayName("Job No Cost Rework"), Expression("jJobNo.[COST_REWORK]")]
        public Decimal? JobNoCostRework
        {
            get { return Fields.JobNoCostRework[this]; }
            set { Fields.JobNoCostRework[this] = value; }
        }

        [DisplayName("Job No Mold Job"), Expression("jJobNo.[MOLD_JOB]")]
        public String JobNoMoldJob
        {
            get { return Fields.JobNoMoldJob[this]; }
            set { Fields.JobNoMoldJob[this] = value; }
        }

        [DisplayName("Job No Mold Desc"), Expression("jJobNo.[MOLD_DESC]")]
        public String JobNoMoldDesc
        {
            get { return Fields.JobNoMoldDesc[this]; }
            set { Fields.JobNoMoldDesc[this] = value; }
        }

        [DisplayName("Job No Anlys9"), Expression("jJobNo.[ANLYS9]")]
        public String JobNoAnlys9
        {
            get { return Fields.JobNoAnlys9[this]; }
            set { Fields.JobNoAnlys9[this] = value; }
        }

        [DisplayName("Job No Anlys10"), Expression("jJobNo.[ANLYS10]")]
        public String JobNoAnlys10
        {
            get { return Fields.JobNoAnlys10[this]; }
            set { Fields.JobNoAnlys10[this] = value; }
        }

        [DisplayName("Job No Anlys11"), Expression("jJobNo.[ANLYS11]")]
        public String JobNoAnlys11
        {
            get { return Fields.JobNoAnlys11[this]; }
            set { Fields.JobNoAnlys11[this] = value; }
        }

        [DisplayName("Job No Anlys12"), Expression("jJobNo.[ANLYS12]")]
        public String JobNoAnlys12
        {
            get { return Fields.JobNoAnlys12[this]; }
            set { Fields.JobNoAnlys12[this] = value; }
        }

        [DisplayName("Job No Anlys13"), Expression("jJobNo.[ANLYS13]")]
        public String JobNoAnlys13
        {
            get { return Fields.JobNoAnlys13[this]; }
            set { Fields.JobNoAnlys13[this] = value; }
        }

        [DisplayName("Job No Anlys14"), Expression("jJobNo.[ANLYS14]")]
        public String JobNoAnlys14
        {
            get { return Fields.JobNoAnlys14[this]; }
            set { Fields.JobNoAnlys14[this] = value; }
        }

        [DisplayName("Job No Project No"), Expression("jJobNo.[PROJECT_NO]")]
        public String JobNoProjectNo
        {
            get { return Fields.JobNoProjectNo[this]; }
            set { Fields.JobNoProjectNo[this] = value; }
        }

        [DisplayName("Job No Source Mrp No"), Expression("jJobNo.[SOURCE_MRP_NO]")]
        public String JobNoSourceMrpNo
        {
            get { return Fields.JobNoSourceMrpNo[this]; }
            set { Fields.JobNoSourceMrpNo[this] = value; }
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

        public JobOrderRoutingStepRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField JobNo;
            public DecimalField StepNo;
            public StringField OpCode;
            public StringField Description;
            public StringField ProdnMode;
            public StringField Ticketed;
            public StringField Reported;
            public StringField WorkCentre;
            public DecimalField HrsPerLot;
            public DecimalField PieceRate;
            public StringField SubVendorNo;
            public StringField SubContractNo;
            public DateTimeField SubIssueDate;
            public DateTimeField SubDueDate;
            public DecimalField SubLotRate;
            public DecimalField CostMachine;
            public DecimalField CostEnergy;
            public DecimalField CostWater;
            public DecimalField CostRental;
            public DecimalField CostLabor;
            public DecimalField CostInlab;
            public DecimalField CostInmat;
            public DecimalField CostMisc;
            public DecimalField CostSubcon;
            public DecimalField CostMachCpd;
            public DecimalField CostEnergyCpd;
            public DecimalField CostWaterCpd;
            public DecimalField CostRentalCpd;
            public DecimalField CostLaborCpd;
            public DecimalField CostInlabCpd;
            public DecimalField CostInmatCpd;
            public DecimalField CostMiscCpd;
            public DecimalField CostSubCpd;
            public StringField AcctMachine;
            public StringField AcctEnergy;
            public StringField AcctWater;
            public StringField AcctRental;
            public StringField AcctLabor;
            public StringField AcctInlab;
            public StringField AcctInmat;
            public StringField AcctMisc;
            public StringField Specifications;
            public DateTimeField Eod;
            public DateTimeField Edd;
            public StringField Anlys1;
            public StringField Anlys2;
            public DecimalField HrsPerLot1;
            public DecimalField TotalManHrs;
            public DecimalField TotalMachHrs;
            public StringField Anlys18;
            public StringField Anlys19;
            public StringField Anlys20;

            public DecimalField JobNoRecnum;
            public StringField JobNoPosted;
            public StringField JobNoClosed;
            public StringField JobNoIssued;
            public StringField JobNoFinished;
            public StringField JobNoAssemblyType;
            public StringField JobNoSourceSubjob;
            public StringField JobNoSourceSales;
            public StringField JobNoSourceAssort;
            public StringField JobNoSourceRefNo;
            public DecimalField JobNoSourceLineNo;
            public DecimalField JobNoSourcePartNo;
            public DateTimeField JobNoIssueDate;
            public DateTimeField JobNoDueDate;
            public DateTimeField JobNoStartDate;
            public StringField JobNoItemNo;
            public StringField JobNoDescription;
            public StringField JobNoUom;
            public DecimalField JobNoTotalQty;
            public StringField JobNoSpecNo;
            public StringField JobNoBomNo;
            public DecimalField JobNoStdOutput;
            public DecimalField JobNoProdLotSize;
            public DecimalField JobNoNoOfLots;
            public DecimalField JobNoBatchedLots;
            public DecimalField JobNoHrsPerLot;
            public DecimalField JobNoHrsPerLotCpd;
            public StringField JobNoBranchNo;
            public StringField JobNoAssemblyLine;
            public StringField JobNoJobCategory;
            public DecimalField JobNoJobPriority;
            public StringField JobNoHeaderVerified;
            public StringField JobNoByprodVerified;
            public StringField JobNoBatchVerified;
            public StringField JobNoBomVerified;
            public StringField JobNoRoutingVerifed;
            public StringField JobNoMatschVerified;
            public StringField JobNoWrkschVerified;
            public StringField JobNoCostVerified;
            public DecimalField JobNoByprCostShare;
            public StringField JobNoTicketNeeded;
            public StringField JobNoTicketClosed;
            public DateTimeField JobNoCreatedDate;
            public StringField JobNoCreatedBy;
            public DateTimeField JobNoRevisedDate;
            public StringField JobNoRevisedBy;
            public DateTimeField JobNoPostedDate;
            public StringField JobNoPostedBy;
            public DecimalField JobNoLastLineNo;
            public DecimalField JobNoLastByprodNo;
            public DecimalField JobNoBatchCount;
            public DecimalField JobNoLastLogNo;
            public StringField JobNoLockType;
            public StringField JobNoLockRefNo;
            public StringField JobNoFgLoc;
            public StringField JobNoRmLoc;
            public DecimalField JobNoCostMaterial;
            public DecimalField JobNoCostLabor;
            public DecimalField JobNoCostSubcon;
            public DecimalField JobNoCostMachine;
            public DecimalField JobNoCostEnergy;
            public DecimalField JobNoCostWater;
            public DecimalField JobNoCostRental;
            public DecimalField JobNoCostInlab;
            public DecimalField JobNoCostInmat;
            public DecimalField JobNoCostMisc;
            public DecimalField JobNoCostOverhead;
            public DecimalField JobNoCostEstimate;
            public DecimalField JobNoCostFinished;
            public DecimalField JobNoCostScrapped;
            public DecimalField JobNoCostCharged;
            public DecimalField JobNoCoacRmConsu;
            public DecimalField JobNoCoacRmScrap;
            public DecimalField JobNoCoacMaterial;
            public DecimalField JobNoCoacLabor;
            public DecimalField JobNoCoacSubcon;
            public DecimalField JobNoCoacMachine;
            public DecimalField JobNoCoacEnergy;
            public DecimalField JobNoCoacWater;
            public DecimalField JobNoCoacRental;
            public DecimalField JobNoCoacInlab;
            public DecimalField JobNoCoacInmat;
            public DecimalField JobNoCoacMisc;
            public DecimalField JobNoCoacOverhead;
            public DecimalField JobNoCostActual;
            public DecimalField JobNoCostVariance;
            public DecimalField JobNoCostWip;
            public StringField JobNoAcctWip;
            public StringField JobNoAcctPvar;
            public StringField JobNoAcctProdCost;
            public StringField JobNoCanEdit;
            public DecimalField JobNoLastSubNo;
            public StringField JobNoSubjobVerified;
            public DecimalField JobNoLotsIssued;
            public DecimalField JobNoLotsFinished;
            public StringField JobNoOwnerBranch;
            public StringField JobNoSourceBranch;
            public StringField JobNoFinishedType;
            public DateTimeField JobNoFinishedDate;
            public StringField JobNoSpecifications;
            public DecimalField JobNoQtyNeeded;
            public DecimalField JobNoScrapRate;
            public DecimalField JobNoScrapQty;
            public DecimalField JobNoQtyAdjusted;
            public DecimalField JobNoNetWt;
            public StringField JobNoNetWtUom;
            public StringField JobNoAnlys1;
            public StringField JobNoAnlys2;
            public StringField JobNoBlowThru;
            public StringField JobNoComments1;
            public StringField JobNoComments2;
            public StringField JobNoComments3;
            public StringField JobNoComments4;
            public DecimalField JobNoLastTextNo;
            public StringField JobNoBomRevision;
            public StringField JobNoAnlys7;
            public StringField JobNoAnlys8;
            public DecimalField JobNoLastLinkNo;
            public StringField JobNoFlag;
            public StringField JobNoHoldBy;
            public StringField JobNoIncludeScrapRate;
            public StringField JobNoUseItemMasterScrap;
            public StringField JobNoWcBackflush;
            public StringField JobNoReorder;
            public DecimalField JobNoCostRework;
            public StringField JobNoMoldJob;
            public StringField JobNoMoldDesc;
            public StringField JobNoAnlys9;
            public StringField JobNoAnlys10;
            public StringField JobNoAnlys11;
            public StringField JobNoAnlys12;
            public StringField JobNoAnlys13;
            public StringField JobNoAnlys14;
            public StringField JobNoProjectNo;
            public StringField JobNoSourceMrpNo;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Production.JobOrderRoutingStep";
            }
        }
    }
}
