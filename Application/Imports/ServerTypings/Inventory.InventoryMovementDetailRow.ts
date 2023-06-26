namespace Matrix.Inventory {
    export interface InventoryMovementDetailRow {
        Recnum?: number;
        RefNo?: string;
        LineNo?: number;
        ItemNo?: string;
        Description?: string;
        Uom?: string;
        LotSize?: number;
        LineRef?: string;
        Qty?: number;
        UnitCost?: number;
        TotalCost?: number;
        QtyPerRec?: number;
        QtyPerCount?: number;
        BinQtyIn?: number;
        BinQtyOut?: number;
        Anlys1?: string;
        Anlys2?: string;
        Anlys3?: string;
        Anlys4?: string;
        Anlys5?: string;
        Anlys6?: string;
        BaseQty?: number;
        BaseUnitCost?: number;
        QtyCommitted?: number;
        QtyRequired?: number;
        QtyIssued?: number;
        QtyBalance?: number;
        QtyPer?: number;
        Final?: string;
        DebitAcct?: string;
        CreditAcct?: string;
        AllocMethod?: string;
        SourceType?: string;
        SourceRefNo?: string;
        SourceEntryNo?: number;
        SourcePartNo?: number;
        Particulars?: string;
        RevisedCost?: number;
        CostDiff?: number;
        FlowType?: string;
        LocFrom?: string;
        LocTo?: string;
        TempStubNo?: string;
        TempLoc?: string;
        TempReserved?: number;
        TempDateNeeded?: string;
        TempRemarks?: string;
        Anlys15?: string;
        Anlys16?: string;
        Anlys17?: string;
        Anlys18?: string;
        Anlys19?: string;
        Anlys20?: string;
        AllocatedQty?: number;
        AllocatedCost?: number;
        QtyPick?: number;
        Weight?: number;
        TotalWeight?: number;
        QtyFollowList?: number;
        QuotationScrapQty?: number;
        QuotationScrapRate?: number;
        RefNoRecnum?: number;
        RefNoTranType?: string;
        RefNoMoveDate?: string;
        RefNoValueDate?: string;
        RefNoPosted?: string;
        RefNoPostedStep1?: string;
        RefNoFlowType?: string;
        RefNoMoveType?: string;
        RefNoLocFrom?: string;
        RefNoLocTo?: string;
        RefNoReference?: string;
        RefNoReceivedFrom?: string;
        RefNoIssuedTo?: string;
        RefNoDept?: string;
        RefNoTotalCost?: number;
        RefNoLastLineNo?: number;
        RefNoCreatedBy?: string;
        RefNoCreatedDate?: string;
        RefNoRevisedDate?: string;
        RefNoRevisedBy?: string;
        RefNoPostedDate?: string;
        RefNoPostedBy?: string;
        RefNoLogNo?: number;
        RefNoSourceType?: string;
        RefNoSourceRef?: string;
        RefNoAnlys1?: string;
        RefNoAnlys2?: string;
        RefNoPeriod?: string;
        RefNoFiscalYear?: number;
        RefNoPeriodNo?: number;
        RefNoJobNo?: string;
        RefNoBatchNo?: string;
        RefNoStartDate?: string;
        RefNoBranchNo?: string;
        RefNoFinal?: string;
        RefNoLotsPending?: number;
        RefNoLotsIssued?: number;
        RefNoQtyIssued?: number;
        RefNoStdOutput?: number;
        RefNoBatchSelect?: string;
        RefNoGlLink?: string;
        RefNoGlLinkType?: string;
        RefNoGlLinkNo?: string;
        RefNoOwnerBranch?: string;
        RefNoSourceBranch?: string;
        RefNoParticulars?: string;
        RefNoRevisedCost?: number;
        RefNoCostDiff?: number;
        RefNoDiffAcct?: string;
        RefNoItemNo?: string;
        RefNoBomNo?: string;
        RefNoUom?: string;
        RefNoQty?: number;
        RefNoFollowList?: string;
        RefNoAnlys7?: string;
        RefNoAnlys8?: string;
        RefNoFlag?: string;
        RefNoHoldBy?: string;
        RefNoFrozen?: string;
        RefNoExcludeScrap?: string;
        RefNoAnlys9?: string;
        RefNoAnlys10?: string;
        RefNoAnlys11?: string;
        RefNoAnlys12?: string;
        RefNoAnlys13?: string;
        RefNoAnlys14?: string;
        RefNoLotsReturned?: number;
        RefNoStepNo?: number;
        RefNoConsIssue?: boolean;
        RefNoConsIssueRefNo?: string;
        RefNoConsIssueLineNo?: number;
    }

    export namespace InventoryMovementDetailRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'RefNo';
        export const localTextPrefix = 'Inventory.InventoryMovementDetail';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const RefNo: string;
            export declare const LineNo: string;
            export declare const ItemNo: string;
            export declare const Description: string;
            export declare const Uom: string;
            export declare const LotSize: string;
            export declare const LineRef: string;
            export declare const Qty: string;
            export declare const UnitCost: string;
            export declare const TotalCost: string;
            export declare const QtyPerRec: string;
            export declare const QtyPerCount: string;
            export declare const BinQtyIn: string;
            export declare const BinQtyOut: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const Anlys3: string;
            export declare const Anlys4: string;
            export declare const Anlys5: string;
            export declare const Anlys6: string;
            export declare const BaseQty: string;
            export declare const BaseUnitCost: string;
            export declare const QtyCommitted: string;
            export declare const QtyRequired: string;
            export declare const QtyIssued: string;
            export declare const QtyBalance: string;
            export declare const QtyPer: string;
            export declare const Final: string;
            export declare const DebitAcct: string;
            export declare const CreditAcct: string;
            export declare const AllocMethod: string;
            export declare const SourceType: string;
            export declare const SourceRefNo: string;
            export declare const SourceEntryNo: string;
            export declare const SourcePartNo: string;
            export declare const Particulars: string;
            export declare const RevisedCost: string;
            export declare const CostDiff: string;
            export declare const FlowType: string;
            export declare const LocFrom: string;
            export declare const LocTo: string;
            export declare const TempStubNo: string;
            export declare const TempLoc: string;
            export declare const TempReserved: string;
            export declare const TempDateNeeded: string;
            export declare const TempRemarks: string;
            export declare const Anlys15: string;
            export declare const Anlys16: string;
            export declare const Anlys17: string;
            export declare const Anlys18: string;
            export declare const Anlys19: string;
            export declare const Anlys20: string;
            export declare const AllocatedQty: string;
            export declare const AllocatedCost: string;
            export declare const QtyPick: string;
            export declare const Weight: string;
            export declare const TotalWeight: string;
            export declare const QtyFollowList: string;
            export declare const QuotationScrapQty: string;
            export declare const QuotationScrapRate: string;
            export declare const RefNoRecnum: string;
            export declare const RefNoTranType: string;
            export declare const RefNoMoveDate: string;
            export declare const RefNoValueDate: string;
            export declare const RefNoPosted: string;
            export declare const RefNoPostedStep1: string;
            export declare const RefNoFlowType: string;
            export declare const RefNoMoveType: string;
            export declare const RefNoLocFrom: string;
            export declare const RefNoLocTo: string;
            export declare const RefNoReference: string;
            export declare const RefNoReceivedFrom: string;
            export declare const RefNoIssuedTo: string;
            export declare const RefNoDept: string;
            export declare const RefNoTotalCost: string;
            export declare const RefNoLastLineNo: string;
            export declare const RefNoCreatedBy: string;
            export declare const RefNoCreatedDate: string;
            export declare const RefNoRevisedDate: string;
            export declare const RefNoRevisedBy: string;
            export declare const RefNoPostedDate: string;
            export declare const RefNoPostedBy: string;
            export declare const RefNoLogNo: string;
            export declare const RefNoSourceType: string;
            export declare const RefNoSourceRef: string;
            export declare const RefNoAnlys1: string;
            export declare const RefNoAnlys2: string;
            export declare const RefNoPeriod: string;
            export declare const RefNoFiscalYear: string;
            export declare const RefNoPeriodNo: string;
            export declare const RefNoJobNo: string;
            export declare const RefNoBatchNo: string;
            export declare const RefNoStartDate: string;
            export declare const RefNoBranchNo: string;
            export declare const RefNoFinal: string;
            export declare const RefNoLotsPending: string;
            export declare const RefNoLotsIssued: string;
            export declare const RefNoQtyIssued: string;
            export declare const RefNoStdOutput: string;
            export declare const RefNoBatchSelect: string;
            export declare const RefNoGlLink: string;
            export declare const RefNoGlLinkType: string;
            export declare const RefNoGlLinkNo: string;
            export declare const RefNoOwnerBranch: string;
            export declare const RefNoSourceBranch: string;
            export declare const RefNoParticulars: string;
            export declare const RefNoRevisedCost: string;
            export declare const RefNoCostDiff: string;
            export declare const RefNoDiffAcct: string;
            export declare const RefNoItemNo: string;
            export declare const RefNoBomNo: string;
            export declare const RefNoUom: string;
            export declare const RefNoQty: string;
            export declare const RefNoFollowList: string;
            export declare const RefNoAnlys7: string;
            export declare const RefNoAnlys8: string;
            export declare const RefNoFlag: string;
            export declare const RefNoHoldBy: string;
            export declare const RefNoFrozen: string;
            export declare const RefNoExcludeScrap: string;
            export declare const RefNoAnlys9: string;
            export declare const RefNoAnlys10: string;
            export declare const RefNoAnlys11: string;
            export declare const RefNoAnlys12: string;
            export declare const RefNoAnlys13: string;
            export declare const RefNoAnlys14: string;
            export declare const RefNoLotsReturned: string;
            export declare const RefNoStepNo: string;
            export declare const RefNoConsIssue: string;
            export declare const RefNoConsIssueRefNo: string;
            export declare const RefNoConsIssueLineNo: string;
        }

        [
            'Recnum', 
            'RefNo', 
            'LineNo', 
            'ItemNo', 
            'Description', 
            'Uom', 
            'LotSize', 
            'LineRef', 
            'Qty', 
            'UnitCost', 
            'TotalCost', 
            'QtyPerRec', 
            'QtyPerCount', 
            'BinQtyIn', 
            'BinQtyOut', 
            'Anlys1', 
            'Anlys2', 
            'Anlys3', 
            'Anlys4', 
            'Anlys5', 
            'Anlys6', 
            'BaseQty', 
            'BaseUnitCost', 
            'QtyCommitted', 
            'QtyRequired', 
            'QtyIssued', 
            'QtyBalance', 
            'QtyPer', 
            'Final', 
            'DebitAcct', 
            'CreditAcct', 
            'AllocMethod', 
            'SourceType', 
            'SourceRefNo', 
            'SourceEntryNo', 
            'SourcePartNo', 
            'Particulars', 
            'RevisedCost', 
            'CostDiff', 
            'FlowType', 
            'LocFrom', 
            'LocTo', 
            'TempStubNo', 
            'TempLoc', 
            'TempReserved', 
            'TempDateNeeded', 
            'TempRemarks', 
            'Anlys15', 
            'Anlys16', 
            'Anlys17', 
            'Anlys18', 
            'Anlys19', 
            'Anlys20', 
            'AllocatedQty', 
            'AllocatedCost', 
            'QtyPick', 
            'Weight', 
            'TotalWeight', 
            'QtyFollowList', 
            'QuotationScrapQty', 
            'QuotationScrapRate', 
            'RefNoRecnum', 
            'RefNoTranType', 
            'RefNoMoveDate', 
            'RefNoValueDate', 
            'RefNoPosted', 
            'RefNoPostedStep1', 
            'RefNoFlowType', 
            'RefNoMoveType', 
            'RefNoLocFrom', 
            'RefNoLocTo', 
            'RefNoReference', 
            'RefNoReceivedFrom', 
            'RefNoIssuedTo', 
            'RefNoDept', 
            'RefNoTotalCost', 
            'RefNoLastLineNo', 
            'RefNoCreatedBy', 
            'RefNoCreatedDate', 
            'RefNoRevisedDate', 
            'RefNoRevisedBy', 
            'RefNoPostedDate', 
            'RefNoPostedBy', 
            'RefNoLogNo', 
            'RefNoSourceType', 
            'RefNoSourceRef', 
            'RefNoAnlys1', 
            'RefNoAnlys2', 
            'RefNoPeriod', 
            'RefNoFiscalYear', 
            'RefNoPeriodNo', 
            'RefNoJobNo', 
            'RefNoBatchNo', 
            'RefNoStartDate', 
            'RefNoBranchNo', 
            'RefNoFinal', 
            'RefNoLotsPending', 
            'RefNoLotsIssued', 
            'RefNoQtyIssued', 
            'RefNoStdOutput', 
            'RefNoBatchSelect', 
            'RefNoGlLink', 
            'RefNoGlLinkType', 
            'RefNoGlLinkNo', 
            'RefNoOwnerBranch', 
            'RefNoSourceBranch', 
            'RefNoParticulars', 
            'RefNoRevisedCost', 
            'RefNoCostDiff', 
            'RefNoDiffAcct', 
            'RefNoItemNo', 
            'RefNoBomNo', 
            'RefNoUom', 
            'RefNoQty', 
            'RefNoFollowList', 
            'RefNoAnlys7', 
            'RefNoAnlys8', 
            'RefNoFlag', 
            'RefNoHoldBy', 
            'RefNoFrozen', 
            'RefNoExcludeScrap', 
            'RefNoAnlys9', 
            'RefNoAnlys10', 
            'RefNoAnlys11', 
            'RefNoAnlys12', 
            'RefNoAnlys13', 
            'RefNoAnlys14', 
            'RefNoLotsReturned', 
            'RefNoStepNo', 
            'RefNoConsIssue', 
            'RefNoConsIssueRefNo', 
            'RefNoConsIssueLineNo'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

