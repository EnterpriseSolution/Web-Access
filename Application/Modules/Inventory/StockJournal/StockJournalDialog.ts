
namespace Matrix.Inventory {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class StockJournalDialog extends Serenity.EntityDialog<StockJournalRow, any> {
        protected getFormKey() { return StockJournalForm.formKey; }
        protected getIdProperty() { return StockJournalRow.idProperty; }
        protected getLocalTextPrefix() { return StockJournalRow.localTextPrefix; }
        protected getNameProperty() { return StockJournalRow.nameProperty; }
        protected getService() { return StockJournalService.baseUrl; }

        protected form = new StockJournalForm(this.idPrefix);

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