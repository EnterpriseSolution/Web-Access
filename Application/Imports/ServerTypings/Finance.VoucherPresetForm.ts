namespace Matrix.Finance {
    export class VoucherPresetForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.VoucherPreset';

    }

    export interface VoucherPresetForm {
        VoucherType: Serenity.StringEditor;
        SeqNo: Serenity.DecimalEditor;
        AcctNo: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        ExchRate: Serenity.DecimalEditor;
        DebitAmt: Serenity.DecimalEditor;
        CreditAmt: Serenity.DecimalEditor;
        BaseLineNo: Serenity.DecimalEditor;
        BaseEntry: Serenity.StringEditor;
        ResultPercent: Serenity.DecimalEditor;
        ResultSign: Serenity.StringEditor;
        CostCentre: Serenity.StringEditor;
        Dept: Serenity.StringEditor;
        Particulars: Serenity.TextAreaEditor;
    }

    [['VoucherType', () => Serenity.StringEditor]
   , ['SeqNo', () => Serenity.DecimalEditor]
   , ['AcctNo', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['ExchRate', () => Serenity.DecimalEditor]
   , ['DebitAmt', () => Serenity.DecimalEditor]
   , ['CreditAmt', () => Serenity.DecimalEditor]
   , ['BaseLineNo', () => Serenity.DecimalEditor]
   , ['BaseEntry', () => Serenity.StringEditor]
   , ['ResultPercent', () => Serenity.DecimalEditor]
   , ['ResultSign', () => Serenity.StringEditor]
   , ['CostCentre', () => Serenity.StringEditor]
   , ['Dept', () => Serenity.StringEditor]
   , ['Particulars', () => Serenity.TextAreaEditor]
].forEach(x => Object.defineProperty(VoucherPresetForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

