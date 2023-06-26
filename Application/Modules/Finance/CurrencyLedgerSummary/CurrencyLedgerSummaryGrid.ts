
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class CurrencyLedgerSummaryGrid extends Serenity.EntityGrid<CurrencyLedgerSummaryRow, any> {
        protected getColumnsKey() { return 'Finance.CurrencyLedgerSummary'; }
        protected getDialogType() { return CurrencyLedgerSummaryDialog; }
        protected getIdProperty() { return CurrencyLedgerSummaryRow.idProperty; }
        protected getLocalTextPrefix() { return CurrencyLedgerSummaryRow.localTextPrefix; }
        protected getService() { return CurrencyLedgerSummaryService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}