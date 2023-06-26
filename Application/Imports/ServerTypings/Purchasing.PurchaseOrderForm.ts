namespace Matrix.Purchasing {
    export class PurchaseOrderForm extends Serenity.PrefixedContext {
        static formKey = 'Purchasing.PurchaseOrder';

    }

    export interface PurchaseOrderForm {
        OrderNo: Serenity.StringEditor;
        VendorNo: Serenity.StringEditor;
        VendorName: Serenity.StringEditor;
        VendorAddress: Serenity.StringEditor;
        VendorAddress2: Serenity.StringEditor;
        VendorAddress3: Serenity.StringEditor;
        VendorAddress4: Serenity.StringEditor;
        ShipTo: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        Address2: Serenity.StringEditor;
        Address3: Serenity.StringEditor;
        Address4: Serenity.StringEditor;
        OrderDate: Serenity.DateEditor;
        DueDate: Serenity.DateEditor;
        SchedDate: Serenity.DateEditor;
        Buyer: Serenity.StringEditor;
        PortLoading: Serenity.StringEditor;
        PortDischarge: Serenity.StringEditor;
        ShipVia: Serenity.StringEditor;
        ShipmentTerms: Serenity.StringEditor;
        Forwarder: Serenity.StringEditor;
        LcNo: Serenity.StringEditor;
        VesselName: Serenity.StringEditor;
        OriginCountry: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        ExchRate: Serenity.DecimalEditor;
        PayTerms: Serenity.StringEditor;
        MultiShip: Serenity.StringEditor;
        MrpExclude: Serenity.StringEditor;
        ItemDetailList: PurchaseOrderDetailEditor;
        TotItemAmt: Serenity.DecimalEditor;
        TotPtaxAmt: Serenity.DecimalEditor;
        TdiscPcent: Serenity.DecimalEditor;
        TotTdiscAmt: Serenity.DecimalEditor;
        TotGtaxAmt: Serenity.DecimalEditor;
        TotLdiscAmt: Serenity.DecimalEditor;
        NetTradeAmt: Serenity.DecimalEditor;
        DpsPcent: Serenity.DecimalEditor;
        TotDpsAmt: Serenity.DecimalEditor;
        DpsFundCode: Serenity.StringEditor;
        DpsDate: Serenity.DateEditor;
        DpsChequeNo: Serenity.StringEditor;
        DpsRefNo: Serenity.StringEditor;
        DpsPayee: Serenity.TextAreaEditor;
        Comments1: Serenity.TextAreaEditor;
        Comments2: Serenity.TextAreaEditor;
        Comments3: Serenity.TextAreaEditor;
        Comments4: Serenity.TextAreaEditor;
    }

    [['OrderNo', () => Serenity.StringEditor]
   , ['VendorNo', () => Serenity.StringEditor]
   , ['VendorName', () => Serenity.StringEditor]
   , ['VendorAddress', () => Serenity.StringEditor]
   , ['VendorAddress2', () => Serenity.StringEditor]
   , ['VendorAddress3', () => Serenity.StringEditor]
   , ['VendorAddress4', () => Serenity.StringEditor]
   , ['ShipTo', () => Serenity.StringEditor]
   , ['Address', () => Serenity.StringEditor]
   , ['Address2', () => Serenity.StringEditor]
   , ['Address3', () => Serenity.StringEditor]
   , ['Address4', () => Serenity.StringEditor]
   , ['OrderDate', () => Serenity.DateEditor]
   , ['DueDate', () => Serenity.DateEditor]
   , ['SchedDate', () => Serenity.DateEditor]
   , ['Buyer', () => Serenity.StringEditor]
   , ['PortLoading', () => Serenity.StringEditor]
   , ['PortDischarge', () => Serenity.StringEditor]
   , ['ShipVia', () => Serenity.StringEditor]
   , ['ShipmentTerms', () => Serenity.StringEditor]
   , ['Forwarder', () => Serenity.StringEditor]
   , ['LcNo', () => Serenity.StringEditor]
   , ['VesselName', () => Serenity.StringEditor]
   , ['OriginCountry', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['ExchRate', () => Serenity.DecimalEditor]
   , ['PayTerms', () => Serenity.StringEditor]
   , ['MultiShip', () => Serenity.StringEditor]
   , ['MrpExclude', () => Serenity.StringEditor]
   , ['ItemDetailList', () => PurchaseOrderDetailEditor]
   , ['TotItemAmt', () => Serenity.DecimalEditor]
   , ['TotPtaxAmt', () => Serenity.DecimalEditor]
   , ['TdiscPcent', () => Serenity.DecimalEditor]
   , ['TotTdiscAmt', () => Serenity.DecimalEditor]
   , ['TotGtaxAmt', () => Serenity.DecimalEditor]
   , ['TotLdiscAmt', () => Serenity.DecimalEditor]
   , ['NetTradeAmt', () => Serenity.DecimalEditor]
   , ['DpsPcent', () => Serenity.DecimalEditor]
   , ['TotDpsAmt', () => Serenity.DecimalEditor]
   , ['DpsFundCode', () => Serenity.StringEditor]
   , ['DpsDate', () => Serenity.DateEditor]
   , ['DpsChequeNo', () => Serenity.StringEditor]
   , ['DpsRefNo', () => Serenity.StringEditor]
   , ['DpsPayee', () => Serenity.TextAreaEditor]
   , ['Comments1', () => Serenity.TextAreaEditor]
   , ['Comments2', () => Serenity.TextAreaEditor]
   , ['Comments3', () => Serenity.TextAreaEditor]
   , ['Comments4', () => Serenity.TextAreaEditor]
].forEach(x => Object.defineProperty(PurchaseOrderForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

