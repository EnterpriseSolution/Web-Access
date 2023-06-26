
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class VoucherCancellationGrid extends Serenity.EntityGrid<VoucherCancellationRow, any> {
        protected getColumnsKey() { return 'Finance.VoucherCancellation'; }
        protected getDialogType() { return VoucherCancellationDialog; }
        protected getIdProperty() { return VoucherCancellationRow.idProperty; }
        protected getLocalTextPrefix() { return VoucherCancellationRow.localTextPrefix; }
        protected getService() { return VoucherCancellationService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}