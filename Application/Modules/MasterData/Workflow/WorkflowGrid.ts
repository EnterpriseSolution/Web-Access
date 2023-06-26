
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class WorkflowGrid extends Serenity.EntityGrid<WorkflowRow, any> {
        protected getColumnsKey() { return 'MasterData.Workflow'; }
        protected getDialogType() { return WorkflowDialog; }
        protected getIdProperty() { return WorkflowRow.idProperty; }
        protected getLocalTextPrefix() { return WorkflowRow.localTextPrefix; }
        protected getService() { return WorkflowService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}