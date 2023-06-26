
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class OperationGrid extends Serenity.EntityGrid<OperationRow, any> {
        protected getColumnsKey() { return 'MasterData.Operation'; }
        protected getDialogType() { return OperationDialog; }
        protected getIdProperty() { return OperationRow.idProperty; }
        protected getLocalTextPrefix() { return OperationRow.localTextPrefix; }
        protected getService() { return OperationService.baseUrl; }

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