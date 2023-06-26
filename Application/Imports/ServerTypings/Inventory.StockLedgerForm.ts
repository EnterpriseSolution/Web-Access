namespace Matrix.Inventory {
    export class StockLedgerForm extends Serenity.PrefixedContext {
        static formKey = 'Inventory.StockLedger';

    }

    export interface StockLedgerForm {
        Loc: Serenity.StringEditor;
        ItemNo: Serenity.StringEditor;
        Period: Serenity.StringEditor;
        QtyBeg: Serenity.DecimalEditor;
        QtyIn: Serenity.DecimalEditor;
        QtyOut: Serenity.DecimalEditor;
        QtyEnd: Serenity.DecimalEditor;
        QtyInTrf: Serenity.DecimalEditor;
        QtyOutTrf: Serenity.DecimalEditor;
        CostInTrf: Serenity.DecimalEditor;
        CostOutTrf: Serenity.DecimalEditor;
        ValueBeg: Serenity.DecimalEditor;
        CostIn: Serenity.DecimalEditor;
        CostOut: Serenity.DecimalEditor;
        ValueEnd: Serenity.DecimalEditor;
    }

    [['Loc', () => Serenity.StringEditor]
   , ['ItemNo', () => Serenity.StringEditor]
   , ['Period', () => Serenity.StringEditor]
   , ['QtyBeg', () => Serenity.DecimalEditor]
   , ['QtyIn', () => Serenity.DecimalEditor]
   , ['QtyOut', () => Serenity.DecimalEditor]
   , ['QtyEnd', () => Serenity.DecimalEditor]
   , ['QtyInTrf', () => Serenity.DecimalEditor]
   , ['QtyOutTrf', () => Serenity.DecimalEditor]
   , ['CostInTrf', () => Serenity.DecimalEditor]
   , ['CostOutTrf', () => Serenity.DecimalEditor]
   , ['ValueBeg', () => Serenity.DecimalEditor]
   , ['CostIn', () => Serenity.DecimalEditor]
   , ['CostOut', () => Serenity.DecimalEditor]
   , ['ValueEnd', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(StockLedgerForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

