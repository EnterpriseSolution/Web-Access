
namespace Matrix.Production {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class BomMaterialDialog extends Serenity.EntityDialog<BomMaterialRow, any> {
        protected getFormKey() { return BomMaterialForm.formKey; }
        protected getIdProperty() { return BomMaterialRow.idProperty; }
        protected getLocalTextPrefix() { return BomMaterialRow.localTextPrefix; }
        protected getNameProperty() { return BomMaterialRow.nameProperty; }
        protected getService() { return BomMaterialService.baseUrl; }

        protected form = new BomMaterialForm(this.idPrefix);

    }
}