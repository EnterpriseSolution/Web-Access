
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class AccountsReceivablePaymentDepositGrid extends Serenity.EntityGrid<AccountsReceivablePaymentDepositRow, any> {
        protected getColumnsKey() { return 'Finance.AccountsReceivablePaymentDeposit'; }
        protected getDialogType() { return AccountsReceivablePaymentDepositDialog; }
        protected getIdProperty() { return AccountsReceivablePaymentDepositRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsReceivablePaymentDepositRow.localTextPrefix; }
        protected getService() { return AccountsReceivablePaymentDepositService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}