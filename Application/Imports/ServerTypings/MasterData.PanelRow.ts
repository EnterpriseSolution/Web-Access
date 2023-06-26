namespace Matrix.MasterData {
    export interface PanelRow {
        Recnum?: number;
        PanelCode?: string;
        Description?: string;
        Length?: number;
        Width?: number;
        DimUom?: string;
        Suspended?: boolean;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        ItemGroup?: string;
    }

    export namespace PanelRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'PanelCode';
        export const localTextPrefix = 'MasterData.Panel';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const PanelCode: string;
            export declare const Description: string;
            export declare const Length: string;
            export declare const Width: string;
            export declare const DimUom: string;
            export declare const Suspended: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const ItemGroup: string;
        }

        [
            'Recnum', 
            'PanelCode', 
            'Description', 
            'Length', 
            'Width', 
            'DimUom', 
            'Suspended', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'ItemGroup'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

