
namespace Matrix.Administration {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.panel()
    export class LookupDialogDialog extends Serenity.EntityDialog<LookupDialogRow, any> {
        protected getFormKey() { return LookupDialogForm.formKey; }
        protected getIdProperty() { return LookupDialogRow.idProperty; }
        protected getLocalTextPrefix() { return LookupDialogRow.localTextPrefix; }
        protected getNameProperty() { return LookupDialogRow.nameProperty; }
        protected getService() { return LookupDialogService.baseUrl; }

        protected form = new LookupDialogForm(this.idPrefix);

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