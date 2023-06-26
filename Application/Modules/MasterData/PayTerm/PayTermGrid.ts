
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class PayTermGrid extends Serenity.EntityGrid<PayTermRow, any> {
        protected getColumnsKey() { return 'MasterData.PayTerm'; }
        protected getDialogType() { return PayTermDialog; }
        protected getIdProperty() { return PayTermRow.idProperty; }
        protected getLocalTextPrefix() { return PayTermRow.localTextPrefix; }
        protected getService() { return PayTermService.baseUrl; }

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