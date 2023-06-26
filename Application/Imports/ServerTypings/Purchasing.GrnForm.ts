namespace Matrix.Purchasing {
    export class GrnForm extends Serenity.PrefixedContext {
        static formKey = 'Purchasing.Grn';

    }

    export interface GrnForm {
        GrnNo: Serenity.StringEditor;
        ReceivedDate: Serenity.DateEditor;
        ShipTo: Serenity.StringEditor;
        InspectPriority: Serenity.DecimalEditor;
        VendorNo: Serenity.StringEditor;
        VendorName: Serenity.StringEditor;
        CutoffDate: Serenity.DateEditor;
        DoNo: Serenity.StringEditor;
        InvoiceNo: Serenity.StringEditor;
        Ccy: Serenity.StringEditor;
        ExchRate: Serenity.DecimalEditor;
        PayTerms: Serenity.StringEditor;
        DiscPcent: Serenity.DecimalEditor;
        DiscDays: Serenity.DecimalEditor;
        DueDays: Serenity.DecimalEditor;
        TotItemAmt: Serenity.DecimalEditor;
        TotPtaxAmt: Serenity.DecimalEditor;
        TotTdiscAmt: Serenity.DecimalEditor;
        NetTradeAmt: Serenity.DecimalEditor;
        TotChgsAmt: Serenity.DecimalEditor;
        NetPayAmt: Serenity.DecimalEditor;
        DpsCover: Serenity.DecimalEditor;
        DpsApplied: Serenity.DecimalEditor;
        NetBalAmt: Serenity.DecimalEditor;
        OrderDetailList: GrnOrderDetailEditor;
        EntryMethod: Serenity.StringEditor;
        WithInvoice: Serenity.StringEditor;
        Posted: Serenity.StringEditor;
        Inspected: Serenity.StringEditor;
        Returned: Serenity.StringEditor;
        DiscountDate: Serenity.DateEditor;
        DueDate: Serenity.DateEditor;
        ComputeTax: Serenity.StringEditor;
        Comments1: Serenity.TextAreaEditor;
        Comments2: Serenity.TextAreaEditor;
        Comments3: Serenity.TextAreaEditor;
        Comments4: Serenity.TextAreaEditor;
    }

    [['GrnNo', () => Serenity.StringEditor]
   , ['ReceivedDate', () => Serenity.DateEditor]
   , ['ShipTo', () => Serenity.StringEditor]
   , ['InspectPriority', () => Serenity.DecimalEditor]
   , ['VendorNo', () => Serenity.StringEditor]
   , ['VendorName', () => Serenity.StringEditor]
   , ['CutoffDate', () => Serenity.DateEditor]
   , ['DoNo', () => Serenity.StringEditor]
   , ['InvoiceNo', () => Serenity.StringEditor]
   , ['Ccy', () => Serenity.StringEditor]
   , ['ExchRate', () => Serenity.DecimalEditor]
   , ['PayTerms', () => Serenity.StringEditor]
   , ['DiscPcent', () => Serenity.DecimalEditor]
   , ['DiscDays', () => Serenity.DecimalEditor]
   , ['DueDays', () => Serenity.DecimalEditor]
   , ['TotItemAmt', () => Serenity.DecimalEditor]
   , ['TotPtaxAmt', () => Serenity.DecimalEditor]
   , ['TotTdiscAmt', () => Serenity.DecimalEditor]
   , ['NetTradeAmt', () => Serenity.DecimalEditor]
   , ['TotChgsAmt', () => Serenity.DecimalEditor]
   , ['NetPayAmt', () => Serenity.DecimalEditor]
   , ['DpsCover', () => Serenity.DecimalEditor]
   , ['DpsApplied', () => Serenity.DecimalEditor]
   , ['NetBalAmt', () => Serenity.DecimalEditor]
   , ['OrderDetailList', () => GrnOrderDetailEditor]
   , ['EntryMethod', () => Serenity.StringEditor]
   , ['WithInvoice', () => Serenity.StringEditor]
   , ['Posted', () => Serenity.StringEditor]
   , ['Inspected', () => Serenity.StringEditor]
   , ['Returned', () => Serenity.StringEditor]
   , ['DiscountDate', () => Serenity.DateEditor]
   , ['DueDate', () => Serenity.DateEditor]
   , ['ComputeTax', () => Serenity.StringEditor]
   , ['Comments1', () => Serenity.TextAreaEditor]
   , ['Comments2', () => Serenity.TextAreaEditor]
   , ['Comments3', () => Serenity.TextAreaEditor]
   , ['Comments4', () => Serenity.TextAreaEditor]
].forEach(x => Object.defineProperty(GrnForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

