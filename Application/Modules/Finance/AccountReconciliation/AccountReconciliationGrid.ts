
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class AccountReconciliationGrid extends Serenity.EntityGrid<AccountReconciliationRow, any> {
        protected getColumnsKey() { return 'Finance.AccountReconciliation'; }
        protected getDialogType() { return AccountReconciliationDialog; }
        protected getIdProperty() { return AccountReconciliationRow.idProperty; }
        protected getLocalTextPrefix() { return AccountReconciliationRow.localTextPrefix; }
        protected getService() { return AccountReconciliationService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}