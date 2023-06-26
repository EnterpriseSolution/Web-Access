
namespace Matrix.Enterprise {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class CustomerGroupDialog extends Serenity.EntityDialog<CustomerGroupRow, any> {
        protected getFormKey() { return CustomerGroupForm.formKey; }
        protected getIdProperty() { return CustomerGroupRow.idProperty; }
        protected getLocalTextPrefix() { return CustomerGroupRow.localTextPrefix; }
        protected getNameProperty() { return CustomerGroupRow.nameProperty; }
        protected getService() { return CustomerGroupService.baseUrl; }

        protected form = new CustomerGroupForm(this.idPrefix);

    }
}