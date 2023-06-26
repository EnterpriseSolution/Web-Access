
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class AnalysisCodeGrid extends Serenity.EntityGrid<AnalysisCodeRow, any> {
        protected getColumnsKey() { return 'MasterData.AnalysisCode'; }
        protected getDialogType() { return AnalysisCodeDialog; }
        protected getIdProperty() { return AnalysisCodeRow.idProperty; }
        protected getLocalTextPrefix() { return AnalysisCodeRow.localTextPrefix; }
        protected getService() { return AnalysisCodeService.baseUrl; }

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