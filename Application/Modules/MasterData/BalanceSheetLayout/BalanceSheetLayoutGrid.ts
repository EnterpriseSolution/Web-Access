
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class BalanceSheetLayoutGrid extends Serenity.EntityGrid<BalanceSheetLayoutRow, any> {
        protected getColumnsKey() { return 'MasterData.BalanceSheetLayout'; }
        protected getDialogType() { return BalanceSheetLayoutDialog; }
        protected getIdProperty() { return BalanceSheetLayoutRow.idProperty; }
        protected getLocalTextPrefix() { return BalanceSheetLayoutRow.localTextPrefix; }
        protected getService() { return BalanceSheetLayoutService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}