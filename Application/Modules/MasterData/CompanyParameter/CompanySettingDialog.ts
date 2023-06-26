
namespace Matrix.Basic {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class CompanySettingDialog extends Serenity.EntityDialog<CompanySettingRow, any> {
        protected getFormKey() { return CompanySettingForm.formKey; }
        protected getIdProperty() { return CompanySettingRow.idProperty; }
        protected getLocalTextPrefix() { return CompanySettingRow.localTextPrefix; }
        protected getNameProperty() { return CompanySettingRow.nameProperty; }
        protected getService() { return CompanySettingService.baseUrl; }

        protected form = new CompanySettingForm(this.idPrefix);

    }
}