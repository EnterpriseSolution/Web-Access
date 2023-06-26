
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PurchaseReturnDetailDialog extends Serenity.EntityDialog<PurchaseReturnDetailRow, any> {
        protected getFormKey() { return PurchaseReturnDetailForm.formKey; }
        protected getIdProperty() { return PurchaseReturnDetailRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseReturnDetailRow.localTextPrefix; }
        protected getNameProperty() { return PurchaseReturnDetailRow.nameProperty; }
        protected getService() { return PurchaseReturnDetailService.baseUrl; }

        protected form = new PurchaseReturnDetailForm(this.idPrefix);

    }
}