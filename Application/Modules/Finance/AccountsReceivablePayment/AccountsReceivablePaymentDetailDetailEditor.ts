/// <reference path="../../AdminLTE/Helpers/GridEditorBase.ts" />

namespace Matrix.Finance {
    @Serenity.Decorators.registerClass()
    export class AccountsReceivablePaymentDetailDetailEditor extends Common.GridEditorBase<AccountsReceivablePaymentDetailRow> {
        protected getColumnsKey() { return "Finance.AccountsReceivablePaymentDetail"; }
        protected getDialogType() { return AccountsReceivablePaymentDetailDialog; }
        protected getLocalTextPrefix() { return AccountsReceivablePaymentDetailRow.localTextPrefix; }

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