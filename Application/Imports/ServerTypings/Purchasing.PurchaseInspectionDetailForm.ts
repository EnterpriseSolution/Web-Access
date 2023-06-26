namespace Matrix.Purchasing {
    export class PurchaseInspectionDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Purchasing.PurchaseInspectionDetail';

    }

    export interface PurchaseInspectionDetailForm {
        RefNo: Serenity.StringEditor;
        EntryNo: Serenity.DecimalEditor;
        OrderNo: Serenity.StringEditor;
        LineNo: Serenity.DecimalEditor;
        ItemNo: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Uom: Serenity.StringEditor;
        LotSize: Serenity.DecimalEditor;
        QtyReceived: Serenity.DecimalEditor;
        QtyPending: Serenity.DecimalEditor;
        QtyInspected: Serenity.DecimalEditor;
        QtyRejected: Serenity.DecimalEditor;
        Reorder: Serenity.StringEditor;
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
        LocPriceAmt: Serenity.DecimalEditor;
        LocPtaxAmt: Serenity.DecimalEditor;
        LocExtPrice: Serenity.DecimalEditor;
        LocLdiscAmt: Serenity.DecimalEditor;
        LocAtaxAmt: Serenity.DecimalEditor;
        LocItemAmt: Serenity.DecimalEditor;
        GrnNo: Serenity.StringEditor;
        Loc: Serenity.StringEditor;
        InspectionDate: Serenity.DateEditor;
        Posted: Serenity.StringEditor;
        LogNo: Serenity.DecimalEditor;
        VendorNo: Serenity.StringEditor;
        AcctPurchase: Serenity.StringEditor;
        AcctLdisc: Serenity.StringEditor;
        AcctGtax: Serenity.StringEditor;
        CostAccepted: Serenity.DecimalEditor;
        CostRejected: Serenity.DecimalEditor;
        Remarks: Serenity.StringEditor;
        ExtDescription: Serenity.StringEditor;
        AdjustRcvd: Serenity.StringEditor;
        Anlys3: Serenity.StringEditor;
        Anlys4: Serenity.StringEditor;
        Anlys5: Serenity.StringEditor;
        Anlys6: Serenity.StringEditor;
        Anlys15: Serenity.StringEditor;
        Anlys16: Serenity.StringEditor;
        Anlys17: Serenity.StringEditor;
        Anlys18: Serenity.StringEditor;
        Anlys19: Serenity.StringEditor;
        Anlys20: Serenity.StringEditor;
    }

    [['RefNo', () => Serenity.StringEditor]
   , ['EntryNo', () => Serenity.DecimalEditor]
   , ['OrderNo', () => Serenity.StringEditor]
   , ['LineNo', () => Serenity.DecimalEditor]
   , ['ItemNo', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Uom', () => Serenity.StringEditor]
   , ['LotSize', () => Serenity.DecimalEditor]
   , ['QtyReceived', () => Serenity.DecimalEditor]
   , ['QtyPending', () => Serenity.DecimalEditor]
   , ['QtyInspected', () => Serenity.DecimalEditor]
   , ['QtyRejected', () => Serenity.DecimalEditor]
   , ['Reorder', () => Serenity.StringEditor]
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
   , ['LocPriceAmt', () => Serenity.DecimalEditor]
   , ['LocPtaxAmt', () => Serenity.DecimalEditor]
   , ['LocExtPrice', () => Serenity.DecimalEditor]
   , ['LocLdiscAmt', () => Serenity.DecimalEditor]
   , ['LocAtaxAmt', () => Serenity.DecimalEditor]
   , ['LocItemAmt', () => Serenity.DecimalEditor]
   , ['GrnNo', () => Serenity.StringEditor]
   , ['Loc', () => Serenity.StringEditor]
   , ['InspectionDate', () => Serenity.DateEditor]
   , ['Posted', () => Serenity.StringEditor]
   , ['LogNo', () => Serenity.DecimalEditor]
   , ['VendorNo', () => Serenity.StringEditor]
   , ['AcctPurchase', () => Serenity.StringEditor]
   , ['AcctLdisc', () => Serenity.StringEditor]
   , ['AcctGtax', () => Serenity.StringEditor]
   , ['CostAccepted', () => Serenity.DecimalEditor]
   , ['CostRejected', () => Serenity.DecimalEditor]
   , ['Remarks', () => Serenity.StringEditor]
   , ['ExtDescription', () => Serenity.StringEditor]
   , ['AdjustRcvd', () => Serenity.StringEditor]
   , ['Anlys3', () => Serenity.StringEditor]
   , ['Anlys4', () => Serenity.StringEditor]
   , ['Anlys5', () => Serenity.StringEditor]
   , ['Anlys6', () => Serenity.StringEditor]
   , ['Anlys15', () => Serenity.StringEditor]
   , ['Anlys16', () => Serenity.StringEditor]
   , ['Anlys17', () => Serenity.StringEditor]
   , ['Anlys18', () => Serenity.StringEditor]
   , ['Anlys19', () => Serenity.StringEditor]
   , ['Anlys20', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(PurchaseInspectionDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

