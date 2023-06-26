
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountReconciliationAdjustmentDialog extends Serenity.EntityDialog<AccountReconciliationAdjustmentRow, any> {
        protected getFormKey() { return AccountReconciliationAdjustmentForm.formKey; }
        protected getIdProperty() { return AccountReconciliationAdjustmentRow.idProperty; }
        protected getLocalTextPrefix() { return AccountReconciliationAdjustmentRow.localTextPrefix; }
        protected getNameProperty() { return AccountReconciliationAdjustmentRow.nameProperty; }
        protected getService() { return AccountReconciliationAdjustmentService.baseUrl; }

        protected form = new AccountReconciliationAdjustmentForm(this.idPrefix);

    }
}