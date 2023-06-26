namespace Matrix.MasterData {
    export class WorkCentreForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.WorkCentre';

    }

    export interface WorkCentreForm {
        WorkCentre: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        Critical: Serenity.BooleanEditor;
        NoOfPersons: Serenity.DecimalEditor;
        NoOfShifts: Serenity.DecimalEditor;
        FirstSetupHr: Serenity.DecimalEditor;
        FirstCleanHr: Serenity.DecimalEditor;
        OtherSetupHr: Serenity.DecimalEditor;
        OtherCleanHr: Serenity.DecimalEditor;
        QueueHr: Serenity.DecimalEditor;
        OperHrsBasis: Serenity.StringEditor;
        NoOfMachines: Serenity.DecimalEditor;
        CapacityUnit: Serenity.StringEditor;
        MachineUnit: Serenity.StringEditor;
        MachineCost: Serenity.DecimalEditor;
        EnergyUnit: Serenity.StringEditor;
        EnergyCost: Serenity.DecimalEditor;
        WaterUnit: Serenity.StringEditor;
        WaterCost: Serenity.DecimalEditor;
        RentalUnit: Serenity.StringEditor;
        RentalCost: Serenity.DecimalEditor;
        LaborUnit: Serenity.StringEditor;
        LaborCost: Serenity.DecimalEditor;
        InlabUnit: Serenity.StringEditor;
        InlabCost: Serenity.DecimalEditor;
        InmatUnit: Serenity.StringEditor;
        InmatCost: Serenity.DecimalEditor;
        MiscUnit: Serenity.StringEditor;
        MiscCost: Serenity.DecimalEditor;
        Restrict0: Serenity.StringEditor;
        Restrict1: Serenity.StringEditor;
        Restrict2: Serenity.StringEditor;
        Restrict3: Serenity.StringEditor;
        Restrict4: Serenity.StringEditor;
        Restrict5: Serenity.StringEditor;
        Restrict6: Serenity.StringEditor;
        Restrict7: Serenity.StringEditor;
        Restrict8: Serenity.StringEditor;
        Restrict9: Serenity.StringEditor;
        Require0: Serenity.StringEditor;
        Require1: Serenity.StringEditor;
        Require2: Serenity.StringEditor;
        Require3: Serenity.StringEditor;
        Require4: Serenity.StringEditor;
        Require5: Serenity.StringEditor;
        Require6: Serenity.StringEditor;
        Require7: Serenity.StringEditor;
        Require8: Serenity.StringEditor;
        Require9: Serenity.StringEditor;
        AcctMachine: Serenity.StringEditor;
        AcctEnergy: Serenity.StringEditor;
        AcctWater: Serenity.StringEditor;
        AcctRental: Serenity.StringEditor;
        AcctLabor: Serenity.StringEditor;
        AcctInlab: Serenity.StringEditor;
        AcctInmat: Serenity.StringEditor;
        AcctMisc: Serenity.StringEditor;
    }

    [['WorkCentre', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['Critical', () => Serenity.BooleanEditor]
   , ['NoOfPersons', () => Serenity.DecimalEditor]
   , ['NoOfShifts', () => Serenity.DecimalEditor]
   , ['FirstSetupHr', () => Serenity.DecimalEditor]
   , ['FirstCleanHr', () => Serenity.DecimalEditor]
   , ['OtherSetupHr', () => Serenity.DecimalEditor]
   , ['OtherCleanHr', () => Serenity.DecimalEditor]
   , ['QueueHr', () => Serenity.DecimalEditor]
   , ['OperHrsBasis', () => Serenity.StringEditor]
   , ['NoOfMachines', () => Serenity.DecimalEditor]
   , ['CapacityUnit', () => Serenity.StringEditor]
   , ['MachineUnit', () => Serenity.StringEditor]
   , ['MachineCost', () => Serenity.DecimalEditor]
   , ['EnergyUnit', () => Serenity.StringEditor]
   , ['EnergyCost', () => Serenity.DecimalEditor]
   , ['WaterUnit', () => Serenity.StringEditor]
   , ['WaterCost', () => Serenity.DecimalEditor]
   , ['RentalUnit', () => Serenity.StringEditor]
   , ['RentalCost', () => Serenity.DecimalEditor]
   , ['LaborUnit', () => Serenity.StringEditor]
   , ['LaborCost', () => Serenity.DecimalEditor]
   , ['InlabUnit', () => Serenity.StringEditor]
   , ['InlabCost', () => Serenity.DecimalEditor]
   , ['InmatUnit', () => Serenity.StringEditor]
   , ['InmatCost', () => Serenity.DecimalEditor]
   , ['MiscUnit', () => Serenity.StringEditor]
   , ['MiscCost', () => Serenity.DecimalEditor]
   , ['Restrict0', () => Serenity.StringEditor]
   , ['Restrict1', () => Serenity.StringEditor]
   , ['Restrict2', () => Serenity.StringEditor]
   , ['Restrict3', () => Serenity.StringEditor]
   , ['Restrict4', () => Serenity.StringEditor]
   , ['Restrict5', () => Serenity.StringEditor]
   , ['Restrict6', () => Serenity.StringEditor]
   , ['Restrict7', () => Serenity.StringEditor]
   , ['Restrict8', () => Serenity.StringEditor]
   , ['Restrict9', () => Serenity.StringEditor]
   , ['Require0', () => Serenity.StringEditor]
   , ['Require1', () => Serenity.StringEditor]
   , ['Require2', () => Serenity.StringEditor]
   , ['Require3', () => Serenity.StringEditor]
   , ['Require4', () => Serenity.StringEditor]
   , ['Require5', () => Serenity.StringEditor]
   , ['Require6', () => Serenity.StringEditor]
   , ['Require7', () => Serenity.StringEditor]
   , ['Require8', () => Serenity.StringEditor]
   , ['Require9', () => Serenity.StringEditor]
   , ['AcctMachine', () => Serenity.StringEditor]
   , ['AcctEnergy', () => Serenity.StringEditor]
   , ['AcctWater', () => Serenity.StringEditor]
   , ['AcctRental', () => Serenity.StringEditor]
   , ['AcctLabor', () => Serenity.StringEditor]
   , ['AcctInlab', () => Serenity.StringEditor]
   , ['AcctInmat', () => Serenity.StringEditor]
   , ['AcctMisc', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(WorkCentreForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

