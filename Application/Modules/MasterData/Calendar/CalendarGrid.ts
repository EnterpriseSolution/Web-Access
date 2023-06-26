
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class CalendarGrid extends Serenity.EntityGrid<CalendarRow, any> {
        protected getColumnsKey() { return 'MasterData.Calendar'; }
        protected getDialogType() { return CalendarDialog; }
        protected getIdProperty() { return CalendarRow.idProperty; }
        protected getLocalTextPrefix() { return CalendarRow.localTextPrefix; }
        protected getService() { return CalendarService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}