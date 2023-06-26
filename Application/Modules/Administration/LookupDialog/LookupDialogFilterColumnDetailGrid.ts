
namespace Matrix.Administration {

    @Serenity.Decorators.registerClass()
    export class LookupDialogFilterColumnDetailGrid extends Serenity.EntityGrid<LookupDialogFilterColumnDetailRow, any> {
        protected getColumnsKey() { return 'Administration.LookupDialogFilterColumnDetail'; }
        protected getDialogType() { return LookupDialogFilterColumnDetailDialog; }
        protected getIdProperty() { return LookupDialogFilterColumnDetailRow.idProperty; }
        protected getLocalTextPrefix() { return LookupDialogFilterColumnDetailRow.localTextPrefix; }
        protected getService() { return LookupDialogFilterColumnDetailService.baseUrl; }

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