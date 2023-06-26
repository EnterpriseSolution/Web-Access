
namespace Matrix.Administration {

    @Serenity.Decorators.registerClass()
    export class LookupDialogGrid extends Serenity.EntityGrid<LookupDialogRow, any> {
        protected getColumnsKey() { return 'Administration.LookupDialog'; }
        protected getDialogType() { return LookupDialogDialog; }
        protected getIdProperty() { return LookupDialogRow.idProperty; }
        protected getLocalTextPrefix() { return LookupDialogRow.localTextPrefix; }
        protected getService() { return LookupDialogService.baseUrl; }

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