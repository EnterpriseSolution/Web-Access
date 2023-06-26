namespace Matrix.Purchasing {
    export interface PurchaseOrderDetailRow {
        Recnum?: number;
        OrderNo?: string;
        LineNo?: number;
        Posted?: string;
        Closed?: string;
        ItemNo?: string;
        VendorItemNo?: string;
        Description?: string;
        Uom?: string;
        LotSize?: number;
        Qty?: number;
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
        Anlys1?: string;
        Anlys2?: string;
        Anlys3?: string;
        Anlys4?: string;
        Anlys5?: string;
        Anlys6?: string;
        FirstShipQty?: number;
        OtherShipQty?: number;
        LastShipNo?: number;
        WeightUom?: string;
        GrossWt?: number;
        NetWt?: number;
        DimensionUom?: string;
        Flength?: number;
        Width?: number;
        Height?: number;
        Volume?: number;
        PriceCpd?: number;
        PtaxCpd?: number;
        AtaxCpd?: number;
        DiscCpd?: number;
        GrossWtCpd?: number;
        NetWtCpd?: number;
        VolumeCpd?: number;
        InnerPkgType?: string;
        InnerQty?: number;
        InnerPkgs?: number;
        InnerExcsQty?: number;
        OuterPkgType?: string;
        OuterQty?: number;
        OuterPkgs?: number;
        OuterExcsQty?: number;
        QtyReceived?: number;
        SchedCount?: number;
        ExtDescription?: string;
        QtyPending?: number;
        JobNo?: string;
        OriginQty?: number;
        PutaxPcent?: number;
        PutaxAmt?: number;
        TotAllocatedQty?: number;
        IweightUom?: string;
        IgrossWt?: number;
        InetWt?: number;
        Ivolume?: number;
        TotGrossWt?: number;
        TotNetWt?: number;
        Dimension?: string;
        ReorderQty?: number;
        Remark?: string;
        SubconJob?: string;
        Anlys15?: string;
        Anlys16?: string;
        Anlys17?: string;
        Anlys18?: string;
        Anlys19?: string;
        Anlys20?: string;
        MrpRequiredQty?: number;
        OverReceiptPcent?: number;
        ZeroPrice?: boolean;
        OrderNoRecnum?: number;
        OrderNoPosted?: string;
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
        OrderNoDpsRefNo?: string;
        OrderNoDpsFundCode?: string;
        OrderNoDpsPayee?: string;
        OrderNoDpsChequeNo?: string;
        OrderNoDpsDate?: string;
        OrderNoCreatedDate?: string;
        OrderNoCreatedBy?: string;
        OrderNoRevisedDate?: string;
        OrderNoRevisedBy?: string;
        OrderNoPostedDate?: string;
        OrderNoPostedBy?: string;
        OrderNoLockType?: string;
        OrderNoLockRefNo?: string;
        OrderNoLastLogNo?: number;
        OrderNoOwnerBranch?: string;
        OrderNoSourceBranch?: string;
        OrderNoComments1?: string;
        OrderNoComments2?: string;
        OrderNoComments3?: string;
        OrderNoComments4?: string;
        OrderNoServerRevised?: string;
        OrderNoWebAmended?: string;
        OrderNoPubAccess?: string;
        OrderNoConfirmed?: string;
        OrderNoCheckCrlimit?: string;
        OrderNoCheckCrbal?: number;
        OrderNoJobNo?: string;
        OrderNoConsign?: string;
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
        OrderNoLastLinkNo?: number;
        OrderNoFlag?: string;
        OrderNoHoldBy?: string;
        OrderNoSubconPo?: string;
        OrderNoMrpExclude?: string;
        OrderNoFromPr?: string;
        OrderNoAnlys9?: string;
        OrderNoAnlys10?: string;
        OrderNoAnlys11?: string;
        OrderNoAnlys12?: string;
        OrderNoAnlys13?: string;
        OrderNoAnlys14?: string;
        OrderNoRefCompanyCode?: string;
        OrderNoRefSalesOrderNo?: string;
        OrderNoTaxTerms?: string;
        OrderNoCustomTerms?: string;
        OrderNoLmeCost?: number;
        OrderNoLmeCcy?: string;
        OrderNoLmeExchRate?: number;
        OrderNoAddressCode?: string;
        OrderNoContactPerson?: string;
        OrderNoContactTitle?: string;
        OrderNoTelNo?: string;
        OrderNoFaxNo?: string;
    }

    export namespace PurchaseOrderDetailRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'OrderNo';
        export const localTextPrefix = 'Purchasing.PurchaseOrderDetail';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const OrderNo: string;
            export declare const LineNo: string;
            export declare const Posted: string;
            export declare const Closed: string;
            export declare const ItemNo: string;
            export declare const VendorItemNo: string;
            export declare const Description: string;
            export declare const Uom: string;
            export declare const LotSize: string;
            export declare const Qty: string;
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
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const Anlys3: string;
            export declare const Anlys4: string;
            export declare const Anlys5: string;
            export declare const Anlys6: string;
            export declare const FirstShipQty: string;
            export declare const OtherShipQty: string;
            export declare const LastShipNo: string;
            export declare const WeightUom: string;
            export declare const GrossWt: string;
            export declare const NetWt: string;
            export declare const DimensionUom: string;
            export declare const Flength: string;
            export declare const Width: string;
            export declare const Height: string;
            export declare const Volume: string;
            export declare const PriceCpd: string;
            export declare const PtaxCpd: string;
            export declare const AtaxCpd: string;
            export declare const DiscCpd: string;
            export declare const GrossWtCpd: string;
            export declare const NetWtCpd: string;
            export declare const VolumeCpd: string;
            export declare const InnerPkgType: string;
            export declare const InnerQty: string;
            export declare const InnerPkgs: string;
            export declare const InnerExcsQty: string;
            export declare const OuterPkgType: string;
            export declare const OuterQty: string;
            export declare const OuterPkgs: string;
            export declare const OuterExcsQty: string;
            export declare const QtyReceived: string;
            export declare const SchedCount: string;
            export declare const ExtDescription: string;
            export declare const QtyPending: string;
            export declare const JobNo: string;
            export declare const OriginQty: string;
            export declare const PutaxPcent: string;
            export declare const PutaxAmt: string;
            export declare const TotAllocatedQty: string;
            export declare const IweightUom: string;
            export declare const IgrossWt: string;
            export declare const InetWt: string;
            export declare const Ivolume: string;
            export declare const TotGrossWt: string;
            export declare const TotNetWt: string;
            export declare const Dimension: string;
            export declare const ReorderQty: string;
            export declare const Remark: string;
            export declare const SubconJob: string;
            export declare const Anlys15: string;
            export declare const Anlys16: string;
            export declare const Anlys17: string;
            export declare const Anlys18: string;
            export declare const Anlys19: string;
            export declare const Anlys20: string;
            export declare const MrpRequiredQty: string;
            export declare const OverReceiptPcent: string;
            export declare const ZeroPrice: string;
            export declare const OrderNoRecnum: string;
            export declare const OrderNoPosted: string;
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
            export declare const OrderNoDpsRefNo: string;
            export declare const OrderNoDpsFundCode: string;
            export declare const OrderNoDpsPayee: string;
            export declare const OrderNoDpsChequeNo: string;
            export declare const OrderNoDpsDate: string;
            export declare const OrderNoCreatedDate: string;
            export declare const OrderNoCreatedBy: string;
            export declare const OrderNoRevisedDate: string;
            export declare const OrderNoRevisedBy: string;
            export declare const OrderNoPostedDate: string;
            export declare const OrderNoPostedBy: string;
            export declare const OrderNoLockType: string;
            export declare const OrderNoLockRefNo: string;
            export declare const OrderNoLastLogNo: string;
            export declare const OrderNoOwnerBranch: string;
            export declare const OrderNoSourceBranch: string;
            export declare const OrderNoComments1: string;
            export declare const OrderNoComments2: string;
            export declare const OrderNoComments3: string;
            export declare const OrderNoComments4: string;
            export declare const OrderNoServerRevised: string;
            export declare const OrderNoWebAmended: string;
            export declare const OrderNoPubAccess: string;
            export declare const OrderNoConfirmed: string;
            export declare const OrderNoCheckCrlimit: string;
            export declare const OrderNoCheckCrbal: string;
            export declare const OrderNoJobNo: string;
            export declare const OrderNoConsign: string;
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
            export declare const OrderNoLastLinkNo: string;
            export declare const OrderNoFlag: string;
            export declare const OrderNoHoldBy: string;
            export declare const OrderNoSubconPo: string;
            export declare const OrderNoMrpExclude: string;
            export declare const OrderNoFromPr: string;
            export declare const OrderNoAnlys9: string;
            export declare const OrderNoAnlys10: string;
            export declare const OrderNoAnlys11: string;
            export declare const OrderNoAnlys12: string;
            export declare const OrderNoAnlys13: string;
            export declare const OrderNoAnlys14: string;
            export declare const OrderNoRefCompanyCode: string;
            export declare const OrderNoRefSalesOrderNo: string;
            export declare const OrderNoTaxTerms: string;
            export declare const OrderNoCustomTerms: string;
            export declare const OrderNoLmeCost: string;
            export declare const OrderNoLmeCcy: string;
            export declare const OrderNoLmeExchRate: string;
            export declare const OrderNoAddressCode: string;
            export declare const OrderNoContactPerson: string;
            export declare const OrderNoContactTitle: string;
            export declare const OrderNoTelNo: string;
            export declare const OrderNoFaxNo: string;
        }

        [
            'Recnum', 
            'OrderNo', 
            'LineNo', 
            'Posted', 
            'Closed', 
            'ItemNo', 
            'VendorItemNo', 
            'Description', 
            'Uom', 
            'LotSize', 
            'Qty', 
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
            'Anlys1', 
            'Anlys2', 
            'Anlys3', 
            'Anlys4', 
            'Anlys5', 
            'Anlys6', 
            'FirstShipQty', 
            'OtherShipQty', 
            'LastShipNo', 
            'WeightUom', 
            'GrossWt', 
            'NetWt', 
            'DimensionUom', 
            'Flength', 
            'Width', 
            'Height', 
            'Volume', 
            'PriceCpd', 
            'PtaxCpd', 
            'AtaxCpd', 
            'DiscCpd', 
            'GrossWtCpd', 
            'NetWtCpd', 
            'VolumeCpd', 
            'InnerPkgType', 
            'InnerQty', 
            'InnerPkgs', 
            'InnerExcsQty', 
            'OuterPkgType', 
            'OuterQty', 
            'OuterPkgs', 
            'OuterExcsQty', 
            'QtyReceived', 
            'SchedCount', 
            'ExtDescription', 
            'QtyPending', 
            'JobNo', 
            'OriginQty', 
            'PutaxPcent', 
            'PutaxAmt', 
            'TotAllocatedQty', 
            'IweightUom', 
            'IgrossWt', 
            'InetWt', 
            'Ivolume', 
            'TotGrossWt', 
            'TotNetWt', 
            'Dimension', 
            'ReorderQty', 
            'Remark', 
            'SubconJob', 
            'Anlys15', 
            'Anlys16', 
            'Anlys17', 
            'Anlys18', 
            'Anlys19', 
            'Anlys20', 
            'MrpRequiredQty', 
            'OverReceiptPcent', 
            'ZeroPrice', 
            'OrderNoRecnum', 
            'OrderNoPosted', 
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
            'OrderNoDpsRefNo', 
            'OrderNoDpsFundCode', 
            'OrderNoDpsPayee', 
            'OrderNoDpsChequeNo', 
            'OrderNoDpsDate', 
            'OrderNoCreatedDate', 
            'OrderNoCreatedBy', 
            'OrderNoRevisedDate', 
            'OrderNoRevisedBy', 
            'OrderNoPostedDate', 
            'OrderNoPostedBy', 
            'OrderNoLockType', 
            'OrderNoLockRefNo', 
            'OrderNoLastLogNo', 
            'OrderNoOwnerBranch', 
            'OrderNoSourceBranch', 
            'OrderNoComments1', 
            'OrderNoComments2', 
            'OrderNoComments3', 
            'OrderNoComments4', 
            'OrderNoServerRevised', 
            'OrderNoWebAmended', 
            'OrderNoPubAccess', 
            'OrderNoConfirmed', 
            'OrderNoCheckCrlimit', 
            'OrderNoCheckCrbal', 
            'OrderNoJobNo', 
            'OrderNoConsign', 
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
            'OrderNoLastLinkNo', 
            'OrderNoFlag', 
            'OrderNoHoldBy', 
            'OrderNoSubconPo', 
            'OrderNoMrpExclude', 
            'OrderNoFromPr', 
            'OrderNoAnlys9', 
            'OrderNoAnlys10', 
            'OrderNoAnlys11', 
            'OrderNoAnlys12', 
            'OrderNoAnlys13', 
            'OrderNoAnlys14', 
            'OrderNoRefCompanyCode', 
            'OrderNoRefSalesOrderNo', 
            'OrderNoTaxTerms', 
            'OrderNoCustomTerms', 
            'OrderNoLmeCost', 
            'OrderNoLmeCcy', 
            'OrderNoLmeExchRate', 
            'OrderNoAddressCode', 
            'OrderNoContactPerson', 
            'OrderNoContactTitle', 
            'OrderNoTelNo', 
            'OrderNoFaxNo'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

