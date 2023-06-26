namespace Matrix.EnterpriseSys {
    export class ReportDialogOptionForm extends Serenity.PrefixedContext {
        static formKey = 'EnterpriseSys.ReportDialogOption';

    }

    export interface ReportDialogOptionForm {
        OptionNo: Serenity.IntegerEditor;
        SeqNo: Serenity.IntegerEditor;
        Caption: Serenity.StringEditor;
        FieldName: Serenity.StringEditor;
        FieldType: Serenity.IntegerEditor;
        Style: Serenity.IntegerEditor;
        DataType: Serenity.IntegerEditor;
        CapsLock: Serenity.BooleanEditor;
        LookupName: Serenity.StringEditor;
        LookupFilterName: Serenity.StringEditor;
        Required: Serenity.BooleanEditor;
    }

    [['OptionNo', () => Serenity.IntegerEditor]
   , ['SeqNo', () => Serenity.IntegerEditor]
   , ['Caption', () => Serenity.StringEditor]
   , ['FieldName', () => Serenity.StringEditor]
   , ['FieldType', () => Serenity.IntegerEditor]
   , ['Style', () => Serenity.IntegerEditor]
   , ['DataType', () => Serenity.IntegerEditor]
   , ['CapsLock', () => Serenity.BooleanEditor]
   , ['LookupName', () => Serenity.StringEditor]
   , ['LookupFilterName', () => Serenity.StringEditor]
   , ['Required', () => Serenity.BooleanEditor]
].forEach(x => Object.defineProperty(ReportDialogOptionForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

