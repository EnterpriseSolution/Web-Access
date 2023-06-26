
namespace Matrix.Sales {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class SalesReturnDialog extends Serenity.EntityDialog<SalesReturnRow, any> {
        protected getFormKey() { return SalesReturnForm.formKey; }
        protected getIdProperty() { return SalesReturnRow.idProperty; }
        protected getLocalTextPrefix() { return SalesReturnRow.localTextPrefix; }
        protected getNameProperty() { return SalesReturnRow.nameProperty; }
        protected getService() { return SalesReturnService.baseUrl; }

        protected form = new SalesReturnForm(this.idPrefix);

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