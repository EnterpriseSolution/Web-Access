
namespace Matrix.Administration {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class LookupDialogFilterDetailDialog extends Serenity.EntityDialog<LookupDialogFilterDetailRow, any> {
        protected getFormKey() { return LookupDialogFilterDetailForm.formKey; }
        protected getIdProperty() { return LookupDialogFilterDetailRow.idProperty; }
        protected getLocalTextPrefix() { return LookupDialogFilterDetailRow.localTextPrefix; }
        protected getNameProperty() { return LookupDialogFilterDetailRow.nameProperty; }
        protected getService() { return LookupDialogFilterDetailService.baseUrl; }

        protected form = new LookupDialogFilterDetailForm(this.idPrefix);

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