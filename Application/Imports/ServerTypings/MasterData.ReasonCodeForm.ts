namespace Matrix.MasterData {
    export class ReasonCodeForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.ReasonCode';

    }

    export interface ReasonCodeForm {
        ReasonCode: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        Remarks: Serenity.TextAreaEditor;
    }

    [['ReasonCode', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['Remarks', () => Serenity.TextAreaEditor]
].forEach(x => Object.defineProperty(ReasonCodeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

