namespace Matrix.Administration {
    export class CompanyForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.CompanyForm';

    }

    export interface CompanyForm {
        CompanyCode: Serenity.StringEditor;
        CompanyName: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        DbServer: Serenity.StringEditor;
        DbDatabase: Serenity.StringEditor;
        DbUser: Serenity.StringEditor;
        DbPassword: Serenity.StringEditor;
    }

    [['CompanyCode', () => Serenity.StringEditor]
   , ['CompanyName', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['DbServer', () => Serenity.StringEditor]
   , ['DbDatabase', () => Serenity.StringEditor]
   , ['DbUser', () => Serenity.StringEditor]
   , ['DbPassword', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(CompanyForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

