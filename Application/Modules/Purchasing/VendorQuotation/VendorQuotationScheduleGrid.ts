
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    export class VendorQuotationScheduleGrid extends Serenity.EntityGrid<VendorQuotationScheduleRow, any> {
        protected getColumnsKey() { return 'Purchasing.VendorQuotationSchedule'; }
        protected getDialogType() { return VendorQuotationScheduleDialog; }
        protected getIdProperty() { return VendorQuotationScheduleRow.idProperty; }
        protected getLocalTextPrefix() { return VendorQuotationScheduleRow.localTextPrefix; }
        protected getService() { return VendorQuotationScheduleService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}