
namespace Matrix.Basic {

    @Serenity.Decorators.registerClass()
    export class CompanyParameterGrid extends Serenity.EntityGrid<CompanyParameterRow, any> {
        protected getColumnsKey() { return 'Basic.CompanyParameter'; }
        protected getDialogType() { return CompanyParameterDialog; }
        protected getIdProperty() { return CompanyParameterRow.idProperty; }
        protected getLocalTextPrefix() { return CompanyParameterRow.localTextPrefix; }
        protected getService() { return CompanyParameterService.baseUrl; }

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