
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class CommodityDialog extends Serenity.EntityDialog<CommodityRow, any> {
        protected getFormKey() { return CommodityForm.formKey; }
        protected getIdProperty() { return CommodityRow.idProperty; }
        protected getLocalTextPrefix() { return CommodityRow.localTextPrefix; }
        protected getNameProperty() { return CommodityRow.nameProperty; }
        protected getService() { return CommodityService.baseUrl; }

        protected form = new CommodityForm(this.idPrefix);

    }
}