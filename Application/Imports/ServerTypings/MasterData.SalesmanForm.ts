namespace Matrix.MasterData {
    export class SalesmanForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Salesman';

    }

    export interface SalesmanForm {
        Salesman: Serenity.StringEditor;
        SalesmanName: Serenity.StringEditor;
        Suspended: Serenity.BooleanEditor;
        Rank: Serenity.DecimalEditor;
        EmpNo: Serenity.StringEditor;
        Supervisor: Serenity.StringEditor;
    }

    [['Salesman', () => Serenity.StringEditor]
   , ['SalesmanName', () => Serenity.StringEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['Rank', () => Serenity.DecimalEditor]
   , ['EmpNo', () => Serenity.StringEditor]
   , ['Supervisor', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(SalesmanForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

