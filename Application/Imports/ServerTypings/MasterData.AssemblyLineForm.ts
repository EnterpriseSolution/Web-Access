namespace Matrix.MasterData {
    export class AssemblyLineForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.AssemblyLine';

    }

    export interface AssemblyLineForm {
        AssemblyLine: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        Priority: Serenity.StringEditor;
        EffcRating: Serenity.DecimalEditor;
        Restrict0: Serenity.StringEditor;
        Restrict1: Serenity.StringEditor;
        Restrict2: Serenity.StringEditor;
        Restrict3: Serenity.StringEditor;
        Restrict4: Serenity.StringEditor;
        Restrict5: Serenity.StringEditor;
        Restrict6: Serenity.StringEditor;
        Restrict7: Serenity.StringEditor;
        Restrict8: Serenity.StringEditor;
        Restrict9: Serenity.StringEditor;
        Require0: Serenity.StringEditor;
        Require1: Serenity.StringEditor;
        Require2: Serenity.StringEditor;
        Require3: Serenity.StringEditor;
        Require4: Serenity.StringEditor;
        Require5: Serenity.StringEditor;
        Require6: Serenity.StringEditor;
        Require7: Serenity.StringEditor;
        Require8: Serenity.StringEditor;
        Require9: Serenity.StringEditor;
    }

    [['AssemblyLine', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['Priority', () => Serenity.StringEditor]
   , ['EffcRating', () => Serenity.DecimalEditor]
   , ['Restrict0', () => Serenity.StringEditor]
   , ['Restrict1', () => Serenity.StringEditor]
   , ['Restrict2', () => Serenity.StringEditor]
   , ['Restrict3', () => Serenity.StringEditor]
   , ['Restrict4', () => Serenity.StringEditor]
   , ['Restrict5', () => Serenity.StringEditor]
   , ['Restrict6', () => Serenity.StringEditor]
   , ['Restrict7', () => Serenity.StringEditor]
   , ['Restrict8', () => Serenity.StringEditor]
   , ['Restrict9', () => Serenity.StringEditor]
   , ['Require0', () => Serenity.StringEditor]
   , ['Require1', () => Serenity.StringEditor]
   , ['Require2', () => Serenity.StringEditor]
   , ['Require3', () => Serenity.StringEditor]
   , ['Require4', () => Serenity.StringEditor]
   , ['Require5', () => Serenity.StringEditor]
   , ['Require6', () => Serenity.StringEditor]
   , ['Require7', () => Serenity.StringEditor]
   , ['Require8', () => Serenity.StringEditor]
   , ['Require9', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(AssemblyLineForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

