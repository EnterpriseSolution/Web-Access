namespace Matrix.Inventory {
    export interface InventoryMovementRow {
        Recnum?: number;
        RefNo?: string;
        TranType?: string;
        MoveDate?: string;
        ValueDate?: string;
        Posted?: string;
        PostedStep1?: string;
        FlowType?: string;
        MoveType?: string;
        LocFrom?: string;
        LocTo?: string;
        Reference?: string;
        ReceivedFrom?: string;
        IssuedTo?: string;
        Dept?: string;
        TotalCost?: number;
        LastLineNo?: number;
        CreatedBy?: string;
        CreatedDate?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        PostedDate?: string;
        PostedBy?: string;
        LogNo?: number;
        SourceType?: string;
        SourceRef?: string;
        Anlys1?: string;
        Anlys2?: string;
        Period?: string;
        FiscalYear?: number;
        PeriodNo?: number;
        JobNo?: string;
        BatchNo?: string;
        StartDate?: string;
        BranchNo?: string;
        Final?: string;
        LotsPending?: number;
        LotsIssued?: number;
        QtyIssued?: number;
        StdOutput?: number;
        BatchSelect?: string;
        GlLink?: string;
        GlLinkType?: string;
        GlLinkNo?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        Particulars?: string;
        RevisedCost?: number;
        CostDiff?: number;
        DiffAcct?: string;
        ItemNo?: string;
        BomNo?: string;
        Uom?: string;
        Qty?: number;
        FollowList?: string;
        Anlys7?: string;
        Anlys8?: string;
        Flag?: string;
        HoldBy?: string;
        Frozen?: string;
        ExcludeScrap?: string;
        Anlys9?: string;
        Anlys10?: string;
        Anlys11?: string;
        Anlys12?: string;
        Anlys13?: string;
        Anlys14?: string;
        LotsReturned?: number;
        StepNo?: number;
        ConsIssue?: boolean;
        ConsIssueRefNo?: string;
        ConsIssueLineNo?: number;
        DetailList?: InventoryMovementDetailRow[];
    }

    export namespace InventoryMovementRow {
        export const idProperty = 'RefNo';
        export const nameProperty = 'RefNo';
        export const localTextPrefix = 'Inventory.InventoryMovement';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const RefNo: string;
            export declare const TranType: string;
            export declare const MoveDate: string;
            export declare const ValueDate: string;
            export declare const Posted: string;
            export declare const PostedStep1: string;
            export declare const FlowType: string;
            export declare const MoveType: string;
            export declare const LocFrom: string;
            export declare const LocTo: string;
            export declare const Reference: string;
            export declare const ReceivedFrom: string;
            export declare const IssuedTo: string;
            export declare const Dept: string;
            export declare const TotalCost: string;
            export declare const LastLineNo: string;
            export declare const CreatedBy: string;
            export declare const CreatedDate: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const PostedDate: string;
            export declare const PostedBy: string;
            export declare const LogNo: string;
            export declare const SourceType: string;
            export declare const SourceRef: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const Period: string;
            export declare const FiscalYear: string;
            export declare const PeriodNo: string;
            export declare const JobNo: string;
            export declare const BatchNo: string;
            export declare const StartDate: string;
            export declare const BranchNo: string;
            export declare const Final: string;
            export declare const LotsPending: string;
            export declare const LotsIssued: string;
            export declare const QtyIssued: string;
            export declare const StdOutput: string;
            export declare const BatchSelect: string;
            export declare const GlLink: string;
            export declare const GlLinkType: string;
            export declare const GlLinkNo: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const Particulars: string;
            export declare const RevisedCost: string;
            export declare const CostDiff: string;
            export declare const DiffAcct: string;
            export declare const ItemNo: string;
            export declare const BomNo: string;
            export declare const Uom: string;
            export declare const Qty: string;
            export declare const FollowList: string;
            export declare const Anlys7: string;
            export declare const Anlys8: string;
            export declare const Flag: string;
            export declare const HoldBy: string;
            export declare const Frozen: string;
            export declare const ExcludeScrap: string;
            export declare const Anlys9: string;
            export declare const Anlys10: string;
            export declare const Anlys11: string;
            export declare const Anlys12: string;
            export declare const Anlys13: string;
            export declare const Anlys14: string;
            export declare const LotsReturned: string;
            export declare const StepNo: string;
            export declare const ConsIssue: string;
            export declare const ConsIssueRefNo: string;
            export declare const ConsIssueLineNo: string;
            export declare const DetailList: string;
        }

        [
            'Recnum', 
            'RefNo', 
            'TranType', 
            'MoveDate', 
            'ValueDate', 
            'Posted', 
            'PostedStep1', 
            'FlowType', 
            'MoveType', 
            'LocFrom', 
            'LocTo', 
            'Reference', 
            'ReceivedFrom', 
            'IssuedTo', 
            'Dept', 
            'TotalCost', 
            'LastLineNo', 
            'CreatedBy', 
            'CreatedDate', 
            'RevisedDate', 
            'RevisedBy', 
            'PostedDate', 
            'PostedBy', 
            'LogNo', 
            'SourceType', 
            'SourceRef', 
            'Anlys1', 
            'Anlys2', 
            'Period', 
            'FiscalYear', 
            'PeriodNo', 
            'JobNo', 
            'BatchNo', 
            'StartDate', 
            'BranchNo', 
            'Final', 
            'LotsPending', 
            'LotsIssued', 
            'QtyIssued', 
            'StdOutput', 
            'BatchSelect', 
            'GlLink', 
            'GlLinkType', 
            'GlLinkNo', 
            'OwnerBranch', 
            'SourceBranch', 
            'Particulars', 
            'RevisedCost', 
            'CostDiff', 
            'DiffAcct', 
            'ItemNo', 
            'BomNo', 
            'Uom', 
            'Qty', 
            'FollowList', 
            'Anlys7', 
            'Anlys8', 
            'Flag', 
            'HoldBy', 
            'Frozen', 
            'ExcludeScrap', 
            'Anlys9', 
            'Anlys10', 
            'Anlys11', 
            'Anlys12', 
            'Anlys13', 
            'Anlys14', 
            'LotsReturned', 
            'StepNo', 
            'ConsIssue', 
            'ConsIssueRefNo', 
            'ConsIssueLineNo', 
            'DetailList'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

