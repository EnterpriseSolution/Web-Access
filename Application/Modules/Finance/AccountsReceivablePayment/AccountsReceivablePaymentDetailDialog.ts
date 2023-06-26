
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountsReceivablePaymentDetailDialog extends Serenity.EntityDialog<AccountsReceivablePaymentDetailRow, any> {
        protected getFormKey() { return AccountsReceivablePaymentDetailForm.formKey; }
        protected getIdProperty() { return AccountsReceivablePaymentDetailRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsReceivablePaymentDetailRow.localTextPrefix; }
        protected getNameProperty() { return AccountsReceivablePaymentDetailRow.nameProperty; }
        protected getService() { return AccountsReceivablePaymentDetailService.baseUrl; }

        protected form = new AccountsReceivablePaymentDetailForm(this.idPrefix);

    }
}