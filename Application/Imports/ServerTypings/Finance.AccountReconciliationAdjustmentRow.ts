namespace Matrix.Finance {
    export interface AccountReconciliationAdjustmentRow {
        Recnum?: number;
        AdjAcctNo?: string;
        RefNo?: string;
        LineNo?: number;
        AcctNo?: string;
        CostCentre?: string;
        Dept?: string;
        LineRef?: string;
        Ccy?: string;
        ExchRate?: number;
        Debit?: number;
        Credit?: number;
        CompLdgDebit?: number;
        CompLdgCredit?: number;
        LedgerDebit?: number;
        LedgerCredit?: number;
        Anlys1?: string;
        Anlys2?: string;
        Anlys3?: string;
        Anlys4?: string;
        Anlys5?: string;
        Anlys6?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        Particulars?: string;
    }

    export namespace AccountReconciliationAdjustmentRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'AdjAcctNo';
        export const localTextPrefix = 'Finance.AccountReconciliationAdjustment';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const AdjAcctNo: string;
            export declare const RefNo: string;
            export declare const LineNo: string;
            export declare const AcctNo: string;
            export declare const CostCentre: string;
            export declare const Dept: string;
            export declare const LineRef: string;
            export declare const Ccy: string;
            export declare const ExchRate: string;
            export declare const Debit: string;
            export declare const Credit: string;
            export declare const CompLdgDebit: string;
            export declare const CompLdgCredit: string;
            export declare const LedgerDebit: string;
            export declare const LedgerCredit: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const Anlys3: string;
            export declare const Anlys4: string;
            export declare const Anlys5: string;
            export declare const Anlys6: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const Particulars: string;
        }

        [
            'Recnum', 
            'AdjAcctNo', 
            'RefNo', 
            'LineNo', 
            'AcctNo', 
            'CostCentre', 
            'Dept', 
            'LineRef', 
            'Ccy', 
            'ExchRate', 
            'Debit', 
            'Credit', 
            'CompLdgDebit', 
            'CompLdgCredit', 
            'LedgerDebit', 
            'LedgerCredit', 
            'Anlys1', 
            'Anlys2', 
            'Anlys3', 
            'Anlys4', 
            'Anlys5', 
            'Anlys6', 
            'OwnerBranch', 
            'SourceBranch', 
            'Particulars'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

