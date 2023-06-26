
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class TabDetailGrid extends Serenity.EntityGrid<TabDetailRow, any> {
        protected getColumnsKey() { return 'MasterData.TabDetail'; }
        protected getDialogType() { return TabDetailDialog; }
        protected getIdProperty() { return TabDetailRow.idProperty; }
        protected getLocalTextPrefix() { return TabDetailRow.localTextPrefix; }
        protected getService() { return TabDetailService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}