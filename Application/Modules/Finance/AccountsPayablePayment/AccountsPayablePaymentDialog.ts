
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountsPayablePaymentDialog extends Serenity.EntityDialog<AccountsPayablePaymentRow, any> {
        protected getFormKey() { return AccountsPayablePaymentForm.formKey; }
        protected getIdProperty() { return AccountsPayablePaymentRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsPayablePaymentRow.localTextPrefix; }
        protected getNameProperty() { return AccountsPayablePaymentRow.nameProperty; }
        protected getService() { return AccountsPayablePaymentService.baseUrl; }

        protected form = new AccountsPayablePaymentForm(this.idPrefix);

    }
}