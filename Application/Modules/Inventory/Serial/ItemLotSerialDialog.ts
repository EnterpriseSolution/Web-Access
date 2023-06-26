
namespace Matrix.Inventory {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ItemLotSerialDialog extends Serenity.EntityDialog<ItemLotSerialRow, any> {
        protected getFormKey() { return ItemLotSerialForm.formKey; }
        protected getIdProperty() { return ItemLotSerialRow.idProperty; }
        protected getLocalTextPrefix() { return ItemLotSerialRow.localTextPrefix; }
        protected getNameProperty() { return ItemLotSerialRow.nameProperty; }
        protected getService() { return ItemLotSerialService.baseUrl; }

        protected form = new ItemLotSerialForm(this.idPrefix);

    }
}