
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountsReceivableLedgerDialog extends Serenity.EntityDialog<AccountsReceivableLedgerRow, any> {
        protected getFormKey() { return AccountsReceivableLedgerForm.formKey; }
        protected getIdProperty() { return AccountsReceivableLedgerRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsReceivableLedgerRow.localTextPrefix; }
        protected getNameProperty() { return AccountsReceivableLedgerRow.nameProperty; }
        protected getService() { return AccountsReceivableLedgerService.baseUrl; }

        protected form = new AccountsReceivableLedgerForm(this.idPrefix);

    }
}