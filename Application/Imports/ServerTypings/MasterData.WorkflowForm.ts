namespace Matrix.MasterData {
    export class WorkflowForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Workflow';

    }

    export interface WorkflowForm {
        Workflowname: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        Tablename: Serenity.StringEditor;
        Workflowtype: Serenity.IntegerEditor;
        Suspended: Serenity.BooleanEditor;
        Seqno: Serenity.IntegerEditor;
        Xoml: Serenity.TextAreaEditor;
        Rules: Serenity.TextAreaEditor;
        Published: Serenity.BooleanEditor;
        Publishedxoml: Serenity.TextAreaEditor;
        Publishedrules: Serenity.TextAreaEditor;
    }

    [['Workflowname', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['Tablename', () => Serenity.StringEditor]
   , ['Workflowtype', () => Serenity.IntegerEditor]
   , ['Suspended', () => Serenity.BooleanEditor]
   , ['Seqno', () => Serenity.IntegerEditor]
   , ['Xoml', () => Serenity.TextAreaEditor]
   , ['Rules', () => Serenity.TextAreaEditor]
   , ['Published', () => Serenity.BooleanEditor]
   , ['Publishedxoml', () => Serenity.TextAreaEditor]
   , ['Publishedrules', () => Serenity.TextAreaEditor]
].forEach(x => Object.defineProperty(WorkflowForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

