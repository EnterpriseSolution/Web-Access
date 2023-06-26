namespace Matrix.Purchasing {
    export class PurchaseInspectionForm extends Serenity.PrefixedContext {
        static formKey = 'Purchasing.PurchaseInspection';

    }

    export interface PurchaseInspectionForm {
        RefNo: Serenity.StringEditor;
        InspectionDate: Serenity.DateEditor;
        InspectedBy: Serenity.StringEditor;
        Loc: Serenity.StringEditor;
        GrnNo: Serenity.StringEditor;
        VendorNo: Serenity.StringEditor;
        VendorName: Serenity.StringEditor;
        ReceivedDate: Serenity.DateEditor;
        DetailList: Sales.QuotationDetailEditor;
        ReOrderNo: Serenity.StringEditor;
        ReOrderDate: Serenity.DateEditor;
        ReDueDate: Serenity.DateEditor;
        ReSchedDate: Serenity.DateEditor;
        ReShipTo: Serenity.StringEditor;
        ReShipVia: Serenity.StringEditor;
        ReShipTerms: Serenity.StringEditor;
        Comments1: Serenity.StringEditor;
        Comments2: Serenity.StringEditor;
        Comments3: Serenity.StringEditor;
        Comments4: Serenity.StringEditor;
    }

    [['RefNo', () => Serenity.StringEditor]
   , ['InspectionDate', () => Serenity.DateEditor]
   , ['InspectedBy', () => Serenity.StringEditor]
   , ['Loc', () => Serenity.StringEditor]
   , ['GrnNo', () => Serenity.StringEditor]
   , ['VendorNo', () => Serenity.StringEditor]
   , ['VendorName', () => Serenity.StringEditor]
   , ['ReceivedDate', () => Serenity.DateEditor]
   , ['DetailList', () => Sales.QuotationDetailEditor]
   , ['ReOrderNo', () => Serenity.StringEditor]
   , ['ReOrderDate', () => Serenity.DateEditor]
   , ['ReDueDate', () => Serenity.DateEditor]
   , ['ReSchedDate', () => Serenity.DateEditor]
   , ['ReShipTo', () => Serenity.StringEditor]
   , ['ReShipVia', () => Serenity.StringEditor]
   , ['ReShipTerms', () => Serenity.StringEditor]
   , ['Comments1', () => Serenity.StringEditor]
   , ['Comments2', () => Serenity.StringEditor]
   , ['Comments3', () => Serenity.StringEditor]
   , ['Comments4', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(PurchaseInspectionForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

