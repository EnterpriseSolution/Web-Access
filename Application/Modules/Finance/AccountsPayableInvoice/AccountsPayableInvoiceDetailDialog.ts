
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountsPayableInvoiceDetailDialog extends Serenity.EntityDialog<AccountsPayableInvoiceDetailRow, any> {
        protected getFormKey() { return AccountsPayableInvoiceDetailForm.formKey; }
        protected getIdProperty() { return AccountsPayableInvoiceDetailRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsPayableInvoiceDetailRow.localTextPrefix; }
        protected getNameProperty() { return AccountsPayableInvoiceDetailRow.nameProperty; }
        protected getService() { return AccountsPayableInvoiceDetailService.baseUrl; }

        protected form = new AccountsPayableInvoiceDetailForm(this.idPrefix);

    }
}