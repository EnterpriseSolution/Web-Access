
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PeriodicVoucherDetailDialog extends Serenity.EntityDialog<PeriodicVoucherDetailRow, any> {
        protected getFormKey() { return PeriodicVoucherDetailForm.formKey; }
        protected getIdProperty() { return PeriodicVoucherDetailRow.idProperty; }
        protected getLocalTextPrefix() { return PeriodicVoucherDetailRow.localTextPrefix; }
        protected getNameProperty() { return PeriodicVoucherDetailRow.nameProperty; }
        protected getService() { return PeriodicVoucherDetailService.baseUrl; }

        protected form = new PeriodicVoucherDetailForm(this.idPrefix);

    }
}