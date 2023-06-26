namespace Matrix.Finance {
    export class AccountsPayableInvoiceOrderForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.AccountsPayableInvoiceOrder';

    }

    export interface AccountsPayableInvoiceOrderForm {
        ControlNo: Serenity.StringEditor;
        GrnNo: Serenity.StringEditor;
        OrderNo: Serenity.StringEditor;
        TotPriceAmt: Serenity.DecimalEditor;
        TotPtaxAmt: Serenity.DecimalEditor;
        TotExtPrice: Serenity.DecimalEditor;
        TotLdiscAmt: Serenity.DecimalEditor;
        TotAtaxAmt: Serenity.DecimalEditor;
        TotItemAmt: Serenity.DecimalEditor;
        TdiscPcent: Serenity.DecimalEditor;
        TotTdiscAmt: Serenity.DecimalEditor;
        NetTradeAmt: Serenity.DecimalEditor;
        TotChgsAmt: Serenity.DecimalEditor;
        NetOrdrAmt: Serenity.DecimalEditor;
        TotGtaxAmt: Serenity.DecimalEditor;
        NetInvoAmt: Serenity.DecimalEditor;
        DpsCover: Serenity.DecimalEditor;
        DpsPcent: Serenity.DecimalEditor;
        DpsApplied: Serenity.DecimalEditor;
        NetBalAmt: Serenity.DecimalEditor;
        LocDpsApplied: Serenity.DecimalEditor;
        PutaxType: Serenity.StringEditor;
        GputaxPcent: Serenity.DecimalEditor;
        TotGputaxAmt: Serenity.DecimalEditor;
        TotLputaxAmt: Serenity.DecimalEditor;
        Anlys1: Serenity.StringEditor;
        Anlys2: Serenity.StringEditor;
        Anlys7: Serenity.StringEditor;
        Anlys8: Serenity.StringEditor;
        Anlys9: Serenity.StringEditor;
        Anlys10: Serenity.StringEditor;
        Anlys11: Serenity.StringEditor;
        Anlys12: Serenity.StringEditor;
        Anlys13: Serenity.StringEditor;
        Anlys14: Serenity.StringEditor;
    }

    [['ControlNo', () => Serenity.StringEditor]
   , ['GrnNo', () => Serenity.StringEditor]
   , ['OrderNo', () => Serenity.StringEditor]
   , ['TotPriceAmt', () => Serenity.DecimalEditor]
   , ['TotPtaxAmt', () => Serenity.DecimalEditor]
   , ['TotExtPrice', () => Serenity.DecimalEditor]
   , ['TotLdiscAmt', () => Serenity.DecimalEditor]
   , ['TotAtaxAmt', () => Serenity.DecimalEditor]
   , ['TotItemAmt', () => Serenity.DecimalEditor]
   , ['TdiscPcent', () => Serenity.DecimalEditor]
   , ['TotTdiscAmt', () => Serenity.DecimalEditor]
   , ['NetTradeAmt', () => Serenity.DecimalEditor]
   , ['TotChgsAmt', () => Serenity.DecimalEditor]
   , ['NetOrdrAmt', () => Serenity.DecimalEditor]
   , ['TotGtaxAmt', () => Serenity.DecimalEditor]
   , ['NetInvoAmt', () => Serenity.DecimalEditor]
   , ['DpsCover', () => Serenity.DecimalEditor]
   , ['DpsPcent', () => Serenity.DecimalEditor]
   , ['DpsApplied', () => Serenity.DecimalEditor]
   , ['NetBalAmt', () => Serenity.DecimalEditor]
   , ['LocDpsApplied', () => Serenity.DecimalEditor]
   , ['PutaxType', () => Serenity.StringEditor]
   , ['GputaxPcent', () => Serenity.DecimalEditor]
   , ['TotGputaxAmt', () => Serenity.DecimalEditor]
   , ['TotLputaxAmt', () => Serenity.DecimalEditor]
   , ['Anlys1', () => Serenity.StringEditor]
   , ['Anlys2', () => Serenity.StringEditor]
   , ['Anlys7', () => Serenity.StringEditor]
   , ['Anlys8', () => Serenity.StringEditor]
   , ['Anlys9', () => Serenity.StringEditor]
   , ['Anlys10', () => Serenity.StringEditor]
   , ['Anlys11', () => Serenity.StringEditor]
   , ['Anlys12', () => Serenity.StringEditor]
   , ['Anlys13', () => Serenity.StringEditor]
   , ['Anlys14', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(AccountsPayableInvoiceOrderForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

