
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class BalanceSheetLayoutDialog extends Serenity.EntityDialog<BalanceSheetLayoutRow, any> {
        protected getFormKey() { return BalanceSheetLayoutForm.formKey; }
        protected getIdProperty() { return BalanceSheetLayoutRow.idProperty; }
        protected getLocalTextPrefix() { return BalanceSheetLayoutRow.localTextPrefix; }
        protected getNameProperty() { return BalanceSheetLayoutRow.nameProperty; }
        protected getService() { return BalanceSheetLayoutService.baseUrl; }

        protected form = new BalanceSheetLayoutForm(this.idPrefix);

    }
}