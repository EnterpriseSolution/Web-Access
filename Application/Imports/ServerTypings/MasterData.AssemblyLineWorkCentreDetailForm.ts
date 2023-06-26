namespace Matrix.MasterData {
    export class AssemblyLineWorkCentreDetailForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.AssemblyLineWorkCentreDetail';

    }

    export interface AssemblyLineWorkCentreDetailForm {
        AssemblyLine: Serenity.StringEditor;
        SeqNo: Serenity.DecimalEditor;
        WorkCentre: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Alternate: Serenity.StringEditor;
        Suspended: Serenity.StringEditor;
        CreatedDate: Serenity.DateEditor;
        CreatedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        OwnerBranch: Serenity.StringEditor;
        SourceBranch: Serenity.StringEditor;
    }

    [['AssemblyLine', () => Serenity.StringEditor]
   , ['SeqNo', () => Serenity.DecimalEditor]
   , ['WorkCentre', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Alternate', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.StringEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['OwnerBranch', () => Serenity.StringEditor]
   , ['SourceBranch', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(AssemblyLineWorkCentreDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

