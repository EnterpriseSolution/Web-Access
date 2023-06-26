
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class TextTypeGrid extends Serenity.EntityGrid<TextTypeRow, any> {
        protected getColumnsKey() { return 'MasterData.TextType'; }
        protected getDialogType() { return TextTypeDialog; }
        protected getIdProperty() { return TextTypeRow.idProperty; }
        protected getLocalTextPrefix() { return TextTypeRow.localTextPrefix; }
        protected getService() { return TextTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}