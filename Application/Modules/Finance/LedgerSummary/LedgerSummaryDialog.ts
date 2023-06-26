
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class LedgerSummaryDialog extends Serenity.EntityDialog<LedgerSummaryRow, any> {
        protected getFormKey() { return LedgerSummaryForm.formKey; }
        protected getIdProperty() { return LedgerSummaryRow.idProperty; }
        protected getLocalTextPrefix() { return LedgerSummaryRow.localTextPrefix; }
        protected getNameProperty() { return LedgerSummaryRow.nameProperty; }
        protected getService() { return LedgerSummaryService.baseUrl; }

        protected form = new LedgerSummaryForm(this.idPrefix);

    }
}