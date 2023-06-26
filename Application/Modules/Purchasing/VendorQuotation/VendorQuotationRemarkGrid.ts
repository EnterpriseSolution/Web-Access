
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    export class VendorQuotationRemarkGrid extends Serenity.EntityGrid<VendorQuotationRemarkRow, any> {
        protected getColumnsKey() { return 'Purchasing.VendorQuotationRemark'; }
        protected getDialogType() { return VendorQuotationRemarkDialog; }
        protected getIdProperty() { return VendorQuotationRemarkRow.idProperty; }
        protected getLocalTextPrefix() { return VendorQuotationRemarkRow.localTextPrefix; }
        protected getService() { return VendorQuotationRemarkService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}