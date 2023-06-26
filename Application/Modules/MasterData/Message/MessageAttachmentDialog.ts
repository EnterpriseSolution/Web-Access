
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class MessageAttachmentDialog extends Serenity.EntityDialog<MessageAttachmentRow, any> {
        protected getFormKey() { return MessageAttachmentForm.formKey; }
        protected getIdProperty() { return MessageAttachmentRow.idProperty; }
        protected getLocalTextPrefix() { return MessageAttachmentRow.localTextPrefix; }
        protected getNameProperty() { return MessageAttachmentRow.nameProperty; }
        protected getService() { return MessageAttachmentService.baseUrl; }

        protected form = new MessageAttachmentForm(this.idPrefix);

    }
}