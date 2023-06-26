
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PeriodicVoucherDialog extends Serenity.EntityDialog<PeriodicVoucherRow, any> {
        protected getFormKey() { return PeriodicVoucherForm.formKey; }
        protected getIdProperty() { return PeriodicVoucherRow.idProperty; }
        protected getLocalTextPrefix() { return PeriodicVoucherRow.localTextPrefix; }
        protected getNameProperty() { return PeriodicVoucherRow.nameProperty; }
        protected getService() { return PeriodicVoucherService.baseUrl; }

        protected form = new PeriodicVoucherForm(this.idPrefix);

    }
}