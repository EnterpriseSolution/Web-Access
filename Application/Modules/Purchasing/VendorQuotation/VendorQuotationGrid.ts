
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    export class VendorQuotationGrid extends Serenity.EntityGrid<VendorQuotationRow, any> {
        protected getColumnsKey() { return 'Purchasing.VendorQuotation'; }
        protected getDialogType() { return VendorQuotationDialog; }
        protected getIdProperty() { return VendorQuotationRow.idProperty; }
        protected getLocalTextPrefix() { return VendorQuotationRow.localTextPrefix; }
        protected getService() { return VendorQuotationService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}