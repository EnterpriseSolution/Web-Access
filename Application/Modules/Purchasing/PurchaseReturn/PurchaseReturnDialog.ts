
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PurchaseReturnDialog extends Serenity.EntityDialog<PurchaseReturnRow, any> {
        protected getFormKey() { return PurchaseReturnForm.formKey; }
        protected getIdProperty() { return PurchaseReturnRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseReturnRow.localTextPrefix; }
        protected getNameProperty() { return PurchaseReturnRow.nameProperty; }
        protected getService() { return PurchaseReturnService.baseUrl; }

        protected form = new PurchaseReturnForm(this.idPrefix);

    }
}