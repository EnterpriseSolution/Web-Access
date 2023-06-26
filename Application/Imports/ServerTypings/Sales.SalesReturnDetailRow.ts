namespace Matrix.Sales {
    export interface SalesReturnDetailRow {
        Recnum?: number;
        RefNo?: string;
        EntryNo?: number;
        OrderNo?: string;
        LineNo?: number;
        ItemNo?: string;
        Description?: string;
        Uom?: string;
        LotSize?: number;
        QtyBalance?: number;
        QtyReturned?: number;
        Price?: number;
        Ptax?: number;
        NetPrice?: number;
        ExtPrice?: number;
        LdiscPcent?: number;
        LdiscAmt?: number;
        AtaxAmt?: number;
        NetItemAmt?: number;
        RefundAmt?: number;
        VariaAmt?: number;
        LdiscRate?: number;
        AtaxRate?: number;
        PriceAmt?: number;
        PtaxAmt?: number;
        LocPriceAmt?: number;
        LocPtaxAmt?: number;
        LocExtPrice?: number;
        LocLdiscAmt?: number;
        LocAtaxAmt?: number;
        LocItemAmt?: number;
        LocRefundAmt?: number;
        LocVariaAmt?: number;
        AcctSales?: string;
        AcctLdisc?: string;
        AcctPtax?: string;
        AcctAtax?: string;
        AcctVariance?: string;
        CommisType?: string;
        CommisRefNo?: string;
        CostReturned?: number;
        Anlys3?: string;
        Anlys4?: string;
        Anlys5?: string;
        Anlys6?: string;
        Reorder?: boolean;
        Anlys15?: string;
        Anlys16?: string;
        Anlys17?: string;
        Anlys18?: string;
        Anlys19?: string;
        Anlys20?: string;
        RefNoRecnum?: number;
        RefNoPosted?: string;
        RefNoTranDate?: string;
        RefNoShipmentRef?: string;
        RefNoCustomerNo?: string;
        RefNoCustomerName?: string;
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
        RefNoTotTdiscCpd?: number;
        RefNoAcctCustomer?: string;
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
        RefNoGlLink?: string;
        RefNoGlLinkType?: string;
        RefNoGlLinkNo?: string;
        RefNoOwnerBranch?: string;
        RefNoSourceBranch?: string;
        RefNoReason?: string;
        RefNoAnlys1?: string;
        RefNoAnlys2?: string;
        RefNoAnlys7?: string;
        RefNoAnlys8?: string;
        RefNoReturnOnly?: string;
        RefNoAnlys9?: string;
        RefNoAnlys10?: string;
        RefNoAnlys11?: string;
        RefNoAnlys12?: string;
        RefNoAnlys13?: string;
        RefNoAnlys14?: string;
    }

    export namespace SalesReturnDetailRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'RefNo';
        export const localTextPrefix = 'Sales.SalesReturnDetail';

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
            export declare const QtyBalance: string;
            export declare const QtyReturned: string;
            export declare const Price: string;
            export declare const Ptax: string;
            export declare const NetPrice: string;
            export declare const ExtPrice: string;
            export declare const LdiscPcent: string;
            export declare const LdiscAmt: string;
            export declare const AtaxAmt: string;
            export declare const NetItemAmt: string;
            export declare const RefundAmt: string;
            export declare const VariaAmt: string;
            export declare const LdiscRate: string;
            export declare const AtaxRate: string;
            export declare const PriceAmt: string;
            export declare const PtaxAmt: string;
            export declare const LocPriceAmt: string;
            export declare const LocPtaxAmt: string;
            export declare const LocExtPrice: string;
            export declare const LocLdiscAmt: string;
            export declare const LocAtaxAmt: string;
            export declare const LocItemAmt: string;
            export declare const LocRefundAmt: string;
            export declare const LocVariaAmt: string;
            export declare const AcctSales: string;
            export declare const AcctLdisc: string;
            export declare const AcctPtax: string;
            export declare const AcctAtax: string;
            export declare const AcctVariance: string;
            export declare const CommisType: string;
            export declare const CommisRefNo: string;
            export declare const CostReturned: string;
            export declare const Anlys3: string;
            export declare const Anlys4: string;
            export declare const Anlys5: string;
            export declare const Anlys6: string;
            export declare const Reorder: string;
            export declare const Anlys15: string;
            export declare const Anlys16: string;
            export declare const Anlys17: string;
            export declare const Anlys18: string;
            export declare const Anlys19: string;
            export declare const Anlys20: string;
            export declare const RefNoRecnum: string;
            export declare const RefNoPosted: string;
            export declare const RefNoTranDate: string;
            export declare const RefNoShipmentRef: string;
            export declare const RefNoCustomerNo: string;
            export declare const RefNoCustomerName: string;
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
            export declare const RefNoTotTdiscCpd: string;
            export declare const RefNoAcctCustomer: string;
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
            export declare const RefNoGlLink: string;
            export declare const RefNoGlLinkType: string;
            export declare const RefNoGlLinkNo: string;
            export declare const RefNoOwnerBranch: string;
            export declare const RefNoSourceBranch: string;
            export declare const RefNoReason: string;
            export declare const RefNoAnlys1: string;
            export declare const RefNoAnlys2: string;
            export declare const RefNoAnlys7: string;
            export declare const RefNoAnlys8: string;
            export declare const RefNoReturnOnly: string;
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
            'QtyBalance', 
            'QtyReturned', 
            'Price', 
            'Ptax', 
            'NetPrice', 
            'ExtPrice', 
            'LdiscPcent', 
            'LdiscAmt', 
            'AtaxAmt', 
            'NetItemAmt', 
            'RefundAmt', 
            'VariaAmt', 
            'LdiscRate', 
            'AtaxRate', 
            'PriceAmt', 
            'PtaxAmt', 
            'LocPriceAmt', 
            'LocPtaxAmt', 
            'LocExtPrice', 
            'LocLdiscAmt', 
            'LocAtaxAmt', 
            'LocItemAmt', 
            'LocRefundAmt', 
            'LocVariaAmt', 
            'AcctSales', 
            'AcctLdisc', 
            'AcctPtax', 
            'AcctAtax', 
            'AcctVariance', 
            'CommisType', 
            'CommisRefNo', 
            'CostReturned', 
            'Anlys3', 
            'Anlys4', 
            'Anlys5', 
            'Anlys6', 
            'Reorder', 
            'Anlys15', 
            'Anlys16', 
            'Anlys17', 
            'Anlys18', 
            'Anlys19', 
            'Anlys20', 
            'RefNoRecnum', 
            'RefNoPosted', 
            'RefNoTranDate', 
            'RefNoShipmentRef', 
            'RefNoCustomerNo', 
            'RefNoCustomerName', 
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
            'RefNoTotTdiscCpd', 
            'RefNoAcctCustomer', 
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
            'RefNoGlLink', 
            'RefNoGlLinkType', 
            'RefNoGlLinkNo', 
            'RefNoOwnerBranch', 
            'RefNoSourceBranch', 
            'RefNoReason', 
            'RefNoAnlys1', 
            'RefNoAnlys2', 
            'RefNoAnlys7', 
            'RefNoAnlys8', 
            'RefNoReturnOnly', 
            'RefNoAnlys9', 
            'RefNoAnlys10', 
            'RefNoAnlys11', 
            'RefNoAnlys12', 
            'RefNoAnlys13', 
            'RefNoAnlys14'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

