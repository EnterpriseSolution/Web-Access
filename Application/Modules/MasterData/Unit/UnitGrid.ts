
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class UnitGrid extends Serenity.EntityGrid<UnitRow, any> {
        protected getColumnsKey() { return 'MasterData.Unit'; }
        protected getDialogType() { return UnitDialog; }
        protected getIdProperty() { return UnitRow.idProperty; }
        protected getLocalTextPrefix() { return UnitRow.localTextPrefix; }
        protected getService() { return UnitService.baseUrl; }

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