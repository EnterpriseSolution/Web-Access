/// <reference path="../../AdminLTE/Helpers/GridEditorBase.ts" />

namespace Matrix.Finance {
   
    @Serenity.Decorators.registerClass()
    export class AccountsPayableInvoiceOrderEditor extends Common.GridEditorBase<AccountsPayableInvoiceOrderRow> {
        protected getColumnsKey() { return "Finance.AccountsPayableInvoiceOrder"; }
        protected getDialogType() { return AccountsPayableInvoiceOrderDialog; }
        protected getLocalTextPrefix() { return AccountsPayableInvoiceOrderRow.localTextPrefix; }

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
