
namespace Matrix.Sales {

    @Serenity.Decorators.registerClass()
    export class SalesReturnDetailGrid extends Serenity.EntityGrid<SalesReturnDetailRow, any> {
        protected getColumnsKey() { return 'Sales.SalesReturnDetail'; }
        protected getDialogType() { return SalesReturnDetailDialog; }
        protected getIdProperty() { return SalesReturnDetailRow.idProperty; }
        protected getLocalTextPrefix() { return SalesReturnDetailRow.localTextPrefix; }
        protected getService() { return SalesReturnDetailService.baseUrl; }

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