namespace Matrix.Sales {
    export class SalesReturnForm extends Serenity.PrefixedContext {
        static formKey = 'Sales.SalesReturn';

    }

    export interface SalesReturnForm {
        RefNo: Serenity.StringEditor;
        TranDate: Serenity.DateEditor;
        Loc: Serenity.StringEditor;
        ShipmentRef: Serenity.StringEditor;
        CustomerNo: Serenity.StringEditor;
        CustomerName: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        ExchRate: Serenity.DecimalEditor;
        Reason: Serenity.TextAreaEditor;
        DetailList: SalesReturnDetailEditor;
        TotItemAmt: Serenity.DecimalEditor;
        TotRefundAmt: Serenity.DecimalEditor;
        TdiscPcent: Serenity.DecimalEditor;
        TotLdiscAmt: Serenity.DecimalEditor;
        NetTradeAmt: Serenity.DecimalEditor;
        TotChgsAmt: Serenity.DecimalEditor;
        NetPayAmt: Serenity.DecimalEditor;
    }

    [['RefNo', () => Serenity.StringEditor]
   , ['TranDate', () => Serenity.DateEditor]
   , ['Loc', () => Serenity.StringEditor]
   , ['ShipmentRef', () => Serenity.StringEditor]
   , ['CustomerNo', () => Serenity.StringEditor]
   , ['CustomerName', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['ExchRate', () => Serenity.DecimalEditor]
   , ['Reason', () => Serenity.TextAreaEditor]
   , ['DetailList', () => SalesReturnDetailEditor]
   , ['TotItemAmt', () => Serenity.DecimalEditor]
   , ['TotRefundAmt', () => Serenity.DecimalEditor]
   , ['TdiscPcent', () => Serenity.DecimalEditor]
   , ['TotLdiscAmt', () => Serenity.DecimalEditor]
   , ['NetTradeAmt', () => Serenity.DecimalEditor]
   , ['TotChgsAmt', () => Serenity.DecimalEditor]
   , ['NetPayAmt', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(SalesReturnForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

