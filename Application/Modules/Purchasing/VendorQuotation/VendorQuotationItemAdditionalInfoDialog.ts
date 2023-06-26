
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class VendorQuotationItemAdditionalInfoDialog extends Serenity.EntityDialog<VendorQuotationItemAdditionalInfoRow, any> {
        protected getFormKey() { return VendorQuotationItemAdditionalInfoForm.formKey; }
        protected getIdProperty() { return VendorQuotationItemAdditionalInfoRow.idProperty; }
        protected getLocalTextPrefix() { return VendorQuotationItemAdditionalInfoRow.localTextPrefix; }
        protected getNameProperty() { return VendorQuotationItemAdditionalInfoRow.nameProperty; }
        protected getService() { return VendorQuotationItemAdditionalInfoService.baseUrl; }

        protected form = new VendorQuotationItemAdditionalInfoForm(this.idPrefix);

    }
}