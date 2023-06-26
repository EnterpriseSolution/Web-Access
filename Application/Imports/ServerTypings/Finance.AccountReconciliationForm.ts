namespace Matrix.Finance {
    export class AccountReconciliationForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.AccountReconciliation';

    }

    export interface AccountReconciliationForm {
        AcctNo: Serenity.StringEditor;
        RefNo: Serenity.StringEditor;
        Posted: Serenity.StringEditor;
        AcctName: Serenity.StringEditor;
        TranDate: Serenity.DateEditor;
        BeginAmt: Serenity.DecimalEditor;
        BeginSign: Serenity.StringEditor;
        TotalDebit: Serenity.DecimalEditor;
        TotalCredit: Serenity.DecimalEditor;
        AllocDebit: Serenity.DecimalEditor;
        AllocCredit: Serenity.DecimalEditor;
        AdjustDebit: Serenity.DecimalEditor;
        AdjustCredit: Serenity.DecimalEditor;
        EndAmt: Serenity.DecimalEditor;
        EndSign: Serenity.StringEditor;
        EndAllocAmt: Serenity.DecimalEditor;
        EndAllocSign: Serenity.StringEditor;
        DetailCount: Serenity.DecimalEditor;
        CreatedDate: Serenity.DateEditor;
        CreatedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        OwnerBranch: Serenity.StringEditor;
        SourceBranch: Serenity.StringEditor;
        CutoffDate: Serenity.DateEditor;
        PostedDate: Serenity.DateEditor;
        PostedBy: Serenity.StringEditor;
    }

    [['AcctNo', () => Serenity.StringEditor]
   , ['RefNo', () => Serenity.StringEditor]
   , ['Posted', () => Serenity.StringEditor]
   , ['AcctName', () => Serenity.StringEditor]
   , ['TranDate', () => Serenity.DateEditor]
   , ['BeginAmt', () => Serenity.DecimalEditor]
   , ['BeginSign', () => Serenity.StringEditor]
   , ['TotalDebit', () => Serenity.DecimalEditor]
   , ['TotalCredit', () => Serenity.DecimalEditor]
   , ['AllocDebit', () => Serenity.DecimalEditor]
   , ['AllocCredit', () => Serenity.DecimalEditor]
   , ['AdjustDebit', () => Serenity.DecimalEditor]
   , ['AdjustCredit', () => Serenity.DecimalEditor]
   , ['EndAmt', () => Serenity.DecimalEditor]
   , ['EndSign', () => Serenity.StringEditor]
   , ['EndAllocAmt', () => Serenity.DecimalEditor]
   , ['EndAllocSign', () => Serenity.StringEditor]
   , ['DetailCount', () => Serenity.DecimalEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['OwnerBranch', () => Serenity.StringEditor]
   , ['SourceBranch', () => Serenity.StringEditor]
   , ['CutoffDate', () => Serenity.DateEditor]
   , ['PostedDate', () => Serenity.DateEditor]
   , ['PostedBy', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(AccountReconciliationForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

