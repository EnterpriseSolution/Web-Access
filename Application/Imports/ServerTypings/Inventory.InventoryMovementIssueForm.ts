namespace Matrix.Inventory {
    export class InventoryMovementIssueForm extends Serenity.PrefixedContext {
        static formKey = 'Inventory.InventoryMovementIssue';

    }

    export interface InventoryMovementIssueForm {
        RefNo: Serenity.StringEditor;
        MoveType: Serenity.StringEditor;
        MoveDate: Serenity.DateEditor;
        LocFrom: Serenity.StringEditor;
        Reference: Serenity.StringEditor;
        SourceType: Serenity.StringEditor;
        SourceRef: Serenity.StringEditor;
        DetailList: InventoryMovementDetailEditor;
    }

    [['RefNo', () => Serenity.StringEditor]
   , ['MoveType', () => Serenity.StringEditor]
   , ['MoveDate', () => Serenity.DateEditor]
   , ['LocFrom', () => Serenity.StringEditor]
   , ['Reference', () => Serenity.StringEditor]
   , ['SourceType', () => Serenity.StringEditor]
   , ['SourceRef', () => Serenity.StringEditor]
   , ['DetailList', () => InventoryMovementDetailEditor]
].forEach(x => Object.defineProperty(InventoryMovementIssueForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

