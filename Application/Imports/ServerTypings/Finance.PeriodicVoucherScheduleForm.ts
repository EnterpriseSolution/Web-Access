namespace Matrix.Finance {
    export class PeriodicVoucherScheduleForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.PeriodicVoucherSchedule';

    }

    export interface PeriodicVoucherScheduleForm {
        EntryKey: Serenity.StringEditor;
        Period: Serenity.StringEditor;
        Suspended: Serenity.StringEditor;
        VoucherNo: Serenity.StringEditor;
        VoucherDate: Serenity.DateEditor;
        ExchRate: Serenity.DecimalEditor;
        DebitTotal: Serenity.DecimalEditor;
        CreditTotal: Serenity.DecimalEditor;
        SourceDate: Serenity.DateEditor;
        SourceBy: Serenity.StringEditor;
        CreatedDate: Serenity.DateEditor;
        CreatedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
    }

    [['EntryKey', () => Serenity.StringEditor]
   , ['Period', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.StringEditor]
   , ['VoucherNo', () => Serenity.StringEditor]
   , ['VoucherDate', () => Serenity.DateEditor]
   , ['ExchRate', () => Serenity.DecimalEditor]
   , ['DebitTotal', () => Serenity.DecimalEditor]
   , ['CreditTotal', () => Serenity.DecimalEditor]
   , ['SourceDate', () => Serenity.DateEditor]
   , ['SourceBy', () => Serenity.StringEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(PeriodicVoucherScheduleForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

