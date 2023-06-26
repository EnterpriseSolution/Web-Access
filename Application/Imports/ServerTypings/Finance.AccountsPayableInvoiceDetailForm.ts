namespace Matrix.Finance {
    export class AccountsPayableInvoiceDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.AccountsPayableInvoiceDetail';

    }

    export interface AccountsPayableInvoiceDetailForm {
        ControlNo: Serenity.StringEditor;
        GrnNo: Serenity.StringEditor;
        EntryNo: Serenity.DecimalEditor;
        Posted: Serenity.StringEditor;
        Returned: Serenity.StringEditor;
        OrderNo: Serenity.StringEditor;
        LineNo: Serenity.DecimalEditor;
        ItemNo: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Uom: Serenity.StringEditor;
        LotSize: Serenity.DecimalEditor;
        Qty: Serenity.DecimalEditor;
        Price: Serenity.DecimalEditor;
        Ptax: Serenity.DecimalEditor;
        NetPrice: Serenity.DecimalEditor;
        ExtPrice: Serenity.DecimalEditor;
        LdiscPcent: Serenity.DecimalEditor;
        LdiscAmt: Serenity.DecimalEditor;
        AtaxAmt: Serenity.DecimalEditor;
        NetItemAmt: Serenity.DecimalEditor;
        PriceAmt: Serenity.DecimalEditor;
        PtaxAmt: Serenity.DecimalEditor;
        LocPriceAmt: Serenity.DecimalEditor;
        LocPtaxAmt: Serenity.DecimalEditor;
        LocExtPrice: Serenity.DecimalEditor;
        LocLdiscAmt: Serenity.DecimalEditor;
        LocAtaxAmt: Serenity.DecimalEditor;
        LocItemAmt: Serenity.DecimalEditor;
        GrnItemAmt: Serenity.DecimalEditor;
        LgrnItemAmt: Serenity.DecimalEditor;
        VariaAmt: Serenity.DecimalEditor;
        LocVariaAmt: Serenity.DecimalEditor;
        AcctPurchase: Serenity.StringEditor;
        AcctLdisc: Serenity.StringEditor;
        AcctPtax: Serenity.StringEditor;
        AcctAtax: Serenity.StringEditor;
        AcctVariance: Serenity.StringEditor;
        ReturnQty: Serenity.DecimalEditor;
        ReturnAmt: Serenity.DecimalEditor;
        LreturnAmt: Serenity.DecimalEditor;
        PutaxPcent: Serenity.DecimalEditor;
        PutaxAmt: Serenity.DecimalEditor;
        LocPutaxAmt: Serenity.DecimalEditor;
        AcctPutax: Serenity.StringEditor;
        Anlys3: Serenity.StringEditor;
        Anlys4: Serenity.StringEditor;
        Anlys5: Serenity.StringEditor;
        Anlys6: Serenity.StringEditor;
        Anlys15: Serenity.StringEditor;
        Anlys16: Serenity.StringEditor;
        Anlys17: Serenity.StringEditor;
        Anlys18: Serenity.StringEditor;
        Anlys19: Serenity.StringEditor;
        Anlys20: Serenity.StringEditor;
    }

    [['ControlNo', () => Serenity.StringEditor]
   , ['GrnNo', () => Serenity.StringEditor]
   , ['EntryNo', () => Serenity.DecimalEditor]
   , ['Posted', () => Serenity.StringEditor]
   , ['Returned', () => Serenity.StringEditor]
   , ['OrderNo', () => Serenity.StringEditor]
   , ['LineNo', () => Serenity.DecimalEditor]
   , ['ItemNo', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Uom', () => Serenity.StringEditor]
   , ['LotSize', () => Serenity.DecimalEditor]
   , ['Qty', () => Serenity.DecimalEditor]
   , ['Price', () => Serenity.DecimalEditor]
   , ['Ptax', () => Serenity.DecimalEditor]
   , ['NetPrice', () => Serenity.DecimalEditor]
   , ['ExtPrice', () => Serenity.DecimalEditor]
   , ['LdiscPcent', () => Serenity.DecimalEditor]
   , ['LdiscAmt', () => Serenity.DecimalEditor]
   , ['AtaxAmt', () => Serenity.DecimalEditor]
   , ['NetItemAmt', () => Serenity.DecimalEditor]
   , ['PriceAmt', () => Serenity.DecimalEditor]
   , ['PtaxAmt', () => Serenity.DecimalEditor]
   , ['LocPriceAmt', () => Serenity.DecimalEditor]
   , ['LocPtaxAmt', () => Serenity.DecimalEditor]
   , ['LocExtPrice', () => Serenity.DecimalEditor]
   , ['LocLdiscAmt', () => Serenity.DecimalEditor]
   , ['LocAtaxAmt', () => Serenity.DecimalEditor]
   , ['LocItemAmt', () => Serenity.DecimalEditor]
   , ['GrnItemAmt', () => Serenity.DecimalEditor]
   , ['LgrnItemAmt', () => Serenity.DecimalEditor]
   , ['VariaAmt', () => Serenity.DecimalEditor]
   , ['LocVariaAmt', () => Serenity.DecimalEditor]
   , ['AcctPurchase', () => Serenity.StringEditor]
   , ['AcctLdisc', () => Serenity.StringEditor]
   , ['AcctPtax', () => Serenity.StringEditor]
   , ['AcctAtax', () => Serenity.StringEditor]
   , ['AcctVariance', () => Serenity.StringEditor]
   , ['ReturnQty', () => Serenity.DecimalEditor]
   , ['ReturnAmt', () => Serenity.DecimalEditor]
   , ['LreturnAmt', () => Serenity.DecimalEditor]
   , ['PutaxPcent', () => Serenity.DecimalEditor]
   , ['PutaxAmt', () => Serenity.DecimalEditor]
   , ['LocPutaxAmt', () => Serenity.DecimalEditor]
   , ['AcctPutax', () => Serenity.StringEditor]
   , ['Anlys3', () => Serenity.StringEditor]
   , ['Anlys4', () => Serenity.StringEditor]
   , ['Anlys5', () => Serenity.StringEditor]
   , ['Anlys6', () => Serenity.StringEditor]
   , ['Anlys15', () => Serenity.StringEditor]
   , ['Anlys16', () => Serenity.StringEditor]
   , ['Anlys17', () => Serenity.StringEditor]
   , ['Anlys18', () => Serenity.StringEditor]
   , ['Anlys19', () => Serenity.StringEditor]
   , ['Anlys20', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(AccountsPayableInvoiceDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

