namespace Matrix.Finance {
    export interface AccountsReceivableInvoiceRow {
        OrderList?: AccountsReceivableInvoiceOrderRow[];
        DetailList?: AccountsReceivableInvoiceDetailRow[];
        CommissionList?: AccountsReceivableCommissionRow[];
        Recnum?: number;
        InvoiceNo?: string;
        DirectEntry?: string;
        Posted?: string;
        Closed?: string;
        Returned?: string;
        DebitNote?: string;
        CustomerNo?: string;
        CustomerName?: string;
        Address?: string;
        Address2?: string;
        Address3?: string;
        Address4?: string;
        Attention?: string;
        InvoiceDate?: string;
        Period?: string;
        FiscalYear?: number;
        PeriodNo?: number;
        Salesman?: string;
        Ccy?: string;
        ExchRate?: number;
        PayTerms?: string;
        DiscDays?: number;
        DiscPcent?: number;
        DueDays?: number;
        DiscountDate?: string;
        DueDate?: string;
        ExpectedDate?: string;
        Anlys1?: string;
        Anlys2?: string;
        TotPriceAmt?: number;
        LocPriceAmt?: number;
        TotPtaxAmt?: number;
        LocPtaxAmt?: number;
        TotExtPrice?: number;
        LocExtPrice?: number;
        TotLdiscAmt?: number;
        LocLdiscAmt?: number;
        TotAtaxAmt?: number;
        LocAtaxAmt?: number;
        TotItemAmt?: number;
        LocItemAmt?: number;
        TdiscPcent?: number;
        TdiscAmt?: number;
        LocalTdiscAmt?: number;
        ChgsAmt?: number;
        LocChgsAmt?: number;
        GtaxAmt?: number;
        LocalGtaxAmt?: number;
        NetAmt?: number;
        LocalNetAmt?: number;
        TdiscAmtCpd?: number;
        LastLineNo?: number;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        PostedDate?: string;
        PostedBy?: string;
        LastLogNo?: number;
        SettledAmt?: number;
        LsettledAmt?: number;
        TermDiscAmt?: number;
        LtermDiscAmt?: number;
        ReturnAmt?: number;
        LreturnAmt?: number;
        BalAmt?: number;
        BalAmtLocal?: number;
        OverAllocAmt?: number;
        LoverAllocAmt?: number;
        AcctCustomer?: string;
        AcctTdisc?: string;
        AcctGtax?: string;
        LockType?: string;
        LockRefNo?: string;
        BatchSelect?: string;
        GlLink?: string;
        GlLinkType?: string;
        GlLinkNo?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        CheckCrlimit?: string;
        CheckCrbal?: number;
        Comments1?: string;
        Comments2?: string;
        Comments3?: string;
        Comments4?: string;
        LastTextNo?: number;
        ShipTo?: string;
        TelNo?: string;
        FaxNo?: string;
        SltaxType?: string;
        GsltaxPcent?: number;
        TotGsltaxAmt?: number;
        TotLsltaxAmt?: number;
        LocGsltaxAmt?: number;
        LocLsltaxAmt?: number;
        AcctSltax?: string;
        CustomerPo?: string;
        AiLink?: string;
        AiLinkType?: string;
        AiLinkNo?: string;
        Anlys7?: string;
        Anlys8?: string;
        NetTradeAmt?: number;
        NetOrdrAmt?: number;
        ShipAmt?: number;
        LshipAmt?: number;
        VariaAmt?: number;
        LvariaAmt?: number;
        ItemVariaAmt?: number;
        LitemVariaAmt?: number;
        ChgsVariaAmt?: number;
        LchgsVariaAmt?: number;
        DpsApplied?: number;
        LocDpsApplied?: number;
        ShipSltaxType?: string;
        ShipGsltaxPcent?: number;
        ShipCount?: number;
        SourceType?: string;
        LastChgsNo?: number;
        DocType?: string;
        DocId?: string;
        Anlys9?: string;
        Anlys10?: string;
        Anlys11?: string;
        Anlys12?: string;
        Anlys13?: string;
        Anlys14?: string;
        BreakDebitNote?: boolean;
        Freezed?: boolean;
        RelatedDebitNote?: string;
        Cloned?: boolean;
        ClonedCompanyCode?: string;
        UseSampleAcct?: boolean;
        ReferenceDate?: string;
    }

    export namespace AccountsReceivableInvoiceRow {
        export const idProperty = 'InvoiceNo';
        export const nameProperty = 'InvoiceNo';
        export const localTextPrefix = 'Finance.AccountsReceivableInvoice';

