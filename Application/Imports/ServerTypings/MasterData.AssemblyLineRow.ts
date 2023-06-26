namespace Matrix.MasterData {
    export interface AssemblyLineRow {
        DetailList?: AssemblyLineWorkCentreDetailRow[];
        Recnum?: number;
        AssemblyLine?: string;
        Description?: string;
        BranchNo?: string;
        Suspended?: boolean;
        Priority?: string;
        EffcRating?: number;
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
    }

    export namespace AssemblyLineRow {
        export const idProperty = 'AssemblyLine';
        export const nameProperty = 'Description';
        export const localTextPrefix = 'MasterData.AssemblyLine';

        export namespace Fields {
            export declare const DetailList: string;
            export declare const Recnum: string;
            export declare const AssemblyLine: string;
            export declare const Description: string;
            export declare const BranchNo: string;
            export declare const Suspended: string;
            export declare const Priority: string;
            export declare const EffcRating: string;
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
        }

        [
            'DetailList', 
            'Recnum', 
            'AssemblyLine', 
            'Description', 
            'BranchNo', 
            'Suspended', 
            'Priority', 
            'EffcRating', 
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
            'SourceBranch'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

