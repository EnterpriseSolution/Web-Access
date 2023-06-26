namespace Matrix.Enterprise {
    export class VendorGroupForm extends Serenity.PrefixedContext {
        static formKey = 'Enterprise.VendorGroup';

    }

    export interface VendorGroupForm {
        VendorGroup: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        UseAltNames: Serenity.BooleanEditor;
        OrderCcy: Serenity.StringEditor;
        PayTerms: Serenity.StringEditor;
        TradeDiscount: Serenity.DecimalEditor;
        VendorCount: Serenity.DecimalEditor;
    }

    [['VendorGroup', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['UseAltNames', () => Serenity.BooleanEditor]
   , ['OrderCcy', () => Serenity.StringEditor]
   , ['PayTerms', () => Serenity.StringEditor]
   , ['TradeDiscount', () => Serenity.DecimalEditor]
   , ['VendorCount', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(VendorGroupForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

