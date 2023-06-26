
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AnalysisCategoryDialog extends Serenity.EntityDialog<AnalysisCategoryRow, any> {
        protected getFormKey() { return AnalysisCategoryForm.formKey; }
        protected getIdProperty() { return AnalysisCategoryRow.idProperty; }
        protected getLocalTextPrefix() { return AnalysisCategoryRow.localTextPrefix; }
        protected getNameProperty() { return AnalysisCategoryRow.nameProperty; }
        protected getService() { return AnalysisCategoryService.baseUrl; }

        protected form = new AnalysisCategoryForm(this.idPrefix);

    }
}