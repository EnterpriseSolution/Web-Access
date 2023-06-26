namespace  Matrix.Finance {
    @Serenity.Decorators.registerClass()
    export class PeriodicVoucherScheduleDetailEditor extends Common.GridEditorBase<PeriodicVoucherScheduleRow> {
        protected getColumnsKey() { return "Sales.QuotationDetail"; }
        protected getDialogType() { return PeriodicVoucherScheduleDialog; }
        protected getLocalTextPrefix() { return PeriodicVoucherScheduleRow.localTextPrefix; }

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