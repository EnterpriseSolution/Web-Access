
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PurchaseInspectionDialog extends Serenity.EntityDialog<PurchaseInspectionRow, any> {
        protected getFormKey() { return PurchaseInspectionForm.formKey; }
        protected getIdProperty() { return PurchaseInspectionRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseInspectionRow.localTextPrefix; }
        protected getNameProperty() { return PurchaseInspectionRow.nameProperty; }
        protected getService() { return PurchaseInspectionService.baseUrl; }

        protected form = new PurchaseInspectionForm(this.idPrefix);

    }
}