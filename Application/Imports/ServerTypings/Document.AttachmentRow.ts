namespace Matrix.Document {
    export interface AttachmentRow {
        Recnum?: number;
        MasterTable?: string;
        MasterKey?: number;
        FileType?: string;
        FilePath?: string;
        CreatedBy?: string;
        CreatedDate?: string;
        RevisedBy?: string;
        RevisedDate?: string;
        Description?: string;
        KeySegment1?: string;
        KeySegment2?: string;
        KeySegment3?: string;
        KeySegment4?: string;
        KeySegment5?: string;
        AttmSize?: number;
        AttmFile?: number[];
        UploadedBy?: string;
        UploadedDate?: string;
        Md5Hash?: string;
    }

    export namespace AttachmentRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'MasterTable';
        export const localTextPrefix = 'Document.Attachment';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const MasterTable: string;
            export declare const MasterKey: string;
            export declare const FileType: string;
            export declare const FilePath: string;
            export declare const CreatedBy: string;
            export declare const CreatedDate: string;
            export declare const RevisedBy: string;
            export declare const RevisedDate: string;
            export declare const Description: string;
            export declare const KeySegment1: string;
            export declare const KeySegment2: string;
            export declare const KeySegment3: string;
            export declare const KeySegment4: string;
            export declare const KeySegment5: string;
            export declare const AttmSize: string;
            export declare const AttmFile: string;
            export declare const UploadedBy: string;
            export declare const UploadedDate: string;
            export declare const Md5Hash: string;
        }

        [
            'Recnum', 
            'MasterTable', 
            'MasterKey', 
            'FileType', 
            'FilePath', 
            'CreatedBy', 
            'CreatedDate', 
            'RevisedBy', 
            'RevisedDate', 
            'Description', 
            'KeySegment1', 
            'KeySegment2', 
            'KeySegment3', 
            'KeySegment4', 
            'KeySegment5', 
            'AttmSize', 
            'AttmFile', 
            'UploadedBy', 
            'UploadedDate', 
            'Md5Hash'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

