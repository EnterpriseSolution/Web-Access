
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class WorkCentreDialog extends Serenity.EntityDialog<WorkCentreRow, any> {
        protected getFormKey() { return WorkCentreForm.formKey; }
        protected getIdProperty() { return WorkCentreRow.idProperty; }
        protected getLocalTextPrefix() { return WorkCentreRow.localTextPrefix; }
        protected getNameProperty() { return WorkCentreRow.nameProperty; }
        protected getService() { return WorkCentreService.baseUrl; }

        protected form = new WorkCentreForm(this.idPrefix);

    }
}