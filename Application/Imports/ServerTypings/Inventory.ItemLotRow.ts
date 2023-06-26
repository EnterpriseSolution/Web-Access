namespace Matrix.Inventory {
    export interface ItemLotRow {
        Recnum?: number;
        ItemNo?: string;
        Description?: string;
        Loc?: string;
        BinNo?: string;
        LotNo?: string;
        Closed?: string;
        LocSummary?: string;
        QtyShipped?: number;
        QtyReceived?: number;
        QtyIssued?: number;
        QtyFinished?: number;
        QtyBalance?: number;
        ExpiryDate?: string;
        Uom?: string;
        Remarks?: string;
        UnitCost?: number;
        UserDefinedField01?: string;
        UserDefinedField02?: string;
        UserDefinedField03?: string;
        UserDefinedField04?: string;
        UserDefinedField05?: string;
        FifoLogNo?: number;
        FifoLineNo?: number;
    }

    export namespace ItemLotRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'ItemNo';
        export const localTextPrefix = 'Inventory.ItemLot';
        export const lookupKey = 'Inventory.ItemLotItemLookup';

        export function getLookup(): Q.Lookup<ItemLotRow> {
            return Q.getLookup<ItemLotRow>('Inventory.ItemLotItemLookup');
        }

        export namespace Fields {
            export declare const Recnum: string;
            export declare const ItemNo: string;
            export declare const Description: string;
            export declare const Loc: string;
            export declare const BinNo: string;
            export declare const LotNo: string;
            export declare const Closed: string;
            export declare const LocSummary: string;
            export declare const QtyShipped: string;
            export declare const QtyReceived: string;
            export declare const QtyIssued: string;
            export declare const QtyFinished: string;
            export declare const QtyBalance: string;
            export declare const ExpiryDate: string;
            export declare const Uom: string;
            export declare const Remarks: string;
            export declare const UnitCost: string;
            export declare const UserDefinedField01: string;
            export declare const UserDefinedField02: string;
            export declare const UserDefinedField03: string;
            export declare const UserDefinedField04: string;
            export declare const UserDefinedField05: string;
            export declare const FifoLogNo: string;
            export declare const FifoLineNo: string;
        }

        [
            'Recnum', 
            'ItemNo', 
            'Description', 
            'Loc', 
            'BinNo', 
            'LotNo', 
            'Closed', 
            'LocSummary', 
            'QtyShipped', 
            'QtyReceived', 
            'QtyIssued', 
            'QtyFinished', 
            'QtyBalance', 
            'ExpiryDate', 
            'Uom', 
            'Remarks', 
            'UnitCost', 
            'UserDefinedField01', 
            'UserDefinedField02', 
            'UserDefinedField03', 
            'UserDefinedField04', 
            'UserDefinedField05', 
            'FifoLogNo', 
            'FifoLineNo'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

