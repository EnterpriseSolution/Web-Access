
namespace Matrix.Production {

    @Serenity.Decorators.registerClass()
    export class JobOrderRoutingStepGrid extends Serenity.EntityGrid<JobOrderRoutingStepRow, any> {
        protected getColumnsKey() { return 'Production.JobOrderRoutingStep'; }
        protected getDialogType() { return JobOrderRoutingStepDialog; }
        protected getIdProperty() { return JobOrderRoutingStepRow.idProperty; }
        protected getLocalTextPrefix() { return JobOrderRoutingStepRow.localTextPrefix; }
        protected getService() { return JobOrderRoutingStepService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}