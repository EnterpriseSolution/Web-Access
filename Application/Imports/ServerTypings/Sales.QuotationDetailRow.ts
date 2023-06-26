namespace Matrix.Sales {
    export interface QuotationDetailRow {
        Recnum?: number;
        RefNo?: string;
        LineNo?: number;
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
        PriceCpd?: number;
        PtaxCpd?: number;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        Configurable?: string;
        CustItemNo?: string;
        SpecNo?: string;
        BomNo?: string;
        StdAssort?: string;
        ExtDescription?: string;
        SltaxPcent?: number;
        SltaxAmt?: number;
        Anlys3?: string;
        Anlys4?: string;
        Anlys5?: string;
        Anlys6?: string;
        MarkupPcent?: number;
        Markup?: number;
        MoldBomNo?: string;
        MoldFormulaCode?: string;
        MoldExpectedQty?: number;
        Anlys15?: string;
        Anlys16?: string;
        Anlys17?: string;
        Anlys18?: string;
        Anlys19?: string;
        Anlys20?: string;
        RefNoRecnum?: number;
        RefNoIssueDate?: string;
        RefNoValidUntil?: string;
        RefNoClosed?: string;
        RefNoCustomerNo?: string;
        RefNoCustomerName?: string;
        RefNoAddress?: string;
        RefNoAddress2?: string;
        RefNoAddress3?: string;
        RefNoAddress4?: string;
        RefNoAttention?: string;
        RefNoShipVia?: string;
        RefNoShipmentTerms?: string;
        RefNoBaseLoc?: string;
        RefNoSalesman?: string;
        RefNoPayTerms?: string;
        RefNoPriceCode?: string;
        RefNoAnlys1?: string;
        RefNoAnlys2?: string;
        RefNoCcy?: string;
        RefNoExchRate?: number;
        RefNoComputeTax?: string;
        RefNoLastLineNo?: number;
        RefNoLastMailNo?: number;
        RefNoLastTextNo?: number;
        RefNoTotPriceAmt?: number;
        RefNoTotPtaxAmt?: number;
        RefNoTotExtPrice?: number;
        RefNoTotLdiscAmt?: number;
        RefNoTotAtaxAmt?: number;
        RefNoTotItemAmt?: number;
        RefNoTdiscPcent?: number;
        RefNoTotTdiscAmt?: number;
        RefNoNetTradeAmt?: number;
        RefNoTotChgsAmt?: number;
        RefNoNetOrdrAmt?: number;
        RefNoTotGtaxAmt?: number;
        RefNoNetPayAmt?: number;
        RefNoDpsPcent?: number;
        RefNoTotDpsAmt?: number;
        RefNoCreatedDate?: string;
        RefNoCreatedBy?: string;
        RefNoRevisedDate?: string;
        RefNoRevisedBy?: string;
        RefNoTotTdiscCpd?: number;
        RefNoTotGtaxCpd?: number;
        RefNoTotDpsCpd?: number;
        RefNoClosedDate?: string;
        RefNoClosedBy?: string;
        RefNoComments1?: string;
        RefNoComments2?: string;
        RefNoComments3?: string;
        RefNoComments4?: string;
        RefNoWebPublished?: string;
        RefNoConfirmed?: string;
        RefNoRfqNo?: string;
        RefNoWebUserName?: string;
        RefNoShipTo?: string;
        RefNoTelNo?: string;
        RefNoFaxNo?: string;
        RefNoPortLoading?: string;
        RefNoPortDischarge?: string;
        RefNoOriginCountry?: string;
        RefNoSltaxType?: string;
        RefNoGsltaxPcent?: number;
        RefNoTotGsltaxAmt?: number;
        RefNoTotLsltaxAmt?: number;
        RefNoAnlys7?: string;
        RefNoAnlys8?: string;
        RefNoMarkupDecimal?: number;
        RefNoPkgUnit?: string;
        RefNoWeightUnit?: string;
        RefNoAnlys9?: string;
        RefNoAnlys10?: string;
        RefNoAnlys11?: string;
        RefNoAnlys12?: string;
        RefNoAnlys13?: string;
        RefNoAnlys14?: string;
        RefNoItemCode?: string;
        RefNoTransport?: string;
    }

    export namespace QuotationDetailRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'RefNo';
        export const localTextPrefix = 'Sales.QuotationDetail';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const RefNo: string;
            export declare const LineNo: string;
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
            export declare const PriceCpd: string;
            export declare const PtaxCpd: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const Configurable: string;
            export declare const CustItemNo: string;
            export declare const SpecNo: string;
            export declare const BomNo: string;
            export declare const StdAssort: string;
            export declare const ExtDescription: string;
            export declare const SltaxPcent: string;
            export declare const SltaxAmt: string;
            export declare const Anlys3: string;
            export declare const Anlys4: string;
            export declare const Anlys5: string;
            export declare const Anlys6: string;
            export declare const MarkupPcent: string;
            export declare const Markup: string;
            export declare const MoldBomNo: string;
            export declare const MoldFormulaCode: string;
            export declare const MoldExpectedQty: string;
            export declare const Anlys15: string;
            export declare const Anlys16: string;
            export declare const Anlys17: string;
            export declare const Anlys18: string;
            export declare const Anlys19: string;
            export declare const Anlys20: string;
            export declare const RefNoRecnum: string;
            export declare const RefNoIssueDate: string;
            export declare const RefNoValidUntil: string;
            export declare const RefNoClosed: string;
            export declare const RefNoCustomerNo: string;
            export declare const RefNoCustomerName: string;
            export declare const RefNoAddress: string;
            export declare const RefNoAddress2: string;
            export declare const RefNoAddress3: string;
            export declare const RefNoAddress4: string;
            export declare const RefNoAttention: string;
            export declare const RefNoShipVia: string;
            export declare const RefNoShipmentTerms: string;
            export declare const RefNoBaseLoc: string;
            export declare const RefNoSalesman: string;
            export declare const RefNoPayTerms: string;
            export declare const RefNoPriceCode: string;
            export declare const RefNoAnlys1: string;
            export declare const RefNoAnlys2: string;
            export declare const RefNoCcy: string;
            export declare const RefNoExchRate: string;
            export declare const RefNoComputeTax: string;
            export declare const RefNoLastLineNo: string;
            export declare const RefNoLastMailNo: string;
            export declare const RefNoLastTextNo: string;
            export declare const RefNoTotPriceAmt: string;
            export declare const RefNoTotPtaxAmt: string;
            export declare const RefNoTotExtPrice: string;
            export declare const RefNoTotLdiscAmt: string;
            export declare const RefNoTotAtaxAmt: string;
            export declare const RefNoTotItemAmt: string;
            export declare const RefNoTdiscPcent: string;
            export declare const RefNoTotTdiscAmt: string;
            export declare const RefNoNetTradeAmt: string;
            export declare const RefNoTotChgsAmt: string;
            export declare const RefNoNetOrdrAmt: string;
            export declare const RefNoTotGtaxAmt: string;
            export declare const RefNoNetPayAmt: string;
            export declare const RefNoDpsPcent: string;
            export declare const RefNoTotDpsAmt: string;
            export declare const RefNoCreatedDate: string;
            export declare const RefNoCreatedBy: string;
            export declare const RefNoRevisedDate: string;
            export declare const RefNoRevisedBy: string;
            export declare const RefNoTotTdiscCpd: string;
            export declare const RefNoTotGtaxCpd: string;
            export declare const RefNoTotDpsCpd: string;
            export declare const RefNoClosedDate: string;
            export declare const RefNoClosedBy: string;
            export declare const RefNoComments1: string;
            export declare const RefNoComments2: string;
            export declare const RefNoComments3: string;
            export declare const RefNoComments4: string;
            export declare const RefNoWebPublished: string;
            export declare const RefNoConfirmed: string;
            export declare const RefNoRfqNo: string;
            export declare const RefNoWebUserName: string;
            export declare const RefNoShipTo: string;
            export declare const RefNoTelNo: string;
            export declare const RefNoFaxNo: string;
            export declare const RefNoPortLoading: string;
            export declare const RefNoPortDischarge: string;
            export declare const RefNoOriginCountry: string;
            export declare const RefNoSltaxType: string;
            export declare const RefNoGsltaxPcent: string;
            export declare const RefNoTotGsltaxAmt: string;
            export declare const RefNoTotLsltaxAmt: string;
            export declare const RefNoAnlys7: string;
            export declare const RefNoAnlys8: string;
            export declare const RefNoMarkupDecimal: string;
            export declare const RefNoPkgUnit: string;
            export declare const RefNoWeightUnit: string;
            export declare const RefNoAnlys9: string;
            export declare const RefNoAnlys10: string;
            export declare const RefNoAnlys11: string;
            export declare const RefNoAnlys12: string;
            export declare const RefNoAnlys13: string;
            export declare const RefNoAnlys14: string;
            export declare const RefNoItemCode: string;
            export declare const RefNoTransport: string;
        }

        [
            'Recnum', 
            'RefNo', 
            'LineNo', 
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
            'PriceCpd', 
            'PtaxCpd', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'Configurable', 
            'CustItemNo', 
            'SpecNo', 
            'BomNo', 
            'StdAssort', 
            'ExtDescription', 
            'SltaxPcent', 
            'SltaxAmt', 
            'Anlys3', 
            'Anlys4', 
            'Anlys5', 
            'Anlys6', 
            'MarkupPcent', 
            'Markup', 
            'MoldBomNo', 
            'MoldFormulaCode', 
            'MoldExpectedQty', 
            'Anlys15', 
            'Anlys16', 
            'Anlys17', 
            'Anlys18', 
            'Anlys19', 
            'Anlys20', 
            'RefNoRecnum', 
            'RefNoIssueDate', 
            'RefNoValidUntil', 
            'RefNoClosed', 
            'RefNoCustomerNo', 
            'RefNoCustomerName', 
            'RefNoAddress', 
            'RefNoAddress2', 
            'RefNoAddress3', 
            'RefNoAddress4', 
            'RefNoAttention', 
            'RefNoShipVia', 
            'RefNoShipmentTerms', 
            'RefNoBaseLoc', 
            'RefNoSalesman', 
            'RefNoPayTerms', 
            'RefNoPriceCode', 
            'RefNoAnlys1', 
            'RefNoAnlys2', 
            'RefNoCcy', 
            'RefNoExchRate', 
            'RefNoComputeTax', 
            'RefNoLastLineNo', 
            'RefNoLastMailNo', 
            'RefNoLastTextNo', 
            'RefNoTotPriceAmt', 
            'RefNoTotPtaxAmt', 
            'RefNoTotExtPrice', 
            'RefNoTotLdiscAmt', 
            'RefNoTotAtaxAmt', 
            'RefNoTotItemAmt', 
            'RefNoTdiscPcent', 
            'RefNoTotTdiscAmt', 
            'RefNoNetTradeAmt', 
            'RefNoTotChgsAmt', 
            'RefNoNetOrdrAmt', 
            'RefNoTotGtaxAmt', 
            'RefNoNetPayAmt', 
            'RefNoDpsPcent', 
            'RefNoTotDpsAmt', 
            'RefNoCreatedDate', 
            'RefNoCreatedBy', 
            'RefNoRevisedDate', 
            'RefNoRevisedBy', 
            'RefNoTotTdiscCpd', 
            'RefNoTotGtaxCpd', 
            'RefNoTotDpsCpd', 
            'RefNoClosedDate', 
            'RefNoClosedBy', 
            'RefNoComments1', 
            'RefNoComments2', 
            'RefNoComments3', 
            'RefNoComments4', 
            'RefNoWebPublished', 
            'RefNoConfirmed', 
            'RefNoRfqNo', 
            'RefNoWebUserName', 
            'RefNoShipTo', 
            'RefNoTelNo', 
            'RefNoFaxNo', 
            'RefNoPortLoading', 
            'RefNoPortDischarge', 
            'RefNoOriginCountry', 
            'RefNoSltaxType', 
            'RefNoGsltaxPcent', 
            'RefNoTotGsltaxAmt', 
            'RefNoTotLsltaxAmt', 
            'RefNoAnlys7', 
            'RefNoAnlys8', 
            'RefNoMarkupDecimal', 
            'RefNoPkgUnit', 
            'RefNoWeightUnit', 
            'RefNoAnlys9', 
            'RefNoAnlys10', 
            'RefNoAnlys11', 
            'RefNoAnlys12', 
            'RefNoAnlys13', 
            'RefNoAnlys14', 
            'RefNoItemCode', 
            'RefNoTransport'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

