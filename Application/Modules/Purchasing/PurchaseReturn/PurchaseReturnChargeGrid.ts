
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    export class PurchaseReturnChargeGrid extends Serenity.EntityGrid<PurchaseReturnChargeRow, any> {
        protected getColumnsKey() { return 'Purchasing.PurchaseReturnCharge'; }
        protected getDialogType() { return PurchaseReturnChargeDialog; }
        protected getIdProperty() { return PurchaseReturnChargeRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseReturnChargeRow.localTextPrefix; }
        protected getService() { return PurchaseReturnChargeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}