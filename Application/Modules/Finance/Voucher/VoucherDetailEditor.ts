/// <reference path="../../AdminLTE/Helpers/GridEditorBase.ts" />

namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class VoucherDetailEditor extends Common.GridEditorBase<VoucherDetailRow> {
        protected getColumnsKey() { return "Finance.VoucherDetail"; }
        protected getDialogType() { return VoucherDetailDialog; }
        protected getLocalTextPrefix() { return VoucherDetailRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }

        validateEntity(row, id) {
            return true;
        }
        

        protected getButtons(): Serenity.ToolButton[] {
            let buttons = super.getButtons();
            buttons = [];
            return buttons;
        }

    }
}