
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class SalesmanDialog extends Serenity.EntityDialog<SalesmanRow, any> {
        protected getFormKey() { return SalesmanForm.formKey; }
        protected getIdProperty() { return SalesmanRow.idProperty; }
        protected getLocalTextPrefix() { return SalesmanRow.localTextPrefix; }
        protected getNameProperty() { return SalesmanRow.nameProperty; }
        protected getService() { return SalesmanService.baseUrl; }

        protected form = new SalesmanForm(this.idPrefix);

    }
}