
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ReasonCodeDialog extends Serenity.EntityDialog<ReasonCodeRow, any> {
        protected getFormKey() { return ReasonCodeForm.formKey; }
        protected getIdProperty() { return ReasonCodeRow.idProperty; }
        protected getLocalTextPrefix() { return ReasonCodeRow.localTextPrefix; }
        protected getNameProperty() { return ReasonCodeRow.nameProperty; }
        protected getService() { return ReasonCodeService.baseUrl; }

        protected form = new ReasonCodeForm(this.idPrefix);

    }
}