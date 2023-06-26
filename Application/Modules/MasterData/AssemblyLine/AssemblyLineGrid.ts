
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class AssemblyLineGrid extends Serenity.EntityGrid<AssemblyLineRow, any> {
        protected getColumnsKey() { return 'MasterData.AssemblyLine'; }
        protected getDialogType() { return AssemblyLineDialog; }
        protected getIdProperty() { return AssemblyLineRow.idProperty; }
        protected getLocalTextPrefix() { return AssemblyLineRow.localTextPrefix; }
        protected getService() { return AssemblyLineService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}