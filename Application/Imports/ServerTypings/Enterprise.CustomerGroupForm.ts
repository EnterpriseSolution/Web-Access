namespace Matrix.Enterprise {
    export class CustomerGroupForm extends Serenity.PrefixedContext {
        static formKey = 'Enterprise.CustomerGroup';

    }

    export interface CustomerGroupForm {
        CustomerGroup: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Suspended: Serenity.StringEditor;
        UseAltNames: Serenity.BooleanEditor;
        WithCrLimit: Serenity.BooleanEditor;
        PaymentCcy: Serenity.StringEditor;
        PayTerms: Serenity.StringEditor;
        PriceCode: Serenity.StringEditor;
        CreditLimit: Serenity.DecimalEditor;
        TradeDiscount: Serenity.DecimalEditor;
        CustomerCount: Serenity.DecimalEditor;
    }

    [['CustomerGroup', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.StringEditor]
   , ['UseAltNames', () => Serenity.BooleanEditor]
   , ['WithCrLimit', () => Serenity.BooleanEditor]
   , ['PaymentCcy', () => Serenity.StringEditor]
   , ['PayTerms', () => Serenity.StringEditor]
   , ['PriceCode', () => Serenity.StringEditor]
   , ['CreditLimit', () => Serenity.DecimalEditor]
   , ['TradeDiscount', () => Serenity.DecimalEditor]
   , ['CustomerCount', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(CustomerGroupForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

