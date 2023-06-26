namespace Matrix.EnterpriseSys {
    export class ReportDialogForm extends Serenity.PrefixedContext {
        static formKey = 'EnterpriseSys.ReportDialog';

    }

    export interface ReportDialogForm {
        Description: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        FilterBySalesmanCode: Serenity.BooleanEditor;
        FilterByBuyerCode: Serenity.BooleanEditor;
        ReportType: Serenity.IntegerEditor;
        DataSource: Serenity.IntegerEditor;
        ItemDetailList: ReportDialogOptionEditor;
    }

    [['Description', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['FilterBySalesmanCode', () => Serenity.BooleanEditor]
   , ['FilterByBuyerCode', () => Serenity.BooleanEditor]
   , ['ReportType', () => Serenity.IntegerEditor]
   , ['DataSource', () => Serenity.IntegerEditor]
   , ['ItemDetailList', () => ReportDialogOptionEditor]
].forEach(x => Object.defineProperty(ReportDialogForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

