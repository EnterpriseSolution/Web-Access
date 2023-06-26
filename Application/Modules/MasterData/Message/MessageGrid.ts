
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class MessageGrid extends Serenity.EntityGrid<MessageRow, any> {
        protected getColumnsKey() { return 'MasterData.Message'; }
        protected getDialogType() { return MessageDialog; }
        protected getIdProperty() { return MessageRow.idProperty; }
        protected getLocalTextPrefix() { return MessageRow.localTextPrefix; }
        protected getService() { return MessageService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}