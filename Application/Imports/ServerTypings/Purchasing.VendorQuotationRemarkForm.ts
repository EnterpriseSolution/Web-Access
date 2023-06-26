namespace Matrix.Purchasing {
    export class VendorQuotationRemarkForm extends Serenity.PrefixedContext {
        static formKey = 'Purchasing.VendorQuotationRemark';

    }

    export interface VendorQuotationRemarkForm {
        OrderNo: Serenity.StringEditor;
        TextNo: Serenity.IntegerEditor;
        TextType: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Remarks: Serenity.StringEditor;
    }

    [['OrderNo', () => Serenity.StringEditor]
   , ['TextNo', () => Serenity.IntegerEditor]
   , ['TextType', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Remarks', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(VendorQuotationRemarkForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

