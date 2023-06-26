namespace Matrix.Finance {
    export class AccountsReceivableInvoiceOrderForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.AccountsReceivableInvoiceOrder';

    }

    export interface AccountsReceivableInvoiceOrderForm {
        InvoiceNo: Serenity.StringEditor;
        ShipmentRef: Serenity.StringEditor;
        OrderNo: Serenity.StringEditor;
        TotPriceAmt: Serenity.DecimalEditor;
        TotExtPrice: Serenity.DecimalEditor;
        TotLdiscAmt: Serenity.DecimalEditor;
        TotItemAmt: Serenity.DecimalEditor;
        TdiscPcent: Serenity.DecimalEditor;
        TotTdiscAmt: Serenity.DecimalEditor;
        NetTradeAmt: Serenity.DecimalEditor;
        TotChgsAmt: Serenity.DecimalEditor;
        NetOrdrAmt: Serenity.DecimalEditor;
        NetPayAmt: Serenity.DecimalEditor;
        DpsCover: Serenity.DecimalEditor;
        DpsPcent: Serenity.DecimalEditor;
        DpsApplied: Serenity.DecimalEditor;
        LocDpsApplied: Serenity.DecimalEditor;
        NetBalAmt: Serenity.DecimalEditor;
        SltaxType: Serenity.StringEditor;
        GsltaxPcent: Serenity.DecimalEditor;
        TotGsltaxAmt: Serenity.DecimalEditor;
        TotLsltaxAmt: Serenity.DecimalEditor;
        Anlys9: Serenity.StringEditor;
        Anlys10: Serenity.StringEditor;
        Anlys11: Serenity.StringEditor;
        Anlys12: Serenity.StringEditor;
        CustomerPo: Serenity.StringEditor;
        Anlys21: Serenity.StringEditor;
        Anlys22: Serenity.StringEditor;
        Anlys23: Serenity.StringEditor;
        Anlys24: Serenity.StringEditor;
        Anlys25: Serenity.StringEditor;
        Anlys26: Serenity.StringEditor;
    }

    [['InvoiceNo', () => Serenity.StringEditor]
   , ['ShipmentRef', () => Serenity.StringEditor]
   , ['OrderNo', () => Serenity.StringEditor]
   , ['TotPriceAmt', () => Serenity.DecimalEditor]
   , ['TotExtPrice', () => Serenity.DecimalEditor]
   , ['TotLdiscAmt', () => Serenity.DecimalEditor]
   , ['TotItemAmt', () => Serenity.DecimalEditor]
   , ['TdiscPcent', () => Serenity.DecimalEditor]
   , ['TotTdiscAmt', () => Serenity.DecimalEditor]
   , ['NetTradeAmt', () => Serenity.DecimalEditor]
   , ['TotChgsAmt', () => Serenity.DecimalEditor]
   , ['NetOrdrAmt', () => Serenity.DecimalEditor]
   , ['NetPayAmt', () => Serenity.DecimalEditor]
   , ['DpsCover', () => Serenity.DecimalEditor]
   , ['DpsPcent', () => Serenity.DecimalEditor]
   , ['DpsApplied', () => Serenity.DecimalEditor]
   , ['LocDpsApplied', () => Serenity.DecimalEditor]
   , ['NetBalAmt', () => Serenity.DecimalEditor]
   , ['SltaxType', () => Serenity.StringEditor]
   , ['GsltaxPcent', () => Serenity.DecimalEditor]
   , ['TotGsltaxAmt', () => Serenity.DecimalEditor]
   , ['TotLsltaxAmt', () => Serenity.DecimalEditor]
   , ['Anlys9', () => Serenity.StringEditor]
   , ['Anlys10', () => Serenity.StringEditor]
   , ['Anlys11', () => Serenity.StringEditor]
   , ['Anlys12', () => Serenity.StringEditor]
   , ['CustomerPo', () => Serenity.StringEditor]
   , ['Anlys21', () => Serenity.StringEditor]
   , ['Anlys22', () => Serenity.StringEditor]
   , ['Anlys23', () => Serenity.StringEditor]
   , ['Anlys24', () => Serenity.StringEditor]
   , ['Anlys25', () => Serenity.StringEditor]
   , ['Anlys26', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(AccountsReceivableInvoiceOrderForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

