
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    export class FiscalYearGrid extends Serenity.EntityGrid<FiscalYearRow, any> {
        protected getColumnsKey() { return 'MasterData.FiscalYear'; }
        protected getDialogType() { return FiscalYearDialog; }
        protected getIdProperty() { return FiscalYearRow.idProperty; }
        protected getLocalTextPrefix() { return FiscalYearRow.localTextPrefix; }
        protected getService() { return FiscalYearService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getButtons(): Serenity.ToolButton[] {

            // call base method to get list of buttons
            var buttons = super.getButtons();

            // add our import button
            var button = {
                title: 'Fiscal Year',
                cssClass: 'send-button',
                onClick: () => {
                    if (!this.onViewSubmit()) {
                        return;
                    }
                    Q.notifySuccess("Allright!");
                    //var action = new OrderBulkAction();
                    //action.done = () => this.rowSelection.resetCheckedAndRefresh();
                    //action.execute(this.rowSelection.getSelectedKeys());
                }
            };

            buttons.splice(0, 0, button);
        
            return buttons;
        }
    }
}