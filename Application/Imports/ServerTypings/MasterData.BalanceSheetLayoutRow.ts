namespace Matrix.MasterData {
    export interface BalanceSheetLayoutRow {
        Recnum?: number;
        LineNo?: number;
        LineType?: string;
        LineSkip?: number;
        Description?: string;
        AcctFrom?: string;
        AcctTo?: string;
        AcctOperator?: string;
        TotalLevel?: number;
        NormalSign?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        Report?: string;
        CellLineNo?: number;
        CellValueBegin?: string;
        CellValueEnd?: string;
    }

    export namespace BalanceSheetLayoutRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'LineType';
        export const localTextPrefix = 'MasterData.BalanceSheetLayout';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const LineNo: string;
            export declare const LineType: string;
            export declare const LineSkip: string;
            export declare const Description: string;
            export declare const AcctFrom: string;
            export declare const AcctTo: string;
            export declare const AcctOperator: string;
            export declare const TotalLevel: string;
            export declare const NormalSign: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const Report: string;
            export declare const CellLineNo: string;
            export declare const CellValueBegin: string;
            export declare const CellValueEnd: string;
        }

        [
            'Recnum', 
            'LineNo', 
            'LineType', 
            'LineSkip', 
            'Description', 
            'AcctFrom', 
            'AcctTo', 
            'AcctOperator', 
            'TotalLevel', 
            'NormalSign', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch', 
            'Report', 
            'CellLineNo', 
            'CellValueBegin', 
            'CellValueEnd'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

