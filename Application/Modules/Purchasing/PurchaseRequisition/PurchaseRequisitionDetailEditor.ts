/// <reference path="../../AdminLTE/Helpers/GridEditorBase.ts" />

namespace Matrix.Purchasing {
   
    @Serenity.Decorators.registerClass()
    export class PurchaseRequisitionDetailEditor extends Common.GridEditorBase<PurchaseRequisitionDetailRow> {
        protected getColumnsKey() { return "Purchasing.PurchaseRequisitionDetail"; }
        protected getDialogType() { return PurchaseRequisitionDetailDialog; }
        protected getLocalTextPrefix() { return PurchaseRequisitionDetailRow.localTextPrefix; }

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
