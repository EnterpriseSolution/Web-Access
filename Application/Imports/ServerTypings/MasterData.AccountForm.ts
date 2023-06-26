namespace Matrix.MasterData {
    export class AccountForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Account';

    }

    export interface AccountForm {
        AcctNo: Serenity.StringEditor;
        AcctName: Serenity.StringEditor;
        DefaultCcy: Serenity.StringEditor;
        TypeBs: Serenity.BooleanEditor;
        TypePl: Serenity.BooleanEditor;
        Suspended: Serenity.BooleanEditor;
        FixedCurrency: Serenity.StringEditor;
        BudgetControl: Serenity.StringEditor;
        SupprReval: Serenity.StringEditor;
        AllowEdit: Serenity.StringEditor;
        DetailList: AccountBudgetDetailEditor;
    }

    [['AcctNo', () => Serenity.StringEditor]
   , ['AcctName', () => Serenity.StringEditor]
   , ['DefaultCcy', () => Serenity.StringEditor]
   , ['TypeBs', () => Serenity.BooleanEditor]
   , ['TypePl', () => Serenity.BooleanEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['FixedCurrency', () => Serenity.StringEditor]
   , ['BudgetControl', () => Serenity.StringEditor]
   , ['SupprReval', () => Serenity.StringEditor]
   , ['AllowEdit', () => Serenity.StringEditor]
   , ['DetailList', () => AccountBudgetDetailEditor]
].forEach(x => Object.defineProperty(AccountForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

