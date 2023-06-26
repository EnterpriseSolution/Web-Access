
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class VoucherGrid extends Serenity.EntityGrid<VoucherRow, any> {
        protected getColumnsKey() { return 'Finance.Voucher'; }
        protected getDialogType() { return VoucherDialog; }
        protected getIdProperty() { return VoucherRow.idProperty; }
        protected getLocalTextPrefix() { return VoucherRow.localTextPrefix; }
        protected getService() { return VoucherService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}