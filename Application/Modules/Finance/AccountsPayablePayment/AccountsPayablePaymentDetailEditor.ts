/// <reference path="../../AdminLTE/Helpers/GridEditorBase.ts" />

namespace Matrix.Finance {
   
    @Serenity.Decorators.registerClass()
    export class AccountsPayablePaymentDetailEditor extends Common.GridEditorBase<AccountsPayablePaymentDetailRow> {
        protected getColumnsKey() { return "Finance.AccountsPayablePaymentDetail"; }
        protected getDialogType() { return AccountsPayablePaymentDetailDialog; }
        protected getLocalTextPrefix() { return AccountsPayablePaymentDetailRow.localTextPrefix; }

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
