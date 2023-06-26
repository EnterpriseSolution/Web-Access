
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class AccountsReceivableLedgerGrid extends Serenity.EntityGrid<AccountsReceivableLedgerRow, any> {
        protected getColumnsKey() { return 'Finance.AccountsReceivableLedger'; }
        protected getDialogType() { return AccountsReceivableLedgerDialog; }
        protected getIdProperty() { return AccountsReceivableLedgerRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsReceivableLedgerRow.localTextPrefix; }
        protected getService() { return AccountsReceivableLedgerService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}