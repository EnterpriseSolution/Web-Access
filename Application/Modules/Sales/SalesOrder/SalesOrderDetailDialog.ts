
namespace Matrix.Sales {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class SalesOrderDetailDialog extends Serenity.EntityDialog<SalesOrderDetailRow, any> {
        protected getFormKey() { return SalesOrderDetailForm.formKey; }
        protected getIdProperty() { return SalesOrderDetailRow.idProperty; }
        protected getLocalTextPrefix() { return SalesOrderDetailRow.localTextPrefix; }
        protected getNameProperty() { return SalesOrderDetailRow.nameProperty; }
        protected getService() { return SalesOrderDetailService.baseUrl; }

        protected form = new SalesOrderDetailForm(this.idPrefix);

        protected getToolbarButtons(): Serenity.ToolButton[] {
            let buttons = super.getToolbarButtons();

            buttons.splice(Q.indexOf(buttons, x => x.cssClass === "save-and-close-button"), 1);
            buttons.splice(Q.indexOf(buttons, x => x.cssClass === "apply-changes-button"), 1);
            buttons.splice(Q.indexOf(buttons, x => x.cssClass === "delete-button"), 1);

            return buttons;
        }

        protected updateInterface(): void {
            super.updateInterface();

            Serenity.EditorUtils.setReadonly(this.element.find('.editor'), true);
            this.element.find('sup').hide();

            this.deleteButton.hide();
            this.applyChangesButton.hide();
            this.saveAndCloseButton.hide();
        }
    }
}