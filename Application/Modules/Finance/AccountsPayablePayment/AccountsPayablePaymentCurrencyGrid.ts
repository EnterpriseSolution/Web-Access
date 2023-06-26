
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class AccountsPayablePaymentCurrencyGrid extends Serenity.EntityGrid<AccountsPayablePaymentCurrencyRow, any> {
        protected getColumnsKey() { return 'Finance.AccountsPayablePaymentCurrency'; }
        protected getDialogType() { return AccountsPayablePaymentCurrencyDialog; }
        protected getIdProperty() { return AccountsPayablePaymentCurrencyRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsPayablePaymentCurrencyRow.localTextPrefix; }
        protected getService() { return AccountsPayablePaymentCurrencyService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}