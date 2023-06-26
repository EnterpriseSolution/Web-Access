/// <reference path="../../AdminLTE/Helpers/GridEditorBase.ts" />

namespace Matrix.EnterpriseSys {
    
    @Serenity.Decorators.registerClass()
    export class ReportDialogOptionEditor extends Common.GridEditorBase<ReportDialogOptionRow> {
        protected getColumnsKey() { return "EnterpriseSys.ReportDialogOption"; }
        protected getDialogType() { return ReportDialogOptionDialog; }
        protected getLocalTextPrefix() { return ReportDialogOptionRow.localTextPrefix; }

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
