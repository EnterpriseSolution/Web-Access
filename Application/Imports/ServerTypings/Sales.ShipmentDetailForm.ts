﻿namespace Matrix.Sales {
    export class ShipmentDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Sales.ShipmentDetail';

    }

    export interface ShipmentDetailForm {
        RefNo: Serenity.StringEditor;
        EntryNo: Serenity.DecimalEditor;
        Selected: Serenity.StringEditor;
        OrderNo: Serenity.StringEditor;
        LineNo: Serenity.DecimalEditor;
        ItemNo: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Uom: Serenity.StringEditor;
        LotSize: Serenity.DecimalEditor;
        Configurable: Serenity.StringEditor;
        QtyBalance: Serenity.DecimalEditor;
        QtyDue: Serenity.DecimalEditor;
        QtyShipped: Serenity.DecimalEditor;
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
        LdiscRate: Serenity.DecimalEditor;
        AtaxRate: Serenity.DecimalEditor;
        LdiscAmtCpd: Serenity.DecimalEditor;
        AtaxAmtCpd: Serenity.DecimalEditor;
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
        Returned: Serenity.StringEditor;
        ShipmentDate: Serenity.DateEditor;
        CustomerNo: Serenity.StringEditor;
        ShipFrom: Serenity.StringEditor;
        CommisType: Serenity.StringEditor;
        CommisRefNo: Serenity.StringEditor;
        CustItemNo: Serenity.StringEditor;
        AcctSales: Serenity.StringEditor;
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
        QtyPacked: Serenity.DecimalEditor;
        CostReturned: Serenity.DecimalEditor;
        StdAssort: Serenity.StringEditor;
        ExtDescription: Serenity.StringEditor;
        VendorPack: Serenity.StringEditor;
        SltaxPcent: Serenity.DecimalEditor;
        SltaxAmt: Serenity.DecimalEditor;
        LocSltaxAmt: Serenity.DecimalEditor;
        AcctSltax: Serenity.StringEditor;
        MarkupPcent: Serenity.DecimalEditor;
        Markup: Serenity.DecimalEditor;
        Anlys15: Serenity.StringEditor;
        Anlys16: Serenity.StringEditor;
        Anlys17: Serenity.StringEditor;
        Anlys18: Serenity.StringEditor;
        Anlys19: Serenity.StringEditor;
        Anlys20: Serenity.StringEditor;
        LotSizeCost: Serenity.DecimalEditor;
    }

    [['RefNo', () => Serenity.StringEditor]
   , ['EntryNo', () => Serenity.DecimalEditor]
   , ['Selected', () => Serenity.StringEditor]
   , ['OrderNo', () => Serenity.StringEditor]
   , ['LineNo', () => Serenity.DecimalEditor]
   , ['ItemNo', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Uom', () => Serenity.StringEditor]
   , ['LotSize', () => Serenity.DecimalEditor]
   , ['Configurable', () => Serenity.StringEditor]
   , ['QtyBalance', () => Serenity.DecimalEditor]
   , ['QtyDue', () => Serenity.DecimalEditor]
   , ['QtyShipped', () => Serenity.DecimalEditor]
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
   , ['LdiscRate', () => Serenity.DecimalEditor]
   , ['AtaxRate', () => Serenity.DecimalEditor]
   , ['LdiscAmtCpd', () => Serenity.DecimalEditor]
   , ['AtaxAmtCpd', () => Serenity.DecimalEditor]
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
   , ['Returned', () => Serenity.StringEditor]
   , ['ShipmentDate', () => Serenity.DateEditor]
   , ['CustomerNo', () => Serenity.StringEditor]
   , ['ShipFrom', () => Serenity.StringEditor]
   , ['CommisType', () => Serenity.StringEditor]
   , ['CommisRefNo', () => Serenity.StringEditor]
   , ['CustItemNo', () => Serenity.StringEditor]
   , ['AcctSales', () => Serenity.StringEditor]
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
   , ['QtyPacked', () => Serenity.DecimalEditor]
   , ['CostReturned', () => Serenity.DecimalEditor]
   , ['StdAssort', () => Serenity.StringEditor]
   , ['ExtDescription', () => Serenity.StringEditor]
   , ['VendorPack', () => Serenity.StringEditor]
   , ['SltaxPcent', () => Serenity.DecimalEditor]
   , ['SltaxAmt', () => Serenity.DecimalEditor]
   , ['LocSltaxAmt', () => Serenity.DecimalEditor]
   , ['AcctSltax', () => Serenity.StringEditor]
   , ['MarkupPcent', () => Serenity.DecimalEditor]
   , ['Markup', () => Serenity.DecimalEditor]
   , ['Anlys15', () => Serenity.StringEditor]
   , ['Anlys16', () => Serenity.StringEditor]
   , ['Anlys17', () => Serenity.StringEditor]
   , ['Anlys18', () => Serenity.StringEditor]
   , ['Anlys19', () => Serenity.StringEditor]
   , ['Anlys20', () => Serenity.StringEditor]
   , ['LotSizeCost', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(ShipmentDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

