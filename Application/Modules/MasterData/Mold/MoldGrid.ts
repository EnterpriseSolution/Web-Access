
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class MoldGrid extends Serenity.EntityGrid<MoldRow, any> {
        protected getColumnsKey() { return 'MasterData.Mold'; }
        protected getDialogType() { return MoldDialog; }
        protected getIdProperty() { return MoldRow.idProperty; }
        protected getLocalTextPrefix() { return MoldRow.localTextPrefix; }
        protected getService() { return MoldService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}