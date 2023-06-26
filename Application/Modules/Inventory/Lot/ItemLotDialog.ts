
namespace Matrix.Inventory {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ItemLotDialog extends Serenity.EntityDialog<ItemLotRow, any> {
        protected getFormKey() { return ItemLotForm.formKey; }
        protected getIdProperty() { return ItemLotRow.idProperty; }
        protected getLocalTextPrefix() { return ItemLotRow.localTextPrefix; }
        protected getNameProperty() { return ItemLotRow.nameProperty; }
        protected getService() { return ItemLotService.baseUrl; }

        protected form = new ItemLotForm(this.idPrefix);

    }
}