
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class TabGrid extends Serenity.EntityGrid<TabRow, any> {
        protected getColumnsKey() { return 'MasterData.Tab'; }
        protected getDialogType() { return TabDialog; }
        protected getIdProperty() { return TabRow.idProperty; }
        protected getLocalTextPrefix() { return TabRow.localTextPrefix; }
        protected getService() { return TabService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}