namespace Matrix.MasterData {
    export interface FiscalPeriodRow {
        Recnum?: number;
        FiscalYear?: number;
        PeriodNo?: number;
        Period?: string;
        StartDate?: string;
        EndDate?: string;
        AllowEntries?: boolean;
        ClosedSl?: boolean;
        ClosedPu?: boolean;
        ClosedPr?: boolean;
        ClosedIc?: boolean;
        ClosedAr?: boolean;
        ClosedAp?: boolean;
        ClosedGl?: boolean;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        ClosedDate?: string;
        ClosedBy?: string;
        BalBeg?: number;
        BalBegSign?: string;
        TotalDebit?: number;
        TotalCredit?: number;
        BalEnd?: number;
        BalEndSign?: string;
        ArBalBeg?: number;
        ArInvoAmt?: number;
        ArMemoAmt?: number;
        ArAdjAmt?: number;
        ArPayAmt?: number;
        ArBalEnd?: number;
        ApBalBeg?: number;
        ApInvoAmt?: number;
        ApMemoAmt?: number;
        ApAdjAmt?: number;
        ApPayAmt?: number;
        ApBalEnd?: number;
        ActiveGl?: string;
        ActiveAp?: string;
        ActiveAr?: string;
        ActiveIc?: string;
        ActivePr?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        ArDiscAmt?: number;
        ArDiffAmt?: number;
        ApDiscAmt?: number;
        ApDiffAmt?: number;
        ApRfdAmt?: number;
        ArRfdAmt?: number;
        FiscalYearRecnum?: number;
        FiscalYearAllowEntries?: string;
        FiscalYearClosed?: string;
        FiscalYearLastPeriod?: number;
        FiscalYearCreatedDate?: string;
        FiscalYearCreatedBy?: string;
        FiscalYearRevisedDate?: string;
        FiscalYearRevisedBy?: string;
        FiscalYearClosedDate?: string;
        FiscalYearClosedBy?: string;
        FiscalYearYtdPlCredit?: number;
        FiscalYearYtdPlDebit?: number;
        FiscalYearYtdPlNet?: number;
        FiscalYearOwnerBranch?: string;
        FiscalYearSourceBranch?: string;
    }

    export namespace FiscalPeriodRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'Period';
        export const localTextPrefix = 'MasterData.FiscalPeriod';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const FiscalYear: string;
            export declare const PeriodNo: string;
            export declare const Period: string;
            export declare const StartDate: string;
            export declare const EndDate: string;
            export declare const AllowEntries: string;
            export declare const ClosedSl: string;
            export declare const ClosedPu: string;
            export declare const ClosedPr: string;
            export declare const ClosedIc: string;
            export declare const ClosedAr: string;
            export declare const ClosedAp: string;
            export declare const ClosedGl: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const ClosedDate: string;
            export declare const ClosedBy: string;
            export declare const BalBeg: string;
            export declare const BalBegSign: string;
            export declare const TotalDebit: string;
            export declare const TotalCredit: string;
            export declare const BalEnd: string;
            export declare const BalEndSign: string;
            export declare const ArBalBeg: string;
            export declare const ArInvoAmt: string;
            export declare const ArMemoAmt: string;
            export declare const ArAdjAmt: string;
            export declare const ArPayAmt: string;
            export declare const ArBalEnd: string;
            export declare const ApBalBeg: string;
            export declare const ApInvoAmt: string;
            export declare const ApMemoAmt: string;
            export declare const ApAdjAmt: string;
            export declare const ApPayAmt: string;
            export declare const ApBalEnd: string;
            export declare const ActiveGl: string;
            export declare const ActiveAp: string;
            export declare const ActiveAr: string;
            export declare const ActiveIc: string;
            export declare const ActivePr: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const ArDiscAmt: string;
            export declare const ArDiffAmt: string;
            export declare const ApDiscAmt: string;
            export declare const ApDiffAmt: string;
            export declare const ApRfdAmt: string;
            export declare const ArRfdAmt: string;
            export declare const FiscalYearRecnum: string;
            export declare const FiscalYearAllowEntries: string;
            export declare const FiscalYearClosed: string;
            export declare const FiscalYearLastPeriod: string;
            export declare const FiscalYearCreatedDate: string;
            export declare const FiscalYearCreatedBy: string;
            export declare const FiscalYearRevisedDate: string;
            export declare const FiscalYearRevisedBy: string;
            export declare const FiscalYearClosedDate: string;
            export declare const FiscalYearClosedBy: string;
            export declare const FiscalYearYtdPlCredit: string;
            export declare const FiscalYearYtdPlDebit: string;
            export declare const FiscalYearYtdPlNet: string;
            export declare const FiscalYearOwnerBranch: string;
            export declare const FiscalYearSourceBranch: string;
        }

        [
            'Recnum', 
            'FiscalYear', 
            'PeriodNo', 
            'Period', 
            'StartDate', 
            'EndDate', 
            'AllowEntries', 
            'ClosedSl', 
            'ClosedPu', 
            'ClosedPr', 
            'ClosedIc', 
            'ClosedAr', 
            'ClosedAp', 
            'ClosedGl', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'ClosedDate', 
            'ClosedBy', 
            'BalBeg', 
            'BalBegSign', 
            'TotalDebit', 
            'TotalCredit', 
            'BalEnd', 
            'BalEndSign', 
            'ArBalBeg', 
            'ArInvoAmt', 
            'ArMemoAmt', 
            'ArAdjAmt', 
            'ArPayAmt', 
            'ArBalEnd', 
            'ApBalBeg', 
            'ApInvoAmt', 
            'ApMemoAmt', 
            'ApAdjAmt', 
            'ApPayAmt', 
            'ApBalEnd', 
            'ActiveGl', 
            'ActiveAp', 
            'ActiveAr', 
            'ActiveIc', 
            'ActivePr', 
            'OwnerBranch', 
            'SourceBranch', 
            'ArDiscAmt', 
            'ArDiffAmt', 
            'ApDiscAmt', 
            'ApDiffAmt', 
            'ApRfdAmt', 
            'ArRfdAmt', 
            'FiscalYearRecnum', 
            'FiscalYearAllowEntries', 
            'FiscalYearClosed', 
            'FiscalYearLastPeriod', 
            'FiscalYearCreatedDate', 
            'FiscalYearCreatedBy', 
            'FiscalYearRevisedDate', 
            'FiscalYearRevisedBy', 
            'FiscalYearClosedDate', 
            'FiscalYearClosedBy', 
            'FiscalYearYtdPlCredit', 
            'FiscalYearYtdPlDebit', 
            'FiscalYearYtdPlNet', 
            'FiscalYearOwnerBranch', 
            'FiscalYearSourceBranch'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

