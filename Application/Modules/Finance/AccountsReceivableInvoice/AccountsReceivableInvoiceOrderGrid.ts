
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class AccountsReceivableInvoiceOrderGrid extends Serenity.EntityGrid<AccountsReceivableInvoiceOrderRow, any> {
        protected getColumnsKey() { return 'Finance.AccountsReceivableInvoiceOrder'; }
        protected getDialogType() { return AccountsReceivableInvoiceOrderDialog; }
        protected getIdProperty() { return AccountsReceivableInvoiceOrderRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsReceivableInvoiceOrderRow.localTextPrefix; }
        protected getService() { return AccountsReceivableInvoiceOrderService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}