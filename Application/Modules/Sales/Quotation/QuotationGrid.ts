
namespace Matrix.Sales {

    @Serenity.Decorators.registerClass()
    export class QuotationGrid extends Serenity.EntityGrid<QuotationRow, any> {
        protected getColumnsKey() { return 'Sales.Quotation'; }
        protected getDialogType() { return QuotationDialog; }
        protected getIdProperty() { return QuotationRow.idProperty; }
        protected getLocalTextPrefix() { return QuotationRow.localTextPrefix; }
        protected getService() { return QuotationService.baseUrl; }

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