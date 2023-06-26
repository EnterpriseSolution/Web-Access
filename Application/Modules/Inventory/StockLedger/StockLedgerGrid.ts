
namespace Matrix.Inventory {

    @Serenity.Decorators.registerClass()
    export class StockLedgerGrid extends Serenity.EntityGrid<StockLedgerRow, any> {
        protected getColumnsKey() { return 'Inventory.StockLedger'; }
        protected getDialogType() { return StockLedgerDialog; }
        protected getIdProperty() { return StockLedgerRow.idProperty; }
        protected getLocalTextPrefix() { return StockLedgerRow.localTextPrefix; }
        protected getService() { return StockLedgerService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}