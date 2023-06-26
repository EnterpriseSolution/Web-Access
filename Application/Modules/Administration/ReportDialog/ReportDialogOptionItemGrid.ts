
namespace Matrix.EnterpriseSys {

    @Serenity.Decorators.registerClass()
    export class ReportDialogOptionItemGrid extends Serenity.EntityGrid<ReportDialogOptionItemRow, any> {
        protected getColumnsKey() { return 'EnterpriseSys.ReportDialogOptionItem'; }
        protected getDialogType() { return ReportDialogOptionItemDialog; }
        protected getIdProperty() { return ReportDialogOptionItemRow.idProperty; }
        protected getLocalTextPrefix() { return ReportDialogOptionItemRow.localTextPrefix; }
        protected getService() { return ReportDialogOptionItemService.baseUrl; }

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