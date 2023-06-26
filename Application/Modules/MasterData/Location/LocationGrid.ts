
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class LocationGrid extends Serenity.EntityGrid<LocationRow, any> {
        protected getColumnsKey() { return 'MasterData.Location'; }
        protected getDialogType() { return LocationDialog; }
        protected getIdProperty() { return LocationRow.idProperty; }
        protected getLocalTextPrefix() { return LocationRow.localTextPrefix; }
        protected getService() { return LocationService.baseUrl; }

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