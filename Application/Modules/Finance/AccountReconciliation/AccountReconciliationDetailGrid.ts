
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class AccountReconciliationDetailGrid extends Serenity.EntityGrid<AccountReconciliationDetailRow, any> {
        protected getColumnsKey() { return 'Finance.AccountReconciliationDetail'; }
        protected getDialogType() { return AccountReconciliationDetailDialog; }
        protected getIdProperty() { return AccountReconciliationDetailRow.idProperty; }
        protected getLocalTextPrefix() { return AccountReconciliationDetailRow.localTextPrefix; }
        protected getService() { return AccountReconciliationDetailService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}