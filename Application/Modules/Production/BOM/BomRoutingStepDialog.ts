
namespace Matrix.Production {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class BomRoutingStepDialog extends Serenity.EntityDialog<BomRoutingStepRow, any> {
        protected getFormKey() { return BomRoutingStepForm.formKey; }
        protected getIdProperty() { return BomRoutingStepRow.idProperty; }
        protected getLocalTextPrefix() { return BomRoutingStepRow.localTextPrefix; }
        protected getNameProperty() { return BomRoutingStepRow.nameProperty; }
        protected getService() { return BomRoutingStepService.baseUrl; }

        protected form = new BomRoutingStepForm(this.idPrefix);

    }
}