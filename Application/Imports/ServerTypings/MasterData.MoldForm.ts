namespace Matrix.MasterData {
    export class MoldForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Mold';

    }

    export interface MoldForm {
        MoldNo: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        TotalSet: Serenity.IntegerEditor;
        StdOutput: Serenity.IntegerEditor;
        Suspended: Serenity.StringEditor;
        Length: Serenity.DecimalEditor;
        Width: Serenity.DecimalEditor;
        Thickness: Serenity.DecimalEditor;
        Weight: Serenity.DecimalEditor;
        SetWeight: Serenity.DecimalEditor;
        Shrink: Serenity.DecimalEditor;
        ShotSize: Serenity.DecimalEditor;
        CavityFinish: Serenity.StringEditor;
        TempCtrlZone: Serenity.DecimalEditor;
        WtrFlowA: Serenity.DecimalEditor;
        WtrFlowB: Serenity.DecimalEditor;
        Qmc: Serenity.StringEditor;
        HyCores: Serenity.StringEditor;
        MoldCost: Serenity.DecimalEditor;
        EjectorRtn: Serenity.StringEditor;
        Remarks: Serenity.StringEditor;
        PictureFile: Serenity.StringEditor;
        CavSets: Serenity.IntegerEditor;
        CavSqInch: Serenity.IntegerEditor;
        RevisedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        CreatedDate: Serenity.DateEditor;
        CreatedBy: Serenity.StringEditor;
        LifeTime: Serenity.DecimalEditor;
        JobQty: Serenity.DecimalEditor;
        FinQty: Serenity.DecimalEditor;
        BalQty: Serenity.DecimalEditor;
        RepQty: Serenity.DecimalEditor;
    }

    [['MoldNo', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['TotalSet', () => Serenity.IntegerEditor]
   , ['StdOutput', () => Serenity.IntegerEditor]
   , ['Suspended', () => Serenity.StringEditor]
   , ['Length', () => Serenity.DecimalEditor]
   , ['Width', () => Serenity.DecimalEditor]
   , ['Thickness', () => Serenity.DecimalEditor]
   , ['Weight', () => Serenity.DecimalEditor]
   , ['SetWeight', () => Serenity.DecimalEditor]
   , ['Shrink', () => Serenity.DecimalEditor]
   , ['ShotSize', () => Serenity.DecimalEditor]
   , ['CavityFinish', () => Serenity.StringEditor]
   , ['TempCtrlZone', () => Serenity.DecimalEditor]
   , ['WtrFlowA', () => Serenity.DecimalEditor]
   , ['WtrFlowB', () => Serenity.DecimalEditor]
   , ['Qmc', () => Serenity.StringEditor]
   , ['HyCores', () => Serenity.StringEditor]
   , ['MoldCost', () => Serenity.DecimalEditor]
   , ['EjectorRtn', () => Serenity.StringEditor]
   , ['Remarks', () => Serenity.StringEditor]
   , ['PictureFile', () => Serenity.StringEditor]
   , ['CavSets', () => Serenity.IntegerEditor]
   , ['CavSqInch', () => Serenity.IntegerEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['LifeTime', () => Serenity.DecimalEditor]
   , ['JobQty', () => Serenity.DecimalEditor]
   , ['FinQty', () => Serenity.DecimalEditor]
   , ['BalQty', () => Serenity.DecimalEditor]
   , ['RepQty', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(MoldForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

