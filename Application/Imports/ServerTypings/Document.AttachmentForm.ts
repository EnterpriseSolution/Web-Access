namespace Matrix.Document {
    export class AttachmentForm extends Serenity.PrefixedContext {
        static formKey = 'Document.Attachment';

    }

    export interface AttachmentForm {
        MasterTable: Serenity.StringEditor;
        MasterKey: Serenity.DecimalEditor;
        FileType: Serenity.StringEditor;
        FilePath: Serenity.StringEditor;
        CreatedBy: Serenity.StringEditor;
        CreatedDate: Serenity.DateEditor;
        RevisedBy: Serenity.StringEditor;
        RevisedDate: Serenity.DateEditor;
        Description: Serenity.StringEditor;
        KeySegment1: Serenity.StringEditor;
        KeySegment2: Serenity.StringEditor;
        KeySegment3: Serenity.StringEditor;
        KeySegment4: Serenity.StringEditor;
        KeySegment5: Serenity.StringEditor;
        AttmSize: Serenity.DecimalEditor;
        AttmFile: Serenity.StringEditor;
        UploadedBy: Serenity.StringEditor;
        UploadedDate: Serenity.DateEditor;
        Md5Hash: Serenity.StringEditor;
    }

    [['MasterTable', () => Serenity.StringEditor]
   , ['MasterKey', () => Serenity.DecimalEditor]
   , ['FileType', () => Serenity.StringEditor]
   , ['FilePath', () => Serenity.StringEditor]
   , ['CreatedBy', () => Serenity.StringEditor]
   , ['CreatedDate', () => Serenity.DateEditor]
   , ['RevisedBy', () => Serenity.StringEditor]
   , ['RevisedDate', () => Serenity.DateEditor]
   , ['Description', () => Serenity.StringEditor]
   , ['KeySegment1', () => Serenity.StringEditor]
   , ['KeySegment2', () => Serenity.StringEditor]
   , ['KeySegment3', () => Serenity.StringEditor]
   , ['KeySegment4', () => Serenity.StringEditor]
   , ['KeySegment5', () => Serenity.StringEditor]
   , ['AttmSize', () => Serenity.DecimalEditor]
   , ['AttmFile', () => Serenity.StringEditor]
   , ['UploadedBy', () => Serenity.StringEditor]
   , ['UploadedDate', () => Serenity.DateEditor]
   , ['Md5Hash', () => Serenity.StringEditor]
].forEach(x => Object.defineProperty(AttachmentForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

