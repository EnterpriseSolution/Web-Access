
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountsPayableInvoiceDialog extends Serenity.EntityDialog<AccountsPayableInvoiceRow, any> {
        protected getFormKey() { return AccountsPayableInvoiceForm.formKey; }
        protected getIdProperty() { return AccountsPayableInvoiceRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsPayableInvoiceRow.localTextPrefix; }
        protected getNameProperty() { return AccountsPayableInvoiceRow.nameProperty; }
        protected getService() { return AccountsPayableInvoiceService.baseUrl; }

        protected form = new AccountsPayableInvoiceForm(this.idPrefix);

    }
}