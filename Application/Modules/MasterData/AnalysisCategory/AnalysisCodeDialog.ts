
namespace Matrix.MasterData {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class AnalysisCodeDialog extends Serenity.EntityDialog<AnalysisCodeRow, any> {
        protected getFormKey() { return AnalysisCodeForm.formKey; }
        protected getIdProperty() { return AnalysisCodeRow.idProperty; }
        protected getLocalTextPrefix() { return AnalysisCodeRow.localTextPrefix; }
        protected getNameProperty() { return AnalysisCodeRow.nameProperty; }
        protected getService() { return AnalysisCodeService.baseUrl; }

        protected form = new AnalysisCodeForm(this.idPrefix);

    }
}