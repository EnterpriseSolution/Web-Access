
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    export class VendorQuotationItemAdditionalInfoGrid extends Serenity.EntityGrid<VendorQuotationItemAdditionalInfoRow, any> {
        protected getColumnsKey() { return 'Purchasing.VendorQuotationItemAdditionalInfo'; }
        protected getDialogType() { return VendorQuotationItemAdditionalInfoDialog; }
        protected getIdProperty() { return VendorQuotationItemAdditionalInfoRow.idProperty; }
        protected getLocalTextPrefix() { return VendorQuotationItemAdditionalInfoRow.localTextPrefix; }
        protected getService() { return VendorQuotationItemAdditionalInfoService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}