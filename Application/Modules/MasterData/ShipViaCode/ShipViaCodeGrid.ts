
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class ShipViaCodeGrid extends Serenity.EntityGrid<ShipViaCodeRow, any> {
        protected getColumnsKey() { return 'MasterData.ShipViaCode'; }
        protected getDialogType() { return ShipViaCodeDialog; }
        protected getIdProperty() { return ShipViaCodeRow.idProperty; }
        protected getLocalTextPrefix() { return ShipViaCodeRow.localTextPrefix; }
        protected getService() { return ShipViaCodeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}