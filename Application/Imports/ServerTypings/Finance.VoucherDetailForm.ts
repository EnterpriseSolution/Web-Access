namespace Matrix.Finance {
    export class VoucherDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.VoucherDetail';

    }

    export interface VoucherDetailForm {
        VoucherType: Serenity.StringEditor;
        VoucherNo: Serenity.StringEditor;
        LineNo: Serenity.DecimalEditor;
        AcctNo: Serenity.StringEditor;
        AcctName: Serenity.StringEditor;
        BranchNo: Serenity.StringEditor;
        CostCentre: Serenity.StringEditor;
        Dept: Serenity.StringEditor;
        LineRef: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        ExchRate: Serenity.DecimalEditor;
        Debit: Serenity.DecimalEditor;
        Credit: Serenity.DecimalEditor;
        ForexAmt: Serenity.DecimalEditor;
        LedgerAmt: Serenity.DecimalEditor;
        Sign: Serenity.StringEditor;
        LedgerDebit: Serenity.DecimalEditor;
        LedgerCredit: Serenity.DecimalEditor;
        Anlys1: Serenity.StringEditor;
        Anlys2: Serenity.StringEditor;
        Anlys3: Serenity.StringEditor;
        Anlys4: Serenity.StringEditor;
        Anlys5: Serenity.StringEditor;
        Anlys6: Serenity.StringEditor;
        Posted: Serenity.StringEditor;
        Reconciled: Serenity.StringEditor;
        Period: Serenity.StringEditor;
        FiscalYear: Serenity.DecimalEditor;
        PeriodNo: Serenity.DecimalEditor;
        JournalNo: Serenity.DecimalEditor;
        VoucherDate: Serenity.DateEditor;
        LedgerAmtCpd: Serenity.DecimalEditor;
        Reference: Serenity.StringEditor;
        PostedDate: Serenity.DateEditor;
        RunningBalance: Serenity.DecimalEditor;
        BalanceSign: Serenity.StringEditor;
        ExchDiff: Serenity.StringEditor;
        Particulars: Serenity.StringEditor;
        ItemGroup: Serenity.StringEditor;
        Anlys15: Serenity.StringEditor;
        Anlys16: Serenity.StringEditor;
        Anlys17: Serenity.StringEditor;
        Anlys18: Serenity.StringEditor;
        Anlys19: Serenity.StringEditor;
        Anlys20: Serenity.StringEditor;
        InvoiceNo: Serenity.StringEditor;
    }

    [['VoucherType', () => Serenity.StringEditor]
   , ['VoucherNo', () => Serenity.StringEditor]
   , ['LineNo', () => Serenity.DecimalEditor]
   , ['AcctNo', () => Serenity.StringEditor]
   , ['AcctName', () => Serenity.StringEditor]
   , ['BranchNo', () => Serenity.StringEditor]
   , ['CostCentre', () => Serenity.StringEditor]
   , ['Dept', () => Serenity.StringEditor]
   , ['LineRef', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['ExchRate', () => Serenity.DecimalEditor]
   , ['Debit', () => Serenity.DecimalEditor]
   , ['Credit', () => Serenity.DecimalEditor]
   , ['ForexAmt', () => Serenity.DecimalEditor]
   , ['LedgerAmt', () => Serenity.DecimalEditor]
   , ['Sign', () => Serenity.StringEditor]
   , ['LedgerDebit', () => Serenity.DecimalEditor]
   , ['LedgerCredit', () => Serenity.DecimalEditor]
   , ['Anlys1', () => Serenity.StringEditor]
   , ['Anlys2', () => Serenity.StringEditor]
   , ['Anlys3', () => Serenity.StringEditor]
   , ['Anlys4', () => Serenity.StringEditor]
   , ['Anlys5', () => Serenity.StringEditor]
   , ['Anlys6', () => Serenity.StringEditor]
   , ['Posted', () => Serenity.StringEditor]
   , ['Reconciled', () => Serenity.StringEditor]
   , ['Period', () => Serenity.StringEditor]
   , ['FiscalYear', () => Serenity.DecimalEditor]
   , ['PeriodNo', () => Serenity.DecimalEditor]
   , ['JournalNo', () => Serenity.DecimalEditor]
   , ['VoucherDate', () => Serenity.DateEditor]
   , ['LedgerAmtCpd', () => Serenity.DecimalEditor]
   , ['Reference', () => Serenity.StringEditor]
   , ['PostedDate', () => Serenity.DateEditor]
   , ['RunningBalance', () => Serenity.DecimalEditor]
   , ['BalanceSign', () => Serenity.StringEditor]
   , ['ExchDiff', () => Serenity.StringEditor]
   , ['Particulars', () => Serenity.StringEditor]
   , ['ItemGroup', () => Serenity.StringEditor]
   , ['Anlys15', () => Serenity.StringEditor]
   , ['Anlys16', () => Serenity.StringEditor]
   , ['Anlys17', () => Serenity.StringEditor]
   , ['Anlys18', () => Serenity.StringEditor]
   , ['Anlys19', () => Serenity.StringEditor]
   , ['Anlys20', () => Serenity.StringEditor]
   , ['InvoiceNo', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(VoucherDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

