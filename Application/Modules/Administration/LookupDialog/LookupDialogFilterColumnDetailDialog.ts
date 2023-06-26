
namespace Matrix.Administration {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class LookupDialogFilterColumnDetailDialog extends Serenity.EntityDialog<LookupDialogFilterColumnDetailRow, any> {
        protected getFormKey() { return LookupDialogFilterColumnDetailForm.formKey; }
        protected getIdProperty() { return LookupDialogFilterColumnDetailRow.idProperty; }
        protected getLocalTextPrefix() { return LookupDialogFilterColumnDetailRow.localTextPrefix; }
        protected getNameProperty() { return LookupDialogFilterColumnDetailRow.nameProperty; }
        protected getService() { return LookupDialogFilterColumnDetailService.baseUrl; }

        protected form = new LookupDialogFilterColumnDetailForm(this.idPrefix);

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