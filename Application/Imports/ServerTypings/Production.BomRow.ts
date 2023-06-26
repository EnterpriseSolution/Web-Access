namespace Matrix.Production {
    export interface BomRow {
        Recnum?: number;
        BomNo?: string;
        Suspended?: string;
        AssmItemNo?: string;
        Description?: string;
        Uom?: string;
        StdOutput?: number;
        EffectFrom?: string;
        EffectTo?: string;
        PartsVerified?: string;
        ProcVerified?: string;
        EcnRequired?: string;
        BranchNo?: string;
        AssemblyLine?: string;
        FixedAsmLine?: string;
        WorkEstBasis?: string;
        StdLotSize?: number;
        MinLotSize?: number;
        MaxLotSize?: number;
        ScrapRate?: number;
        LastLineNo?: number;
        LastLogNo?: number;
        PartsCount?: number;
        RouteCount?: number;
        ByproCount?: number;
        ByproShare?: number;
        MnproShare?: number;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        LockType?: string;
        LockRefNo?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        LastEcnNo?: string;
        MassCngId?: string;
        AllowChgJob?: string;
        NetWt?: number;
        NetWtUom?: string;
        BomRevision?: string;
        Flag?: string;
        HoldBy?: string;
        LastPartsSeqNo?: number;
        IsApproved?: string;
        ApprovedBy?: string;
        Preapprove?: string;
        ApprovedDate?: string;
        Remarks?: string;
        IssueRunnerWaste?: string;
        RunnerWasteWt?: number;
        RunnerWasteUom?: string;
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
        AllowRohsMatOnly?: boolean;
        IssueExtraRunnerWaste?: boolean;
        Phantom?: boolean;
        DieCutter?: number;
    }

    export namespace BomRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'BomNo';
        export const localTextPrefix = 'Production.Bom';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const BomNo: string;
            export declare const Suspended: string;
            export declare const AssmItemNo: string;
            export declare const Description: string;
            export declare const Uom: string;
            export declare const StdOutput: string;
            export declare const EffectFrom: string;
            export declare const EffectTo: string;
            export declare const PartsVerified: string;
            export declare const ProcVerified: string;
            export declare const EcnRequired: string;
            export declare const BranchNo: string;
            export declare const AssemblyLine: string;
            export declare const FixedAsmLine: string;
            export declare const WorkEstBasis: string;
            export declare const StdLotSize: string;
            export declare const MinLotSize: string;
            export declare const MaxLotSize: string;
            export declare const ScrapRate: string;
            export declare const LastLineNo: string;
            export declare const LastLogNo: string;
            export declare const PartsCount: string;
            export declare const RouteCount: string;
            export declare const ByproCount: string;
            export declare const ByproShare: string;
            export declare const MnproShare: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const LockType: string;
            export declare const LockRefNo: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const LastEcnNo: string;
            export declare const MassCngId: string;
            export declare const AllowChgJob: string;
            export declare const NetWt: string;
            export declare const NetWtUom: string;
            export declare const BomRevision: string;
            export declare const Flag: string;
            export declare const HoldBy: string;
            export declare const LastPartsSeqNo: string;
            export declare const IsApproved: string;
            export declare const ApprovedBy: string;
            export declare const Preapprove: string;
            export declare const ApprovedDate: string;
            export declare const Remarks: string;
            export declare const IssueRunnerWaste: string;
            export declare const RunnerWasteWt: string;
            export declare const RunnerWasteUom: string;
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
            export declare const AllowRohsMatOnly: string;
            export declare const IssueExtraRunnerWaste: string;
            export declare const Phantom: string;
            export declare const DieCutter: string;
        }

        [
            'Recnum', 
            'BomNo', 
            'Suspended', 
            'AssmItemNo', 
            'Description', 
            'Uom', 
            'StdOutput', 
            'EffectFrom', 
            'EffectTo', 
            'PartsVerified', 
            'ProcVerified', 
            'EcnRequired', 
            'BranchNo', 
            'AssemblyLine', 
            'FixedAsmLine', 
            'WorkEstBasis', 
            'StdLotSize', 
            'MinLotSize', 
            'MaxLotSize', 
            'ScrapRate', 
            'LastLineNo', 
            'LastLogNo', 
            'PartsCount', 
            'RouteCount', 
            'ByproCount', 
            'ByproShare', 
            'MnproShare', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'LockType', 
            'LockRefNo', 
            'OwnerBranch', 
            'SourceBranch', 
            'LastEcnNo', 
            'MassCngId', 
            'AllowChgJob', 
            'NetWt', 
            'NetWtUom', 
            'BomRevision', 
            'Flag', 
            'HoldBy', 
            'LastPartsSeqNo', 
            'IsApproved', 
            'ApprovedBy', 
            'Preapprove', 
            'ApprovedDate', 
            'Remarks', 
            'IssueRunnerWaste', 
            'RunnerWasteWt', 
            'RunnerWasteUom', 
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
            'AllowRohsMatOnly', 
            'IssueExtraRunnerWaste', 
            'Phantom', 
            'DieCutter'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

