namespace Matrix.MasterData {
    export interface BuyerRow {
        Recnum?: number;
        BuyerCode?: string;
        BuyerName?: string;
        Suspended?: boolean;
        WithBacklog?: string;
        OnOrderCount?: number;
        LastLineNo?: number;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        Supervisor?: string;
    }

    export namespace BuyerRow {
        export const idProperty = 'BuyerCode';
        export const nameProperty = 'BuyerName';
        export const localTextPrefix = 'MasterData.Buyer';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const BuyerCode: string;
            export declare const BuyerName: string;
            export declare const Suspended: string;
            export declare const WithBacklog: string;
            export declare const OnOrderCount: string;
            export declare const LastLineNo: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const Supervisor: string;
        }

        [
            'Recnum', 
            'BuyerCode', 
            'BuyerName', 
            'Suspended', 
            'WithBacklog', 
            'OnOrderCount', 
            'LastLineNo', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch', 
            'Supervisor'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

