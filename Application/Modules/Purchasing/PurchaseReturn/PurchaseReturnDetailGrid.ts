
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    export class PurchaseReturnDetailGrid extends Serenity.EntityGrid<PurchaseReturnDetailRow, any> {
        protected getColumnsKey() { return 'Purchasing.PurchaseReturnDetail'; }
        protected getDialogType() { return PurchaseReturnDetailDialog; }
        protected getIdProperty() { return PurchaseReturnDetailRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseReturnDetailRow.localTextPrefix; }
        protected getService() { return PurchaseReturnDetailService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}