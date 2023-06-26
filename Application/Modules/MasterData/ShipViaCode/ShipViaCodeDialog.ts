
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ShipViaCodeDialog extends Serenity.EntityDialog<ShipViaCodeRow, any> {
        protected getFormKey() { return ShipViaCodeForm.formKey; }
        protected getIdProperty() { return ShipViaCodeRow.idProperty; }
        protected getLocalTextPrefix() { return ShipViaCodeRow.localTextPrefix; }
        protected getNameProperty() { return ShipViaCodeRow.nameProperty; }
        protected getService() { return ShipViaCodeService.baseUrl; }

        protected form = new ShipViaCodeForm(this.idPrefix);

    }
}