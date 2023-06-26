
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class MachineGrid extends Serenity.EntityGrid<MachineRow, any> {
        protected getColumnsKey() { return 'MasterData.Machine'; }
        protected getDialogType() { return MachineDialog; }
        protected getIdProperty() { return MachineRow.idProperty; }
        protected getLocalTextPrefix() { return MachineRow.localTextPrefix; }
        protected getService() { return MachineService.baseUrl; }

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