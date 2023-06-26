
namespace Matrix.Production {

    @Serenity.Decorators.registerClass()
    export class JobOrderMaterialGrid extends Serenity.EntityGrid<JobOrderMaterialRow, any> {
        protected getColumnsKey() { return 'Production.JobOrderMaterial'; }
        protected getDialogType() { return JobOrderMaterialDialog; }
        protected getIdProperty() { return JobOrderMaterialRow.idProperty; }
        protected getLocalTextPrefix() { return JobOrderMaterialRow.localTextPrefix; }
        protected getService() { return JobOrderMaterialService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}