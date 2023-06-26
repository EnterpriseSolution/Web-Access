
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class WorkflowDialog extends Serenity.EntityDialog<WorkflowRow, any> {
        protected getFormKey() { return WorkflowForm.formKey; }
        protected getIdProperty() { return WorkflowRow.idProperty; }
        protected getLocalTextPrefix() { return WorkflowRow.localTextPrefix; }
        protected getNameProperty() { return WorkflowRow.nameProperty; }
        protected getService() { return WorkflowService.baseUrl; }

        protected form = new WorkflowForm(this.idPrefix);

    }
}