namespace Matrix.MasterData {
    export interface CalendarRow {
        Recnum?: number;
        TranMonth?: string;
        TranYear?: number;
        MonthNo?: number;
        CreatedDate?: string;
        CreatedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
    }

    export namespace CalendarRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'TranMonth';
        export const localTextPrefix = 'MasterData.Calendar';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const TranMonth: string;
            export declare const TranYear: string;
            export declare const MonthNo: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
        }

        [
            'Recnum', 
            'TranMonth', 
            'TranYear', 
            'MonthNo', 
            'CreatedDate', 
            'CreatedBy', 
            'OwnerBranch', 
            'SourceBranch'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

