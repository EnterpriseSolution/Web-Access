
namespace Matrix.Sales {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class QuotationDialog extends Serenity.EntityDialog<QuotationRow, any> {
        protected getFormKey() { return QuotationForm.formKey; }
        protected getIdProperty() { return QuotationRow.idProperty; }
        protected getLocalTextPrefix() { return QuotationRow.localTextPrefix; }
        protected getNameProperty() { return QuotationRow.nameProperty; }
        protected getService() { return QuotationService.baseUrl; }

        protected form = new QuotationForm(this.idPrefix);

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

            this.element.find('.s-DialogToolbar').hide();
        }
    }
}