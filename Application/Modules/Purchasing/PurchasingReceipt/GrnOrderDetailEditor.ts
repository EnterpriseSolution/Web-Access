/// <reference path="../../AdminLTE/Helpers/GridEditorBase.ts" />

namespace Matrix.Purchasing {
   
    @Serenity.Decorators.registerClass()
    export class GrnOrderDetailEditor extends Common.GridEditorBase<GrnOrderDetailRow> {
        protected getColumnsKey() { return "Purchasing.GrnOrderDetail"; }
        protected getDialogType() { return GrnOrderDetailDialog; }
        protected getLocalTextPrefix() { return GrnOrderDetailRow.localTextPrefix; }

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
