/// <reference path="../../AdminLTE/Helpers/GridEditorBase.ts" />

namespace Matrix.MasterData {
    //import AccountBudgetRow = Finance.AccountBudgetRow;
    //import AccountBudgetRow = Matrix.Finance.AccountBudgetRow;
    //import AccountBudgetService = Matrix.Finance.AccountBudgetService;

    @Serenity.Decorators.registerClass()
    export class AccountBudgetDetailEditor extends Common.GridEditorBase<AccountBudgetRow> {
        protected getColumnsKey() { return "MasterData.AccountBudget"; }
        protected getDialogType() { return AccountBudgetDialog; }
        protected getLocalTextPrefix() { return AccountBudgetRow.localTextPrefix; }

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
