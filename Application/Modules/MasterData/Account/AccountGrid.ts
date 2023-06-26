
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class AccountGrid extends Serenity.EntityGrid<AccountRow, any> {
        protected getColumnsKey() { return 'MasterData.Account'; }
        protected getDialogType() { return AccountDialog; }
        protected getIdProperty() { return AccountRow.idProperty; }
        protected getLocalTextPrefix() { return AccountRow.localTextPrefix; }
        protected getService() { return AccountService.baseUrl; }

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