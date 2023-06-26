
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class ExchangeRateDialog extends Serenity.EntityDialog<ExchangeRateRow, any> {
        protected getFormKey() { return ExchangeRateForm.formKey; }
        protected getIdProperty() { return ExchangeRateRow.idProperty; }
        protected getLocalTextPrefix() { return ExchangeRateRow.localTextPrefix; }
        protected getNameProperty() { return ExchangeRateRow.nameProperty; }
        protected getService() { return ExchangeRateService.baseUrl; }

        protected form = new ExchangeRateForm(this.idPrefix);

    }
}