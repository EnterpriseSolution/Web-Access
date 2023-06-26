
namespace Matrix.Finance {

    @Serenity.Decorators.registerClass()
    export class AccountsPayablePaymentDetailGrid extends Serenity.EntityGrid<AccountsPayablePaymentDetailRow, any> {
        protected getColumnsKey() { return 'Finance.AccountsPayablePaymentDetail'; }
        protected getDialogType() { return AccountsPayablePaymentDetailDialog; }
        protected getIdProperty() { return AccountsPayablePaymentDetailRow.idProperty; }
        protected getLocalTextPrefix() { return AccountsPayablePaymentDetailRow.localTextPrefix; }
        protected getService() { return AccountsPayablePaymentDetailService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}