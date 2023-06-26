
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    export class GrnOrderGrid extends Serenity.EntityGrid<GrnOrderRow, any> {
        protected getColumnsKey() { return 'Purchasing.GrnOrder'; }
        protected getDialogType() { return GrnOrderDialog; }
        protected getIdProperty() { return GrnOrderRow.idProperty; }
        protected getLocalTextPrefix() { return GrnOrderRow.localTextPrefix; }
        protected getService() { return GrnOrderService.baseUrl; }

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