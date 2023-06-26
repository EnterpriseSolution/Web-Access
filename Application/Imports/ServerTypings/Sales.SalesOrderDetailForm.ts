namespace Matrix.Sales {
    export class SalesOrderDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Sales.SalesOrderDetail';

    }

    export interface SalesOrderDetailForm {
        LineNo: Serenity.DecimalEditor;
        ItemNo: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Uom: Serenity.StringEditor;
        LotSize: Serenity.DecimalEditor;
        Qty: Serenity.DecimalEditor;
        Price: Serenity.DecimalEditor;
        ExtPrice: Serenity.DecimalEditor;
        LdiscPcent: Serenity.DecimalEditor;
        NetItemAmt: Serenity.DecimalEditor;
        PriceAmt: Serenity.DecimalEditor;
    }

    [['LineNo', () => Serenity.DecimalEditor]
   , ['ItemNo', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Uom', () => Serenity.StringEditor]
   , ['LotSize', () => Serenity.DecimalEditor]
   , ['Qty', () => Serenity.DecimalEditor]
   , ['Price', () => Serenity.DecimalEditor]
   , ['ExtPrice', () => Serenity.DecimalEditor]
   , ['LdiscPcent', () => Serenity.DecimalEditor]
   , ['NetItemAmt', () => Serenity.DecimalEditor]
   , ['PriceAmt', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(SalesOrderDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

