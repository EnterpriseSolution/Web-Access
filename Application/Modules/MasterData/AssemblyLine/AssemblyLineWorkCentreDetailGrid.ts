
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class AssemblyLineWorkCentreDetailGrid extends Serenity.EntityGrid<AssemblyLineWorkCentreDetailRow, any> {
        protected getColumnsKey() { return 'MasterData.AssemblyLineWorkCentreDetail'; }
        protected getDialogType() { return AssemblyLineWorkCentreDetailDialog; }
        protected getIdProperty() { return AssemblyLineWorkCentreDetailRow.idProperty; }
        protected getLocalTextPrefix() { return AssemblyLineWorkCentreDetailRow.localTextPrefix; }
        protected getService() { return AssemblyLineWorkCentreDetailService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}