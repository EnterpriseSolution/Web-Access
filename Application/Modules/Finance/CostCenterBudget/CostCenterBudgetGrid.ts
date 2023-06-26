
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class CostCenterBudgetGrid extends Serenity.EntityGrid<CostCenterBudgetRow, any> {
        protected getColumnsKey() { return 'Finance.CostCenterBudget'; }
        protected getDialogType() { return CostCenterBudgetDialog; }
        protected getIdProperty() { return CostCenterBudgetRow.idProperty; }
        protected getLocalTextPrefix() { return CostCenterBudgetRow.localTextPrefix; }
        protected getService() { return CostCenterBudgetService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}