
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class FundCodeDialog extends Serenity.EntityDialog<FundCodeRow, any> {
        protected getFormKey() { return FundCodeForm.formKey; }
        protected getIdProperty() { return FundCodeRow.idProperty; }
        protected getLocalTextPrefix() { return FundCodeRow.localTextPrefix; }
        protected getNameProperty() { return FundCodeRow.nameProperty; }
        protected getService() { return FundCodeService.baseUrl; }

        protected form = new FundCodeForm(this.idPrefix);

    }
}