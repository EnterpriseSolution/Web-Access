
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class GrnOrderDialog extends Serenity.EntityDialog<GrnOrderRow, any> {
        protected getFormKey() { return GrnOrderForm.formKey; }
        protected getIdProperty() { return GrnOrderRow.idProperty; }
        protected getLocalTextPrefix() { return GrnOrderRow.localTextPrefix; }
        protected getNameProperty() { return GrnOrderRow.nameProperty; }
        protected getService() { return GrnOrderService.baseUrl; }

        protected form = new GrnOrderForm(this.idPrefix);

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