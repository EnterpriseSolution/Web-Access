namespace Matrix.Production {
    export class JobOrderRoutingStepForm extends Serenity.PrefixedContext {
        static formKey = 'Production.JobOrderRoutingStep';

    }

    export interface JobOrderRoutingStepForm {
        JobNo: Serenity.StringEditor;
        StepNo: Serenity.DecimalEditor;
        OpCode: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        ProdnMode: Serenity.StringEditor;
        Ticketed: Serenity.StringEditor;
        Reported: Serenity.StringEditor;
        WorkCentre: Serenity.StringEditor;
        HrsPerLot: Serenity.DecimalEditor;
        PieceRate: Serenity.DecimalEditor;
        SubVendorNo: Serenity.StringEditor;
        SubContractNo: Serenity.StringEditor;
        SubIssueDate: Serenity.DateEditor;
        SubDueDate: Serenity.DateEditor;
        SubLotRate: Serenity.DecimalEditor;
        CostMachine: Serenity.DecimalEditor;
        CostEnergy: Serenity.DecimalEditor;
        CostWater: Serenity.DecimalEditor;
        CostRental: Serenity.DecimalEditor;
        CostLabor: Serenity.DecimalEditor;
        CostInlab: Serenity.DecimalEditor;
        CostInmat: Serenity.DecimalEditor;
        CostMisc: Serenity.DecimalEditor;
        CostSubcon: Serenity.DecimalEditor;
        CostMachCpd: Serenity.DecimalEditor;
        CostEnergyCpd: Serenity.DecimalEditor;
        CostWaterCpd: Serenity.DecimalEditor;
        CostRentalCpd: Serenity.DecimalEditor;
        CostLaborCpd: Serenity.DecimalEditor;
        CostInlabCpd: Serenity.DecimalEditor;
        CostInmatCpd: Serenity.DecimalEditor;
        CostMiscCpd: Serenity.DecimalEditor;
        CostSubCpd: Serenity.DecimalEditor;
        AcctMachine: Serenity.StringEditor;
        AcctEnergy: Serenity.StringEditor;
        AcctWater: Serenity.StringEditor;
        AcctRental: Serenity.StringEditor;
        AcctLabor: Serenity.StringEditor;
        AcctInlab: Serenity.StringEditor;
        AcctInmat: Serenity.StringEditor;
        AcctMisc: Serenity.StringEditor;
        Specifications: Serenity.StringEditor;
        Eod: Serenity.DateEditor;
        Edd: Serenity.DateEditor;
        Anlys1: Serenity.StringEditor;
        Anlys2: Serenity.StringEditor;
        HrsPerLot1: Serenity.DecimalEditor;
        TotalManHrs: Serenity.DecimalEditor;
        TotalMachHrs: Serenity.DecimalEditor;
        Anlys18: Serenity.StringEditor;
        Anlys19: Serenity.StringEditor;
        Anlys20: Serenity.StringEditor;
    }

    [['JobNo', () => Serenity.StringEditor]
   , ['StepNo', () => Serenity.DecimalEditor]
   , ['OpCode', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['ProdnMode', () => Serenity.StringEditor]
   , ['Ticketed', () => Serenity.StringEditor]
   , ['Reported', () => Serenity.StringEditor]
   , ['WorkCentre', () => Serenity.StringEditor]
   , ['HrsPerLot', () => Serenity.DecimalEditor]
   , ['PieceRate', () => Serenity.DecimalEditor]
   , ['SubVendorNo', () => Serenity.StringEditor]
   , ['SubContractNo', () => Serenity.StringEditor]
   , ['SubIssueDate', () => Serenity.DateEditor]
   , ['SubDueDate', () => Serenity.DateEditor]
   , ['SubLotRate', () => Serenity.DecimalEditor]
   , ['CostMachine', () => Serenity.DecimalEditor]
   , ['CostEnergy', () => Serenity.DecimalEditor]
   , ['CostWater', () => Serenity.DecimalEditor]
   , ['CostRental', () => Serenity.DecimalEditor]
   , ['CostLabor', () => Serenity.DecimalEditor]
   , ['CostInlab', () => Serenity.DecimalEditor]
   , ['CostInmat', () => Serenity.DecimalEditor]
   , ['CostMisc', () => Serenity.DecimalEditor]
   , ['CostSubcon', () => Serenity.DecimalEditor]
   , ['CostMachCpd', () => Serenity.DecimalEditor]
   , ['CostEnergyCpd', () => Serenity.DecimalEditor]
   , ['CostWaterCpd', () => Serenity.DecimalEditor]
   , ['CostRentalCpd', () => Serenity.DecimalEditor]
   , ['CostLaborCpd', () => Serenity.DecimalEditor]
   , ['CostInlabCpd', () => Serenity.DecimalEditor]
   , ['CostInmatCpd', () => Serenity.DecimalEditor]
   , ['CostMiscCpd', () => Serenity.DecimalEditor]
   , ['CostSubCpd', () => Serenity.DecimalEditor]
   , ['AcctMachine', () => Serenity.StringEditor]
   , ['AcctEnergy', () => Serenity.StringEditor]
   , ['AcctWater', () => Serenity.StringEditor]
   , ['AcctRental', () => Serenity.StringEditor]
   , ['AcctLabor', () => Serenity.StringEditor]
   , ['AcctInlab', () => Serenity.StringEditor]
   , ['AcctInmat', () => Serenity.StringEditor]
   , ['AcctMisc', () => Serenity.StringEditor]
   , ['Specifications', () => Serenity.StringEditor]
   , ['Eod', () => Serenity.DateEditor]
   , ['Edd', () => Serenity.DateEditor]
   , ['Anlys1', () => Serenity.StringEditor]
   , ['Anlys2', () => Serenity.StringEditor]
   , ['HrsPerLot1', () => Serenity.DecimalEditor]
   , ['TotalManHrs', () => Serenity.DecimalEditor]
   , ['TotalMachHrs', () => Serenity.DecimalEditor]
   , ['Anlys18', () => Serenity.StringEditor]
   , ['Anlys19', () => Serenity.StringEditor]
   , ['Anlys20', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(JobOrderRoutingStepForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

