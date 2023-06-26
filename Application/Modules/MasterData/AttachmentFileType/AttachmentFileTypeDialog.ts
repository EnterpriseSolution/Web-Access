
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AttachmentFileTypeDialog extends Serenity.EntityDialog<AttachmentFileTypeRow, any> {
        protected getFormKey() { return AttachmentFileTypeForm.formKey; }
        protected getIdProperty() { return AttachmentFileTypeRow.idProperty; }
        protected getLocalTextPrefix() { return AttachmentFileTypeRow.localTextPrefix; }
        protected getNameProperty() { return AttachmentFileTypeRow.nameProperty; }
        protected getService() { return AttachmentFileTypeService.baseUrl; }

        protected form = new AttachmentFileTypeForm(this.idPrefix);

    }
}