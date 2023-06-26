
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountsReceivablePaymentDepositDialog extends Serenity.EntityDialog<AccountsReceivablePaymentDepositRow, any> {
        protected getFormKey() { return AccountsReceivablePaymentDepositForm.formKey; }
        protected getIdProperty() { return AccountsReceivablePaymentDepositRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsReceivablePaymentDepositRow.localTextPrefix; }
        protected getNameProperty() { return AccountsReceivablePaymentDepositRow.nameProperty; }
        protected getService() { return AccountsReceivablePaymentDepositService.baseUrl; }

        protected form = new AccountsReceivablePaymentDepositForm(this.idPrefix);

    }
}