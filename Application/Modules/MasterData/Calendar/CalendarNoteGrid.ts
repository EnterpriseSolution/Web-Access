
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class CalendarNoteGrid extends Serenity.EntityGrid<CalendarNoteRow, any> {
        protected getColumnsKey() { return 'MasterData.CalendarNote'; }
        protected getDialogType() { return CalendarNoteDialog; }
        protected getIdProperty() { return CalendarNoteRow.idProperty; }
        protected getLocalTextPrefix() { return CalendarNoteRow.localTextPrefix; }
        protected getService() { return CalendarNoteService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}