
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ContactTypeDialog extends Serenity.EntityDialog<ContactTypeRow, any> {
        protected getFormKey() { return ContactTypeForm.formKey; }
        protected getIdProperty() { return ContactTypeRow.idProperty; }
        protected getLocalTextPrefix() { return ContactTypeRow.localTextPrefix; }
        protected getNameProperty() { return ContactTypeRow.nameProperty; }
        protected getService() { return ContactTypeService.baseUrl; }

        protected form = new ContactTypeForm(this.idPrefix);

    }
}