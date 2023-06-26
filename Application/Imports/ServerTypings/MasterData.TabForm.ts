namespace Matrix.MasterData {
    export class TabForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Tab';

    }

    export interface TabForm {
        Caption: Serenity.StringEditor;
    }

    [['Caption', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(TabForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

