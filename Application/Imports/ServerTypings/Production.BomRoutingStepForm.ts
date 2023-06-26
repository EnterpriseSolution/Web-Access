namespace Matrix.Production {
    export class BomRoutingStepForm extends Serenity.PrefixedContext {
        static formKey = 'Production.BomRoutingStep';

    }

    export interface BomRoutingStepForm {
        BomNo: Serenity.StringEditor;
        SeqNo: Serenity.DecimalEditor;
        OpCode: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Ticketed: Serenity.StringEditor;
        Reported: Serenity.StringEditor;
        ProdnMode: Serenity.StringEditor;
        WorkCentre: Serenity.StringEditor;
        FixedWcentre: Serenity.StringEditor;
        NoOfWorkers: Serenity.DecimalEditor;
        PieceRate: Serenity.DecimalEditor;
        SubconVendor: Serenity.StringEditor;
        SubconRate: Serenity.DecimalEditor;
        FixedVendor: Serenity.StringEditor;
        MachLoadHr: Serenity.DecimalEditor;
        ManLoadHr: Serenity.DecimalEditor;
        MachProcessHr: Serenity.DecimalEditor;
        ManProcessHr: Serenity.DecimalEditor;
        MachUnloadHr: Serenity.DecimalEditor;
        ManUnloadHr: Serenity.DecimalEditor;
        MachineCost: Serenity.DecimalEditor;
        EnergyCost: Serenity.DecimalEditor;
        WaterCost: Serenity.DecimalEditor;
        RentalCost: Serenity.DecimalEditor;
        LaborCost: Serenity.DecimalEditor;
        InlabCost: Serenity.DecimalEditor;
        InmatCost: Serenity.DecimalEditor;
        MiscCost: Serenity.DecimalEditor;
        CreatedDate: Serenity.DateEditor;
        CreatedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        OwnerBranch: Serenity.StringEditor;
        SourceBranch: Serenity.StringEditor;
        Specifications: Serenity.StringEditor;
        DependTo: Serenity.DecimalEditor;
        Dependency: Serenity.StringEditor;
        LagHour: Serenity.DecimalEditor;
        MachineNo: Serenity.StringEditor;
        MoldNo: Serenity.StringEditor;
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
    }

    [['BomNo', () => Serenity.StringEditor]
   , ['SeqNo', () => Serenity.DecimalEditor]
   , ['OpCode', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Ticketed', () => Serenity.StringEditor]
   , ['Reported', () => Serenity.StringEditor]
   , ['ProdnMode', () => Serenity.StringEditor]
   , ['WorkCentre', () => Serenity.StringEditor]
   , ['FixedWcentre', () => Serenity.StringEditor]
   , ['NoOfWorkers', () => Serenity.DecimalEditor]
   , ['PieceRate', () => Serenity.DecimalEditor]
   , ['SubconVendor', () => Serenity.StringEditor]
   , ['SubconRate', () => Serenity.DecimalEditor]
   , ['FixedVendor', () => Serenity.StringEditor]
   , ['MachLoadHr', () => Serenity.DecimalEditor]
   , ['ManLoadHr', () => Serenity.DecimalEditor]
   , ['MachProcessHr', () => Serenity.DecimalEditor]
   , ['ManProcessHr', () => Serenity.DecimalEditor]
   , ['MachUnloadHr', () => Serenity.DecimalEditor]
   , ['ManUnloadHr', () => Serenity.DecimalEditor]
   , ['MachineCost', () => Serenity.DecimalEditor]
   , ['EnergyCost', () => Serenity.DecimalEditor]
   , ['WaterCost', () => Serenity.DecimalEditor]
   , ['RentalCost', () => Serenity.DecimalEditor]
   , ['LaborCost', () => Serenity.DecimalEditor]
   , ['InlabCost', () => Serenity.DecimalEditor]
   , ['InmatCost', () => Serenity.DecimalEditor]
   , ['MiscCost', () => Serenity.DecimalEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['OwnerBranch', () => Serenity.StringEditor]
   , ['SourceBranch', () => Serenity.StringEditor]
   , ['Specifications', () => Serenity.StringEditor]
   , ['DependTo', () => Serenity.DecimalEditor]
   , ['Dependency', () => Serenity.StringEditor]
   , ['LagHour', () => Serenity.DecimalEditor]
   , ['MachineNo', () => Serenity.StringEditor]
   , ['MoldNo', () => Serenity.StringEditor]
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
].forEach(x => Object.defineProperty(BomRoutingStepForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

