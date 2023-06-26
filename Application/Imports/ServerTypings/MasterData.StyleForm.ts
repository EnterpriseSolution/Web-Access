namespace Matrix.MasterData {
    export class StyleForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Style';

    }

    export interface StyleForm {
        StyleCode: Serenity.StringEditor;
        CollectionCode: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        DieCutter: Serenity.DecimalEditor;
    }

    [['StyleCode', () => Serenity.StringEditor]
   , ['CollectionCode', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['DieCutter', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(StyleForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

