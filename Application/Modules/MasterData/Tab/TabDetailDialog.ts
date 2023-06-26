
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class TabDetailDialog extends Serenity.EntityDialog<TabDetailRow, any> {
        protected getFormKey() { return TabDetailForm.formKey; }
        protected getIdProperty() { return TabDetailRow.idProperty; }
        protected getLocalTextPrefix() { return TabDetailRow.localTextPrefix; }
        protected getNameProperty() { return TabDetailRow.nameProperty; }
        protected getService() { return TabDetailService.baseUrl; }

        protected form = new TabDetailForm(this.idPrefix);

    }
}