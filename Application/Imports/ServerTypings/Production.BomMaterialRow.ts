namespace Matrix.Production {
    export interface BomMaterialRow {
        Recnum?: number;
        BomNo?: string;
        SeqNo?: number;
        PartItemNo?: string;
        Description?: string;
        Uom?: string;
        QtyPer?: number;
        WithAltern?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        EntrySeqNo?: number;
        AssmItemNo?: string;
        ScrapRate?: number;
        OwnerBranch?: string;
        SourceBranch?: string;
        LocCount?: number;
        BlowThruBomNo?: string;
        Remarks?: string;
        LastAltSeqNo?: number;
        LastEcnNo?: string;
        RunnerWaste?: string;
        RunnerWasteRate?: number;
        UserDefinedField1?: string;
        UserDefinedField2?: string;
        UserDefinedField3?: string;
        UserDefinedField4?: string;
        UserDefinedField5?: string;
        UserDefinedField6?: string;
        UserDefinedField7?: string;
        UserDefinedField8?: string;
        UserDefinedField9?: string;
        UserDefinedField10?: string;
        UserDefinedField11?: string;
        UserDefinedField12?: string;
        UserDefinedField13?: string;
        UserDefinedField14?: string;
        UserDefinedField15?: string;
        UserDefinedField16?: string;
        UserDefinedField17?: string;
        UserDefinedField18?: string;
        UserDefinedField19?: string;
        UserDefinedField20?: string;
        RohsCompliance?: boolean;
        Approved?: boolean;
        Uom2?: string;
        QtyPer2?: number;
        WorkCentre?: string;
        QuotationScrapQty?: number;
        QuotationScrapRate?: number;
        QuotationQty?: number;
        ShowCost?: boolean;
        QtyBeforeConversion?: number;
        BomNoRecnum?: number;
        BomNoSuspended?: string;
        BomNoAssmItemNo?: string;
        BomNoDescription?: string;
        BomNoUom?: string;
        BomNoStdOutput?: number;
        BomNoEffectFrom?: string;
        BomNoEffectTo?: string;
        BomNoPartsVerified?: string;
        BomNoProcVerified?: string;
        BomNoEcnRequired?: string;
        BomNoBranchNo?: string;
        BomNoAssemblyLine?: string;
        BomNoFixedAsmLine?: string;
        BomNoWorkEstBasis?: string;
        BomNoStdLotSize?: number;
        BomNoMinLotSize?: number;
        BomNoMaxLotSize?: number;
        BomNoScrapRate?: number;
        BomNoLastLineNo?: number;
        BomNoLastLogNo?: number;
        BomNoPartsCount?: number;
        BomNoRouteCount?: number;
        BomNoByproCount?: number;
        BomNoByproShare?: number;
        BomNoMnproShare?: number;
        BomNoCreatedDate?: string;
        BomNoCreatedBy?: string;
        BomNoRevisedDate?: string;
        BomNoRevisedBy?: string;
        BomNoLockType?: string;
        BomNoLockRefNo?: string;
        BomNoOwnerBranch?: string;
        BomNoSourceBranch?: string;
        BomNoLastEcnNo?: string;
        BomNoMassCngId?: string;
        BomNoAllowChgJob?: string;
        BomNoNetWt?: number;
        BomNoNetWtUom?: string;
        BomNoBomRevision?: string;
        BomNoFlag?: string;
        BomNoHoldBy?: string;
        BomNoLastPartsSeqNo?: number;
        BomNoIsApproved?: string;
        BomNoApprovedBy?: string;
        BomNoPreapprove?: string;
        BomNoApprovedDate?: string;
        BomNoRemarks?: string;
        BomNoIssueRunnerWaste?: string;
        BomNoRunnerWasteWt?: number;
        BomNoRunnerWasteUom?: string;
        BomNoUserDefinedField1?: string;
        BomNoUserDefinedField2?: string;
        BomNoUserDefinedField3?: string;
        BomNoUserDefinedField4?: string;
        BomNoUserDefinedField5?: string;
        BomNoUserDefinedField6?: string;
        BomNoUserDefinedField7?: string;
        BomNoUserDefinedField8?: string;
        BomNoUserDefinedField9?: string;
        BomNoUserDefinedField10?: string;
        BomNoUserDefinedField11?: string;
        BomNoUserDefinedField12?: string;
        BomNoUserDefinedField13?: string;
        BomNoUserDefinedField14?: string;
        BomNoUserDefinedField15?: string;
        BomNoUserDefinedField16?: string;
        BomNoUserDefinedField17?: string;
        BomNoUserDefinedField18?: string;
        BomNoUserDefinedField19?: string;
        BomNoUserDefinedField20?: string;
        BomNoAllowRohsMatOnly?: boolean;
        BomNoIssueExtraRunnerWaste?: boolean;
        BomNoPhantom?: boolean;
        BomNoDieCutter?: number;
    }

    export namespace BomMaterialRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'BomNo';
        export const localTextPrefix = 'Production.BomMaterial';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const BomNo: string;
            export declare const SeqNo: string;
            export declare const PartItemNo: string;
            export declare const Description: string;
            export declare const Uom: string;
            export declare const QtyPer: string;
            export declare const WithAltern: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const EntrySeqNo: string;
            export declare const AssmItemNo: string;
            export declare const ScrapRate: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const LocCount: string;
            export declare const BlowThruBomNo: string;
            export declare const Remarks: string;
            export declare const LastAltSeqNo: string;
            export declare const LastEcnNo: string;
            export declare const RunnerWaste: string;
            export declare const RunnerWasteRate: string;
            export declare const UserDefinedField1: string;
            export declare const UserDefinedField2: string;
            export declare const UserDefinedField3: string;
            export declare const UserDefinedField4: string;
            export declare const UserDefinedField5: string;
            export declare const UserDefinedField6: string;
            export declare const UserDefinedField7: string;
            export declare const UserDefinedField8: string;
            export declare const UserDefinedField9: string;
            export declare const UserDefinedField10: string;
            export declare const UserDefinedField11: string;
            export declare const UserDefinedField12: string;
            export declare const UserDefinedField13: string;
            export declare const UserDefinedField14: string;
            export declare const UserDefinedField15: string;
            export declare const UserDefinedField16: string;
            export declare const UserDefinedField17: string;
            export declare const UserDefinedField18: string;
            export declare const UserDefinedField19: string;
            export declare const UserDefinedField20: string;
            export declare const RohsCompliance: string;
            export declare const Approved: string;
            export declare const Uom2: string;
            export declare const QtyPer2: string;
            export declare const WorkCentre: string;
            export declare const QuotationScrapQty: string;
            export declare const QuotationScrapRate: string;
            export declare const QuotationQty: string;
            export declare const ShowCost: string;
            export declare const QtyBeforeConversion: string;
            export declare const BomNoRecnum: string;
            export declare const BomNoSuspended: string;
            export declare const BomNoAssmItemNo: string;
            export declare const BomNoDescription: string;
            export declare const BomNoUom: string;
            export declare const BomNoStdOutput: string;
            export declare const BomNoEffectFrom: string;
            export declare const BomNoEffectTo: string;
            export declare const BomNoPartsVerified: string;
            export declare const BomNoProcVerified: string;
            export declare const BomNoEcnRequired: string;
            export declare const BomNoBranchNo: string;
            export declare const BomNoAssemblyLine: string;
            export declare const BomNoFixedAsmLine: string;
            export declare const BomNoWorkEstBasis: string;
            export declare const BomNoStdLotSize: string;
            export declare const BomNoMinLotSize: string;
            export declare const BomNoMaxLotSize: string;
            export declare const BomNoScrapRate: string;
            export declare const BomNoLastLineNo: string;
            export declare const BomNoLastLogNo: string;
            export declare const BomNoPartsCount: string;
            export declare const BomNoRouteCount: string;
            export declare const BomNoByproCount: string;
            export declare const BomNoByproShare: string;
            export declare const BomNoMnproShare: string;
            export declare const BomNoCreatedDate: string;
            export declare const BomNoCreatedBy: string;
            export declare const BomNoRevisedDate: string;
            export declare const BomNoRevisedBy: string;
            export declare const BomNoLockType: string;
            export declare const BomNoLockRefNo: string;
            export declare const BomNoOwnerBranch: string;
            export declare const BomNoSourceBranch: string;
            export declare const BomNoLastEcnNo: string;
            export declare const BomNoMassCngId: string;
            export declare const BomNoAllowChgJob: string;
            export declare const BomNoNetWt: string;
            export declare const BomNoNetWtUom: string;
            export declare const BomNoBomRevision: string;
            export declare const BomNoFlag: string;
            export declare const BomNoHoldBy: string;
            export declare const BomNoLastPartsSeqNo: string;
            export declare const BomNoIsApproved: string;
            export declare const BomNoApprovedBy: string;
            export declare const BomNoPreapprove: string;
            export declare const BomNoApprovedDate: string;
            export declare const BomNoRemarks: string;
            export declare const BomNoIssueRunnerWaste: string;
            export declare const BomNoRunnerWasteWt: string;
            export declare const BomNoRunnerWasteUom: string;
            export declare const BomNoUserDefinedField1: string;
            export declare const BomNoUserDefinedField2: string;
            export declare const BomNoUserDefinedField3: string;
            export declare const BomNoUserDefinedField4: string;
            export declare const BomNoUserDefinedField5: string;
            export declare const BomNoUserDefinedField6: string;
            export declare const BomNoUserDefinedField7: string;
            export declare const BomNoUserDefinedField8: string;
            export declare const BomNoUserDefinedField9: string;
            export declare const BomNoUserDefinedField10: string;
            export declare const BomNoUserDefinedField11: string;
            export declare const BomNoUserDefinedField12: string;
            export declare const BomNoUserDefinedField13: string;
            export declare const BomNoUserDefinedField14: string;
            export declare const BomNoUserDefinedField15: string;
            export declare const BomNoUserDefinedField16: string;
            export declare const BomNoUserDefinedField17: string;
            export declare const BomNoUserDefinedField18: string;
            export declare const BomNoUserDefinedField19: string;
            export declare const BomNoUserDefinedField20: string;
            export declare const BomNoAllowRohsMatOnly: string;
            export declare const BomNoIssueExtraRunnerWaste: string;
            export declare const BomNoPhantom: string;
            export declare const BomNoDieCutter: string;
        }

        [
            'Recnum', 
            'BomNo', 
            'SeqNo', 
            'PartItemNo', 
            'Description', 
            'Uom', 
            'QtyPer', 
            'WithAltern', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'EntrySeqNo', 
            'AssmItemNo', 
            'ScrapRate', 
            'OwnerBranch', 
            'SourceBranch', 
            'LocCount', 
            'BlowThruBomNo', 
            'Remarks', 
            'LastAltSeqNo', 
            'LastEcnNo', 
            'RunnerWaste', 
            'RunnerWasteRate', 
            'UserDefinedField1', 
            'UserDefinedField2', 
            'UserDefinedField3', 
            'UserDefinedField4', 
            'UserDefinedField5', 
            'UserDefinedField6', 
            'UserDefinedField7', 
            'UserDefinedField8', 
            'UserDefinedField9', 
            'UserDefinedField10', 
            'UserDefinedField11', 
            'UserDefinedField12', 
            'UserDefinedField13', 
            'UserDefinedField14', 
            'UserDefinedField15', 
            'UserDefinedField16', 
            'UserDefinedField17', 
            'UserDefinedField18', 
            'UserDefinedField19', 
            'UserDefinedField20', 
            'RohsCompliance', 
            'Approved', 
            'Uom2', 
            'QtyPer2', 
            'WorkCentre', 
            'QuotationScrapQty', 
            'QuotationScrapRate', 
            'QuotationQty', 
            'ShowCost', 
            'QtyBeforeConversion', 
            'BomNoRecnum', 
            'BomNoSuspended', 
            'BomNoAssmItemNo', 
            'BomNoDescription', 
            'BomNoUom', 
            'BomNoStdOutput', 
            'BomNoEffectFrom', 
            'BomNoEffectTo', 
            'BomNoPartsVerified', 
            'BomNoProcVerified', 
            'BomNoEcnRequired', 
            'BomNoBranchNo', 
            'BomNoAssemblyLine', 
            'BomNoFixedAsmLine', 
            'BomNoWorkEstBasis', 
            'BomNoStdLotSize', 
            'BomNoMinLotSize', 
            'BomNoMaxLotSize', 
            'BomNoScrapRate', 
            'BomNoLastLineNo', 
            'BomNoLastLogNo', 
            'BomNoPartsCount', 
            'BomNoRouteCount', 
            'BomNoByproCount', 
            'BomNoByproShare', 
            'BomNoMnproShare', 
            'BomNoCreatedDate', 
            'BomNoCreatedBy', 
            'BomNoRevisedDate', 
            'BomNoRevisedBy', 
            'BomNoLockType', 
            'BomNoLockRefNo', 
            'BomNoOwnerBranch', 
            'BomNoSourceBranch', 
            'BomNoLastEcnNo', 
            'BomNoMassCngId', 
            'BomNoAllowChgJob', 
            'BomNoNetWt', 
            'BomNoNetWtUom', 
            'BomNoBomRevision', 
            'BomNoFlag', 
            'BomNoHoldBy', 
            'BomNoLastPartsSeqNo', 
            'BomNoIsApproved', 
            'BomNoApprovedBy', 
            'BomNoPreapprove', 
            'BomNoApprovedDate', 
            'BomNoRemarks', 
            'BomNoIssueRunnerWaste', 
            'BomNoRunnerWasteWt', 
            'BomNoRunnerWasteUom', 
            'BomNoUserDefinedField1', 
            'BomNoUserDefinedField2', 
            'BomNoUserDefinedField3', 
            'BomNoUserDefinedField4', 
            'BomNoUserDefinedField5', 
            'BomNoUserDefinedField6', 
            'BomNoUserDefinedField7', 
            'BomNoUserDefinedField8', 
            'BomNoUserDefinedField9', 
            'BomNoUserDefinedField10', 
            'BomNoUserDefinedField11', 
            'BomNoUserDefinedField12', 
            'BomNoUserDefinedField13', 
            'BomNoUserDefinedField14', 
            'BomNoUserDefinedField15', 
            'BomNoUserDefinedField16', 
            'BomNoUserDefinedField17', 
            'BomNoUserDefinedField18', 
            'BomNoUserDefinedField19', 
            'BomNoUserDefinedField20', 
            'BomNoAllowRohsMatOnly', 
            'BomNoIssueExtraRunnerWaste', 
            'BomNoPhantom', 
            'BomNoDieCutter'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

