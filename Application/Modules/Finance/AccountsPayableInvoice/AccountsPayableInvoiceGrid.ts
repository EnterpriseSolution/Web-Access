
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class AccountsPayableInvoiceGrid extends Serenity.EntityGrid<AccountsPayableInvoiceRow, any> {
        protected getColumnsKey() { return 'Finance.AccountsPayableInvoice'; }
        protected getDialogType() { return AccountsPayableInvoiceDialog; }
        protected getIdProperty() { return AccountsPayableInvoiceRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsPayableInvoiceRow.localTextPrefix; }
        protected getService() { return AccountsPayableInvoiceService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}