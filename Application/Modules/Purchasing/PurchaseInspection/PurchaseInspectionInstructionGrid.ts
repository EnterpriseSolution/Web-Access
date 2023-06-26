
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    export class PurchaseInspectionInstructionGrid extends Serenity.EntityGrid<PurchaseInspectionInstructionRow, any> {
        protected getColumnsKey() { return 'Purchasing.PurchaseInspectionInstruction'; }
        protected getDialogType() { return PurchaseInspectionInstructionDialog; }
        protected getIdProperty() { return PurchaseInspectionInstructionRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseInspectionInstructionRow.localTextPrefix; }
        protected getService() { return PurchaseInspectionInstructionService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}