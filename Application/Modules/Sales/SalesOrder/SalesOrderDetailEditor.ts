/// <reference path="../../AdminLTE/Helpers/GridEditorBase.ts" />

namespace Matrix.Sales {
   
    @Serenity.Decorators.registerClass()
    export class SalesOrderDetailEditor extends Common.GridEditorBase<QuotationDetailRow> {
        protected getColumnsKey() { return "Sales.SalesOrderDetail"; }
        protected getDialogType() { return SalesOrderDetailDialog; }
        protected getLocalTextPrefix() { return SalesOrderDetailRow.localTextPrefix; }

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
