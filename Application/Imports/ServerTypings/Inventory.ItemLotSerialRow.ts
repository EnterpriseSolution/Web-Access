namespace Matrix.Inventory {
    export interface ItemLotSerialRow {
        Recnum?: number;
        ItemNo?: string;
        SerialNo?: string;
        Loc?: string;
        BinNo?: string;
        LotNo?: string;
        Closed?: string;
        ExpiryDate?: string;
        SourceType?: string;
        SourceRef?: string;
        SourceEntryNo?: number;
    }

    export namespace ItemLotSerialRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'ItemNo';
        export const localTextPrefix = 'Inventory.ItemLotSerial';
        export const lookupKey = 'Inventory.ItemLotSerialItemLookup';

        export function getLookup(): Q.Lookup<ItemLotSerialRow> {
            return Q.getLookup<ItemLotSerialRow>('Inventory.ItemLotSerialItemLookup');
        }

        export namespace Fields {
            export declare const Recnum: string;
            export declare const ItemNo: string;
            export declare const SerialNo: string;
            export declare const Loc: string;
            export declare const BinNo: string;
            export declare const LotNo: string;
            export declare const Closed: string;
            export declare const ExpiryDate: string;
            export declare const SourceType: string;
            export declare const SourceRef: string;
            export declare const SourceEntryNo: string;
        }

        [
            'Recnum', 
            'ItemNo', 
            'SerialNo', 
            'Loc', 
            'BinNo', 
            'LotNo', 
            'Closed', 
            'ExpiryDate', 
            'SourceType', 
            'SourceRef', 
            'SourceEntryNo'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

