namespace Matrix.Sales {
    export interface ShipmentDetailRow {
        Recnum?: number;
        RefNo?: string;
        EntryNo?: number;
        Selected?: string;
        OrderNo?: string;
        LineNo?: number;
        ItemNo?: string;
        Description?: string;
        Uom?: string;
        LotSize?: number;
        Configurable?: string;
        QtyBalance?: number;
        QtyDue?: number;
        QtyShipped?: number;
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
        LdiscRate?: number;
        AtaxRate?: number;
        LdiscAmtCpd?: number;
        AtaxAmtCpd?: number;
        LocPriceAmt?: number;
        LocPtaxAmt?: number;
        LocExtPrice?: number;
        LocLdiscAmt?: number;
        LocAtaxAmt?: number;
        LocItemAmt?: number;
        Anlys1?: string;
        Anlys2?: string;
        Anlys3?: string;
        Anlys4?: string;
        Anlys5?: string;
        Anlys6?: string;
        Posted?: string;
        LogNo?: number;
        Returned?: string;
        ShipmentDate?: string;
        CustomerNo?: string;
        ShipFrom?: string;
        CommisType?: string;
        CommisRefNo?: string;
        CustItemNo?: string;
        AcctSales?: string;
        AcctLdisc?: string;
        AcctPtax?: string;
        AcctAtax?: string;
        ItemTaxCode?: string;
        QtyReturned?: number;
        RetPriceAmt?: number;
        RetPtaxAmt?: number;
        RetExtPrice?: number;
        RetLdiscAmt?: number;
        RetAtaxAmt?: number;
        RetItemAmt?: number;
        LretPriceAmt?: number;
        LretPtaxAmt?: number;
        LretExtPrice?: number;
        LretLdiscAmt?: number;
        LretAtaxAmt?: number;
        LretItemAmt?: number;
        QtyPacked?: number;
        CostReturned?: number;
        StdAssort?: string;
        ExtDescription?: string;
        VendorPack?: string;
        SltaxPcent?: number;
        SltaxAmt?: number;
        LocSltaxAmt?: number;
        AcctSltax?: string;
        MarkupPcent?: number;
        Markup?: number;
        Anlys15?: string;
        Anlys16?: string;
        Anlys17?: string;
        Anlys18?: string;
        Anlys19?: string;
        Anlys20?: string;
        LotSizeCost?: number;
        RefNoRecnum?: number;
        RefNoShipmentDate?: string;
        RefNoPosted?: string;
        RefNoReturned?: string;
        RefNoCustomerNo?: string;
        RefNoCustomerName?: string;
        RefNoShipTo?: string;
        RefNoAddress?: string;
        RefNoAddress2?: string;
        RefNoAddress3?: string;
        RefNoAddress4?: string;
        RefNoCutoffDate?: string;
        RefNoShipVia?: string;
        RefNoShipmentTerms?: string;
        RefNoVesselName?: string;
        RefNoEtd?: string;
        RefNoEta?: string;
        RefNoPayTerms?: string;
        RefNoDiscDays?: number;
        RefNoDiscPercent?: number;
        RefNoNetDays?: number;
        RefNoDiscountDate?: string;
        RefNoDueDate?: string;
        RefNoExpectedDate?: string;
        RefNoCcy?: string;
        RefNoExchRate?: number;
        RefNoShipFrom?: string;
        RefNoOwnerBranch?: string;
        RefNoSourceBranch?: string;
        RefNoComputeTax?: string;
        RefNoTotPriceAmt?: number;
        RefNoTotPtaxAmt?: number;
        RefNoTotExtPrice?: number;
        RefNoTotLdiscAmt?: number;
        RefNoTotAtaxAmt?: number;
        RefNoTotItemAmt?: number;
        RefNoTotTdiscAmt?: number;
        RefNoNetTradeAmt?: number;
        RefNoTotChgsAmt?: number;
        RefNoNetOrdrAmt?: number;
        RefNoTotGtaxAmt?: number;
        RefNoNetPayAmt?: number;
        RefNoDpsCover?: number;
        RefNoDpsApplied?: number;
        RefNoNetBalAmt?: number;
        RefNoCpdTdiscAmt?: number;
        RefNoCpdGtaxAmt?: number;
        RefNoCpdDpsAmt?: number;
        RefNoLocPriceAmt?: number;
        RefNoLocPtaxAmt?: number;
        RefNoLocExtPrice?: number;
        RefNoLocLdiscAmt?: number;
        RefNoLocAtaxAmt?: number;
        RefNoLocItemAmt?: number;
        RefNoLocTdiscAmt?: number;
        RefNoLocChgsAmt?: number;
        RefNoLocGtaxAmt?: number;
        RefNoLocPayAmt?: number;
        RefNoLocDpsApplied?: number;
        RefNoCreatedDate?: string;
        RefNoCreatedBy?: string;
        RefNoRevisedDate?: string;
        RefNoRevisedBy?: string;
        RefNoPostedDate?: string;
        RefNoPostedBy?: string;
        RefNoPrevisedDate?: string;
        RefNoPrevisedBy?: string;
        RefNoLastEntryNo?: number;
        RefNoLastChgsNo?: number;
        RefNoLastTextNo?: number;
        RefNoLastCtnNo?: number;
        RefNoLockType?: string;
        RefNoLockRefNo?: string;
        RefNoLastLogNo?: number;
        RefNoNewItemCount?: number;
        RefNoNewChgsCount?: number;
        RefNoAcctCustomer?: string;
        RefNoAcctTdisc?: string;
        RefNoAcctGtax?: string;
        RefNoDpsApplyRef?: string;
        RefNoVendTaxCode?: string;
        RefNoCustTaxCode?: string;
        RefNoRetPriceAmt?: number;
        RefNoRetPtaxAmt?: number;
        RefNoRetExtPrice?: number;
        RefNoRetLdiscAmt?: number;
        RefNoRetAtaxAmt?: number;
        RefNoRetItemAmt?: number;
        RefNoRetTdiscAmt?: number;
        RefNoRetGtaxAmt?: number;
        RefNoRetChgsAmt?: number;
        RefNoRetPayAmt?: number;
        RefNoLretPriceAmt?: number;
        RefNoLretPtaxAmt?: number;
        RefNoLretExtPrice?: number;
        RefNoLretLdiscAmt?: number;
        RefNoLretAtaxAmt?: number;
        RefNoLretItemAmt?: number;
        RefNoLretTdiscAmt?: number;
        RefNoLretGtaxAmt?: number;
        RefNoLretChgsAmt?: number;
        RefNoLretPayAmt?: number;
        RefNoWeightUom?: string;
        RefNoGrWt?: number;
        RefNoNtWt?: number;
        RefNoDimensionUom?: string;
        RefNoVolume?: number;
        RefNoGlLink?: string;
        RefNoGlLinkType?: string;
        RefNoGlLinkNo?: string;
        RefNoPackingOk?: string;
        RefNoComments1?: string;
        RefNoComments2?: string;
        RefNoComments3?: string;
        RefNoComments4?: string;
        RefNoSettleAt?: string;
        RefNoCheckCrlimit?: string;
        RefNoCheckCrbal?: number;
        RefNoAttention?: string;
        RefNoTelNo?: string;
        RefNoFaxNo?: string;
        RefNoPortLoading?: string;
        RefNoPortDischarge?: string;
        RefNoForwarder?: string;
        RefNoLcNo?: string;
        RefNoOriginCountry?: string;
        RefNoComments5?: string;
        RefNoComments6?: string;
        RefNoComments7?: string;
        RefNoComments8?: string;
        RefNoIssueBank?: string;
        RefNoIssueDate?: string;
        RefNoSltaxType?: string;
        RefNoGsltaxPcent?: number;
        RefNoTotGsltaxAmt?: number;
        RefNoTotLsltaxAmt?: number;
        RefNoLocGsltaxAmt?: number;
        RefNoLocLsltaxAmt?: number;
        RefNoSoSltaxType?: string;
        RefNoSoGsltaxPcent?: number;
        RefNoOrderCount?: number;
        RefNoAcctSltax?: string;
        RefNoLastTextNo1?: number;
        RefNoAnlys1?: string;
        RefNoAnlys2?: string;
        RefNoAnlys7?: string;
        RefNoAnlys8?: string;
        RefNoDnOnly?: string;
        RefNoInvoiced?: string;
        RefNoInvoiceNo?: string;
        RefNoFlag?: string;
        RefNoHoldBy?: string;
        RefNoAnlys9?: string;
        RefNoAnlys10?: string;
        RefNoAnlys11?: string;
        RefNoAnlys12?: string;
        RefNoAnlys13?: string;
        RefNoAnlys14?: string;
        RefNoManualShipmentDetail?: boolean;
        RefNoRefCompanyCode?: string;
        RefNoRefGrnNo?: string;
        RefNoLcName?: string;
    }

