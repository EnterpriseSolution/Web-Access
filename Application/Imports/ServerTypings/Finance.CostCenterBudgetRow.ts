namespace Matrix.Finance {
    export interface CostCenterBudgetRow {
        Recnum?: number;
        AcctNo?: string;
        CostCentre?: string;
        Period?: string;
        FiscalYear?: number;
        PeriodNo?: number;
        TotalDebit?: number;
        TotalCredit?: number;
        ControlDebit?: boolean;
        ControlCredit?: boolean;
        BudgetDebit?: number;
        BudgetCredit?: number;
        BudgetDate?: string;
        BudgetBy?: string;
    }

    export namespace CostCenterBudgetRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'AcctNo';
        export const localTextPrefix = 'Finance.CostCenterBudget';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const AcctNo: string;
            export declare const CostCentre: string;
            export declare const Period: string;
            export declare const FiscalYear: string;
            export declare const PeriodNo: string;
            export declare const TotalDebit: string;
            export declare const TotalCredit: string;
            export declare const ControlDebit: string;
            export declare const ControlCredit: string;
            export declare const BudgetDebit: string;
            export declare const BudgetCredit: string;
            export declare const BudgetDate: string;
            export declare const BudgetBy: string;
        }

        [
            'Recnum', 
            'AcctNo', 
            'CostCentre', 
            'Period', 
            'FiscalYear', 
            'PeriodNo', 
            'TotalDebit', 
            'TotalCredit', 
            'ControlDebit', 
            'ControlCredit', 
            'BudgetDebit', 
            'BudgetCredit', 
            'BudgetDate', 
            'BudgetBy'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

