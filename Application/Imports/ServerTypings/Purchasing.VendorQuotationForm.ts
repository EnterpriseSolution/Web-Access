namespace Matrix.Purchasing {
    export class VendorQuotationForm extends Serenity.PrefixedContext {
        static formKey = 'Purchasing.VendorQuotation';

    }

    export interface VendorQuotationForm {
        OrderNo: Serenity.StringEditor;
        VendorNo: Serenity.StringEditor;
        VendorName: Serenity.StringEditor;
        VendorRefNo: Serenity.StringEditor;
        VendorAddress: Serenity.StringEditor;
        VendorAddress2: Serenity.StringEditor;
        VendorAddress3: Serenity.StringEditor;
        VendorAddress4: Serenity.StringEditor;
        OrderDate: Serenity.DateEditor;
        DueDate: Serenity.DateEditor;
        SchedDate: Serenity.DateEditor;
        ValidUntil: Serenity.DateEditor;
        ShipTo: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        Address2: Serenity.StringEditor;
        Address3: Serenity.StringEditor;
        Address4: Serenity.StringEditor;
        Buyer: Serenity.StringEditor;
        MultiShip: Serenity.StringEditor;
        PortLoading: Serenity.StringEditor;
        PortDischarge: Serenity.StringEditor;
        ShipVia: Serenity.StringEditor;
        ShipmentTerms: Serenity.StringEditor;
        VesselName: Serenity.StringEditor;
        Forwarder: Serenity.StringEditor;
        LcNo: Serenity.StringEditor;
        OriginCountry: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        ExchRate: Serenity.DecimalEditor;
        PayTerms: Serenity.StringEditor;
        PutaxType: Serenity.StringEditor;
        ComputeTax: Serenity.StringEditor;
        TotItemAmt: Serenity.DecimalEditor;
        TdiscPcent: Serenity.DecimalEditor;
        TotTdiscAmt: Serenity.DecimalEditor;
        NetTradeAmt: Serenity.DecimalEditor;
        Comments1: Serenity.TextAreaEditor;
        Comments2: Serenity.TextAreaEditor;
        Comments3: Serenity.TextAreaEditor;
        Comments4: Serenity.TextAreaEditor;
    }

    [['OrderNo', () => Serenity.StringEditor]
   , ['VendorNo', () => Serenity.StringEditor]
   , ['VendorName', () => Serenity.StringEditor]
   , ['VendorRefNo', () => Serenity.StringEditor]
   , ['VendorAddress', () => Serenity.StringEditor]
   , ['VendorAddress2', () => Serenity.StringEditor]
   , ['VendorAddress3', () => Serenity.StringEditor]
   , ['VendorAddress4', () => Serenity.StringEditor]
   , ['OrderDate', () => Serenity.DateEditor]
   , ['DueDate', () => Serenity.DateEditor]
   , ['SchedDate', () => Serenity.DateEditor]
   , ['ValidUntil', () => Serenity.DateEditor]
   , ['ShipTo', () => Serenity.StringEditor]
   , ['Address', () => Serenity.StringEditor]
   , ['Address2', () => Serenity.StringEditor]
   , ['Address3', () => Serenity.StringEditor]
   , ['Address4', () => Serenity.StringEditor]
   , ['Buyer', () => Serenity.StringEditor]
   , ['MultiShip', () => Serenity.StringEditor]
   , ['PortLoading', () => Serenity.StringEditor]
   , ['PortDischarge', () => Serenity.StringEditor]
   , ['ShipVia', () => Serenity.StringEditor]
   , ['ShipmentTerms', () => Serenity.StringEditor]
   , ['VesselName', () => Serenity.StringEditor]
   , ['Forwarder', () => Serenity.StringEditor]
   , ['LcNo', () => Serenity.StringEditor]
   , ['OriginCountry', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['ExchRate', () => Serenity.DecimalEditor]
   , ['PayTerms', () => Serenity.StringEditor]
   , ['PutaxType', () => Serenity.StringEditor]
   , ['ComputeTax', () => Serenity.StringEditor]
   , ['TotItemAmt', () => Serenity.DecimalEditor]
   , ['TdiscPcent', () => Serenity.DecimalEditor]
   , ['TotTdiscAmt', () => Serenity.DecimalEditor]
   , ['NetTradeAmt', () => Serenity.DecimalEditor]
   , ['Comments1', () => Serenity.TextAreaEditor]
   , ['Comments2', () => Serenity.TextAreaEditor]
   , ['Comments3', () => Serenity.TextAreaEditor]
   , ['Comments4', () => Serenity.TextAreaEditor]
].forEach(x => Object.defineProperty(VendorQuotationForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

