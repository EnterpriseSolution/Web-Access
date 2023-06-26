/// <reference path="../../../../Serenity/Serenity.TypeScript.CodeGeneration/Serenity.CodeGeneration.d.ts" />
namespace Matrix.Administration {

    @Serenity.Decorators.registerClass()
    export class TranslationGrid extends Serenity.EntityGrid<TranslationRow, any> {
        protected getColumnsKey() { return 'Administration.Translation'; }
        protected getDialogType() { return TranslationDialog; }
        protected getIdProperty() { return "__id"; }
        protected getLocalTextPrefix() { return TranslationRow.localTextPrefix; }
        protected getService() { return TranslationService.baseUrl; }
        private nextId = 1; 

        constructor(container: JQuery) {
            super(container);
        }
           
        protected onViewProcessData(response: Serenity.ListResponse<TranslationRow>) {
            response = super.onViewProcessData(response);
            if (response.Entities == null)
                return response;

            for (var x of response.Entities) {
                (x as any).__id = this.nextId++;
            }
            return response;
        }

        protected getDefaultSortBy() {
            return [TranslationRow.Fields.KeyText];
        }
    }
}  