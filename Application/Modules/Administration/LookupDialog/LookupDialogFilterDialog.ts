
namespace Matrix.Administration {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class LookupDialogFilterDialog extends Serenity.EntityDialog<LookupDialogFilterRow, any> {
        protected getFormKey() { return LookupDialogFilterForm.formKey; }
        protected getIdProperty() { return LookupDialogFilterRow.idProperty; }
        protected getLocalTextPrefix() { return LookupDialogFilterRow.localTextPrefix; }
        protected getNameProperty() { return LookupDialogFilterRow.nameProperty; }
        protected getService() { return LookupDialogFilterService.baseUrl; }

        protected form = new LookupDialogFilterForm(this.idPrefix);

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