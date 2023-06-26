
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class CalendarNoteDialog extends Serenity.EntityDialog<CalendarNoteRow, any> {
        protected getFormKey() { return CalendarNoteForm.formKey; }
        protected getIdProperty() { return CalendarNoteRow.idProperty; }
        protected getLocalTextPrefix() { return CalendarNoteRow.localTextPrefix; }
        protected getNameProperty() { return CalendarNoteRow.nameProperty; }
        protected getService() { return CalendarNoteService.baseUrl; }

        protected form = new CalendarNoteForm(this.idPrefix);

    }
}