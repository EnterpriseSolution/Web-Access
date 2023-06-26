namespace Matrix.Finance {
    export class PeriodicVoucherForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.PeriodicVoucher';

    }

    export interface PeriodicVoucherForm {
        EntryKey: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        VoucherType: Serenity.StringEditor;
        SeriesCode: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        EffectiveFrom: Serenity.DateEditor;
        EffectiveTo: Serenity.DateEditor;
        TotalDebit: Serenity.DecimalEditor;
        TotalCredit: Serenity.DecimalEditor;
        Reference: Serenity.TextAreaEditor;
        Particulars: Serenity.TextAreaEditor;
        DetailList: PeriodicVoucherDetailEditor;
        ScheduleList: PeriodicVoucherScheduleDetailEditor;
    }

    [['EntryKey', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['VoucherType', () => Serenity.StringEditor]
   , ['SeriesCode', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['EffectiveFrom', () => Serenity.DateEditor]
   , ['EffectiveTo', () => Serenity.DateEditor]
   , ['TotalDebit', () => Serenity.DecimalEditor]
   , ['TotalCredit', () => Serenity.DecimalEditor]
   , ['Reference', () => Serenity.TextAreaEditor]
   , ['Particulars', () => Serenity.TextAreaEditor]
   , ['DetailList', () => PeriodicVoucherDetailEditor]
   , ['ScheduleList', () => PeriodicVoucherScheduleDetailEditor]
].forEach(x => Object.defineProperty(PeriodicVoucherForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

