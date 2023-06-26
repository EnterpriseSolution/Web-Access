namespace Matrix.Purchasing {
    export class PurchaseRequisitionDetailForm extends Serenity.PrefixedContext {
        static formKey = 'Purchasing.PurchaseRequisitionDetail';

    }

    export interface PurchaseRequisitionDetailForm {
        ReqNo: Serenity.StringEditor;
        LineNo: Serenity.DecimalEditor;
        ItemNo: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Uom: Serenity.StringEditor;
        LotSize: Serenity.DecimalEditor;
        Qty: Serenity.DecimalEditor;
        ExtDescription: Serenity.StringEditor;
        QtyAllocated: Serenity.DecimalEditor;
        Remark: Serenity.StringEditor;
        QtyPreAllocated: Serenity.DecimalEditor;
    }

    [['ReqNo', () => Serenity.StringEditor]
   , ['LineNo', () => Serenity.DecimalEditor]
   , ['ItemNo', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Uom', () => Serenity.StringEditor]
   , ['LotSize', () => Serenity.DecimalEditor]
   , ['Qty', () => Serenity.DecimalEditor]
   , ['ExtDescription', () => Serenity.StringEditor]
   , ['QtyAllocated', () => Serenity.DecimalEditor]
   , ['Remark', () => Serenity.StringEditor]
   , ['QtyPreAllocated', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(PurchaseRequisitionDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

