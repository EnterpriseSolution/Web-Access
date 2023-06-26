
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class VoucherPresetDialog extends Serenity.EntityDialog<VoucherPresetRow, any> {
        protected getFormKey() { return VoucherPresetForm.formKey; }
        protected getIdProperty() { return VoucherPresetRow.idProperty; }
        protected getLocalTextPrefix() { return VoucherPresetRow.localTextPrefix; }
        protected getNameProperty() { return VoucherPresetRow.nameProperty; }
        protected getService() { return VoucherPresetService.baseUrl; }

        protected form = new VoucherPresetForm(this.idPrefix);

    }
}