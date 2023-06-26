
namespace Matrix.Administration {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class CompanyDialog extends Serenity.EntityDialog<CompanyRow, any> {
        protected getFormKey() { return "Administration.CompanyForm"; }
        protected getIdProperty() { return CompanyRow.idProperty; }
        protected getLocalTextPrefix() { return CompanyRow.localTextPrefix; }
        protected getNameProperty() { return CompanyRow.nameProperty; }
        protected getService() { return CompanyService.baseUrl; }

        protected form = new CompanyForm(this.idPrefix);
    }
}