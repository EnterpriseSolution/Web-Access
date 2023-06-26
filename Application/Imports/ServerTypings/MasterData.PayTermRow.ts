namespace Matrix.MasterData {
    export interface PayTermRow {
        Recnum?: number;
        PayTerms?: string;
        Description?: string;
        Suspended?: boolean;
        BaseDate?: string;
        DueDays?: number;
        DiscDays?: number;
        DiscPercent?: number;
        AdjustCrlimit?: string;
        MinDueDays?: number;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        Phase1PayTerms?: string;
        Phase1BaseDate?: string;
        Phase1DueDays?: number;
        Phase1PayPercent?: number;
        Phase2PayTerms?: string;
        Phase2BaseDate?: string;
        Phase2DueDays?: number;
        Phase2PayPercent?: number;
        Phase3PayTerms?: string;
        Phase3BaseDate?: string;
        Phase3DueDays?: number;
        Phase3PayPercent?: number;
        Phase4PayTerms?: string;
        Phase4BaseDate?: string;
        Phase4DueDays?: number;
        Phase4PayPercent?: number;
        Phase5PayTerms?: string;
        Phase5BaseDate?: string;
        Phase5DueDays?: number;
        Phase5PayPercent?: number;
    }

    export namespace PayTermRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'PayTerms';
        export const localTextPrefix = 'MasterData.PayTerm';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const PayTerms: string;
            export declare const Description: string;
            export declare const Suspended: string;
            export declare const BaseDate: string;
            export declare const DueDays: string;
            export declare const DiscDays: string;
            export declare const DiscPercent: string;
            export declare const AdjustCrlimit: string;
            export declare const MinDueDays: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const Phase1PayTerms: string;
            export declare const Phase1BaseDate: string;
            export declare const Phase1DueDays: string;
            export declare const Phase1PayPercent: string;
            export declare const Phase2PayTerms: string;
            export declare const Phase2BaseDate: string;
            export declare const Phase2DueDays: string;
            export declare const Phase2PayPercent: string;
            export declare const Phase3PayTerms: string;
            export declare const Phase3BaseDate: string;
            export declare const Phase3DueDays: string;
            export declare const Phase3PayPercent: string;
            export declare const Phase4PayTerms: string;
            export declare const Phase4BaseDate: string;
            export declare const Phase4DueDays: string;
            export declare const Phase4PayPercent: string;
            export declare const Phase5PayTerms: string;
            export declare const Phase5BaseDate: string;
            export declare const Phase5DueDays: string;
            export declare const Phase5PayPercent: string;
        }

        [
            'Recnum', 
            'PayTerms', 
            'Description', 
            'Suspended', 
            'BaseDate', 
            'DueDays', 
            'DiscDays', 
            'DiscPercent', 
            'AdjustCrlimit', 
            'MinDueDays', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch', 
            'Phase1PayTerms', 
            'Phase1BaseDate', 
            'Phase1DueDays', 
            'Phase1PayPercent', 
            'Phase2PayTerms', 
            'Phase2BaseDate', 
            'Phase2DueDays', 
            'Phase2PayPercent', 
            'Phase3PayTerms', 
            'Phase3BaseDate', 
            'Phase3DueDays', 
            'Phase3PayPercent', 
            'Phase4PayTerms', 
            'Phase4BaseDate', 
            'Phase4DueDays', 
            'Phase4PayPercent', 
            'Phase5PayTerms', 
            'Phase5BaseDate', 
            'Phase5DueDays', 
            'Phase5PayPercent'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

