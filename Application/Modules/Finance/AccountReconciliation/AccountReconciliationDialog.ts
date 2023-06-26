
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountReconciliationDialog extends Serenity.EntityDialog<AccountReconciliationRow, any> {
        protected getFormKey() { return AccountReconciliationForm.formKey; }
        protected getIdProperty() { return AccountReconciliationRow.idProperty; }
        protected getLocalTextPrefix() { return AccountReconciliationRow.localTextPrefix; }
        protected getNameProperty() { return AccountReconciliationRow.nameProperty; }
        protected getService() { return AccountReconciliationService.baseUrl; }

        protected form = new AccountReconciliationForm(this.idPrefix);

    }
}