namespace Matrix.MasterData {
    export interface ColorRow {
        Recnum?: number;
        ColorCode?: string;
        Description?: string;
        ChineseDescription?: string;
        CreatedBy?: string;
        CreatedDate?: string;
        RevisedBy?: string;
        RevisedDate?: string;
        ColorGroup?: string;
        ItemGroup?: string;
    }

    export namespace ColorRow {
        export const idProperty = 'ColorCode';
        export const nameProperty = 'Description';
        export const localTextPrefix = 'MasterData.Color';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const ColorCode: string;
            export declare const Description: string;
            export declare const ChineseDescription: string;
            export declare const CreatedBy: string;
            export declare const CreatedDate: string;
            export declare const RevisedBy: string;
            export declare const RevisedDate: string;
            export declare const ColorGroup: string;
            export declare const ItemGroup: string;
        }

        [
            'Recnum', 
            'ColorCode', 
            'Description', 
            'ChineseDescription', 
            'CreatedBy', 
            'CreatedDate', 
            'RevisedBy', 
            'RevisedDate', 
            'ColorGroup', 
            'ItemGroup'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

