
namespace Matrix.Production {

    @Serenity.Decorators.registerClass()
    export class BomRoutingStepGrid extends Serenity.EntityGrid<BomRoutingStepRow, any> {
        protected getColumnsKey() { return 'Production.BomRoutingStep'; }
        protected getDialogType() { return BomRoutingStepDialog; }
        protected getIdProperty() { return BomRoutingStepRow.idProperty; }
        protected getLocalTextPrefix() { return BomRoutingStepRow.localTextPrefix; }
        protected getService() { return BomRoutingStepService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}