/// <reference path="../../AdminLTE/Helpers/GridEditorBase.ts" />

namespace Matrix.Finance {
   
    @Serenity.Decorators.registerClass()
    export class PeriodicVoucherDetailEditor extends Common.GridEditorBase<PeriodicVoucherDetailRow> {
        protected getColumnsKey() { return "Sales.QuotationDetail"; }
        protected getDialogType() { return PeriodicVoucherDetailDialog; }
        protected getLocalTextPrefix() { return PeriodicVoucherDetailRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
        
        protected usePager() {
            return true;
        }

        protected getButtons(): Serenity.ToolButton[] {
            let buttons = super.getButtons();
            buttons = [];
            return buttons;
        }
    }
}
