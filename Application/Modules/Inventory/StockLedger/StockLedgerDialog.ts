
namespace Matrix.Inventory {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.panel()
    export class StockLedgerDialog extends Serenity.EntityDialog<StockLedgerRow, any> {
        protected getFormKey() { return StockLedgerForm.formKey; }
        protected getIdProperty() { return StockLedgerRow.idProperty; }
        protected getLocalTextPrefix() { return StockLedgerRow.localTextPrefix; }
        protected getNameProperty() { return StockLedgerRow.nameProperty; }
        protected getService() { return StockLedgerService.baseUrl; }

        protected form = new StockLedgerForm(this.idPrefix);

    }
}