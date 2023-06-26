
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class BuyerControlDialog extends Serenity.EntityDialog<BuyerControlRow, any> {
        protected getFormKey() { return BuyerControlForm.formKey; }
        protected getIdProperty() { return BuyerControlRow.idProperty; }
        protected getLocalTextPrefix() { return BuyerControlRow.localTextPrefix; }
        protected getNameProperty() { return BuyerControlRow.nameProperty; }
        protected getService() { return BuyerControlService.baseUrl; }

        protected form = new BuyerControlForm(this.idPrefix);

    }
}