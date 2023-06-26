
namespace Matrix.Inventory {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class FifoControlDialog extends Serenity.EntityDialog<FifoControlRow, any> {
        protected getFormKey() { return FifoControlForm.formKey; }
        protected getIdProperty() { return FifoControlRow.idProperty; }
        protected getLocalTextPrefix() { return FifoControlRow.localTextPrefix; }
        protected getNameProperty() { return FifoControlRow.nameProperty; }
        protected getService() { return FifoControlService.baseUrl; }

        protected form = new FifoControlForm(this.idPrefix);

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