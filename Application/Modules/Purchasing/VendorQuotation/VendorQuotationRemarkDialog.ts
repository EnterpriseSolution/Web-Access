
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class VendorQuotationRemarkDialog extends Serenity.EntityDialog<VendorQuotationRemarkRow, any> {
        protected getFormKey() { return VendorQuotationRemarkForm.formKey; }
        protected getIdProperty() { return VendorQuotationRemarkRow.idProperty; }
        protected getLocalTextPrefix() { return VendorQuotationRemarkRow.localTextPrefix; }
        protected getNameProperty() { return VendorQuotationRemarkRow.nameProperty; }
        protected getService() { return VendorQuotationRemarkService.baseUrl; }

        protected form = new VendorQuotationRemarkForm(this.idPrefix);

    }
}