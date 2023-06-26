
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class AccountsReceivablePaymentCurrencyGrid extends Serenity.EntityGrid<AccountsReceivablePaymentCurrencyRow, any> {
        protected getColumnsKey() { return 'Finance.AccountsReceivablePaymentCurrency'; }
        protected getDialogType() { return AccountsReceivablePaymentCurrencyDialog; }
        protected getIdProperty() { return AccountsReceivablePaymentCurrencyRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsReceivablePaymentCurrencyRow.localTextPrefix; }
        protected getService() { return AccountsReceivablePaymentCurrencyService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}