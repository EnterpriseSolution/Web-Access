namespace Matrix.MasterData {
    export interface AccountBudgetRow {
        Recnum?: number;
        AcctNo?: string;
        Period?: string;
        FiscalYear?: number;
        PeriodNo?: number;
        TotalDebit?: number;
        TotalCredit?: number;
        ControlDebit?: string;
        ControlCredit?: string;
        BudgetDebit?: number;
        BudgetCredit?: number;
        BudgetDate?: string;
        BudgetBy?: string;
        AcctNoRecnum?: number;
        AcctNoAcctName?: string;
        AcctNoAltAcctNo?: string;
        AcctNoNormalSign?: string;
        AcctNoTypeBs?: string;
        AcctNoTypePl?: string;
        AcctNoTypeDebtor?: string;
        AcctNoTypeCreditor?: string;
        AcctNoTypeMemo?: string;
        AcctNoDefaultCcy?: string;
        AcctNoAnlys1?: string;
        AcctNoAnlys2?: string;
        AcctNoAnlys3?: string;
        AcctNoAnlys4?: string;
        AcctNoSuspended?: string;
        AcctNoFixedCurrency?: string;
        AcctNoAutoDist?: string;
        AcctNoBudgetControl?: string;
        AcctNoSupprAnlys3?: string;
        AcctNoSupprAnlys4?: string;
        AcctNoSupprAnlys5?: string;
        AcctNoSupprAnlys6?: string;
        AcctNoSupprReval?: string;
        AcctNoNoCostCentre?: string;
        AcctNoNoDept?: string;
        AcctNoOper1?: string;
        AcctNoOper2?: string;
        AcctNoOper3?: string;
        AcctNoOper4?: string;
        AcctNoOper5?: string;
        AcctNoLinesBefPrint?: number;
        AcctNoTranAcct?: string;
        AcctNoSummaryPos?: string;
        AcctNoCreatedDate?: string;
        AcctNoCreatedBy?: string;
        AcctNoRevisedDate?: string;
        AcctNoRevisedBy?: string;
        AcctNoReconLastDate?: string;
        AcctNoReconLastJrn?: number;
        AcctNoReconBal?: number;
        AcctNoReconBalSign?: string;
        AcctNoLastTranDate?: string;
        AcctNoLastJrnNo?: number;
        AcctNoDistTotalPct?: number;
        AcctNoDistLastLine?: number;
        AcctNoReconCount?: number;
        AcctNoBalanceEnd?: number;
        AcctNoBalanceSign?: string;
        AcctNoOwnerBranch?: string;
        AcctNoSourceBranch?: string;
        AcctNoAllowEdit?: string;
        AcctNoAnlys5?: string;
        AcctNoAnlys6?: string;
        AcctNoAnlys7?: string;
        AcctNoAnlys8?: string;
        AcctNoAnlys9?: string;
        AcctNoAnlys10?: string;
    }

    export namespace AccountBudgetRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'AcctNo';
        export const localTextPrefix = 'Finance.AccountBudget';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const AcctNo: string;
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
            export declare const AcctNoRecnum: string;
            export declare const AcctNoAcctName: string;
            export declare const AcctNoAltAcctNo: string;
            export declare const AcctNoNormalSign: string;
            export declare const AcctNoTypeBs: string;
            export declare const AcctNoTypePl: string;
            export declare const AcctNoTypeDebtor: string;
            export declare const AcctNoTypeCreditor: string;
            export declare const AcctNoTypeMemo: string;
            export declare const AcctNoDefaultCcy: string;
            export declare const AcctNoAnlys1: string;
            export declare const AcctNoAnlys2: string;
            export declare const AcctNoAnlys3: string;
            export declare const AcctNoAnlys4: string;
            export declare const AcctNoSuspended: string;
            export declare const AcctNoFixedCurrency: string;
            export declare const AcctNoAutoDist: string;
            export declare const AcctNoBudgetControl: string;
            export declare const AcctNoSupprAnlys3: string;
            export declare const AcctNoSupprAnlys4: string;
            export declare const AcctNoSupprAnlys5: string;
            export declare const AcctNoSupprAnlys6: string;
            export declare const AcctNoSupprReval: string;
            export declare const AcctNoNoCostCentre: string;
            export declare const AcctNoNoDept: string;
            export declare const AcctNoOper1: string;
            export declare const AcctNoOper2: string;
            export declare const AcctNoOper3: string;
            export declare const AcctNoOper4: string;
            export declare const AcctNoOper5: string;
            export declare const AcctNoLinesBefPrint: string;
            export declare const AcctNoTranAcct: string;
            export declare const AcctNoSummaryPos: string;
            export declare const AcctNoCreatedDate: string;
            export declare const AcctNoCreatedBy: string;
            export declare const AcctNoRevisedDate: string;
            export declare const AcctNoRevisedBy: string;
            export declare const AcctNoReconLastDate: string;
            export declare const AcctNoReconLastJrn: string;
            export declare const AcctNoReconBal: string;
            export declare const AcctNoReconBalSign: string;
            export declare const AcctNoLastTranDate: string;
            export declare const AcctNoLastJrnNo: string;
            export declare const AcctNoDistTotalPct: string;
            export declare const AcctNoDistLastLine: string;
            export declare const AcctNoReconCount: string;
            export declare const AcctNoBalanceEnd: string;
            export declare const AcctNoBalanceSign: string;
            export declare const AcctNoOwnerBranch: string;
            export declare const AcctNoSourceBranch: string;
            export declare const AcctNoAllowEdit: string;
            export declare const AcctNoAnlys5: string;
            export declare const AcctNoAnlys6: string;
            export declare const AcctNoAnlys7: string;
            export declare const AcctNoAnlys8: string;
            export declare const AcctNoAnlys9: string;
            export declare const AcctNoAnlys10: string;
        }

        [
            'Recnum', 
            'AcctNo', 
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
            'BudgetBy', 
            'AcctNoRecnum', 
            'AcctNoAcctName', 
            'AcctNoAltAcctNo', 
            'AcctNoNormalSign', 
            'AcctNoTypeBs', 
            'AcctNoTypePl', 
            'AcctNoTypeDebtor', 
            'AcctNoTypeCreditor', 
            'AcctNoTypeMemo', 
            'AcctNoDefaultCcy', 
            'AcctNoAnlys1', 
            'AcctNoAnlys2', 
            'AcctNoAnlys3', 
            'AcctNoAnlys4', 
            'AcctNoSuspended', 
            'AcctNoFixedCurrency', 
            'AcctNoAutoDist', 
            'AcctNoBudgetControl', 
            'AcctNoSupprAnlys3', 
            'AcctNoSupprAnlys4', 
            'AcctNoSupprAnlys5', 
            'AcctNoSupprAnlys6', 
            'AcctNoSupprReval', 
            'AcctNoNoCostCentre', 
            'AcctNoNoDept', 
            'AcctNoOper1', 
            'AcctNoOper2', 
            'AcctNoOper3', 
            'AcctNoOper4', 
            'AcctNoOper5', 
            'AcctNoLinesBefPrint', 
            'AcctNoTranAcct', 
            'AcctNoSummaryPos', 
            'AcctNoCreatedDate', 
            'AcctNoCreatedBy', 
            'AcctNoRevisedDate', 
            'AcctNoRevisedBy', 
            'AcctNoReconLastDate', 
            'AcctNoReconLastJrn', 
            'AcctNoReconBal', 
            'AcctNoReconBalSign', 
            'AcctNoLastTranDate', 
            'AcctNoLastJrnNo', 
            'AcctNoDistTotalPct', 
            'AcctNoDistLastLine', 
            'AcctNoReconCount', 
            'AcctNoBalanceEnd', 
            'AcctNoBalanceSign', 
            'AcctNoOwnerBranch', 
            'AcctNoSourceBranch', 
            'AcctNoAllowEdit', 
            'AcctNoAnlys5', 
            'AcctNoAnlys6', 
            'AcctNoAnlys7', 
            'AcctNoAnlys8', 
            'AcctNoAnlys9', 
            'AcctNoAnlys10'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

