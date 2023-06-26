
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AssemblyLineWorkCentreDetailDialog extends Serenity.EntityDialog<AssemblyLineWorkCentreDetailRow, any> {
        protected getFormKey() { return AssemblyLineWorkCentreDetailForm.formKey; }
        protected getIdProperty() { return AssemblyLineWorkCentreDetailRow.idProperty; }
        protected getLocalTextPrefix() { return AssemblyLineWorkCentreDetailRow.localTextPrefix; }
        protected getNameProperty() { return AssemblyLineWorkCentreDetailRow.nameProperty; }
        protected getService() { return AssemblyLineWorkCentreDetailService.baseUrl; }

        protected form = new AssemblyLineWorkCentreDetailForm(this.idPrefix);

    }
}