        export namespace Fields {
            export declare const OrderList: string;
            export declare const DetailList: string;
            export declare const CommissionList: string;
            export declare const Recnum: string;
            export declare const InvoiceNo: string;
            export declare const DirectEntry: string;
            export declare const Posted: string;
            export declare const Closed: string;
            export declare const Returned: string;
            export declare const DebitNote: string;
            export declare const CustomerNo: string;
            export declare const CustomerName: string;
            export declare const Address: string;
            export declare const Address2: string;
            export declare const Address3: string;
            export declare const Address4: string;
            export declare const Attention: string;
            export declare const InvoiceDate: string;
            export declare const Period: string;
            export declare const FiscalYear: string;
            export declare const PeriodNo: string;
            export declare const Salesman: string;
            export declare const Ccy: string;
            export declare const ExchRate: string;
            export declare const PayTerms: string;
            export declare const DiscDays: string;
            export declare const DiscPcent: string;
            export declare const DueDays: string;
            export declare const DiscountDate: string;
            export declare const DueDate: string;
            export declare const ExpectedDate: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const TotPriceAmt: string;
            export declare const LocPriceAmt: string;
            export declare const TotPtaxAmt: string;
            export declare const LocPtaxAmt: string;
            export declare const TotExtPrice: string;
            export declare const LocExtPrice: string;
            export declare const TotLdiscAmt: string;
            export declare const LocLdiscAmt: string;
            export declare const TotAtaxAmt: string;
            export declare const LocAtaxAmt: string;
            export declare const TotItemAmt: string;
            export declare const LocItemAmt: string;
            export declare const TdiscPcent: string;
            export declare const TdiscAmt: string;
            export declare const LocalTdiscAmt: string;
            export declare const ChgsAmt: string;
            export declare const LocChgsAmt: string;
            export declare const GtaxAmt: string;
            export declare const LocalGtaxAmt: string;
            export declare const NetAmt: string;
            export declare const LocalNetAmt: string;
            export declare const TdiscAmtCpd: string;
            export declare const LastLineNo: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const PostedDate: string;
            export declare const PostedBy: string;
            export declare const LastLogNo: string;
            export declare const SettledAmt: string;
            export declare const LsettledAmt: string;
            export declare const TermDiscAmt: string;
            export declare const LtermDiscAmt: string;
            export declare const ReturnAmt: string;
            export declare const LreturnAmt: string;
            export declare const BalAmt: string;
            export declare const BalAmtLocal: string;
            export declare const OverAllocAmt: string;
            export declare const LoverAllocAmt: string;
            export declare const AcctCustomer: string;
            export declare const AcctTdisc: string;
            export declare const AcctGtax: string;
            export declare const LockType: string;
            export declare const LockRefNo: string;
            export declare const BatchSelect: string;
            export declare const GlLink: string;
            export declare const GlLinkType: string;
            export declare const GlLinkNo: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const CheckCrlimit: string;
            export declare const CheckCrbal: string;
            export declare const Comments1: string;
            export declare const Comments2: string;
            export declare const Comments3: string;
            export declare const Comments4: string;
            export declare const LastTextNo: string;
            export declare const ShipTo: string;
            export declare const TelNo: string;
            export declare const FaxNo: string;
            export declare const SltaxType: string;
            export declare const GsltaxPcent: string;
            export declare const TotGsltaxAmt: string;
            export declare const TotLsltaxAmt: string;
            export declare const LocGsltaxAmt: string;
            export declare const LocLsltaxAmt: string;
            export declare const AcctSltax: string;
            export declare const CustomerPo: string;
            export declare const AiLink: string;
            export declare const AiLinkType: string;
            export declare const AiLinkNo: string;
            export declare const Anlys7: string;
            export declare const Anlys8: string;
            export declare const NetTradeAmt: string;
            export declare const NetOrdrAmt: string;
            export declare const ShipAmt: string;
            export declare const LshipAmt: string;
            export declare const VariaAmt: string;
            export declare const LvariaAmt: string;
            export declare const ItemVariaAmt: string;
            export declare const LitemVariaAmt: string;
            export declare const ChgsVariaAmt: string;
            export declare const LchgsVariaAmt: string;
            export declare const DpsApplied: string;
            export declare const LocDpsApplied: string;
            export declare const ShipSltaxType: string;
            export declare const ShipGsltaxPcent: string;
            export declare const ShipCount: string;
            export declare const SourceType: string;
            export declare const LastChgsNo: string;
            export declare const DocType: string;
            export declare const DocId: string;
            export declare const Anlys9: string;
            export declare const Anlys10: string;
            export declare const Anlys11: string;
            export declare const Anlys12: string;
            export declare const Anlys13: string;
            export declare const Anlys14: string;
            export declare const BreakDebitNote: string;
            export declare const Freezed: string;
            export declare const RelatedDebitNote: string;
            export declare const Cloned: string;
            export declare const ClonedCompanyCode: string;
            export declare const UseSampleAcct: string;
            export declare const ReferenceDate: string;
        }

