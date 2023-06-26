
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class CurrencyLedgerDialog extends Serenity.EntityDialog<CurrencyLedgerRow, any> {
        protected getFormKey() { return CurrencyLedgerForm.formKey; }
        protected getIdProperty() { return CurrencyLedgerRow.idProperty; }
        protected getLocalTextPrefix() { return CurrencyLedgerRow.localTextPrefix; }
        protected getNameProperty() { return CurrencyLedgerRow.nameProperty; }
        protected getService() { return CurrencyLedgerService.baseUrl; }

        protected form = new CurrencyLedgerForm(this.idPrefix);

    }
}