
namespace Matrix.Administration {

    @Serenity.Decorators.registerClass()
    export class CompanyGrid extends Serenity.EntityGrid<CompanyRow, any> {
        protected getColumnsKey() { return 'Administration.CompanyDialog'; }
        protected getDialogType() { return CompanyDialog; }
        protected getIdProperty() { return CompanyRow.idProperty; }
        protected getLocalTextPrefix() { return CompanyRow.localTextPrefix; }
        protected getService() { return CompanyService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        //protected getButtons(): Serenity.ToolButton[] {
        //    var buttons = super.getButtons();
        //    buttons.splice(Q.indexOf(buttons, x => x.cssClass === "add-button"), 1);
        //    return buttons;
        //}

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