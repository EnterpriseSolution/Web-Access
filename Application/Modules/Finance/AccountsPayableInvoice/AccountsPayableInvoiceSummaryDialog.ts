
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountsPayableInvoiceSummaryDialog extends Serenity.EntityDialog<AccountsPayableInvoiceSummaryRow, any> {
        protected getFormKey() { return AccountsPayableInvoiceSummaryForm.formKey; }
        protected getIdProperty() { return AccountsPayableInvoiceSummaryRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsPayableInvoiceSummaryRow.localTextPrefix; }
        protected getNameProperty() { return AccountsPayableInvoiceSummaryRow.nameProperty; }
        protected getService() { return AccountsPayableInvoiceSummaryService.baseUrl; }

        protected form = new AccountsPayableInvoiceSummaryForm(this.idPrefix);

    }
}