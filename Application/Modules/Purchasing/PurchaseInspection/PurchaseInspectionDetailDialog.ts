
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PurchaseInspectionDetailDialog extends Serenity.EntityDialog<PurchaseInspectionDetailRow, any> {
        protected getFormKey() { return PurchaseInspectionDetailForm.formKey; }
        protected getIdProperty() { return PurchaseInspectionDetailRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseInspectionDetailRow.localTextPrefix; }
        protected getNameProperty() { return PurchaseInspectionDetailRow.nameProperty; }
        protected getService() { return PurchaseInspectionDetailService.baseUrl; }

        protected form = new PurchaseInspectionDetailForm(this.idPrefix);

    }
}