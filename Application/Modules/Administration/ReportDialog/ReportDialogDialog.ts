
namespace Matrix.EnterpriseSys {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    @Serenity.Decorators.panel()
    export class ReportDialogDialog extends Serenity.EntityDialog<ReportDialogRow, any> {
        protected getFormKey() { return ReportDialogForm.formKey; }
        protected getIdProperty() { return ReportDialogRow.idProperty; }
        protected getLocalTextPrefix() { return ReportDialogRow.localTextPrefix; }
        protected getNameProperty() { return ReportDialogRow.nameProperty; }
        protected getService() { return ReportDialogService.baseUrl; }

        protected form = new ReportDialogForm(this.idPrefix);

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