namespace Matrix.MasterData {
    export interface BuyerControlRow {
        Recnum?: number;
        BuyerCode?: string;
        LineNo?: number;
        TypeGroup?: string;
        TypeItem?: string;
        EntryCode?: string;
        Description?: string;
        Suspended?: string;
        MaxQty?: number;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        BuyerCodeRecnum?: number;
        BuyerCodeBuyerName?: string;
        BuyerCodeSuspended?: string;
        BuyerCodeWithBacklog?: string;
        BuyerCodeOnOrderCount?: number;
        BuyerCodeLastLineNo?: number;
        BuyerCodeCreatedDate?: string;
        BuyerCodeCreatedBy?: string;
        BuyerCodeRevisedDate?: string;
        BuyerCodeRevisedBy?: string;
        BuyerCodeOwnerBranch?: string;
        BuyerCodeSourceBranch?: string;
        BuyerCodeSupervisor?: string;
    }

    export namespace BuyerControlRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'BuyerCode';
        export const localTextPrefix = 'MasterData.BuyerControl';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const BuyerCode: string;
            export declare const LineNo: string;
            export declare const TypeGroup: string;
            export declare const TypeItem: string;
            export declare const EntryCode: string;
            export declare const Description: string;
            export declare const Suspended: string;
            export declare const MaxQty: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const BuyerCodeRecnum: string;
            export declare const BuyerCodeBuyerName: string;
            export declare const BuyerCodeSuspended: string;
            export declare const BuyerCodeWithBacklog: string;
            export declare const BuyerCodeOnOrderCount: string;
            export declare const BuyerCodeLastLineNo: string;
            export declare const BuyerCodeCreatedDate: string;
            export declare const BuyerCodeCreatedBy: string;
            export declare const BuyerCodeRevisedDate: string;
            export declare const BuyerCodeRevisedBy: string;
            export declare const BuyerCodeOwnerBranch: string;
            export declare const BuyerCodeSourceBranch: string;
            export declare const BuyerCodeSupervisor: string;
        }

        [
            'Recnum', 
            'BuyerCode', 
            'LineNo', 
            'TypeGroup', 
            'TypeItem', 
            'EntryCode', 
            'Description', 
            'Suspended', 
            'MaxQty', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch', 
            'BuyerCodeRecnum', 
            'BuyerCodeBuyerName', 
            'BuyerCodeSuspended', 
            'BuyerCodeWithBacklog', 
            'BuyerCodeOnOrderCount', 
            'BuyerCodeLastLineNo', 
            'BuyerCodeCreatedDate', 
            'BuyerCodeCreatedBy', 
            'BuyerCodeRevisedDate', 
            'BuyerCodeRevisedBy', 
            'BuyerCodeOwnerBranch', 
            'BuyerCodeSourceBranch', 
            'BuyerCodeSupervisor'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

