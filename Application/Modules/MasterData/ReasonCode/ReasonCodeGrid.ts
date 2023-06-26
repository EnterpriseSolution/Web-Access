
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class ReasonCodeGrid extends Serenity.EntityGrid<ReasonCodeRow, any> {
        protected getColumnsKey() { return 'MasterData.ReasonCode'; }
        protected getDialogType() { return ReasonCodeDialog; }
        protected getIdProperty() { return ReasonCodeRow.idProperty; }
        protected getLocalTextPrefix() { return ReasonCodeRow.localTextPrefix; }
        protected getService() { return ReasonCodeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}