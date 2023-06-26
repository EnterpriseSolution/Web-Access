
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class PeriodicVoucherScheduleGrid extends Serenity.EntityGrid<PeriodicVoucherScheduleRow, any> {
        protected getColumnsKey() { return 'Finance.PeriodicVoucherSchedule'; }
        protected getDialogType() { return PeriodicVoucherScheduleDialog; }
        protected getIdProperty() { return PeriodicVoucherScheduleRow.idProperty; }
        protected getLocalTextPrefix() { return PeriodicVoucherScheduleRow.localTextPrefix; }
        protected getService() { return PeriodicVoucherScheduleService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}