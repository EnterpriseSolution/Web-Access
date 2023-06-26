
namespace Matrix.Administration {

    @Serenity.Decorators.registerClass()
    export class LookupDialogFilterDetailGrid extends Serenity.EntityGrid<LookupDialogFilterDetailRow, any> {
        protected getColumnsKey() { return 'Administration.LookupDialogFilterDetail'; }
        protected getDialogType() { return LookupDialogFilterDetailDialog; }
        protected getIdProperty() { return LookupDialogFilterDetailRow.idProperty; }
        protected getLocalTextPrefix() { return LookupDialogFilterDetailRow.localTextPrefix; }
        protected getService() { return LookupDialogFilterDetailService.baseUrl; }

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