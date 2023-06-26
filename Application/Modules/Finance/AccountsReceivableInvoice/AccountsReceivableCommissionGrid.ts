
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class AccountsReceivableCommissionGrid extends Serenity.EntityGrid<AccountsReceivableCommissionRow, any> {
        protected getColumnsKey() { return 'Finance.AccountsReceivableCommission'; }
        protected getDialogType() { return AccountsReceivableCommissionDialog; }
        protected getIdProperty() { return AccountsReceivableCommissionRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsReceivableCommissionRow.localTextPrefix; }
        protected getService() { return AccountsReceivableCommissionService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}