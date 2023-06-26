
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class AccountReconciliationAdjustmentGrid extends Serenity.EntityGrid<AccountReconciliationAdjustmentRow, any> {
        protected getColumnsKey() { return 'Finance.AccountReconciliationAdjustment'; }
        protected getDialogType() { return AccountReconciliationAdjustmentDialog; }
        protected getIdProperty() { return AccountReconciliationAdjustmentRow.idProperty; }
        protected getLocalTextPrefix() { return AccountReconciliationAdjustmentRow.localTextPrefix; }
        protected getService() { return AccountReconciliationAdjustmentService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}