        [
            'OrderList', 
            'DetailList', 
            'CommissionList', 
            'Recnum', 
            'InvoiceNo', 
            'DirectEntry', 
            'Posted', 
            'Closed', 
            'Returned', 
            'DebitNote', 
            'CustomerNo', 
            'CustomerName', 
            'Address', 
            'Address2', 
            'Address3', 
            'Address4', 
            'Attention', 
            'InvoiceDate', 
            'Period', 
            'FiscalYear', 
            'PeriodNo', 
            'Salesman', 
            'Ccy', 
            'ExchRate', 
            'PayTerms', 
            'DiscDays', 
            'DiscPcent', 
            'DueDays', 
            'DiscountDate', 
            'DueDate', 
            'ExpectedDate', 
            'Anlys1', 
            'Anlys2', 
            'TotPriceAmt', 
            'LocPriceAmt', 
            'TotPtaxAmt', 
            'LocPtaxAmt', 
            'TotExtPrice', 
            'LocExtPrice', 
            'TotLdiscAmt', 
            'LocLdiscAmt', 
            'TotAtaxAmt', 
            'LocAtaxAmt', 
            'TotItemAmt', 
            'LocItemAmt', 
            'TdiscPcent', 
            'TdiscAmt', 
            'LocalTdiscAmt', 
            'ChgsAmt', 
            'LocChgsAmt', 
            'GtaxAmt', 
            'LocalGtaxAmt', 
            'NetAmt', 
            'LocalNetAmt', 
            'TdiscAmtCpd', 
            'LastLineNo', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'PostedDate', 
            'PostedBy', 
            'LastLogNo', 
            'SettledAmt', 
            'LsettledAmt', 
            'TermDiscAmt', 
            'LtermDiscAmt', 
            'ReturnAmt', 
            'LreturnAmt', 
            'BalAmt', 
            'BalAmtLocal', 
            'OverAllocAmt', 
            'LoverAllocAmt', 
            'AcctCustomer', 
            'AcctTdisc', 
            'AcctGtax', 
            'LockType', 
            'LockRefNo', 
            'BatchSelect', 
            'GlLink', 
            'GlLinkType', 
            'GlLinkNo', 
            'OwnerBranch', 
            'SourceBranch', 
            'CheckCrlimit', 
            'CheckCrbal', 
            'Comments1', 
            'Comments2', 
            'Comments3', 
            'Comments4', 
            'LastTextNo', 
            'ShipTo', 
            'TelNo', 
            'FaxNo', 
            'SltaxType', 
            'GsltaxPcent', 
            'TotGsltaxAmt', 
            'TotLsltaxAmt', 
            'LocGsltaxAmt', 
            'LocLsltaxAmt', 
            'AcctSltax', 
            'CustomerPo', 
            'AiLink', 
            'AiLinkType', 
            'AiLinkNo', 
            'Anlys7', 
            'Anlys8', 
            'NetTradeAmt', 
            'NetOrdrAmt', 
            'ShipAmt', 
            'LshipAmt', 
            'VariaAmt', 
            'LvariaAmt', 
            'ItemVariaAmt', 
            'LitemVariaAmt', 
            'ChgsVariaAmt', 
            'LchgsVariaAmt', 
            'DpsApplied', 
            'LocDpsApplied', 
            'ShipSltaxType', 
            'ShipGsltaxPcent', 
            'ShipCount', 
            'SourceType', 
            'LastChgsNo', 
            'DocType', 
            'DocId', 
            'Anlys9', 
            'Anlys10', 
            'Anlys11', 
            'Anlys12', 
            'Anlys13', 
            'Anlys14', 
            'BreakDebitNote', 
            'Freezed', 
            'RelatedDebitNote', 
            'Cloned', 
            'ClonedCompanyCode', 
            'UseSampleAcct', 
            'ReferenceDate'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

