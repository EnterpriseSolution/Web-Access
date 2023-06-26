namespace Matrix.MasterData {
    export interface ReasonCodeRow {
        Recnum?: number;
        ReasonCode?: string;
        Description?: string;
        Suspended?: boolean;
        CreatedBy?: string;
        CreatedDate?: string;
        RevisedBy?: string;
        RevisedDate?: string;
        Remarks?: string;
    }

    export namespace ReasonCodeRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'ReasonCode';
        export const localTextPrefix = 'MasterData.ReasonCode';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const ReasonCode: string;
            export declare const Description: string;
            export declare const Suspended: string;
            export declare const CreatedBy: string;
            export declare const CreatedDate: string;
            export declare const RevisedBy: string;
            export declare const RevisedDate: string;
            export declare const Remarks: string;
        }

        [
            'Recnum', 
            'ReasonCode', 
            'Description', 
            'Suspended', 
            'CreatedBy', 
            'CreatedDate', 
            'RevisedBy', 
            'RevisedDate', 
            'Remarks'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

