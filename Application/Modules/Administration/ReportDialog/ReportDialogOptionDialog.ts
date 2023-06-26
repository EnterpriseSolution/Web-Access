
namespace Matrix.EnterpriseSys {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class ReportDialogOptionDialog extends Serenity.EntityDialog<ReportDialogOptionRow, any> {
        protected getFormKey() { return ReportDialogOptionForm.formKey; }
       
        protected getLocalTextPrefix() { return ReportDialogOptionRow.localTextPrefix; }
        protected getNameProperty() { return ReportDialogOptionRow.nameProperty; }
        protected getService() { return ReportDialogOptionService.baseUrl; }

        protected form = new ReportDialogOptionForm(this.idPrefix);

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