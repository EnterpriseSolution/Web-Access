
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountsReceivableInvoiceOrderDialog extends Serenity.EntityDialog<AccountsReceivableInvoiceOrderRow, any> {
        protected getFormKey() { return AccountsReceivableInvoiceOrderForm.formKey; }
        protected getIdProperty() { return AccountsReceivableInvoiceOrderRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsReceivableInvoiceOrderRow.localTextPrefix; }
        protected getNameProperty() { return AccountsReceivableInvoiceOrderRow.nameProperty; }
        protected getService() { return AccountsReceivableInvoiceOrderService.baseUrl; }

        protected form = new AccountsReceivableInvoiceOrderForm(this.idPrefix);

    }
}