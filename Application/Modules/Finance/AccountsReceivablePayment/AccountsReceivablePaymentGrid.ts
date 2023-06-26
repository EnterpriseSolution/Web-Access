
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class AccountsReceivablePaymentGrid extends Serenity.EntityGrid<AccountsReceivablePaymentRow, any> {
        protected getColumnsKey() { return 'Finance.AccountsReceivablePayment'; }
        protected getDialogType() { return AccountsReceivablePaymentDialog; }
        protected getIdProperty() { return AccountsReceivablePaymentRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsReceivablePaymentRow.localTextPrefix; }
        protected getService() { return AccountsReceivablePaymentService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}