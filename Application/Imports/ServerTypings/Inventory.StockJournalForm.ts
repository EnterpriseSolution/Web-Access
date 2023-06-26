namespace Matrix.Inventory {
    export class StockJournalForm extends Serenity.PrefixedContext {
        static formKey = 'Inventory.StockJournal';

    }

    export interface StockJournalForm {
        Loc: Serenity.StringEditor;
        ItemNo: Serenity.StringEditor;
        Period: Serenity.StringEditor;
        ValueDate: Serenity.DateEditor;
        LogNo: Serenity.DecimalEditor;
        LineNo: Serenity.DecimalEditor;
        MoveIn: Serenity.StringEditor;
        RefNo: Serenity.StringEditor;
        QtyIn: Serenity.DecimalEditor;
        QtyOut: Serenity.DecimalEditor;
        CostIn: Serenity.DecimalEditor;
        CostOut: Serenity.DecimalEditor;
        MoveDate: Serenity.DateEditor;
        LineRef: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        MoveType: Serenity.StringEditor;
        Reference: Serenity.StringEditor;
        Transfer: Serenity.StringEditor;
        FromTo: Serenity.StringEditor;
        BalQty: Serenity.DecimalEditor;
        BalCost: Serenity.DecimalEditor;
        BalQtyItem: Serenity.DecimalEditor;
        BalCostItem: Serenity.DecimalEditor;
        UnitCost: Serenity.DecimalEditor;
    }

    [['Loc', () => Serenity.StringEditor]
   , ['ItemNo', () => Serenity.StringEditor]
   , ['Period', () => Serenity.StringEditor]
   , ['ValueDate', () => Serenity.DateEditor]
   , ['LogNo', () => Serenity.DecimalEditor]
   , ['LineNo', () => Serenity.DecimalEditor]
   , ['MoveIn', () => Serenity.StringEditor]
   , ['RefNo', () => Serenity.StringEditor]
   , ['QtyIn', () => Serenity.DecimalEditor]
   , ['QtyOut', () => Serenity.DecimalEditor]
   , ['CostIn', () => Serenity.DecimalEditor]
   , ['CostOut', () => Serenity.DecimalEditor]
   , ['MoveDate', () => Serenity.DateEditor]
   , ['LineRef', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['MoveType', () => Serenity.StringEditor]
   , ['Reference', () => Serenity.StringEditor]
   , ['Transfer', () => Serenity.StringEditor]
   , ['FromTo', () => Serenity.StringEditor]
   , ['BalQty', () => Serenity.DecimalEditor]
   , ['BalCost', () => Serenity.DecimalEditor]
   , ['BalQtyItem', () => Serenity.DecimalEditor]
   , ['BalCostItem', () => Serenity.DecimalEditor]
   , ['UnitCost', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(StockJournalForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

