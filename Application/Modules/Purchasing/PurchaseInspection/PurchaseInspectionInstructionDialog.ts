
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PurchaseInspectionInstructionDialog extends Serenity.EntityDialog<PurchaseInspectionInstructionRow, any> {
        protected getFormKey() { return PurchaseInspectionInstructionForm.formKey; }
        protected getIdProperty() { return PurchaseInspectionInstructionRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseInspectionInstructionRow.localTextPrefix; }
        protected getNameProperty() { return PurchaseInspectionInstructionRow.nameProperty; }
        protected getService() { return PurchaseInspectionInstructionService.baseUrl; }

        protected form = new PurchaseInspectionInstructionForm(this.idPrefix);

    }
}