
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class VendorQuotationScheduleDialog extends Serenity.EntityDialog<VendorQuotationScheduleRow, any> {
        protected getFormKey() { return VendorQuotationScheduleForm.formKey; }
        protected getIdProperty() { return VendorQuotationScheduleRow.idProperty; }
        protected getLocalTextPrefix() { return VendorQuotationScheduleRow.localTextPrefix; }
        protected getNameProperty() { return VendorQuotationScheduleRow.nameProperty; }
        protected getService() { return VendorQuotationScheduleService.baseUrl; }

        protected form = new VendorQuotationScheduleForm(this.idPrefix);

    }
}