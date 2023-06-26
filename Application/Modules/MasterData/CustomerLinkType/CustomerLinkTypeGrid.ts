
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class CustomerLinkTypeGrid extends Serenity.EntityGrid<CustomerLinkTypeRow, any> {
        protected getColumnsKey() { return 'MasterData.CustomerLinkType'; }
        protected getDialogType() { return CustomerLinkTypeDialog; }
        protected getIdProperty() { return CustomerLinkTypeRow.idProperty; }
        protected getLocalTextPrefix() { return CustomerLinkTypeRow.localTextPrefix; }
        protected getService() { return CustomerLinkTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}