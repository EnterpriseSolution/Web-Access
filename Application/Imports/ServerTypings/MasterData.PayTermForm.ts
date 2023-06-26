namespace Matrix.MasterData {
    export class PayTermForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.PayTerm';

    }

    export interface PayTermForm {
        PayTerms: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        BaseDate: Serenity.StringEditor;
        DueDays: Serenity.DecimalEditor;
        DiscDays: Serenity.DecimalEditor;
        DiscPercent: Serenity.DecimalEditor;
        AdjustCrlimit: Serenity.StringEditor;
        MinDueDays: Serenity.DecimalEditor;
        Phase1PayTerms: Serenity.StringEditor;
        Phase1BaseDate: Serenity.StringEditor;
        Phase1DueDays: Serenity.DecimalEditor;
        Phase1PayPercent: Serenity.DecimalEditor;
        Phase2PayTerms: Serenity.StringEditor;
        Phase2BaseDate: Serenity.StringEditor;
        Phase2DueDays: Serenity.DecimalEditor;
        Phase2PayPercent: Serenity.DecimalEditor;
        Phase3PayTerms: Serenity.StringEditor;
        Phase3BaseDate: Serenity.StringEditor;
        Phase3DueDays: Serenity.DecimalEditor;
        Phase3PayPercent: Serenity.DecimalEditor;
        Phase4PayTerms: Serenity.StringEditor;
        Phase4BaseDate: Serenity.StringEditor;
        Phase4DueDays: Serenity.DecimalEditor;
        Phase4PayPercent: Serenity.DecimalEditor;
        Phase5PayTerms: Serenity.StringEditor;
        Phase5BaseDate: Serenity.StringEditor;
        Phase5DueDays: Serenity.DecimalEditor;
        Phase5PayPercent: Serenity.DecimalEditor;
    }

    [['PayTerms', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['BaseDate', () => Serenity.StringEditor]
   , ['DueDays', () => Serenity.DecimalEditor]
   , ['DiscDays', () => Serenity.DecimalEditor]
   , ['DiscPercent', () => Serenity.DecimalEditor]
   , ['AdjustCrlimit', () => Serenity.StringEditor]
   , ['MinDueDays', () => Serenity.DecimalEditor]
   , ['Phase1PayTerms', () => Serenity.StringEditor]
   , ['Phase1BaseDate', () => Serenity.StringEditor]
   , ['Phase1DueDays', () => Serenity.DecimalEditor]
   , ['Phase1PayPercent', () => Serenity.DecimalEditor]
   , ['Phase2PayTerms', () => Serenity.StringEditor]
   , ['Phase2BaseDate', () => Serenity.StringEditor]
   , ['Phase2DueDays', () => Serenity.DecimalEditor]
   , ['Phase2PayPercent', () => Serenity.DecimalEditor]
   , ['Phase3PayTerms', () => Serenity.StringEditor]
   , ['Phase3BaseDate', () => Serenity.StringEditor]
   , ['Phase3DueDays', () => Serenity.DecimalEditor]
   , ['Phase3PayPercent', () => Serenity.DecimalEditor]
   , ['Phase4PayTerms', () => Serenity.StringEditor]
   , ['Phase4BaseDate', () => Serenity.StringEditor]
   , ['Phase4DueDays', () => Serenity.DecimalEditor]
   , ['Phase4PayPercent', () => Serenity.DecimalEditor]
   , ['Phase5PayTerms', () => Serenity.StringEditor]
   , ['Phase5BaseDate', () => Serenity.StringEditor]
   , ['Phase5DueDays', () => Serenity.DecimalEditor]
   , ['Phase5PayPercent', () => Serenity.DecimalEditor]
].forEach(x => Object.defineProperty(PayTermForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

