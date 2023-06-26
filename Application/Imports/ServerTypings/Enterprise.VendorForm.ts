namespace Matrix.Enterprise {
    export class VendorForm extends Serenity.PrefixedContext {
        static formKey = 'Enterprise.Vendor';

    }

    export interface VendorForm {
        VendorNo: Serenity.StringEditor;
        VendorName: Serenity.StringEditor;
        VendorGroup: Serenity.StringEditor;
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
        AltVendorName: Serenity.StringEditor;
        AltAddress: Serenity.StringEditor;
        AltAddress2: Serenity.StringEditor;
        AltAddress3: Serenity.StringEditor;
        AltAddress4: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        UseAltNames: Serenity.StringEditor;
        UseAltDesc: Serenity.StringEditor;
        OrderCcy: Serenity.StringEditor;
        PayTerms: Serenity.StringEditor;
        BuyerCode: Serenity.StringEditor;
        LeadTime: Serenity.DecimalEditor;
        PutaxPcent: Serenity.DecimalEditor;
        TaxationLv: Serenity.StringEditor;
        BankName: Serenity.StringEditor;
        BankAcctNo: Serenity.StringEditor;
        RefCompanyCode: Serenity.StringEditor;
        RefCustomerNo: Serenity.StringEditor;
        RefIntegrateComments: Serenity.BooleanEditor;
        RefIntegrateAnlys: Serenity.BooleanEditor;
    }

    [['VendorNo', () => Serenity.StringEditor]
   , ['VendorName', () => Serenity.StringEditor]
   , ['VendorGroup', () => Serenity.StringEditor]
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
   , ['AltVendorName', () => Serenity.StringEditor]
   , ['AltAddress', () => Serenity.StringEditor]
   , ['AltAddress2', () => Serenity.StringEditor]
   , ['AltAddress3', () => Serenity.StringEditor]
   , ['AltAddress4', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['UseAltNames', () => Serenity.StringEditor]
   , ['UseAltDesc', () => Serenity.StringEditor]
   , ['OrderCcy', () => Serenity.StringEditor]
   , ['PayTerms', () => Serenity.StringEditor]
   , ['BuyerCode', () => Serenity.StringEditor]
   , ['LeadTime', () => Serenity.DecimalEditor]
   , ['PutaxPcent', () => Serenity.DecimalEditor]
   , ['TaxationLv', () => Serenity.StringEditor]
   , ['BankName', () => Serenity.StringEditor]
   , ['BankAcctNo', () => Serenity.StringEditor]
   , ['RefCompanyCode', () => Serenity.StringEditor]
   , ['RefCustomerNo', () => Serenity.StringEditor]
   , ['RefIntegrateComments', () => Serenity.BooleanEditor]
   , ['RefIntegrateAnlys', () => Serenity.BooleanEditor]
].forEach(x => Object.defineProperty(VendorForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

