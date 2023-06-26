
namespace Matrix.Enterprise {

    @Serenity.Decorators.registerClass()
    export class VendorGroupGrid extends Serenity.EntityGrid<VendorGroupRow, any> {
        protected getColumnsKey() { return 'Enterprise.VendorGroup'; }
        protected getDialogType() { return VendorGroupDialog; }
        protected getIdProperty() { return VendorGroupRow.idProperty; }
        protected getLocalTextPrefix() { return VendorGroupRow.localTextPrefix; }
        protected getService() { return VendorGroupService.baseUrl; }

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