namespace Matrix.MasterData {
    export interface ChargeTypeRow {
        Recnum?: number;
        ChargeType?: string;
        Description?: string;
        Suspended?: boolean;
        Deduction?: boolean;
        UseInSales?: boolean;
        UseInPurchase?: boolean;
        SlsAcctNo?: string;
        PurAcctNo?: string;
        FixedRate?: string;
        FixedBasis?: string;
        FixedPercent?: number;
        FixedAmt?: number;
        Step01?: string;
        Oper01?: string;
        Step02?: string;
        Oper02?: string;
        Step03?: string;
        Oper03?: string;
        Step04?: string;
        Oper04?: string;
        Step05?: string;
        Oper05?: string;
        Step06?: string;
        Oper06?: string;
        Step07?: string;
        Oper07?: string;
        Step08?: string;
        Oper08?: string;
        Step09?: string;
        Oper09?: string;
        Step10?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        UseInProduction?: string;
        ProdAcctNo?: string;
    }

    export namespace ChargeTypeRow {
        export const idProperty = 'ChargeType';
        export const nameProperty = 'Description';
        export const localTextPrefix = 'MasterData.ChargeType';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const ChargeType: string;
            export declare const Description: string;
            export declare const Suspended: string;
            export declare const Deduction: string;
            export declare const UseInSales: string;
            export declare const UseInPurchase: string;
            export declare const SlsAcctNo: string;
            export declare const PurAcctNo: string;
            export declare const FixedRate: string;
            export declare const FixedBasis: string;
            export declare const FixedPercent: string;
            export declare const FixedAmt: string;
            export declare const Step01: string;
            export declare const Oper01: string;
            export declare const Step02: string;
            export declare const Oper02: string;
            export declare const Step03: string;
            export declare const Oper03: string;
            export declare const Step04: string;
            export declare const Oper04: string;
            export declare const Step05: string;
            export declare const Oper05: string;
            export declare const Step06: string;
            export declare const Oper06: string;
            export declare const Step07: string;
            export declare const Oper07: string;
            export declare const Step08: string;
            export declare const Oper08: string;
            export declare const Step09: string;
            export declare const Oper09: string;
            export declare const Step10: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const UseInProduction: string;
            export declare const ProdAcctNo: string;
        }

        [
            'Recnum', 
            'ChargeType', 
            'Description', 
            'Suspended', 
            'Deduction', 
            'UseInSales', 
            'UseInPurchase', 
            'SlsAcctNo', 
            'PurAcctNo', 
            'FixedRate', 
            'FixedBasis', 
            'FixedPercent', 
            'FixedAmt', 
            'Step01', 
            'Oper01', 
            'Step02', 
            'Oper02', 
            'Step03', 
            'Oper03', 
            'Step04', 
            'Oper04', 
            'Step05', 
            'Oper05', 
            'Step06', 
            'Oper06', 
            'Step07', 
            'Oper07', 
            'Step08', 
            'Oper08', 
            'Step09', 
            'Oper09', 
            'Step10', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch', 
            'UseInProduction', 
            'ProdAcctNo'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

