
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class SalesmanGrid extends Serenity.EntityGrid<SalesmanRow, any> {
        protected getColumnsKey() { return 'MasterData.Salesman'; }
        protected getDialogType() { return SalesmanDialog; }
        protected getIdProperty() { return SalesmanRow.idProperty; }
        protected getLocalTextPrefix() { return SalesmanRow.localTextPrefix; }
        protected getService() { return SalesmanService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}