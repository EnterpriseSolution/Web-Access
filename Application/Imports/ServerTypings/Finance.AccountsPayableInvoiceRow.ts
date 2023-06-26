namespace Matrix.Finance {
    export interface AccountsPayableInvoiceRow {
        DetailList?: AccountsPayableInvoiceOrderRow[];
        ItemDetailList?: AccountsPayableInvoiceDetailRow[];
        Recnum?: number;
        ControlNo?: string;
        Miscellaneous?: string;
        Posted?: string;
        Closed?: string;
        Returned?: string;
        VendorNo?: string;
        VendorName?: string;
        InvoiceNo?: string;
        InvoiceDate?: string;
        ReceivedDate?: string;
        Period?: string;
        FiscalYear?: number;
        PeriodNo?: number;
        PayTerms?: string;
        DiscPercent?: number;
        DiscDays?: number;
        NetDays?: number;
        DiscountDate?: string;
        DueDate?: string;
        PlannedDate?: string;
        PaymentBranch?: string;
        Ccy?: string;
        ExchRate?: number;
        TotPriceAmt?: number;
        TotPtaxAmt?: number;
        TotExtPrice?: number;
        TotLdiscAmt?: number;
        TotAtaxAmt?: number;
        TotItemAmt?: number;
        TotTdiscAmt?: number;
        NetTradeAmt?: number;
        TotChgsAmt?: number;
        NetOrdrAmt?: number;
        TotGtaxAmt?: number;
        NetInvoAmt?: number;
        DpsApplied?: number;
        NetBalAmt?: number;
        LocPriceAmt?: number;
        LocPtaxAmt?: number;
        LocExtPrice?: number;
        LocLdiscAmt?: number;
        LocAtaxAmt?: number;
        LocItemAmt?: number;
        LocTdiscAmt?: number;
        LocChgsAmt?: number;
        LocGtaxAmt?: number;
        LocInvoAmt?: number;
        LocDpsApplied?: number;
        GrnNetAmt?: number;
        LgrnNetAmt?: number;
        VariaAmt?: number;
        LvariaAmt?: number;
        ItemVariaAmt?: number;
        LitemVariaAmt?: number;
        ChgsVariaAmt?: number;
        LchgsVariaAmt?: number;
        LastLineNo?: number;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        PostedDate?: string;
        PostedBy?: string;
        Hold?: string;
        HoldUntil?: string;
        HoldDate?: string;
        HoldBy?: string;
        AcctVendor?: string;
        AcctTdisc?: string;
        AcctGtax?: string;
        AcctVariance?: string;
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
        BatchSelect?: string;
        GlLink?: string;
        GlLinkType?: string;
        GlLinkNo?: string;
        LastLogNo?: number;
        LockType?: string;
        LockRefNo?: string;
        HoldReason?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        Particulars?: string;
        CheckCrlimit?: string;
        CheckCrbal?: number;
        AcctPutax?: string;
        PutaxType?: string;
        GputaxPcent?: number;
        TotGputaxAmt?: number;
        TotLputaxAmt?: number;
        LocGputaxAmt?: number;
        LocLputaxAmt?: number;
        GrnPutaxType?: string;
        GrnGputaxPcent?: number;
        GrnCount?: number;
        AiLink?: string;
        AiLinkType?: string;
        AiLinkNo?: string;
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
        PoNo?: string;
        OriginCountry?: string;
    }

    export namespace AccountsPayableInvoiceRow {
        export const idProperty = 'ControlNo';
        export const nameProperty = 'ControlNo';
        export const localTextPrefix = 'Finance.AccountsPayableInvoice';

        export namespace Fields {
            export declare const DetailList: string;
            export declare const ItemDetailList: string;
            export declare const Recnum: string;
            export declare const ControlNo: string;
            export declare const Miscellaneous: string;
            export declare const Posted: string;
            export declare const Closed: string;
            export declare const Returned: string;
            export declare const VendorNo: string;
            export declare const VendorName: string;
            export declare const InvoiceNo: string;
            export declare const InvoiceDate: string;
            export declare const ReceivedDate: string;
            export declare const Period: string;
            export declare const FiscalYear: string;
            export declare const PeriodNo: string;
            export declare const PayTerms: string;
            export declare const DiscPercent: string;
            export declare const DiscDays: string;
            export declare const NetDays: string;
            export declare const DiscountDate: string;
            export declare const DueDate: string;
            export declare const PlannedDate: string;
            export declare const PaymentBranch: string;
            export declare const Ccy: string;
            export declare const ExchRate: string;
            export declare const TotPriceAmt: string;
            export declare const TotPtaxAmt: string;
            export declare const TotExtPrice: string;
            export declare const TotLdiscAmt: string;
            export declare const TotAtaxAmt: string;
            export declare const TotItemAmt: string;
            export declare const TotTdiscAmt: string;
            export declare const NetTradeAmt: string;
            export declare const TotChgsAmt: string;
            export declare const NetOrdrAmt: string;
            export declare const TotGtaxAmt: string;
            export declare const NetInvoAmt: string;
            export declare const DpsApplied: string;
            export declare const NetBalAmt: string;
            export declare const LocPriceAmt: string;
            export declare const LocPtaxAmt: string;
            export declare const LocExtPrice: string;
            export declare const LocLdiscAmt: string;
            export declare const LocAtaxAmt: string;
            export declare const LocItemAmt: string;
            export declare const LocTdiscAmt: string;
            export declare const LocChgsAmt: string;
            export declare const LocGtaxAmt: string;
            export declare const LocInvoAmt: string;
            export declare const LocDpsApplied: string;
            export declare const GrnNetAmt: string;
            export declare const LgrnNetAmt: string;
            export declare const VariaAmt: string;
            export declare const LvariaAmt: string;
            export declare const ItemVariaAmt: string;
            export declare const LitemVariaAmt: string;
            export declare const ChgsVariaAmt: string;
            export declare const LchgsVariaAmt: string;
            export declare const LastLineNo: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const PostedDate: string;
            export declare const PostedBy: string;
            export declare const Hold: string;
            export declare const HoldUntil: string;
            export declare const HoldDate: string;
            export declare const HoldBy: string;
            export declare const AcctVendor: string;
            export declare const AcctTdisc: string;
            export declare const AcctGtax: string;
            export declare const AcctVariance: string;
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
            export declare const BatchSelect: string;
            export declare const GlLink: string;
            export declare const GlLinkType: string;
            export declare const GlLinkNo: string;
            export declare const LastLogNo: string;
            export declare const LockType: string;
            export declare const LockRefNo: string;
            export declare const HoldReason: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const Particulars: string;
            export declare const CheckCrlimit: string;
            export declare const CheckCrbal: string;
            export declare const AcctPutax: string;
            export declare const PutaxType: string;
            export declare const GputaxPcent: string;
            export declare const TotGputaxAmt: string;
            export declare const TotLputaxAmt: string;
            export declare const LocGputaxAmt: string;
            export declare const LocLputaxAmt: string;
            export declare const GrnPutaxType: string;
            export declare const GrnGputaxPcent: string;
            export declare const GrnCount: string;
            export declare const AiLink: string;
            export declare const AiLinkType: string;
            export declare const AiLinkNo: string;
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
            export declare const PoNo: string;
            export declare const OriginCountry: string;
        }

        [
            'DetailList', 
            'ItemDetailList', 
            'Recnum', 
            'ControlNo', 
            'Miscellaneous', 
            'Posted', 
            'Closed', 
            'Returned', 
            'VendorNo', 
            'VendorName', 
            'InvoiceNo', 
            'InvoiceDate', 
            'ReceivedDate', 
            'Period', 
            'FiscalYear', 
            'PeriodNo', 
            'PayTerms', 
            'DiscPercent', 
            'DiscDays', 
            'NetDays', 
            'DiscountDate', 
            'DueDate', 
            'PlannedDate', 
            'PaymentBranch', 
            'Ccy', 
            'ExchRate', 
            'TotPriceAmt', 
            'TotPtaxAmt', 
            'TotExtPrice', 
            'TotLdiscAmt', 
            'TotAtaxAmt', 
            'TotItemAmt', 
            'TotTdiscAmt', 
            'NetTradeAmt', 
            'TotChgsAmt', 
            'NetOrdrAmt', 
            'TotGtaxAmt', 
            'NetInvoAmt', 
            'DpsApplied', 
            'NetBalAmt', 
            'LocPriceAmt', 
            'LocPtaxAmt', 
            'LocExtPrice', 
            'LocLdiscAmt', 
            'LocAtaxAmt', 
            'LocItemAmt', 
            'LocTdiscAmt', 
            'LocChgsAmt', 
            'LocGtaxAmt', 
            'LocInvoAmt', 
            'LocDpsApplied', 
            'GrnNetAmt', 
            'LgrnNetAmt', 
            'VariaAmt', 
            'LvariaAmt', 
            'ItemVariaAmt', 
            'LitemVariaAmt', 
            'ChgsVariaAmt', 
            'LchgsVariaAmt', 
            'LastLineNo', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'PostedDate', 
            'PostedBy', 
            'Hold', 
            'HoldUntil', 
            'HoldDate', 
            'HoldBy', 
            'AcctVendor', 
            'AcctTdisc', 
            'AcctGtax', 
            'AcctVariance', 
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
            'BatchSelect', 
            'GlLink', 
            'GlLinkType', 
            'GlLinkNo', 
            'LastLogNo', 
            'LockType', 
            'LockRefNo', 
            'HoldReason', 
            'OwnerBranch', 
            'SourceBranch', 
            'Particulars', 
            'CheckCrlimit', 
            'CheckCrbal', 
            'AcctPutax', 
            'PutaxType', 
            'GputaxPcent', 
            'TotGputaxAmt', 
            'TotLputaxAmt', 
            'LocGputaxAmt', 
            'LocLputaxAmt', 
            'GrnPutaxType', 
            'GrnGputaxPcent', 
            'GrnCount', 
            'AiLink', 
            'AiLinkType', 
            'AiLinkNo', 
            'Anlys9', 
            'Anlys10', 
            'Anlys11', 
            'Anlys12', 
            'Anlys13', 
            'Anlys14', 
            'Anlys15', 
            'Anlys16', 
            'Anlys17', 
            'Anlys18', 
            'PoNo', 
            'OriginCountry'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

