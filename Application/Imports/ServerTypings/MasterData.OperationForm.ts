namespace Matrix.MasterData {
    export class OperationForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Operation';

    }

    export interface OperationForm {
        OpCode: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        TicketIssued: Serenity.BooleanEditor;
        ReportRequired: Serenity.BooleanEditor;
        OperType: Serenity.StringEditor;
        ProdnMode: Serenity.StringEditor;
        WorkCentre: Serenity.StringEditor;
        FixedWctr: Serenity.StringEditor;
        MinLotSize: Serenity.DecimalEditor;
        StdLotSize: Serenity.DecimalEditor;
        DirectLabor: Serenity.DecimalEditor;
        SubconVendor: Serenity.StringEditor;
        PieceRate: Serenity.DecimalEditor;
        Specifications: Serenity.TextAreaEditor;
        ManLoadHr: Serenity.DecimalEditor;
        ManProcessHr: Serenity.DecimalEditor;
        ManUnloadHr: Serenity.DecimalEditor;
        MachLoadHr: Serenity.DecimalEditor;
        MachProcessHr: Serenity.DecimalEditor;
        MachUnloadHr: Serenity.DecimalEditor;
        AcctMachine: Serenity.StringEditor;
        AcctEnergy: Serenity.StringEditor;
        AcctWater: Serenity.StringEditor;
        AcctRental: Serenity.StringEditor;
        AcctLabor: Serenity.StringEditor;
        AcctInlab: Serenity.StringEditor;
        AcctInmat: Serenity.StringEditor;
        AcctMisc: Serenity.StringEditor;
        MachineCost: Serenity.DecimalEditor;
        EnergyCost: Serenity.DecimalEditor;
        WaterCost: Serenity.DecimalEditor;
        RentalCost: Serenity.DecimalEditor;
        LaborCost: Serenity.DecimalEditor;
        InlabCost: Serenity.DecimalEditor;
        InmatCost: Serenity.DecimalEditor;
        MiscCost: Serenity.DecimalEditor;
        SubconCost: Serenity.DecimalEditor;
    }

    [['OpCode', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['TicketIssued', () => Serenity.BooleanEditor]
   , ['ReportRequired', () => Serenity.BooleanEditor]
   , ['OperType', () => Serenity.StringEditor]
   , ['ProdnMode', () => Serenity.StringEditor]
   , ['WorkCentre', () => Serenity.StringEditor]
   , ['FixedWctr', () => Serenity.StringEditor]
   , ['MinLotSize', () => Serenity.DecimalEditor]
   , ['StdLotSize', () => Serenity.DecimalEditor]
   , ['DirectLabor', () => Serenity.DecimalEditor]
   , ['SubconVendor', () => Serenity.StringEditor]
   , ['PieceRate', () => Serenity.DecimalEditor]
   , ['Specifications', () => Serenity.TextAreaEditor]
   , ['ManLoadHr', () => Serenity.DecimalEditor]
   , ['ManProcessHr', () => Serenity.DecimalEditor]
   , ['ManUnloadHr', () => Serenity.DecimalEditor]
   , ['MachLoadHr', () => Serenity.DecimalEditor]
   , ['MachProcessHr', () => Serenity.DecimalEditor]
   , ['MachUnloadHr', () => Serenity.DecimalEditor]
   , ['AcctMachine', () => Serenity.StringEditor]
   , ['AcctEnergy', () => Serenity.StringEditor]
   , ['AcctWater', () => Serenity.StringEditor]
   , ['AcctRental', () => Serenity.StringEditor]
   , ['AcctLabor', () => Serenity.StringEditor]
   , ['AcctInlab', () => Serenity.StringEditor]
   , ['AcctInmat', () => Serenity.StringEditor]
   , ['AcctMisc', () => Serenity.StringEditor]
   , ['MachineCost', () => Serenity.DecimalEditor]
   , ['EnergyCost', () => Serenity.DecimalEditor]
   , ['WaterCost', () => Serenity.DecimalEditor]
   , ['RentalCost', () => Serenity.DecimalEditor]
   , ['LaborCost', () => Serenity.DecimalEditor]
   , ['InlabCost', () => Serenity.DecimalEditor]
   , ['InmatCost', () => Serenity.DecimalEditor]
   , ['MiscCost', () => Serenity.DecimalEditor]
   , ['SubconCost', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(OperationForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

