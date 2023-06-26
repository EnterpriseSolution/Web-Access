
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class MoldDialog extends Serenity.EntityDialog<MoldRow, any> {
        protected getFormKey() { return MoldForm.formKey; }
        protected getIdProperty() { return MoldRow.idProperty; }
        protected getLocalTextPrefix() { return MoldRow.localTextPrefix; }
        protected getNameProperty() { return MoldRow.nameProperty; }
        protected getService() { return MoldService.baseUrl; }

        protected form = new MoldForm(this.idPrefix);

    }
}