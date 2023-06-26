
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class ProfitAndLossLayoutGrid extends Serenity.EntityGrid<ProfitAndLossLayoutRow, any> {
        protected getColumnsKey() { return 'MasterData.ProfitAndLossLayout'; }
        protected getDialogType() { return ProfitAndLossLayoutDialog; }
        protected getIdProperty() { return ProfitAndLossLayoutRow.idProperty; }
        protected getLocalTextPrefix() { return ProfitAndLossLayoutRow.localTextPrefix; }
        protected getService() { return ProfitAndLossLayoutService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}