namespace Matrix.MasterData {
    export class VoucherTypeForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.VoucherType';

    }

    export interface VoucherTypeForm {
        VoucherType: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Suspended: Serenity.StringEditor;
        DirectEntry: Serenity.StringEditor;
        AllowEdit: Serenity.StringEditor;
        MultiCurrency: Serenity.StringEditor;
        BatchedPosting: Serenity.StringEditor;
        CostCtrOpt: Serenity.StringEditor;
        DeptOpt: Serenity.StringEditor;
        Anlys1Opt: Serenity.StringEditor;
        Anlys2Opt: Serenity.StringEditor;
        Anlys3DrOpt: Serenity.StringEditor;
        Anlys4DrOpt: Serenity.StringEditor;
        Anlys5DrOpt: Serenity.StringEditor;
        Anlys6DrOpt: Serenity.StringEditor;
        Anlys3CrOpt: Serenity.StringEditor;
        Anlys4CrOpt: Serenity.StringEditor;
        Anlys5CrOpt: Serenity.StringEditor;
        Anlys6CrOpt: Serenity.StringEditor;
        SeriesCode: Serenity.StringEditor;
        CreatedDate: Serenity.DateEditor;
        CreatedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        BatchCount: Serenity.DecimalEditor;
        OwnerBranch: Serenity.StringEditor;
        SourceBranch: Serenity.StringEditor;
        Remarks: Serenity.StringEditor;
        Anlys7Opt: Serenity.StringEditor;
        Anlys8Opt: Serenity.StringEditor;
        Anlys9Opt: Serenity.StringEditor;
        Anlys10Opt: Serenity.StringEditor;
        Anlys11Opt: Serenity.StringEditor;
        Anlys12Opt: Serenity.StringEditor;
        Anlys13Opt: Serenity.StringEditor;
        Anlys14Opt: Serenity.StringEditor;
        Anlys15DrOpt: Serenity.StringEditor;
        Anlys16DrOpt: Serenity.StringEditor;
        Anlys17DrOpt: Serenity.StringEditor;
        Anlys18DrOpt: Serenity.StringEditor;
        Anlys19DrOpt: Serenity.StringEditor;
        Anlys20DrOpt: Serenity.StringEditor;
        Anlys15CrOpt: Serenity.StringEditor;
        Anlys16CrOpt: Serenity.StringEditor;
        Anlys17CrOpt: Serenity.StringEditor;
        Anlys18CrOpt: Serenity.StringEditor;
        Anlys19CrOpt: Serenity.StringEditor;
        Anlys20CrOpt: Serenity.StringEditor;
    }

    [['VoucherType', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.StringEditor]
   , ['DirectEntry', () => Serenity.StringEditor]
   , ['AllowEdit', () => Serenity.StringEditor]
   , ['MultiCurrency', () => Serenity.StringEditor]
   , ['BatchedPosting', () => Serenity.StringEditor]
   , ['CostCtrOpt', () => Serenity.StringEditor]
   , ['DeptOpt', () => Serenity.StringEditor]
   , ['Anlys1Opt', () => Serenity.StringEditor]
   , ['Anlys2Opt', () => Serenity.StringEditor]
   , ['Anlys3DrOpt', () => Serenity.StringEditor]
   , ['Anlys4DrOpt', () => Serenity.StringEditor]
   , ['Anlys5DrOpt', () => Serenity.StringEditor]
   , ['Anlys6DrOpt', () => Serenity.StringEditor]
   , ['Anlys3CrOpt', () => Serenity.StringEditor]
   , ['Anlys4CrOpt', () => Serenity.StringEditor]
   , ['Anlys5CrOpt', () => Serenity.StringEditor]
   , ['Anlys6CrOpt', () => Serenity.StringEditor]
   , ['SeriesCode', () => Serenity.StringEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['BatchCount', () => Serenity.DecimalEditor]
   , ['OwnerBranch', () => Serenity.StringEditor]
   , ['SourceBranch', () => Serenity.StringEditor]
   , ['Remarks', () => Serenity.StringEditor]
   , ['Anlys7Opt', () => Serenity.StringEditor]
   , ['Anlys8Opt', () => Serenity.StringEditor]
   , ['Anlys9Opt', () => Serenity.StringEditor]
   , ['Anlys10Opt', () => Serenity.StringEditor]
   , ['Anlys11Opt', () => Serenity.StringEditor]
   , ['Anlys12Opt', () => Serenity.StringEditor]
   , ['Anlys13Opt', () => Serenity.StringEditor]
   , ['Anlys14Opt', () => Serenity.StringEditor]
   , ['Anlys15DrOpt', () => Serenity.StringEditor]
   , ['Anlys16DrOpt', () => Serenity.StringEditor]
   , ['Anlys17DrOpt', () => Serenity.StringEditor]
   , ['Anlys18DrOpt', () => Serenity.StringEditor]
   , ['Anlys19DrOpt', () => Serenity.StringEditor]
   , ['Anlys20DrOpt', () => Serenity.StringEditor]
   , ['Anlys15CrOpt', () => Serenity.StringEditor]
   , ['Anlys16CrOpt', () => Serenity.StringEditor]
   , ['Anlys17CrOpt', () => Serenity.StringEditor]
   , ['Anlys18CrOpt', () => Serenity.StringEditor]
   , ['Anlys19CrOpt', () => Serenity.StringEditor]
   , ['Anlys20CrOpt', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(VoucherTypeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

