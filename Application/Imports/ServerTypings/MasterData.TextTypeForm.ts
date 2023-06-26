namespace Matrix.MasterData {
    export class TextTypeForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.TextType';

    }

    export interface TextTypeForm {
        TextType: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        DefaultText: Serenity.TextAreaEditor;
    }

    [['TextType', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['DefaultText', () => Serenity.TextAreaEditor]
].forEach(x => Object.defineProperty(TextTypeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

