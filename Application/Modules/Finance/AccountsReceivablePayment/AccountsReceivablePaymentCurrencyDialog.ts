
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountsReceivablePaymentCurrencyDialog extends Serenity.EntityDialog<AccountsReceivablePaymentCurrencyRow, any> {
        protected getFormKey() { return AccountsReceivablePaymentCurrencyForm.formKey; }
        protected getIdProperty() { return AccountsReceivablePaymentCurrencyRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsReceivablePaymentCurrencyRow.localTextPrefix; }
        protected getNameProperty() { return AccountsReceivablePaymentCurrencyRow.nameProperty; }
        protected getService() { return AccountsReceivablePaymentCurrencyService.baseUrl; }

        protected form = new AccountsReceivablePaymentCurrencyForm(this.idPrefix);

    }
}