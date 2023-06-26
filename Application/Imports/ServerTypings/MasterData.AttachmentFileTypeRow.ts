namespace Matrix.MasterData {
    export interface AttachmentFileTypeRow {
        Recnum?: number;
        FileType?: string;
        Description?: string;
        ExePath?: string;
        CreatedBy?: string;
        CreatedDate?: string;
        RevisedBy?: string;
        RevisedDate?: string;
        Suspended?: boolean;
    }

    export namespace AttachmentFileTypeRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'FileType';
        export const localTextPrefix = 'MasterData.AttachmentFileType';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const FileType: string;
            export declare const Description: string;
            export declare const ExePath: string;
            export declare const CreatedBy: string;
            export declare const CreatedDate: string;
            export declare const RevisedBy: string;
            export declare const RevisedDate: string;
            export declare const Suspended: string;
        }

        [
            'Recnum', 
            'FileType', 
            'Description', 
            'ExePath', 
            'CreatedBy', 
            'CreatedDate', 
            'RevisedBy', 
            'RevisedDate', 
            'Suspended'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

