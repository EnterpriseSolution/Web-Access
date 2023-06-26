
namespace Matrix.Enterprise {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class JobCategoryDialog extends Serenity.EntityDialog<JobCategoryRow, any> {
        protected getFormKey() { return JobCategoryForm.formKey; }
        protected getIdProperty() { return JobCategoryRow.idProperty; }
        protected getLocalTextPrefix() { return JobCategoryRow.localTextPrefix; }
        protected getNameProperty() { return JobCategoryRow.nameProperty; }
        protected getService() { return JobCategoryService.baseUrl; }

        protected form = new JobCategoryForm(this.idPrefix);

    }
}