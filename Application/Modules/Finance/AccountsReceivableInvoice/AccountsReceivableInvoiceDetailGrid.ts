
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class AccountsReceivableInvoiceDetailGrid extends Serenity.EntityGrid<AccountsReceivableInvoiceDetailRow, any> {
        protected getColumnsKey() { return 'Finance.AccountsReceivableInvoiceDetail'; }
        protected getDialogType() { return AccountsReceivableInvoiceDetailDialog; }
        protected getIdProperty() { return AccountsReceivableInvoiceDetailRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsReceivableInvoiceDetailRow.localTextPrefix; }
        protected getService() { return AccountsReceivableInvoiceDetailService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}