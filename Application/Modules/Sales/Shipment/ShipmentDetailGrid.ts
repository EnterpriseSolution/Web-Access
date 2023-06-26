
namespace Matrix.Sales {

    @Serenity.Decorators.registerClass()
    export class ShipmentDetailGrid extends Serenity.EntityGrid<ShipmentDetailRow, any> {
        protected getColumnsKey() { return 'Sales.ShipmentDetail'; }
        protected getDialogType() { return ShipmentDetailDialog; }
        protected getIdProperty() { return ShipmentDetailRow.idProperty; }
        protected getLocalTextPrefix() { return ShipmentDetailRow.localTextPrefix; }
        protected getService() { return ShipmentDetailService.baseUrl; }

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