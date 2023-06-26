
namespace Matrix.Production {

    @Serenity.Decorators.registerClass()
    export class BomGrid extends Serenity.EntityGrid<BomRow, any> {
        protected getColumnsKey() { return 'Production.Bom'; }
        protected getDialogType() { return BomDialog; }
        protected getIdProperty() { return BomRow.idProperty; }
        protected getLocalTextPrefix() { return BomRow.localTextPrefix; }
        protected getService() { return BomService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}