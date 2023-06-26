
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class CollectionGrid extends Serenity.EntityGrid<CollectionRow, any> {
        protected getColumnsKey() { return 'MasterData.Collection'; }
        protected getDialogType() { return CollectionDialog; }
        protected getIdProperty() { return CollectionRow.idProperty; }
        protected getLocalTextPrefix() { return CollectionRow.localTextPrefix; }
        protected getService() { return CollectionService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}