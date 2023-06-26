namespace Matrix.Finance {
    export class AccountsReceivableCommissionForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.AccountsReceivableCommission';

    }

    export interface AccountsReceivableCommissionForm {
        Salesman: Serenity.StringEditor;
        SalesmanName: Serenity.StringEditor;
        Rate: Serenity.DecimalEditor;
    }

    [['Salesman', () => Serenity.StringEditor]
   , ['SalesmanName', () => Serenity.StringEditor]
   , ['Rate', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(AccountsReceivableCommissionForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

