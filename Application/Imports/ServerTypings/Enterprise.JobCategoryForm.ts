namespace Matrix.Enterprise {
    export class JobCategoryForm extends Serenity.PrefixedContext {
        static formKey = 'Enterprise.JobCategory';

    }

    export interface JobCategoryForm {
        Category: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        Priority: Serenity.DecimalEditor;
    }

    [['Category', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['Priority', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(JobCategoryForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

