namespace Matrix.MasterData {
    export class PlannerForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Planner';

    }

    export interface PlannerForm {
        Planner: Serenity.StringEditor;
        Name: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        Userid: Serenity.StringEditor;
    }

    [['Planner', () => Serenity.StringEditor]
   , ['Name', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['Userid', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(PlannerForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

