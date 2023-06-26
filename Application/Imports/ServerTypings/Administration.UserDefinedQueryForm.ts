namespace Matrix.Administration {
    export class UserDefinedQueryForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.UserDefinedQuery';

    }

    export interface UserDefinedQueryForm {
        Description: Serenity.StringEditor;
        CreatedBy: Serenity.StringEditor;
        CreatedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        AllowDuplicates: Serenity.BooleanEditor;
        Suspended: Serenity.BooleanEditor;
        DataSource: Serenity.IntegerEditor;
        UseAsEnquiry: Serenity.BooleanEditor;
        UseAsLookup: Serenity.BooleanEditor;
        UseAsAlert: Serenity.BooleanEditor;
        UseAsComparation: Serenity.BooleanEditor;
        FunctionCode: Serenity.StringEditor;
        PrimaryKeyFields: Serenity.StringEditor;
        CustomerNoEntityName: Serenity.StringEditor;
        CustomerNoFieldName: Serenity.StringEditor;
        VendorNoEntityName: Serenity.StringEditor;
        VendorNoFieldName: Serenity.StringEditor;
        Filter: Serenity.StringEditor;
        Sql: Serenity.StringEditor;
    }

    [['Description', () => Serenity.StringEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['AllowDuplicates', () => Serenity.BooleanEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['DataSource', () => Serenity.IntegerEditor]
   , ['UseAsEnquiry', () => Serenity.BooleanEditor]
   , ['UseAsLookup', () => Serenity.BooleanEditor]
   , ['UseAsAlert', () => Serenity.BooleanEditor]
   , ['UseAsComparation', () => Serenity.BooleanEditor]
   , ['FunctionCode', () => Serenity.StringEditor]
   , ['PrimaryKeyFields', () => Serenity.StringEditor]
   , ['CustomerNoEntityName', () => Serenity.StringEditor]
   , ['CustomerNoFieldName', () => Serenity.StringEditor]
   , ['VendorNoEntityName', () => Serenity.StringEditor]
   , ['VendorNoFieldName', () => Serenity.StringEditor]
   , ['Filter', () => Serenity.StringEditor]
   , ['Sql', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(UserDefinedQueryForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

