
namespace Matrix.Production {

    @Serenity.Decorators.registerClass()
    export class JobOrderGrid extends Serenity.EntityGrid<JobOrderRow, any> {
        protected getColumnsKey() { return 'Production.JobOrder'; }
        protected getDialogType() { return JobOrderDialog; }
        protected getIdProperty() { return JobOrderRow.idProperty; }
        protected getLocalTextPrefix() { return JobOrderRow.localTextPrefix; }
        protected getService() { return JobOrderService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}