namespace Matrix.MasterData {
    export interface WorkCentreRow {
        Recnum?: number;
        WorkCentre?: string;
        Description?: string;
        Suspended?: boolean;
        Critical?: boolean;
        BranchNo?: string;
        NoOfPersons?: number;
        NoOfShifts?: number;
        FirstSetupHr?: number;
        FirstCleanHr?: number;
        OtherSetupHr?: number;
        OtherCleanHr?: number;
        QueueHr?: number;
        MachineUnit?: string;
        MachineCost?: number;
        EnergyUnit?: string;
        EnergyCost?: number;
        WaterUnit?: string;
        WaterCost?: number;
        RentalUnit?: string;
        RentalCost?: number;
        LaborUnit?: string;
        LaborCost?: number;
        InlabUnit?: string;
        InlabCost?: number;
        InmatUnit?: string;
        InmatCost?: number;
        MiscUnit?: string;
        MiscCost?: number;
        Restrict0?: string;
        Restrict1?: string;
        Restrict2?: string;
        Restrict3?: string;
        Restrict4?: string;
        Restrict5?: string;
        Restrict6?: string;
        Restrict7?: string;
        Restrict8?: string;
        Restrict9?: string;
        Require0?: string;
        Require1?: string;
        Require2?: string;
        Require3?: string;
        Require4?: string;
        Require5?: string;
        Require6?: string;
        Require7?: string;
        Require8?: string;
        Require9?: string;
        AcctMachine?: string;
        AcctEnergy?: string;
        AcctWater?: string;
        AcctRental?: string;
        AcctLabor?: string;
        AcctInlab?: string;
        AcctInmat?: string;
        AcctMisc?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        BrevisedDate?: string;
        BrevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        OperHrsBasis?: string;
        NoOfMachines?: number;
        CapacityUnit?: string;
    }

    export namespace WorkCentreRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'WorkCentre';
        export const localTextPrefix = 'MasterData.WorkCentre';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const WorkCentre: string;
            export declare const Description: string;
            export declare const Suspended: string;
            export declare const Critical: string;
            export declare const BranchNo: string;
            export declare const NoOfPersons: string;
            export declare const NoOfShifts: string;
            export declare const FirstSetupHr: string;
            export declare const FirstCleanHr: string;
            export declare const OtherSetupHr: string;
            export declare const OtherCleanHr: string;
            export declare const QueueHr: string;
            export declare const MachineUnit: string;
            export declare const MachineCost: string;
            export declare const EnergyUnit: string;
            export declare const EnergyCost: string;
            export declare const WaterUnit: string;
            export declare const WaterCost: string;
            export declare const RentalUnit: string;
            export declare const RentalCost: string;
            export declare const LaborUnit: string;
            export declare const LaborCost: string;
            export declare const InlabUnit: string;
            export declare const InlabCost: string;
            export declare const InmatUnit: string;
            export declare const InmatCost: string;
            export declare const MiscUnit: string;
            export declare const MiscCost: string;
            export declare const Restrict0: string;
            export declare const Restrict1: string;
            export declare const Restrict2: string;
            export declare const Restrict3: string;
            export declare const Restrict4: string;
            export declare const Restrict5: string;
            export declare const Restrict6: string;
            export declare const Restrict7: string;
            export declare const Restrict8: string;
            export declare const Restrict9: string;
            export declare const Require0: string;
            export declare const Require1: string;
            export declare const Require2: string;
            export declare const Require3: string;
            export declare const Require4: string;
            export declare const Require5: string;
            export declare const Require6: string;
            export declare const Require7: string;
            export declare const Require8: string;
            export declare const Require9: string;
            export declare const AcctMachine: string;
            export declare const AcctEnergy: string;
            export declare const AcctWater: string;
            export declare const AcctRental: string;
            export declare const AcctLabor: string;
            export declare const AcctInlab: string;
            export declare const AcctInmat: string;
            export declare const AcctMisc: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const BrevisedDate: string;
            export declare const BrevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const OperHrsBasis: string;
            export declare const NoOfMachines: string;
            export declare const CapacityUnit: string;
        }

        [
            'Recnum', 
            'WorkCentre', 
            'Description', 
            'Suspended', 
            'Critical', 
            'BranchNo', 
            'NoOfPersons', 
            'NoOfShifts', 
            'FirstSetupHr', 
            'FirstCleanHr', 
            'OtherSetupHr', 
            'OtherCleanHr', 
            'QueueHr', 
            'MachineUnit', 
            'MachineCost', 
            'EnergyUnit', 
            'EnergyCost', 
            'WaterUnit', 
            'WaterCost', 
            'RentalUnit', 
            'RentalCost', 
            'LaborUnit', 
            'LaborCost', 
            'InlabUnit', 
            'InlabCost', 
            'InmatUnit', 
            'InmatCost', 
            'MiscUnit', 
            'MiscCost', 
            'Restrict0', 
            'Restrict1', 
            'Restrict2', 
            'Restrict3', 
            'Restrict4', 
            'Restrict5', 
            'Restrict6', 
            'Restrict7', 
            'Restrict8', 
            'Restrict9', 
            'Require0', 
            'Require1', 
            'Require2', 
            'Require3', 
            'Require4', 
            'Require5', 
            'Require6', 
            'Require7', 
            'Require8', 
            'Require9', 
            'AcctMachine', 
            'AcctEnergy', 
            'AcctWater', 
            'AcctRental', 
            'AcctLabor', 
            'AcctInlab', 
            'AcctInmat', 
            'AcctMisc', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'BrevisedDate', 
            'BrevisedBy', 
            'OwnerBranch', 
            'SourceBranch', 
            'OperHrsBasis', 
            'NoOfMachines', 
            'CapacityUnit'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

