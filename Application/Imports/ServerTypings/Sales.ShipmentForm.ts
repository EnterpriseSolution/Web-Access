namespace Matrix.Sales {
    export class ShipmentForm extends Serenity.PrefixedContext {
        static formKey = 'Sales.Shipment';

    }

    export interface ShipmentForm {
        RefNo: Serenity.StringEditor;
        ShipmentDate: Serenity.DateEditor;
        ShipFrom: Serenity.StringEditor;
        CustomerNo: Serenity.StringEditor;
        CustomerName: Serenity.StringEditor;
        CutoffDate: Serenity.DateEditor;
        ShipTo: Serenity.StringEditor;
        Attention: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        Address2: Serenity.StringEditor;
        Address3: Serenity.StringEditor;
        Address4: Serenity.StringEditor;
        TelNo: Serenity.StringEditor;
        FaxNo: Serenity.StringEditor;
        PortLoading: Serenity.StringEditor;
        ShipVia: Serenity.StringEditor;
        VesselName: Serenity.StringEditor;
        LcNo: Serenity.StringEditor;
        PortDischarge: Serenity.StringEditor;
        ShipmentTerms: Serenity.StringEditor;
        Forwarder: Serenity.StringEditor;
        OriginCountry: Serenity.StringEditor;
        Etd: Serenity.DateEditor;
        Eta: Serenity.DateEditor;
        IssueBank: Serenity.StringEditor;
        IssueDate: Serenity.DateEditor;
        Ccy: Serenity.StringEditor;
        ExchRate: Serenity.DecimalEditor;
        PayTerms: Serenity.StringEditor;
        DiscPercent: Serenity.DecimalEditor;
        DiscDays: Serenity.DecimalEditor;
        DueDate: Serenity.DateEditor;
        ExpectedDate: Serenity.DateEditor;
        TotItemAmt: Serenity.DecimalEditor;
        TotTdiscAmt: Serenity.DecimalEditor;
        NetTradeAmt: Serenity.DecimalEditor;
        TotAtaxAmt: Serenity.DecimalEditor;
        TotPtaxAmt: Serenity.DecimalEditor;
        NetPayAmt: Serenity.DecimalEditor;
        DpsCover: Serenity.DecimalEditor;
        DpsApplied: Serenity.DecimalEditor;
        NetBalAmt: Serenity.DecimalEditor;
        ManualShipmentDetail: Serenity.BooleanEditor;
        RefCompanyCode: Serenity.StringEditor;
        DetailList: ShipmentDetailEditor;
        RefGrnNo: Serenity.StringEditor;
        LcName: Serenity.StringEditor;
        Comments1: Serenity.StringEditor;
        Comments2: Serenity.StringEditor;
        Comments3: Serenity.StringEditor;
        Comments4: Serenity.StringEditor;
        Comments5: Serenity.StringEditor;
        Comments6: Serenity.StringEditor;
        Comments7: Serenity.StringEditor;
        Comments8: Serenity.StringEditor;
    }

    [['RefNo', () => Serenity.StringEditor]
   , ['ShipmentDate', () => Serenity.DateEditor]
   , ['ShipFrom', () => Serenity.StringEditor]
   , ['CustomerNo', () => Serenity.StringEditor]
   , ['CustomerName', () => Serenity.StringEditor]
   , ['CutoffDate', () => Serenity.DateEditor]
   , ['ShipTo', () => Serenity.StringEditor]
   , ['Attention', () => Serenity.StringEditor]
   , ['Address', () => Serenity.StringEditor]
   , ['Address2', () => Serenity.StringEditor]
   , ['Address3', () => Serenity.StringEditor]
   , ['Address4', () => Serenity.StringEditor]
   , ['TelNo', () => Serenity.StringEditor]
   , ['FaxNo', () => Serenity.StringEditor]
   , ['PortLoading', () => Serenity.StringEditor]
   , ['ShipVia', () => Serenity.StringEditor]
   , ['VesselName', () => Serenity.StringEditor]
   , ['LcNo', () => Serenity.StringEditor]
   , ['PortDischarge', () => Serenity.StringEditor]
   , ['ShipmentTerms', () => Serenity.StringEditor]
   , ['Forwarder', () => Serenity.StringEditor]
   , ['OriginCountry', () => Serenity.StringEditor]
   , ['Etd', () => Serenity.DateEditor]
   , ['Eta', () => Serenity.DateEditor]
   , ['IssueBank', () => Serenity.StringEditor]
   , ['IssueDate', () => Serenity.DateEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['ExchRate', () => Serenity.DecimalEditor]
   , ['PayTerms', () => Serenity.StringEditor]
   , ['DiscPercent', () => Serenity.DecimalEditor]
   , ['DiscDays', () => Serenity.DecimalEditor]
   , ['DueDate', () => Serenity.DateEditor]
   , ['ExpectedDate', () => Serenity.DateEditor]
   , ['TotItemAmt', () => Serenity.DecimalEditor]
   , ['TotTdiscAmt', () => Serenity.DecimalEditor]
   , ['NetTradeAmt', () => Serenity.DecimalEditor]
   , ['TotAtaxAmt', () => Serenity.DecimalEditor]
   , ['TotPtaxAmt', () => Serenity.DecimalEditor]
   , ['NetPayAmt', () => Serenity.DecimalEditor]
   , ['DpsCover', () => Serenity.DecimalEditor]
   , ['DpsApplied', () => Serenity.DecimalEditor]
   , ['NetBalAmt', () => Serenity.DecimalEditor]
   , ['ManualShipmentDetail', () => Serenity.BooleanEditor]
   , ['RefCompanyCode', () => Serenity.StringEditor]
   , ['DetailList', () => ShipmentDetailEditor]
   , ['RefGrnNo', () => Serenity.StringEditor]
   , ['LcName', () => Serenity.StringEditor]
   , ['Comments1', () => Serenity.StringEditor]
   , ['Comments2', () => Serenity.StringEditor]
   , ['Comments3', () => Serenity.StringEditor]
   , ['Comments4', () => Serenity.StringEditor]
   , ['Comments5', () => Serenity.StringEditor]
   , ['Comments6', () => Serenity.StringEditor]
   , ['Comments7', () => Serenity.StringEditor]
   , ['Comments8', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(ShipmentForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

