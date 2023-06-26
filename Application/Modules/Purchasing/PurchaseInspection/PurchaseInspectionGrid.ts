
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    export class PurchaseInspectionGrid extends Serenity.EntityGrid<PurchaseInspectionRow, any> {
        protected getColumnsKey() { return 'Purchasing.PurchaseInspection'; }
        protected getDialogType() { return PurchaseInspectionDialog; }
        protected getIdProperty() { return PurchaseInspectionRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseInspectionRow.localTextPrefix; }
        protected getService() { return PurchaseInspectionService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}