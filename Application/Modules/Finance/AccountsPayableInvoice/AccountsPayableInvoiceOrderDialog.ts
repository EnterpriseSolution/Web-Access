
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountsPayableInvoiceOrderDialog extends Serenity.EntityDialog<AccountsPayableInvoiceOrderRow, any> {
        protected getFormKey() { return AccountsPayableInvoiceOrderForm.formKey; }
        protected getIdProperty() { return AccountsPayableInvoiceOrderRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsPayableInvoiceOrderRow.localTextPrefix; }
        protected getNameProperty() { return AccountsPayableInvoiceOrderRow.nameProperty; }
        protected getService() { return AccountsPayableInvoiceOrderService.baseUrl; }

        protected form = new AccountsPayableInvoiceOrderForm(this.idPrefix);

    }
}