
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class AccountsReceivableInvoiceGrid extends Serenity.EntityGrid<AccountsReceivableInvoiceRow, any> {
        protected getColumnsKey() { return 'Finance.AccountsReceivableInvoice'; }
        protected getDialogType() { return AccountsReceivableInvoiceDialog; }
        protected getIdProperty() { return AccountsReceivableInvoiceRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsReceivableInvoiceRow.localTextPrefix; }
        protected getService() { return AccountsReceivableInvoiceService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}