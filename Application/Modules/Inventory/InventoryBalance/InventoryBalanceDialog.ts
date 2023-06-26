
namespace Matrix.Inventory {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class InventoryBalanceDialog extends Serenity.EntityDialog<InventoryBalanceRow, any> {
        protected getFormKey() { return InventoryBalanceForm.formKey; }
        protected getIdProperty() { return InventoryBalanceRow.idProperty; }
        protected getLocalTextPrefix() { return InventoryBalanceRow.localTextPrefix; }
        protected getNameProperty() { return InventoryBalanceRow.nameProperty; }
        protected getService() { return InventoryBalanceService.baseUrl; }

        protected form = new InventoryBalanceForm(this.idPrefix);

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