namespace Matrix.Finance {
    export class AccountsPayableLedgerForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.AccountsPayableLedger';

    }

    export interface AccountsPayableLedgerForm {
        VendorNo: Serenity.StringEditor;
        VendorName: Serenity.StringEditor;
        Summary: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        Period: Serenity.StringEditor;
        VendorNo2: Serenity.StringEditor;
        Ccy2: Serenity.StringEditor;
        FiscalYear: Serenity.DecimalEditor;
        PeriodNo: Serenity.DecimalEditor;
        InvoAmt: Serenity.DecimalEditor;
        MemoAmt: Serenity.DecimalEditor;
        AdjAmt: Serenity.DecimalEditor;
        PayAmt: Serenity.DecimalEditor;
        DiscAmt: Serenity.DecimalEditor;
        DiffAmt: Serenity.DecimalEditor;
        BalBeg: Serenity.DecimalEditor;
        Credit: Serenity.DecimalEditor;
        Debit: Serenity.DecimalEditor;
        BalEnd: Serenity.DecimalEditor;
        LocalInvoAmt: Serenity.DecimalEditor;
        LocalMemoAmt: Serenity.DecimalEditor;
        LocalAdjAmt: Serenity.DecimalEditor;
        LocalPayAmt: Serenity.DecimalEditor;
        LocalDiscAmt: Serenity.DecimalEditor;
        LocalDiffAmt: Serenity.DecimalEditor;
        LocalBalBeg: Serenity.DecimalEditor;
        LocalCredit: Serenity.DecimalEditor;
        LocalDebit: Serenity.DecimalEditor;
        LocalBalEnd: Serenity.DecimalEditor;
        RfdAmt: Serenity.DecimalEditor;
        LocalRfdAmt: Serenity.DecimalEditor;
    }

    [['VendorNo', () => Serenity.StringEditor]
   , ['VendorName', () => Serenity.StringEditor]
   , ['Summary', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['Period', () => Serenity.StringEditor]
   , ['VendorNo2', () => Serenity.StringEditor]
   , ['Ccy2', () => Serenity.StringEditor]
   , ['FiscalYear', () => Serenity.DecimalEditor]
   , ['PeriodNo', () => Serenity.DecimalEditor]
   , ['InvoAmt', () => Serenity.DecimalEditor]
   , ['MemoAmt', () => Serenity.DecimalEditor]
   , ['AdjAmt', () => Serenity.DecimalEditor]
   , ['PayAmt', () => Serenity.DecimalEditor]
   , ['DiscAmt', () => Serenity.DecimalEditor]
   , ['DiffAmt', () => Serenity.DecimalEditor]
   , ['BalBeg', () => Serenity.DecimalEditor]
   , ['Credit', () => Serenity.DecimalEditor]
   , ['Debit', () => Serenity.DecimalEditor]
   , ['BalEnd', () => Serenity.DecimalEditor]
   , ['LocalInvoAmt', () => Serenity.DecimalEditor]
   , ['LocalMemoAmt', () => Serenity.DecimalEditor]
   , ['LocalAdjAmt', () => Serenity.DecimalEditor]
   , ['LocalPayAmt', () => Serenity.DecimalEditor]
   , ['LocalDiscAmt', () => Serenity.DecimalEditor]
   , ['LocalDiffAmt', () => Serenity.DecimalEditor]
   , ['LocalBalBeg', () => Serenity.DecimalEditor]
   , ['LocalCredit', () => Serenity.DecimalEditor]
   , ['LocalDebit', () => Serenity.DecimalEditor]
   , ['LocalBalEnd', () => Serenity.DecimalEditor]
   , ['RfdAmt', () => Serenity.DecimalEditor]
   , ['LocalRfdAmt', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(AccountsPayableLedgerForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

