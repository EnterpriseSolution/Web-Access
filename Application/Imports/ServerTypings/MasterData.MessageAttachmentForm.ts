namespace Matrix.MasterData {
    export class MessageAttachmentForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.MessageAttachment';

    }

    export interface MessageAttachmentForm {
        LineNo: Serenity.IntegerEditor;
        AttachmentType: Serenity.IntegerEditor;
        FileName: Serenity.StringEditor;
        FileContent: Serenity.StringEditor;
        FileSize: Serenity.IntegerEditor;
    }

    [['LineNo', () => Serenity.IntegerEditor]
   , ['AttachmentType', () => Serenity.IntegerEditor]
   , ['FileName', () => Serenity.StringEditor]
   , ['FileContent', () => Serenity.StringEditor]
   , ['FileSize', () => Serenity.IntegerEditor]
].forEach(x => Object.defineProperty(MessageAttachmentForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

