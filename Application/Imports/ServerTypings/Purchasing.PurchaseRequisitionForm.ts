namespace Matrix.Purchasing {
    export class PurchaseRequisitionForm extends Serenity.PrefixedContext {
        static formKey = 'Purchasing.PurchaseRequisition';

    }

    export interface PurchaseRequisitionForm {
        ReqNo: Serenity.StringEditor;
        RequestBy: Serenity.StringEditor;
        RequestDate: Serenity.DateEditor;
        DueDate: Serenity.DateEditor;
        RemindDate: Serenity.DateEditor;
        Reminded: Serenity.StringEditor;
        Recipients: Serenity.StringEditor;
        DetailList: PurchaseRequisitionDetailEditor;
        Comments1: Serenity.TextAreaEditor;
        Comments2: Serenity.TextAreaEditor;
        Comments3: Serenity.TextAreaEditor;
        Comments4: Serenity.TextAreaEditor;
    }

    [['ReqNo', () => Serenity.StringEditor]
   , ['RequestBy', () => Serenity.StringEditor]
   , ['RequestDate', () => Serenity.DateEditor]
   , ['DueDate', () => Serenity.DateEditor]
   , ['RemindDate', () => Serenity.DateEditor]
   , ['Reminded', () => Serenity.StringEditor]
   , ['Recipients', () => Serenity.StringEditor]
   , ['DetailList', () => PurchaseRequisitionDetailEditor]
   , ['Comments1', () => Serenity.TextAreaEditor]
   , ['Comments2', () => Serenity.TextAreaEditor]
   , ['Comments3', () => Serenity.TextAreaEditor]
   , ['Comments4', () => Serenity.TextAreaEditor]
].forEach(x => Object.defineProperty(PurchaseRequisitionForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

