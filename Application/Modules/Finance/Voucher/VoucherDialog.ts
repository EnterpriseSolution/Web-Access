
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class VoucherDialog extends Serenity.EntityDialog<VoucherRow, any> {
        protected getFormKey() { return VoucherForm.formKey; }
        protected getIdProperty() { return VoucherRow.idProperty; }
        protected getLocalTextPrefix() { return VoucherRow.localTextPrefix; }
        protected getNameProperty() { return VoucherRow.nameProperty; }
        protected getService() { return VoucherService.baseUrl; }

        protected form = new VoucherForm(this.idPrefix);

    }
}