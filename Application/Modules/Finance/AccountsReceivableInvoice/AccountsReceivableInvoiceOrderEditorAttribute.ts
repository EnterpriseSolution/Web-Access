/// <reference path="../../AdminLTE/Helpers/GridEditorBase.ts" />

namespace Matrix.Finance {
   
    @Serenity.Decorators.registerClass()
    export class AccountsReceivableInvoiceOrderEditor extends Common.GridEditorBase<AccountsReceivableInvoiceOrderRow> {
        protected getColumnsKey() { return "Finance.AccountsReceivableInvoiceOrder"; }
        protected getDialogType() { return AccountsReceivableInvoiceOrderDialog; }
        protected getLocalTextPrefix() { return AccountsReceivableInvoiceOrderRow.localTextPrefix; }

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

    @Serenity.Decorators.registerClass()
    export class AccountsReceivableInvoiceDetailEditor extends Common.GridEditorBase<AccountsReceivableInvoiceDetailRow> {
        protected getColumnsKey() { return "Finance.AccountsReceivableInvoiceDetail"; }
        protected getDialogType() { return AccountsReceivableInvoiceDetailDialog; }
        protected getLocalTextPrefix() { return AccountsReceivableInvoiceDetailRow.localTextPrefix; }

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

    @Serenity.Decorators.registerClass()
    export class AccountsReceivableCommissionEditor extends Common.GridEditorBase<AccountsReceivableCommissionRow> {
        protected getColumnsKey() { return "Finance.AccountsReceivableCommission"; }
        protected getDialogType() { return AccountsReceivableCommissionDialog; }
        protected getLocalTextPrefix() { return AccountsReceivableCommissionRow.localTextPrefix; }

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
