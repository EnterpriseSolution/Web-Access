namespace Matrix.Finance {
    export class AccountsPayableInvoiceForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.AccountsPayableInvoice';

    }

    export interface AccountsPayableInvoiceForm {
        ControlNo: Serenity.StringEditor;
        VendorNo: Serenity.StringEditor;
        VendorName: Serenity.StringEditor;
        InvoiceNo: Serenity.StringEditor;
        InvoiceDate: Serenity.DateEditor;
        ReceivedDate: Serenity.DateEditor;
        Period: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        ExchRate: Serenity.DecimalEditor;
        PayTerms: Serenity.StringEditor;
        DiscPercent: Serenity.DecimalEditor;
        DiscDays: Serenity.DecimalEditor;
        NetDays: Serenity.DecimalEditor;
        DiscountDate: Serenity.DateEditor;
        DueDate: Serenity.DateEditor;
        PlannedDate: Serenity.DateEditor;
        TotItemAmt: Serenity.DecimalEditor;
        TotTdiscAmt: Serenity.DecimalEditor;
        TotChgsAmt: Serenity.DecimalEditor;
        NetTradeAmt: Serenity.DecimalEditor;
        DpsApplied: Serenity.DecimalEditor;
        NetBalAmt: Serenity.DecimalEditor;
        DetailList: AccountsPayableInvoiceOrderEditor;
        ItemDetailList: AccountsPayableInvoiceDetailEditor;
        Particulars: Serenity.TextAreaEditor;
    }

    [['ControlNo', () => Serenity.StringEditor]
   , ['VendorNo', () => Serenity.StringEditor]
   , ['VendorName', () => Serenity.StringEditor]
   , ['InvoiceNo', () => Serenity.StringEditor]
   , ['InvoiceDate', () => Serenity.DateEditor]
   , ['ReceivedDate', () => Serenity.DateEditor]
   , ['Period', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['ExchRate', () => Serenity.DecimalEditor]
   , ['PayTerms', () => Serenity.StringEditor]
   , ['DiscPercent', () => Serenity.DecimalEditor]
   , ['DiscDays', () => Serenity.DecimalEditor]
   , ['NetDays', () => Serenity.DecimalEditor]
   , ['DiscountDate', () => Serenity.DateEditor]
   , ['DueDate', () => Serenity.DateEditor]
   , ['PlannedDate', () => Serenity.DateEditor]
   , ['TotItemAmt', () => Serenity.DecimalEditor]
   , ['TotTdiscAmt', () => Serenity.DecimalEditor]
   , ['TotChgsAmt', () => Serenity.DecimalEditor]
   , ['NetTradeAmt', () => Serenity.DecimalEditor]
   , ['DpsApplied', () => Serenity.DecimalEditor]
   , ['NetBalAmt', () => Serenity.DecimalEditor]
   , ['DetailList', () => AccountsPayableInvoiceOrderEditor]
   , ['ItemDetailList', () => AccountsPayableInvoiceDetailEditor]
   , ['Particulars', () => Serenity.TextAreaEditor]
].forEach(x => Object.defineProperty(AccountsPayableInvoiceForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

