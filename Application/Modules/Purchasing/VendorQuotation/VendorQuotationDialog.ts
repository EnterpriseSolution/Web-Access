
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class VendorQuotationDialog extends Serenity.EntityDialog<VendorQuotationRow, any> {
        protected getFormKey() { return VendorQuotationForm.formKey; }
        protected getIdProperty() { return VendorQuotationRow.idProperty; }
        protected getLocalTextPrefix() { return VendorQuotationRow.localTextPrefix; }
        protected getNameProperty() { return VendorQuotationRow.nameProperty; }
        protected getService() { return VendorQuotationService.baseUrl; }

        protected form = new VendorQuotationForm(this.idPrefix);

    }
}