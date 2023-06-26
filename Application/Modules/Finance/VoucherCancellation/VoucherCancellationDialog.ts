
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class VoucherCancellationDialog extends Serenity.EntityDialog<VoucherCancellationRow, any> {
        protected getFormKey() { return VoucherCancellationForm.formKey; }
        protected getIdProperty() { return VoucherCancellationRow.idProperty; }
        protected getLocalTextPrefix() { return VoucherCancellationRow.localTextPrefix; }
        protected getNameProperty() { return VoucherCancellationRow.nameProperty; }
        protected getService() { return VoucherCancellationService.baseUrl; }

        protected form = new VoucherCancellationForm(this.idPrefix);

    }
}