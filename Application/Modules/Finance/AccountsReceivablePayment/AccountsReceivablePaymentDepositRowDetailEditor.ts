/// <reference path="../../AdminLTE/Helpers/GridEditorBase.ts" />

namespace Matrix.Finance {
   
    @Serenity.Decorators.registerClass()
    export class AccountsReceivablePaymentDepositRowDetailEditor extends Common.GridEditorBase<AccountsReceivablePaymentDepositRow> {
        protected getColumnsKey() { return "Finance.AccountsReceivablePaymentDeposit"; }
        protected getDialogType() { return AccountsReceivablePaymentDepositDialog; }
        protected getLocalTextPrefix() { return AccountsReceivablePaymentDepositRow.localTextPrefix; }

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
