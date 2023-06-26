
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class CollectionDialog extends Serenity.EntityDialog<CollectionRow, any> {
        protected getFormKey() { return CollectionForm.formKey; }
        protected getIdProperty() { return CollectionRow.idProperty; }
        protected getLocalTextPrefix() { return CollectionRow.localTextPrefix; }
        protected getNameProperty() { return CollectionRow.nameProperty; }
        protected getService() { return CollectionService.baseUrl; }

        protected form = new CollectionForm(this.idPrefix);

    }
}