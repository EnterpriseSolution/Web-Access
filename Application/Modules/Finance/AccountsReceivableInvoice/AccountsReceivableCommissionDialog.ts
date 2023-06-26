
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountsReceivableCommissionDialog extends Serenity.EntityDialog<AccountsReceivableCommissionRow, any> {
        protected getFormKey() { return AccountsReceivableCommissionForm.formKey; }
        protected getIdProperty() { return AccountsReceivableCommissionRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsReceivableCommissionRow.localTextPrefix; }
        protected getNameProperty() { return AccountsReceivableCommissionRow.nameProperty; }
        protected getService() { return AccountsReceivableCommissionService.baseUrl; }

        protected form = new AccountsReceivableCommissionForm(this.idPrefix);

    }
}