namespace Matrix.MasterData {
    export class ColorForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Color';

    }

    export interface ColorForm {
        ColorCode: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        ChineseDescription: Serenity.StringEditor;
        ColorGroup: Serenity.StringEditor;
        ItemGroup: Serenity.StringEditor;
    }

    [['ColorCode', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['ChineseDescription', () => Serenity.StringEditor]
   , ['ColorGroup', () => Serenity.StringEditor]
   , ['ItemGroup', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(ColorForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

