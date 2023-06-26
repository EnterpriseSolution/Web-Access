namespace Matrix.Purchasing {
    export interface PurchaseReturnRow {
        Recnum?: number;
        RefNo?: string;
        EntryMethod?: string;
        Posted?: string;
        TranDate?: string;
        GrnNo?: string;
        VendorNo?: string;
        VendorName?: string;
        DoNo?: string;
        InvoiceNo?: string;
        HoldItems?: string;
        Loc?: string;
        Ccy?: string;
        ExchRate?: number;
        TotPriceAmt?: number;
        TotPtaxAmt?: number;
        TotExtPrice?: number;
        TotLdiscAmt?: number;
        TotAtaxAmt?: number;
        TotItemAmt?: number;
        TotRefundAmt?: number;
        TotVariaAmt?: number;
        TdiscPcent?: number;
        TotTdiscAmt?: number;
        NetTradeAmt?: number;
        TotChgsAmt?: number;
        NetOrdrAmt?: number;
        TotGtaxAmt?: number;
        NetPayAmt?: number;
        TotTdiscCpd?: number;
        LocPriceAmt?: number;
        LocPtaxAmt?: number;
        LocExtPrice?: number;
        LocLdiscAmt?: number;
        LocAtaxAmt?: number;
        LocItemAmt?: number;
        LocRefundAmt?: number;
        LocVariaAmt?: number;
        LocTdiscAmt?: number;
        LocChgsAmt?: number;
        LocGtaxAmt?: number;
        LocPayAmt?: number;
        AcctVendor?: string;
        AcctTdisc?: string;
        AcctGtax?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        PostedDate?: string;
        PostedBy?: string;
        LogNo?: number;
        LastLogNo?: number;
        OwnerBranch?: string;
        SourceBranch?: string;
        SettleAt?: string;
        Reason?: string;
        Anlys9?: string;
        Anlys10?: string;
        Anlys11?: string;
        Anlys12?: string;
        Anlys13?: string;
        Anlys14?: string;
        Anlys15?: string;
        Anlys16?: string;
        Anlys17?: string;
        Anlys18?: string;
    }

    export namespace PurchaseReturnRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'RefNo';
        export const localTextPrefix = 'Purchasing.PurchaseReturn';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const RefNo: string;
            export declare const EntryMethod: string;
            export declare const Posted: string;
            export declare const TranDate: string;
            export declare const GrnNo: string;
            export declare const VendorNo: string;
            export declare const VendorName: string;
            export declare const DoNo: string;
            export declare const InvoiceNo: string;
            export declare const HoldItems: string;
            export declare const Loc: string;
            export declare const Ccy: string;
            export declare const ExchRate: string;
            export declare const TotPriceAmt: string;
            export declare const TotPtaxAmt: string;
            export declare const TotExtPrice: string;
            export declare const TotLdiscAmt: string;
            export declare const TotAtaxAmt: string;
            export declare const TotItemAmt: string;
            export declare const TotRefundAmt: string;
            export declare const TotVariaAmt: string;
            export declare const TdiscPcent: string;
            export declare const TotTdiscAmt: string;
            export declare const NetTradeAmt: string;
            export declare const TotChgsAmt: string;
            export declare const NetOrdrAmt: string;
            export declare const TotGtaxAmt: string;
            export declare const NetPayAmt: string;
            export declare const TotTdiscCpd: string;
            export declare const LocPriceAmt: string;
            export declare const LocPtaxAmt: string;
            export declare const LocExtPrice: string;
            export declare const LocLdiscAmt: string;
            export declare const LocAtaxAmt: string;
            export declare const LocItemAmt: string;
            export declare const LocRefundAmt: string;
            export declare const LocVariaAmt: string;
            export declare const LocTdiscAmt: string;
            export declare const LocChgsAmt: string;
            export declare const LocGtaxAmt: string;
            export declare const LocPayAmt: string;
            export declare const AcctVendor: string;
            export declare const AcctTdisc: string;
            export declare const AcctGtax: string;
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
            export declare const Reason: string;
            export declare const Anlys9: string;
            export declare const Anlys10: string;
            export declare const Anlys11: string;
            export declare const Anlys12: string;
            export declare const Anlys13: string;
            export declare const Anlys14: string;
            export declare const Anlys15: string;
            export declare const Anlys16: string;
            export declare const Anlys17: string;
            export declare const Anlys18: string;
        }

        [
            'Recnum', 
            'RefNo', 
            'EntryMethod', 
            'Posted', 
            'TranDate', 
            'GrnNo', 
            'VendorNo', 
            'VendorName', 
            'DoNo', 
            'InvoiceNo', 
            'HoldItems', 
            'Loc', 
            'Ccy', 
            'ExchRate', 
            'TotPriceAmt', 
            'TotPtaxAmt', 
            'TotExtPrice', 
            'TotLdiscAmt', 
            'TotAtaxAmt', 
            'TotItemAmt', 
            'TotRefundAmt', 
            'TotVariaAmt', 
            'TdiscPcent', 
            'TotTdiscAmt', 
            'NetTradeAmt', 
            'TotChgsAmt', 
            'NetOrdrAmt', 
            'TotGtaxAmt', 
            'NetPayAmt', 
            'TotTdiscCpd', 
            'LocPriceAmt', 
            'LocPtaxAmt', 
            'LocExtPrice', 
            'LocLdiscAmt', 
            'LocAtaxAmt', 
            'LocItemAmt', 
            'LocRefundAmt', 
            'LocVariaAmt', 
            'LocTdiscAmt', 
            'LocChgsAmt', 
            'LocGtaxAmt', 
            'LocPayAmt', 
            'AcctVendor', 
            'AcctTdisc', 
            'AcctGtax', 
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
            'Reason', 
            'Anlys9', 
            'Anlys10', 
            'Anlys11', 
            'Anlys12', 
            'Anlys13', 
            'Anlys14', 
            'Anlys15', 
            'Anlys16', 
            'Anlys17', 
            'Anlys18'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

