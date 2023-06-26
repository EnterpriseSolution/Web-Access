namespace Matrix.MasterData {
    export interface SizeRow {
        Recnum?: number;
        Size?: string;
        Suspended?: boolean;
        Description?: string;
        CreatedBy?: string;
        CreatedDate?: string;
        RevisedBy?: string;
        RevisedDate?: string;
    }

    export namespace SizeRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'Size';
        export const localTextPrefix = 'MasterData.Size';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const Size: string;
            export declare const Suspended: string;
            export declare const Description: string;
            export declare const CreatedBy: string;
            export declare const CreatedDate: string;
            export declare const RevisedBy: string;
            export declare const RevisedDate: string;
        }

        [
            'Recnum', 
            'Size', 
            'Suspended', 
            'Description', 
            'CreatedBy', 
            'CreatedDate', 
            'RevisedBy', 
            'RevisedDate'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

