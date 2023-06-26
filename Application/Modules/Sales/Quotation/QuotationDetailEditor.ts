/// <reference path="../../AdminLTE/Helpers/GridEditorBase.ts" />

namespace Matrix.Sales {
   
    @Serenity.Decorators.registerClass()
    export class QuotationDetailEditor extends Common.GridEditorBase<QuotationDetailRow> {
        protected getColumnsKey() { return "Sales.QuotationDetail"; }
        protected getDialogType() { return QuotationDetailDialog; }
        protected getLocalTextPrefix() { return QuotationDetailRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }
        
        protected usePager() {
            return true;
        }  

        //protected getButtons(): Serenity.ToolButton[] {
        //    let buttons = super.getButtons();
        //    buttons = [];
        //    return buttons;
        //}
    }
}
