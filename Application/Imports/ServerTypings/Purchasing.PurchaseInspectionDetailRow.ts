namespace Matrix.Purchasing {
    export interface PurchaseInspectionDetailRow {
        Recnum?: number;
        RefNo?: string;
        EntryNo?: number;
        OrderNo?: string;
        LineNo?: number;
        ItemNo?: string;
        Description?: string;
        Uom?: string;
        LotSize?: number;
        QtyReceived?: number;
        QtyPending?: number;
        QtyInspected?: number;
        QtyRejected?: number;
        Reorder?: string;
        Price?: number;
        Ptax?: number;
        NetPrice?: number;
        ExtPrice?: number;
        LdiscPcent?: number;
        LdiscAmt?: number;
        AtaxAmt?: number;
        NetItemAmt?: number;
        PriceAmt?: number;
        PtaxAmt?: number;
        LocPriceAmt?: number;
        LocPtaxAmt?: number;
        LocExtPrice?: number;
        LocLdiscAmt?: number;
        LocAtaxAmt?: number;
        LocItemAmt?: number;
        GrnNo?: string;
        Loc?: string;
        InspectionDate?: string;
        Posted?: string;
        LogNo?: number;
        VendorNo?: string;
        AcctPurchase?: string;
        AcctLdisc?: string;
        AcctGtax?: string;
        CostAccepted?: number;
        CostRejected?: number;
        Remarks?: string;
        ExtDescription?: string;
        AdjustRcvd?: string;
        Anlys3?: string;
        Anlys4?: string;
        Anlys5?: string;
        Anlys6?: string;
        Anlys15?: string;
        Anlys16?: string;
        Anlys17?: string;
        Anlys18?: string;
        Anlys19?: string;
        Anlys20?: string;
        RefNoRecnum?: number;
        RefNoInspectionDate?: string;
        RefNoEntryMethod?: string;
        RefNoPosted?: string;
        RefNoInspectedBy?: string;
        RefNoLoc?: string;
        RefNoGrnNo?: string;
        RefNoVendorNo?: string;
        RefNoVendorName?: string;
        RefNoReceivedDate?: string;
        RefNoCcy?: string;
        RefNoExchRate?: number;
        RefNoFullInspection?: string;
        RefNoPendingCount?: number;
        RefNoWithRejects?: string;
        RefNoHoldItems?: string;
        RefNoReOrderNo?: string;
        RefNoReOrderDate?: string;
        RefNoReDueDate?: string;
        RefNoReSchedDate?: string;
        RefNoReShipTo?: string;
        RefNoReShipVia?: string;
        RefNoReShipTerms?: string;
        RefNoReCount?: number;
        RefNoTotPriceAmt?: number;
        RefNoTotPtaxAmt?: number;
        RefNoTotExtPrice?: number;
        RefNoTotLdiscAmt?: number;
        RefNoTotAtaxAmt?: number;
        RefNoTotItemAmt?: number;
        RefNoTdiscPcent?: number;
        RefNoTotTdiscAmt?: number;
        RefNoNetTradeAmt?: number;
        RefNoLocPriceAmt?: number;
        RefNoLocPtaxAmt?: number;
        RefNoLocExtPrice?: number;
        RefNoLocLdiscAmt?: number;
        RefNoLocAtaxAmt?: number;
        RefNoLocItemAmt?: number;
        RefNoLocTdiscAmt?: number;
        RefNoCreatedDate?: string;
        RefNoCreatedBy?: string;
        RefNoRevisedDate?: string;
        RefNoRevisedBy?: string;
        RefNoPostedDate?: string;
        RefNoPostedBy?: string;
        RefNoLogNo?: number;
        RefNoLastLogNo?: string;
        RefNoOwnerBranch?: string;
        RefNoSourceBranch?: string;
        RefNoSettleAt?: string;
        RefNoAnlys1?: string;
        RefNoAnlys2?: string;
        RefNoAnlys7?: string;
        RefNoAnlys8?: string;
        RefNoDoNo?: string;
        RefNoAnlys9?: string;
        RefNoAnlys10?: string;
        RefNoAnlys11?: string;
        RefNoAnlys12?: string;
        RefNoAnlys13?: string;
        RefNoAnlys14?: string;
    }

    export namespace PurchaseInspectionDetailRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'RefNo';
        export const localTextPrefix = 'Purchasing.PurchaseInspectionDetail';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const RefNo: string;
            export declare const EntryNo: string;
            export declare const OrderNo: string;
            export declare const LineNo: string;
            export declare const ItemNo: string;
            export declare const Description: string;
            export declare const Uom: string;
            export declare const LotSize: string;
            export declare const QtyReceived: string;
            export declare const QtyPending: string;
            export declare const QtyInspected: string;
            export declare const QtyRejected: string;
            export declare const Reorder: string;
            export declare const Price: string;
            export declare const Ptax: string;
            export declare const NetPrice: string;
            export declare const ExtPrice: string;
            export declare const LdiscPcent: string;
            export declare const LdiscAmt: string;
            export declare const AtaxAmt: string;
            export declare const NetItemAmt: string;
            export declare const PriceAmt: string;
            export declare const PtaxAmt: string;
            export declare const LocPriceAmt: string;
            export declare const LocPtaxAmt: string;
            export declare const LocExtPrice: string;
            export declare const LocLdiscAmt: string;
            export declare const LocAtaxAmt: string;
            export declare const LocItemAmt: string;
            export declare const GrnNo: string;
            export declare const Loc: string;
            export declare const InspectionDate: string;
            export declare const Posted: string;
            export declare const LogNo: string;
            export declare const VendorNo: string;
            export declare const AcctPurchase: string;
            export declare const AcctLdisc: string;
            export declare const AcctGtax: string;
            export declare const CostAccepted: string;
            export declare const CostRejected: string;
            export declare const Remarks: string;
            export declare const ExtDescription: string;
            export declare const AdjustRcvd: string;
            export declare const Anlys3: string;
            export declare const Anlys4: string;
            export declare const Anlys5: string;
            export declare const Anlys6: string;
            export declare const Anlys15: string;
            export declare const Anlys16: string;
            export declare const Anlys17: string;
            export declare const Anlys18: string;
            export declare const Anlys19: string;
            export declare const Anlys20: string;
            export declare const RefNoRecnum: string;
            export declare const RefNoInspectionDate: string;
            export declare const RefNoEntryMethod: string;
            export declare const RefNoPosted: string;
            export declare const RefNoInspectedBy: string;
            export declare const RefNoLoc: string;
            export declare const RefNoGrnNo: string;
            export declare const RefNoVendorNo: string;
            export declare const RefNoVendorName: string;
            export declare const RefNoReceivedDate: string;
            export declare const RefNoCcy: string;
            export declare const RefNoExchRate: string;
            export declare const RefNoFullInspection: string;
            export declare const RefNoPendingCount: string;
            export declare const RefNoWithRejects: string;
            export declare const RefNoHoldItems: string;
            export declare const RefNoReOrderNo: string;
            export declare const RefNoReOrderDate: string;
            export declare const RefNoReDueDate: string;
            export declare const RefNoReSchedDate: string;
            export declare const RefNoReShipTo: string;
            export declare const RefNoReShipVia: string;
            export declare const RefNoReShipTerms: string;
            export declare const RefNoReCount: string;
            export declare const RefNoTotPriceAmt: string;
            export declare const RefNoTotPtaxAmt: string;
            export declare const RefNoTotExtPrice: string;
            export declare const RefNoTotLdiscAmt: string;
            export declare const RefNoTotAtaxAmt: string;
            export declare const RefNoTotItemAmt: string;
            export declare const RefNoTdiscPcent: string;
            export declare const RefNoTotTdiscAmt: string;
            export declare const RefNoNetTradeAmt: string;
            export declare const RefNoLocPriceAmt: string;
            export declare const RefNoLocPtaxAmt: string;
            export declare const RefNoLocExtPrice: string;
            export declare const RefNoLocLdiscAmt: string;
            export declare const RefNoLocAtaxAmt: string;
            export declare const RefNoLocItemAmt: string;
            export declare const RefNoLocTdiscAmt: string;
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
            export declare const RefNoAnlys1: string;
            export declare const RefNoAnlys2: string;
            export declare const RefNoAnlys7: string;
            export declare const RefNoAnlys8: string;
            export declare const RefNoDoNo: string;
            export declare const RefNoAnlys9: string;
            export declare const RefNoAnlys10: string;
            export declare const RefNoAnlys11: string;
            export declare const RefNoAnlys12: string;
            export declare const RefNoAnlys13: string;
            export declare const RefNoAnlys14: string;
        }

        [
            'Recnum', 
            'RefNo', 
            'EntryNo', 
            'OrderNo', 
            'LineNo', 
            'ItemNo', 
            'Description', 
            'Uom', 
            'LotSize', 
            'QtyReceived', 
            'QtyPending', 
            'QtyInspected', 
            'QtyRejected', 
            'Reorder', 
            'Price', 
            'Ptax', 
            'NetPrice', 
            'ExtPrice', 
            'LdiscPcent', 
            'LdiscAmt', 
            'AtaxAmt', 
            'NetItemAmt', 
            'PriceAmt', 
            'PtaxAmt', 
            'LocPriceAmt', 
            'LocPtaxAmt', 
            'LocExtPrice', 
            'LocLdiscAmt', 
            'LocAtaxAmt', 
            'LocItemAmt', 
            'GrnNo', 
            'Loc', 
            'InspectionDate', 
            'Posted', 
            'LogNo', 
            'VendorNo', 
            'AcctPurchase', 
            'AcctLdisc', 
            'AcctGtax', 
            'CostAccepted', 
            'CostRejected', 
            'Remarks', 
            'ExtDescription', 
            'AdjustRcvd', 
            'Anlys3', 
            'Anlys4', 
            'Anlys5', 
            'Anlys6', 
            'Anlys15', 
            'Anlys16', 
            'Anlys17', 
            'Anlys18', 
            'Anlys19', 
            'Anlys20', 
            'RefNoRecnum', 
            'RefNoInspectionDate', 
            'RefNoEntryMethod', 
            'RefNoPosted', 
            'RefNoInspectedBy', 
            'RefNoLoc', 
            'RefNoGrnNo', 
            'RefNoVendorNo', 
            'RefNoVendorName', 
            'RefNoReceivedDate', 
            'RefNoCcy', 
            'RefNoExchRate', 
            'RefNoFullInspection', 
            'RefNoPendingCount', 
            'RefNoWithRejects', 
            'RefNoHoldItems', 
            'RefNoReOrderNo', 
            'RefNoReOrderDate', 
            'RefNoReDueDate', 
            'RefNoReSchedDate', 
            'RefNoReShipTo', 
            'RefNoReShipVia', 
            'RefNoReShipTerms', 
            'RefNoReCount', 
            'RefNoTotPriceAmt', 
            'RefNoTotPtaxAmt', 
            'RefNoTotExtPrice', 
            'RefNoTotLdiscAmt', 
            'RefNoTotAtaxAmt', 
            'RefNoTotItemAmt', 
            'RefNoTdiscPcent', 
            'RefNoTotTdiscAmt', 
            'RefNoNetTradeAmt', 
            'RefNoLocPriceAmt', 
            'RefNoLocPtaxAmt', 
            'RefNoLocExtPrice', 
            'RefNoLocLdiscAmt', 
            'RefNoLocAtaxAmt', 
            'RefNoLocItemAmt', 
            'RefNoLocTdiscAmt', 
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
            'RefNoAnlys1', 
            'RefNoAnlys2', 
            'RefNoAnlys7', 
            'RefNoAnlys8', 
            'RefNoDoNo', 
            'RefNoAnlys9', 
            'RefNoAnlys10', 
            'RefNoAnlys11', 
            'RefNoAnlys12', 
            'RefNoAnlys13', 
            'RefNoAnlys14'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

