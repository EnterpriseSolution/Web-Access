
namespace Matrix.Administration {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class TranslationDialog extends Serenity.EntityDialog<TranslationRow, any> {
        protected getFormKey() { return TranslationForm.formKey; }
        protected getIdProperty() { return "__id"; }
        protected getLocalTextPrefix() { return TranslationRow.localTextPrefix; }
        protected getNameProperty() { return TranslationRow.nameProperty; }
        protected getService() { return TranslationService.baseUrl; }

        protected form = new TranslationForm(this.idPrefix);  

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