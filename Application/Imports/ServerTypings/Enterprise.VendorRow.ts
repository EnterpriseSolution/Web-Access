namespace Matrix.Enterprise {
    export interface VendorRow {
        Recnum?: number;
        VendorNo?: string;
        VendorName?: string;
        Address?: string;
        Address2?: string;
        Address3?: string;
        Address4?: string;
        PostCode?: string;
        TelNo?: string;
        FaxNo?: string;
        Email?: string;
        Suspended?: boolean;
        VendorGroup?: string;
        OrderCcy?: string;
        PayTerms?: string;
        GtaxCode?: string;
        LtaxCode?: string;
        AcctApVend?: string;
        AcctApDisc?: string;
        AcctApAdj?: string;
        AcctPurTrdisc?: string;
        UseAltNames?: string;
        WithCrLimit?: boolean;
        CreditLimit?: number;
        Anlys1?: string;
        Anlys2?: string;
        Anlys3?: string;
        Anlys4?: string;
        ContactPerson?: string;
        ContactTitle?: string;
        TradeDiscount?: number;
        LeadTime?: number;
        BankName?: string;
        BankAcctNo?: string;
        AltVendorName?: string;
        AltAddress?: string;
        AltAddress2?: string;
        AltAddress3?: string;
        AltAddress4?: string;
        WithBacklog?: string;
        WithBalance?: string;
        OnOrderCount?: number;
        InvoAmtBal?: number;
        OpenAmtBal?: number;
        NetAmtBal?: number;
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
        UseAltDesc?: string;
        PurPriceCtrl?: string;
        PurMaxDev?: number;
        PendAmtOrd?: number;
        PendAmtInv?: number;
        BuyerCode?: string;
        TaxationLv?: string;
        PutaxPcent?: number;
        AcctVendPutax?: string;
        IsApproved?: string;
        ApprovedBy?: string;
        Preapprove?: string;
        ApprovedDate?: string;
        Anlys5?: string;
        Anlys6?: string;
        Anlys7?: string;
        Anlys8?: string;
        Anlys9?: string;
        Anlys10?: string;
        AcctTemp?: string;
        RefCompanyCode?: string;
        RefCustomerNo?: string;
        RefIntegrateComments?: boolean;
        RefIntegrateAnlys?: boolean;
        TaxTerms?: string;
        CustomTerms?: string;
        OverReceiptPcent?: number;
        AcctApDeposit?: string;
        VendorGroupRecnum?: number;
        VendorGroupDescription?: string;
        VendorGroupSuspended?: string;
        VendorGroupAcctApVend?: string;
        VendorGroupAcctApDisc?: string;
        VendorGroupAcctApAdj?: string;
        VendorGroupAcctPurTrdisc?: string;
        VendorGroupGtaxCode?: string;
        VendorGroupLtaxCode?: string;
        VendorGroupOrderCcy?: string;
        VendorGroupPayTerms?: string;
        VendorGroupUseAltNames?: string;
        VendorGroupWithCrLimit?: string;
        VendorGroupCreditLimit?: number;
        VendorGroupTradeDiscount?: number;
        VendorGroupAnlys1?: string;
        VendorGroupAnlys2?: string;
        VendorGroupAnlys3?: string;
        VendorGroupAnlys4?: string;
        VendorGroupVendorCount?: number;
        VendorGroupCreatedDate?: string;
        VendorGroupCreatedBy?: string;
        VendorGroupRevisedDate?: string;
        VendorGroupRevisedBy?: string;
        VendorGroupArevisedDate?: string;
        VendorGroupArevisedBy?: string;
        VendorGroupTrevisedDate?: string;
        VendorGroupTrevisedBy?: string;
        VendorGroupOwnerBranch?: string;
        VendorGroupSourceBranch?: string;
        VendorGroupPutaxPcent?: number;
        VendorGroupAcctVendPutax?: string;
        VendorGroupAnlys5?: string;
        VendorGroupAnlys6?: string;
        VendorGroupAnlys7?: string;
        VendorGroupAnlys8?: string;
        VendorGroupAnlys9?: string;
        VendorGroupAnlys10?: string;
        VendorGroupAcctTemp?: string;
        VendorGroupAcctApDeposit?: string;
    }

    export namespace VendorRow {
        export const idProperty = 'VendorNo';
        export const nameProperty = 'VendorName';
        export const localTextPrefix = 'Enterprise.Vendor';
        export const lookupKey = 'Enterprise.VendorLookup';

        export function getLookup(): Q.Lookup<VendorRow> {
            return Q.getLookup<VendorRow>('Enterprise.VendorLookup');
        }

        export namespace Fields {
            export declare const Recnum: string;
            export declare const VendorNo: string;
            export declare const VendorName: string;
            export declare const Address: string;
            export declare const Address2: string;
            export declare const Address3: string;
            export declare const Address4: string;
            export declare const PostCode: string;
            export declare const TelNo: string;
            export declare const FaxNo: string;
            export declare const Email: string;
            export declare const Suspended: string;
            export declare const VendorGroup: string;
            export declare const OrderCcy: string;
            export declare const PayTerms: string;
            export declare const GtaxCode: string;
            export declare const LtaxCode: string;
            export declare const AcctApVend: string;
            export declare const AcctApDisc: string;
            export declare const AcctApAdj: string;
            export declare const AcctPurTrdisc: string;
            export declare const UseAltNames: string;
            export declare const WithCrLimit: string;
            export declare const CreditLimit: string;
            export declare const Anlys1: string;
            export declare const Anlys2: string;
            export declare const Anlys3: string;
            export declare const Anlys4: string;
            export declare const ContactPerson: string;
            export declare const ContactTitle: string;
            export declare const TradeDiscount: string;
            export declare const LeadTime: string;
            export declare const BankName: string;
            export declare const BankAcctNo: string;
            export declare const AltVendorName: string;
            export declare const AltAddress: string;
            export declare const AltAddress2: string;
            export declare const AltAddress3: string;
            export declare const AltAddress4: string;
            export declare const WithBacklog: string;
            export declare const WithBalance: string;
            export declare const OnOrderCount: string;
            export declare const InvoAmtBal: string;
            export declare const OpenAmtBal: string;
            export declare const NetAmtBal: string;
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
            export declare const UseAltDesc: string;
            export declare const PurPriceCtrl: string;
            export declare const PurMaxDev: string;
            export declare const PendAmtOrd: string;
            export declare const PendAmtInv: string;
            export declare const BuyerCode: string;
            export declare const TaxationLv: string;
            export declare const PutaxPcent: string;
            export declare const AcctVendPutax: string;
            export declare const IsApproved: string;
            export declare const ApprovedBy: string;
            export declare const Preapprove: string;
            export declare const ApprovedDate: string;
            export declare const Anlys5: string;
            export declare const Anlys6: string;
            export declare const Anlys7: string;
            export declare const Anlys8: string;
            export declare const Anlys9: string;
            export declare const Anlys10: string;
            export declare const AcctTemp: string;
            export declare const RefCompanyCode: string;
            export declare const RefCustomerNo: string;
            export declare const RefIntegrateComments: string;
            export declare const RefIntegrateAnlys: string;
            export declare const TaxTerms: string;
            export declare const CustomTerms: string;
            export declare const OverReceiptPcent: string;
            export declare const AcctApDeposit: string;
            export declare const VendorGroupRecnum: string;
            export declare const VendorGroupDescription: string;
            export declare const VendorGroupSuspended: string;
            export declare const VendorGroupAcctApVend: string;
            export declare const VendorGroupAcctApDisc: string;
            export declare const VendorGroupAcctApAdj: string;
            export declare const VendorGroupAcctPurTrdisc: string;
            export declare const VendorGroupGtaxCode: string;
            export declare const VendorGroupLtaxCode: string;
            export declare const VendorGroupOrderCcy: string;
            export declare const VendorGroupPayTerms: string;
            export declare const VendorGroupUseAltNames: string;
            export declare const VendorGroupWithCrLimit: string;
            export declare const VendorGroupCreditLimit: string;
            export declare const VendorGroupTradeDiscount: string;
            export declare const VendorGroupAnlys1: string;
            export declare const VendorGroupAnlys2: string;
            export declare const VendorGroupAnlys3: string;
            export declare const VendorGroupAnlys4: string;
            export declare const VendorGroupVendorCount: string;
            export declare const VendorGroupCreatedDate: string;
            export declare const VendorGroupCreatedBy: string;
            export declare const VendorGroupRevisedDate: string;
            export declare const VendorGroupRevisedBy: string;
            export declare const VendorGroupArevisedDate: string;
            export declare const VendorGroupArevisedBy: string;
            export declare const VendorGroupTrevisedDate: string;
            export declare const VendorGroupTrevisedBy: string;
            export declare const VendorGroupOwnerBranch: string;
            export declare const VendorGroupSourceBranch: string;
            export declare const VendorGroupPutaxPcent: string;
            export declare const VendorGroupAcctVendPutax: string;
            export declare const VendorGroupAnlys5: string;
            export declare const VendorGroupAnlys6: string;
            export declare const VendorGroupAnlys7: string;
            export declare const VendorGroupAnlys8: string;
            export declare const VendorGroupAnlys9: string;
            export declare const VendorGroupAnlys10: string;
            export declare const VendorGroupAcctTemp: string;
            export declare const VendorGroupAcctApDeposit: string;
        }

        [
            'Recnum', 
            'VendorNo', 
            'VendorName', 
            'Address', 
            'Address2', 
            'Address3', 
            'Address4', 
            'PostCode', 
            'TelNo', 
            'FaxNo', 
            'Email', 
            'Suspended', 
            'VendorGroup', 
            'OrderCcy', 
            'PayTerms', 
            'GtaxCode', 
            'LtaxCode', 
            'AcctApVend', 
            'AcctApDisc', 
            'AcctApAdj', 
            'AcctPurTrdisc', 
            'UseAltNames', 
            'WithCrLimit', 
            'CreditLimit', 
            'Anlys1', 
            'Anlys2', 
            'Anlys3', 
            'Anlys4', 
            'ContactPerson', 
            'ContactTitle', 
            'TradeDiscount', 
            'LeadTime', 
            'BankName', 
            'BankAcctNo', 
            'AltVendorName', 
            'AltAddress', 
            'AltAddress2', 
            'AltAddress3', 
            'AltAddress4', 
            'WithBacklog', 
            'WithBalance', 
            'OnOrderCount', 
            'InvoAmtBal', 
            'OpenAmtBal', 
            'NetAmtBal', 
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
            'UseAltDesc', 
            'PurPriceCtrl', 
            'PurMaxDev', 
            'PendAmtOrd', 
            'PendAmtInv', 
            'BuyerCode', 
            'TaxationLv', 
            'PutaxPcent', 
            'AcctVendPutax', 
            'IsApproved', 
            'ApprovedBy', 
            'Preapprove', 
            'ApprovedDate', 
            'Anlys5', 
            'Anlys6', 
            'Anlys7', 
            'Anlys8', 
            'Anlys9', 
            'Anlys10', 
            'AcctTemp', 
            'RefCompanyCode', 
            'RefCustomerNo', 
            'RefIntegrateComments', 
            'RefIntegrateAnlys', 
            'TaxTerms', 
            'CustomTerms', 
            'OverReceiptPcent', 
            'AcctApDeposit', 
            'VendorGroupRecnum', 
            'VendorGroupDescription', 
            'VendorGroupSuspended', 
            'VendorGroupAcctApVend', 
            'VendorGroupAcctApDisc', 
            'VendorGroupAcctApAdj', 
            'VendorGroupAcctPurTrdisc', 
            'VendorGroupGtaxCode', 
            'VendorGroupLtaxCode', 
            'VendorGroupOrderCcy', 
            'VendorGroupPayTerms', 
            'VendorGroupUseAltNames', 
            'VendorGroupWithCrLimit', 
            'VendorGroupCreditLimit', 
            'VendorGroupTradeDiscount', 
            'VendorGroupAnlys1', 
            'VendorGroupAnlys2', 
            'VendorGroupAnlys3', 
            'VendorGroupAnlys4', 
            'VendorGroupVendorCount', 
            'VendorGroupCreatedDate', 
            'VendorGroupCreatedBy', 
            'VendorGroupRevisedDate', 
            'VendorGroupRevisedBy', 
            'VendorGroupArevisedDate', 
            'VendorGroupArevisedBy', 
            'VendorGroupTrevisedDate', 
            'VendorGroupTrevisedBy', 
            'VendorGroupOwnerBranch', 
            'VendorGroupSourceBranch', 
            'VendorGroupPutaxPcent', 
            'VendorGroupAcctVendPutax', 
            'VendorGroupAnlys5', 
            'VendorGroupAnlys6', 
            'VendorGroupAnlys7', 
            'VendorGroupAnlys8', 
            'VendorGroupAnlys9', 
            'VendorGroupAnlys10', 
            'VendorGroupAcctTemp', 
            'VendorGroupAcctApDeposit'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

