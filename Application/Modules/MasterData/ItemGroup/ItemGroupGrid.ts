
namespace Matrix.Enterprise {

    @Serenity.Decorators.registerClass()
    export class ItemGroupGrid extends Serenity.EntityGrid<ItemGroupRow, any> {
        protected getColumnsKey() { return 'Enterprise.ItemGroup'; }
        protected getDialogType() { return ItemGroupDialog; }
        protected getIdProperty() { return ItemGroupRow.idProperty; }
        protected getLocalTextPrefix() { return ItemGroupRow.localTextPrefix; }
        protected getService() { return ItemGroupService.baseUrl; }

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