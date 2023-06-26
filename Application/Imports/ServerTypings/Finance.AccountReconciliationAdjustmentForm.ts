namespace Matrix.Finance {
    export class AccountReconciliationAdjustmentForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.AccountReconciliationAdjustment';

    }

    export interface AccountReconciliationAdjustmentForm {
        AdjAcctNo: Serenity.StringEditor;
        RefNo: Serenity.StringEditor;
        LineNo: Serenity.DecimalEditor;
        AcctNo: Serenity.StringEditor;
        CostCentre: Serenity.StringEditor;
        Dept: Serenity.StringEditor;
        LineRef: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        ExchRate: Serenity.DecimalEditor;
        Debit: Serenity.DecimalEditor;
        Credit: Serenity.DecimalEditor;
        CompLdgDebit: Serenity.DecimalEditor;
        CompLdgCredit: Serenity.DecimalEditor;
        LedgerDebit: Serenity.DecimalEditor;
        LedgerCredit: Serenity.DecimalEditor;
        Anlys1: Serenity.StringEditor;
        Anlys2: Serenity.StringEditor;
        Anlys3: Serenity.StringEditor;
        Anlys4: Serenity.StringEditor;
        Anlys5: Serenity.StringEditor;
        Anlys6: Serenity.StringEditor;
        OwnerBranch: Serenity.StringEditor;
        SourceBranch: Serenity.StringEditor;
        Particulars: Serenity.StringEditor;
    }

    [['AdjAcctNo', () => Serenity.StringEditor]
   , ['RefNo', () => Serenity.StringEditor]
   , ['LineNo', () => Serenity.DecimalEditor]
   , ['AcctNo', () => Serenity.StringEditor]
   , ['CostCentre', () => Serenity.StringEditor]
   , ['Dept', () => Serenity.StringEditor]
   , ['LineRef', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['ExchRate', () => Serenity.DecimalEditor]
   , ['Debit', () => Serenity.DecimalEditor]
   , ['Credit', () => Serenity.DecimalEditor]
   , ['CompLdgDebit', () => Serenity.DecimalEditor]
   , ['CompLdgCredit', () => Serenity.DecimalEditor]
   , ['LedgerDebit', () => Serenity.DecimalEditor]
   , ['LedgerCredit', () => Serenity.DecimalEditor]
   , ['Anlys1', () => Serenity.StringEditor]
   , ['Anlys2', () => Serenity.StringEditor]
   , ['Anlys3', () => Serenity.StringEditor]
   , ['Anlys4', () => Serenity.StringEditor]
   , ['Anlys5', () => Serenity.StringEditor]
   , ['Anlys6', () => Serenity.StringEditor]
   , ['OwnerBranch', () => Serenity.StringEditor]
   , ['SourceBranch', () => Serenity.StringEditor]
   , ['Particulars', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(AccountReconciliationAdjustmentForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

