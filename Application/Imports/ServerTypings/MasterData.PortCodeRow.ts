namespace Matrix.MasterData {
    export interface PortCodeRow {
        Recnum?: number;
        PortCode?: string;
        Description?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
    }

    export namespace PortCodeRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'PortCode';
        export const localTextPrefix = 'MasterData.PortCode';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const PortCode: string;
            export declare const Description: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
        }

        [
            'Recnum', 
            'PortCode', 
            'Description', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

