
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class VoucherCurrencyDetailDialog extends Serenity.EntityDialog<VoucherCurrencyDetailRow, any> {
        protected getFormKey() { return VoucherCurrencyDetailForm.formKey; }
        protected getIdProperty() { return VoucherCurrencyDetailRow.idProperty; }
        protected getLocalTextPrefix() { return VoucherCurrencyDetailRow.localTextPrefix; }
        protected getNameProperty() { return VoucherCurrencyDetailRow.nameProperty; }
        protected getService() { return VoucherCurrencyDetailService.baseUrl; }

        protected form = new VoucherCurrencyDetailForm(this.idPrefix);

    }
}