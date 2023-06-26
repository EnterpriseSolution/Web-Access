
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class VoucherDetailDialog extends Serenity.EntityDialog<VoucherDetailRow, any> {
        protected getFormKey() { return VoucherDetailForm.formKey; }
        protected getIdProperty() { return VoucherDetailRow.idProperty; }
        protected getLocalTextPrefix() { return VoucherDetailRow.localTextPrefix; }
        protected getNameProperty() { return VoucherDetailRow.nameProperty; }
        protected getService() { return VoucherDetailService.baseUrl; }

        protected form = new VoucherDetailForm(this.idPrefix);

    }
}