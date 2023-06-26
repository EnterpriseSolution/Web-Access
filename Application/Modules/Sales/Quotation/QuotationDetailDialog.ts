
namespace Matrix.Sales {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.panel()
    @Serenity.Decorators.responsive()
    export class QuotationDetailDialog extends Serenity.EntityDialog<QuotationDetailRow, any> {
        protected getFormKey() { return QuotationDetailForm.formKey; }
        protected getIdProperty() { return QuotationDetailRow.idProperty; }
        protected getLocalTextPrefix() { return QuotationDetailRow.localTextPrefix; }
        protected getNameProperty() { return QuotationDetailRow.nameProperty; }
        protected getService() { return QuotationDetailService.baseUrl; }

        protected form = new QuotationDetailForm(this.idPrefix);

        //protected getToolbarButtons(): Serenity.ToolButton[] {
        //    let buttons = super.getToolbarButtons();

        //    //buttons.splice(Q.indexOf(buttons, x => x.cssClass === "save-and-close-button"), 1);
        //    //buttons.splice(Q.indexOf(buttons, x => x.cssClass === "apply-changes-button"), 1);
        //    //buttons.splice(Q.indexOf(buttons, x => x.cssClass === "delete-button"), 1);

        //    return buttons;
        //}

        //protected updateInterface(): void {
        //    super.updateInterface();

        //    Serenity.EditorUtils.setReadonly(this.element.find('.editor'), true);
        //    this.element.find('sup').hide();

        //    this.deleteButton.hide();
        //    this.applyChangesButton.hide();
        //    this.saveAndCloseButton.hide();
        //}
    }
}