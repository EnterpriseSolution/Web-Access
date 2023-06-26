/// <reference path="../../AdminLTE/Helpers/GridEditorBase.ts" />

namespace Matrix.Purchasing {
    import ShipmentDetailDialog = Matrix.Sales.ShipmentDetailDialog;
    import ShipmentDetailRow = Matrix.Sales.ShipmentDetailRow;

    @Serenity.Decorators.registerClass()
    export class GrnOrderEditor extends Common.GridEditorBase<GrnOrderRow> {
        protected getColumnsKey() { return "Purchasing.GrnOrder"; }
        protected getDialogType() { return GrnOrderDialog; }
        protected getLocalTextPrefix() { return GrnOrderRow.localTextPrefix; }

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
