
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    export class GrnGrid extends Serenity.EntityGrid<GrnRow, any> {
        protected getColumnsKey() { return 'Purchasing.Grn'; }
        protected getDialogType() { return GrnDialog; }
        protected getIdProperty() { return GrnRow.idProperty; }
        protected getLocalTextPrefix() { return GrnRow.localTextPrefix; }
        protected getService() { return GrnService.baseUrl; }

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