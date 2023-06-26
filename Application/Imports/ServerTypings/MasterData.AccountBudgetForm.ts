namespace Matrix.MasterData {
    export class AccountBudgetForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.AccountBudget';

    }

    export interface AccountBudgetForm {
        AcctNo: Serenity.StringEditor;
        Period: Serenity.StringEditor;
        FiscalYear: Serenity.DecimalEditor;
        PeriodNo: Serenity.DecimalEditor;
        TotalDebit: Serenity.DecimalEditor;
        TotalCredit: Serenity.DecimalEditor;
        ControlDebit: Serenity.StringEditor;
        ControlCredit: Serenity.StringEditor;
        BudgetDebit: Serenity.DecimalEditor;
        BudgetCredit: Serenity.DecimalEditor;
        BudgetDate: Serenity.DateEditor;
        BudgetBy: Serenity.StringEditor;
    }

    [['AcctNo', () => Serenity.StringEditor]
   , ['Period', () => Serenity.StringEditor]
   , ['FiscalYear', () => Serenity.DecimalEditor]
   , ['PeriodNo', () => Serenity.DecimalEditor]
   , ['TotalDebit', () => Serenity.DecimalEditor]
   , ['TotalCredit', () => Serenity.DecimalEditor]
   , ['ControlDebit', () => Serenity.StringEditor]
   , ['ControlCredit', () => Serenity.StringEditor]
   , ['BudgetDebit', () => Serenity.DecimalEditor]
   , ['BudgetCredit', () => Serenity.DecimalEditor]
   , ['BudgetDate', () => Serenity.DateEditor]
   , ['BudgetBy', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(AccountBudgetForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

