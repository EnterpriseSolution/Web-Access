namespace Matrix.Finance {
    export interface VoucherPresetRow {
        Recnum?: number;
        VoucherType?: string;
        SeqNo?: number;
        AcctNo?: string;
        Ccy?: string;
        ExchRate?: number;
        DebitAmt?: number;
        CreditAmt?: number;
        BaseLineNo?: number;
        BaseEntry?: string;
        ResultPercent?: number;
        ResultSign?: string;
        CostCentre?: string;
        Dept?: string;
        Anlys1?: string;
        Anlys2?: string;
        Anlys3?: string;
        Anlys4?: string;
        Anlys5?: string;
        Anlys6?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        Particulars?: string;
        VoucherTypeRecnum?: number;
        VoucherTypeDescription?: string;
        VoucherTypeSuspended?: string;
        VoucherTypeDirectEntry?: string;
        VoucherTypeAllowEdit?: string;
        VoucherTypeMultiCurrency?: string;
        VoucherTypeBatchedPosting?: string;
        VoucherTypeCostCtrOpt?: string;
        VoucherTypeDeptOpt?: string;
        VoucherTypeAnlys1Opt?: string;
        VoucherTypeAnlys2Opt?: string;
        VoucherTypeAnlys3DrOpt?: string;
        VoucherTypeAnlys4DrOpt?: string;
        VoucherTypeAnlys5DrOpt?: string;
        VoucherTypeAnlys6DrOpt?: string;
        VoucherTypeAnlys3CrOpt?: string;
        VoucherTypeAnlys4CrOpt?: string;
        VoucherTypeAnlys5CrOpt?: string;
        VoucherTypeAnlys6CrOpt?: string;
        VoucherTypeSeriesCode?: string;
        VoucherTypeCreatedDate?: string;
        VoucherTypeCreatedBy?: string;
        VoucherTypeRevisedDate?: string;
        VoucherTypeRevisedBy?: string;
        VoucherTypeBatchCount?: number;
        VoucherTypeOwnerBranch?: string;
        VoucherTypeSourceBranch?: string;
        VoucherTypeRemarks?: string;
        VoucherTypeAnlys7Opt?: string;
        VoucherTypeAnlys8Opt?: string;
        VoucherTypeAnlys9Opt?: string;
        VoucherTypeAnlys10Opt?: string;
        VoucherTypeAnlys11Opt?: string;
        VoucherTypeAnlys12Opt?: string;
        VoucherTypeAnlys13Opt?: string;
        VoucherTypeAnlys14Opt?: string;
        VoucherTypeAnlys15DrOpt?: string;
        VoucherTypeAnlys16DrOpt?: string;
        VoucherTypeAnlys17DrOpt?: string;
        VoucherTypeAnlys18DrOpt?: string;
        VoucherTypeAnlys19DrOpt?: string;
        VoucherTypeAnlys20DrOpt?: string;
        VoucherTypeAnlys15CrOpt?: string;
        VoucherTypeAnlys16CrOpt?: string;
        VoucherTypeAnlys17CrOpt?: string;
        VoucherTypeAnlys18CrOpt?: string;
        VoucherTypeAnlys19CrOpt?: string;
        VoucherTypeAnlys20CrOpt?: string;
    }

    export namespace VoucherPresetRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'VoucherType';
        export const localTextPrefix = 'Finance.VoucherPreset';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const VoucherType: string;
            export declare const SeqNo: string;
            export declare const AcctNo: string;
            export declare const Ccy: string;
            export declare const ExchRate: string;
            export declare const DebitAmt: string;
            export declare const CreditAmt: string;
            export declare const BaseLineNo: string;
            export declare const BaseEntry: string;
            export declare const ResultPercent: string;
            export declare const ResultSign: string;
            export declare const CostCentre: string;
            export declare const Dept: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const Anlys3: string;
            export declare const Anlys4: string;
            export declare const Anlys5: string;
            export declare const Anlys6: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const Particulars: string;
            export declare const VoucherTypeRecnum: string;
            export declare const VoucherTypeDescription: string;
            export declare const VoucherTypeSuspended: string;
            export declare const VoucherTypeDirectEntry: string;
            export declare const VoucherTypeAllowEdit: string;
            export declare const VoucherTypeMultiCurrency: string;
            export declare const VoucherTypeBatchedPosting: string;
            export declare const VoucherTypeCostCtrOpt: string;
            export declare const VoucherTypeDeptOpt: string;
            export declare const VoucherTypeAnlys1Opt: string;
            export declare const VoucherTypeAnlys2Opt: string;
            export declare const VoucherTypeAnlys3DrOpt: string;
            export declare const VoucherTypeAnlys4DrOpt: string;
            export declare const VoucherTypeAnlys5DrOpt: string;
            export declare const VoucherTypeAnlys6DrOpt: string;
            export declare const VoucherTypeAnlys3CrOpt: string;
            export declare const VoucherTypeAnlys4CrOpt: string;
            export declare const VoucherTypeAnlys5CrOpt: string;
            export declare const VoucherTypeAnlys6CrOpt: string;
            export declare const VoucherTypeSeriesCode: string;
            export declare const VoucherTypeCreatedDate: string;
            export declare const VoucherTypeCreatedBy: string;
            export declare const VoucherTypeRevisedDate: string;
            export declare const VoucherTypeRevisedBy: string;
            export declare const VoucherTypeBatchCount: string;
            export declare const VoucherTypeOwnerBranch: string;
            export declare const VoucherTypeSourceBranch: string;
            export declare const VoucherTypeRemarks: string;
            export declare const VoucherTypeAnlys7Opt: string;
            export declare const VoucherTypeAnlys8Opt: string;
            export declare const VoucherTypeAnlys9Opt: string;
            export declare const VoucherTypeAnlys10Opt: string;
            export declare const VoucherTypeAnlys11Opt: string;
            export declare const VoucherTypeAnlys12Opt: string;
            export declare const VoucherTypeAnlys13Opt: string;
            export declare const VoucherTypeAnlys14Opt: string;
            export declare const VoucherTypeAnlys15DrOpt: string;
            export declare const VoucherTypeAnlys16DrOpt: string;
            export declare const VoucherTypeAnlys17DrOpt: string;
            export declare const VoucherTypeAnlys18DrOpt: string;
            export declare const VoucherTypeAnlys19DrOpt: string;
            export declare const VoucherTypeAnlys20DrOpt: string;
            export declare const VoucherTypeAnlys15CrOpt: string;
            export declare const VoucherTypeAnlys16CrOpt: string;
            export declare const VoucherTypeAnlys17CrOpt: string;
            export declare const VoucherTypeAnlys18CrOpt: string;
            export declare const VoucherTypeAnlys19CrOpt: string;
            export declare const VoucherTypeAnlys20CrOpt: string;
        }

        [
            'Recnum', 
            'VoucherType', 
            'SeqNo', 
            'AcctNo', 
            'Ccy', 
            'ExchRate', 
            'DebitAmt', 
            'CreditAmt', 
            'BaseLineNo', 
            'BaseEntry', 
            'ResultPercent', 
            'ResultSign', 
            'CostCentre', 
            'Dept', 
            'Anlys1', 
            'Anlys2', 
            'Anlys3', 
            'Anlys4', 
            'Anlys5', 
            'Anlys6', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch', 
            'Particulars', 
            'VoucherTypeRecnum', 
            'VoucherTypeDescription', 
            'VoucherTypeSuspended', 
            'VoucherTypeDirectEntry', 
            'VoucherTypeAllowEdit', 
            'VoucherTypeMultiCurrency', 
            'VoucherTypeBatchedPosting', 
            'VoucherTypeCostCtrOpt', 
            'VoucherTypeDeptOpt', 
            'VoucherTypeAnlys1Opt', 
            'VoucherTypeAnlys2Opt', 
            'VoucherTypeAnlys3DrOpt', 
            'VoucherTypeAnlys4DrOpt', 
            'VoucherTypeAnlys5DrOpt', 
            'VoucherTypeAnlys6DrOpt', 
            'VoucherTypeAnlys3CrOpt', 
            'VoucherTypeAnlys4CrOpt', 
            'VoucherTypeAnlys5CrOpt', 
            'VoucherTypeAnlys6CrOpt', 
            'VoucherTypeSeriesCode', 
            'VoucherTypeCreatedDate', 
            'VoucherTypeCreatedBy', 
            'VoucherTypeRevisedDate', 
            'VoucherTypeRevisedBy', 
            'VoucherTypeBatchCount', 
            'VoucherTypeOwnerBranch', 
            'VoucherTypeSourceBranch', 
            'VoucherTypeRemarks', 
            'VoucherTypeAnlys7Opt', 
            'VoucherTypeAnlys8Opt', 
            'VoucherTypeAnlys9Opt', 
            'VoucherTypeAnlys10Opt', 
            'VoucherTypeAnlys11Opt', 
            'VoucherTypeAnlys12Opt', 
            'VoucherTypeAnlys13Opt', 
            'VoucherTypeAnlys14Opt', 
            'VoucherTypeAnlys15DrOpt', 
            'VoucherTypeAnlys16DrOpt', 
            'VoucherTypeAnlys17DrOpt', 
            'VoucherTypeAnlys18DrOpt', 
            'VoucherTypeAnlys19DrOpt', 
            'VoucherTypeAnlys20DrOpt', 
            'VoucherTypeAnlys15CrOpt', 
            'VoucherTypeAnlys16CrOpt', 
            'VoucherTypeAnlys17CrOpt', 
            'VoucherTypeAnlys18CrOpt', 
            'VoucherTypeAnlys19CrOpt', 
            'VoucherTypeAnlys20CrOpt'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

