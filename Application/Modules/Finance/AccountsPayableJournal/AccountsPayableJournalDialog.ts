
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountsPayableJournalDialog extends Serenity.EntityDialog<AccountsPayableJournalRow, any> {
        protected getFormKey() { return AccountsPayableJournalForm.formKey; }
        protected getIdProperty() { return AccountsPayableJournalRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsPayableJournalRow.localTextPrefix; }
        protected getNameProperty() { return AccountsPayableJournalRow.nameProperty; }
        protected getService() { return AccountsPayableJournalService.baseUrl; }

        protected form = new AccountsPayableJournalForm(this.idPrefix);

    }
}