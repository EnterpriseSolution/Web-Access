module Matrix.Finance {
    @Serenity.Decorators.registerClass()
    export class AccountsPayableInvoiceDetailEditor extends Common.GridEditorBase<AccountsPayableInvoiceDetailRow> {
        protected getColumnsKey() { return "Finance.AccountsPayableInvoiceDetail"; }
        protected getDialogType() { return AccountsPayableInvoiceDetailDialog; }
        protected getLocalTextPrefix() { return AccountsPayableInvoiceDetailRow.localTextPrefix; }

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