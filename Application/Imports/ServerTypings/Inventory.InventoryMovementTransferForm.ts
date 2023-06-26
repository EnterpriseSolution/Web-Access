namespace Matrix.Inventory {
    export class InventoryMovementTransferForm extends Serenity.PrefixedContext {
        static formKey = 'Inventory.InventoryMovementTransfer';

    }

    export interface InventoryMovementTransferForm {
        RefNo: Serenity.StringEditor;
        MoveType: Serenity.StringEditor;
        MoveDate: Serenity.DateEditor;
        LocFrom: Serenity.StringEditor;
        LocTo: Serenity.StringEditor;
        Reference: Serenity.StringEditor;
        SourceType: Serenity.StringEditor;
        SourceRef: Serenity.StringEditor;
        DetailList: InventoryMovementDetailEditor;
    }

    [['RefNo', () => Serenity.StringEditor]
   , ['MoveType', () => Serenity.StringEditor]
   , ['MoveDate', () => Serenity.DateEditor]
   , ['LocFrom', () => Serenity.StringEditor]
   , ['LocTo', () => Serenity.StringEditor]
   , ['Reference', () => Serenity.StringEditor]
   , ['SourceType', () => Serenity.StringEditor]
   , ['SourceRef', () => Serenity.StringEditor]
   , ['DetailList', () => InventoryMovementDetailEditor]
].forEach(x => Object.defineProperty(InventoryMovementTransferForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

