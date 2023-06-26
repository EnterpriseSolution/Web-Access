
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class AnalysisCategoryGrid extends Serenity.EntityGrid<AnalysisCategoryRow, any> {
        protected getColumnsKey() { return 'MasterData.AnalysisCategory'; }
        protected getDialogType() { return AnalysisCategoryDialog; }
        protected getIdProperty() { return AnalysisCategoryRow.idProperty; }
        protected getLocalTextPrefix() { return AnalysisCategoryRow.localTextPrefix; }
        protected getService() { return AnalysisCategoryService.baseUrl; }

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