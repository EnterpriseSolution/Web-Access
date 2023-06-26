namespace Matrix.MasterData {
    export interface CustomerRow {
        Recnum?: number;
        CustomerNo?: string;
        CustomerName?: string;
        Address?: string;
        Address2?: string;
        Address3?: string;
        Address4?: string;
        PostCode?: string;
        TelNo?: string;
        FaxNo?: string;
        Email?: string;
        Suspended?: boolean;
        CustomerGroup?: string;
        PaymentCcy?: string;
        PayTerms?: string;
        GtaxCode?: string;
        LtaxCode?: string;
        AcctArCust?: string;
        AcctArDisc?: string;
        AcctArAdj?: string;
        AcctSlsTrdisc?: string;
        PriceCode?: string;
        UseAltNames?: string;
        WithCrLimit?: string;
        CreditLimit?: number;
        Anlys1?: string;
        Anlys2?: string;
        Anlys3?: string;
        Anlys4?: string;
        ContactPerson?: string;
        ContactTitle?: string;
        TradeDiscount?: number;
        AltCustName?: string;
        AltCustAddr?: string;
        AltCustAddr2?: string;
        AltCustAddr3?: string;
        AltCustAddr4?: string;
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
        LastNoteNo?: number;
        Salesman?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        UseAltDesc?: string;
        MaskCode?: string;
        ShortName?: string;
        PendAmtOrd?: number;
        PendAmtInv?: number;
        AcctCustSltax?: string;
        TaxationLv?: string;
        SltaxPcent?: number;
        ShipmentTerms?: string;
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
        UserDefinedField1?: string;
        UserDefinedField2?: string;
        UserDefinedField3?: string;
        UserDefinedField4?: string;
        UserDefinedField5?: string;
        UserDefinedField6?: string;
        UserDefinedField7?: string;
        UserDefinedField8?: string;
        UserDefinedField9?: string;
        UserDefinedField10?: string;
        UserDefinedField11?: string;
        UserDefinedField12?: string;
        UserDefinedField13?: string;
        UserDefinedField14?: string;
        UserDefinedField15?: string;
        UserDefinedField16?: string;
        UserDefinedField17?: string;
        UserDefinedField18?: string;
        UserDefinedField19?: string;
        UserDefinedField20?: string;
        AcctTemp?: string;
        BreakDebitNote?: boolean;
        ContractorCode?: string;
        PayTermsAr?: string;
        AcctArDeposit?: string;
        CustomerGroupRecnum?: number;
        CustomerGroupDescription?: string;
        CustomerGroupSuspended?: string;
        CustomerGroupAcctArCust?: string;
        CustomerGroupAcctArDisc?: string;
        CustomerGroupAcctArAdj?: string;
        CustomerGroupAcctSlsTrdisc?: string;
        CustomerGroupGtaxCode?: string;
        CustomerGroupLtaxCode?: string;
        CustomerGroupPaymentCcy?: string;
        CustomerGroupPayTerms?: string;
        CustomerGroupPriceCode?: string;
        CustomerGroupUseAltNames?: string;
        CustomerGroupWithCrLimit?: string;
        CustomerGroupCreditLimit?: number;
        CustomerGroupTradeDiscount?: number;
        CustomerGroupAnlys1?: string;
        CustomerGroupAnlys2?: string;
        CustomerGroupAnlys3?: string;
        CustomerGroupAnlys4?: string;
        CustomerGroupCustomerCount?: number;
        CustomerGroupCreatedDate?: string;
        CustomerGroupCreatedBy?: string;
        CustomerGroupRevisedDate?: string;
        CustomerGroupRevisedBy?: string;
        CustomerGroupArevisedDate?: string;
        CustomerGroupArevisedBy?: string;
        CustomerGroupTrevisedDate?: string;
        CustomerGroupTrevisedBy?: string;
        CustomerGroupOwnerBranch?: string;
        CustomerGroupSourceBranch?: string;
        CustomerGroupAcctCustSltax?: string;
        CustomerGroupSltaxPcent?: number;
        CustomerGroupAnlys5?: string;
        CustomerGroupAnlys6?: string;
        CustomerGroupAnlys7?: string;
        CustomerGroupAnlys8?: string;
        CustomerGroupAnlys9?: string;
        CustomerGroupAnlys10?: string;
        CustomerGroupAcctTemp?: string;
        CustomerGroupClientCompanyName?: string;
        CustomerGroupClientAddress1?: string;
        CustomerGroupClientAddress2?: string;
        CustomerGroupClientAddress3?: string;
        CustomerGroupClientAddress4?: string;
        CustomerGroupClientAddress5?: string;
        CustomerGroupClientTelNo?: string;
        CustomerGroupClientFaxNo?: string;
        CustomerGroupClientEmailAddress?: string;
        CustomerGroupClientContactPerson?: string;
        CustomerGroupClientContactTitle?: string;
        CustomerGroupClientRemarks?: string;
        CustomerGroupAcctArDeposit?: string;
    }

    export namespace CustomerRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'CustomerNo';
        export const localTextPrefix = 'MasterData.Customer';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const CustomerNo: string;
            export declare const CustomerName: string;
            export declare const Address: string;
            export declare const Address2: string;
            export declare const Address3: string;
            export declare const Address4: string;
            export declare const PostCode: string;
            export declare const TelNo: string;
            export declare const FaxNo: string;
            export declare const Email: string;
            export declare const Suspended: string;
            export declare const CustomerGroup: string;
            export declare const PaymentCcy: string;
            export declare const PayTerms: string;
            export declare const GtaxCode: string;
            export declare const LtaxCode: string;
            export declare const AcctArCust: string;
            export declare const AcctArDisc: string;
            export declare const AcctArAdj: string;
            export declare const AcctSlsTrdisc: string;
            export declare const PriceCode: string;
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
            export declare const AltCustName: string;
            export declare const AltCustAddr: string;
            export declare const AltCustAddr2: string;
            export declare const AltCustAddr3: string;
            export declare const AltCustAddr4: string;
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
            export declare const LastNoteNo: string;
            export declare const Salesman: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const UseAltDesc: string;
            export declare const MaskCode: string;
            export declare const ShortName: string;
            export declare const PendAmtOrd: string;
            export declare const PendAmtInv: string;
            export declare const AcctCustSltax: string;
            export declare const TaxationLv: string;
            export declare const SltaxPcent: string;
            export declare const ShipmentTerms: string;
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
            export declare const UserDefinedField1: string;
            export declare const UserDefinedField2: string;
            export declare const UserDefinedField3: string;
            export declare const UserDefinedField4: string;
            export declare const UserDefinedField5: string;
            export declare const UserDefinedField6: string;
            export declare const UserDefinedField7: string;
            export declare const UserDefinedField8: string;
            export declare const UserDefinedField9: string;
            export declare const UserDefinedField10: string;
            export declare const UserDefinedField11: string;
            export declare const UserDefinedField12: string;
            export declare const UserDefinedField13: string;
            export declare const UserDefinedField14: string;
            export declare const UserDefinedField15: string;
            export declare const UserDefinedField16: string;
            export declare const UserDefinedField17: string;
            export declare const UserDefinedField18: string;
            export declare const UserDefinedField19: string;
            export declare const UserDefinedField20: string;
            export declare const AcctTemp: string;
            export declare const BreakDebitNote: string;
            export declare const ContractorCode: string;
            export declare const PayTermsAr: string;
            export declare const AcctArDeposit: string;
            export declare const CustomerGroupRecnum: string;
            export declare const CustomerGroupDescription: string;
            export declare const CustomerGroupSuspended: string;
            export declare const CustomerGroupAcctArCust: string;
            export declare const CustomerGroupAcctArDisc: string;
            export declare const CustomerGroupAcctArAdj: string;
            export declare const CustomerGroupAcctSlsTrdisc: string;
            export declare const CustomerGroupGtaxCode: string;
            export declare const CustomerGroupLtaxCode: string;
            export declare const CustomerGroupPaymentCcy: string;
            export declare const CustomerGroupPayTerms: string;
            export declare const CustomerGroupPriceCode: string;
            export declare const CustomerGroupUseAltNames: string;
            export declare const CustomerGroupWithCrLimit: string;
            export declare const CustomerGroupCreditLimit: string;
            export declare const CustomerGroupTradeDiscount: string;
            export declare const CustomerGroupAnlys1: string;
            export declare const CustomerGroupAnlys2: string;
            export declare const CustomerGroupAnlys3: string;
            export declare const CustomerGroupAnlys4: string;
            export declare const CustomerGroupCustomerCount: string;
            export declare const CustomerGroupCreatedDate: string;
            export declare const CustomerGroupCreatedBy: string;
            export declare const CustomerGroupRevisedDate: string;
            export declare const CustomerGroupRevisedBy: string;
            export declare const CustomerGroupArevisedDate: string;
            export declare const CustomerGroupArevisedBy: string;
            export declare const CustomerGroupTrevisedDate: string;
            export declare const CustomerGroupTrevisedBy: string;
            export declare const CustomerGroupOwnerBranch: string;
            export declare const CustomerGroupSourceBranch: string;
            export declare const CustomerGroupAcctCustSltax: string;
            export declare const CustomerGroupSltaxPcent: string;
            export declare const CustomerGroupAnlys5: string;
            export declare const CustomerGroupAnlys6: string;
            export declare const CustomerGroupAnlys7: string;
            export declare const CustomerGroupAnlys8: string;
            export declare const CustomerGroupAnlys9: string;
            export declare const CustomerGroupAnlys10: string;
            export declare const CustomerGroupAcctTemp: string;
            export declare const CustomerGroupClientCompanyName: string;
            export declare const CustomerGroupClientAddress1: string;
            export declare const CustomerGroupClientAddress2: string;
            export declare const CustomerGroupClientAddress3: string;
            export declare const CustomerGroupClientAddress4: string;
            export declare const CustomerGroupClientAddress5: string;
            export declare const CustomerGroupClientTelNo: string;
            export declare const CustomerGroupClientFaxNo: string;
            export declare const CustomerGroupClientEmailAddress: string;
            export declare const CustomerGroupClientContactPerson: string;
            export declare const CustomerGroupClientContactTitle: string;
            export declare const CustomerGroupClientRemarks: string;
            export declare const CustomerGroupAcctArDeposit: string;
        }

        [
            'Recnum', 
            'CustomerNo', 
            'CustomerName', 
            'Address', 
            'Address2', 
            'Address3', 
            'Address4', 
            'PostCode', 
            'TelNo', 
            'FaxNo', 
            'Email', 
            'Suspended', 
            'CustomerGroup', 
            'PaymentCcy', 
            'PayTerms', 
            'GtaxCode', 
            'LtaxCode', 
            'AcctArCust', 
            'AcctArDisc', 
            'AcctArAdj', 
            'AcctSlsTrdisc', 
            'PriceCode', 
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
            'AltCustName', 
            'AltCustAddr', 
            'AltCustAddr2', 
            'AltCustAddr3', 
            'AltCustAddr4', 
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
            'LastNoteNo', 
            'Salesman', 
            'OwnerBranch', 
            'SourceBranch', 
            'UseAltDesc', 
            'MaskCode', 
            'ShortName', 
            'PendAmtOrd', 
            'PendAmtInv', 
            'AcctCustSltax', 
            'TaxationLv', 
            'SltaxPcent', 
            'ShipmentTerms', 
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
            'UserDefinedField1', 
            'UserDefinedField2', 
            'UserDefinedField3', 
            'UserDefinedField4', 
            'UserDefinedField5', 
            'UserDefinedField6', 
            'UserDefinedField7', 
            'UserDefinedField8', 
            'UserDefinedField9', 
            'UserDefinedField10', 
            'UserDefinedField11', 
            'UserDefinedField12', 
            'UserDefinedField13', 
            'UserDefinedField14', 
            'UserDefinedField15', 
            'UserDefinedField16', 
            'UserDefinedField17', 
            'UserDefinedField18', 
            'UserDefinedField19', 
            'UserDefinedField20', 
            'AcctTemp', 
            'BreakDebitNote', 
            'ContractorCode', 
            'PayTermsAr', 
            'AcctArDeposit', 
            'CustomerGroupRecnum', 
            'CustomerGroupDescription', 
            'CustomerGroupSuspended', 
            'CustomerGroupAcctArCust', 
            'CustomerGroupAcctArDisc', 
            'CustomerGroupAcctArAdj', 
            'CustomerGroupAcctSlsTrdisc', 
            'CustomerGroupGtaxCode', 
            'CustomerGroupLtaxCode', 
            'CustomerGroupPaymentCcy', 
            'CustomerGroupPayTerms', 
            'CustomerGroupPriceCode', 
            'CustomerGroupUseAltNames', 
            'CustomerGroupWithCrLimit', 
            'CustomerGroupCreditLimit', 
            'CustomerGroupTradeDiscount', 
            'CustomerGroupAnlys1', 
            'CustomerGroupAnlys2', 
            'CustomerGroupAnlys3', 
            'CustomerGroupAnlys4', 
            'CustomerGroupCustomerCount', 
            'CustomerGroupCreatedDate', 
            'CustomerGroupCreatedBy', 
            'CustomerGroupRevisedDate', 
            'CustomerGroupRevisedBy', 
            'CustomerGroupArevisedDate', 
            'CustomerGroupArevisedBy', 
            'CustomerGroupTrevisedDate', 
            'CustomerGroupTrevisedBy', 
            'CustomerGroupOwnerBranch', 
            'CustomerGroupSourceBranch', 
            'CustomerGroupAcctCustSltax', 
            'CustomerGroupSltaxPcent', 
            'CustomerGroupAnlys5', 
            'CustomerGroupAnlys6', 
            'CustomerGroupAnlys7', 
            'CustomerGroupAnlys8', 
            'CustomerGroupAnlys9', 
            'CustomerGroupAnlys10', 
            'CustomerGroupAcctTemp', 
            'CustomerGroupClientCompanyName', 
            'CustomerGroupClientAddress1', 
            'CustomerGroupClientAddress2', 
            'CustomerGroupClientAddress3', 
            'CustomerGroupClientAddress4', 
            'CustomerGroupClientAddress5', 
            'CustomerGroupClientTelNo', 
            'CustomerGroupClientFaxNo', 
            'CustomerGroupClientEmailAddress', 
            'CustomerGroupClientContactPerson', 
            'CustomerGroupClientContactTitle', 
            'CustomerGroupClientRemarks', 
            'CustomerGroupAcctArDeposit'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

