namespace Matrix.MasterData {
    export interface CalendarDetailRow {
        Recnum?: number;
        TranMonth?: string;
        TranDate?: string;
        TranDay?: string;
        DayNum?: number;
        IsHoliday?: string;
        HalfDayOnly?: string;
        FirstShift?: string;
        SecondShift?: string;
        ThirdShift?: string;
        CanReceive?: string;
        CanShip?: string;
        DayName?: string;
        LastEntryNo?: number;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        TranMonthRecnum?: number;
        TranMonthTranYear?: number;
        TranMonthMonthNo?: number;
        TranMonthCreatedDate?: string;
        TranMonthCreatedBy?: string;
        TranMonthOwnerBranch?: string;
        TranMonthSourceBranch?: string;
    }

    export namespace CalendarDetailRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'TranMonth';
        export const localTextPrefix = 'MasterData.CalendarDetail';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const TranMonth: string;
            export declare const TranDate: string;
            export declare const TranDay: string;
            export declare const DayNum: string;
            export declare const IsHoliday: string;
            export declare const HalfDayOnly: string;
            export declare const FirstShift: string;
            export declare const SecondShift: string;
            export declare const ThirdShift: string;
            export declare const CanReceive: string;
            export declare const CanShip: string;
            export declare const DayName: string;
            export declare const LastEntryNo: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const TranMonthRecnum: string;
            export declare const TranMonthTranYear: string;
            export declare const TranMonthMonthNo: string;
            export declare const TranMonthCreatedDate: string;
            export declare const TranMonthCreatedBy: string;
            export declare const TranMonthOwnerBranch: string;
            export declare const TranMonthSourceBranch: string;
        }

        [
            'Recnum', 
            'TranMonth', 
            'TranDate', 
            'TranDay', 
            'DayNum', 
            'IsHoliday', 
            'HalfDayOnly', 
            'FirstShift', 
            'SecondShift', 
            'ThirdShift', 
            'CanReceive', 
            'CanShip', 
            'DayName', 
            'LastEntryNo', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch', 
            'TranMonthRecnum', 
            'TranMonthTranYear', 
            'TranMonthMonthNo', 
            'TranMonthCreatedDate', 
            'TranMonthCreatedBy', 
            'TranMonthOwnerBranch', 
            'TranMonthSourceBranch'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

