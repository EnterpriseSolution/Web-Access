namespace Matrix.MasterData {
    export class PanelForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Panel';

    }

    export interface PanelForm {
        PanelCode: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Length: Serenity.DecimalEditor;
        Width: Serenity.DecimalEditor;
        DimUom: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        ItemGroup: Serenity.StringEditor;
    }

    [['PanelCode', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Length', () => Serenity.DecimalEditor]
   , ['Width', () => Serenity.DecimalEditor]
   , ['DimUom', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['ItemGroup', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(PanelForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

