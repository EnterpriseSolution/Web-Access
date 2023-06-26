﻿
namespace Matrix.Sales {

    @Serenity.Decorators.registerClass()
    export class ShipmentGrid extends Serenity.EntityGrid<ShipmentRow, any> {
        protected getColumnsKey() { return 'Sales.Shipment'; }
        protected getDialogType() { return ShipmentDialog; }
        protected getIdProperty() { return ShipmentRow.idProperty; }
        protected getLocalTextPrefix() { return ShipmentRow.localTextPrefix; }
        protected getService() { return ShipmentService.baseUrl; }

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