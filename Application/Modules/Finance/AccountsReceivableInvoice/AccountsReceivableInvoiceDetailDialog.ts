
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountsReceivableInvoiceDetailDialog extends Serenity.EntityDialog<AccountsReceivableInvoiceDetailRow, any> {
        protected getFormKey() { return AccountsReceivableInvoiceDetailForm.formKey; }
        protected getIdProperty() { return AccountsReceivableInvoiceDetailRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsReceivableInvoiceDetailRow.localTextPrefix; }
        protected getNameProperty() { return AccountsReceivableInvoiceDetailRow.nameProperty; }
        protected getService() { return AccountsReceivableInvoiceDetailService.baseUrl; }

        protected form = new AccountsReceivableInvoiceDetailForm(this.idPrefix);

    }
}