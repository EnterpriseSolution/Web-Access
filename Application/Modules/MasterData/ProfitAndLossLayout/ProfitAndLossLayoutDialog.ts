
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ProfitAndLossLayoutDialog extends Serenity.EntityDialog<ProfitAndLossLayoutRow, any> {
        protected getFormKey() { return ProfitAndLossLayoutForm.formKey; }
        protected getIdProperty() { return ProfitAndLossLayoutRow.idProperty; }
        protected getLocalTextPrefix() { return ProfitAndLossLayoutRow.localTextPrefix; }
        protected getNameProperty() { return ProfitAndLossLayoutRow.nameProperty; }
        protected getService() { return ProfitAndLossLayoutService.baseUrl; }

        protected form = new ProfitAndLossLayoutForm(this.idPrefix);

    }
}