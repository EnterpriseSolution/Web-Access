namespace Matrix.MasterData {
    export class CustomerForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Customer';

    }

    export interface CustomerForm {
        CustomerNo: Serenity.StringEditor;
        CustomerName: Serenity.StringEditor;
        CustomerGroup: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        Address2: Serenity.StringEditor;
        Address3: Serenity.StringEditor;
        Address4: Serenity.StringEditor;
        PostCode: Serenity.StringEditor;
        TelNo: Serenity.StringEditor;
        FaxNo: Serenity.StringEditor;
        Email: Serenity.StringEditor;
        ContactPerson: Serenity.StringEditor;
        ContactTitle: Serenity.StringEditor;
        AltCustName: Serenity.StringEditor;
        AltCustAddr: Serenity.StringEditor;
        AltCustAddr2: Serenity.StringEditor;
        AltCustAddr3: Serenity.StringEditor;
        AltCustAddr4: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        UseAltNames: Serenity.StringEditor;
        UseAltDesc: Serenity.StringEditor;
        WithCrLimit: Serenity.StringEditor;
        Salesman: Serenity.StringEditor;
        PaymentCcy: Serenity.StringEditor;
        PayTerms: Serenity.StringEditor;
        PriceCode: Serenity.StringEditor;
        CreditLimit: Serenity.DecimalEditor;
        ShipmentTerms: Serenity.StringEditor;
        TaxationLv: Serenity.StringEditor;
        SltaxPcent: Serenity.DecimalEditor;
        AcctCustSltax: Serenity.StringEditor;
        AcctArCust: Serenity.StringEditor;
        AcctArDisc: Serenity.StringEditor;
        AcctArAdj: Serenity.StringEditor;
        AcctSlsTrdisc: Serenity.StringEditor;
        AcctTemp: Serenity.StringEditor;
        AcctArDeposit: Serenity.StringEditor;
        Anlys1: Serenity.StringEditor;
        Anlys2: Serenity.StringEditor;
        Anlys3: Serenity.StringEditor;
        Anlys4: Serenity.StringEditor;
        Anlys5: Serenity.StringEditor;
        Anlys6: Serenity.StringEditor;
        Anlys7: Serenity.StringEditor;
        Anlys8: Serenity.StringEditor;
        Anlys9: Serenity.StringEditor;
        Anlys10: Serenity.StringEditor;
        BreakDebitNote: Serenity.BooleanEditor;
        ContractorCode: Serenity.StringEditor;
        PayTermsAr: Serenity.StringEditor;
    }

    [['CustomerNo', () => Serenity.StringEditor]
   , ['CustomerName', () => Serenity.StringEditor]
   , ['CustomerGroup', () => Serenity.StringEditor]
   , ['Address', () => Serenity.StringEditor]
   , ['Address2', () => Serenity.StringEditor]
   , ['Address3', () => Serenity.StringEditor]
   , ['Address4', () => Serenity.StringEditor]
   , ['PostCode', () => Serenity.StringEditor]
   , ['TelNo', () => Serenity.StringEditor]
   , ['FaxNo', () => Serenity.StringEditor]
   , ['Email', () => Serenity.StringEditor]
   , ['ContactPerson', () => Serenity.StringEditor]
   , ['ContactTitle', () => Serenity.StringEditor]
   , ['AltCustName', () => Serenity.StringEditor]
   , ['AltCustAddr', () => Serenity.StringEditor]
   , ['AltCustAddr2', () => Serenity.StringEditor]
   , ['AltCustAddr3', () => Serenity.StringEditor]
   , ['AltCustAddr4', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['UseAltNames', () => Serenity.StringEditor]
   , ['UseAltDesc', () => Serenity.StringEditor]
   , ['WithCrLimit', () => Serenity.StringEditor]
   , ['Salesman', () => Serenity.StringEditor]
   , ['PaymentCcy', () => Serenity.StringEditor]
   , ['PayTerms', () => Serenity.StringEditor]
   , ['PriceCode', () => Serenity.StringEditor]
   , ['CreditLimit', () => Serenity.DecimalEditor]
   , ['ShipmentTerms', () => Serenity.StringEditor]
   , ['TaxationLv', () => Serenity.StringEditor]
   , ['SltaxPcent', () => Serenity.DecimalEditor]
   , ['AcctCustSltax', () => Serenity.StringEditor]
   , ['AcctArCust', () => Serenity.StringEditor]
   , ['AcctArDisc', () => Serenity.StringEditor]
   , ['AcctArAdj', () => Serenity.StringEditor]
   , ['AcctSlsTrdisc', () => Serenity.StringEditor]
   , ['AcctTemp', () => Serenity.StringEditor]
   , ['AcctArDeposit', () => Serenity.StringEditor]
   , ['Anlys1', () => Serenity.StringEditor]
   , ['Anlys2', () => Serenity.StringEditor]
   , ['Anlys3', () => Serenity.StringEditor]
   , ['Anlys4', () => Serenity.StringEditor]
   , ['Anlys5', () => Serenity.StringEditor]
   , ['Anlys6', () => Serenity.StringEditor]
   , ['Anlys7', () => Serenity.StringEditor]
   , ['Anlys8', () => Serenity.StringEditor]
   , ['Anlys9', () => Serenity.StringEditor]
   , ['Anlys10', () => Serenity.StringEditor]
   , ['BreakDebitNote', () => Serenity.BooleanEditor]
   , ['ContractorCode', () => Serenity.StringEditor]
   , ['PayTermsAr', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(CustomerForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

