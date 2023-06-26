namespace Matrix.Inventory {
    export class ItemLotSerialForm extends Serenity.PrefixedContext {
        static formKey = 'Inventory.ItemLotSerial';

    }

    export interface ItemLotSerialForm {
        ItemNo: Serenity.StringEditor;
        SerialNo: Serenity.StringEditor;
        Loc: Serenity.StringEditor;
        BinNo: Serenity.StringEditor;
        LotNo: Serenity.StringEditor;
        Closed: Serenity.StringEditor;
        ExpiryDate: Serenity.DateEditor;
        SourceType: Serenity.StringEditor;
        SourceRef: Serenity.StringEditor;
        SourceEntryNo: Serenity.DecimalEditor;
    }

    [['ItemNo', () => Serenity.StringEditor]
   , ['SerialNo', () => Serenity.StringEditor]
   , ['Loc', () => Serenity.StringEditor]
   , ['BinNo', () => Serenity.StringEditor]
   , ['LotNo', () => Serenity.StringEditor]
   , ['Closed', () => Serenity.StringEditor]
   , ['ExpiryDate', () => Serenity.DateEditor]
   , ['SourceType', () => Serenity.StringEditor]
   , ['SourceRef', () => Serenity.StringEditor]
   , ['SourceEntryNo', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(ItemLotSerialForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

