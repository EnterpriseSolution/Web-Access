
namespace Matrix.Production {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class JobOrderMaterialDialog extends Serenity.EntityDialog<JobOrderMaterialRow, any> {
        protected getFormKey() { return JobOrderMaterialForm.formKey; }
        protected getIdProperty() { return JobOrderMaterialRow.idProperty; }
        protected getLocalTextPrefix() { return JobOrderMaterialRow.localTextPrefix; }
        protected getNameProperty() { return JobOrderMaterialRow.nameProperty; }
        protected getService() { return JobOrderMaterialService.baseUrl; }

        protected form = new JobOrderMaterialForm(this.idPrefix);

    }
}