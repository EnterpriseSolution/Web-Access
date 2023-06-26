
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class PurchaseRequisitionDetailDialog extends Serenity.EntityDialog<PurchaseRequisitionDetailRow, any> {
        protected getFormKey() { return PurchaseRequisitionDetailForm.formKey; }
        protected getIdProperty() { return PurchaseRequisitionDetailRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseRequisitionDetailRow.localTextPrefix; }
        protected getNameProperty() { return PurchaseRequisitionDetailRow.nameProperty; }
        protected getService() { return PurchaseRequisitionDetailService.baseUrl; }

        protected form = new PurchaseRequisitionDetailForm(this.idPrefix);

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