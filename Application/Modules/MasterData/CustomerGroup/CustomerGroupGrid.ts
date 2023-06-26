
namespace Matrix.Enterprise {

    @Serenity.Decorators.registerClass()
    export class CustomerGroupGrid extends Serenity.EntityGrid<CustomerGroupRow, any> {
        protected getColumnsKey() { return 'Enterprise.CustomerGroup'; }
        protected getDialogType() { return CustomerGroupDialog; }
        protected getIdProperty() { return CustomerGroupRow.idProperty; }
        protected getLocalTextPrefix() { return CustomerGroupRow.localTextPrefix; }
        protected getService() { return CustomerGroupService.baseUrl; }

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