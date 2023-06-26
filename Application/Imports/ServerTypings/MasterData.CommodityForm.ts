namespace Matrix.MasterData {
    export class CommodityForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Commodity';

    }

    export interface CommodityForm {
        CustomProdCode: Serenity.StringEditor;
        CustomSerialNo: Serenity.StringEditor;
        CustomProdDesc: Serenity.StringEditor;
        CustomProdNo: Serenity.StringEditor;
        CustomEng: Serenity.StringEditor;
        CustomEngNo: Serenity.StringEditor;
        CustomMeasUom: Serenity.StringEditor;
        CustomCcy: Serenity.StringEditor;
        CustomPrice: Serenity.DecimalEditor;
        CustomExempt: Serenity.StringEditor;
        CustomFee: Serenity.DecimalEditor;
        CustomRemark: Serenity.TextAreaEditor;
    }

    [['CustomProdCode', () => Serenity.StringEditor]
   , ['CustomSerialNo', () => Serenity.StringEditor]
   , ['CustomProdDesc', () => Serenity.StringEditor]
   , ['CustomProdNo', () => Serenity.StringEditor]
   , ['CustomEng', () => Serenity.StringEditor]
   , ['CustomEngNo', () => Serenity.StringEditor]
   , ['CustomMeasUom', () => Serenity.StringEditor]
   , ['CustomCcy', () => Serenity.StringEditor]
   , ['CustomPrice', () => Serenity.DecimalEditor]
   , ['CustomExempt', () => Serenity.StringEditor]
   , ['CustomFee', () => Serenity.DecimalEditor]
   , ['CustomRemark', () => Serenity.TextAreaEditor]
].forEach(x => Object.defineProperty(CommodityForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

