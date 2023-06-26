namespace Matrix.Inventory {
    export class ItemLotForm extends Serenity.PrefixedContext {
        static formKey = 'Inventory.ItemLot';

    }

    export interface ItemLotForm {
        ItemNo: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Loc: Serenity.StringEditor;
        BinNo: Serenity.StringEditor;
        LotNo: Serenity.StringEditor;
        Closed: Serenity.StringEditor;
        LocSummary: Serenity.StringEditor;
        QtyShipped: Serenity.DecimalEditor;
        QtyReceived: Serenity.DecimalEditor;
        QtyIssued: Serenity.DecimalEditor;
        QtyFinished: Serenity.DecimalEditor;
        QtyBalance: Serenity.DecimalEditor;
        ExpiryDate: Serenity.DateEditor;
        Uom: Serenity.StringEditor;
        Remarks: Serenity.StringEditor;
        UnitCost: Serenity.DecimalEditor;
        UserDefinedField01: Serenity.StringEditor;
        UserDefinedField02: Serenity.StringEditor;
        UserDefinedField03: Serenity.StringEditor;
        UserDefinedField04: Serenity.StringEditor;
        UserDefinedField05: Serenity.StringEditor;
        FifoLogNo: Serenity.DecimalEditor;
        FifoLineNo: Serenity.DecimalEditor;
    }

    [['ItemNo', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Loc', () => Serenity.StringEditor]
   , ['BinNo', () => Serenity.StringEditor]
   , ['LotNo', () => Serenity.StringEditor]
   , ['Closed', () => Serenity.StringEditor]
   , ['LocSummary', () => Serenity.StringEditor]
   , ['QtyShipped', () => Serenity.DecimalEditor]
   , ['QtyReceived', () => Serenity.DecimalEditor]
   , ['QtyIssued', () => Serenity.DecimalEditor]
   , ['QtyFinished', () => Serenity.DecimalEditor]
   , ['QtyBalance', () => Serenity.DecimalEditor]
   , ['ExpiryDate', () => Serenity.DateEditor]
   , ['Uom', () => Serenity.StringEditor]
   , ['Remarks', () => Serenity.StringEditor]
   , ['UnitCost', () => Serenity.DecimalEditor]
   , ['UserDefinedField01', () => Serenity.StringEditor]
   , ['UserDefinedField02', () => Serenity.StringEditor]
   , ['UserDefinedField03', () => Serenity.StringEditor]
   , ['UserDefinedField04', () => Serenity.StringEditor]
   , ['UserDefinedField05', () => Serenity.StringEditor]
   , ['FifoLogNo', () => Serenity.DecimalEditor]
   , ['FifoLineNo', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(ItemLotForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

