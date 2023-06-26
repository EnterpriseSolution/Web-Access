namespace Matrix.Purchasing {
    export interface PurchaseReturnChargeRow {
        Recnum?: number;
        RefNo?: string;
        EntryNo?: number;
        OrderNo?: string;
        SeqNo?: number;
        ChargeType?: string;
        Particulars?: string;
        BalAmt?: number;
        ReturnAmt?: number;
        LocReturnAmt?: number;
        AcctPurchase?: string;
        Deduction?: string;
        Anlys1?: string;
        Anlys2?: string;
        Anlys7?: string;
        Anlys8?: string;
        Anlys9?: string;
        Anlys10?: string;
        Anlys11?: string;
        Anlys12?: string;
        Anlys13?: string;
        Anlys14?: string;
        RefNoRecnum?: number;
        RefNoEntryMethod?: string;
        RefNoPosted?: string;
        RefNoTranDate?: string;
        RefNoGrnNo?: string;
        RefNoVendorNo?: string;
        RefNoVendorName?: string;
        RefNoDoNo?: string;
        RefNoInvoiceNo?: string;
        RefNoHoldItems?: string;
        RefNoLoc?: string;
        RefNoCcy?: string;
        RefNoExchRate?: number;
        RefNoTotPriceAmt?: number;
        RefNoTotPtaxAmt?: number;
        RefNoTotExtPrice?: number;
        RefNoTotLdiscAmt?: number;
        RefNoTotAtaxAmt?: number;
        RefNoTotItemAmt?: number;
        RefNoTotRefundAmt?: number;
        RefNoTotVariaAmt?: number;
        RefNoTdiscPcent?: number;
        RefNoTotTdiscAmt?: number;
        RefNoNetTradeAmt?: number;
        RefNoTotChgsAmt?: number;
        RefNoNetOrdrAmt?: number;
        RefNoTotGtaxAmt?: number;
        RefNoNetPayAmt?: number;
        RefNoTotTdiscCpd?: number;
        RefNoLocPriceAmt?: number;
        RefNoLocPtaxAmt?: number;
        RefNoLocExtPrice?: number;
        RefNoLocLdiscAmt?: number;
        RefNoLocAtaxAmt?: number;
        RefNoLocItemAmt?: number;
        RefNoLocRefundAmt?: number;
        RefNoLocVariaAmt?: number;
        RefNoLocTdiscAmt?: number;
        RefNoLocChgsAmt?: number;
        RefNoLocGtaxAmt?: number;
        RefNoLocPayAmt?: number;
        RefNoAcctVendor?: string;
        RefNoAcctTdisc?: string;
        RefNoAcctGtax?: string;
        RefNoCreatedDate?: string;
        RefNoCreatedBy?: string;
        RefNoRevisedDate?: string;
        RefNoRevisedBy?: string;
        RefNoPostedDate?: string;
        RefNoPostedBy?: string;
        RefNoLogNo?: number;
        RefNoLastLogNo?: number;
        RefNoOwnerBranch?: string;
        RefNoSourceBranch?: string;
        RefNoSettleAt?: string;
        RefNoReason?: string;
        RefNoAnlys9?: string;
        RefNoAnlys10?: string;
        RefNoAnlys11?: string;
        RefNoAnlys12?: string;
        RefNoAnlys13?: string;
        RefNoAnlys14?: string;
        RefNoAnlys15?: string;
        RefNoAnlys16?: string;
        RefNoAnlys17?: string;
        RefNoAnlys18?: string;
    }

    export namespace PurchaseReturnChargeRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'RefNo';
        export const localTextPrefix = 'Purchasing.PurchaseReturnCharge';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const RefNo: string;
            export declare const EntryNo: string;
            export declare const OrderNo: string;
            export declare const SeqNo: string;
            export declare const ChargeType: string;
            export declare const Particulars: string;
            export declare const BalAmt: string;
            export declare const ReturnAmt: string;
            export declare const LocReturnAmt: string;
            export declare const AcctPurchase: string;
            export declare const Deduction: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const Anlys7: string;
            export declare const Anlys8: string;
            export declare const Anlys9: string;
            export declare const Anlys10: string;
            export declare const Anlys11: string;
            export declare const Anlys12: string;
            export declare const Anlys13: string;
            export declare const Anlys14: string;
            export declare const RefNoRecnum: string;
            export declare const RefNoEntryMethod: string;
            export declare const RefNoPosted: string;
            export declare const RefNoTranDate: string;
            export declare const RefNoGrnNo: string;
            export declare const RefNoVendorNo: string;
            export declare const RefNoVendorName: string;
            export declare const RefNoDoNo: string;
            export declare const RefNoInvoiceNo: string;
            export declare const RefNoHoldItems: string;
            export declare const RefNoLoc: string;
            export declare const RefNoCcy: string;
            export declare const RefNoExchRate: string;
            export declare const RefNoTotPriceAmt: string;
            export declare const RefNoTotPtaxAmt: string;
            export declare const RefNoTotExtPrice: string;
            export declare const RefNoTotLdiscAmt: string;
            export declare const RefNoTotAtaxAmt: string;
            export declare const RefNoTotItemAmt: string;
            export declare const RefNoTotRefundAmt: string;
            export declare const RefNoTotVariaAmt: string;
            export declare const RefNoTdiscPcent: string;
            export declare const RefNoTotTdiscAmt: string;
            export declare const RefNoNetTradeAmt: string;
            export declare const RefNoTotChgsAmt: string;
            export declare const RefNoNetOrdrAmt: string;
            export declare const RefNoTotGtaxAmt: string;
            export declare const RefNoNetPayAmt: string;
            export declare const RefNoTotTdiscCpd: string;
            export declare const RefNoLocPriceAmt: string;
            export declare const RefNoLocPtaxAmt: string;
            export declare const RefNoLocExtPrice: string;
            export declare const RefNoLocLdiscAmt: string;
            export declare const RefNoLocAtaxAmt: string;
            export declare const RefNoLocItemAmt: string;
            export declare const RefNoLocRefundAmt: string;
            export declare const RefNoLocVariaAmt: string;
            export declare const RefNoLocTdiscAmt: string;
            export declare const RefNoLocChgsAmt: string;
            export declare const RefNoLocGtaxAmt: string;
            export declare const RefNoLocPayAmt: string;
            export declare const RefNoAcctVendor: string;
            export declare const RefNoAcctTdisc: string;
            export declare const RefNoAcctGtax: string;
            export declare const RefNoCreatedDate: string;
            export declare const RefNoCreatedBy: string;
            export declare const RefNoRevisedDate: string;
            export declare const RefNoRevisedBy: string;
            export declare const RefNoPostedDate: string;
            export declare const RefNoPostedBy: string;
            export declare const RefNoLogNo: string;
            export declare const RefNoLastLogNo: string;
            export declare const RefNoOwnerBranch: string;
            export declare const RefNoSourceBranch: string;
            export declare const RefNoSettleAt: string;
            export declare const RefNoReason: string;
            export declare const RefNoAnlys9: string;
            export declare const RefNoAnlys10: string;
            export declare const RefNoAnlys11: string;
            export declare const RefNoAnlys12: string;
            export declare const RefNoAnlys13: string;
            export declare const RefNoAnlys14: string;
            export declare const RefNoAnlys15: string;
            export declare const RefNoAnlys16: string;
            export declare const RefNoAnlys17: string;
            export declare const RefNoAnlys18: string;
        }

        [
            'Recnum', 
            'RefNo', 
            'EntryNo', 
            'OrderNo', 
            'SeqNo', 
            'ChargeType', 
            'Particulars', 
            'BalAmt', 
            'ReturnAmt', 
            'LocReturnAmt', 
            'AcctPurchase', 
            'Deduction', 
            'Anlys1', 
            'Anlys2', 
            'Anlys7', 
            'Anlys8', 
            'Anlys9', 
            'Anlys10', 
            'Anlys11', 
            'Anlys12', 
            'Anlys13', 
            'Anlys14', 
            'RefNoRecnum', 
            'RefNoEntryMethod', 
            'RefNoPosted', 
            'RefNoTranDate', 
            'RefNoGrnNo', 
            'RefNoVendorNo', 
            'RefNoVendorName', 
            'RefNoDoNo', 
            'RefNoInvoiceNo', 
            'RefNoHoldItems', 
            'RefNoLoc', 
            'RefNoCcy', 
            'RefNoExchRate', 
            'RefNoTotPriceAmt', 
            'RefNoTotPtaxAmt', 
            'RefNoTotExtPrice', 
            'RefNoTotLdiscAmt', 
            'RefNoTotAtaxAmt', 
            'RefNoTotItemAmt', 
            'RefNoTotRefundAmt', 
            'RefNoTotVariaAmt', 
            'RefNoTdiscPcent', 
            'RefNoTotTdiscAmt', 
            'RefNoNetTradeAmt', 
            'RefNoTotChgsAmt', 
            'RefNoNetOrdrAmt', 
            'RefNoTotGtaxAmt', 
            'RefNoNetPayAmt', 
            'RefNoTotTdiscCpd', 
            'RefNoLocPriceAmt', 
            'RefNoLocPtaxAmt', 
            'RefNoLocExtPrice', 
            'RefNoLocLdiscAmt', 
            'RefNoLocAtaxAmt', 
            'RefNoLocItemAmt', 
            'RefNoLocRefundAmt', 
            'RefNoLocVariaAmt', 
            'RefNoLocTdiscAmt', 
            'RefNoLocChgsAmt', 
            'RefNoLocGtaxAmt', 
            'RefNoLocPayAmt', 
            'RefNoAcctVendor', 
            'RefNoAcctTdisc', 
            'RefNoAcctGtax', 
            'RefNoCreatedDate', 
            'RefNoCreatedBy', 
            'RefNoRevisedDate', 
            'RefNoRevisedBy', 
            'RefNoPostedDate', 
            'RefNoPostedBy', 
            'RefNoLogNo', 
            'RefNoLastLogNo', 
            'RefNoOwnerBranch', 
            'RefNoSourceBranch', 
            'RefNoSettleAt', 
            'RefNoReason', 
            'RefNoAnlys9', 
            'RefNoAnlys10', 
            'RefNoAnlys11', 
            'RefNoAnlys12', 
            'RefNoAnlys13', 
            'RefNoAnlys14', 
            'RefNoAnlys15', 
            'RefNoAnlys16', 
            'RefNoAnlys17', 
            'RefNoAnlys18'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

