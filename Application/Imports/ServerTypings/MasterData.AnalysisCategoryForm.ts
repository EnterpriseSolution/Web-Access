namespace Matrix.MasterData {
    export class AnalysisCategoryForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.AnalysisCategory';

    }

    export interface AnalysisCategoryForm {
        Category: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Caption: Serenity.StringEditor;
    }

    [['Category', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Caption', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(AnalysisCategoryForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

