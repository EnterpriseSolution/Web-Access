
namespace Matrix.Enterprise {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ItemGroupDialog extends Serenity.EntityDialog<ItemGroupRow, any> {
        protected getFormKey() { return ItemGroupForm.formKey; }
        protected getIdProperty() { return ItemGroupRow.idProperty; }
        protected getLocalTextPrefix() { return ItemGroupRow.localTextPrefix; }
        protected getNameProperty() { return ItemGroupRow.nameProperty; }
        protected getService() { return ItemGroupService.baseUrl; }

        protected form = new ItemGroupForm(this.idPrefix);

    }
}