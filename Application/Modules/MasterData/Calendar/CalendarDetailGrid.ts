
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class CalendarDetailGrid extends Serenity.EntityGrid<CalendarDetailRow, any> {
        protected getColumnsKey() { return 'MasterData.CalendarDetail'; }
        protected getDialogType() { return CalendarDetailDialog; }
        protected getIdProperty() { return CalendarDetailRow.idProperty; }
        protected getLocalTextPrefix() { return CalendarDetailRow.localTextPrefix; }
        protected getService() { return CalendarDetailService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}