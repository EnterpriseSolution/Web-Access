/// <reference path="../../AdminLTE/Helpers/GridEditorBase.ts" />

namespace Matrix.MasterData {
   
    @Serenity.Decorators.registerClass()
    export class AnalysisCategoryDetailEditor extends Common.GridEditorBase<AnalysisCodeRow> {
        protected getColumnsKey() { return "MasterData.AnalysisCode"; }
        protected getDialogType() { return AnalysisCodeDialog; }
        protected getLocalTextPrefix() { return AnalysisCodeRow.localTextPrefix; }

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
