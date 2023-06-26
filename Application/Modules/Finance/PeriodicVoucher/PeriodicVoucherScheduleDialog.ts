
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PeriodicVoucherScheduleDialog extends Serenity.EntityDialog<PeriodicVoucherScheduleRow, any> {
        protected getFormKey() { return PeriodicVoucherScheduleForm.formKey; }
        protected getIdProperty() { return PeriodicVoucherScheduleRow.idProperty; }
        protected getLocalTextPrefix() { return PeriodicVoucherScheduleRow.localTextPrefix; }
        protected getNameProperty() { return PeriodicVoucherScheduleRow.nameProperty; }
        protected getService() { return PeriodicVoucherScheduleService.baseUrl; }

        protected form = new PeriodicVoucherScheduleForm(this.idPrefix);

    }
}