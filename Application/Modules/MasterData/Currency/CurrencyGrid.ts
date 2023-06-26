
namespace Matrix.Enterprise {

    @Serenity.Decorators.registerClass()
    export class CurrencyGrid extends Serenity.EntityGrid<CurrencyRow, any> {
        protected getColumnsKey() { return 'Enterprise.Currency'; }
        protected getDialogType() { return CurrencyDialog; }
        protected getIdProperty() { return CurrencyRow.idProperty; }
        protected getLocalTextPrefix() { return CurrencyRow.localTextPrefix; }
        protected getService() { return CurrencyService.baseUrl; }

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