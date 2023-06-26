namespace Matrix.Sales {
    export interface SalesOrderDetailRow {
        Recnum?: number;
        OrderNo?: string;
        LineNo?: number;
        Posted?: string;
        Closed?: string;
        ItemNo?: string;
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
        CommisType?: string;
        CommisRefNo?: string;
        Configurable?: string;
        FirstShipQty?: number;
        OtherShipQty?: number;
        LastShipNo?: number;
        Reserved?: string;
        ResvStubNo?: string;
        Waitlisted?: string;
        WaitlistNo?: string;
        WeightUom?: string;
        GrossWt?: number;
        NetWt?: number;
        DimensionUom?: string;
        Flength?: number;
        Width?: number;
        Height?: number;
        UnitVolume?: number;
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
        StartCtnNo?: number;
        QtyShipped?: number;
        ItemTaxCode?: string;
        CustItemNo?: string;
        SpecNo?: string;
        BomNo?: string;
        QtyPacked?: number;
        JobNo?: string;
        ProdBranch?: string;
        AssemblyLine?: string;
        ProdDueDate?: string;
        MakeIt?: string;
        ProdStartDate?: string;
        SchedCount?: number;
        StdAssort?: string;
        ExtDescription?: string;
        QtyPending?: number;
        VendorNo?: string;
        VendorPrice?: number;
        VendorPack?: string;
        VendorCcy?: string;
        OriginQty?: number;
        SltaxPcent?: number;
        SltaxAmt?: number;
        ReorderQty?: number;
        IncludeScrapRate?: string;
        MarkupPcent?: number;
        Markup?: number;
        ItemCode?: string;
        MoldBomNo?: string;
        MoldFormulaCode?: string;
        MoldExpectedQty?: number;
        Anlys15?: string;
        Anlys16?: string;
        Anlys17?: string;
        Anlys18?: string;
        Anlys19?: string;
        Anlys20?: string;
        ShipmarkRmk?: string;
        LotSizeCost?: number;
        ReleaseQty?: number;
        BlanketRef?: string;
        BlanketLineNo?: number;
        OrderNoRecnum?: number;
        OrderNoPosted?: string;
        OrderNoClosed?: string;
        OrderNoCustomerNo?: string;
        OrderNoCustomerName?: string;
        OrderNoOrderDate?: string;
        OrderNoDueDate?: string;
        OrderNoSchedDate?: string;
        OrderNoCustomerPo?: string;
        OrderNoShipTo?: string;
        OrderNoAddress?: string;
        OrderNoAddress2?: string;
        OrderNoAddress3?: string;
        OrderNoAddress4?: string;
        OrderNoMultiShip?: string;
        OrderNoAutoPo?: string;
        OrderNoAutoJob?: string;
        OrderNoComputeTax?: string;
        OrderNoAutoResv?: string;
        OrderNoAutoWait?: string;
        OrderNoVendorNo?: string;
        OrderNoPoNo?: string;
        OrderNoPoPayTerms?: string;
        OrderNoPoShipTo?: string;
        OrderNoPoBuyer?: string;
        OrderNoShipVia?: string;
        OrderNoShipmentTerms?: string;
        OrderNoSalesman?: string;
        OrderNoPayTerms?: string;
        OrderNoPriceCode?: string;
        OrderNoAnlys1?: string;
        OrderNoAnlys2?: string;
        OrderNoCcy?: string;
        OrderNoExchRate?: number;
        OrderNoShipFrom?: string;
        OrderNoLastSchedNo?: number;
        OrderNoLastLineNo?: number;
        OrderNoLastTextNo?: number;
        OrderNoLastCtnNo?: number;
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
        OrderNoDpsReceiptNo?: string;
        OrderNoDpsFundCode?: string;
        OrderNoDpsReference?: string;
        OrderNoDpsRcptDate?: string;
        OrderNoCreatedDate?: string;
        OrderNoCreatedBy?: string;
        OrderNoRevisedDate?: string;
        OrderNoRevisedBy?: string;
        OrderNoPostedDate?: string;
        OrderNoPostedBy?: string;
        OrderNoPrevisedDate?: string;
        OrderNoPrevisedBy?: string;
        OrderNoLockType?: string;
        OrderNoLockRefNo?: string;
        OrderNoLastLogNo?: number;
        OrderNoVendTaxCode?: string;
        OrderNoCustTaxCode?: string;
        OrderNoPackingOk?: string;
        OrderNoWeightUom?: string;
        OrderNoGrWt?: number;
        OrderNoNtWt?: number;
        OrderNoDimensionUom?: string;
        OrderNoVolume?: number;
        OrderNoOwnerBranch?: string;
        OrderNoSourceBranch?: string;
        OrderNoComments1?: string;
        OrderNoComments2?: string;
        OrderNoComments3?: string;
        OrderNoComments4?: string;
        OrderNoCheckCrlimit?: string;
        OrderNoCheckCrbal?: number;
        OrderNoWebPublished?: string;
        OrderNoSendWebMsg?: string;
        OrderNoWebUserName?: string;
        OrderNoAttention?: string;
        OrderNoTelNo?: string;
        OrderNoFaxNo?: string;
        OrderNoPortLoading?: string;
        OrderNoPortDischarge?: string;
        OrderNoVesselName?: string;
        OrderNoForwarder?: string;
        OrderNoLcNo?: string;
        OrderNoOriginCountry?: string;
        OrderNoMrpExclude?: string;
        OrderNoSltaxType?: string;
        OrderNoGsltaxPcent?: number;
        OrderNoTotGsltaxAmt?: number;
        OrderNoTotLsltaxAmt?: number;
        OrderNoLastTextNo1?: number;
        OrderNoComments5?: string;
        OrderNoComments6?: string;
        OrderNoComments7?: string;
        OrderNoComments8?: string;
        OrderNoAnlys7?: string;
        OrderNoAnlys8?: string;
        OrderNoFlag?: string;
        OrderNoHoldBy?: string;
        OrderNoQuoRefNo?: string;
        OrderNoBrandCode?: string;
        OrderNoItemCode?: string;
        OrderNoPkgUnit?: string;
        OrderNoWeightUnit?: string;
        OrderNoAnlys9?: string;
        OrderNoAnlys10?: string;
        OrderNoAnlys11?: string;
        OrderNoAnlys12?: string;
        OrderNoAnlys13?: string;
        OrderNoAnlys14?: string;
        OrderNoOrderType?: string;
        OrderNoRefCompanyCode?: string;
        OrderNoRefPurchaseOrderNo?: string;
    }

    export namespace SalesOrderDetailRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'OrderNo';
        export const localTextPrefix = 'Sales.SalesOrderDetail';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const OrderNo: string;
            export declare const LineNo: string;
            export declare const Posted: string;
            export declare const Closed: string;
            export declare const ItemNo: string;
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
            export declare const CommisType: string;
            export declare const CommisRefNo: string;
            export declare const Configurable: string;
            export declare const FirstShipQty: string;
            export declare const OtherShipQty: string;
            export declare const LastShipNo: string;
            export declare const Reserved: string;
            export declare const ResvStubNo: string;
            export declare const Waitlisted: string;
            export declare const WaitlistNo: string;
            export declare const WeightUom: string;
            export declare const GrossWt: string;
            export declare const NetWt: string;
            export declare const DimensionUom: string;
            export declare const Flength: string;
            export declare const Width: string;
            export declare const Height: string;
            export declare const UnitVolume: string;
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
            export declare const StartCtnNo: string;
            export declare const QtyShipped: string;
            export declare const ItemTaxCode: string;
            export declare const CustItemNo: string;
            export declare const SpecNo: string;
            export declare const BomNo: string;
            export declare const QtyPacked: string;
            export declare const JobNo: string;
            export declare const ProdBranch: string;
            export declare const AssemblyLine: string;
            export declare const ProdDueDate: string;
            export declare const MakeIt: string;
            export declare const ProdStartDate: string;
            export declare const SchedCount: string;
            export declare const StdAssort: string;
            export declare const ExtDescription: string;
            export declare const QtyPending: string;
            export declare const VendorNo: string;
            export declare const VendorPrice: string;
            export declare const VendorPack: string;
            export declare const VendorCcy: string;
            export declare const OriginQty: string;
            export declare const SltaxPcent: string;
            export declare const SltaxAmt: string;
            export declare const ReorderQty: string;
            export declare const IncludeScrapRate: string;
            export declare const MarkupPcent: string;
            export declare const Markup: string;
            export declare const ItemCode: string;
            export declare const MoldBomNo: string;
            export declare const MoldFormulaCode: string;
            export declare const MoldExpectedQty: string;
            export declare const Anlys15: string;
            export declare const Anlys16: string;
            export declare const Anlys17: string;
            export declare const Anlys18: string;
            export declare const Anlys19: string;
            export declare const Anlys20: string;
            export declare const ShipmarkRmk: string;
            export declare const LotSizeCost: string;
            export declare const ReleaseQty: string;
            export declare const BlanketRef: string;
            export declare const BlanketLineNo: string;
            export declare const OrderNoRecnum: string;
            export declare const OrderNoPosted: string;
            export declare const OrderNoClosed: string;
            export declare const OrderNoCustomerNo: string;
            export declare const OrderNoCustomerName: string;
            export declare const OrderNoOrderDate: string;
            export declare const OrderNoDueDate: string;
            export declare const OrderNoSchedDate: string;
            export declare const OrderNoCustomerPo: string;
            export declare const OrderNoShipTo: string;
            export declare const OrderNoAddress: string;
            export declare const OrderNoAddress2: string;
            export declare const OrderNoAddress3: string;
            export declare const OrderNoAddress4: string;
            export declare const OrderNoMultiShip: string;
            export declare const OrderNoAutoPo: string;
            export declare const OrderNoAutoJob: string;
            export declare const OrderNoComputeTax: string;
            export declare const OrderNoAutoResv: string;
            export declare const OrderNoAutoWait: string;
            export declare const OrderNoVendorNo: string;
            export declare const OrderNoPoNo: string;
            export declare const OrderNoPoPayTerms: string;
            export declare const OrderNoPoShipTo: string;
            export declare const OrderNoPoBuyer: string;
            export declare const OrderNoShipVia: string;
            export declare const OrderNoShipmentTerms: string;
            export declare const OrderNoSalesman: string;
            export declare const OrderNoPayTerms: string;
            export declare const OrderNoPriceCode: string;
            export declare const OrderNoAnlys1: string;
            export declare const OrderNoAnlys2: string;
            export declare const OrderNoCcy: string;
            export declare const OrderNoExchRate: string;
            export declare const OrderNoShipFrom: string;
            export declare const OrderNoLastSchedNo: string;
            export declare const OrderNoLastLineNo: string;
            export declare const OrderNoLastTextNo: string;
            export declare const OrderNoLastCtnNo: string;
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
            export declare const OrderNoDpsReceiptNo: string;
            export declare const OrderNoDpsFundCode: string;
            export declare const OrderNoDpsReference: string;
            export declare const OrderNoDpsRcptDate: string;
            export declare const OrderNoCreatedDate: string;
            export declare const OrderNoCreatedBy: string;
            export declare const OrderNoRevisedDate: string;
            export declare const OrderNoRevisedBy: string;
            export declare const OrderNoPostedDate: string;
            export declare const OrderNoPostedBy: string;
            export declare const OrderNoPrevisedDate: string;
            export declare const OrderNoPrevisedBy: string;
            export declare const OrderNoLockType: string;
            export declare const OrderNoLockRefNo: string;
            export declare const OrderNoLastLogNo: string;
            export declare const OrderNoVendTaxCode: string;
            export declare const OrderNoCustTaxCode: string;
            export declare const OrderNoPackingOk: string;
            export declare const OrderNoWeightUom: string;
            export declare const OrderNoGrWt: string;
            export declare const OrderNoNtWt: string;
            export declare const OrderNoDimensionUom: string;
            export declare const OrderNoVolume: string;
            export declare const OrderNoOwnerBranch: string;
            export declare const OrderNoSourceBranch: string;
            export declare const OrderNoComments1: string;
            export declare const OrderNoComments2: string;
            export declare const OrderNoComments3: string;
            export declare const OrderNoComments4: string;
            export declare const OrderNoCheckCrlimit: string;
            export declare const OrderNoCheckCrbal: string;
            export declare const OrderNoWebPublished: string;
            export declare const OrderNoSendWebMsg: string;
            export declare const OrderNoWebUserName: string;
            export declare const OrderNoAttention: string;
            export declare const OrderNoTelNo: string;
            export declare const OrderNoFaxNo: string;
            export declare const OrderNoPortLoading: string;
            export declare const OrderNoPortDischarge: string;
            export declare const OrderNoVesselName: string;
            export declare const OrderNoForwarder: string;
            export declare const OrderNoLcNo: string;
            export declare const OrderNoOriginCountry: string;
            export declare const OrderNoMrpExclude: string;
            export declare const OrderNoSltaxType: string;
            export declare const OrderNoGsltaxPcent: string;
            export declare const OrderNoTotGsltaxAmt: string;
            export declare const OrderNoTotLsltaxAmt: string;
            export declare const OrderNoLastTextNo1: string;
            export declare const OrderNoComments5: string;
            export declare const OrderNoComments6: string;
            export declare const OrderNoComments7: string;
            export declare const OrderNoComments8: string;
            export declare const OrderNoAnlys7: string;
            export declare const OrderNoAnlys8: string;
            export declare const OrderNoFlag: string;
            export declare const OrderNoHoldBy: string;
            export declare const OrderNoQuoRefNo: string;
            export declare const OrderNoBrandCode: string;
            export declare const OrderNoItemCode: string;
            export declare const OrderNoPkgUnit: string;
            export declare const OrderNoWeightUnit: string;
            export declare const OrderNoAnlys9: string;
            export declare const OrderNoAnlys10: string;
            export declare const OrderNoAnlys11: string;
            export declare const OrderNoAnlys12: string;
            export declare const OrderNoAnlys13: string;
            export declare const OrderNoAnlys14: string;
            export declare const OrderNoOrderType: string;
            export declare const OrderNoRefCompanyCode: string;
            export declare const OrderNoRefPurchaseOrderNo: string;
        }

        [
            'Recnum', 
            'OrderNo', 
            'LineNo', 
            'Posted', 
            'Closed', 
            'ItemNo', 
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
            'CommisType', 
            'CommisRefNo', 
            'Configurable', 
            'FirstShipQty', 
            'OtherShipQty', 
            'LastShipNo', 
            'Reserved', 
            'ResvStubNo', 
            'Waitlisted', 
            'WaitlistNo', 
            'WeightUom', 
            'GrossWt', 
            'NetWt', 
            'DimensionUom', 
            'Flength', 
            'Width', 
            'Height', 
            'UnitVolume', 
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
            'StartCtnNo', 
            'QtyShipped', 
            'ItemTaxCode', 
            'CustItemNo', 
            'SpecNo', 
            'BomNo', 
            'QtyPacked', 
            'JobNo', 
            'ProdBranch', 
            'AssemblyLine', 
            'ProdDueDate', 
            'MakeIt', 
            'ProdStartDate', 
            'SchedCount', 
            'StdAssort', 
            'ExtDescription', 
            'QtyPending', 
            'VendorNo', 
            'VendorPrice', 
            'VendorPack', 
            'VendorCcy', 
            'OriginQty', 
            'SltaxPcent', 
            'SltaxAmt', 
            'ReorderQty', 
            'IncludeScrapRate', 
            'MarkupPcent', 
            'Markup', 
            'ItemCode', 
            'MoldBomNo', 
            'MoldFormulaCode', 
            'MoldExpectedQty', 
            'Anlys15', 
            'Anlys16', 
            'Anlys17', 
            'Anlys18', 
            'Anlys19', 
            'Anlys20', 
            'ShipmarkRmk', 
            'LotSizeCost', 
            'ReleaseQty', 
            'BlanketRef', 
            'BlanketLineNo', 
            'OrderNoRecnum', 
            'OrderNoPosted', 
            'OrderNoClosed', 
            'OrderNoCustomerNo', 
            'OrderNoCustomerName', 
            'OrderNoOrderDate', 
            'OrderNoDueDate', 
            'OrderNoSchedDate', 
            'OrderNoCustomerPo', 
            'OrderNoShipTo', 
            'OrderNoAddress', 
            'OrderNoAddress2', 
            'OrderNoAddress3', 
            'OrderNoAddress4', 
            'OrderNoMultiShip', 
            'OrderNoAutoPo', 
            'OrderNoAutoJob', 
            'OrderNoComputeTax', 
            'OrderNoAutoResv', 
            'OrderNoAutoWait', 
            'OrderNoVendorNo', 
            'OrderNoPoNo', 
            'OrderNoPoPayTerms', 
            'OrderNoPoShipTo', 
            'OrderNoPoBuyer', 
            'OrderNoShipVia', 
            'OrderNoShipmentTerms', 
            'OrderNoSalesman', 
            'OrderNoPayTerms', 
            'OrderNoPriceCode', 
            'OrderNoAnlys1', 
            'OrderNoAnlys2', 
            'OrderNoCcy', 
            'OrderNoExchRate', 
            'OrderNoShipFrom', 
            'OrderNoLastSchedNo', 
            'OrderNoLastLineNo', 
            'OrderNoLastTextNo', 
            'OrderNoLastCtnNo', 
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
            'OrderNoDpsReceiptNo', 
            'OrderNoDpsFundCode', 
            'OrderNoDpsReference', 
            'OrderNoDpsRcptDate', 
            'OrderNoCreatedDate', 
            'OrderNoCreatedBy', 
            'OrderNoRevisedDate', 
            'OrderNoRevisedBy', 
            'OrderNoPostedDate', 
            'OrderNoPostedBy', 
            'OrderNoPrevisedDate', 
            'OrderNoPrevisedBy', 
            'OrderNoLockType', 
            'OrderNoLockRefNo', 
            'OrderNoLastLogNo', 
            'OrderNoVendTaxCode', 
            'OrderNoCustTaxCode', 
            'OrderNoPackingOk', 
            'OrderNoWeightUom', 
            'OrderNoGrWt', 
            'OrderNoNtWt', 
            'OrderNoDimensionUom', 
            'OrderNoVolume', 
            'OrderNoOwnerBranch', 
            'OrderNoSourceBranch', 
            'OrderNoComments1', 
            'OrderNoComments2', 
            'OrderNoComments3', 
            'OrderNoComments4', 
            'OrderNoCheckCrlimit', 
            'OrderNoCheckCrbal', 
            'OrderNoWebPublished', 
            'OrderNoSendWebMsg', 
            'OrderNoWebUserName', 
            'OrderNoAttention', 
            'OrderNoTelNo', 
            'OrderNoFaxNo', 
            'OrderNoPortLoading', 
            'OrderNoPortDischarge', 
            'OrderNoVesselName', 
            'OrderNoForwarder', 
            'OrderNoLcNo', 
            'OrderNoOriginCountry', 
            'OrderNoMrpExclude', 
            'OrderNoSltaxType', 
            'OrderNoGsltaxPcent', 
            'OrderNoTotGsltaxAmt', 
            'OrderNoTotLsltaxAmt', 
            'OrderNoLastTextNo1', 
            'OrderNoComments5', 
            'OrderNoComments6', 
            'OrderNoComments7', 
            'OrderNoComments8', 
            'OrderNoAnlys7', 
            'OrderNoAnlys8', 
            'OrderNoFlag', 
            'OrderNoHoldBy', 
            'OrderNoQuoRefNo', 
            'OrderNoBrandCode', 
            'OrderNoItemCode', 
            'OrderNoPkgUnit', 
            'OrderNoWeightUnit', 
            'OrderNoAnlys9', 
            'OrderNoAnlys10', 
            'OrderNoAnlys11', 
            'OrderNoAnlys12', 
            'OrderNoAnlys13', 
            'OrderNoAnlys14', 
            'OrderNoOrderType', 
            'OrderNoRefCompanyCode', 
            'OrderNoRefPurchaseOrderNo'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

