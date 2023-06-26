
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AccountDialog extends Serenity.EntityDialog<AccountRow, any> {
        protected getFormKey() { return AccountForm.formKey; }
        protected getIdProperty() { return AccountRow.idProperty; }
        protected getLocalTextPrefix() { return AccountRow.localTextPrefix; }
        protected getNameProperty() { return AccountRow.nameProperty; }
        protected getService() { return AccountService.baseUrl; }

        protected form = new AccountForm(this.idPrefix);

    }
}