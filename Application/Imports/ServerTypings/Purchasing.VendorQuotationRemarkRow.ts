namespace Matrix.Purchasing {
    export interface VendorQuotationRemarkRow {
        Recnum?: number;
        OrderNo?: string;
        TextNo?: number;
        TextType?: string;
        Description?: string;
        Remarks?: string;
        OrderNoRecnum?: number;
        OrderNoClosed?: string;
        OrderNoVendorNo?: string;
        OrderNoVendorName?: string;
        OrderNoVendorAddress?: string;
        OrderNoVendorAddress2?: string;
        OrderNoVendorAddress3?: string;
        OrderNoVendorAddress4?: string;
        OrderNoOrderDate?: string;
        OrderNoDueDate?: string;
        OrderNoSchedDate?: string;
        OrderNoShipTo?: string;
        OrderNoAddress?: string;
        OrderNoAddress2?: string;
        OrderNoAddress3?: string;
        OrderNoAddress4?: string;
        OrderNoMultiShip?: string;
        OrderNoComputeTax?: string;
        OrderNoShipVia?: string;
        OrderNoShipmentTerms?: string;
        OrderNoBuyer?: string;
        OrderNoPayTerms?: string;
        OrderNoAnlys1?: string;
        OrderNoAnlys2?: string;
        OrderNoCcy?: string;
        OrderNoExchRate?: number;
        OrderNoSourceType?: string;
        OrderNoSourceRefNo?: string;
        OrderNoLastSchedNo?: number;
        OrderNoLastLineNo?: number;
        OrderNoLastTextNo?: number;
        OrderNoTotPriceAmt?: number;
        OrderNoTotPtaxAmt?: number;
        OrderNoTotExtPrice?: number;
        OrderNoTotLdiscAmt?: number;
        OrderNoTotAtaxAmt?: number;
        OrderNoTotItemAmt?: number;
        OrderNoTdiscPcent?: number;
        OrderNoTotTdiscAmt?: number;
        OrderNoNetTradeAmt?: number;
        OrderNoTotChgsAmt?: number;
        OrderNoNetOrdrAmt?: number;
        OrderNoTotGtaxAmt?: number;
        OrderNoNetPayAmt?: number;
        OrderNoDpsPcent?: number;
        OrderNoTotDpsAmt?: number;
        OrderNoNetBalAmt?: number;
        OrderNoTotTdiscCpd?: number;
        OrderNoTotGtaxCpd?: number;
        OrderNoTotDpsCpd?: number;
        OrderNoCreatedDate?: string;
        OrderNoCreatedBy?: string;
        OrderNoRevisedDate?: string;
        OrderNoRevisedBy?: string;
        OrderNoPostedDate?: string;
        OrderNoPostedBy?: string;
        OrderNoLockRefNo?: string;
        OrderNoLastLogNo?: number;
        OrderNoOwnerBranch?: string;
        OrderNoSourceBranch?: string;
        OrderNoComments1?: string;
        OrderNoComments2?: string;
        OrderNoComments3?: string;
        OrderNoComments4?: string;
        OrderNoPortLoading?: string;
        OrderNoPortDischarge?: string;
        OrderNoVesselName?: string;
        OrderNoForwarder?: string;
        OrderNoLcNo?: string;
        OrderNoOriginCountry?: string;
        OrderNoPutaxType?: string;
        OrderNoGputaxPcent?: number;
        OrderNoTotGputaxAmt?: number;
        OrderNoTotLputaxAmt?: number;
        OrderNoAnlys7?: string;
        OrderNoAnlys8?: string;
        OrderNoVendorRefNo?: string;
        OrderNoValidUntil?: string;
        OrderNoClosedBy?: string;
        OrderNoClosedDate?: string;
        OrderNoAnlys9?: string;
        OrderNoAnlys10?: string;
        OrderNoAnlys11?: string;
        OrderNoAnlys12?: string;
        OrderNoAnlys13?: string;
        OrderNoAnlys14?: string;
    }

    export namespace VendorQuotationRemarkRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'OrderNo';
        export const localTextPrefix = 'Purchasing.VendorQuotationRemark';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const OrderNo: string;
            export declare const TextNo: string;
            export declare const TextType: string;
            export declare const Description: string;
            export declare const Remarks: string;
            export declare const OrderNoRecnum: string;
            export declare const OrderNoClosed: string;
            export declare const OrderNoVendorNo: string;
            export declare const OrderNoVendorName: string;
            export declare const OrderNoVendorAddress: string;
            export declare const OrderNoVendorAddress2: string;
            export declare const OrderNoVendorAddress3: string;
            export declare const OrderNoVendorAddress4: string;
            export declare const OrderNoOrderDate: string;
            export declare const OrderNoDueDate: string;
            export declare const OrderNoSchedDate: string;
            export declare const OrderNoShipTo: string;
            export declare const OrderNoAddress: string;
            export declare const OrderNoAddress2: string;
            export declare const OrderNoAddress3: string;
            export declare const OrderNoAddress4: string;
            export declare const OrderNoMultiShip: string;
            export declare const OrderNoComputeTax: string;
            export declare const OrderNoShipVia: string;
            export declare const OrderNoShipmentTerms: string;
            export declare const OrderNoBuyer: string;
            export declare const OrderNoPayTerms: string;
            export declare const OrderNoAnlys1: string;
            export declare const OrderNoAnlys2: string;
            export declare const OrderNoCcy: string;
            export declare const OrderNoExchRate: string;
            export declare const OrderNoSourceType: string;
            export declare const OrderNoSourceRefNo: string;
            export declare const OrderNoLastSchedNo: string;
            export declare const OrderNoLastLineNo: string;
            export declare const OrderNoLastTextNo: string;
            export declare const OrderNoTotPriceAmt: string;
            export declare const OrderNoTotPtaxAmt: string;
            export declare const OrderNoTotExtPrice: string;
            export declare const OrderNoTotLdiscAmt: string;
            export declare const OrderNoTotAtaxAmt: string;
            export declare const OrderNoTotItemAmt: string;
            export declare const OrderNoTdiscPcent: string;
            export declare const OrderNoTotTdiscAmt: string;
            export declare const OrderNoNetTradeAmt: string;
            export declare const OrderNoTotChgsAmt: string;
            export declare const OrderNoNetOrdrAmt: string;
            export declare const OrderNoTotGtaxAmt: string;
            export declare const OrderNoNetPayAmt: string;
            export declare const OrderNoDpsPcent: string;
            export declare const OrderNoTotDpsAmt: string;
            export declare const OrderNoNetBalAmt: string;
            export declare const OrderNoTotTdiscCpd: string;
            export declare const OrderNoTotGtaxCpd: string;
            export declare const OrderNoTotDpsCpd: string;
            export declare const OrderNoCreatedDate: string;
            export declare const OrderNoCreatedBy: string;
            export declare const OrderNoRevisedDate: string;
            export declare const OrderNoRevisedBy: string;
            export declare const OrderNoPostedDate: string;
            export declare const OrderNoPostedBy: string;
            export declare const OrderNoLockRefNo: string;
            export declare const OrderNoLastLogNo: string;
            export declare const OrderNoOwnerBranch: string;
            export declare const OrderNoSourceBranch: string;
            export declare const OrderNoComments1: string;
            export declare const OrderNoComments2: string;
            export declare const OrderNoComments3: string;
            export declare const OrderNoComments4: string;
            export declare const OrderNoPortLoading: string;
            export declare const OrderNoPortDischarge: string;
            export declare const OrderNoVesselName: string;
            export declare const OrderNoForwarder: string;
            export declare const OrderNoLcNo: string;
            export declare const OrderNoOriginCountry: string;
            export declare const OrderNoPutaxType: string;
            export declare const OrderNoGputaxPcent: string;
            export declare const OrderNoTotGputaxAmt: string;
            export declare const OrderNoTotLputaxAmt: string;
            export declare const OrderNoAnlys7: string;
            export declare const OrderNoAnlys8: string;
            export declare const OrderNoVendorRefNo: string;
            export declare const OrderNoValidUntil: string;
            export declare const OrderNoClosedBy: string;
            export declare const OrderNoClosedDate: string;
            export declare const OrderNoAnlys9: string;
            export declare const OrderNoAnlys10: string;
            export declare const OrderNoAnlys11: string;
            export declare const OrderNoAnlys12: string;
            export declare const OrderNoAnlys13: string;
            export declare const OrderNoAnlys14: string;
        }

        [
            'Recnum', 
            'OrderNo', 
            'TextNo', 
            'TextType', 
            'Description', 
            'Remarks', 
            'OrderNoRecnum', 
            'OrderNoClosed', 
            'OrderNoVendorNo', 
            'OrderNoVendorName', 
            'OrderNoVendorAddress', 
            'OrderNoVendorAddress2', 
            'OrderNoVendorAddress3', 
            'OrderNoVendorAddress4', 
            'OrderNoOrderDate', 
            'OrderNoDueDate', 
            'OrderNoSchedDate', 
            'OrderNoShipTo', 
            'OrderNoAddress', 
            'OrderNoAddress2', 
            'OrderNoAddress3', 
            'OrderNoAddress4', 
            'OrderNoMultiShip', 
            'OrderNoComputeTax', 
            'OrderNoShipVia', 
            'OrderNoShipmentTerms', 
            'OrderNoBuyer', 
            'OrderNoPayTerms', 
            'OrderNoAnlys1', 
            'OrderNoAnlys2', 
            'OrderNoCcy', 
            'OrderNoExchRate', 
            'OrderNoSourceType', 
            'OrderNoSourceRefNo', 
            'OrderNoLastSchedNo', 
            'OrderNoLastLineNo', 
            'OrderNoLastTextNo', 
            'OrderNoTotPriceAmt', 
            'OrderNoTotPtaxAmt', 
            'OrderNoTotExtPrice', 
            'OrderNoTotLdiscAmt', 
            'OrderNoTotAtaxAmt', 
            'OrderNoTotItemAmt', 
            'OrderNoTdiscPcent', 
            'OrderNoTotTdiscAmt', 
            'OrderNoNetTradeAmt', 
            'OrderNoTotChgsAmt', 
            'OrderNoNetOrdrAmt', 
            'OrderNoTotGtaxAmt', 
            'OrderNoNetPayAmt', 
            'OrderNoDpsPcent', 
            'OrderNoTotDpsAmt', 
            'OrderNoNetBalAmt', 
            'OrderNoTotTdiscCpd', 
            'OrderNoTotGtaxCpd', 
            'OrderNoTotDpsCpd', 
            'OrderNoCreatedDate', 
            'OrderNoCreatedBy', 
            'OrderNoRevisedDate', 
            'OrderNoRevisedBy', 
            'OrderNoPostedDate', 
            'OrderNoPostedBy', 
            'OrderNoLockRefNo', 
            'OrderNoLastLogNo', 
            'OrderNoOwnerBranch', 
            'OrderNoSourceBranch', 
            'OrderNoComments1', 
            'OrderNoComments2', 
            'OrderNoComments3', 
            'OrderNoComments4', 
            'OrderNoPortLoading', 
            'OrderNoPortDischarge', 
            'OrderNoVesselName', 
            'OrderNoForwarder', 
            'OrderNoLcNo', 
            'OrderNoOriginCountry', 
            'OrderNoPutaxType', 
            'OrderNoGputaxPcent', 
            'OrderNoTotGputaxAmt', 
            'OrderNoTotLputaxAmt', 
            'OrderNoAnlys7', 
            'OrderNoAnlys8', 
            'OrderNoVendorRefNo', 
            'OrderNoValidUntil', 
            'OrderNoClosedBy', 
            'OrderNoClosedDate', 
            'OrderNoAnlys9', 
            'OrderNoAnlys10', 
            'OrderNoAnlys11', 
            'OrderNoAnlys12', 
            'OrderNoAnlys13', 
            'OrderNoAnlys14'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

