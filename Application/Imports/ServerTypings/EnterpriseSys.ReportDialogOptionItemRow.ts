namespace Matrix.EnterpriseSys {
    export interface ReportDialogOptionItemRow {
        ReportId?: string;
        OptionNo?: number;
        EntryNo?: number;
        Caption?: string;
        Value?: string;
    }

    export namespace ReportDialogOptionItemRow {
        export const idProperty = 'ReportId';
        export const nameProperty = 'ReportId';
        export const localTextPrefix = 'EnterpriseSys.ReportDialogOptionItem';

        export namespace Fields {
            export declare const ReportId: string;
            export declare const OptionNo: string;
            export declare const EntryNo: string;
            export declare const Caption: string;
            export declare const Value: string;
        }

        [
            'ReportId', 
            'OptionNo', 
            'EntryNo', 
            'Caption', 
            'Value'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

