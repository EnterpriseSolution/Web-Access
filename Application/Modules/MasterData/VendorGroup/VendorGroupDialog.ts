
namespace Matrix.Enterprise {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class VendorGroupDialog extends Serenity.EntityDialog<VendorGroupRow, any> {
        protected getFormKey() { return VendorGroupForm.formKey; }
        protected getIdProperty() { return VendorGroupRow.idProperty; }
        protected getLocalTextPrefix() { return VendorGroupRow.localTextPrefix; }
        protected getNameProperty() { return VendorGroupRow.nameProperty; }
        protected getService() { return VendorGroupService.baseUrl; }

        protected form = new VendorGroupForm(this.idPrefix);

    }
}