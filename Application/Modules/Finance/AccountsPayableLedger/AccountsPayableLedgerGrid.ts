
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class AccountsPayableLedgerGrid extends Serenity.EntityGrid<AccountsPayableLedgerRow, any> {
        protected getColumnsKey() { return 'Finance.AccountsPayableLedger'; }
        protected getDialogType() { return AccountsPayableLedgerDialog; }
        protected getIdProperty() { return AccountsPayableLedgerRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsPayableLedgerRow.localTextPrefix; }
        protected getService() { return AccountsPayableLedgerService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}