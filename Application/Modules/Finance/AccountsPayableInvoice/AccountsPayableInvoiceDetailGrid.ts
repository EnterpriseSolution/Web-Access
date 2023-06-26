
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class AccountsPayableInvoiceDetailGrid extends Serenity.EntityGrid<AccountsPayableInvoiceDetailRow, any> {
        protected getColumnsKey() { return 'Finance.AccountsPayableInvoiceDetail'; }
        protected getDialogType() { return AccountsPayableInvoiceDetailDialog; }
        protected getIdProperty() { return AccountsPayableInvoiceDetailRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsPayableInvoiceDetailRow.localTextPrefix; }
        protected getService() { return AccountsPayableInvoiceDetailService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}