
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class VoucherPresetGrid extends Serenity.EntityGrid<VoucherPresetRow, any> {
        protected getColumnsKey() { return 'Finance.VoucherPreset'; }
        protected getDialogType() { return VoucherPresetDialog; }
        protected getIdProperty() { return VoucherPresetRow.idProperty; }
        protected getLocalTextPrefix() { return VoucherPresetRow.localTextPrefix; }
        protected getService() { return VoucherPresetService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}