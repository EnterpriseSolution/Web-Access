namespace Matrix.Finance {
    export class AccountsReceivableInvoiceForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.AccountsReceivableInvoice';

    }

    export interface AccountsReceivableInvoiceForm {
        InvoiceNo: Serenity.StringEditor;
        InvoiceDate: Serenity.DateEditor;
        CustomerNo: Serenity.StringEditor;
        CustomerName: Serenity.StringEditor;
        ShipTo: Serenity.StringEditor;
        Attention: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        Address2: Serenity.StringEditor;
        Address3: Serenity.StringEditor;
        Address4: Serenity.StringEditor;
        TelNo: Serenity.StringEditor;
        FaxNo: Serenity.StringEditor;
        PayTerms: Serenity.StringEditor;
        DiscDays: Serenity.DecimalEditor;
        DiscPcent: Serenity.DecimalEditor;
        DiscountDate: Serenity.DateEditor;
        DueDate: Serenity.DateEditor;
        ExpectedDate: Serenity.DateEditor;
        Ccy: Serenity.StringEditor;
        ExchRate: Serenity.DecimalEditor;
        TdiscPcent: Serenity.DecimalEditor;
        NetTradeAmt: Serenity.DecimalEditor;
        ChgsAmt: Serenity.DecimalEditor;
        NetOrdrAmt: Serenity.DecimalEditor;
        NetAmt: Serenity.DecimalEditor;
        DpsApplied: Serenity.DecimalEditor;
        BalAmt: Serenity.DecimalEditor;
        OrderList: AccountsReceivableInvoiceOrderEditor;
        DetailList: AccountsReceivableInvoiceDetailEditor;
        CommissionList: AccountsReceivableCommissionEditor;
        Comments1: Serenity.TextAreaEditor;
        Comments2: Serenity.TextAreaEditor;
        Comments3: Serenity.TextAreaEditor;
        Comments4: Serenity.TextAreaEditor;
    }

    [['InvoiceNo', () => Serenity.StringEditor]
   , ['InvoiceDate', () => Serenity.DateEditor]
   , ['CustomerNo', () => Serenity.StringEditor]
   , ['CustomerName', () => Serenity.StringEditor]
   , ['ShipTo', () => Serenity.StringEditor]
   , ['Attention', () => Serenity.StringEditor]
   , ['Address', () => Serenity.StringEditor]
   , ['Address2', () => Serenity.StringEditor]
   , ['Address3', () => Serenity.StringEditor]
   , ['Address4', () => Serenity.StringEditor]
   , ['TelNo', () => Serenity.StringEditor]
   , ['FaxNo', () => Serenity.StringEditor]
   , ['PayTerms', () => Serenity.StringEditor]
   , ['DiscDays', () => Serenity.DecimalEditor]
   , ['DiscPcent', () => Serenity.DecimalEditor]
   , ['DiscountDate', () => Serenity.DateEditor]
   , ['DueDate', () => Serenity.DateEditor]
   , ['ExpectedDate', () => Serenity.DateEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['ExchRate', () => Serenity.DecimalEditor]
   , ['TdiscPcent', () => Serenity.DecimalEditor]
   , ['NetTradeAmt', () => Serenity.DecimalEditor]
   , ['ChgsAmt', () => Serenity.DecimalEditor]
   , ['NetOrdrAmt', () => Serenity.DecimalEditor]
   , ['NetAmt', () => Serenity.DecimalEditor]
   , ['DpsApplied', () => Serenity.DecimalEditor]
   , ['BalAmt', () => Serenity.DecimalEditor]
   , ['OrderList', () => AccountsReceivableInvoiceOrderEditor]
   , ['DetailList', () => AccountsReceivableInvoiceDetailEditor]
   , ['CommissionList', () => AccountsReceivableCommissionEditor]
   , ['Comments1', () => Serenity.TextAreaEditor]
   , ['Comments2', () => Serenity.TextAreaEditor]
   , ['Comments3', () => Serenity.TextAreaEditor]
   , ['Comments4', () => Serenity.TextAreaEditor]
].forEach(x => Object.defineProperty(AccountsReceivableInvoiceForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

