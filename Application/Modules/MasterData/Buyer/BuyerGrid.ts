
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class BuyerGrid extends Serenity.EntityGrid<BuyerRow, any> {
        protected getColumnsKey() { return 'MasterData.Buyer'; }
        protected getDialogType() { return BuyerDialog; }
        protected getIdProperty() { return BuyerRow.idProperty; }
        protected getLocalTextPrefix() { return BuyerRow.localTextPrefix; }
        protected getService() { return BuyerService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected usePager(): boolean {
            return false;
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