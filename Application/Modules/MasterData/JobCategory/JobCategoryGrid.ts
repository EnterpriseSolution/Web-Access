
namespace Matrix.Enterprise {

    @Serenity.Decorators.registerClass()
    export class JobCategoryGrid extends Serenity.EntityGrid<JobCategoryRow, any> {
        protected getColumnsKey() { return 'Enterprise.JobCategory'; }
        protected getDialogType() { return JobCategoryDialog; }
        protected getIdProperty() { return JobCategoryRow.idProperty; }
        protected getLocalTextPrefix() { return JobCategoryRow.localTextPrefix; }
        protected getService() { return JobCategoryService.baseUrl; }

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