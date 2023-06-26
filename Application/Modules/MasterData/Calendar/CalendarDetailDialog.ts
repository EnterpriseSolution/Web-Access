
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class CalendarDetailDialog extends Serenity.EntityDialog<CalendarDetailRow, any> {
        protected getFormKey() { return CalendarDetailForm.formKey; }
        protected getIdProperty() { return CalendarDetailRow.idProperty; }
        protected getLocalTextPrefix() { return CalendarDetailRow.localTextPrefix; }
        protected getNameProperty() { return CalendarDetailRow.nameProperty; }
        protected getService() { return CalendarDetailService.baseUrl; }

        protected form = new CalendarDetailForm(this.idPrefix);

    }
}