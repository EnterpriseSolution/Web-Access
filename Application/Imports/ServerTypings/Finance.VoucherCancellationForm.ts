namespace Matrix.Finance {
    export class VoucherCancellationForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.VoucherCancellation';

    }

    export interface VoucherCancellationForm {
        RefNo: Serenity.StringEditor;
        PostedDate: Serenity.DateEditor;
        PostedBy: Serenity.StringEditor;
        Posted: Serenity.StringEditor;
        VoucherType: Serenity.StringEditor;
        VoucherNo: Serenity.StringEditor;
        TranDate: Serenity.DateEditor;
        Particulars: Serenity.TextAreaEditor;
    }

    [['RefNo', () => Serenity.StringEditor]
   , ['PostedDate', () => Serenity.DateEditor]
   , ['PostedBy', () => Serenity.StringEditor]
   , ['Posted', () => Serenity.StringEditor]
   , ['VoucherType', () => Serenity.StringEditor]
   , ['VoucherNo', () => Serenity.StringEditor]
   , ['TranDate', () => Serenity.DateEditor]
   , ['Particulars', () => Serenity.TextAreaEditor]
].forEach(x => Object.defineProperty(VoucherCancellationForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

