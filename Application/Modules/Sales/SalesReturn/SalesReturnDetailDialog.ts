
namespace Matrix.Sales {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class SalesReturnDetailDialog extends Serenity.EntityDialog<SalesReturnDetailRow, any> {
        protected getFormKey() { return SalesReturnDetailForm.formKey; }
        protected getIdProperty() { return SalesReturnDetailRow.idProperty; }
        protected getLocalTextPrefix() { return SalesReturnDetailRow.localTextPrefix; }
        protected getNameProperty() { return SalesReturnDetailRow.nameProperty; }
        protected getService() { return SalesReturnDetailService.baseUrl; }

        protected form = new SalesReturnDetailForm(this.idPrefix);

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