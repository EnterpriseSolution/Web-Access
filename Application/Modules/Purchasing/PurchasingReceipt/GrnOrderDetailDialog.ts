
namespace Matrix.Purchasing {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class GrnOrderDetailDialog extends Serenity.EntityDialog<GrnOrderDetailRow, any> {
        protected getFormKey() { return GrnOrderDetailForm.formKey; }
        protected getIdProperty() { return GrnOrderDetailRow.idProperty; }
        protected getLocalTextPrefix() { return GrnOrderDetailRow.localTextPrefix; }
        protected getNameProperty() { return GrnOrderDetailRow.nameProperty; }
        protected getService() { return GrnOrderDetailService.baseUrl; }

        protected form = new GrnOrderDetailForm(this.idPrefix);

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