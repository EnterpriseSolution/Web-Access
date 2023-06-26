namespace Matrix.MasterData {
    export class FundCodeForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.FundCode';

    }

    export interface FundCodeForm {
        FundCode: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        DefaultCcy: Serenity.StringEditor;
        AcctCash: Serenity.StringEditor;
        RcptSuspended: Serenity.BooleanEditor;
        PmntSuspended: Serenity.BooleanEditor;
        FixedCurrency: Serenity.BooleanEditor;
        IsBankAcct: Serenity.BooleanEditor;
        IsCurrAcct: Serenity.BooleanEditor;
        BankAcctNo: Serenity.StringEditor;
        NextChequeNo: Serenity.DecimalEditor;
    }

    [['FundCode', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['DefaultCcy', () => Serenity.StringEditor]
   , ['AcctCash', () => Serenity.StringEditor]
   , ['RcptSuspended', () => Serenity.BooleanEditor]
   , ['PmntSuspended', () => Serenity.BooleanEditor]
   , ['FixedCurrency', () => Serenity.BooleanEditor]
   , ['IsBankAcct', () => Serenity.BooleanEditor]
   , ['IsCurrAcct', () => Serenity.BooleanEditor]
   , ['BankAcctNo', () => Serenity.StringEditor]
   , ['NextChequeNo', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(FundCodeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

