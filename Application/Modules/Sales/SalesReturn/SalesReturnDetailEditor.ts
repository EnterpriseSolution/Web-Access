/// <reference path="../../AdminLTE/Helpers/GridEditorBase.ts" />

namespace Matrix.Sales {
   
    @Serenity.Decorators.registerClass()
    export class SalesReturnDetailEditor extends Common.GridEditorBase<SalesReturnDetailRow> {
        protected getColumnsKey() { return "Sales.SalesReturnDetail"; }
        protected getDialogType() { return SalesReturnDetailDialog; }
        protected getLocalTextPrefix() { return SalesReturnDetailRow.localTextPrefix; }

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
