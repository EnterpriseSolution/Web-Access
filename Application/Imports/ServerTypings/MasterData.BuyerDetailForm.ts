namespace Matrix.MasterData {
    export class BuyerDetailForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.BuyerDetail';

    }

    export interface BuyerDetailForm {
        BuyerCode: Serenity.StringEditor;
        VendorNo: Serenity.StringEditor;
        VendorName: Serenity.StringEditor;
    }

    [['BuyerCode', () => Serenity.StringEditor]
   , ['VendorNo', () => Serenity.StringEditor]
   , ['VendorName', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(BuyerDetailForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

