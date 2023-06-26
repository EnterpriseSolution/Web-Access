namespace Matrix.Purchasing {
    export class GrnOrderDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Purchasing.GrnOrderDetail';

    }

    export interface GrnOrderDetailForm {
        GrnNo: Serenity.StringEditor;
        EntryNo: Serenity.DecimalEditor;
        OrderNo: Serenity.StringEditor;
        LineNo: Serenity.DecimalEditor;
        ItemNo: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Uom: Serenity.StringEditor;
        LotSize: Serenity.DecimalEditor;
        QtyBalance: Serenity.DecimalEditor;
        QtyDue: Serenity.DecimalEditor;
        QtyReceived: Serenity.DecimalEditor;
        Price: Serenity.DecimalEditor;
        Ptax: Serenity.DecimalEditor;
        NetPrice: Serenity.DecimalEditor;
        ExtPrice: Serenity.DecimalEditor;
        LdiscPcent: Serenity.DecimalEditor;
        LdiscAmt: Serenity.DecimalEditor;
        AtaxAmt: Serenity.DecimalEditor;
        NetItemAmt: Serenity.DecimalEditor;
        PriceAmt: Serenity.DecimalEditor;
        PtaxAmt: Serenity.DecimalEditor;
        AtaxRate: Serenity.DecimalEditor;
        LdiscRate: Serenity.DecimalEditor;
        AtaxAmtCpd: Serenity.DecimalEditor;
        LdiscAmtCpd: Serenity.DecimalEditor;
        LocPriceAmt: Serenity.DecimalEditor;
        LocPtaxAmt: Serenity.DecimalEditor;
        LocExtPrice: Serenity.DecimalEditor;
        LocLdiscAmt: Serenity.DecimalEditor;
        LocAtaxAmt: Serenity.DecimalEditor;
        LocItemAmt: Serenity.DecimalEditor;
        Anlys1: Serenity.StringEditor;
        Anlys2: Serenity.StringEditor;
        Anlys3: Serenity.StringEditor;
        Anlys4: Serenity.StringEditor;
        Anlys5: Serenity.StringEditor;
        Anlys6: Serenity.StringEditor;
        Posted: Serenity.StringEditor;
        LogNo: Serenity.DecimalEditor;
        ReceivedDate: Serenity.DateEditor;
        VendorNo: Serenity.StringEditor;
        ShipTo: Serenity.StringEditor;
        Inspected: Serenity.StringEditor;
        QtyInspected: Serenity.DecimalEditor;
        QtyAccepted: Serenity.DecimalEditor;
        QtyRejected: Serenity.DecimalEditor;
        Returned: Serenity.StringEditor;
        QcHold: Serenity.StringEditor;
        AcctPurchase: Serenity.StringEditor;
        AcctLdisc: Serenity.StringEditor;
        AcctPtax: Serenity.StringEditor;
        AcctAtax: Serenity.StringEditor;
        ItemTaxCode: Serenity.StringEditor;
        QtyReturned: Serenity.DecimalEditor;
        RetPriceAmt: Serenity.DecimalEditor;
        RetPtaxAmt: Serenity.DecimalEditor;
        RetExtPrice: Serenity.DecimalEditor;
        RetLdiscAmt: Serenity.DecimalEditor;
        RetAtaxAmt: Serenity.DecimalEditor;
        RetItemAmt: Serenity.DecimalEditor;
        LretPriceAmt: Serenity.DecimalEditor;
        LretPtaxAmt: Serenity.DecimalEditor;
        LretExtPrice: Serenity.DecimalEditor;
        LretLdiscAmt: Serenity.DecimalEditor;
        LretAtaxAmt: Serenity.DecimalEditor;
        LretItemAmt: Serenity.DecimalEditor;
        CostAccepted: Serenity.DecimalEditor;
        CostRejected: Serenity.DecimalEditor;
        CostReturned: Serenity.DecimalEditor;
        ExtDescription: Serenity.StringEditor;
        Loc: Serenity.StringEditor;
        PutaxPcent: Serenity.DecimalEditor;
        PutaxAmt: Serenity.DecimalEditor;
        LocPutaxAmt: Serenity.DecimalEditor;
        InspectPriority: Serenity.DecimalEditor;
        QcHoldLoc: Serenity.StringEditor;
        JobNo: Serenity.StringEditor;
        Anlys15: Serenity.StringEditor;
        Anlys16: Serenity.StringEditor;
        Anlys17: Serenity.StringEditor;
        Anlys18: Serenity.StringEditor;
        Anlys19: Serenity.StringEditor;
        Anlys20: Serenity.StringEditor;
        MaterialCost: Serenity.DecimalEditor;
        VendorItemNo: Serenity.StringEditor;
    }

    [['GrnNo', () => Serenity.StringEditor]
   , ['EntryNo', () => Serenity.DecimalEditor]
   , ['OrderNo', () => Serenity.StringEditor]
   , ['LineNo', () => Serenity.DecimalEditor]
   , ['ItemNo', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Uom', () => Serenity.StringEditor]
   , ['LotSize', () => Serenity.DecimalEditor]
   , ['QtyBalance', () => Serenity.DecimalEditor]
   , ['QtyDue', () => Serenity.DecimalEditor]
   , ['QtyReceived', () => Serenity.DecimalEditor]
   , ['Price', () => Serenity.DecimalEditor]
   , ['Ptax', () => Serenity.DecimalEditor]
   , ['NetPrice', () => Serenity.DecimalEditor]
   , ['ExtPrice', () => Serenity.DecimalEditor]
   , ['LdiscPcent', () => Serenity.DecimalEditor]
   , ['LdiscAmt', () => Serenity.DecimalEditor]
   , ['AtaxAmt', () => Serenity.DecimalEditor]
   , ['NetItemAmt', () => Serenity.DecimalEditor]
   , ['PriceAmt', () => Serenity.DecimalEditor]
   , ['PtaxAmt', () => Serenity.DecimalEditor]
   , ['AtaxRate', () => Serenity.DecimalEditor]
   , ['LdiscRate', () => Serenity.DecimalEditor]
   , ['AtaxAmtCpd', () => Serenity.DecimalEditor]
   , ['LdiscAmtCpd', () => Serenity.DecimalEditor]
   , ['LocPriceAmt', () => Serenity.DecimalEditor]
   , ['LocPtaxAmt', () => Serenity.DecimalEditor]
   , ['LocExtPrice', () => Serenity.DecimalEditor]
   , ['LocLdiscAmt', () => Serenity.DecimalEditor]
   , ['LocAtaxAmt', () => Serenity.DecimalEditor]
   , ['LocItemAmt', () => Serenity.DecimalEditor]
   , ['Anlys1', () => Serenity.StringEditor]
   , ['Anlys2', () => Serenity.StringEditor]
   , ['Anlys3', () => Serenity.StringEditor]
   , ['Anlys4', () => Serenity.StringEditor]
   , ['Anlys5', () => Serenity.StringEditor]
   , ['Anlys6', () => Serenity.StringEditor]
   , ['Posted', () => Serenity.StringEditor]
   , ['LogNo', () => Serenity.DecimalEditor]
   , ['ReceivedDate', () => Serenity.DateEditor]
   , ['VendorNo', () => Serenity.StringEditor]
   , ['ShipTo', () => Serenity.StringEditor]
   , ['Inspected', () => Serenity.StringEditor]
   , ['QtyInspected', () => Serenity.DecimalEditor]
   , ['QtyAccepted', () => Serenity.DecimalEditor]
   , ['QtyRejected', () => Serenity.DecimalEditor]
   , ['Returned', () => Serenity.StringEditor]
   , ['QcHold', () => Serenity.StringEditor]
   , ['AcctPurchase', () => Serenity.StringEditor]
   , ['AcctLdisc', () => Serenity.StringEditor]
   , ['AcctPtax', () => Serenity.StringEditor]
   , ['AcctAtax', () => Serenity.StringEditor]
   , ['ItemTaxCode', () => Serenity.StringEditor]
   , ['QtyReturned', () => Serenity.DecimalEditor]
   , ['RetPriceAmt', () => Serenity.DecimalEditor]
   , ['RetPtaxAmt', () => Serenity.DecimalEditor]
   , ['RetExtPrice', () => Serenity.DecimalEditor]
   , ['RetLdiscAmt', () => Serenity.DecimalEditor]
   , ['RetAtaxAmt', () => Serenity.DecimalEditor]
   , ['RetItemAmt', () => Serenity.DecimalEditor]
   , ['LretPriceAmt', () => Serenity.DecimalEditor]
   , ['LretPtaxAmt', () => Serenity.DecimalEditor]
   , ['LretExtPrice', () => Serenity.DecimalEditor]
   , ['LretLdiscAmt', () => Serenity.DecimalEditor]
   , ['LretAtaxAmt', () => Serenity.DecimalEditor]
   , ['LretItemAmt', () => Serenity.DecimalEditor]
   , ['CostAccepted', () => Serenity.DecimalEditor]
   , ['CostRejected', () => Serenity.DecimalEditor]
   , ['CostReturned', () => Serenity.DecimalEditor]
   , ['ExtDescription', () => Serenity.StringEditor]
   , ['Loc', () => Serenity.StringEditor]
   , ['PutaxPcent', () => Serenity.DecimalEditor]
   , ['PutaxAmt', () => Serenity.DecimalEditor]
   , ['LocPutaxAmt', () => Serenity.DecimalEditor]
   , ['InspectPriority', () => Serenity.DecimalEditor]
   , ['QcHoldLoc', () => Serenity.StringEditor]
   , ['JobNo', () => Serenity.StringEditor]
   , ['Anlys15', () => Serenity.StringEditor]
   , ['Anlys16', () => Serenity.StringEditor]
   , ['Anlys17', () => Serenity.StringEditor]
   , ['Anlys18', () => Serenity.StringEditor]
   , ['Anlys19', () => Serenity.StringEditor]
   , ['Anlys20', () => Serenity.StringEditor]
   , ['MaterialCost', () => Serenity.DecimalEditor]
   , ['VendorItemNo', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(GrnOrderDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

