
namespace Matrix.EnterpriseSys {

    @Serenity.Decorators.registerClass()
    export class ReportDialogOptionGrid extends Serenity.EntityGrid<ReportDialogOptionRow, any> {
        protected getColumnsKey() { return 'EnterpriseSys.ReportDialogOption'; }
        protected getDialogType() { return ReportDialogOptionDialog; }
       
        protected getLocalTextPrefix() { return ReportDialogOptionRow.localTextPrefix; }
        protected getService() { return ReportDialogOptionService.baseUrl; }

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