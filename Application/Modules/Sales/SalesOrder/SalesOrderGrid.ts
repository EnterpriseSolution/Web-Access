
namespace Matrix.Sales {

    @Serenity.Decorators.registerClass()
    export class SalesOrderGrid extends Serenity.EntityGrid<SalesOrderRow, any> {
        protected getColumnsKey() { return 'Sales.SalesOrder'; }
        protected getDialogType() { return SalesOrderDialog; }
        protected getIdProperty() { return SalesOrderRow.idProperty; }
        protected getLocalTextPrefix() { return SalesOrderRow.localTextPrefix; }
        protected getService() { return SalesOrderService.baseUrl; }

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