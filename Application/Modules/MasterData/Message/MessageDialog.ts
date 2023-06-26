
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class MessageDialog extends Serenity.EntityDialog<MessageRow, any> {
        protected getFormKey() { return MessageForm.formKey; }
        protected getIdProperty() { return MessageRow.idProperty; }
        protected getLocalTextPrefix() { return MessageRow.localTextPrefix; }
        protected getNameProperty() { return MessageRow.nameProperty; }
        protected getService() { return MessageService.baseUrl; }

        protected form = new MessageForm(this.idPrefix);

    }
}