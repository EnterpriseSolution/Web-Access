
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class PortCodeGrid extends Serenity.EntityGrid<PortCodeRow, any> {
        protected getColumnsKey() { return 'MasterData.PortCode'; }
        protected getDialogType() { return PortCodeDialog; }
        protected getIdProperty() { return PortCodeRow.idProperty; }
        protected getLocalTextPrefix() { return PortCodeRow.localTextPrefix; }
        protected getService() { return PortCodeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}