
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class ContactTypeGrid extends Serenity.EntityGrid<ContactTypeRow, any> {
        protected getColumnsKey() { return 'MasterData.ContactType'; }
        protected getDialogType() { return ContactTypeDialog; }
        protected getIdProperty() { return ContactTypeRow.idProperty; }
        protected getLocalTextPrefix() { return ContactTypeRow.localTextPrefix; }
        protected getService() { return ContactTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}