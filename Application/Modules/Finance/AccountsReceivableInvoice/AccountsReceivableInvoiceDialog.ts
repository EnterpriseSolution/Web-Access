
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountsReceivableInvoiceDialog extends Serenity.EntityDialog<AccountsReceivableInvoiceRow, any> {
        protected getFormKey() { return AccountsReceivableInvoiceForm.formKey; }
        protected getIdProperty() { return AccountsReceivableInvoiceRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsReceivableInvoiceRow.localTextPrefix; }
        protected getNameProperty() { return AccountsReceivableInvoiceRow.nameProperty; }
        protected getService() { return AccountsReceivableInvoiceService.baseUrl; }

        protected form = new AccountsReceivableInvoiceForm(this.idPrefix);

    }
}