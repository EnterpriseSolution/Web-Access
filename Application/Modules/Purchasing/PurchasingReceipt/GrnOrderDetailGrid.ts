
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    export class GrnOrderDetailGrid extends Serenity.EntityGrid<GrnOrderDetailRow, any> {
        protected getColumnsKey() { return 'Purchasing.GrnOrderDetail'; }
        protected getDialogType() { return GrnOrderDetailDialog; }
        protected getIdProperty() { return GrnOrderDetailRow.idProperty; }
        protected getLocalTextPrefix() { return GrnOrderDetailRow.localTextPrefix; }
        protected getService() { return GrnOrderDetailService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getButtons(): Serenity.ToolButton[] {
            var buttons = super.getButtons();
            buttons.splice(Q.indexOf(buttons, x => x.cssClass === "add-button"), 1);
            return buttons;
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