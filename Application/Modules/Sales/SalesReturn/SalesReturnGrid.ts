
namespace Matrix.Sales {

    @Serenity.Decorators.registerClass()
    export class SalesReturnGrid extends Serenity.EntityGrid<SalesReturnRow, any> {
        protected getColumnsKey() { return 'Sales.SalesReturn'; }
        protected getDialogType() { return SalesReturnDialog; }
        protected getIdProperty() { return SalesReturnRow.idProperty; }
        protected getLocalTextPrefix() { return SalesReturnRow.localTextPrefix; }
        protected getService() { return SalesReturnService.baseUrl; }

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