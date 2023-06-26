namespace Matrix.Purchasing {
    export class PurchaseReturnDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Purchasing.PurchaseReturnDetail';

    }

    export interface PurchaseReturnDetailForm {
        RefNo: Serenity.StringEditor;
        EntryNo: Serenity.DecimalEditor;
        OrderNo: Serenity.StringEditor;
        LineNo: Serenity.DecimalEditor;
        ItemNo: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Uom: Serenity.StringEditor;
        LotSize: Serenity.DecimalEditor;
        QtyBalance: Serenity.DecimalEditor;
        QtyReturned: Serenity.DecimalEditor;
        Price: Serenity.DecimalEditor;
        Ptax: Serenity.DecimalEditor;
        NetPrice: Serenity.DecimalEditor;
        ExtPrice: Serenity.DecimalEditor;
        LdiscPcent: Serenity.DecimalEditor;
        LdiscAmt: Serenity.DecimalEditor;
        AtaxAmt: Serenity.DecimalEditor;
        NetItemAmt: Serenity.DecimalEditor;
        RefundAmt: Serenity.DecimalEditor;
        VariaAmt: Serenity.DecimalEditor;
        LdiscRate: Serenity.DecimalEditor;
        AtaxRate: Serenity.DecimalEditor;
        PriceAmt: Serenity.DecimalEditor;
        PtaxAmt: Serenity.DecimalEditor;
        LocPriceAmt: Serenity.DecimalEditor;
        LocPtaxAmt: Serenity.DecimalEditor;
        LocExtPrice: Serenity.DecimalEditor;
        LocLdiscAmt: Serenity.DecimalEditor;
        LocAtaxAmt: Serenity.DecimalEditor;
        LocItemAmt: Serenity.DecimalEditor;
        LocRefundAmt: Serenity.DecimalEditor;
        LocVariaAmt: Serenity.DecimalEditor;
        AcctPurchase: Serenity.StringEditor;
        AcctLdisc: Serenity.StringEditor;
        AcctPtax: Serenity.StringEditor;
        AcctAtax: Serenity.StringEditor;
        AcctVariance: Serenity.StringEditor;
        CostReturned: Serenity.DecimalEditor;
        Loc: Serenity.StringEditor;
        Anlys3: Serenity.StringEditor;
        Anlys4: Serenity.StringEditor;
        Anlys5: Serenity.StringEditor;
        Anlys6: Serenity.StringEditor;
        Reorder: Serenity.StringEditor;
        Anlys15: Serenity.StringEditor;
        Anlys16: Serenity.StringEditor;
        Anlys17: Serenity.StringEditor;
        Anlys18: Serenity.StringEditor;
        Anlys19: Serenity.StringEditor;
        Anlys20: Serenity.StringEditor;
        InspectionRefNo: Serenity.StringEditor;
        Remarks: Serenity.StringEditor;
    }

    [['RefNo', () => Serenity.StringEditor]
   , ['EntryNo', () => Serenity.DecimalEditor]
   , ['OrderNo', () => Serenity.StringEditor]
   , ['LineNo', () => Serenity.DecimalEditor]
   , ['ItemNo', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Uom', () => Serenity.StringEditor]
   , ['LotSize', () => Serenity.DecimalEditor]
   , ['QtyBalance', () => Serenity.DecimalEditor]
   , ['QtyReturned', () => Serenity.DecimalEditor]
   , ['Price', () => Serenity.DecimalEditor]
   , ['Ptax', () => Serenity.DecimalEditor]
   , ['NetPrice', () => Serenity.DecimalEditor]
   , ['ExtPrice', () => Serenity.DecimalEditor]
   , ['LdiscPcent', () => Serenity.DecimalEditor]
   , ['LdiscAmt', () => Serenity.DecimalEditor]
   , ['AtaxAmt', () => Serenity.DecimalEditor]
   , ['NetItemAmt', () => Serenity.DecimalEditor]
   , ['RefundAmt', () => Serenity.DecimalEditor]
   , ['VariaAmt', () => Serenity.DecimalEditor]
   , ['LdiscRate', () => Serenity.DecimalEditor]
   , ['AtaxRate', () => Serenity.DecimalEditor]
   , ['PriceAmt', () => Serenity.DecimalEditor]
   , ['PtaxAmt', () => Serenity.DecimalEditor]
   , ['LocPriceAmt', () => Serenity.DecimalEditor]
   , ['LocPtaxAmt', () => Serenity.DecimalEditor]
   , ['LocExtPrice', () => Serenity.DecimalEditor]
   , ['LocLdiscAmt', () => Serenity.DecimalEditor]
   , ['LocAtaxAmt', () => Serenity.DecimalEditor]
   , ['LocItemAmt', () => Serenity.DecimalEditor]
   , ['LocRefundAmt', () => Serenity.DecimalEditor]
   , ['LocVariaAmt', () => Serenity.DecimalEditor]
   , ['AcctPurchase', () => Serenity.StringEditor]
   , ['AcctLdisc', () => Serenity.StringEditor]
   , ['AcctPtax', () => Serenity.StringEditor]
   , ['AcctAtax', () => Serenity.StringEditor]
   , ['AcctVariance', () => Serenity.StringEditor]
   , ['CostReturned', () => Serenity.DecimalEditor]
   , ['Loc', () => Serenity.StringEditor]
   , ['Anlys3', () => Serenity.StringEditor]
   , ['Anlys4', () => Serenity.StringEditor]
   , ['Anlys5', () => Serenity.StringEditor]
   , ['Anlys6', () => Serenity.StringEditor]
   , ['Reorder', () => Serenity.StringEditor]
   , ['Anlys15', () => Serenity.StringEditor]
   , ['Anlys16', () => Serenity.StringEditor]
   , ['Anlys17', () => Serenity.StringEditor]
   , ['Anlys18', () => Serenity.StringEditor]
   , ['Anlys19', () => Serenity.StringEditor]
   , ['Anlys20', () => Serenity.StringEditor]
   , ['InspectionRefNo', () => Serenity.StringEditor]
   , ['Remarks', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(PurchaseReturnDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

