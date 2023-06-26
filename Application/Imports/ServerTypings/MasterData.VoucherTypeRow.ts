namespace Matrix.MasterData {
    export interface VoucherTypeRow {
        Recnum?: number;
        VoucherType?: string;
        Description?: string;
        Suspended?: boolean;
        DirectEntry?: boolean;
        AllowEdit?: boolean;
        MultiCurrency?: boolean;
        BatchedPosting?: boolean;
        CostCtrOpt?: string;
        DeptOpt?: string;
        Anlys1Opt?: string;
        Anlys2Opt?: string;
        Anlys3DrOpt?: string;
        Anlys4DrOpt?: string;
        Anlys5DrOpt?: string;
        Anlys6DrOpt?: string;
        Anlys3CrOpt?: string;
        Anlys4CrOpt?: string;
        Anlys5CrOpt?: string;
        Anlys6CrOpt?: string;
        SeriesCode?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        BatchCount?: number;
        OwnerBranch?: string;
        SourceBranch?: string;
        Remarks?: string;
        Anlys7Opt?: string;
        Anlys8Opt?: string;
        Anlys9Opt?: string;
        Anlys10Opt?: string;
        Anlys11Opt?: string;
        Anlys12Opt?: string;
        Anlys13Opt?: string;
        Anlys14Opt?: string;
        Anlys15DrOpt?: string;
        Anlys16DrOpt?: string;
        Anlys17DrOpt?: string;
        Anlys18DrOpt?: string;
        Anlys19DrOpt?: string;
        Anlys20DrOpt?: string;
        Anlys15CrOpt?: string;
        Anlys16CrOpt?: string;
        Anlys17CrOpt?: string;
        Anlys18CrOpt?: string;
        Anlys19CrOpt?: string;
        Anlys20CrOpt?: string;
    }

    export namespace VoucherTypeRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'VoucherType';
        export const localTextPrefix = 'MasterData.VoucherType';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const VoucherType: string;
            export declare const Description: string;
            export declare const Suspended: string;
            export declare const DirectEntry: string;
            export declare const AllowEdit: string;
            export declare const MultiCurrency: string;
            export declare const BatchedPosting: string;
            export declare const CostCtrOpt: string;
            export declare const DeptOpt: string;
            export declare const Anlys1Opt: string;
            export declare const Anlys2Opt: string;
            export declare const Anlys3DrOpt: string;
            export declare const Anlys4DrOpt: string;
            export declare const Anlys5DrOpt: string;
            export declare const Anlys6DrOpt: string;
            export declare const Anlys3CrOpt: string;
            export declare const Anlys4CrOpt: string;
            export declare const Anlys5CrOpt: string;
            export declare const Anlys6CrOpt: string;
            export declare const SeriesCode: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const BatchCount: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const Remarks: string;
            export declare const Anlys7Opt: string;
            export declare const Anlys8Opt: string;
            export declare const Anlys9Opt: string;
            export declare const Anlys10Opt: string;
            export declare const Anlys11Opt: string;
            export declare const Anlys12Opt: string;
            export declare const Anlys13Opt: string;
            export declare const Anlys14Opt: string;
            export declare const Anlys15DrOpt: string;
            export declare const Anlys16DrOpt: string;
            export declare const Anlys17DrOpt: string;
            export declare const Anlys18DrOpt: string;
            export declare const Anlys19DrOpt: string;
            export declare const Anlys20DrOpt: string;
            export declare const Anlys15CrOpt: string;
            export declare const Anlys16CrOpt: string;
            export declare const Anlys17CrOpt: string;
            export declare const Anlys18CrOpt: string;
            export declare const Anlys19CrOpt: string;
            export declare const Anlys20CrOpt: string;
        }

        [
            'Recnum', 
            'VoucherType', 
            'Description', 
            'Suspended', 
            'DirectEntry', 
            'AllowEdit', 
            'MultiCurrency', 
            'BatchedPosting', 
            'CostCtrOpt', 
            'DeptOpt', 
            'Anlys1Opt', 
            'Anlys2Opt', 
            'Anlys3DrOpt', 
            'Anlys4DrOpt', 
            'Anlys5DrOpt', 
            'Anlys6DrOpt', 
            'Anlys3CrOpt', 
            'Anlys4CrOpt', 
            'Anlys5CrOpt', 
            'Anlys6CrOpt', 
            'SeriesCode', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'BatchCount', 
            'OwnerBranch', 
            'SourceBranch', 
            'Remarks', 
            'Anlys7Opt', 
            'Anlys8Opt', 
            'Anlys9Opt', 
            'Anlys10Opt', 
            'Anlys11Opt', 
            'Anlys12Opt', 
            'Anlys13Opt', 
            'Anlys14Opt', 
            'Anlys15DrOpt', 
            'Anlys16DrOpt', 
            'Anlys17DrOpt', 
            'Anlys18DrOpt', 
            'Anlys19DrOpt', 
            'Anlys20DrOpt', 
            'Anlys15CrOpt', 
            'Anlys16CrOpt', 
            'Anlys17CrOpt', 
            'Anlys18CrOpt', 
            'Anlys19CrOpt', 
            'Anlys20CrOpt'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

