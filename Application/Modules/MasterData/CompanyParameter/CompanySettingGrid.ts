
namespace Matrix.Basic {

    @Serenity.Decorators.registerClass()
    export class CompanySettingGrid extends Serenity.EntityGrid<CompanySettingRow, any> {
        protected getColumnsKey() { return 'Basic.CompanySetting'; }
        protected getDialogType() { return CompanySettingDialog; }
        protected getIdProperty() { return CompanySettingRow.idProperty; }
        protected getLocalTextPrefix() { return CompanySettingRow.localTextPrefix; }
        protected getService() { return CompanySettingService.baseUrl; }

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