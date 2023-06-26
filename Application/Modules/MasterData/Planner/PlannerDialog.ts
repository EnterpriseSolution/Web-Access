
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PlannerDialog extends Serenity.EntityDialog<PlannerRow, any> {
        protected getFormKey() { return PlannerForm.formKey; }
        protected getIdProperty() { return PlannerRow.idProperty; }
        protected getLocalTextPrefix() { return PlannerRow.localTextPrefix; }
        protected getNameProperty() { return PlannerRow.nameProperty; }
        protected getService() { return PlannerService.baseUrl; }

        protected form = new PlannerForm(this.idPrefix);

    }
}