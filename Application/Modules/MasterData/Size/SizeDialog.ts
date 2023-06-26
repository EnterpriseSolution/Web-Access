
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class SizeDialog extends Serenity.EntityDialog<SizeRow, any> {
        protected getFormKey() { return SizeForm.formKey; }
        protected getIdProperty() { return SizeRow.idProperty; }
        protected getLocalTextPrefix() { return SizeRow.localTextPrefix; }
        protected getNameProperty() { return SizeRow.nameProperty; }
        protected getService() { return SizeService.baseUrl; }

        protected form = new SizeForm(this.idPrefix);

    }
}