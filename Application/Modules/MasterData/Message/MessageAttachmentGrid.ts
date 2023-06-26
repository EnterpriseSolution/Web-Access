
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class MessageAttachmentGrid extends Serenity.EntityGrid<MessageAttachmentRow, any> {
        protected getColumnsKey() { return 'MasterData.MessageAttachment'; }
        protected getDialogType() { return MessageAttachmentDialog; }
        protected getIdProperty() { return MessageAttachmentRow.idProperty; }
        protected getLocalTextPrefix() { return MessageAttachmentRow.localTextPrefix; }
        protected getService() { return MessageAttachmentService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}