
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class PeriodicVoucherGrid extends Serenity.EntityGrid<PeriodicVoucherRow, any> {
        protected getColumnsKey() { return 'Finance.PeriodicVoucher'; }
        protected getDialogType() { return PeriodicVoucherDialog; }
        protected getIdProperty() { return PeriodicVoucherRow.idProperty; }
        protected getLocalTextPrefix() { return PeriodicVoucherRow.localTextPrefix; }
        protected getService() { return PeriodicVoucherService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}