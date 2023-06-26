
namespace Matrix.MasterData {
    //import AccountBudgetRow = Matrix.Finance.AccountBudgetRow;
    //import AccountBudgetService = Matrix.Finance.AccountBudgetService;

    @Serenity.Decorators.registerClass()
    export class AccountBudgetGrid extends Serenity.EntityGrid<AccountBudgetRow, any> {
        protected getColumnsKey() { return 'Finance.AccountBudget'; }
        protected getDialogType() { return AccountBudgetDialog; }
        protected getIdProperty() { return AccountBudgetRow.idProperty; }
        protected getLocalTextPrefix() { return AccountBudgetRow.localTextPrefix; }
        protected getService() { return AccountBudgetService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}