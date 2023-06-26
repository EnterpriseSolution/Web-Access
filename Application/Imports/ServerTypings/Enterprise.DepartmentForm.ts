namespace Matrix.Enterprise {
    export class DepartmentForm extends Serenity.PrefixedContext {
        static formKey = 'Enterprise.Department';

    }

    export interface DepartmentForm {
        Dept: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
    }

    [['Dept', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
].forEach(x => Object.defineProperty(DepartmentForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

