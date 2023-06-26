
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountsPayablePaymentDetailDialog extends Serenity.EntityDialog<AccountsPayablePaymentDetailRow, any> {
        protected getFormKey() { return AccountsPayablePaymentDetailForm.formKey; }
        protected getIdProperty() { return AccountsPayablePaymentDetailRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsPayablePaymentDetailRow.localTextPrefix; }
        protected getNameProperty() { return AccountsPayablePaymentDetailRow.nameProperty; }
        protected getService() { return AccountsPayablePaymentDetailService.baseUrl; }

        protected form = new AccountsPayablePaymentDetailForm(this.idPrefix);

    }
}