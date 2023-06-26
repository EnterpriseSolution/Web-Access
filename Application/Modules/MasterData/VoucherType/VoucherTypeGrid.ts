
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class VoucherTypeGrid extends Serenity.EntityGrid<VoucherTypeRow, any> {
        protected getColumnsKey() { return 'MasterData.VoucherType'; }
        protected getDialogType() { return VoucherTypeDialog; }
        protected getIdProperty() { return VoucherTypeRow.idProperty; }
        protected getLocalTextPrefix() { return VoucherTypeRow.localTextPrefix; }
        protected getService() { return VoucherTypeService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}