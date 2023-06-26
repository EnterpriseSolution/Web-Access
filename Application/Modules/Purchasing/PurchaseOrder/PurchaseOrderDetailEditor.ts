/// <reference path="../../AdminLTE/Helpers/GridEditorBase.ts" />

namespace Matrix.Purchasing {
   
    @Serenity.Decorators.registerClass()
    export class PurchaseOrderDetailEditor extends Common.GridEditorBase<PurchaseOrderDetailRow> {
        protected getColumnsKey() { return "Purchasing.PurchaseOrderDetail"; }
        protected getDialogType() { return PurchaseOrderDetailDialog; }
        protected getLocalTextPrefix() { return PurchaseOrderDetailRow.localTextPrefix; }

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
