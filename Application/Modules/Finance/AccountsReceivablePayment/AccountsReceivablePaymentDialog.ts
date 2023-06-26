
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountsReceivablePaymentDialog extends Serenity.EntityDialog<AccountsReceivablePaymentRow, any> {
        protected getFormKey() { return AccountsReceivablePaymentForm.formKey; }
        protected getIdProperty() { return AccountsReceivablePaymentRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsReceivablePaymentRow.localTextPrefix; }
        protected getNameProperty() { return AccountsReceivablePaymentRow.nameProperty; }
        protected getService() { return AccountsReceivablePaymentService.baseUrl; }

        protected form = new AccountsReceivablePaymentForm(this.idPrefix);

    }
}