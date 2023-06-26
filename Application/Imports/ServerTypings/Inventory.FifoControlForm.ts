namespace Matrix.Inventory {
    export class FifoControlForm extends Serenity.PrefixedContext {
        static formKey = 'Inventory.FifoControl';

    }

    export interface FifoControlForm {
        Loc: Serenity.StringEditor;
        ItemNo: Serenity.StringEditor;
        Allocated: Serenity.StringEditor;
        ValueDate: Serenity.DateEditor;
        LogNo: Serenity.DecimalEditor;
        LineNo: Serenity.DecimalEditor;
        LogNoOut: Serenity.DecimalEditor;
        LineNoOut: Serenity.DecimalEditor;
        Qty: Serenity.DecimalEditor;
        Cost: Serenity.DecimalEditor;
    }

    [['Loc', () => Serenity.StringEditor]
   , ['ItemNo', () => Serenity.StringEditor]
   , ['Allocated', () => Serenity.StringEditor]
   , ['ValueDate', () => Serenity.DateEditor]
   , ['LogNo', () => Serenity.DecimalEditor]
   , ['LineNo', () => Serenity.DecimalEditor]
   , ['LogNoOut', () => Serenity.DecimalEditor]
   , ['LineNoOut', () => Serenity.DecimalEditor]
   , ['Qty', () => Serenity.DecimalEditor]
   , ['Cost', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(FifoControlForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

