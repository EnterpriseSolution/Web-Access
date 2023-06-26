
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class FiscalYearDialog extends Serenity.EntityDialog<FiscalYearRow, any> {
        protected getFormKey() { return FiscalYearForm.formKey; }
        protected getIdProperty() { return FiscalYearRow.idProperty; }
        protected getLocalTextPrefix() { return FiscalYearRow.localTextPrefix; }
        protected getNameProperty() { return FiscalYearRow.nameProperty; }
        protected getService() { return FiscalYearService.baseUrl; }

        protected form = new FiscalYearForm(this.idPrefix);

    }
}