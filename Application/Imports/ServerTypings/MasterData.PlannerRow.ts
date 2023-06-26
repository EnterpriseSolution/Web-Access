namespace Matrix.MasterData {
    export interface PlannerRow {
        Recnum?: number;
        Planner?: string;
        Name?: string;
        Suspended?: boolean;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        Userid?: string;
    }

    export namespace PlannerRow {
        export const idProperty = 'Planner';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'MasterData.Planner';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const Planner: string;
            export declare const Name: string;
            export declare const Suspended: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const Userid: string;
        }

        [
            'Recnum', 
            'Planner', 
            'Name', 
            'Suspended', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch', 
            'Userid'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

