namespace Matrix.Finance {
    export interface VoucherCancellationRow {
        Recnum?: number;
        RefNo?: string;
        PostedDate?: string;
        PostedBy?: string;
        Posted?: boolean;
        VoucherType?: string;
        VoucherNo?: string;
        TranDate?: string;
        CreatedBy?: string;
        CreatedDate?: string;
        RevisedBy?: string;
        RevisedDate?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        Particulars?: string;
    }

    export namespace VoucherCancellationRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'RefNo';
        export const localTextPrefix = 'Finance.VoucherCancellation';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const RefNo: string;
            export declare const PostedDate: string;
            export declare const PostedBy: string;
            export declare const Posted: string;
            export declare const VoucherType: string;
            export declare const VoucherNo: string;
            export declare const TranDate: string;
            export declare const CreatedBy: string;
            export declare const CreatedDate: string;
            export declare const RevisedBy: string;
            export declare const RevisedDate: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const Particulars: string;
        }

        [
            'Recnum', 
            'RefNo', 
            'PostedDate', 
            'PostedBy', 
            'Posted', 
            'VoucherType', 
            'VoucherNo', 
            'TranDate', 
            'CreatedBy', 
            'CreatedDate', 
            'RevisedBy', 
            'RevisedDate', 
            'OwnerBranch', 
            'SourceBranch', 
            'Particulars'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

