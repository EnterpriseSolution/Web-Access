
namespace Matrix.Production {

    @Serenity.Decorators.registerClass()
    export class BomMaterialGrid extends Serenity.EntityGrid<BomMaterialRow, any> {
        protected getColumnsKey() { return 'Production.BomMaterial'; }
        protected getDialogType() { return BomMaterialDialog; }
        protected getIdProperty() { return BomMaterialRow.idProperty; }
        protected getLocalTextPrefix() { return BomMaterialRow.localTextPrefix; }
        protected getService() { return BomMaterialService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}