namespace Matrix.Enterprise {
    export class ItemGroupForm extends Serenity.PrefixedContext {
        static formKey = 'Enterprise.ItemGroup';

    }

    export interface ItemGroupForm {
        ItemGroup: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        Product: Serenity.BooleanEditor;
        Material: Serenity.BooleanEditor;
        Inspected: Serenity.BooleanEditor;
        AllocMethod: Serenity.EnumEditor;
        MakeOrBuy: Serenity.BooleanEditor;
        ScrapRate: Serenity.DecimalEditor;
    }

    [['ItemGroup', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['Product', () => Serenity.BooleanEditor]
   , ['Material', () => Serenity.BooleanEditor]
   , ['Inspected', () => Serenity.BooleanEditor]
   , ['AllocMethod', () => Serenity.EnumEditor]
   , ['MakeOrBuy', () => Serenity.BooleanEditor]
   , ['ScrapRate', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(ItemGroupForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

