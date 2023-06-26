
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class PurchaseRequisitionDialog extends Serenity.EntityDialog<PurchaseRequisitionRow, any> {
        protected getFormKey() { return PurchaseRequisitionForm.formKey; }
        protected getIdProperty() { return PurchaseRequisitionRow.idProperty; }
        protected getLocalTextPrefix() { return PurchaseRequisitionRow.localTextPrefix; }
        protected getNameProperty() { return PurchaseRequisitionRow.nameProperty; }
        protected getService() { return PurchaseRequisitionService.baseUrl; }

        protected form = new PurchaseRequisitionForm(this.idPrefix);

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