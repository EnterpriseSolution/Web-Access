namespace Matrix.Sales {
    export class SalesReturnDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Sales.SalesReturnDetail';

    }

    export interface SalesReturnDetailForm {
        EntryNo: Serenity.DecimalEditor;
        OrderNo: Serenity.StringEditor;
        LineNo: Serenity.DecimalEditor;
        ItemNo: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Uom: Serenity.StringEditor;
        LotSize: Serenity.DecimalEditor;
        Price: Serenity.DecimalEditor;
        ExtPrice: Serenity.DecimalEditor;
        LdiscPcent: Serenity.DecimalEditor;
        LdiscAmt: Serenity.DecimalEditor;
        NetItemAmt: Serenity.DecimalEditor;
        RefundAmt: Serenity.DecimalEditor;
        Reorder: Serenity.BooleanEditor;
    }

    [['EntryNo', () => Serenity.DecimalEditor]
   , ['OrderNo', () => Serenity.StringEditor]
   , ['LineNo', () => Serenity.DecimalEditor]
   , ['ItemNo', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Uom', () => Serenity.StringEditor]
   , ['LotSize', () => Serenity.DecimalEditor]
   , ['Price', () => Serenity.DecimalEditor]
   , ['ExtPrice', () => Serenity.DecimalEditor]
   , ['LdiscPcent', () => Serenity.DecimalEditor]
   , ['LdiscAmt', () => Serenity.DecimalEditor]
   , ['NetItemAmt', () => Serenity.DecimalEditor]
   , ['RefundAmt', () => Serenity.DecimalEditor]
   , ['Reorder', () => Serenity.BooleanEditor]
].forEach(x => Object.defineProperty(SalesReturnDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

