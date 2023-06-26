
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class AccountsPayableJournalGrid extends Serenity.EntityGrid<AccountsPayableJournalRow, any> {
        protected getColumnsKey() { return 'Finance.AccountsPayableJournal'; }
        protected getDialogType() { return AccountsPayableJournalDialog; }
        protected getIdProperty() { return AccountsPayableJournalRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsPayableJournalRow.localTextPrefix; }
        protected getService() { return AccountsPayableJournalService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}