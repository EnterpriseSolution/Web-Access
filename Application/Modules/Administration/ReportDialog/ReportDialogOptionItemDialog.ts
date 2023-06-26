
namespace Matrix.EnterpriseSys {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class ReportDialogOptionItemDialog extends Serenity.EntityDialog<ReportDialogOptionItemRow, any> {
        protected getFormKey() { return ReportDialogOptionItemForm.formKey; }
        protected getIdProperty() { return ReportDialogOptionItemRow.idProperty; }
        protected getLocalTextPrefix() { return ReportDialogOptionItemRow.localTextPrefix; }
        protected getNameProperty() { return ReportDialogOptionItemRow.nameProperty; }
        protected getService() { return ReportDialogOptionItemService.baseUrl; }

        protected form = new ReportDialogOptionItemForm(this.idPrefix);

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