    export namespace ShipmentDetailRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'RefNo';
        export const localTextPrefix = 'Sales.ShipmentDetail';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const RefNo: string;
            export declare const EntryNo: string;
            export declare const Selected: string;
            export declare const OrderNo: string;
            export declare const LineNo: string;
            export declare const ItemNo: string;
            export declare const Description: string;
            export declare const Uom: string;
            export declare const LotSize: string;
            export declare const Configurable: string;
            export declare const QtyBalance: string;
            export declare const QtyDue: string;
            export declare const QtyShipped: string;
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
            export declare const LdiscRate: string;
            export declare const AtaxRate: string;
            export declare const LdiscAmtCpd: string;
            export declare const AtaxAmtCpd: string;
            export declare const LocPriceAmt: string;
            export declare const LocPtaxAmt: string;
            export declare const LocExtPrice: string;
            export declare const LocLdiscAmt: string;
            export declare const LocAtaxAmt: string;
            export declare const LocItemAmt: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const Anlys3: string;
            export declare const Anlys4: string;
            export declare const Anlys5: string;
            export declare const Anlys6: string;
            export declare const Posted: string;
            export declare const LogNo: string;
            export declare const Returned: string;
            export declare const ShipmentDate: string;
            export declare const CustomerNo: string;
            export declare const ShipFrom: string;
            export declare const CommisType: string;
            export declare const CommisRefNo: string;
            export declare const CustItemNo: string;
            export declare const AcctSales: string;
            export declare const AcctLdisc: string;
            export declare const AcctPtax: string;
            export declare const AcctAtax: string;
            export declare const ItemTaxCode: string;
            export declare const QtyReturned: string;
            export declare const RetPriceAmt: string;
            export declare const RetPtaxAmt: string;
            export declare const RetExtPrice: string;
            export declare const RetLdiscAmt: string;
            export declare const RetAtaxAmt: string;
            export declare const RetItemAmt: string;
            export declare const LretPriceAmt: string;
            export declare const LretPtaxAmt: string;
            export declare const LretExtPrice: string;
            export declare const LretLdiscAmt: string;
            export declare const LretAtaxAmt: string;
            export declare const LretItemAmt: string;
            export declare const QtyPacked: string;
            export declare const CostReturned: string;
            export declare const StdAssort: string;
            export declare const ExtDescription: string;
            export declare const VendorPack: string;
            export declare const SltaxPcent: string;
            export declare const SltaxAmt: string;
            export declare const LocSltaxAmt: string;
            export declare const AcctSltax: string;
            export declare const MarkupPcent: string;
            export declare const Markup: string;
            export declare const Anlys15: string;
            export declare const Anlys16: string;
            export declare const Anlys17: string;
            export declare const Anlys18: string;
            export declare const Anlys19: string;
            export declare const Anlys20: string;
            export declare const LotSizeCost: string;
            export declare const RefNoRecnum: string;
            export declare const RefNoShipmentDate: string;
            export declare const RefNoPosted: string;
            export declare const RefNoReturned: string;
            export declare const RefNoCustomerNo: string;
            export declare const RefNoCustomerName: string;
            export declare const RefNoShipTo: string;
            export declare const RefNoAddress: string;
            export declare const RefNoAddress2: string;
            export declare const RefNoAddress3: string;
            export declare const RefNoAddress4: string;
            export declare const RefNoCutoffDate: string;
            export declare const RefNoShipVia: string;
            export declare const RefNoShipmentTerms: string;
            export declare const RefNoVesselName: string;
            export declare const RefNoEtd: string;
            export declare const RefNoEta: string;
            export declare const RefNoPayTerms: string;
            export declare const RefNoDiscDays: string;
            export declare const RefNoDiscPercent: string;
            export declare const RefNoNetDays: string;
            export declare const RefNoDiscountDate: string;
            export declare const RefNoDueDate: string;
            export declare const RefNoExpectedDate: string;
            export declare const RefNoCcy: string;
            export declare const RefNoExchRate: string;
            export declare const RefNoShipFrom: string;
            export declare const RefNoOwnerBranch: string;
            export declare const RefNoSourceBranch: string;
            export declare const RefNoComputeTax: string;
            export declare const RefNoTotPriceAmt: string;
            export declare const RefNoTotPtaxAmt: string;
            export declare const RefNoTotExtPrice: string;
            export declare const RefNoTotLdiscAmt: string;
            export declare const RefNoTotAtaxAmt: string;
            export declare const RefNoTotItemAmt: string;
            export declare const RefNoTotTdiscAmt: string;
            export declare const RefNoNetTradeAmt: string;
            export declare const RefNoTotChgsAmt: string;
            export declare const RefNoNetOrdrAmt: string;
            export declare const RefNoTotGtaxAmt: string;
            export declare const RefNoNetPayAmt: string;
            export declare const RefNoDpsCover: string;
            export declare const RefNoDpsApplied: string;
            export declare const RefNoNetBalAmt: string;
            export declare const RefNoCpdTdiscAmt: string;
            export declare const RefNoCpdGtaxAmt: string;
            export declare const RefNoCpdDpsAmt: string;
            export declare const RefNoLocPriceAmt: string;
            export declare const RefNoLocPtaxAmt: string;
            export declare const RefNoLocExtPrice: string;
            export declare const RefNoLocLdiscAmt: string;
            export declare const RefNoLocAtaxAmt: string;
            export declare const RefNoLocItemAmt: string;
            export declare const RefNoLocTdiscAmt: string;
            export declare const RefNoLocChgsAmt: string;
            export declare const RefNoLocGtaxAmt: string;
            export declare const RefNoLocPayAmt: string;
            export declare const RefNoLocDpsApplied: string;
            export declare const RefNoCreatedDate: string;
            export declare const RefNoCreatedBy: string;
            export declare const RefNoRevisedDate: string;
            export declare const RefNoRevisedBy: string;
            export declare const RefNoPostedDate: string;
            export declare const RefNoPostedBy: string;
            export declare const RefNoPrevisedDate: string;
            export declare const RefNoPrevisedBy: string;
            export declare const RefNoLastEntryNo: string;
            export declare const RefNoLastChgsNo: string;
            export declare const RefNoLastTextNo: string;
            export declare const RefNoLastCtnNo: string;
            export declare const RefNoLockType: string;
            export declare const RefNoLockRefNo: string;
            export declare const RefNoLastLogNo: string;
            export declare const RefNoNewItemCount: string;
            export declare const RefNoNewChgsCount: string;
            export declare const RefNoAcctCustomer: string;
            export declare const RefNoAcctTdisc: string;
            export declare const RefNoAcctGtax: string;
            export declare const RefNoDpsApplyRef: string;
            export declare const RefNoVendTaxCode: string;
            export declare const RefNoCustTaxCode: string;
            export declare const RefNoRetPriceAmt: string;
            export declare const RefNoRetPtaxAmt: string;
            export declare const RefNoRetExtPrice: string;
            export declare const RefNoRetLdiscAmt: string;
            export declare const RefNoRetAtaxAmt: string;
            export declare const RefNoRetItemAmt: string;
            export declare const RefNoRetTdiscAmt: string;
            export declare const RefNoRetGtaxAmt: string;
            export declare const RefNoRetChgsAmt: string;
            export declare const RefNoRetPayAmt: string;
            export declare const RefNoLretPriceAmt: string;
            export declare const RefNoLretPtaxAmt: string;
            export declare const RefNoLretExtPrice: string;
            export declare const RefNoLretLdiscAmt: string;
            export declare const RefNoLretAtaxAmt: string;
            export declare const RefNoLretItemAmt: string;
            export declare const RefNoLretTdiscAmt: string;
            export declare const RefNoLretGtaxAmt: string;
            export declare const RefNoLretChgsAmt: string;
            export declare const RefNoLretPayAmt: string;
            export declare const RefNoWeightUom: string;
            export declare const RefNoGrWt: string;
            export declare const RefNoNtWt: string;
            export declare const RefNoDimensionUom: string;
            export declare const RefNoVolume: string;
            export declare const RefNoGlLink: string;
            export declare const RefNoGlLinkType: string;
            export declare const RefNoGlLinkNo: string;
            export declare const RefNoPackingOk: string;
            export declare const RefNoComments1: string;
            export declare const RefNoComments2: string;
            export declare const RefNoComments3: string;
            export declare const RefNoComments4: string;
            export declare const RefNoSettleAt: string;
            export declare const RefNoCheckCrlimit: string;
            export declare const RefNoCheckCrbal: string;
            export declare const RefNoAttention: string;
            export declare const RefNoTelNo: string;
            export declare const RefNoFaxNo: string;
            export declare const RefNoPortLoading: string;
            export declare const RefNoPortDischarge: string;
            export declare const RefNoForwarder: string;
            export declare const RefNoLcNo: string;
            export declare const RefNoOriginCountry: string;
            export declare const RefNoComments5: string;
            export declare const RefNoComments6: string;
            export declare const RefNoComments7: string;
            export declare const RefNoComments8: string;
            export declare const RefNoIssueBank: string;
            export declare const RefNoIssueDate: string;
            export declare const RefNoSltaxType: string;
            export declare const RefNoGsltaxPcent: string;
            export declare const RefNoTotGsltaxAmt: string;
            export declare const RefNoTotLsltaxAmt: string;
            export declare const RefNoLocGsltaxAmt: string;
            export declare const RefNoLocLsltaxAmt: string;
            export declare const RefNoSoSltaxType: string;
            export declare const RefNoSoGsltaxPcent: string;
            export declare const RefNoOrderCount: string;
            export declare const RefNoAcctSltax: string;
            export declare const RefNoLastTextNo1: string;
            export declare const RefNoAnlys1: string;
            export declare const RefNoAnlys2: string;
            export declare const RefNoAnlys7: string;
            export declare const RefNoAnlys8: string;
            export declare const RefNoDnOnly: string;
            export declare const RefNoInvoiced: string;
            export declare const RefNoInvoiceNo: string;
            export declare const RefNoFlag: string;
            export declare const RefNoHoldBy: string;
            export declare const RefNoAnlys9: string;
            export declare const RefNoAnlys10: string;
            export declare const RefNoAnlys11: string;
            export declare const RefNoAnlys12: string;
            export declare const RefNoAnlys13: string;
            export declare const RefNoAnlys14: string;
            export declare const RefNoManualShipmentDetail: string;
            export declare const RefNoRefCompanyCode: string;
            export declare const RefNoRefGrnNo: string;
            export declare const RefNoLcName: string;
        }

        [
            'Recnum', 
            'RefNo', 
            'EntryNo', 
            'Selected', 
            'OrderNo', 
            'LineNo', 
            'ItemNo', 
            'Description', 
            'Uom', 
            'LotSize', 
            'Configurable', 
            'QtyBalance', 
            'QtyDue', 
            'QtyShipped', 
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
            'LdiscRate', 
            'AtaxRate', 
            'LdiscAmtCpd', 
            'AtaxAmtCpd', 
            'LocPriceAmt', 
            'LocPtaxAmt', 
            'LocExtPrice', 
            'LocLdiscAmt', 
            'LocAtaxAmt', 
            'LocItemAmt', 
            'Anlys1', 
            'Anlys2', 
            'Anlys3', 
            'Anlys4', 
            'Anlys5', 
            'Anlys6', 
            'Posted', 
            'LogNo', 
            'Returned', 
            'ShipmentDate', 
            'CustomerNo', 
            'ShipFrom', 
            'CommisType', 
            'CommisRefNo', 
            'CustItemNo', 
            'AcctSales', 
            'AcctLdisc', 
            'AcctPtax', 
            'AcctAtax', 
            'ItemTaxCode', 
            'QtyReturned', 
            'RetPriceAmt', 
            'RetPtaxAmt', 
            'RetExtPrice', 
            'RetLdiscAmt', 
            'RetAtaxAmt', 
            'RetItemAmt', 
            'LretPriceAmt', 
            'LretPtaxAmt', 
            'LretExtPrice', 
            'LretLdiscAmt', 
            'LretAtaxAmt', 
            'LretItemAmt', 
            'QtyPacked', 
            'CostReturned', 
            'StdAssort', 
            'ExtDescription', 
            'VendorPack', 
            'SltaxPcent', 
            'SltaxAmt', 
            'LocSltaxAmt', 
            'AcctSltax', 
            'MarkupPcent', 
            'Markup', 
            'Anlys15', 
            'Anlys16', 
            'Anlys17', 
            'Anlys18', 
            'Anlys19', 
            'Anlys20', 
            'LotSizeCost', 
            'RefNoRecnum', 
            'RefNoShipmentDate', 
            'RefNoPosted', 
            'RefNoReturned', 
            'RefNoCustomerNo', 
            'RefNoCustomerName', 
            'RefNoShipTo', 
            'RefNoAddress', 
            'RefNoAddress2', 
            'RefNoAddress3', 
            'RefNoAddress4', 
            'RefNoCutoffDate', 
            'RefNoShipVia', 
            'RefNoShipmentTerms', 
            'RefNoVesselName', 
            'RefNoEtd', 
            'RefNoEta', 
            'RefNoPayTerms', 
            'RefNoDiscDays', 
            'RefNoDiscPercent', 
            'RefNoNetDays', 
            'RefNoDiscountDate', 
            'RefNoDueDate', 
            'RefNoExpectedDate', 
            'RefNoCcy', 
            'RefNoExchRate', 
            'RefNoShipFrom', 
            'RefNoOwnerBranch', 
            'RefNoSourceBranch', 
            'RefNoComputeTax', 
            'RefNoTotPriceAmt', 
            'RefNoTotPtaxAmt', 
            'RefNoTotExtPrice', 
            'RefNoTotLdiscAmt', 
            'RefNoTotAtaxAmt', 
            'RefNoTotItemAmt', 
            'RefNoTotTdiscAmt', 
            'RefNoNetTradeAmt', 
            'RefNoTotChgsAmt', 
            'RefNoNetOrdrAmt', 
            'RefNoTotGtaxAmt', 
            'RefNoNetPayAmt', 
            'RefNoDpsCover', 
            'RefNoDpsApplied', 
            'RefNoNetBalAmt', 
            'RefNoCpdTdiscAmt', 
            'RefNoCpdGtaxAmt', 
            'RefNoCpdDpsAmt', 
            'RefNoLocPriceAmt', 
            'RefNoLocPtaxAmt', 
            'RefNoLocExtPrice', 
            'RefNoLocLdiscAmt', 
            'RefNoLocAtaxAmt', 
            'RefNoLocItemAmt', 
            'RefNoLocTdiscAmt', 
            'RefNoLocChgsAmt', 
            'RefNoLocGtaxAmt', 
            'RefNoLocPayAmt', 
            'RefNoLocDpsApplied', 
            'RefNoCreatedDate', 
            'RefNoCreatedBy', 
            'RefNoRevisedDate', 
            'RefNoRevisedBy', 
            'RefNoPostedDate', 
            'RefNoPostedBy', 
            'RefNoPrevisedDate', 
            'RefNoPrevisedBy', 
            'RefNoLastEntryNo', 
            'RefNoLastChgsNo', 
            'RefNoLastTextNo', 
            'RefNoLastCtnNo', 
            'RefNoLockType', 
            'RefNoLockRefNo', 
            'RefNoLastLogNo', 
            'RefNoNewItemCount', 
            'RefNoNewChgsCount', 
            'RefNoAcctCustomer', 
            'RefNoAcctTdisc', 
            'RefNoAcctGtax', 
            'RefNoDpsApplyRef', 
            'RefNoVendTaxCode', 
            'RefNoCustTaxCode', 
            'RefNoRetPriceAmt', 
            'RefNoRetPtaxAmt', 
            'RefNoRetExtPrice', 
            'RefNoRetLdiscAmt', 
            'RefNoRetAtaxAmt', 
            'RefNoRetItemAmt', 
            'RefNoRetTdiscAmt', 
            'RefNoRetGtaxAmt', 
            'RefNoRetChgsAmt', 
            'RefNoRetPayAmt', 
            'RefNoLretPriceAmt', 
            'RefNoLretPtaxAmt', 
            'RefNoLretExtPrice', 
            'RefNoLretLdiscAmt', 
            'RefNoLretAtaxAmt', 
            'RefNoLretItemAmt', 
            'RefNoLretTdiscAmt', 
            'RefNoLretGtaxAmt', 
            'RefNoLretChgsAmt', 
            'RefNoLretPayAmt', 
            'RefNoWeightUom', 
            'RefNoGrWt', 
            'RefNoNtWt', 
            'RefNoDimensionUom', 
            'RefNoVolume', 
            'RefNoGlLink', 
            'RefNoGlLinkType', 
            'RefNoGlLinkNo', 
            'RefNoPackingOk', 
            'RefNoComments1', 
            'RefNoComments2', 
            'RefNoComments3', 
            'RefNoComments4', 
            'RefNoSettleAt', 
            'RefNoCheckCrlimit', 
            'RefNoCheckCrbal', 
            'RefNoAttention', 
            'RefNoTelNo', 
            'RefNoFaxNo', 
            'RefNoPortLoading', 
            'RefNoPortDischarge', 
            'RefNoForwarder', 
            'RefNoLcNo', 
            'RefNoOriginCountry', 
            'RefNoComments5', 
            'RefNoComments6', 
            'RefNoComments7', 
            'RefNoComments8', 
            'RefNoIssueBank', 
            'RefNoIssueDate', 
            'RefNoSltaxType', 
            'RefNoGsltaxPcent', 
            'RefNoTotGsltaxAmt', 
            'RefNoTotLsltaxAmt', 
            'RefNoLocGsltaxAmt', 
            'RefNoLocLsltaxAmt', 
            'RefNoSoSltaxType', 
            'RefNoSoGsltaxPcent', 
            'RefNoOrderCount', 
            'RefNoAcctSltax', 
            'RefNoLastTextNo1', 
            'RefNoAnlys1', 
            'RefNoAnlys2', 
            'RefNoAnlys7', 
            'RefNoAnlys8', 
            'RefNoDnOnly', 
            'RefNoInvoiced', 
            'RefNoInvoiceNo', 
            'RefNoFlag', 
            'RefNoHoldBy', 
            'RefNoAnlys9', 
            'RefNoAnlys10', 
            'RefNoAnlys11', 
            'RefNoAnlys12', 
            'RefNoAnlys13', 
            'RefNoAnlys14', 
            'RefNoManualShipmentDetail', 
            'RefNoRefCompanyCode', 
            'RefNoRefGrnNo', 
            'RefNoLcName'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

