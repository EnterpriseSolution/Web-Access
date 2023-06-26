
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class MachineDialog extends Serenity.EntityDialog<MachineRow, any> {
        protected getFormKey() { return MachineForm.formKey; }
        protected getIdProperty() { return MachineRow.idProperty; }
        protected getLocalTextPrefix() { return MachineRow.localTextPrefix; }
        protected getNameProperty() { return MachineRow.nameProperty; }
        protected getService() { return MachineService.baseUrl; }

        protected form = new MachineForm(this.idPrefix);

    }
}