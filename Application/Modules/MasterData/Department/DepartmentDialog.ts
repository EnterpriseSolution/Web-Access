
namespace Matrix.Enterprise {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class DepartmentDialog extends Serenity.EntityDialog<DepartmentRow, any> {
        protected getFormKey() { return DepartmentForm.formKey; }
        protected getIdProperty() { return DepartmentRow.idProperty; }
        protected getLocalTextPrefix() { return DepartmentRow.localTextPrefix; }
        protected getNameProperty() { return DepartmentRow.nameProperty; }
        protected getService() { return DepartmentService.baseUrl; }

        protected form = new DepartmentForm(this.idPrefix);

        protected afterLoadEntity() {
            super.afterLoadEntity();

            // these fields are only required in new record mode
            //this.form.Password.element.toggleClass('required', this.isNew())
            //    .closest('.field').find('sup').toggle(this.isNew());
            //this.form.PasswordConfirm.element.toggleClass('required', this.isNew())
            //    .closest('.field').find('sup').toggle(this.isNew());

            new Matrix.Administration.LookupDialogController(jQuery(".inputLookup")).InitiaizeLookupUI();
            new Matrix.Administration.LookupDialogController(jQuery(".buttonLookup")).InitiaizeLookupExecution();
        }
    }
}