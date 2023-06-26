
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class PeriodicVoucherDetailGrid extends Serenity.EntityGrid<PeriodicVoucherDetailRow, any> {
        protected getColumnsKey() { return 'Finance.PeriodicVoucherDetail'; }
        protected getDialogType() { return PeriodicVoucherDetailDialog; }
        protected getIdProperty() { return PeriodicVoucherDetailRow.idProperty; }
        protected getLocalTextPrefix() { return PeriodicVoucherDetailRow.localTextPrefix; }
        protected getService() { return PeriodicVoucherDetailService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}