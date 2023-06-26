
namespace Matrix.Inventory {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class InventoryMovementDialog extends Serenity.EntityDialog<InventoryMovementRow, any> {

        public static FlowType:string ;

        constructor(container: JQuery) {
            super(container);

            console.log("InventoryMovementDialog.FlowType", InventoryMovementDialog.FlowType);

            if (InventoryMovementDialog.FlowType === "I")
                this.form = new InventoryMovementIssueForm(this.idPrefix);
            if (InventoryMovementDialog.FlowType === "R")
                this.form = new InventoryMovementReceiptForm(this.idPrefix);
            if (InventoryMovementDialog.FlowType === "T")
                this.form = new InventoryMovementTransferForm(this.idPrefix);
        }

        protected getFormKey() {
             return InventoryMovementIssueForm.formKey;
        }

        protected getIdProperty() { return InventoryMovementRow.idProperty; }
        protected getLocalTextPrefix() { return InventoryMovementRow.localTextPrefix; }
        protected getNameProperty() { return InventoryMovementRow.nameProperty; }
        protected getService() {
             return InventoryMovementService.baseUrl;
        }

        protected form :any;

        protected getEntityTitle(): string {
            var entityType = super.getEntitySingular();
            let name = this.getEntityNameFieldValue() || "";
            return Q.format("View {0} ({1})", entityType, name);
        }

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