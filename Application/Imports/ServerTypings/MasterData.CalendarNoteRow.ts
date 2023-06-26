namespace Matrix.MasterData {
    export interface CalendarNoteRow {
        Recnum?: number;
        TranDate?: string;
        EntryNo?: number;
        EntryBy?: string;
        EntryDate?: string;
        EntryType?: string;
        Subject?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        Notes?: string;
    }

    export namespace CalendarNoteRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'EntryBy';
        export const localTextPrefix = 'MasterData.CalendarNote';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const TranDate: string;
            export declare const EntryNo: string;
            export declare const EntryBy: string;
            export declare const EntryDate: string;
            export declare const EntryType: string;
            export declare const Subject: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const Notes: string;
        }

        [
            'Recnum', 
            'TranDate', 
            'EntryNo', 
            'EntryBy', 
            'EntryDate', 
            'EntryType', 
            'Subject', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch', 
            'Notes'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

