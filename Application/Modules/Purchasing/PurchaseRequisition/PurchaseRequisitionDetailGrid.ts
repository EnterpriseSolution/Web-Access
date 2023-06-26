
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    export class PurchaseRequisitionDetailGrid extends Serenity.EntityGrid<PurchaseRequisitionDetailRow, any> {
        protected getColumnsKey() { return 'Purchasing.PurchaseRequisitionDetail'; }
        protected getDialogType() { return PurchaseRequisitionDetailDialog; }
        protected getIdProperty() { return PurchaseRequisitionDetailRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseRequisitionDetailRow.localTextPrefix; }
        protected getService() { return PurchaseRequisitionDetailService.baseUrl; }

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