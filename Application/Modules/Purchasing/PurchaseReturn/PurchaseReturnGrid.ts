
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    export class PurchaseReturnGrid extends Serenity.EntityGrid<PurchaseReturnRow, any> {
        protected getColumnsKey() { return 'Purchasing.PurchaseReturn'; }
        protected getDialogType() { return PurchaseReturnDialog; }
        protected getIdProperty() { return PurchaseReturnRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseReturnRow.localTextPrefix; }
        protected getService() { return PurchaseReturnService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}