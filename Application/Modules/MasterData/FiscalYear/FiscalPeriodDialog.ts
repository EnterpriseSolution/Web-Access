
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class FiscalPeriodDialog extends Serenity.EntityDialog<FiscalPeriodRow, any> {
        protected getFormKey() { return FiscalPeriodForm.formKey; }
        protected getIdProperty() { return FiscalPeriodRow.idProperty; }
        protected getLocalTextPrefix() { return FiscalPeriodRow.localTextPrefix; }
        protected getNameProperty() { return FiscalPeriodRow.nameProperty; }
        protected getService() { return FiscalPeriodService.baseUrl; }

        protected form = new FiscalPeriodForm(this.idPrefix);

    }
}