
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class BuyerDialog extends Serenity.EntityDialog<BuyerRow, any> {
        protected getFormKey() { return BuyerForm.formKey; }
        protected getIdProperty() { return BuyerRow.idProperty; }
        protected getLocalTextPrefix() { return BuyerRow.localTextPrefix; }
        protected getNameProperty() { return BuyerRow.nameProperty; }
        protected getService() { return BuyerService.baseUrl; }

        protected form = new BuyerForm(this.idPrefix);

    }
}