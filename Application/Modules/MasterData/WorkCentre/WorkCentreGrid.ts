
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class WorkCentreGrid extends Serenity.EntityGrid<WorkCentreRow, any> {
        protected getColumnsKey() { return 'MasterData.WorkCentre'; }
        protected getDialogType() { return WorkCentreDialog; }
        protected getIdProperty() { return WorkCentreRow.idProperty; }
        protected getLocalTextPrefix() { return WorkCentreRow.localTextPrefix; }
        protected getService() { return WorkCentreService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getSlickOptions(): Slick.GridOptions {
            var opt = super.getSlickOptions();
            opt.enableTextSelectionOnCells = true;
            opt.selectedCellCssClass = "slick-row-selected";
            opt.enableCellNavigation = true;
            return opt;
        }

        protected createSlickGrid(): Slick.Grid {
            var grid = super.createSlickGrid();
            grid.setSelectionModel(new Slick.RowSelectionModel());
            return grid;
        }
    }
}