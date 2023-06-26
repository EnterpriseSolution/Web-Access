
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PayTermDialog extends Serenity.EntityDialog<PayTermRow, any> {
        protected getFormKey() { return PayTermForm.formKey; }
        protected getIdProperty() { return PayTermRow.idProperty; }
        protected getLocalTextPrefix() { return PayTermRow.localTextPrefix; }
        protected getNameProperty() { return PayTermRow.nameProperty; }
        protected getService() { return PayTermService.baseUrl; }

        protected form = new PayTermForm(this.idPrefix);

    }
}