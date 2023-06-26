namespace Matrix.Finance {
    export class AccountsReceivableLedgerForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.AccountsReceivableLedger';

    }

    export interface AccountsReceivableLedgerForm {
        CustomerNo: Serenity.StringEditor;
        CustomerName: Serenity.StringEditor;
        Summary: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        Period: Serenity.StringEditor;
        InvoAmt: Serenity.DecimalEditor;
        MemoAmt: Serenity.DecimalEditor;
        AdjAmt: Serenity.DecimalEditor;
        PayAmt: Serenity.DecimalEditor;
        DiscAmt: Serenity.DecimalEditor;
        DiffAmt: Serenity.DecimalEditor;
        BalBeg: Serenity.DecimalEditor;
        Debit: Serenity.DecimalEditor;
        Credit: Serenity.DecimalEditor;
        BalEnd: Serenity.DecimalEditor;
        RfdAmt: Serenity.DecimalEditor;
        LocalInvoAmt: Serenity.DecimalEditor;
        LocalMemoAmt: Serenity.DecimalEditor;
        LocalAdjAmt: Serenity.DecimalEditor;
        LocalPayAmt: Serenity.DecimalEditor;
        LocalDiscAmt: Serenity.DecimalEditor;
        LocalDiffAmt: Serenity.DecimalEditor;
        LocalBalBeg: Serenity.DecimalEditor;
        LocalDebit: Serenity.DecimalEditor;
        LocalCredit: Serenity.DecimalEditor;
        LocalBalEnd: Serenity.DecimalEditor;
        LocalRfdAmt: Serenity.DecimalEditor;
    }

    [['CustomerNo', () => Serenity.StringEditor]
   , ['CustomerName', () => Serenity.StringEditor]
   , ['Summary', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['Period', () => Serenity.StringEditor]
   , ['InvoAmt', () => Serenity.DecimalEditor]
   , ['MemoAmt', () => Serenity.DecimalEditor]
   , ['AdjAmt', () => Serenity.DecimalEditor]
   , ['PayAmt', () => Serenity.DecimalEditor]
   , ['DiscAmt', () => Serenity.DecimalEditor]
   , ['DiffAmt', () => Serenity.DecimalEditor]
   , ['BalBeg', () => Serenity.DecimalEditor]
   , ['Debit', () => Serenity.DecimalEditor]
   , ['Credit', () => Serenity.DecimalEditor]
   , ['BalEnd', () => Serenity.DecimalEditor]
   , ['RfdAmt', () => Serenity.DecimalEditor]
   , ['LocalInvoAmt', () => Serenity.DecimalEditor]
   , ['LocalMemoAmt', () => Serenity.DecimalEditor]
   , ['LocalAdjAmt', () => Serenity.DecimalEditor]
   , ['LocalPayAmt', () => Serenity.DecimalEditor]
   , ['LocalDiscAmt', () => Serenity.DecimalEditor]
   , ['LocalDiffAmt', () => Serenity.DecimalEditor]
   , ['LocalBalBeg', () => Serenity.DecimalEditor]
   , ['LocalDebit', () => Serenity.DecimalEditor]
   , ['LocalCredit', () => Serenity.DecimalEditor]
   , ['LocalBalEnd', () => Serenity.DecimalEditor]
   , ['LocalRfdAmt', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(AccountsReceivableLedgerForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

