
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class FundCodeGrid extends Serenity.EntityGrid<FundCodeRow, any> {
        protected getColumnsKey() { return 'MasterData.FundCode'; }
        protected getDialogType() { return FundCodeDialog; }
        protected getIdProperty() { return FundCodeRow.idProperty; }
        protected getLocalTextPrefix() { return FundCodeRow.localTextPrefix; }
        protected getService() { return FundCodeService.baseUrl; }

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