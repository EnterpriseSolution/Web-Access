
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class CustomerLinkTypeDialog extends Serenity.EntityDialog<CustomerLinkTypeRow, any> {
        protected getFormKey() { return CustomerLinkTypeForm.formKey; }
        protected getIdProperty() { return CustomerLinkTypeRow.idProperty; }
        protected getLocalTextPrefix() { return CustomerLinkTypeRow.localTextPrefix; }
        protected getNameProperty() { return CustomerLinkTypeRow.nameProperty; }
        protected getService() { return CustomerLinkTypeService.baseUrl; }

        protected form = new CustomerLinkTypeForm(this.idPrefix);

    }
}