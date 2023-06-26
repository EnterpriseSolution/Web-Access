namespace Matrix.MasterData {
    export class FiscalPeriodForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.FiscalPeriod';

    }

    export interface FiscalPeriodForm {
        FiscalYear: Serenity.DecimalEditor;
        PeriodNo: Serenity.DecimalEditor;
        Period: Serenity.StringEditor;
        StartDate: Serenity.DateEditor;
        EndDate: Serenity.DateEditor;
        AllowEntries: Serenity.StringEditor;
        ClosedSl: Serenity.StringEditor;
        ClosedPu: Serenity.StringEditor;
        ClosedPr: Serenity.StringEditor;
        ClosedIc: Serenity.StringEditor;
        ClosedAr: Serenity.StringEditor;
        ClosedAp: Serenity.StringEditor;
        ClosedGl: Serenity.StringEditor;
        CreatedDate: Serenity.DateEditor;
        CreatedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        ClosedDate: Serenity.DateEditor;
        ClosedBy: Serenity.StringEditor;
        BalBeg: Serenity.DecimalEditor;
        BalBegSign: Serenity.StringEditor;
        TotalDebit: Serenity.DecimalEditor;
        TotalCredit: Serenity.DecimalEditor;
        BalEnd: Serenity.DecimalEditor;
        BalEndSign: Serenity.StringEditor;
        ArBalBeg: Serenity.DecimalEditor;
        ArInvoAmt: Serenity.DecimalEditor;
        ArMemoAmt: Serenity.DecimalEditor;
        ArAdjAmt: Serenity.DecimalEditor;
        ArPayAmt: Serenity.DecimalEditor;
        ArBalEnd: Serenity.DecimalEditor;
        ApBalBeg: Serenity.DecimalEditor;
        ApInvoAmt: Serenity.DecimalEditor;
        ApMemoAmt: Serenity.DecimalEditor;
        ApAdjAmt: Serenity.DecimalEditor;
        ApPayAmt: Serenity.DecimalEditor;
        ApBalEnd: Serenity.DecimalEditor;
        ActiveGl: Serenity.StringEditor;
        ActiveAp: Serenity.StringEditor;
        ActiveAr: Serenity.StringEditor;
        ActiveIc: Serenity.StringEditor;
        ActivePr: Serenity.StringEditor;
        OwnerBranch: Serenity.StringEditor;
        SourceBranch: Serenity.StringEditor;
        ArDiscAmt: Serenity.DecimalEditor;
        ArDiffAmt: Serenity.DecimalEditor;
        ApDiscAmt: Serenity.DecimalEditor;
        ApDiffAmt: Serenity.DecimalEditor;
        ApRfdAmt: Serenity.DecimalEditor;
        ArRfdAmt: Serenity.DecimalEditor;
    }

    [['FiscalYear', () => Serenity.DecimalEditor]
   , ['PeriodNo', () => Serenity.DecimalEditor]
   , ['Period', () => Serenity.StringEditor]
   , ['StartDate', () => Serenity.DateEditor]
   , ['EndDate', () => Serenity.DateEditor]
   , ['AllowEntries', () => Serenity.StringEditor]
   , ['ClosedSl', () => Serenity.StringEditor]
   , ['ClosedPu', () => Serenity.StringEditor]
   , ['ClosedPr', () => Serenity.StringEditor]
   , ['ClosedIc', () => Serenity.StringEditor]
   , ['ClosedAr', () => Serenity.StringEditor]
   , ['ClosedAp', () => Serenity.StringEditor]
   , ['ClosedGl', () => Serenity.StringEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['ClosedDate', () => Serenity.DateEditor]
   , ['ClosedBy', () => Serenity.StringEditor]
   , ['BalBeg', () => Serenity.DecimalEditor]
   , ['BalBegSign', () => Serenity.StringEditor]
   , ['TotalDebit', () => Serenity.DecimalEditor]
   , ['TotalCredit', () => Serenity.DecimalEditor]
   , ['BalEnd', () => Serenity.DecimalEditor]
   , ['BalEndSign', () => Serenity.StringEditor]
   , ['ArBalBeg', () => Serenity.DecimalEditor]
   , ['ArInvoAmt', () => Serenity.DecimalEditor]
   , ['ArMemoAmt', () => Serenity.DecimalEditor]
   , ['ArAdjAmt', () => Serenity.DecimalEditor]
   , ['ArPayAmt', () => Serenity.DecimalEditor]
   , ['ArBalEnd', () => Serenity.DecimalEditor]
   , ['ApBalBeg', () => Serenity.DecimalEditor]
   , ['ApInvoAmt', () => Serenity.DecimalEditor]
   , ['ApMemoAmt', () => Serenity.DecimalEditor]
   , ['ApAdjAmt', () => Serenity.DecimalEditor]
   , ['ApPayAmt', () => Serenity.DecimalEditor]
   , ['ApBalEnd', () => Serenity.DecimalEditor]
   , ['ActiveGl', () => Serenity.StringEditor]
   , ['ActiveAp', () => Serenity.StringEditor]
   , ['ActiveAr', () => Serenity.StringEditor]
   , ['ActiveIc', () => Serenity.StringEditor]
   , ['ActivePr', () => Serenity.StringEditor]
   , ['OwnerBranch', () => Serenity.StringEditor]
   , ['SourceBranch', () => Serenity.StringEditor]
   , ['ArDiscAmt', () => Serenity.DecimalEditor]
   , ['ArDiffAmt', () => Serenity.DecimalEditor]
   , ['ApDiscAmt', () => Serenity.DecimalEditor]
   , ['ApDiffAmt', () => Serenity.DecimalEditor]
   , ['ApRfdAmt', () => Serenity.DecimalEditor]
   , ['ArRfdAmt', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(FiscalPeriodForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

