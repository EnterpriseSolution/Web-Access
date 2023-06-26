
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class CurrencyLedgerSummaryDialog extends Serenity.EntityDialog<CurrencyLedgerSummaryRow, any> {
        protected getFormKey() { return CurrencyLedgerSummaryForm.formKey; }
        protected getIdProperty() { return CurrencyLedgerSummaryRow.idProperty; }
        protected getLocalTextPrefix() { return CurrencyLedgerSummaryRow.localTextPrefix; }
        protected getNameProperty() { return CurrencyLedgerSummaryRow.nameProperty; }
        protected getService() { return CurrencyLedgerSummaryService.baseUrl; }

        protected form = new CurrencyLedgerSummaryForm(this.idPrefix);

    }
}