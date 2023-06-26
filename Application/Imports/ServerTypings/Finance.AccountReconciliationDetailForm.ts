namespace Matrix.Finance {
    export class AccountReconciliationDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.AccountReconciliationDetail';

    }

    export interface AccountReconciliationDetailForm {
        AcctNo: Serenity.StringEditor;
        RefNo: Serenity.StringEditor;
        VoucherDate: Serenity.DateEditor;
        JournalNo: Serenity.DecimalEditor;
        LineNo: Serenity.DecimalEditor;
        VoucherType: Serenity.StringEditor;
        VoucherNo: Serenity.StringEditor;
        Reference: Serenity.StringEditor;
        LineRef: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        Debit: Serenity.DecimalEditor;
        Credit: Serenity.DecimalEditor;
        LedgerAmt: Serenity.DecimalEditor;
        Sign: Serenity.StringEditor;
        IncludeThis: Serenity.StringEditor;
        OwnerBranch: Serenity.StringEditor;
        SourceBranch: Serenity.StringEditor;
        Particulars: Serenity.StringEditor;
    }

    [['AcctNo', () => Serenity.StringEditor]
   , ['RefNo', () => Serenity.StringEditor]
   , ['VoucherDate', () => Serenity.DateEditor]
   , ['JournalNo', () => Serenity.DecimalEditor]
   , ['LineNo', () => Serenity.DecimalEditor]
   , ['VoucherType', () => Serenity.StringEditor]
   , ['VoucherNo', () => Serenity.StringEditor]
   , ['Reference', () => Serenity.StringEditor]
   , ['LineRef', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['Debit', () => Serenity.DecimalEditor]
   , ['Credit', () => Serenity.DecimalEditor]
   , ['LedgerAmt', () => Serenity.DecimalEditor]
   , ['Sign', () => Serenity.StringEditor]
   , ['IncludeThis', () => Serenity.StringEditor]
   , ['OwnerBranch', () => Serenity.StringEditor]
   , ['SourceBranch', () => Serenity.StringEditor]
   , ['Particulars', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(AccountReconciliationDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

