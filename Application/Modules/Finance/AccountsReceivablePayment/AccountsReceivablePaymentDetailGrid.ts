
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class AccountsReceivablePaymentDetailGrid extends Serenity.EntityGrid<AccountsReceivablePaymentDetailRow, any> {
        protected getColumnsKey() { return 'Finance.AccountsReceivablePaymentDetail'; }
        protected getDialogType() { return AccountsReceivablePaymentDetailDialog; }
        protected getIdProperty() { return AccountsReceivablePaymentDetailRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsReceivablePaymentDetailRow.localTextPrefix; }
        protected getService() { return AccountsReceivablePaymentDetailService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}