
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class VoucherDetailGrid extends Serenity.EntityGrid<VoucherDetailRow, any> {
        protected getColumnsKey() { return 'Finance.VoucherDetail'; }
        protected getDialogType() { return VoucherDetailDialog; }
        protected getIdProperty() { return VoucherDetailRow.idProperty; }
        protected getLocalTextPrefix() { return VoucherDetailRow.localTextPrefix; }
        protected getService() { return VoucherDetailService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}