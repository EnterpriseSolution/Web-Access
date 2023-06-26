namespace Matrix.MasterData {
    export interface SalesmanRow {
        Recnum?: number;
        Salesman?: string;
        SalesmanName?: string;
        Suspended?: boolean;
        Rank?: number;
        EmpNo?: string;
        Supervisor?: string;
        WithBacklog?: string;
        OnOrderCount?: number;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
    }

    export namespace SalesmanRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'Salesman';
        export const localTextPrefix = 'MasterData.Salesman';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const Salesman: string;
            export declare const SalesmanName: string;
            export declare const Suspended: string;
            export declare const Rank: string;
            export declare const EmpNo: string;
            export declare const Supervisor: string;
            export declare const WithBacklog: string;
            export declare const OnOrderCount: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
        }

        [
            'Recnum', 
            'Salesman', 
            'SalesmanName', 
            'Suspended', 
            'Rank', 
            'EmpNo', 
            'Supervisor', 
            'WithBacklog', 
            'OnOrderCount', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

