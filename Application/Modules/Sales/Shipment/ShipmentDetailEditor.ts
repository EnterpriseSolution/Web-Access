/// <reference path="../../AdminLTE/Helpers/GridEditorBase.ts" />

namespace Matrix.Sales {
   
    @Serenity.Decorators.registerClass()
    export class ShipmentDetailEditor extends Common.GridEditorBase<ShipmentDetailRow> {
        protected getColumnsKey() { return "Sales.ShipmentDetail"; }
        protected getDialogType() { return ShipmentDetailDialog; }
        protected getLocalTextPrefix() { return ShipmentDetailRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }

        validateEntity(row, id) {
            return true;
        }

        protected getButtons(): Serenity.ToolButton[] {
            let buttons = super.getButtons();
            buttons = [];
            return buttons;
        }
    }
}
