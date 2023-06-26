
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class CurrencyLedgerGrid extends Serenity.EntityGrid<CurrencyLedgerRow, any> {
        protected getColumnsKey() { return 'Finance.CurrencyLedger'; }
        protected getDialogType() { return CurrencyLedgerDialog; }
        protected getIdProperty() { return CurrencyLedgerRow.idProperty; }
        protected getLocalTextPrefix() { return CurrencyLedgerRow.localTextPrefix; }
        protected getService() { return CurrencyLedgerService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}