namespace Matrix.MasterData {
    export class BalanceSheetLayoutForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.BalanceSheetLayout';

    }

    export interface BalanceSheetLayoutForm {
        LineNo: Serenity.DecimalEditor;
        LineType: Serenity.StringEditor;
        LineSkip: Serenity.DecimalEditor;
        Description: Serenity.StringEditor;
        AcctFrom: Serenity.StringEditor;
        AcctTo: Serenity.StringEditor;
        AcctOperator: Serenity.StringEditor;
        TotalLevel: Serenity.DecimalEditor;
        NormalSign: Serenity.StringEditor;
    }

    [['LineNo', () => Serenity.DecimalEditor]
   , ['LineType', () => Serenity.StringEditor]
   , ['LineSkip', () => Serenity.DecimalEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['AcctFrom', () => Serenity.StringEditor]
   , ['AcctTo', () => Serenity.StringEditor]
   , ['AcctOperator', () => Serenity.StringEditor]
   , ['TotalLevel', () => Serenity.DecimalEditor]
   , ['NormalSign', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(BalanceSheetLayoutForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

