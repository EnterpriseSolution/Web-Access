namespace Matrix.Production {
    export interface JobOrderRoutingStepRow {
        Recnum?: number;
        JobNo?: string;
        StepNo?: number;
        OpCode?: string;
        Description?: string;
        ProdnMode?: string;
        Ticketed?: string;
        Reported?: string;
        WorkCentre?: string;
        HrsPerLot?: number;
        PieceRate?: number;
        SubVendorNo?: string;
        SubContractNo?: string;
        SubIssueDate?: string;
        SubDueDate?: string;
        SubLotRate?: number;
        CostMachine?: number;
        CostEnergy?: number;
        CostWater?: number;
        CostRental?: number;
        CostLabor?: number;
        CostInlab?: number;
        CostInmat?: number;
        CostMisc?: number;
        CostSubcon?: number;
        CostMachCpd?: number;
        CostEnergyCpd?: number;
        CostWaterCpd?: number;
        CostRentalCpd?: number;
        CostLaborCpd?: number;
        CostInlabCpd?: number;
        CostInmatCpd?: number;
        CostMiscCpd?: number;
        CostSubCpd?: number;
        AcctMachine?: string;
        AcctEnergy?: string;
        AcctWater?: string;
        AcctRental?: string;
        AcctLabor?: string;
        AcctInlab?: string;
        AcctInmat?: string;
        AcctMisc?: string;
        Specifications?: string;
        Eod?: string;
        Edd?: string;
        Anlys1?: string;
        Anlys2?: string;
        HrsPerLot1?: number;
        TotalManHrs?: number;
        TotalMachHrs?: number;
        Anlys18?: string;
        Anlys19?: string;
        Anlys20?: string;
        JobNoRecnum?: number;
        JobNoPosted?: string;
        JobNoClosed?: string;
        JobNoIssued?: string;
        JobNoFinished?: string;
        JobNoAssemblyType?: string;
        JobNoSourceSubjob?: string;
        JobNoSourceSales?: string;
        JobNoSourceAssort?: string;
        JobNoSourceRefNo?: string;
        JobNoSourceLineNo?: number;
        JobNoSourcePartNo?: number;
        JobNoIssueDate?: string;
        JobNoDueDate?: string;
        JobNoStartDate?: string;
        JobNoItemNo?: string;
        JobNoDescription?: string;
        JobNoUom?: string;
        JobNoTotalQty?: number;
        JobNoSpecNo?: string;
        JobNoBomNo?: string;
        JobNoStdOutput?: number;
        JobNoProdLotSize?: number;
        JobNoNoOfLots?: number;
        JobNoBatchedLots?: number;
        JobNoHrsPerLot?: number;
        JobNoHrsPerLotCpd?: number;
        JobNoBranchNo?: string;
        JobNoAssemblyLine?: string;
        JobNoJobCategory?: string;
        JobNoJobPriority?: number;
        JobNoHeaderVerified?: string;
        JobNoByprodVerified?: string;
        JobNoBatchVerified?: string;
        JobNoBomVerified?: string;
        JobNoRoutingVerifed?: string;
        JobNoMatschVerified?: string;
        JobNoWrkschVerified?: string;
        JobNoCostVerified?: string;
        JobNoByprCostShare?: number;
        JobNoTicketNeeded?: string;
        JobNoTicketClosed?: string;
        JobNoCreatedDate?: string;
        JobNoCreatedBy?: string;
        JobNoRevisedDate?: string;
        JobNoRevisedBy?: string;
        JobNoPostedDate?: string;
        JobNoPostedBy?: string;
        JobNoLastLineNo?: number;
        JobNoLastByprodNo?: number;
        JobNoBatchCount?: number;
        JobNoLastLogNo?: number;
        JobNoLockType?: string;
        JobNoLockRefNo?: string;
        JobNoFgLoc?: string;
        JobNoRmLoc?: string;
        JobNoCostMaterial?: number;
        JobNoCostLabor?: number;
        JobNoCostSubcon?: number;
        JobNoCostMachine?: number;
        JobNoCostEnergy?: number;
        JobNoCostWater?: number;
        JobNoCostRental?: number;
        JobNoCostInlab?: number;
        JobNoCostInmat?: number;
        JobNoCostMisc?: number;
        JobNoCostOverhead?: number;
        JobNoCostEstimate?: number;
        JobNoCostFinished?: number;
        JobNoCostScrapped?: number;
        JobNoCostCharged?: number;
        JobNoCoacRmConsu?: number;
        JobNoCoacRmScrap?: number;
        JobNoCoacMaterial?: number;
        JobNoCoacLabor?: number;
        JobNoCoacSubcon?: number;
        JobNoCoacMachine?: number;
        JobNoCoacEnergy?: number;
        JobNoCoacWater?: number;
        JobNoCoacRental?: number;
        JobNoCoacInlab?: number;
        JobNoCoacInmat?: number;
        JobNoCoacMisc?: number;
        JobNoCoacOverhead?: number;
        JobNoCostActual?: number;
        JobNoCostVariance?: number;
        JobNoCostWip?: number;
        JobNoAcctWip?: string;
        JobNoAcctPvar?: string;
        JobNoAcctProdCost?: string;
        JobNoCanEdit?: string;
        JobNoLastSubNo?: number;
        JobNoSubjobVerified?: string;
        JobNoLotsIssued?: number;
        JobNoLotsFinished?: number;
        JobNoOwnerBranch?: string;
        JobNoSourceBranch?: string;
        JobNoFinishedType?: string;
        JobNoFinishedDate?: string;
        JobNoSpecifications?: string;
        JobNoQtyNeeded?: number;
        JobNoScrapRate?: number;
        JobNoScrapQty?: number;
        JobNoQtyAdjusted?: number;
        JobNoNetWt?: number;
        JobNoNetWtUom?: string;
        JobNoAnlys1?: string;
        JobNoAnlys2?: string;
        JobNoBlowThru?: string;
        JobNoComments1?: string;
        JobNoComments2?: string;
        JobNoComments3?: string;
        JobNoComments4?: string;
        JobNoLastTextNo?: number;
        JobNoBomRevision?: string;
        JobNoAnlys7?: string;
        JobNoAnlys8?: string;
        JobNoLastLinkNo?: number;
        JobNoFlag?: string;
        JobNoHoldBy?: string;
        JobNoIncludeScrapRate?: string;
        JobNoUseItemMasterScrap?: string;
        JobNoWcBackflush?: string;
        JobNoReorder?: string;
        JobNoCostRework?: number;
        JobNoMoldJob?: string;
        JobNoMoldDesc?: string;
        JobNoAnlys9?: string;
        JobNoAnlys10?: string;
        JobNoAnlys11?: string;
        JobNoAnlys12?: string;
        JobNoAnlys13?: string;
        JobNoAnlys14?: string;
        JobNoProjectNo?: string;
        JobNoSourceMrpNo?: string;
    }

    export namespace JobOrderRoutingStepRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'JobNo';
        export const localTextPrefix = 'Production.JobOrderRoutingStep';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const JobNo: string;
            export declare const StepNo: string;
            export declare const OpCode: string;
            export declare const Description: string;
            export declare const ProdnMode: string;
            export declare const Ticketed: string;
            export declare const Reported: string;
            export declare const WorkCentre: string;
            export declare const HrsPerLot: string;
            export declare const PieceRate: string;
            export declare const SubVendorNo: string;
            export declare const SubContractNo: string;
            export declare const SubIssueDate: string;
            export declare const SubDueDate: string;
            export declare const SubLotRate: string;
            export declare const CostMachine: string;
            export declare const CostEnergy: string;
            export declare const CostWater: string;
            export declare const CostRental: string;
            export declare const CostLabor: string;
            export declare const CostInlab: string;
            export declare const CostInmat: string;
            export declare const CostMisc: string;
            export declare const CostSubcon: string;
            export declare const CostMachCpd: string;
            export declare const CostEnergyCpd: string;
            export declare const CostWaterCpd: string;
            export declare const CostRentalCpd: string;
            export declare const CostLaborCpd: string;
            export declare const CostInlabCpd: string;
            export declare const CostInmatCpd: string;
            export declare const CostMiscCpd: string;
            export declare const CostSubCpd: string;
            export declare const AcctMachine: string;
            export declare const AcctEnergy: string;
            export declare const AcctWater: string;
            export declare const AcctRental: string;
            export declare const AcctLabor: string;
            export declare const AcctInlab: string;
            export declare const AcctInmat: string;
            export declare const AcctMisc: string;
            export declare const Specifications: string;
            export declare const Eod: string;
            export declare const Edd: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const HrsPerLot1: string;
            export declare const TotalManHrs: string;
            export declare const TotalMachHrs: string;
            export declare const Anlys18: string;
            export declare const Anlys19: string;
            export declare const Anlys20: string;
            export declare const JobNoRecnum: string;
            export declare const JobNoPosted: string;
            export declare const JobNoClosed: string;
            export declare const JobNoIssued: string;
            export declare const JobNoFinished: string;
            export declare const JobNoAssemblyType: string;
            export declare const JobNoSourceSubjob: string;
            export declare const JobNoSourceSales: string;
            export declare const JobNoSourceAssort: string;
            export declare const JobNoSourceRefNo: string;
            export declare const JobNoSourceLineNo: string;
            export declare const JobNoSourcePartNo: string;
            export declare const JobNoIssueDate: string;
            export declare const JobNoDueDate: string;
            export declare const JobNoStartDate: string;
            export declare const JobNoItemNo: string;
            export declare const JobNoDescription: string;
            export declare const JobNoUom: string;
            export declare const JobNoTotalQty: string;
            export declare const JobNoSpecNo: string;
            export declare const JobNoBomNo: string;
            export declare const JobNoStdOutput: string;
            export declare const JobNoProdLotSize: string;
            export declare const JobNoNoOfLots: string;
            export declare const JobNoBatchedLots: string;
            export declare const JobNoHrsPerLot: string;
            export declare const JobNoHrsPerLotCpd: string;
            export declare const JobNoBranchNo: string;
            export declare const JobNoAssemblyLine: string;
            export declare const JobNoJobCategory: string;
            export declare const JobNoJobPriority: string;
            export declare const JobNoHeaderVerified: string;
            export declare const JobNoByprodVerified: string;
            export declare const JobNoBatchVerified: string;
            export declare const JobNoBomVerified: string;
            export declare const JobNoRoutingVerifed: string;
            export declare const JobNoMatschVerified: string;
            export declare const JobNoWrkschVerified: string;
            export declare const JobNoCostVerified: string;
            export declare const JobNoByprCostShare: string;
            export declare const JobNoTicketNeeded: string;
            export declare const JobNoTicketClosed: string;
            export declare const JobNoCreatedDate: string;
            export declare const JobNoCreatedBy: string;
            export declare const JobNoRevisedDate: string;
            export declare const JobNoRevisedBy: string;
            export declare const JobNoPostedDate: string;
            export declare const JobNoPostedBy: string;
            export declare const JobNoLastLineNo: string;
            export declare const JobNoLastByprodNo: string;
            export declare const JobNoBatchCount: string;
            export declare const JobNoLastLogNo: string;
            export declare const JobNoLockType: string;
            export declare const JobNoLockRefNo: string;
            export declare const JobNoFgLoc: string;
            export declare const JobNoRmLoc: string;
            export declare const JobNoCostMaterial: string;
            export declare const JobNoCostLabor: string;
            export declare const JobNoCostSubcon: string;
            export declare const JobNoCostMachine: string;
            export declare const JobNoCostEnergy: string;
            export declare const JobNoCostWater: string;
            export declare const JobNoCostRental: string;
            export declare const JobNoCostInlab: string;
            export declare const JobNoCostInmat: string;
            export declare const JobNoCostMisc: string;
            export declare const JobNoCostOverhead: string;
            export declare const JobNoCostEstimate: string;
            export declare const JobNoCostFinished: string;
            export declare const JobNoCostScrapped: string;
            export declare const JobNoCostCharged: string;
            export declare const JobNoCoacRmConsu: string;
            export declare const JobNoCoacRmScrap: string;
            export declare const JobNoCoacMaterial: string;
            export declare const JobNoCoacLabor: string;
            export declare const JobNoCoacSubcon: string;
            export declare const JobNoCoacMachine: string;
            export declare const JobNoCoacEnergy: string;
            export declare const JobNoCoacWater: string;
            export declare const JobNoCoacRental: string;
            export declare const JobNoCoacInlab: string;
            export declare const JobNoCoacInmat: string;
            export declare const JobNoCoacMisc: string;
            export declare const JobNoCoacOverhead: string;
            export declare const JobNoCostActual: string;
            export declare const JobNoCostVariance: string;
            export declare const JobNoCostWip: string;
            export declare const JobNoAcctWip: string;
            export declare const JobNoAcctPvar: string;
            export declare const JobNoAcctProdCost: string;
            export declare const JobNoCanEdit: string;
            export declare const JobNoLastSubNo: string;
            export declare const JobNoSubjobVerified: string;
            export declare const JobNoLotsIssued: string;
            export declare const JobNoLotsFinished: string;
            export declare const JobNoOwnerBranch: string;
            export declare const JobNoSourceBranch: string;
            export declare const JobNoFinishedType: string;
            export declare const JobNoFinishedDate: string;
            export declare const JobNoSpecifications: string;
            export declare const JobNoQtyNeeded: string;
            export declare const JobNoScrapRate: string;
            export declare const JobNoScrapQty: string;
            export declare const JobNoQtyAdjusted: string;
            export declare const JobNoNetWt: string;
            export declare const JobNoNetWtUom: string;
            export declare const JobNoAnlys1: string;
            export declare const JobNoAnlys2: string;
            export declare const JobNoBlowThru: string;
            export declare const JobNoComments1: string;
            export declare const JobNoComments2: string;
            export declare const JobNoComments3: string;
            export declare const JobNoComments4: string;
            export declare const JobNoLastTextNo: string;
            export declare const JobNoBomRevision: string;
            export declare const JobNoAnlys7: string;
            export declare const JobNoAnlys8: string;
            export declare const JobNoLastLinkNo: string;
            export declare const JobNoFlag: string;
            export declare const JobNoHoldBy: string;
            export declare const JobNoIncludeScrapRate: string;
            export declare const JobNoUseItemMasterScrap: string;
            export declare const JobNoWcBackflush: string;
            export declare const JobNoReorder: string;
            export declare const JobNoCostRework: string;
            export declare const JobNoMoldJob: string;
            export declare const JobNoMoldDesc: string;
            export declare const JobNoAnlys9: string;
            export declare const JobNoAnlys10: string;
            export declare const JobNoAnlys11: string;
            export declare const JobNoAnlys12: string;
            export declare const JobNoAnlys13: string;
            export declare const JobNoAnlys14: string;
            export declare const JobNoProjectNo: string;
            export declare const JobNoSourceMrpNo: string;
        }

        [
            'Recnum', 
            'JobNo', 
            'StepNo', 
            'OpCode', 
            'Description', 
            'ProdnMode', 
            'Ticketed', 
            'Reported', 
            'WorkCentre', 
            'HrsPerLot', 
            'PieceRate', 
            'SubVendorNo', 
            'SubContractNo', 
            'SubIssueDate', 
            'SubDueDate', 
            'SubLotRate', 
            'CostMachine', 
            'CostEnergy', 
            'CostWater', 
            'CostRental', 
            'CostLabor', 
            'CostInlab', 
            'CostInmat', 
            'CostMisc', 
            'CostSubcon', 
            'CostMachCpd', 
            'CostEnergyCpd', 
            'CostWaterCpd', 
            'CostRentalCpd', 
            'CostLaborCpd', 
            'CostInlabCpd', 
            'CostInmatCpd', 
            'CostMiscCpd', 
            'CostSubCpd', 
            'AcctMachine', 
            'AcctEnergy', 
            'AcctWater', 
            'AcctRental', 
            'AcctLabor', 
            'AcctInlab', 
            'AcctInmat', 
            'AcctMisc', 
            'Specifications', 
            'Eod', 
            'Edd', 
            'Anlys1', 
            'Anlys2', 
            'HrsPerLot1', 
            'TotalManHrs', 
            'TotalMachHrs', 
            'Anlys18', 
            'Anlys19', 
            'Anlys20', 
            'JobNoRecnum', 
            'JobNoPosted', 
            'JobNoClosed', 
            'JobNoIssued', 
            'JobNoFinished', 
            'JobNoAssemblyType', 
            'JobNoSourceSubjob', 
            'JobNoSourceSales', 
            'JobNoSourceAssort', 
            'JobNoSourceRefNo', 
            'JobNoSourceLineNo', 
            'JobNoSourcePartNo', 
            'JobNoIssueDate', 
            'JobNoDueDate', 
            'JobNoStartDate', 
            'JobNoItemNo', 
            'JobNoDescription', 
            'JobNoUom', 
            'JobNoTotalQty', 
            'JobNoSpecNo', 
            'JobNoBomNo', 
            'JobNoStdOutput', 
            'JobNoProdLotSize', 
            'JobNoNoOfLots', 
            'JobNoBatchedLots', 
            'JobNoHrsPerLot', 
            'JobNoHrsPerLotCpd', 
            'JobNoBranchNo', 
            'JobNoAssemblyLine', 
            'JobNoJobCategory', 
            'JobNoJobPriority', 
            'JobNoHeaderVerified', 
            'JobNoByprodVerified', 
            'JobNoBatchVerified', 
            'JobNoBomVerified', 
            'JobNoRoutingVerifed', 
            'JobNoMatschVerified', 
            'JobNoWrkschVerified', 
            'JobNoCostVerified', 
            'JobNoByprCostShare', 
            'JobNoTicketNeeded', 
            'JobNoTicketClosed', 
            'JobNoCreatedDate', 
            'JobNoCreatedBy', 
            'JobNoRevisedDate', 
            'JobNoRevisedBy', 
            'JobNoPostedDate', 
            'JobNoPostedBy', 
            'JobNoLastLineNo', 
            'JobNoLastByprodNo', 
            'JobNoBatchCount', 
            'JobNoLastLogNo', 
            'JobNoLockType', 
            'JobNoLockRefNo', 
            'JobNoFgLoc', 
            'JobNoRmLoc', 
            'JobNoCostMaterial', 
            'JobNoCostLabor', 
            'JobNoCostSubcon', 
            'JobNoCostMachine', 
            'JobNoCostEnergy', 
            'JobNoCostWater', 
            'JobNoCostRental', 
            'JobNoCostInlab', 
            'JobNoCostInmat', 
            'JobNoCostMisc', 
            'JobNoCostOverhead', 
            'JobNoCostEstimate', 
            'JobNoCostFinished', 
            'JobNoCostScrapped', 
            'JobNoCostCharged', 
            'JobNoCoacRmConsu', 
            'JobNoCoacRmScrap', 
            'JobNoCoacMaterial', 
            'JobNoCoacLabor', 
            'JobNoCoacSubcon', 
            'JobNoCoacMachine', 
            'JobNoCoacEnergy', 
            'JobNoCoacWater', 
            'JobNoCoacRental', 
            'JobNoCoacInlab', 
            'JobNoCoacInmat', 
            'JobNoCoacMisc', 
            'JobNoCoacOverhead', 
            'JobNoCostActual', 
            'JobNoCostVariance', 
            'JobNoCostWip', 
            'JobNoAcctWip', 
            'JobNoAcctPvar', 
            'JobNoAcctProdCost', 
            'JobNoCanEdit', 
            'JobNoLastSubNo', 
            'JobNoSubjobVerified', 
            'JobNoLotsIssued', 
            'JobNoLotsFinished', 
            'JobNoOwnerBranch', 
            'JobNoSourceBranch', 
            'JobNoFinishedType', 
            'JobNoFinishedDate', 
            'JobNoSpecifications', 
            'JobNoQtyNeeded', 
            'JobNoScrapRate', 
            'JobNoScrapQty', 
            'JobNoQtyAdjusted', 
            'JobNoNetWt', 
            'JobNoNetWtUom', 
            'JobNoAnlys1', 
            'JobNoAnlys2', 
            'JobNoBlowThru', 
            'JobNoComments1', 
            'JobNoComments2', 
            'JobNoComments3', 
            'JobNoComments4', 
            'JobNoLastTextNo', 
            'JobNoBomRevision', 
            'JobNoAnlys7', 
            'JobNoAnlys8', 
            'JobNoLastLinkNo', 
            'JobNoFlag', 
            'JobNoHoldBy', 
            'JobNoIncludeScrapRate', 
            'JobNoUseItemMasterScrap', 
            'JobNoWcBackflush', 
            'JobNoReorder', 
            'JobNoCostRework', 
            'JobNoMoldJob', 
            'JobNoMoldDesc', 
            'JobNoAnlys9', 
            'JobNoAnlys10', 
            'JobNoAnlys11', 
            'JobNoAnlys12', 
            'JobNoAnlys13', 
            'JobNoAnlys14', 
            'JobNoProjectNo', 
            'JobNoSourceMrpNo'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

