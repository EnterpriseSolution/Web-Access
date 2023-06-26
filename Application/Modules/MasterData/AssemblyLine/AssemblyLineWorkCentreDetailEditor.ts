/// <reference path="../../AdminLTE/Helpers/GridEditorBase.ts" />

namespace Matrix.MasterData {
   
    @Serenity.Decorators.registerClass()
    export class AssemblyLineWorkCentreDetailEditor extends Common.GridEditorBase<ExchangeRateRow> {
        protected getColumnsKey() { return "MasterData.AssemblyLineWorkCentreDetail"; }
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
