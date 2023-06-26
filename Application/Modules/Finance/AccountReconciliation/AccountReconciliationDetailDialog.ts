
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountReconciliationDetailDialog extends Serenity.EntityDialog<AccountReconciliationDetailRow, any> {
        protected getFormKey() { return AccountReconciliationDetailForm.formKey; }
        protected getIdProperty() { return AccountReconciliationDetailRow.idProperty; }
        protected getLocalTextPrefix() { return AccountReconciliationDetailRow.localTextPrefix; }
        protected getNameProperty() { return AccountReconciliationDetailRow.nameProperty; }
        protected getService() { return AccountReconciliationDetailService.baseUrl; }

        protected form = new AccountReconciliationDetailForm(this.idPrefix);

    }
}