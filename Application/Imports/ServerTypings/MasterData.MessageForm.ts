namespace Matrix.MasterData {
    export class MessageForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.Message';

    }

    export interface MessageForm {
        CreatedBy: Serenity.StringEditor;
        CreatedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        Summary: Serenity.StringEditor;
        Detail: Serenity.StringEditor;
        ParentId: Serenity.IntegerEditor;
        PostStatus: Serenity.StringEditor;
        ReqId: Serenity.IntegerEditor;
        MsgTo: Serenity.StringEditor;
        ReqmsgParentId: Serenity.DecimalEditor;
        InstanceNo: Serenity.IntegerEditor;
        HtmlText: Serenity.StringEditor;
        WithAttachment: Serenity.BooleanEditor;
    }

    [['CreatedBy', () => Serenity.StringEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['Summary', () => Serenity.StringEditor]
   , ['Detail', () => Serenity.StringEditor]
   , ['ParentId', () => Serenity.IntegerEditor]
   , ['PostStatus', () => Serenity.StringEditor]
   , ['ReqId', () => Serenity.IntegerEditor]
   , ['MsgTo', () => Serenity.StringEditor]
   , ['ReqmsgParentId', () => Serenity.DecimalEditor]
   , ['InstanceNo', () => Serenity.IntegerEditor]
   , ['HtmlText', () => Serenity.StringEditor]
   , ['WithAttachment', () => Serenity.BooleanEditor]
].forEach(x => Object.defineProperty(MessageForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

