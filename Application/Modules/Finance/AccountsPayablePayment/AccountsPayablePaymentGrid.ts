
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class AccountsPayablePaymentGrid extends Serenity.EntityGrid<AccountsPayablePaymentRow, any> {
        protected getColumnsKey() { return 'Finance.AccountsPayablePayment'; }
        protected getDialogType() { return AccountsPayablePaymentDialog; }
        protected getIdProperty() { return AccountsPayablePaymentRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsPayablePaymentRow.localTextPrefix; }
        protected getService() { return AccountsPayablePaymentService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}