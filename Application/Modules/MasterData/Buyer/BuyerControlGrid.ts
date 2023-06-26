
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class BuyerControlGrid extends Serenity.EntityGrid<BuyerControlRow, any> {
        protected getColumnsKey() { return 'MasterData.BuyerControl'; }
        protected getDialogType() { return BuyerControlDialog; }
        protected getIdProperty() { return BuyerControlRow.idProperty; }
        protected getLocalTextPrefix() { return BuyerControlRow.localTextPrefix; }
        protected getService() { return BuyerControlService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}