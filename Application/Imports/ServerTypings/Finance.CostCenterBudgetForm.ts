namespace Matrix.Finance {
    export class CostCenterBudgetForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.CostCenterBudget';

    }

    export interface CostCenterBudgetForm {
        AcctNo: Serenity.StringEditor;
        CostCentre: Serenity.StringEditor;
        Period: Serenity.StringEditor;
        BudgetDebit: Serenity.DecimalEditor;
        BudgetCredit: Serenity.DecimalEditor;
        BudgetDate: Serenity.DateEditor;
        BudgetBy: Serenity.StringEditor;
        TotalDebit: Serenity.DecimalEditor;
        TotalCredit: Serenity.DecimalEditor;
        ControlDebit: Serenity.BooleanEditor;
        ControlCredit: Serenity.BooleanEditor;
    }

    [['AcctNo', () => Serenity.StringEditor]
   , ['CostCentre', () => Serenity.StringEditor]
   , ['Period', () => Serenity.StringEditor]
   , ['BudgetDebit', () => Serenity.DecimalEditor]
   , ['BudgetCredit', () => Serenity.DecimalEditor]
   , ['BudgetDate', () => Serenity.DateEditor]
   , ['BudgetBy', () => Serenity.StringEditor]
   , ['TotalDebit', () => Serenity.DecimalEditor]
   , ['TotalCredit', () => Serenity.DecimalEditor]
   , ['ControlDebit', () => Serenity.BooleanEditor]
   , ['ControlCredit', () => Serenity.BooleanEditor]
].forEach(x => Object.defineProperty(CostCenterBudgetForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

