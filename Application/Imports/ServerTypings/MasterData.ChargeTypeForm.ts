namespace Matrix.MasterData {
    export class ChargeTypeForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.ChargeType';

    }

    export interface ChargeTypeForm {
        ChargeType: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        Deduction: Serenity.BooleanEditor;
        UseInSales: Serenity.BooleanEditor;
        UseInPurchase: Serenity.BooleanEditor;
        UseInProduction: Serenity.BooleanEditor;
    }

    [['ChargeType', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['Deduction', () => Serenity.BooleanEditor]
   , ['UseInSales', () => Serenity.BooleanEditor]
   , ['UseInPurchase', () => Serenity.BooleanEditor]
   , ['UseInProduction', () => Serenity.BooleanEditor]
].forEach(x => Object.defineProperty(ChargeTypeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

