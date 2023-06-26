namespace Matrix.MasterData {
    export interface StyleRow {
        Recnum?: number;
        CollectionCode?: string;
        StyleCode?: string;
        Description?: string;
        ChineseDescription?: string;
        DieCutter?: number;
        CreatedBy?: string;
        CreatedDate?: string;
        RevisedBy?: string;
        RevisedDate?: string;
    }

    export namespace StyleRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'CollectionCode';
        export const localTextPrefix = 'MasterData.Style';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const CollectionCode: string;
            export declare const StyleCode: string;
            export declare const Description: string;
            export declare const ChineseDescription: string;
            export declare const DieCutter: string;
            export declare const CreatedBy: string;
            export declare const CreatedDate: string;
            export declare const RevisedBy: string;
            export declare const RevisedDate: string;
        }

        [
            'Recnum', 
            'CollectionCode', 
            'StyleCode', 
            'Description', 
            'ChineseDescription', 
            'DieCutter', 
            'CreatedBy', 
            'CreatedDate', 
            'RevisedBy', 
            'RevisedDate'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

