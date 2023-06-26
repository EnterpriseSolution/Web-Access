namespace Matrix.Purchasing {
    export interface PurchaseInspectionRow {
        Recnum?: number;
        RefNo?: string;
        InspectionDate?: string;
        EntryMethod?: string;
        Posted?: string;
        InspectedBy?: string;
        Loc?: string;
        GrnNo?: string;
        VendorNo?: string;
        VendorName?: string;
        ReceivedDate?: string;
        Ccy?: string;
        ExchRate?: number;
        FullInspection?: string;
        PendingCount?: number;
        WithRejects?: string;
        HoldItems?: string;
        ReOrderNo?: string;
        ReOrderDate?: string;
        ReDueDate?: string;
        ReSchedDate?: string;
        ReShipTo?: string;
        ReShipVia?: string;
        ReShipTerms?: string;
        ReCount?: number;
        TotPriceAmt?: number;
        TotPtaxAmt?: number;
        TotExtPrice?: number;
        TotLdiscAmt?: number;
        TotAtaxAmt?: number;
        TotItemAmt?: number;
        TdiscPcent?: number;
        TotTdiscAmt?: number;
        NetTradeAmt?: number;
        LocPriceAmt?: number;
        LocPtaxAmt?: number;
        LocExtPrice?: number;
        LocLdiscAmt?: number;
        LocAtaxAmt?: number;
        LocItemAmt?: number;
        LocTdiscAmt?: number;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        PostedDate?: string;
        PostedBy?: string;
        LogNo?: number;
        LastLogNo?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        SettleAt?: string;
        Anlys1?: string;
        Anlys2?: string;
        Anlys7?: string;
        Anlys8?: string;
        DoNo?: string;
        Anlys9?: string;
        Anlys10?: string;
        Anlys11?: string;
        Anlys12?: string;
        Anlys13?: string;
        Anlys14?: string;
        DetailList?: PurchaseInspectionDetailRow[];
    }

    export namespace PurchaseInspectionRow {
        export const idProperty = 'RefNo';
        export const nameProperty = 'RefNo';
        export const localTextPrefix = 'Purchasing.PurchaseInspection';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const RefNo: string;
            export declare const InspectionDate: string;
            export declare const EntryMethod: string;
            export declare const Posted: string;
            export declare const InspectedBy: string;
            export declare const Loc: string;
            export declare const GrnNo: string;
            export declare const VendorNo: string;
            export declare const VendorName: string;
            export declare const ReceivedDate: string;
            export declare const Ccy: string;
            export declare const ExchRate: string;
            export declare const FullInspection: string;
            export declare const PendingCount: string;
            export declare const WithRejects: string;
            export declare const HoldItems: string;
            export declare const ReOrderNo: string;
            export declare const ReOrderDate: string;
            export declare const ReDueDate: string;
            export declare const ReSchedDate: string;
            export declare const ReShipTo: string;
            export declare const ReShipVia: string;
            export declare const ReShipTerms: string;
            export declare const ReCount: string;
            export declare const TotPriceAmt: string;
            export declare const TotPtaxAmt: string;
            export declare const TotExtPrice: string;
            export declare const TotLdiscAmt: string;
            export declare const TotAtaxAmt: string;
            export declare const TotItemAmt: string;
            export declare const TdiscPcent: string;
            export declare const TotTdiscAmt: string;
            export declare const NetTradeAmt: string;
            export declare const LocPriceAmt: string;
            export declare const LocPtaxAmt: string;
            export declare const LocExtPrice: string;
            export declare const LocLdiscAmt: string;
            export declare const LocAtaxAmt: string;
            export declare const LocItemAmt: string;
            export declare const LocTdiscAmt: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const PostedDate: string;
            export declare const PostedBy: string;
            export declare const LogNo: string;
            export declare const LastLogNo: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const SettleAt: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const Anlys7: string;
            export declare const Anlys8: string;
            export declare const DoNo: string;
            export declare const Anlys9: string;
            export declare const Anlys10: string;
            export declare const Anlys11: string;
            export declare const Anlys12: string;
            export declare const Anlys13: string;
            export declare const Anlys14: string;
            export declare const DetailList: string;
        }

        [
            'Recnum', 
            'RefNo', 
            'InspectionDate', 
            'EntryMethod', 
            'Posted', 
            'InspectedBy', 
            'Loc', 
            'GrnNo', 
            'VendorNo', 
            'VendorName', 
            'ReceivedDate', 
            'Ccy', 
            'ExchRate', 
            'FullInspection', 
            'PendingCount', 
            'WithRejects', 
            'HoldItems', 
            'ReOrderNo', 
            'ReOrderDate', 
            'ReDueDate', 
            'ReSchedDate', 
            'ReShipTo', 
            'ReShipVia', 
            'ReShipTerms', 
            'ReCount', 
            'TotPriceAmt', 
            'TotPtaxAmt', 
            'TotExtPrice', 
            'TotLdiscAmt', 
            'TotAtaxAmt', 
            'TotItemAmt', 
            'TdiscPcent', 
            'TotTdiscAmt', 
            'NetTradeAmt', 
            'LocPriceAmt', 
            'LocPtaxAmt', 
            'LocExtPrice', 
            'LocLdiscAmt', 
            'LocAtaxAmt', 
            'LocItemAmt', 
            'LocTdiscAmt', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'PostedDate', 
            'PostedBy', 
            'LogNo', 
            'LastLogNo', 
            'OwnerBranch', 
            'SourceBranch', 
            'SettleAt', 
            'Anlys1', 
            'Anlys2', 
            'Anlys7', 
            'Anlys8', 
            'DoNo', 
            'Anlys9', 
            'Anlys10', 
            'Anlys11', 
            'Anlys12', 
            'Anlys13', 
            'Anlys14', 
            'DetailList'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

