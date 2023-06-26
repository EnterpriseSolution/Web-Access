namespace Matrix.MasterData {
    export interface ShipViaCodeRow {
        Recnum?: number;
        ShipViaCode?: string;
        Description?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
    }

    export namespace ShipViaCodeRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'ShipViaCode';
        export const localTextPrefix = 'MasterData.ShipViaCode';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const ShipViaCode: string;
            export declare const Description: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
        }

        [
            'Recnum', 
            'ShipViaCode', 
            'Description', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

