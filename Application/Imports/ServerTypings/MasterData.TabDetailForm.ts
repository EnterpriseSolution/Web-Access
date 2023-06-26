namespace Matrix.MasterData {
    export class TabDetailForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.TabDetail';

    }

    export interface TabDetailForm {
        ItemGroup: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        CreatedDate: Serenity.DateEditor;
        CreatedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
    }

    [['ItemGroup', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(TabDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

