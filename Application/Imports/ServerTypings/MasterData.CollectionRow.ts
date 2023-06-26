namespace Matrix.MasterData {
    export interface CollectionRow {
        Recnum?: number;
        CollectionCode?: string;
        Description?: string;
        ChineseDescription?: string;
        CreatedBy?: string;
        CreatedDate?: string;
        RevisedBy?: string;
        RevisedDate?: string;
        Remarks?: string;
    }

    export namespace CollectionRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'CollectionCode';
        export const localTextPrefix = 'MasterData.Collection';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const CollectionCode: string;
            export declare const Description: string;
            export declare const ChineseDescription: string;
            export declare const CreatedBy: string;
            export declare const CreatedDate: string;
            export declare const RevisedBy: string;
            export declare const RevisedDate: string;
            export declare const Remarks: string;
        }

        [
            'Recnum', 
            'CollectionCode', 
            'Description', 
            'ChineseDescription', 
            'CreatedBy', 
            'CreatedDate', 
            'RevisedBy', 
            'RevisedDate', 
            'Remarks'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

