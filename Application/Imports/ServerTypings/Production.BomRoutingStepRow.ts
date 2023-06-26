namespace Matrix.Production {
    export interface BomRoutingStepRow {
        Recnum?: number;
        BomNo?: string;
        SeqNo?: number;
        OpCode?: string;
        Description?: string;
        Ticketed?: string;
        Reported?: string;
        ProdnMode?: string;
        WorkCentre?: string;
        FixedWcentre?: string;
        NoOfWorkers?: number;
        PieceRate?: number;
        SubconVendor?: string;
        SubconRate?: number;
        FixedVendor?: string;
        MachLoadHr?: number;
        ManLoadHr?: number;
        MachProcessHr?: number;
        ManProcessHr?: number;
        MachUnloadHr?: number;
        ManUnloadHr?: number;
        MachineCost?: number;
        EnergyCost?: number;
        WaterCost?: number;
        RentalCost?: number;
        LaborCost?: number;
        InlabCost?: number;
        InmatCost?: number;
        MiscCost?: number;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        Specifications?: string;
        DependTo?: number;
        Dependency?: string;
        LagHour?: number;
        MachineNo?: string;
        MoldNo?: string;
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

    export namespace BomRoutingStepRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'BomNo';
        export const localTextPrefix = 'Production.BomRoutingStep';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const BomNo: string;
            export declare const SeqNo: string;
            export declare const OpCode: string;
            export declare const Description: string;
            export declare const Ticketed: string;
            export declare const Reported: string;
            export declare const ProdnMode: string;
            export declare const WorkCentre: string;
            export declare const FixedWcentre: string;
            export declare const NoOfWorkers: string;
            export declare const PieceRate: string;
            export declare const SubconVendor: string;
            export declare const SubconRate: string;
            export declare const FixedVendor: string;
            export declare const MachLoadHr: string;
            export declare const ManLoadHr: string;
            export declare const MachProcessHr: string;
            export declare const ManProcessHr: string;
            export declare const MachUnloadHr: string;
            export declare const ManUnloadHr: string;
            export declare const MachineCost: string;
            export declare const EnergyCost: string;
            export declare const WaterCost: string;
            export declare const RentalCost: string;
            export declare const LaborCost: string;
            export declare const InlabCost: string;
            export declare const InmatCost: string;
            export declare const MiscCost: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const Specifications: string;
            export declare const DependTo: string;
            export declare const Dependency: string;
            export declare const LagHour: string;
            export declare const MachineNo: string;
            export declare const MoldNo: string;
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
            'OpCode', 
            'Description', 
            'Ticketed', 
            'Reported', 
            'ProdnMode', 
            'WorkCentre', 
            'FixedWcentre', 
            'NoOfWorkers', 
            'PieceRate', 
            'SubconVendor', 
            'SubconRate', 
            'FixedVendor', 
            'MachLoadHr', 
            'ManLoadHr', 
            'MachProcessHr', 
            'ManProcessHr', 
            'MachUnloadHr', 
            'ManUnloadHr', 
            'MachineCost', 
            'EnergyCost', 
            'WaterCost', 
            'RentalCost', 
            'LaborCost', 
            'InlabCost', 
            'InmatCost', 
            'MiscCost', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch', 
            'Specifications', 
            'DependTo', 
            'Dependency', 
            'LagHour', 
            'MachineNo', 
            'MoldNo', 
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

