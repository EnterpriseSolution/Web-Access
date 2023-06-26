namespace Matrix.MasterData {
    export interface BuyerDetailRow {
        Recnum?: number;
        BuyerCode?: string;
        VendorNo?: string;
        VendorName?: string;
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

    export namespace BuyerDetailRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'BuyerCode';
        export const localTextPrefix = 'MasterData.BuyerDetail';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const BuyerCode: string;
            export declare const VendorNo: string;
            export declare const VendorName: string;
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
            'VendorNo', 
            'VendorName', 
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

