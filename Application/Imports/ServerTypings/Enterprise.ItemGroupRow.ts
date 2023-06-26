namespace Matrix.Enterprise {
    export interface ItemGroupRow {
        ItemGroup?: string;
        Description?: string;
        Suspended?: boolean;
        Product?: boolean;
        Material?: boolean;
        Inspected?: boolean;
        ItemType?: string;
        AllocMethod?: string;
        MakeOrBuy?: boolean;
        ScrapRate?: number;
    }

    export namespace ItemGroupRow {
        export const idProperty = 'ItemGroup';
        export const nameProperty = 'Description';
        export const localTextPrefix = 'Enterprise.ItemGroup';
        export const lookupKey = 'Enterprise.ItemGroupLookup';

        export function getLookup(): Q.Lookup<ItemGroupRow> {
            return Q.getLookup<ItemGroupRow>('Enterprise.ItemGroupLookup');
        }

        export namespace Fields {
            export declare const ItemGroup: string;
            export declare const Description: string;
            export declare const Suspended: string;
            export declare const Product: string;
            export declare const Material: string;
            export declare const Inspected: string;
            export declare const ItemType: string;
            export declare const AllocMethod: string;
            export declare const MakeOrBuy: string;
            export declare const ScrapRate: string;
        }

        [
            'ItemGroup', 
            'Description', 
            'Suspended', 
            'Product', 
            'Material', 
            'Inspected', 
            'ItemType', 
            'AllocMethod', 
            'MakeOrBuy', 
            'ScrapRate'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

