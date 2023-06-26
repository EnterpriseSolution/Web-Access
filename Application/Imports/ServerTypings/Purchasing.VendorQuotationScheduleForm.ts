namespace Matrix.Purchasing {
    export class VendorQuotationScheduleForm extends Serenity.PrefixedContext {
        static formKey = 'Purchasing.VendorQuotationSchedule';

    }

    export interface VendorQuotationScheduleForm {
        OrderNo: Serenity.StringEditor;
        LineNo: Serenity.IntegerEditor;
        ShipNo: Serenity.IntegerEditor;
        DueDate: Serenity.DateEditor;
        SchedDate: Serenity.DateEditor;
        ShipVia: Serenity.StringEditor;
        ShipmentTerms: Serenity.StringEditor;
        Qty: Serenity.DecimalEditor;
        ItemNo: Serenity.StringEditor;
        ShipTo: Serenity.StringEditor;
        Uom: Serenity.StringEditor;
        LotSize: Serenity.DecimalEditor;
        VendorNo: Serenity.StringEditor;
        Buyer: Serenity.StringEditor;
        VendorName: Serenity.StringEditor;
    }

    [['OrderNo', () => Serenity.StringEditor]
   , ['LineNo', () => Serenity.IntegerEditor]
   , ['ShipNo', () => Serenity.IntegerEditor]
   , ['DueDate', () => Serenity.DateEditor]
   , ['SchedDate', () => Serenity.DateEditor]
   , ['ShipVia', () => Serenity.StringEditor]
   , ['ShipmentTerms', () => Serenity.StringEditor]
   , ['Qty', () => Serenity.DecimalEditor]
   , ['ItemNo', () => Serenity.StringEditor]
   , ['ShipTo', () => Serenity.StringEditor]
   , ['Uom', () => Serenity.StringEditor]
   , ['LotSize', () => Serenity.DecimalEditor]
   , ['VendorNo', () => Serenity.StringEditor]
   , ['Buyer', () => Serenity.StringEditor]
   , ['VendorName', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(VendorQuotationScheduleForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

