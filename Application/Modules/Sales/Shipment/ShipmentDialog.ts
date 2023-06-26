
namespace Matrix.Sales {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class ShipmentDialog extends Serenity.EntityDialog<ShipmentRow, any> {
        protected getFormKey() { return ShipmentForm.formKey; }
        protected getIdProperty() { return ShipmentRow.idProperty; }
        protected getLocalTextPrefix() { return ShipmentRow.localTextPrefix; }
        protected getNameProperty() { return ShipmentRow.nameProperty; }
        protected getService() { return ShipmentService.baseUrl; }

        protected form = new ShipmentForm(this.idPrefix);

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