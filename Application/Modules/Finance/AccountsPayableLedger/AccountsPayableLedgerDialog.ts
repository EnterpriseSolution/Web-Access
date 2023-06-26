
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountsPayableLedgerDialog extends Serenity.EntityDialog<AccountsPayableLedgerRow, any> {
        protected getFormKey() { return AccountsPayableLedgerForm.formKey; }
        protected getIdProperty() { return AccountsPayableLedgerRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsPayableLedgerRow.localTextPrefix; }
        protected getNameProperty() { return AccountsPayableLedgerRow.nameProperty; }
        protected getService() { return AccountsPayableLedgerService.baseUrl; }

        protected form = new AccountsPayableLedgerForm(this.idPrefix);

    }
}