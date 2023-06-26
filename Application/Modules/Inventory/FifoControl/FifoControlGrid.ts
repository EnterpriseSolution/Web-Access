﻿
namespace Matrix.Inventory {

    @Serenity.Decorators.registerClass()
    export class FifoControlGrid extends Serenity.EntityGrid<FifoControlRow, any> {
        protected getColumnsKey() { return 'Inventory.FifoControl'; }
        protected getDialogType() { return FifoControlDialog; }
        protected getIdProperty() { return FifoControlRow.idProperty; }
        protected getLocalTextPrefix() { return FifoControlRow.localTextPrefix; }
        protected getService() { return FifoControlService.baseUrl; }

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