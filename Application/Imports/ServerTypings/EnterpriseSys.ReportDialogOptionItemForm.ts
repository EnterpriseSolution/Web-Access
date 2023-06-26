namespace Matrix.EnterpriseSys {
    export class ReportDialogOptionItemForm extends Serenity.PrefixedContext {
        static formKey = 'EnterpriseSys.ReportDialogOptionItem';

    }

    export interface ReportDialogOptionItemForm {
        OptionNo: Serenity.IntegerEditor;
        EntryNo: Serenity.IntegerEditor;
        Caption: Serenity.StringEditor;
        Value: Serenity.StringEditor;
    }

    [['OptionNo', () => Serenity.IntegerEditor]
   , ['EntryNo', () => Serenity.IntegerEditor]
   , ['Caption', () => Serenity.StringEditor]
   , ['Value', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(ReportDialogOptionItemForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

