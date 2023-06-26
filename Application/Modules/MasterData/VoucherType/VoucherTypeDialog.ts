
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class VoucherTypeDialog extends Serenity.EntityDialog<VoucherTypeRow, any> {
        protected getFormKey() { return VoucherTypeForm.formKey; }
        protected getIdProperty() { return VoucherTypeRow.idProperty; }
        protected getLocalTextPrefix() { return VoucherTypeRow.localTextPrefix; }
        protected getNameProperty() { return VoucherTypeRow.nameProperty; }
        protected getService() { return VoucherTypeService.baseUrl; }

        protected form = new VoucherTypeForm(this.idPrefix);

    }
}