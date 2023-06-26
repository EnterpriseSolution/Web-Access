
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class CurrencyBalanceDialog extends Serenity.EntityDialog<CurrencyBalanceRow, any> {
        protected getFormKey() { return CurrencyBalanceForm.formKey; }
        protected getIdProperty() { return CurrencyBalanceRow.idProperty; }
        protected getLocalTextPrefix() { return CurrencyBalanceRow.localTextPrefix; }
        protected getNameProperty() { return CurrencyBalanceRow.nameProperty; }
        protected getService() { return CurrencyBalanceService.baseUrl; }

        protected form = new CurrencyBalanceForm(this.idPrefix);

    }
}