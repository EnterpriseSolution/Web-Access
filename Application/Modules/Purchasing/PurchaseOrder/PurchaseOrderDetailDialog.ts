
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class PurchaseOrderDetailDialog extends Serenity.EntityDialog<PurchaseOrderDetailRow, any> {
        protected getFormKey() { return PurchaseOrderDetailForm.formKey; }
        protected getIdProperty() { return PurchaseOrderDetailRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseOrderDetailRow.localTextPrefix; }
        protected getNameProperty() { return PurchaseOrderDetailRow.nameProperty; }
        protected getService() { return PurchaseOrderDetailService.baseUrl; }

        protected form = new PurchaseOrderDetailForm(this.idPrefix);

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