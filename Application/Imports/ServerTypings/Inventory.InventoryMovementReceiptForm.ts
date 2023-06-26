namespace Matrix.Inventory {
    export class InventoryMovementReceiptForm extends Serenity.PrefixedContext {
        static formKey = 'Inventory.InventoryMovementReceipt';

    }

    export interface InventoryMovementReceiptForm {
        RefNo: Serenity.StringEditor;
        MoveType: Serenity.StringEditor;
        MoveDate: Serenity.DateEditor;
        LocTo: Serenity.StringEditor;
        Reference: Serenity.StringEditor;
        SourceType: Serenity.StringEditor;
        SourceRef: Serenity.StringEditor;
        DetailList: InventoryMovementDetailEditor;
    }

    [['RefNo', () => Serenity.StringEditor]
   , ['MoveType', () => Serenity.StringEditor]
   , ['MoveDate', () => Serenity.DateEditor]
   , ['LocTo', () => Serenity.StringEditor]
   , ['Reference', () => Serenity.StringEditor]
   , ['SourceType', () => Serenity.StringEditor]
   , ['SourceRef', () => Serenity.StringEditor]
   , ['DetailList', () => InventoryMovementDetailEditor]
].forEach(x => Object.defineProperty(InventoryMovementReceiptForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

