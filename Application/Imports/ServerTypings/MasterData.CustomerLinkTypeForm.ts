namespace Matrix.MasterData {
    export class CustomerLinkTypeForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.CustomerLinkType';

    }

    export interface CustomerLinkTypeForm {
        LinkType: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
    }

    [['LinkType', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
].forEach(x => Object.defineProperty(CustomerLinkTypeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

