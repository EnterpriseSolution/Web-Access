
namespace Matrix.Production {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class JobOrderRoutingStepDialog extends Serenity.EntityDialog<JobOrderRoutingStepRow, any> {
        protected getFormKey() { return JobOrderRoutingStepForm.formKey; }
        protected getIdProperty() { return JobOrderRoutingStepRow.idProperty; }
        protected getLocalTextPrefix() { return JobOrderRoutingStepRow.localTextPrefix; }
        protected getNameProperty() { return JobOrderRoutingStepRow.nameProperty; }
        protected getService() { return JobOrderRoutingStepService.baseUrl; }

        protected form = new JobOrderRoutingStepForm(this.idPrefix);

    }
}