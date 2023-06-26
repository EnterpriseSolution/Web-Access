namespace Matrix.MasterData {
    export class SizeForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Size';

    }

    export interface SizeForm {
        Size: Serenity.StringEditor;
        Suspended: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        CreatedBy: Serenity.StringEditor;
        CreatedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
    }

    [['Size', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
].forEach(x => Object.defineProperty(SizeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

