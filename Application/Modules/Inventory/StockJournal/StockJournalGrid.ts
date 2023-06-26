
namespace Matrix.Inventory {

    @Serenity.Decorators.registerClass()
    export class StockJournalGrid extends Serenity.EntityGrid<StockJournalRow, any> {
        protected getColumnsKey() { return 'Inventory.StockJournal'; }
        protected getDialogType() { return StockJournalDialog; }
        protected getIdProperty() { return StockJournalRow.idProperty; }
        protected getLocalTextPrefix() { return StockJournalRow.localTextPrefix; }
        protected getService() { return StockJournalService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
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

        protected getButtons(): Serenity.ToolButton[] {
            var buttons = super.getButtons();
            buttons.splice(Q.indexOf(buttons, x => x.cssClass === "add-button"), 1);
            return buttons;
        }

        public refreshGrid(param:any) {
            var request = this.view.params;
            request.Location = param.Location;
            request.ItemNo = param.ItemNo;
           this.refresh(); 
        }
    }
}