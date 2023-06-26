namespace Matrix.MasterData {
    export class AttachmentFileTypeForm extends Serenity.PrefixedContext {
        static formKey = 'MasterData.AttachmentFileType';

    }

    export interface AttachmentFileTypeForm {
        FileType: Serenity.StringEditor;
        Description: Serenity.StringEditor;
        ExePath: Serenity.StringEditor;
        CreatedBy: Serenity.StringEditor;
        CreatedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        Suspended: Serenity.StringEditor;
    }

    [['FileType', () => Serenity.StringEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['ExePath', () => Serenity.StringEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['Suspended', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(AttachmentFileTypeForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

