
namespace Matrix.Sales {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class ShipmentDetailDialog extends Serenity.EntityDialog<ShipmentDetailRow, any> {
        protected getFormKey() { return ShipmentDetailForm.formKey; }
        protected getIdProperty() { return ShipmentDetailRow.idProperty; }
        protected getLocalTextPrefix() { return ShipmentDetailRow.localTextPrefix; }
        protected getNameProperty() { return ShipmentDetailRow.nameProperty; }
        protected getService() { return ShipmentDetailService.baseUrl; }

        protected form = new ShipmentDetailForm(this.idPrefix);

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