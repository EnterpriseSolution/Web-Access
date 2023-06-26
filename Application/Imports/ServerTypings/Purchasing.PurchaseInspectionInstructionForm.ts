namespace Matrix.Purchasing {
    export class PurchaseInspectionInstructionForm extends Serenity.PrefixedContext {
        static formKey = 'Purchasing.PurchaseInspectionInstruction';

    }

    export interface PurchaseInspectionInstructionForm {
        RefNo: Serenity.StringEditor;
        LineNo: Serenity.DecimalEditor;
        EntryNo: Serenity.DecimalEditor;
        InspectCode: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Remarks: Serenity.StringEditor;
        Qty: Serenity.DecimalEditor;
    }

    [['RefNo', () => Serenity.StringEditor]
   , ['LineNo', () => Serenity.DecimalEditor]
   , ['EntryNo', () => Serenity.DecimalEditor]
   , ['InspectCode', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Remarks', () => Serenity.StringEditor]
   , ['Qty', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(PurchaseInspectionInstructionForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

