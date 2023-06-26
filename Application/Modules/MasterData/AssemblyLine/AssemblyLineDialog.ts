
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AssemblyLineDialog extends Serenity.EntityDialog<AssemblyLineRow, any> {
        protected getFormKey() { return AssemblyLineForm.formKey; }
        protected getIdProperty() { return AssemblyLineRow.idProperty; }
        protected getLocalTextPrefix() { return AssemblyLineRow.localTextPrefix; }
        protected getNameProperty() { return AssemblyLineRow.nameProperty; }
        protected getService() { return AssemblyLineService.baseUrl; }

        protected form = new AssemblyLineForm(this.idPrefix);

    }
}