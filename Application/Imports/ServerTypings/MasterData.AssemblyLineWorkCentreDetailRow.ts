namespace Matrix.MasterData {
    export interface AssemblyLineWorkCentreDetailRow {
        Recnum?: number;
        AssemblyLine?: string;
        SeqNo?: number;
        WorkCentre?: string;
        Description?: string;
        Alternate?: boolean;
        Suspended?: boolean;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        AssemblyLineRecnum?: number;
        AssemblyLineDescription?: string;
        AssemblyLineBranchNo?: string;
        AssemblyLineSuspended?: string;
        AssemblyLinePriority?: string;
        AssemblyLineEffcRating?: number;
        AssemblyLineRestrict0?: string;
        AssemblyLineRestrict1?: string;
        AssemblyLineRestrict2?: string;
        AssemblyLineRestrict3?: string;
        AssemblyLineRestrict4?: string;
        AssemblyLineRestrict5?: string;
        AssemblyLineRestrict6?: string;
        AssemblyLineRestrict7?: string;
        AssemblyLineRestrict8?: string;
        AssemblyLineRestrict9?: string;
        AssemblyLineRequire0?: string;
        AssemblyLineRequire1?: string;
        AssemblyLineRequire2?: string;
        AssemblyLineRequire3?: string;
        AssemblyLineRequire4?: string;
        AssemblyLineRequire5?: string;
        AssemblyLineRequire6?: string;
        AssemblyLineRequire7?: string;
        AssemblyLineRequire8?: string;
        AssemblyLineRequire9?: string;
        AssemblyLineAcctMachine?: string;
        AssemblyLineAcctEnergy?: string;
        AssemblyLineAcctWater?: string;
        AssemblyLineAcctRental?: string;
        AssemblyLineAcctLabor?: string;
        AssemblyLineAcctInlab?: string;
        AssemblyLineAcctInmat?: string;
        AssemblyLineAcctMisc?: string;
        AssemblyLineCreatedDate?: string;
        AssemblyLineCreatedBy?: string;
        AssemblyLineRevisedDate?: string;
        AssemblyLineRevisedBy?: string;
        AssemblyLineBrevisedDate?: string;
        AssemblyLineBrevisedBy?: string;
        AssemblyLineOwnerBranch?: string;
        AssemblyLineSourceBranch?: string;
        WorkCentreRecnum?: number;
        WorkCentreDescription?: string;
        WorkCentreSuspended?: string;
        WorkCentreCritical?: string;
        WorkCentreBranchNo?: string;
        WorkCentreNoOfPersons?: number;
        WorkCentreNoOfShifts?: number;
        WorkCentreFirstSetupHr?: number;
        WorkCentreFirstCleanHr?: number;
        WorkCentreOtherSetupHr?: number;
        WorkCentreOtherCleanHr?: number;
        WorkCentreQueueHr?: number;
        WorkCentreMachineUnit?: string;
        WorkCentreMachineCost?: number;
        WorkCentreEnergyUnit?: string;
        WorkCentreEnergyCost?: number;
        WorkCentreWaterUnit?: string;
        WorkCentreWaterCost?: number;
        WorkCentreRentalUnit?: string;
        WorkCentreRentalCost?: number;
        WorkCentreLaborUnit?: string;
        WorkCentreLaborCost?: number;
        WorkCentreInlabUnit?: string;
        WorkCentreInlabCost?: number;
        WorkCentreInmatUnit?: string;
        WorkCentreInmatCost?: number;
        WorkCentreMiscUnit?: string;
        WorkCentreMiscCost?: number;
        WorkCentreRestrict0?: string;
        WorkCentreRestrict1?: string;
        WorkCentreRestrict2?: string;
        WorkCentreRestrict3?: string;
        WorkCentreRestrict4?: string;
        WorkCentreRestrict5?: string;
        WorkCentreRestrict6?: string;
        WorkCentreRestrict7?: string;
        WorkCentreRestrict8?: string;
        WorkCentreRestrict9?: string;
        WorkCentreRequire0?: string;
        WorkCentreRequire1?: string;
        WorkCentreRequire2?: string;
        WorkCentreRequire3?: string;
        WorkCentreRequire4?: string;
        WorkCentreRequire5?: string;
        WorkCentreRequire6?: string;
        WorkCentreRequire7?: string;
        WorkCentreRequire8?: string;
        WorkCentreRequire9?: string;
        WorkCentreAcctMachine?: string;
        WorkCentreAcctEnergy?: string;
        WorkCentreAcctWater?: string;
        WorkCentreAcctRental?: string;
        WorkCentreAcctLabor?: string;
        WorkCentreAcctInlab?: string;
        WorkCentreAcctInmat?: string;
        WorkCentreAcctMisc?: string;
        WorkCentreCreatedDate?: string;
        WorkCentreCreatedBy?: string;
        WorkCentreRevisedDate?: string;
        WorkCentreRevisedBy?: string;
        WorkCentreBrevisedDate?: string;
        WorkCentreBrevisedBy?: string;
        WorkCentreOwnerBranch?: string;
        WorkCentreSourceBranch?: string;
        WorkCentreOperHrsBasis?: string;
        WorkCentreNoOfMachines?: number;
        WorkCentreCapacityUnit?: string;
    }

    export namespace AssemblyLineWorkCentreDetailRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'AssemblyLine';
        export const localTextPrefix = 'MasterData.AssemblyLineWorkCentreDetail';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const AssemblyLine: string;
            export declare const SeqNo: string;
            export declare const WorkCentre: string;
            export declare const Description: string;
            export declare const Alternate: string;
            export declare const Suspended: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const AssemblyLineRecnum: string;
            export declare const AssemblyLineDescription: string;
            export declare const AssemblyLineBranchNo: string;
            export declare const AssemblyLineSuspended: string;
            export declare const AssemblyLinePriority: string;
            export declare const AssemblyLineEffcRating: string;
            export declare const AssemblyLineRestrict0: string;
            export declare const AssemblyLineRestrict1: string;
            export declare const AssemblyLineRestrict2: string;
            export declare const AssemblyLineRestrict3: string;
            export declare const AssemblyLineRestrict4: string;
            export declare const AssemblyLineRestrict5: string;
            export declare const AssemblyLineRestrict6: string;
            export declare const AssemblyLineRestrict7: string;
            export declare const AssemblyLineRestrict8: string;
            export declare const AssemblyLineRestrict9: string;
            export declare const AssemblyLineRequire0: string;
            export declare const AssemblyLineRequire1: string;
            export declare const AssemblyLineRequire2: string;
            export declare const AssemblyLineRequire3: string;
            export declare const AssemblyLineRequire4: string;
            export declare const AssemblyLineRequire5: string;
            export declare const AssemblyLineRequire6: string;
            export declare const AssemblyLineRequire7: string;
            export declare const AssemblyLineRequire8: string;
            export declare const AssemblyLineRequire9: string;
            export declare const AssemblyLineAcctMachine: string;
            export declare const AssemblyLineAcctEnergy: string;
            export declare const AssemblyLineAcctWater: string;
            export declare const AssemblyLineAcctRental: string;
            export declare const AssemblyLineAcctLabor: string;
            export declare const AssemblyLineAcctInlab: string;
            export declare const AssemblyLineAcctInmat: string;
            export declare const AssemblyLineAcctMisc: string;
            export declare const AssemblyLineCreatedDate: string;
            export declare const AssemblyLineCreatedBy: string;
            export declare const AssemblyLineRevisedDate: string;
            export declare const AssemblyLineRevisedBy: string;
            export declare const AssemblyLineBrevisedDate: string;
            export declare const AssemblyLineBrevisedBy: string;
            export declare const AssemblyLineOwnerBranch: string;
            export declare const AssemblyLineSourceBranch: string;
            export declare const WorkCentreRecnum: string;
            export declare const WorkCentreDescription: string;
            export declare const WorkCentreSuspended: string;
            export declare const WorkCentreCritical: string;
            export declare const WorkCentreBranchNo: string;
            export declare const WorkCentreNoOfPersons: string;
            export declare const WorkCentreNoOfShifts: string;
            export declare const WorkCentreFirstSetupHr: string;
            export declare const WorkCentreFirstCleanHr: string;
            export declare const WorkCentreOtherSetupHr: string;
            export declare const WorkCentreOtherCleanHr: string;
            export declare const WorkCentreQueueHr: string;
            export declare const WorkCentreMachineUnit: string;
            export declare const WorkCentreMachineCost: string;
            export declare const WorkCentreEnergyUnit: string;
            export declare const WorkCentreEnergyCost: string;
            export declare const WorkCentreWaterUnit: string;
            export declare const WorkCentreWaterCost: string;
            export declare const WorkCentreRentalUnit: string;
            export declare const WorkCentreRentalCost: string;
            export declare const WorkCentreLaborUnit: string;
            export declare const WorkCentreLaborCost: string;
            export declare const WorkCentreInlabUnit: string;
            export declare const WorkCentreInlabCost: string;
            export declare const WorkCentreInmatUnit: string;
            export declare const WorkCentreInmatCost: string;
            export declare const WorkCentreMiscUnit: string;
            export declare const WorkCentreMiscCost: string;
            export declare const WorkCentreRestrict0: string;
            export declare const WorkCentreRestrict1: string;
            export declare const WorkCentreRestrict2: string;
            export declare const WorkCentreRestrict3: string;
            export declare const WorkCentreRestrict4: string;
            export declare const WorkCentreRestrict5: string;
            export declare const WorkCentreRestrict6: string;
            export declare const WorkCentreRestrict7: string;
            export declare const WorkCentreRestrict8: string;
            export declare const WorkCentreRestrict9: string;
            export declare const WorkCentreRequire0: string;
            export declare const WorkCentreRequire1: string;
            export declare const WorkCentreRequire2: string;
            export declare const WorkCentreRequire3: string;
            export declare const WorkCentreRequire4: string;
            export declare const WorkCentreRequire5: string;
            export declare const WorkCentreRequire6: string;
            export declare const WorkCentreRequire7: string;
            export declare const WorkCentreRequire8: string;
            export declare const WorkCentreRequire9: string;
            export declare const WorkCentreAcctMachine: string;
            export declare const WorkCentreAcctEnergy: string;
            export declare const WorkCentreAcctWater: string;
            export declare const WorkCentreAcctRental: string;
            export declare const WorkCentreAcctLabor: string;
            export declare const WorkCentreAcctInlab: string;
            export declare const WorkCentreAcctInmat: string;
            export declare const WorkCentreAcctMisc: string;
            export declare const WorkCentreCreatedDate: string;
            export declare const WorkCentreCreatedBy: string;
            export declare const WorkCentreRevisedDate: string;
            export declare const WorkCentreRevisedBy: string;
            export declare const WorkCentreBrevisedDate: string;
            export declare const WorkCentreBrevisedBy: string;
            export declare const WorkCentreOwnerBranch: string;
            export declare const WorkCentreSourceBranch: string;
            export declare const WorkCentreOperHrsBasis: string;
            export declare const WorkCentreNoOfMachines: string;
            export declare const WorkCentreCapacityUnit: string;
        }

        [
            'Recnum', 
            'AssemblyLine', 
            'SeqNo', 
            'WorkCentre', 
            'Description', 
            'Alternate', 
            'Suspended', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch', 
            'AssemblyLineRecnum', 
            'AssemblyLineDescription', 
            'AssemblyLineBranchNo', 
            'AssemblyLineSuspended', 
            'AssemblyLinePriority', 
            'AssemblyLineEffcRating', 
            'AssemblyLineRestrict0', 
            'AssemblyLineRestrict1', 
            'AssemblyLineRestrict2', 
            'AssemblyLineRestrict3', 
            'AssemblyLineRestrict4', 
            'AssemblyLineRestrict5', 
            'AssemblyLineRestrict6', 
            'AssemblyLineRestrict7', 
            'AssemblyLineRestrict8', 
            'AssemblyLineRestrict9', 
            'AssemblyLineRequire0', 
            'AssemblyLineRequire1', 
            'AssemblyLineRequire2', 
            'AssemblyLineRequire3', 
            'AssemblyLineRequire4', 
            'AssemblyLineRequire5', 
            'AssemblyLineRequire6', 
            'AssemblyLineRequire7', 
            'AssemblyLineRequire8', 
            'AssemblyLineRequire9', 
            'AssemblyLineAcctMachine', 
            'AssemblyLineAcctEnergy', 
            'AssemblyLineAcctWater', 
            'AssemblyLineAcctRental', 
            'AssemblyLineAcctLabor', 
            'AssemblyLineAcctInlab', 
            'AssemblyLineAcctInmat', 
            'AssemblyLineAcctMisc', 
            'AssemblyLineCreatedDate', 
            'AssemblyLineCreatedBy', 
            'AssemblyLineRevisedDate', 
            'AssemblyLineRevisedBy', 
            'AssemblyLineBrevisedDate', 
            'AssemblyLineBrevisedBy', 
            'AssemblyLineOwnerBranch', 
            'AssemblyLineSourceBranch', 
            'WorkCentreRecnum', 
            'WorkCentreDescription', 
            'WorkCentreSuspended', 
            'WorkCentreCritical', 
            'WorkCentreBranchNo', 
            'WorkCentreNoOfPersons', 
            'WorkCentreNoOfShifts', 
            'WorkCentreFirstSetupHr', 
            'WorkCentreFirstCleanHr', 
            'WorkCentreOtherSetupHr', 
            'WorkCentreOtherCleanHr', 
            'WorkCentreQueueHr', 
            'WorkCentreMachineUnit', 
            'WorkCentreMachineCost', 
            'WorkCentreEnergyUnit', 
            'WorkCentreEnergyCost', 
            'WorkCentreWaterUnit', 
            'WorkCentreWaterCost', 
            'WorkCentreRentalUnit', 
            'WorkCentreRentalCost', 
            'WorkCentreLaborUnit', 
            'WorkCentreLaborCost', 
            'WorkCentreInlabUnit', 
            'WorkCentreInlabCost', 
            'WorkCentreInmatUnit', 
            'WorkCentreInmatCost', 
            'WorkCentreMiscUnit', 
            'WorkCentreMiscCost', 
            'WorkCentreRestrict0', 
            'WorkCentreRestrict1', 
            'WorkCentreRestrict2', 
            'WorkCentreRestrict3', 
            'WorkCentreRestrict4', 
            'WorkCentreRestrict5', 
            'WorkCentreRestrict6', 
            'WorkCentreRestrict7', 
            'WorkCentreRestrict8', 
            'WorkCentreRestrict9', 
            'WorkCentreRequire0', 
            'WorkCentreRequire1', 
            'WorkCentreRequire2', 
            'WorkCentreRequire3', 
            'WorkCentreRequire4', 
            'WorkCentreRequire5', 
            'WorkCentreRequire6', 
            'WorkCentreRequire7', 
            'WorkCentreRequire8', 
            'WorkCentreRequire9', 
            'WorkCentreAcctMachine', 
            'WorkCentreAcctEnergy', 
            'WorkCentreAcctWater', 
            'WorkCentreAcctRental', 
            'WorkCentreAcctLabor', 
            'WorkCentreAcctInlab', 
            'WorkCentreAcctInmat', 
            'WorkCentreAcctMisc', 
            'WorkCentreCreatedDate', 
            'WorkCentreCreatedBy', 
            'WorkCentreRevisedDate', 
            'WorkCentreRevisedBy', 
            'WorkCentreBrevisedDate', 
            'WorkCentreBrevisedBy', 
            'WorkCentreOwnerBranch', 
            'WorkCentreSourceBranch', 
            'WorkCentreOperHrsBasis', 
            'WorkCentreNoOfMachines', 
            'WorkCentreCapacityUnit'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

