
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class ExchangeRateGrid extends Serenity.EntityGrid<ExchangeRateRow, any> {
        protected getColumnsKey() { return 'MasterData.ExchangeRate'; }
        protected getDialogType() { return ExchangeRateDialog; }
        protected getIdProperty() { return ExchangeRateRow.idProperty; }
        protected getLocalTextPrefix() { return ExchangeRateRow.localTextPrefix; }
        protected getService() { return ExchangeRateService.baseUrl; }

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