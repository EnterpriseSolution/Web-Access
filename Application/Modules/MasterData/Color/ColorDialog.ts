
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ColorDialog extends Serenity.EntityDialog<ColorRow, any> {
        protected getFormKey() { return ColorForm.formKey; }
        protected getIdProperty() { return ColorRow.idProperty; }
        protected getLocalTextPrefix() { return ColorRow.localTextPrefix; }
        protected getNameProperty() { return ColorRow.nameProperty; }
        protected getService() { return ColorService.baseUrl; }

        protected form = new ColorForm(this.idPrefix);

    }
}