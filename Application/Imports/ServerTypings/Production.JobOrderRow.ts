namespace Matrix.Production {
    export interface JobOrderRow {
        Recnum?: number;
        JobNo?: string;
        Posted?: string;
        Closed?: string;
        Issued?: string;
        Finished?: string;
        AssemblyType?: string;
        SourceSubjob?: string;
        SourceSales?: string;
        SourceAssort?: string;
        SourceRefNo?: string;
        SourceLineNo?: number;
        SourcePartNo?: number;
        IssueDate?: string;
        DueDate?: string;
        StartDate?: string;
        ItemNo?: string;
        Description?: string;
        Uom?: string;
        TotalQty?: number;
        SpecNo?: string;
        BomNo?: string;
        StdOutput?: number;
        ProdLotSize?: number;
        NoOfLots?: number;
        BatchedLots?: number;
        HrsPerLot?: number;
        HrsPerLotCpd?: number;
        BranchNo?: string;
        AssemblyLine?: string;
        JobCategory?: string;
        JobPriority?: number;
        HeaderVerified?: string;
        ByprodVerified?: string;
        BatchVerified?: string;
        BomVerified?: string;
        RoutingVerifed?: string;
        MatschVerified?: string;
        WrkschVerified?: string;
        CostVerified?: string;
        ByprCostShare?: number;
        TicketNeeded?: string;
        TicketClosed?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        PostedDate?: string;
        PostedBy?: string;
        LastLineNo?: number;
        LastByprodNo?: number;
        BatchCount?: number;
        LastLogNo?: number;
        LockType?: string;
        LockRefNo?: string;
        FgLoc?: string;
        RmLoc?: string;
        CostMaterial?: number;
        CostLabor?: number;
        CostSubcon?: number;
        CostMachine?: number;
        CostEnergy?: number;
        CostWater?: number;
        CostRental?: number;
        CostInlab?: number;
        CostInmat?: number;
        CostMisc?: number;
        CostOverhead?: number;
        CostEstimate?: number;
        CostFinished?: number;
        CostScrapped?: number;
        CostCharged?: number;
        CoacRmConsu?: number;
        CoacRmScrap?: number;
        CoacMaterial?: number;
        CoacLabor?: number;
        CoacSubcon?: number;
        CoacMachine?: number;
        CoacEnergy?: number;
        CoacWater?: number;
        CoacRental?: number;
        CoacInlab?: number;
        CoacInmat?: number;
        CoacMisc?: number;
        CoacOverhead?: number;
        CostActual?: number;
        CostVariance?: number;
        CostWip?: number;
        AcctWip?: string;
        AcctPvar?: string;
        AcctProdCost?: string;
        CanEdit?: string;
        LastSubNo?: number;
        SubjobVerified?: string;
        LotsIssued?: number;
        LotsFinished?: number;
        OwnerBranch?: string;
        SourceBranch?: string;
        FinishedType?: string;
        FinishedDate?: string;
        Specifications?: string;
        QtyNeeded?: number;
        ScrapRate?: number;
        ScrapQty?: number;
        QtyAdjusted?: number;
        NetWt?: number;
        NetWtUom?: string;
        Anlys1?: string;
        Anlys2?: string;
        BlowThru?: string;
        Comments1?: string;
        Comments2?: string;
        Comments3?: string;
        Comments4?: string;
        LastTextNo?: number;
        BomRevision?: string;
        Anlys7?: string;
        Anlys8?: string;
        LastLinkNo?: number;
        Flag?: string;
        HoldBy?: string;
        IncludeScrapRate?: string;
        UseItemMasterScrap?: string;
        WcBackflush?: string;
        Reorder?: string;
        CostRework?: number;
        MoldJob?: string;
        MoldDesc?: string;
        Anlys9?: string;
        Anlys10?: string;
        Anlys11?: string;
        Anlys12?: string;
        Anlys13?: string;
        Anlys14?: string;
        ProjectNo?: string;
        SourceMrpNo?: string;
    }

    export namespace JobOrderRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'JobNo';
        export const localTextPrefix = 'Production.JobOrder';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const JobNo: string;
            export declare const Posted: string;
            export declare const Closed: string;
            export declare const Issued: string;
            export declare const Finished: string;
            export declare const AssemblyType: string;
            export declare const SourceSubjob: string;
            export declare const SourceSales: string;
            export declare const SourceAssort: string;
            export declare const SourceRefNo: string;
            export declare const SourceLineNo: string;
            export declare const SourcePartNo: string;
            export declare const IssueDate: string;
            export declare const DueDate: string;
            export declare const StartDate: string;
            export declare const ItemNo: string;
            export declare const Description: string;
            export declare const Uom: string;
            export declare const TotalQty: string;
            export declare const SpecNo: string;
            export declare const BomNo: string;
            export declare const StdOutput: string;
            export declare const ProdLotSize: string;
            export declare const NoOfLots: string;
            export declare const BatchedLots: string;
            export declare const HrsPerLot: string;
            export declare const HrsPerLotCpd: string;
            export declare const BranchNo: string;
            export declare const AssemblyLine: string;
            export declare const JobCategory: string;
            export declare const JobPriority: string;
            export declare const HeaderVerified: string;
            export declare const ByprodVerified: string;
            export declare const BatchVerified: string;
            export declare const BomVerified: string;
            export declare const RoutingVerifed: string;
            export declare const MatschVerified: string;
            export declare const WrkschVerified: string;
            export declare const CostVerified: string;
            export declare const ByprCostShare: string;
            export declare const TicketNeeded: string;
            export declare const TicketClosed: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const PostedDate: string;
            export declare const PostedBy: string;
            export declare const LastLineNo: string;
            export declare const LastByprodNo: string;
            export declare const BatchCount: string;
            export declare const LastLogNo: string;
            export declare const LockType: string;
            export declare const LockRefNo: string;
            export declare const FgLoc: string;
            export declare const RmLoc: string;
            export declare const CostMaterial: string;
            export declare const CostLabor: string;
            export declare const CostSubcon: string;
            export declare const CostMachine: string;
            export declare const CostEnergy: string;
            export declare const CostWater: string;
            export declare const CostRental: string;
            export declare const CostInlab: string;
            export declare const CostInmat: string;
            export declare const CostMisc: string;
            export declare const CostOverhead: string;
            export declare const CostEstimate: string;
            export declare const CostFinished: string;
            export declare const CostScrapped: string;
            export declare const CostCharged: string;
            export declare const CoacRmConsu: string;
            export declare const CoacRmScrap: string;
            export declare const CoacMaterial: string;
            export declare const CoacLabor: string;
            export declare const CoacSubcon: string;
            export declare const CoacMachine: string;
            export declare const CoacEnergy: string;
            export declare const CoacWater: string;
            export declare const CoacRental: string;
            export declare const CoacInlab: string;
            export declare const CoacInmat: string;
            export declare const CoacMisc: string;
            export declare const CoacOverhead: string;
            export declare const CostActual: string;
            export declare const CostVariance: string;
            export declare const CostWip: string;
            export declare const AcctWip: string;
            export declare const AcctPvar: string;
            export declare const AcctProdCost: string;
            export declare const CanEdit: string;
            export declare const LastSubNo: string;
            export declare const SubjobVerified: string;
            export declare const LotsIssued: string;
            export declare const LotsFinished: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const FinishedType: string;
            export declare const FinishedDate: string;
            export declare const Specifications: string;
            export declare const QtyNeeded: string;
            export declare const ScrapRate: string;
            export declare const ScrapQty: string;
            export declare const QtyAdjusted: string;
            export declare const NetWt: string;
            export declare const NetWtUom: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const BlowThru: string;
            export declare const Comments1: string;
            export declare const Comments2: string;
            export declare const Comments3: string;
            export declare const Comments4: string;
            export declare const LastTextNo: string;
            export declare const BomRevision: string;
            export declare const Anlys7: string;
            export declare const Anlys8: string;
            export declare const LastLinkNo: string;
            export declare const Flag: string;
            export declare const HoldBy: string;
            export declare const IncludeScrapRate: string;
            export declare const UseItemMasterScrap: string;
            export declare const WcBackflush: string;
            export declare const Reorder: string;
            export declare const CostRework: string;
            export declare const MoldJob: string;
            export declare const MoldDesc: string;
            export declare const Anlys9: string;
            export declare const Anlys10: string;
            export declare const Anlys11: string;
            export declare const Anlys12: string;
            export declare const Anlys13: string;
            export declare const Anlys14: string;
            export declare const ProjectNo: string;
            export declare const SourceMrpNo: string;
        }

        [
            'Recnum', 
            'JobNo', 
            'Posted', 
            'Closed', 
            'Issued', 
            'Finished', 
            'AssemblyType', 
            'SourceSubjob', 
            'SourceSales', 
            'SourceAssort', 
            'SourceRefNo', 
            'SourceLineNo', 
            'SourcePartNo', 
            'IssueDate', 
            'DueDate', 
            'StartDate', 
            'ItemNo', 
            'Description', 
            'Uom', 
            'TotalQty', 
            'SpecNo', 
            'BomNo', 
            'StdOutput', 
            'ProdLotSize', 
            'NoOfLots', 
            'BatchedLots', 
            'HrsPerLot', 
            'HrsPerLotCpd', 
            'BranchNo', 
            'AssemblyLine', 
            'JobCategory', 
            'JobPriority', 
            'HeaderVerified', 
            'ByprodVerified', 
            'BatchVerified', 
            'BomVerified', 
            'RoutingVerifed', 
            'MatschVerified', 
            'WrkschVerified', 
            'CostVerified', 
            'ByprCostShare', 
            'TicketNeeded', 
            'TicketClosed', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'PostedDate', 
            'PostedBy', 
            'LastLineNo', 
            'LastByprodNo', 
            'BatchCount', 
            'LastLogNo', 
            'LockType', 
            'LockRefNo', 
            'FgLoc', 
            'RmLoc', 
            'CostMaterial', 
            'CostLabor', 
            'CostSubcon', 
            'CostMachine', 
            'CostEnergy', 
            'CostWater', 
            'CostRental', 
            'CostInlab', 
            'CostInmat', 
            'CostMisc', 
            'CostOverhead', 
            'CostEstimate', 
            'CostFinished', 
            'CostScrapped', 
            'CostCharged', 
            'CoacRmConsu', 
            'CoacRmScrap', 
            'CoacMaterial', 
            'CoacLabor', 
            'CoacSubcon', 
            'CoacMachine', 
            'CoacEnergy', 
            'CoacWater', 
            'CoacRental', 
            'CoacInlab', 
            'CoacInmat', 
            'CoacMisc', 
            'CoacOverhead', 
            'CostActual', 
            'CostVariance', 
            'CostWip', 
            'AcctWip', 
            'AcctPvar', 
            'AcctProdCost', 
            'CanEdit', 
            'LastSubNo', 
            'SubjobVerified', 
            'LotsIssued', 
            'LotsFinished', 
            'OwnerBranch', 
            'SourceBranch', 
            'FinishedType', 
            'FinishedDate', 
            'Specifications', 
            'QtyNeeded', 
            'ScrapRate', 
            'ScrapQty', 
            'QtyAdjusted', 
            'NetWt', 
            'NetWtUom', 
            'Anlys1', 
            'Anlys2', 
            'BlowThru', 
            'Comments1', 
            'Comments2', 
            'Comments3', 
            'Comments4', 
            'LastTextNo', 
            'BomRevision', 
            'Anlys7', 
            'Anlys8', 
            'LastLinkNo', 
            'Flag', 
            'HoldBy', 
            'IncludeScrapRate', 
            'UseItemMasterScrap', 
            'WcBackflush', 
            'Reorder', 
            'CostRework', 
            'MoldJob', 
            'MoldDesc', 
            'Anlys9', 
            'Anlys10', 
            'Anlys11', 
            'Anlys12', 
            'Anlys13', 
            'Anlys14', 
            'ProjectNo', 
            'SourceMrpNo'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

