namespace Matrix.MasterData {
    export class CollectionForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Collection';

    }

    export interface CollectionForm {
        CollectionCode: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Remarks: Serenity.TextAreaEditor;
    }

    [['CollectionCode', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Remarks', () => Serenity.TextAreaEditor]
].forEach(x => Object.defineProperty(CollectionForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

