
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ChargeTypeDialog extends Serenity.EntityDialog<ChargeTypeRow, any> {
        protected getFormKey() { return ChargeTypeForm.formKey; }
        protected getIdProperty() { return ChargeTypeRow.idProperty; }
        protected getLocalTextPrefix() { return ChargeTypeRow.localTextPrefix; }
        protected getNameProperty() { return ChargeTypeRow.nameProperty; }
        protected getService() { return ChargeTypeService.baseUrl; }

        protected form = new ChargeTypeForm(this.idPrefix);

    }
}