namespace Matrix.MasterData {
    export class AnalysisCodeForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.AnalysisCode';

    }

    export interface AnalysisCodeForm {
        Category: Serenity.StringEditor;
        AnalysisCode: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Suspended: Serenity.StringEditor;
        CreatedDate: Serenity.DateEditor;
        CreatedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        OwnerBranch: Serenity.StringEditor;
        SourceBranch: Serenity.StringEditor;
    }

    [['Category', () => Serenity.StringEditor]
   , ['AnalysisCode', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.StringEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['OwnerBranch', () => Serenity.StringEditor]
   , ['SourceBranch', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(AnalysisCodeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

