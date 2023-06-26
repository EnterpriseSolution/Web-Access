
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    export class PurchaseOrderDetailGrid extends Serenity.EntityGrid<PurchaseOrderDetailRow, any> {
        protected getColumnsKey() { return 'Purchasing.PurchaseOrderDetail'; }
        protected getDialogType() { return PurchaseOrderDetailDialog; }
        protected getIdProperty() { return PurchaseOrderDetailRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseOrderDetailRow.localTextPrefix; }
        protected getService() { return PurchaseOrderDetailService.baseUrl; }

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