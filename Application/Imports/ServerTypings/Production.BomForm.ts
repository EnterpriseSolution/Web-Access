namespace Matrix.Production {
    export class BomForm extends Serenity.PrefixedContext {
        static formKey = 'Production.Bom';

    }

    export interface BomForm {
        BomNo: Serenity.StringEditor;
        Suspended: Serenity.StringEditor;
        AssmItemNo: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Uom: Serenity.StringEditor;
        StdOutput: Serenity.DecimalEditor;
        EffectFrom: Serenity.DateEditor;
        EffectTo: Serenity.DateEditor;
        PartsVerified: Serenity.StringEditor;
        ProcVerified: Serenity.StringEditor;
        EcnRequired: Serenity.StringEditor;
        BranchNo: Serenity.StringEditor;
        AssemblyLine: Serenity.StringEditor;
        FixedAsmLine: Serenity.StringEditor;
        WorkEstBasis: Serenity.StringEditor;
        StdLotSize: Serenity.DecimalEditor;
        MinLotSize: Serenity.DecimalEditor;
        MaxLotSize: Serenity.DecimalEditor;
        ScrapRate: Serenity.DecimalEditor;
        LastLineNo: Serenity.DecimalEditor;
        LastLogNo: Serenity.DecimalEditor;
        PartsCount: Serenity.DecimalEditor;
        RouteCount: Serenity.DecimalEditor;
        ByproCount: Serenity.DecimalEditor;
        ByproShare: Serenity.DecimalEditor;
        MnproShare: Serenity.DecimalEditor;
        CreatedDate: Serenity.DateEditor;
        CreatedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        LockType: Serenity.StringEditor;
        LockRefNo: Serenity.StringEditor;
        OwnerBranch: Serenity.StringEditor;
        SourceBranch: Serenity.StringEditor;
        LastEcnNo: Serenity.StringEditor;
        MassCngId: Serenity.StringEditor;
        AllowChgJob: Serenity.StringEditor;
        NetWt: Serenity.DecimalEditor;
        NetWtUom: Serenity.StringEditor;
        BomRevision: Serenity.StringEditor;
        Flag: Serenity.StringEditor;
        HoldBy: Serenity.StringEditor;
        LastPartsSeqNo: Serenity.DecimalEditor;
        IsApproved: Serenity.StringEditor;
        ApprovedBy: Serenity.StringEditor;
        Preapprove: Serenity.StringEditor;
        ApprovedDate: Serenity.DateEditor;
        Remarks: Serenity.StringEditor;
        IssueRunnerWaste: Serenity.StringEditor;
        RunnerWasteWt: Serenity.DecimalEditor;
        RunnerWasteUom: Serenity.StringEditor;
        UserDefinedField1: Serenity.StringEditor;
        UserDefinedField2: Serenity.StringEditor;
        UserDefinedField3: Serenity.StringEditor;
        UserDefinedField4: Serenity.StringEditor;
        UserDefinedField5: Serenity.StringEditor;
        UserDefinedField6: Serenity.StringEditor;
        UserDefinedField7: Serenity.StringEditor;
        UserDefinedField8: Serenity.StringEditor;
        UserDefinedField9: Serenity.StringEditor;
        UserDefinedField10: Serenity.StringEditor;
        UserDefinedField11: Serenity.StringEditor;
        UserDefinedField12: Serenity.StringEditor;
        UserDefinedField13: Serenity.StringEditor;
        UserDefinedField14: Serenity.StringEditor;
        UserDefinedField15: Serenity.StringEditor;
        UserDefinedField16: Serenity.StringEditor;
        UserDefinedField17: Serenity.StringEditor;
        UserDefinedField18: Serenity.StringEditor;
        UserDefinedField19: Serenity.StringEditor;
        UserDefinedField20: Serenity.StringEditor;
        AllowRohsMatOnly: Serenity.BooleanEditor;
        IssueExtraRunnerWaste: Serenity.BooleanEditor;
        Phantom: Serenity.BooleanEditor;
        DieCutter: Serenity.DecimalEditor;
    }

    [['BomNo', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.StringEditor]
   , ['AssmItemNo', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Uom', () => Serenity.StringEditor]
   , ['StdOutput', () => Serenity.DecimalEditor]
   , ['EffectFrom', () => Serenity.DateEditor]
   , ['EffectTo', () => Serenity.DateEditor]
   , ['PartsVerified', () => Serenity.StringEditor]
   , ['ProcVerified', () => Serenity.StringEditor]
   , ['EcnRequired', () => Serenity.StringEditor]
   , ['BranchNo', () => Serenity.StringEditor]
   , ['AssemblyLine', () => Serenity.StringEditor]
   , ['FixedAsmLine', () => Serenity.StringEditor]
   , ['WorkEstBasis', () => Serenity.StringEditor]
   , ['StdLotSize', () => Serenity.DecimalEditor]
   , ['MinLotSize', () => Serenity.DecimalEditor]
   , ['MaxLotSize', () => Serenity.DecimalEditor]
   , ['ScrapRate', () => Serenity.DecimalEditor]
   , ['LastLineNo', () => Serenity.DecimalEditor]
   , ['LastLogNo', () => Serenity.DecimalEditor]
   , ['PartsCount', () => Serenity.DecimalEditor]
   , ['RouteCount', () => Serenity.DecimalEditor]
   , ['ByproCount', () => Serenity.DecimalEditor]
   , ['ByproShare', () => Serenity.DecimalEditor]
   , ['MnproShare', () => Serenity.DecimalEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['LockType', () => Serenity.StringEditor]
   , ['LockRefNo', () => Serenity.StringEditor]
   , ['OwnerBranch', () => Serenity.StringEditor]
   , ['SourceBranch', () => Serenity.StringEditor]
   , ['LastEcnNo', () => Serenity.StringEditor]
   , ['MassCngId', () => Serenity.StringEditor]
   , ['AllowChgJob', () => Serenity.StringEditor]
   , ['NetWt', () => Serenity.DecimalEditor]
   , ['NetWtUom', () => Serenity.StringEditor]
   , ['BomRevision', () => Serenity.StringEditor]
   , ['Flag', () => Serenity.StringEditor]
   , ['HoldBy', () => Serenity.StringEditor]
   , ['LastPartsSeqNo', () => Serenity.DecimalEditor]
   , ['IsApproved', () => Serenity.StringEditor]
   , ['ApprovedBy', () => Serenity.StringEditor]
   , ['Preapprove', () => Serenity.StringEditor]
   , ['ApprovedDate', () => Serenity.DateEditor]
   , ['Remarks', () => Serenity.StringEditor]
   , ['IssueRunnerWaste', () => Serenity.StringEditor]
   , ['RunnerWasteWt', () => Serenity.DecimalEditor]
   , ['RunnerWasteUom', () => Serenity.StringEditor]
   , ['UserDefinedField1', () => Serenity.StringEditor]
   , ['UserDefinedField2', () => Serenity.StringEditor]
   , ['UserDefinedField3', () => Serenity.StringEditor]
   , ['UserDefinedField4', () => Serenity.StringEditor]
   , ['UserDefinedField5', () => Serenity.StringEditor]
   , ['UserDefinedField6', () => Serenity.StringEditor]
   , ['UserDefinedField7', () => Serenity.StringEditor]
   , ['UserDefinedField8', () => Serenity.StringEditor]
   , ['UserDefinedField9', () => Serenity.StringEditor]
   , ['UserDefinedField10', () => Serenity.StringEditor]
   , ['UserDefinedField11', () => Serenity.StringEditor]
   , ['UserDefinedField12', () => Serenity.StringEditor]
   , ['UserDefinedField13', () => Serenity.StringEditor]
   , ['UserDefinedField14', () => Serenity.StringEditor]
   , ['UserDefinedField15', () => Serenity.StringEditor]
   , ['UserDefinedField16', () => Serenity.StringEditor]
   , ['UserDefinedField17', () => Serenity.StringEditor]
   , ['UserDefinedField18', () => Serenity.StringEditor]
   , ['UserDefinedField19', () => Serenity.StringEditor]
   , ['UserDefinedField20', () => Serenity.StringEditor]
   , ['AllowRohsMatOnly', () => Serenity.BooleanEditor]
   , ['IssueExtraRunnerWaste', () => Serenity.BooleanEditor]
   , ['Phantom', () => Serenity.BooleanEditor]
   , ['DieCutter', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(BomForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

