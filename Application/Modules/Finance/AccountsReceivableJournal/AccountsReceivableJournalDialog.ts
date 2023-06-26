
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountsReceivableJournalDialog extends Serenity.EntityDialog<AccountsReceivableJournalRow, any> {
        protected getFormKey() { return AccountsReceivableJournalForm.formKey; }
        protected getIdProperty() { return AccountsReceivableJournalRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsReceivableJournalRow.localTextPrefix; }
        protected getNameProperty() { return AccountsReceivableJournalRow.nameProperty; }
        protected getService() { return AccountsReceivableJournalService.baseUrl; }

        protected form = new AccountsReceivableJournalForm(this.idPrefix);

    }
}