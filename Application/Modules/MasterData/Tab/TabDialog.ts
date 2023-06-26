
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class TabDialog extends Serenity.EntityDialog<TabRow, any> {
        protected getFormKey() { return TabForm.formKey; }
        protected getIdProperty() { return TabRow.idProperty; }
        protected getLocalTextPrefix() { return TabRow.localTextPrefix; }
        protected getNameProperty() { return TabRow.nameProperty; }
        protected getService() { return TabService.baseUrl; }

        protected form = new TabForm(this.idPrefix);

    }
}