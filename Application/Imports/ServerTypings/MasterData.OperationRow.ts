namespace Matrix.MasterData {
    export interface OperationRow {
        Recnum?: number;
        OpCode?: string;
        Description?: string;
        Suspended?: boolean;
        TicketIssued?: boolean;
        ReportRequired?: boolean;
        OperType?: string;
        ProdnMode?: string;
        WorkCentre?: string;
        FixedWctr?: boolean;
        MinLotSize?: number;
        StdLotSize?: number;
        DirectLabor?: number;
        MachLoadHr?: number;
        ManLoadHr?: number;
        MachProcessHr?: number;
        ManProcessHr?: number;
        MachUnloadHr?: number;
        ManUnloadHr?: number;
        MachineCost?: number;
        EnergyCost?: number;
        WaterCost?: number;
        RentalCost?: number;
        LaborCost?: number;
        InlabCost?: number;
        InmatCost?: number;
        MiscCost?: number;
        SubconCost?: number;
        SubconVendor?: string;
        PieceRate?: number;
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
        Specifications?: string;
    }

    export namespace OperationRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'OpCode';
        export const localTextPrefix = 'MasterData.Operation';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const OpCode: string;
            export declare const Description: string;
            export declare const Suspended: string;
            export declare const TicketIssued: string;
            export declare const ReportRequired: string;
            export declare const OperType: string;
            export declare const ProdnMode: string;
            export declare const WorkCentre: string;
            export declare const FixedWctr: string;
            export declare const MinLotSize: string;
            export declare const StdLotSize: string;
            export declare const DirectLabor: string;
            export declare const MachLoadHr: string;
            export declare const ManLoadHr: string;
            export declare const MachProcessHr: string;
            export declare const ManProcessHr: string;
            export declare const MachUnloadHr: string;
            export declare const ManUnloadHr: string;
            export declare const MachineCost: string;
            export declare const EnergyCost: string;
            export declare const WaterCost: string;
            export declare const RentalCost: string;
            export declare const LaborCost: string;
            export declare const InlabCost: string;
            export declare const InmatCost: string;
            export declare const MiscCost: string;
            export declare const SubconCost: string;
            export declare const SubconVendor: string;
            export declare const PieceRate: string;
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
            export declare const Specifications: string;
        }

        [
            'Recnum', 
            'OpCode', 
            'Description', 
            'Suspended', 
            'TicketIssued', 
            'ReportRequired', 
            'OperType', 
            'ProdnMode', 
            'WorkCentre', 
            'FixedWctr', 
            'MinLotSize', 
            'StdLotSize', 
            'DirectLabor', 
            'MachLoadHr', 
            'ManLoadHr', 
            'MachProcessHr', 
            'ManProcessHr', 
            'MachUnloadHr', 
            'ManUnloadHr', 
            'MachineCost', 
            'EnergyCost', 
            'WaterCost', 
            'RentalCost', 
            'LaborCost', 
            'InlabCost', 
            'InmatCost', 
            'MiscCost', 
            'SubconCost', 
            'SubconVendor', 
            'PieceRate', 
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
            'Specifications'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

