namespace Matrix.Finance {
    export class AccountsPayableInvoiceSummaryForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.AccountsPayableInvoiceSummary';

    }

    export interface AccountsPayableInvoiceSummaryForm {
        ControlNo: Serenity.StringEditor;
        GrnNo: Serenity.StringEditor;
        Posted: Serenity.StringEditor;
        Returned: Serenity.StringEditor;
        DoNo: Serenity.StringEditor;
        ReceivedDate: Serenity.DateEditor;
        Loc: Serenity.StringEditor;
        Inspected: Serenity.StringEditor;
        TotPriceAmt: Serenity.DecimalEditor;
        TotPtaxAmt: Serenity.DecimalEditor;
        TotExtPrice: Serenity.DecimalEditor;
        TotLdiscAmt: Serenity.DecimalEditor;
        TotAtaxAmt: Serenity.DecimalEditor;
        TotItemAmt: Serenity.DecimalEditor;
        TotTdiscAmt: Serenity.DecimalEditor;
        NetTradeAmt: Serenity.DecimalEditor;
        TotChgsAmt: Serenity.DecimalEditor;
        NetOrdrAmt: Serenity.DecimalEditor;
        TotGtaxAmt: Serenity.DecimalEditor;
        NetInvoAmt: Serenity.DecimalEditor;
        DpsApplied: Serenity.DecimalEditor;
        NetBalAmt: Serenity.DecimalEditor;
        LocPriceAmt: Serenity.DecimalEditor;
        LocPtaxAmt: Serenity.DecimalEditor;
        LocExtPrice: Serenity.DecimalEditor;
        LocLdiscAmt: Serenity.DecimalEditor;
        LocAtaxAmt: Serenity.DecimalEditor;
        LocItemAmt: Serenity.DecimalEditor;
        LocTdiscAmt: Serenity.DecimalEditor;
        LocChgsAmt: Serenity.DecimalEditor;
        LocGtaxAmt: Serenity.DecimalEditor;
        LocInvoAmt: Serenity.DecimalEditor;
        LocDpsApplied: Serenity.DecimalEditor;
        GrnNetAmt: Serenity.DecimalEditor;
        LgrnNetAmt: Serenity.DecimalEditor;
        VariaAmt: Serenity.DecimalEditor;
        LocalVariaAmt: Serenity.DecimalEditor;
        ItemVariaAmt: Serenity.DecimalEditor;
        LitemVariaAmt: Serenity.DecimalEditor;
        ChgsVariaAmt: Serenity.DecimalEditor;
        LchgsVariaAmt: Serenity.DecimalEditor;
        PutaxType: Serenity.StringEditor;
        GputaxPcent: Serenity.DecimalEditor;
        TotGputaxAmt: Serenity.DecimalEditor;
        TotLputaxAmt: Serenity.DecimalEditor;
        LocGputaxAmt: Serenity.DecimalEditor;
        LocLputaxAmt: Serenity.DecimalEditor;
        PoPutaxType: Serenity.StringEditor;
        PoGputaxPcent: Serenity.DecimalEditor;
    }

    [['ControlNo', () => Serenity.StringEditor]
   , ['GrnNo', () => Serenity.StringEditor]
   , ['Posted', () => Serenity.StringEditor]
   , ['Returned', () => Serenity.StringEditor]
   , ['DoNo', () => Serenity.StringEditor]
   , ['ReceivedDate', () => Serenity.DateEditor]
   , ['Loc', () => Serenity.StringEditor]
   , ['Inspected', () => Serenity.StringEditor]
   , ['TotPriceAmt', () => Serenity.DecimalEditor]
   , ['TotPtaxAmt', () => Serenity.DecimalEditor]
   , ['TotExtPrice', () => Serenity.DecimalEditor]
   , ['TotLdiscAmt', () => Serenity.DecimalEditor]
   , ['TotAtaxAmt', () => Serenity.DecimalEditor]
   , ['TotItemAmt', () => Serenity.DecimalEditor]
   , ['TotTdiscAmt', () => Serenity.DecimalEditor]
   , ['NetTradeAmt', () => Serenity.DecimalEditor]
   , ['TotChgsAmt', () => Serenity.DecimalEditor]
   , ['NetOrdrAmt', () => Serenity.DecimalEditor]
   , ['TotGtaxAmt', () => Serenity.DecimalEditor]
   , ['NetInvoAmt', () => Serenity.DecimalEditor]
   , ['DpsApplied', () => Serenity.DecimalEditor]
   , ['NetBalAmt', () => Serenity.DecimalEditor]
   , ['LocPriceAmt', () => Serenity.DecimalEditor]
   , ['LocPtaxAmt', () => Serenity.DecimalEditor]
   , ['LocExtPrice', () => Serenity.DecimalEditor]
   , ['LocLdiscAmt', () => Serenity.DecimalEditor]
   , ['LocAtaxAmt', () => Serenity.DecimalEditor]
   , ['LocItemAmt', () => Serenity.DecimalEditor]
   , ['LocTdiscAmt', () => Serenity.DecimalEditor]
   , ['LocChgsAmt', () => Serenity.DecimalEditor]
   , ['LocGtaxAmt', () => Serenity.DecimalEditor]
   , ['LocInvoAmt', () => Serenity.DecimalEditor]
   , ['LocDpsApplied', () => Serenity.DecimalEditor]
   , ['GrnNetAmt', () => Serenity.DecimalEditor]
   , ['LgrnNetAmt', () => Serenity.DecimalEditor]
   , ['VariaAmt', () => Serenity.DecimalEditor]
   , ['LocalVariaAmt', () => Serenity.DecimalEditor]
   , ['ItemVariaAmt', () => Serenity.DecimalEditor]
   , ['LitemVariaAmt', () => Serenity.DecimalEditor]
   , ['ChgsVariaAmt', () => Serenity.DecimalEditor]
   , ['LchgsVariaAmt', () => Serenity.DecimalEditor]
   , ['PutaxType', () => Serenity.StringEditor]
   , ['GputaxPcent', () => Serenity.DecimalEditor]
   , ['TotGputaxAmt', () => Serenity.DecimalEditor]
   , ['TotLputaxAmt', () => Serenity.DecimalEditor]
   , ['LocGputaxAmt', () => Serenity.DecimalEditor]
   , ['LocLputaxAmt', () => Serenity.DecimalEditor]
   , ['PoPutaxType', () => Serenity.StringEditor]
   , ['PoGputaxPcent', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(AccountsPayableInvoiceSummaryForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

