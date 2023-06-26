
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class CommodityGrid extends Serenity.EntityGrid<CommodityRow, any> {
        protected getColumnsKey() { return 'MasterData.Commodity'; }
        protected getDialogType() { return CommodityDialog; }
        protected getIdProperty() { return CommodityRow.idProperty; }
        protected getLocalTextPrefix() { return CommodityRow.localTextPrefix; }
        protected getService() { return CommodityService.baseUrl; }

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