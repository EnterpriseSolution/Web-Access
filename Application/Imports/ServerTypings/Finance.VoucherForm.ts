namespace Matrix.Finance {
    export class VoucherForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.Voucher';

    }

    export interface VoucherForm {
        VoucherType: Serenity.StringEditor;
        VoucherNo: Serenity.StringEditor;
        VoucherDate: Serenity.DateEditor;
        Period: Serenity.StringEditor;
        Reference: Serenity.StringEditor;
        Particulars: Serenity.StringEditor;
        TotalDebit: Serenity.DecimalEditor;
        TotalCredit: Serenity.DecimalEditor;
        DetailList: VoucherDetailEditor;
    }

    [['VoucherType', () => Serenity.StringEditor]
   , ['VoucherNo', () => Serenity.StringEditor]
   , ['VoucherDate', () => Serenity.DateEditor]
   , ['Period', () => Serenity.StringEditor]
   , ['Reference', () => Serenity.StringEditor]
   , ['Particulars', () => Serenity.StringEditor]
   , ['TotalDebit', () => Serenity.DecimalEditor]
   , ['TotalCredit', () => Serenity.DecimalEditor]
   , ['DetailList', () => VoucherDetailEditor]
].forEach(x => Object.defineProperty(VoucherForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

