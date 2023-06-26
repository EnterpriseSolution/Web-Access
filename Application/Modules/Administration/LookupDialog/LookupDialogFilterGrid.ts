
namespace Matrix.Administration {

    @Serenity.Decorators.registerClass()
    export class LookupDialogFilterGrid extends Serenity.EntityGrid<LookupDialogFilterRow, any> {
        protected getColumnsKey() { return 'Administration.LookupDialogFilter'; }
        protected getDialogType() { return LookupDialogFilterDialog; }
        protected getIdProperty() { return LookupDialogFilterRow.idProperty; }
        protected getLocalTextPrefix() { return LookupDialogFilterRow.localTextPrefix; }
        protected getService() { return LookupDialogFilterService.baseUrl; }

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