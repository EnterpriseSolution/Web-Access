
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class CalendarDialog extends Serenity.EntityDialog<CalendarRow, any> {
        protected getFormKey() { return CalendarForm.formKey; }
        protected getIdProperty() { return CalendarRow.idProperty; }
        protected getLocalTextPrefix() { return CalendarRow.localTextPrefix; }
        protected getNameProperty() { return CalendarRow.nameProperty; }
        protected getService() { return CalendarService.baseUrl; }

        protected form = new CalendarForm(this.idPrefix);

    }
}