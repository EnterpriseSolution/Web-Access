
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class PanelGrid extends Serenity.EntityGrid<PanelRow, any> {
        protected getColumnsKey() { return 'MasterData.Panel'; }
        protected getDialogType() { return PanelDialog; }
        protected getIdProperty() { return PanelRow.idProperty; }
        protected getLocalTextPrefix() { return PanelRow.localTextPrefix; }
        protected getService() { return PanelService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getSlickOptions() {
            var opt = super.getSlickOptions();
            //disable column reorder
            opt.enableCellNavigation = true;
            opt.enableColumnReorder = false;
            return opt;
        }
    }
}