namespace Matrix.EnterpriseSys {
    export interface ReportDialogOptionRow {
        ReportId?: string;
        OptionNo?: number;
        SeqNo?: number;
        Caption?: string;
        FieldName?: string;
        FieldType?: number;
        Style?: number;
        DataType?: number;
        CapsLock?: boolean;
        LookupName?: string;
        LookupFilterName?: string;
        Required?: boolean;
    }

    export namespace ReportDialogOptionRow {
        export const idProperty = 'OptionNo';
        export const nameProperty = 'Caption';
        export const localTextPrefix = 'EnterpriseSys.ReportDialogOption';

        export namespace Fields {
            export declare const ReportId: string;
            export declare const OptionNo: string;
            export declare const SeqNo: string;
            export declare const Caption: string;
            export declare const FieldName: string;
            export declare const FieldType: string;
            export declare const Style: string;
            export declare const DataType: string;
            export declare const CapsLock: string;
            export declare const LookupName: string;
            export declare const LookupFilterName: string;
            export declare const Required: string;
        }

        [
            'ReportId', 
            'OptionNo', 
            'SeqNo', 
            'Caption', 
            'FieldName', 
            'FieldType', 
            'Style', 
            'DataType', 
            'CapsLock', 
            'LookupName', 
            'LookupFilterName', 
            'Required'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

