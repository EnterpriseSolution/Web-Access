namespace Matrix.MasterData {
    export interface AccountRow {
        DetailList?: AccountBudgetRow[];
        Recnum?: number;
        AcctNo?: string;
        AcctName?: string;
        AltAcctNo?: string;
        NormalSign?: string;
        TypeBs?: boolean;
        TypePl?: boolean;
        TypeDebtor?: string;
        TypeCreditor?: string;
        TypeMemo?: string;
        DefaultCcy?: string;
        Anlys1?: string;
        Anlys2?: string;
        Anlys3?: string;
        Anlys4?: string;
        Suspended?: boolean;
        FixedCurrency?: string;
        AutoDist?: string;
        BudgetControl?: string;
        SupprAnlys3?: string;
        SupprAnlys4?: string;
        SupprAnlys5?: string;
        SupprAnlys6?: string;
        SupprReval?: string;
        NoCostCentre?: string;
        NoDept?: string;
        Oper1?: string;
        Oper2?: string;
        Oper3?: string;
        Oper4?: string;
        Oper5?: string;
        LinesBefPrint?: number;
        TranAcct?: string;
        SummaryPos?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        ReconLastDate?: string;
        ReconLastJrn?: number;
        ReconBal?: number;
        ReconBalSign?: string;
        LastTranDate?: string;
        LastJrnNo?: number;
        DistTotalPct?: number;
        DistLastLine?: number;
        ReconCount?: number;
        BalanceEnd?: number;
        BalanceSign?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        AllowEdit?: string;
        Anlys5?: string;
        Anlys6?: string;
        Anlys7?: string;
        Anlys8?: string;
        Anlys9?: string;
        Anlys10?: string;
    }

    export namespace AccountRow {
        export const idProperty = 'AcctNo';
        export const nameProperty = 'AcctName';
        export const localTextPrefix = 'MasterData.Account';

        export namespace Fields {
            export declare const DetailList: string;
            export declare const Recnum: string;
            export declare const AcctNo: string;
            export declare const AcctName: string;
            export declare const AltAcctNo: string;
            export declare const NormalSign: string;
            export declare const TypeBs: string;
            export declare const TypePl: string;
            export declare const TypeDebtor: string;
            export declare const TypeCreditor: string;
            export declare const TypeMemo: string;
            export declare const DefaultCcy: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const Anlys3: string;
            export declare const Anlys4: string;
            export declare const Suspended: string;
            export declare const FixedCurrency: string;
            export declare const AutoDist: string;
            export declare const BudgetControl: string;
            export declare const SupprAnlys3: string;
            export declare const SupprAnlys4: string;
            export declare const SupprAnlys5: string;
            export declare const SupprAnlys6: string;
            export declare const SupprReval: string;
            export declare const NoCostCentre: string;
            export declare const NoDept: string;
            export declare const Oper1: string;
            export declare const Oper2: string;
            export declare const Oper3: string;
            export declare const Oper4: string;
            export declare const Oper5: string;
            export declare const LinesBefPrint: string;
            export declare const TranAcct: string;
            export declare const SummaryPos: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const ReconLastDate: string;
            export declare const ReconLastJrn: string;
            export declare const ReconBal: string;
            export declare const ReconBalSign: string;
            export declare const LastTranDate: string;
            export declare const LastJrnNo: string;
            export declare const DistTotalPct: string;
            export declare const DistLastLine: string;
            export declare const ReconCount: string;
            export declare const BalanceEnd: string;
            export declare const BalanceSign: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const AllowEdit: string;
            export declare const Anlys5: string;
            export declare const Anlys6: string;
            export declare const Anlys7: string;
            export declare const Anlys8: string;
            export declare const Anlys9: string;
            export declare const Anlys10: string;
        }

        [
            'DetailList', 
            'Recnum', 
            'AcctNo', 
            'AcctName', 
            'AltAcctNo', 
            'NormalSign', 
            'TypeBs', 
            'TypePl', 
            'TypeDebtor', 
            'TypeCreditor', 
            'TypeMemo', 
            'DefaultCcy', 
            'Anlys1', 
            'Anlys2', 
            'Anlys3', 
            'Anlys4', 
            'Suspended', 
            'FixedCurrency', 
            'AutoDist', 
            'BudgetControl', 
            'SupprAnlys3', 
            'SupprAnlys4', 
            'SupprAnlys5', 
            'SupprAnlys6', 
            'SupprReval', 
            'NoCostCentre', 
            'NoDept', 
            'Oper1', 
            'Oper2', 
            'Oper3', 
            'Oper4', 
            'Oper5', 
            'LinesBefPrint', 
            'TranAcct', 
            'SummaryPos', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'ReconLastDate', 
            'ReconLastJrn', 
            'ReconBal', 
            'ReconBalSign', 
            'LastTranDate', 
            'LastJrnNo', 
            'DistTotalPct', 
            'DistLastLine', 
            'ReconCount', 
            'BalanceEnd', 
            'BalanceSign', 
            'OwnerBranch', 
            'SourceBranch', 
            'AllowEdit', 
            'Anlys5', 
            'Anlys6', 
            'Anlys7', 
            'Anlys8', 
            'Anlys9', 
            'Anlys10'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

