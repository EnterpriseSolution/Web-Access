
namespace Matrix.Production {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class JobOrderDialog extends Serenity.EntityDialog<JobOrderRow, any> {
        protected getFormKey() { return JobOrderForm.formKey; }
        protected getIdProperty() { return JobOrderRow.idProperty; }
        protected getLocalTextPrefix() { return JobOrderRow.localTextPrefix; }
        protected getNameProperty() { return JobOrderRow.nameProperty; }
        protected getService() { return JobOrderService.baseUrl; }

        protected form = new JobOrderForm(this.idPrefix);

    }
}