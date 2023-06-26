
namespace Matrix.Basic {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class CompanyParameterDialog extends Serenity.EntityDialog<CompanyParameterRow, any> {
        protected getFormKey() { return CompanyParameterForm.formKey; }
        protected getIdProperty() { return CompanyParameterRow.idProperty; }
        protected getLocalTextPrefix() { return CompanyParameterRow.localTextPrefix; }
        protected getNameProperty() { return CompanyParameterRow.nameProperty; }
        protected getService() { return CompanyParameterService.baseUrl; }

        protected form = new CompanyParameterForm(this.idPrefix);

        protected updateInterface() {
            super.updateInterface();

            this.deleteButton.hide();
            this.applyChangesButton.hide();
        }

        protected onSaveSuccess(response) {
            this.showSaveSuccessMessage(response);
        }
    }
}