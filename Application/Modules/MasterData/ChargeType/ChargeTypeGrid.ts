
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class ChargeTypeGrid extends Serenity.EntityGrid<ChargeTypeRow, any> {
        protected getColumnsKey() { return 'MasterData.ChargeType'; }
        protected getDialogType() { return ChargeTypeDialog; }
        protected getIdProperty() { return ChargeTypeRow.idProperty; }
        protected getLocalTextPrefix() { return ChargeTypeRow.localTextPrefix; }
        protected getService() { return ChargeTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}