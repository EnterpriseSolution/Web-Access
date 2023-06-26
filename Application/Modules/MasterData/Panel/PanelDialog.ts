
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PanelDialog extends Serenity.EntityDialog<PanelRow, any> {
        protected getFormKey() { return PanelForm.formKey; }
        protected getIdProperty() { return PanelRow.idProperty; }
        protected getLocalTextPrefix() { return PanelRow.localTextPrefix; }
        protected getNameProperty() { return PanelRow.nameProperty; }
        protected getService() { return PanelService.baseUrl; }

        protected form = new PanelForm(this.idPrefix);

    }
}