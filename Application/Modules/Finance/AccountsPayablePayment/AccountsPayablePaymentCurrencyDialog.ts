
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountsPayablePaymentCurrencyDialog extends Serenity.EntityDialog<AccountsPayablePaymentCurrencyRow, any> {
        protected getFormKey() { return AccountsPayablePaymentCurrencyForm.formKey; }
        protected getIdProperty() { return AccountsPayablePaymentCurrencyRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsPayablePaymentCurrencyRow.localTextPrefix; }
        protected getNameProperty() { return AccountsPayablePaymentCurrencyRow.nameProperty; }
        protected getService() { return AccountsPayablePaymentCurrencyService.baseUrl; }

        protected form = new AccountsPayablePaymentCurrencyForm(this.idPrefix);

    }
}