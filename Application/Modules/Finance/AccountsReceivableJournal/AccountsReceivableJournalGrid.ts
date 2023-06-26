
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class AccountsReceivableJournalGrid extends Serenity.EntityGrid<AccountsReceivableJournalRow, any> {
        protected getColumnsKey() { return 'Finance.AccountsReceivableJournal'; }
        protected getDialogType() { return AccountsReceivableJournalDialog; }
        protected getIdProperty() { return AccountsReceivableJournalRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsReceivableJournalRow.localTextPrefix; }
        protected getService() { return AccountsReceivableJournalService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}