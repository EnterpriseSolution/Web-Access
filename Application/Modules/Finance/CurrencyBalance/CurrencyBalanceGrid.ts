
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class CurrencyBalanceGrid extends Serenity.EntityGrid<CurrencyBalanceRow, any> {
        protected getColumnsKey() { return 'Finance.CurrencyBalance'; }
        protected getDialogType() { return CurrencyBalanceDialog; }
        protected getIdProperty() { return CurrencyBalanceRow.idProperty; }
        protected getLocalTextPrefix() { return CurrencyBalanceRow.localTextPrefix; }
        protected getService() { return CurrencyBalanceService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}