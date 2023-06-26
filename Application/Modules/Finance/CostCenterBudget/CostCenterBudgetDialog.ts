
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class CostCenterBudgetDialog extends Serenity.EntityDialog<CostCenterBudgetRow, any> {
        protected getFormKey() { return CostCenterBudgetForm.formKey; }
        protected getIdProperty() { return CostCenterBudgetRow.idProperty; }
        protected getLocalTextPrefix() { return CostCenterBudgetRow.localTextPrefix; }
        protected getNameProperty() { return CostCenterBudgetRow.nameProperty; }
        protected getService() { return CostCenterBudgetService.baseUrl; }

        protected form = new CostCenterBudgetForm(this.idPrefix);

    }
}