
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.panel()
    export class ItemDialog extends Serenity.EntityDialog<ItemRow, any> {
        protected getFormKey() { return ItemForm.formKey; }
        protected getIdProperty() { return ItemRow.idProperty; }
        protected getLocalTextPrefix() { return ItemRow.localTextPrefix; }
        protected getNameProperty() { return ItemRow.nameProperty; }
        protected getService() { return ItemService.baseUrl; }

        protected form = new ItemForm(this.idPrefix);

    }
}