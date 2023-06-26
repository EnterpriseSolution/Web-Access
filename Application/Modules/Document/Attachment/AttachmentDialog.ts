
namespace Matrix.Document {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class AttachmentDialog extends Serenity.EntityDialog<AttachmentRow, any> {
        protected getFormKey() { return AttachmentForm.formKey; }
        protected getIdProperty() { return AttachmentRow.idProperty; }
        protected getLocalTextPrefix() { return AttachmentRow.localTextPrefix; }
        protected getNameProperty() { return AttachmentRow.nameProperty; }
        protected getService() { return AttachmentService.baseUrl; }

        protected form = new AttachmentForm(this.idPrefix);

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