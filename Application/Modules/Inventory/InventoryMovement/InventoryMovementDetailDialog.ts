
namespace Matrix.Inventory {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class InventoryMovementDetailDialog extends Serenity.EntityDialog<InventoryMovementDetailRow, any> {
        protected getFormKey() { return InventoryMovementDetailForm.formKey; }
        protected getIdProperty() { return InventoryMovementDetailRow.idProperty; }
        protected getLocalTextPrefix() { return InventoryMovementDetailRow.localTextPrefix; }
        protected getNameProperty() { return InventoryMovementDetailRow.nameProperty; }
        protected getService() { return InventoryMovementDetailService.baseUrl; }

        protected form = new InventoryMovementDetailForm(this.idPrefix);

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