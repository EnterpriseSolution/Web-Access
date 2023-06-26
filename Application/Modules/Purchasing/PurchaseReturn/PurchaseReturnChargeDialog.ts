
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PurchaseReturnChargeDialog extends Serenity.EntityDialog<PurchaseReturnChargeRow, any> {
        protected getFormKey() { return PurchaseReturnChargeForm.formKey; }
        protected getIdProperty() { return PurchaseReturnChargeRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseReturnChargeRow.localTextPrefix; }
        protected getNameProperty() { return PurchaseReturnChargeRow.nameProperty; }
        protected getService() { return PurchaseReturnChargeService.baseUrl; }

        protected form = new PurchaseReturnChargeForm(this.idPrefix);

    }
}