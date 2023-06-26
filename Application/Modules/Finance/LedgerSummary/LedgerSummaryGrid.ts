
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class LedgerSummaryGrid extends Serenity.EntityGrid<LedgerSummaryRow, any> {
        protected getColumnsKey() { return 'Finance.LedgerSummary'; }
        protected getDialogType() { return LedgerSummaryDialog; }
        protected getIdProperty() { return LedgerSummaryRow.idProperty; }
        protected getLocalTextPrefix() { return LedgerSummaryRow.localTextPrefix; }
        protected getService() { return LedgerSummaryService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}