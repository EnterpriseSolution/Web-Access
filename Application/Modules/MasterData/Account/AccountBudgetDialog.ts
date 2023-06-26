///// <reference path="../../../Imports/ServerTypings/Finance.AccountBudgetForm.ts" />

namespace Matrix.MasterData {
   
    //import AccountBudgetRow = Matrix.Finance.AccountBudgetRow;
    //import AccountBudgetService = Matrix.Finance.AccountBudgetService;
    //import AccountBudgetForm = Matrix.Finance.AccountBudgetForm;
    

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountBudgetDialog extends Serenity.EntityDialog<AccountBudgetRow, any> {
        protected getFormKey() { return AccountBudgetForm.formKey; }
        protected getIdProperty() { return AccountBudgetRow.idProperty; }
        protected getLocalTextPrefix() { return AccountBudgetRow.localTextPrefix; }
        protected getNameProperty() { return AccountBudgetRow.nameProperty; }
        protected getService() { return AccountBudgetService.baseUrl; }

        protected form = new AccountBudgetForm(this.idPrefix);

    }
}