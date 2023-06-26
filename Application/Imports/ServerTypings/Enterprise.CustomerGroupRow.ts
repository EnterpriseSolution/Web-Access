namespace Matrix.Enterprise {
    export interface CustomerGroupRow {
        Recnum?: number;
        CustomerGroup?: string;
        Description?: string;
        Suspended?: boolean;
        AcctArCust?: string;
        AcctArDisc?: string;
        AcctArAdj?: string;
        AcctSlsTrdisc?: string;
        GtaxCode?: string;
        LtaxCode?: string;
        PaymentCcy?: string;
        PayTerms?: string;
        PriceCode?: string;
        UseAltNames?: boolean;
        WithCrLimit?: boolean;
        CreditLimit?: number;
        TradeDiscount?: number;
        Anlys1?: string;
        Anlys2?: string;
        Anlys3?: string;
        Anlys4?: string;
        CustomerCount?: number;
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
        AcctCustSltax?: string;
        SltaxPcent?: number;
        Anlys5?: string;
        Anlys6?: string;
        Anlys7?: string;
        Anlys8?: string;
        Anlys9?: string;
        Anlys10?: string;
        AcctTemp?: string;
        ClientCompanyName?: string;
        ClientAddress1?: string;
        ClientAddress2?: string;
        ClientAddress3?: string;
        ClientAddress4?: string;
        ClientAddress5?: string;
        ClientTelNo?: string;
        ClientFaxNo?: string;
        ClientEmailAddress?: string;
        ClientContactPerson?: string;
        ClientContactTitle?: string;
        ClientRemarks?: string;
        AcctArDeposit?: string;
    }

    export namespace CustomerGroupRow {
        export const idProperty = 'CustomerGroup';
        export const nameProperty = 'CustomerGroup';
        export const localTextPrefix = 'Enterprise.CustomerGroup';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const CustomerGroup: string;
            export declare const Description: string;
            export declare const Suspended: string;
            export declare const AcctArCust: string;
            export declare const AcctArDisc: string;
            export declare const AcctArAdj: string;
            export declare const AcctSlsTrdisc: string;
            export declare const GtaxCode: string;
            export declare const LtaxCode: string;
            export declare const PaymentCcy: string;
            export declare const PayTerms: string;
            export declare const PriceCode: string;
            export declare const UseAltNames: string;
            export declare const WithCrLimit: string;
            export declare const CreditLimit: string;
            export declare const TradeDiscount: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const Anlys3: string;
            export declare const Anlys4: string;
            export declare const CustomerCount: string;
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
            export declare const AcctCustSltax: string;
            export declare const SltaxPcent: string;
            export declare const Anlys5: string;
            export declare const Anlys6: string;
            export declare const Anlys7: string;
            export declare const Anlys8: string;
            export declare const Anlys9: string;
            export declare const Anlys10: string;
            export declare const AcctTemp: string;
            export declare const ClientCompanyName: string;
            export declare const ClientAddress1: string;
            export declare const ClientAddress2: string;
            export declare const ClientAddress3: string;
            export declare const ClientAddress4: string;
            export declare const ClientAddress5: string;
            export declare const ClientTelNo: string;
            export declare const ClientFaxNo: string;
            export declare const ClientEmailAddress: string;
            export declare const ClientContactPerson: string;
            export declare const ClientContactTitle: string;
            export declare const ClientRemarks: string;
            export declare const AcctArDeposit: string;
        }

        [
            'Recnum', 
            'CustomerGroup', 
            'Description', 
            'Suspended', 
            'AcctArCust', 
            'AcctArDisc', 
            'AcctArAdj', 
            'AcctSlsTrdisc', 
            'GtaxCode', 
            'LtaxCode', 
            'PaymentCcy', 
            'PayTerms', 
            'PriceCode', 
            'UseAltNames', 
            'WithCrLimit', 
            'CreditLimit', 
            'TradeDiscount', 
            'Anlys1', 
            'Anlys2', 
            'Anlys3', 
            'Anlys4', 
            'CustomerCount', 
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
            'AcctCustSltax', 
            'SltaxPcent', 
            'Anlys5', 
            'Anlys6', 
            'Anlys7', 
            'Anlys8', 
            'Anlys9', 
            'Anlys10', 
            'AcctTemp', 
            'ClientCompanyName', 
            'ClientAddress1', 
            'ClientAddress2', 
            'ClientAddress3', 
            'ClientAddress4', 
            'ClientAddress5', 
            'ClientTelNo', 
            'ClientFaxNo', 
            'ClientEmailAddress', 
            'ClientContactPerson', 
            'ClientContactTitle', 
            'ClientRemarks', 
            'AcctArDeposit'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

