
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class TextTypeDialog extends Serenity.EntityDialog<TextTypeRow, any> {
        protected getFormKey() { return TextTypeForm.formKey; }
        protected getIdProperty() { return TextTypeRow.idProperty; }
        protected getLocalTextPrefix() { return TextTypeRow.localTextPrefix; }
        protected getNameProperty() { return TextTypeRow.nameProperty; }
        protected getService() { return TextTypeService.baseUrl; }

        protected form = new TextTypeForm(this.idPrefix);

    }
}