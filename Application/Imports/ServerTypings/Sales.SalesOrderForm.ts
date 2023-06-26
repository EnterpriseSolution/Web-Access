namespace Matrix.Sales {
    export class SalesOrderForm extends Serenity.PrefixedContext {
        static formKey = 'Sales.SalesOrder';

    }

    export interface SalesOrderForm {
        OrderNo: Serenity.StringEditor;
        CustomerNo: Serenity.StringEditor;
        CustomerName: Serenity.StringEditor;
        CustomerPo: Serenity.StringEditor;
        QuoRefNo: Serenity.StringEditor;
        OrderDate: Serenity.DateEditor;
        DueDate: Serenity.DateEditor;
        SchedDate: Serenity.DateEditor;
        PortLoading: Serenity.StringEditor;
        ShipVia: Serenity.StringEditor;
        VesselName: Serenity.StringEditor;
        LcNo: Serenity.StringEditor;
        PortDischarge: Serenity.StringEditor;
        ShipmentTerms: Serenity.StringEditor;
        Forwarder: Serenity.StringEditor;
        OriginCountry: Serenity.StringEditor;
        Salesman: Serenity.StringEditor;
        PriceCode: Serenity.StringEditor;
        ShipFrom: Serenity.StringEditor;
        ShipTo: Serenity.StringEditor;
        Attention: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        Address2: Serenity.StringEditor;
        Address3: Serenity.StringEditor;
        Address4: Serenity.StringEditor;
        TelNo: Serenity.StringEditor;
        FaxNo: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        ExchRate: Serenity.DecimalEditor;
        PayTerms: Serenity.StringEditor;
        VendorNo: Serenity.StringEditor;
        PoNo: Serenity.StringEditor;
        PoPayTerms: Serenity.StringEditor;
        PoShipTo: Serenity.StringEditor;
        PoBuyer: Serenity.StringEditor;
        MultiShip: Serenity.StringEditor;
        AutoResv: Serenity.StringEditor;
        AutoPo: Serenity.StringEditor;
        AutoJob: Serenity.StringEditor;
        DetailList: SalesOrderDetailEditor;
        TotItemAmt: Serenity.DecimalEditor;
        TotPtaxAmt: Serenity.DecimalEditor;
        TotGtaxAmt: Serenity.DecimalEditor;
        TotTdiscAmt: Serenity.DecimalEditor;
        TdiscPcent: Serenity.DecimalEditor;
        TotLdiscAmt: Serenity.DecimalEditor;
        DpsPcent: Serenity.DecimalEditor;
        TotDpsAmt: Serenity.DecimalEditor;
        DpsReceiptNo: Serenity.StringEditor;
        DpsRcptDate: Serenity.DateEditor;
        DpsFundCode: Serenity.StringEditor;
        DpsReference: Serenity.StringEditor;
        TotChgsAmt: Serenity.DecimalEditor;
        NetPayAmt: Serenity.DecimalEditor;
        NetBalAmt: Serenity.DecimalEditor;
        Comments1: Serenity.StringEditor;
        Comments2: Serenity.StringEditor;
        Comments3: Serenity.StringEditor;
        Comments4: Serenity.StringEditor;
        Comments5: Serenity.StringEditor;
        Comments6: Serenity.StringEditor;
        Comments7: Serenity.StringEditor;
        Comments8: Serenity.StringEditor;
    }

    [['OrderNo', () => Serenity.StringEditor]
   , ['CustomerNo', () => Serenity.StringEditor]
   , ['CustomerName', () => Serenity.StringEditor]
   , ['CustomerPo', () => Serenity.StringEditor]
   , ['QuoRefNo', () => Serenity.StringEditor]
   , ['OrderDate', () => Serenity.DateEditor]
   , ['DueDate', () => Serenity.DateEditor]
   , ['SchedDate', () => Serenity.DateEditor]
   , ['PortLoading', () => Serenity.StringEditor]
   , ['ShipVia', () => Serenity.StringEditor]
   , ['VesselName', () => Serenity.StringEditor]
   , ['LcNo', () => Serenity.StringEditor]
   , ['PortDischarge', () => Serenity.StringEditor]
   , ['ShipmentTerms', () => Serenity.StringEditor]
   , ['Forwarder', () => Serenity.StringEditor]
   , ['OriginCountry', () => Serenity.StringEditor]
   , ['Salesman', () => Serenity.StringEditor]
   , ['PriceCode', () => Serenity.StringEditor]
   , ['ShipFrom', () => Serenity.StringEditor]
   , ['ShipTo', () => Serenity.StringEditor]
   , ['Attention', () => Serenity.StringEditor]
   , ['Address', () => Serenity.StringEditor]
   , ['Address2', () => Serenity.StringEditor]
   , ['Address3', () => Serenity.StringEditor]
   , ['Address4', () => Serenity.StringEditor]
   , ['TelNo', () => Serenity.StringEditor]
   , ['FaxNo', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['ExchRate', () => Serenity.DecimalEditor]
   , ['PayTerms', () => Serenity.StringEditor]
   , ['VendorNo', () => Serenity.StringEditor]
   , ['PoNo', () => Serenity.StringEditor]
   , ['PoPayTerms', () => Serenity.StringEditor]
   , ['PoShipTo', () => Serenity.StringEditor]
   , ['PoBuyer', () => Serenity.StringEditor]
   , ['MultiShip', () => Serenity.StringEditor]
   , ['AutoResv', () => Serenity.StringEditor]
   , ['AutoPo', () => Serenity.StringEditor]
   , ['AutoJob', () => Serenity.StringEditor]
   , ['DetailList', () => SalesOrderDetailEditor]
   , ['TotItemAmt', () => Serenity.DecimalEditor]
   , ['TotPtaxAmt', () => Serenity.DecimalEditor]
   , ['TotGtaxAmt', () => Serenity.DecimalEditor]
   , ['TotTdiscAmt', () => Serenity.DecimalEditor]
   , ['TdiscPcent', () => Serenity.DecimalEditor]
   , ['TotLdiscAmt', () => Serenity.DecimalEditor]
   , ['DpsPcent', () => Serenity.DecimalEditor]
   , ['TotDpsAmt', () => Serenity.DecimalEditor]
   , ['DpsReceiptNo', () => Serenity.StringEditor]
   , ['DpsRcptDate', () => Serenity.DateEditor]
   , ['DpsFundCode', () => Serenity.StringEditor]
   , ['DpsReference', () => Serenity.StringEditor]
   , ['TotChgsAmt', () => Serenity.DecimalEditor]
   , ['NetPayAmt', () => Serenity.DecimalEditor]
   , ['NetBalAmt', () => Serenity.DecimalEditor]
   , ['Comments1', () => Serenity.StringEditor]
   , ['Comments2', () => Serenity.StringEditor]
   , ['Comments3', () => Serenity.StringEditor]
   , ['Comments4', () => Serenity.StringEditor]
   , ['Comments5', () => Serenity.StringEditor]
   , ['Comments6', () => Serenity.StringEditor]
   , ['Comments7', () => Serenity.StringEditor]
   , ['Comments8', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(SalesOrderForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

