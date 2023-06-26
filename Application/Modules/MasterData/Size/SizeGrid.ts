
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class SizeGrid extends Serenity.EntityGrid<SizeRow, any> {
        protected getColumnsKey() { return 'MasterData.Size'; }
        protected getDialogType() { return SizeDialog; }
        protected getIdProperty() { return SizeRow.idProperty; }
        protected getLocalTextPrefix() { return SizeRow.localTextPrefix; }
        protected getService() { return SizeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}