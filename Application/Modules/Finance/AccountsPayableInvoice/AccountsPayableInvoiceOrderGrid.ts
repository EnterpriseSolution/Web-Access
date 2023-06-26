
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class AccountsPayableInvoiceOrderGrid extends Serenity.EntityGrid<AccountsPayableInvoiceOrderRow, any> {
        protected getColumnsKey() { return 'Finance.AccountsPayableInvoiceOrder'; }
        protected getDialogType() { return AccountsPayableInvoiceOrderDialog; }
        protected getIdProperty() { return AccountsPayableInvoiceOrderRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsPayableInvoiceOrderRow.localTextPrefix; }
        protected getService() { return AccountsPayableInvoiceOrderService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}