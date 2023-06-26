namespace Matrix.Administration {
    export class TranslationForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.Translation';

    }

    export interface TranslationForm {
        LanguageCode: Serenity.EnumEditor;
        KeyText: Serenity.StringEditor;
        DisplayText: Serenity.StringEditor;
    }

    [['LanguageCode', () => Serenity.EnumEditor]
   , ['KeyText', () => Serenity.StringEditor]
   , ['DisplayText', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(TranslationForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

