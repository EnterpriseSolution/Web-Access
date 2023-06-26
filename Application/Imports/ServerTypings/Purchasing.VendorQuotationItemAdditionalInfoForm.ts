namespace Matrix.Purchasing {
    export class VendorQuotationItemAdditionalInfoForm extends Serenity.PrefixedContext {
        static formKey = 'Purchasing.VendorQuotationItemAdditionalInfo';

    }

    export interface VendorQuotationItemAdditionalInfoForm {
        OrderNo: Serenity.StringEditor;
        LineNo: Serenity.IntegerEditor;
        EntryNo: Serenity.IntegerEditor;
        Caption: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        BitmapPath: Serenity.StringEditor;
    }

    [['OrderNo', () => Serenity.StringEditor]
   , ['LineNo', () => Serenity.IntegerEditor]
   , ['EntryNo', () => Serenity.IntegerEditor]
   , ['Caption', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['BitmapPath', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(VendorQuotationItemAdditionalInfoForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

