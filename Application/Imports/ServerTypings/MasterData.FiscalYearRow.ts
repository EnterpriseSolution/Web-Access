namespace Matrix.MasterData {
    export interface FiscalYearRow {
        Recnum?: number;
        FiscalYear?: number;
        AllowEntries?: string;
        Closed?: string;
        LastPeriod?: number;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        ClosedDate?: string;
        ClosedBy?: string;
        YtdPlCredit?: number;
        YtdPlDebit?: number;
        YtdPlNet?: number;
        OwnerBranch?: string;
        SourceBranch?: string;
        FiscalYearName?: string;
    }

    export namespace FiscalYearRow {
        export const idProperty = 'FiscalYear';
        export const nameProperty = 'FiscalYearName';
        export const localTextPrefix = 'MasterData.FiscalYear';
        export const lookupKey = 'MasterData.FiscalYearRow';

        export function getLookup(): Q.Lookup<FiscalYearRow> {
            return Q.getLookup<FiscalYearRow>('MasterData.FiscalYearRow');
        }

        export namespace Fields {
            export declare const Recnum: string;
            export declare const FiscalYear: string;
            export declare const AllowEntries: string;
            export declare const Closed: string;
            export declare const LastPeriod: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const ClosedDate: string;
            export declare const ClosedBy: string;
            export declare const YtdPlCredit: string;
            export declare const YtdPlDebit: string;
            export declare const YtdPlNet: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const FiscalYearName: string;
        }

        [
            'Recnum', 
            'FiscalYear', 
            'AllowEntries', 
            'Closed', 
            'LastPeriod', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'ClosedDate', 
            'ClosedBy', 
            'YtdPlCredit', 
            'YtdPlDebit', 
            'YtdPlNet', 
            'OwnerBranch', 
            'SourceBranch', 
            'FiscalYearName'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

