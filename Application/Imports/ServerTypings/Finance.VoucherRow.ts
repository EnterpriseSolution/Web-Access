namespace Matrix.Finance {
    export interface VoucherRow {
        DetailList?: VoucherDetailRow[];
        Recnum?: number;
        VoucherType?: string;
        VoucherNo?: string;
        Posted?: string;
        Hold?: string;
        VoucherDate?: string;
        Period?: string;
        FiscalYear?: number;
        PeriodNo?: number;
        Reference?: string;
        LastLineNo?: number;
        LineCount?: number;
        TotalDebit?: number;
        TotalCredit?: number;
        Balance?: number;
        BalanceSign?: string;
        JournalNo?: number;
        SourceType?: string;
        SourceRef?: string;
        Anlys1?: string;
        Anlys2?: string;
        BatchSelect?: string;
        LocalCcyOnly?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        PostedBy?: string;
        PostedDate?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        Particulars?: string;
        AiLink?: string;
        AiLinkType?: string;
        AiLinkNo?: string;
        Anlys7?: string;
        Anlys8?: string;
        ExportedDate?: string;
        Fserialno?: number;
        Fnum?: number;
        RoundNo?: number;
        NewVoucherNo?: string;
        Fgroup?: string;
        Anlys9?: string;
        Anlys10?: string;
        Anlys11?: string;
        Anlys12?: string;
        Anlys13?: string;
        Anlys14?: string;
        ManualEdited?: boolean;
        Remark?: string;
    }

    export namespace VoucherRow {
        export const idProperty = 'VoucherNo';
        export const nameProperty = 'VoucherType';
        export const localTextPrefix = 'Finance.Voucher';

        export namespace Fields {
            export declare const DetailList: string;
            export declare const Recnum: string;
            export declare const VoucherType: string;
            export declare const VoucherNo: string;
            export declare const Posted: string;
            export declare const Hold: string;
            export declare const VoucherDate: string;
            export declare const Period: string;
            export declare const FiscalYear: string;
            export declare const PeriodNo: string;
            export declare const Reference: string;
            export declare const LastLineNo: string;
            export declare const LineCount: string;
            export declare const TotalDebit: string;
            export declare const TotalCredit: string;
            export declare const Balance: string;
            export declare const BalanceSign: string;
            export declare const JournalNo: string;
            export declare const SourceType: string;
            export declare const SourceRef: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const BatchSelect: string;
            export declare const LocalCcyOnly: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const PostedBy: string;
            export declare const PostedDate: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const Particulars: string;
            export declare const AiLink: string;
            export declare const AiLinkType: string;
            export declare const AiLinkNo: string;
            export declare const Anlys7: string;
            export declare const Anlys8: string;
            export declare const ExportedDate: string;
            export declare const Fserialno: string;
            export declare const Fnum: string;
            export declare const RoundNo: string;
            export declare const NewVoucherNo: string;
            export declare const Fgroup: string;
            export declare const Anlys9: string;
            export declare const Anlys10: string;
            export declare const Anlys11: string;
            export declare const Anlys12: string;
            export declare const Anlys13: string;
            export declare const Anlys14: string;
            export declare const ManualEdited: string;
            export declare const Remark: string;
        }

        [
            'DetailList', 
            'Recnum', 
            'VoucherType', 
            'VoucherNo', 
            'Posted', 
            'Hold', 
            'VoucherDate', 
            'Period', 
            'FiscalYear', 
            'PeriodNo', 
            'Reference', 
            'LastLineNo', 
            'LineCount', 
            'TotalDebit', 
            'TotalCredit', 
            'Balance', 
            'BalanceSign', 
            'JournalNo', 
            'SourceType', 
            'SourceRef', 
            'Anlys1', 
            'Anlys2', 
            'BatchSelect', 
            'LocalCcyOnly', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'PostedBy', 
            'PostedDate', 
            'OwnerBranch', 
            'SourceBranch', 
            'Particulars', 
            'AiLink', 
            'AiLinkType', 
            'AiLinkNo', 
            'Anlys7', 
            'Anlys8', 
            'ExportedDate', 
            'Fserialno', 
            'Fnum', 
            'RoundNo', 
            'NewVoucherNo', 
            'Fgroup', 
            'Anlys9', 
            'Anlys10', 
            'Anlys11', 
            'Anlys12', 
            'Anlys13', 
            'Anlys14', 
            'ManualEdited', 
            'Remark'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

