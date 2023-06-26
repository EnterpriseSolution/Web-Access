
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class VoucherCurrencyDetailGrid extends Serenity.EntityGrid<VoucherCurrencyDetailRow, any> {
        protected getColumnsKey() { return 'Finance.VoucherCurrencyDetail'; }
        protected getDialogType() { return VoucherCurrencyDetailDialog; }
        protected getIdProperty() { return VoucherCurrencyDetailRow.idProperty; }
        protected getLocalTextPrefix() { return VoucherCurrencyDetailRow.localTextPrefix; }
        protected getService() { return VoucherCurrencyDetailService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}