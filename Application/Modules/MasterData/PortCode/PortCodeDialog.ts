
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class PortCodeDialog extends Serenity.EntityDialog<PortCodeRow, any> {
        protected getFormKey() { return PortCodeForm.formKey; }
        protected getIdProperty() { return PortCodeRow.idProperty; }
        protected getLocalTextPrefix() { return PortCodeRow.localTextPrefix; }
        protected getNameProperty() { return PortCodeRow.nameProperty; }
        protected getService() { return PortCodeService.baseUrl; }

        protected form = new PortCodeForm(this.idPrefix);

    }
}