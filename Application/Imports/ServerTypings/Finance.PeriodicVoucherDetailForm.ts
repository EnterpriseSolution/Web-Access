namespace Matrix.Finance {
    export class PeriodicVoucherDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Finance.PeriodicVoucherDetail';

    }

    export interface PeriodicVoucherDetailForm {
        EntryKey: Serenity.StringEditor;
        LineNo: Serenity.DecimalEditor;
        AcctNo: Serenity.StringEditor;
        AcctName: Serenity.StringEditor;
        BranchNo: Serenity.StringEditor;
        CostCentre: Serenity.StringEditor;
        Dept: Serenity.StringEditor;
        LineRef: Serenity.StringEditor;
        DebitAmt: Serenity.DecimalEditor;
        CreditAmt: Serenity.DecimalEditor;
        Anlys1: Serenity.StringEditor;
        Anlys2: Serenity.StringEditor;
        Anlys3: Serenity.StringEditor;
        Anlys4: Serenity.StringEditor;
        Anlys5: Serenity.StringEditor;
        Anlys6: Serenity.StringEditor;
        CreatedDate: Serenity.DateEditor;
        CreatedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        Particulars: Serenity.StringEditor;
        Anlys15: Serenity.StringEditor;
        Anlys16: Serenity.StringEditor;
        Anlys17: Serenity.StringEditor;
        Anlys18: Serenity.StringEditor;
        Anlys19: Serenity.StringEditor;
        Anlys20: Serenity.StringEditor;
    }

    [['EntryKey', () => Serenity.StringEditor]
   , ['LineNo', () => Serenity.DecimalEditor]
   , ['AcctNo', () => Serenity.StringEditor]
   , ['AcctName', () => Serenity.StringEditor]
   , ['BranchNo', () => Serenity.StringEditor]
   , ['CostCentre', () => Serenity.StringEditor]
   , ['Dept', () => Serenity.StringEditor]
   , ['LineRef', () => Serenity.StringEditor]
   , ['DebitAmt', () => Serenity.DecimalEditor]
   , ['CreditAmt', () => Serenity.DecimalEditor]
   , ['Anlys1', () => Serenity.StringEditor]
   , ['Anlys2', () => Serenity.StringEditor]
   , ['Anlys3', () => Serenity.StringEditor]
   , ['Anlys4', () => Serenity.StringEditor]
   , ['Anlys5', () => Serenity.StringEditor]
   , ['Anlys6', () => Serenity.StringEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['Particulars', () => Serenity.StringEditor]
   , ['Anlys15', () => Serenity.StringEditor]
   , ['Anlys16', () => Serenity.StringEditor]
   , ['Anlys17', () => Serenity.StringEditor]
   , ['Anlys18', () => Serenity.StringEditor]
   , ['Anlys19', () => Serenity.StringEditor]
   , ['Anlys20', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(PeriodicVoucherDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

