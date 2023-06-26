
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.panel()
    export class GrnDialog extends Serenity.EntityDialog<GrnRow, any> {
        protected getFormKey() { return GrnForm.formKey; }
        protected getIdProperty() { return GrnRow.idProperty; }
        protected getLocalTextPrefix() { return GrnRow.localTextPrefix; }
        protected getNameProperty() { return GrnRow.nameProperty; }
        protected getService() { return GrnService.baseUrl; }

        protected form = new GrnForm(this.idPrefix);

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