
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class AccountsPayableInvoiceSummaryGrid extends Serenity.EntityGrid<AccountsPayableInvoiceSummaryRow, any> {
        protected getColumnsKey() { return 'Finance.AccountsPayableInvoiceSummary'; }
        protected getDialogType() { return AccountsPayableInvoiceSummaryDialog; }
        protected getIdProperty() { return AccountsPayableInvoiceSummaryRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsPayableInvoiceSummaryRow.localTextPrefix; }
        protected getService() { return AccountsPayableInvoiceSummaryService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}