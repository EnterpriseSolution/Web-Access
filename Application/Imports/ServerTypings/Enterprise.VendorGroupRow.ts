namespace Matrix.Enterprise {
    export interface VendorGroupRow {
        Recnum?: number;
        VendorGroup?: string;
        Description?: string;
        Suspended?: boolean;
        AcctApVend?: string;
        AcctApDisc?: string;
        AcctApAdj?: string;
        AcctPurTrdisc?: string;
        GtaxCode?: string;
        LtaxCode?: string;
        OrderCcy?: string;
        PayTerms?: string;
        UseAltNames?: boolean;
        WithCrLimit?: string;
        CreditLimit?: number;
        TradeDiscount?: number;
        Anlys1?: string;
        Anlys2?: string;
        Anlys3?: string;
        Anlys4?: string;
        VendorCount?: number;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        ArevisedDate?: string;
        ArevisedBy?: string;
        TrevisedDate?: string;
        TrevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        PutaxPcent?: number;
        AcctVendPutax?: string;
        Anlys5?: string;
        Anlys6?: string;
        Anlys7?: string;
        Anlys8?: string;
        Anlys9?: string;
        Anlys10?: string;
        AcctTemp?: string;
        AcctApDeposit?: string;
    }

    export namespace VendorGroupRow {
        export const idProperty = 'VendorGroup';
        export const nameProperty = 'Description';
        export const localTextPrefix = 'Enterprise.VendorGroup';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const VendorGroup: string;
            export declare const Description: string;
            export declare const Suspended: string;
            export declare const AcctApVend: string;
            export declare const AcctApDisc: string;
            export declare const AcctApAdj: string;
            export declare const AcctPurTrdisc: string;
            export declare const GtaxCode: string;
            export declare const LtaxCode: string;
            export declare const OrderCcy: string;
            export declare const PayTerms: string;
            export declare const UseAltNames: string;
            export declare const WithCrLimit: string;
            export declare const CreditLimit: string;
            export declare const TradeDiscount: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const Anlys3: string;
            export declare const Anlys4: string;
            export declare const VendorCount: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const ArevisedDate: string;
            export declare const ArevisedBy: string;
            export declare const TrevisedDate: string;
            export declare const TrevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const PutaxPcent: string;
            export declare const AcctVendPutax: string;
            export declare const Anlys5: string;
            export declare const Anlys6: string;
            export declare const Anlys7: string;
            export declare const Anlys8: string;
            export declare const Anlys9: string;
            export declare const Anlys10: string;
            export declare const AcctTemp: string;
            export declare const AcctApDeposit: string;
        }

        [
            'Recnum', 
            'VendorGroup', 
            'Description', 
            'Suspended', 
            'AcctApVend', 
            'AcctApDisc', 
            'AcctApAdj', 
            'AcctPurTrdisc', 
            'GtaxCode', 
            'LtaxCode', 
            'OrderCcy', 
            'PayTerms', 
            'UseAltNames', 
            'WithCrLimit', 
            'CreditLimit', 
            'TradeDiscount', 
            'Anlys1', 
            'Anlys2', 
            'Anlys3', 
            'Anlys4', 
            'VendorCount', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'ArevisedDate', 
            'ArevisedBy', 
            'TrevisedDate', 
            'TrevisedBy', 
            'OwnerBranch', 
            'SourceBranch', 
            'PutaxPcent', 
            'AcctVendPutax', 
            'Anlys5', 
            'Anlys6', 
            'Anlys7', 
            'Anlys8', 
            'Anlys9', 
            'Anlys10', 
            'AcctTemp', 
            'AcctApDeposit'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

