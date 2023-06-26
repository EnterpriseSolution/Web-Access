
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    export class PurchaseInspectionDetailGrid extends Serenity.EntityGrid<PurchaseInspectionDetailRow, any> {
        protected getColumnsKey() { return 'Purchasing.PurchaseInspectionDetail'; }
        protected getDialogType() { return PurchaseInspectionDetailDialog; }
        protected getIdProperty() { return PurchaseInspectionDetailRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseInspectionDetailRow.localTextPrefix; }
        protected getService() { return PurchaseInspectionDetailService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}