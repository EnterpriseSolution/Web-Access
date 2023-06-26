
namespace Matrix.Production {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class BomDialog extends Serenity.EntityDialog<BomRow, any> {
        protected getFormKey() { return BomForm.formKey; }
        protected getIdProperty() { return BomRow.idProperty; }
        protected getLocalTextPrefix() { return BomRow.localTextPrefix; }
        protected getNameProperty() { return BomRow.nameProperty; }
        protected getService() { return BomService.baseUrl; }

        protected form = new BomForm(this.idPrefix);

    }
}