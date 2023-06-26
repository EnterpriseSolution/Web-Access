namespace Matrix.MasterData {
    export interface MessageAttachmentRow {
        MessageId?: number;
        LineNo?: number;
        AttachmentType?: number;
        FileName?: string;
        FileContent?: number[];
        FileSize?: number;
        MessageCreatedBy?: string;
        MessageCreatedDate?: string;
        MessageRevisedBy?: string;
        MessageRevisedDate?: string;
        MessageSummary?: string;
        MessageDetail?: string;
        MessageParentId?: number;
        MessagePostStatus?: string;
        MessageReqId?: number;
        MessageMsgTo?: string;
        MessageReqmsgParentId?: number;
        MessageInstanceNo?: number;
        MessageHtmlText?: string;
        MessageWithAttachment?: boolean;
    }

    export namespace MessageAttachmentRow {
        export const idProperty = 'MessageId';
        export const nameProperty = 'FileName';
        export const localTextPrefix = 'MasterData.MessageAttachment';

        export namespace Fields {
            export declare const MessageId: string;
            export declare const LineNo: string;
            export declare const AttachmentType: string;
            export declare const FileName: string;
            export declare const FileContent: string;
            export declare const FileSize: string;
            export declare const MessageCreatedBy: string;
            export declare const MessageCreatedDate: string;
            export declare const MessageRevisedBy: string;
            export declare const MessageRevisedDate: string;
            export declare const MessageSummary: string;
            export declare const MessageDetail: string;
            export declare const MessageParentId: string;
            export declare const MessagePostStatus: string;
            export declare const MessageReqId: string;
            export declare const MessageMsgTo: string;
            export declare const MessageReqmsgParentId: string;
            export declare const MessageInstanceNo: string;
            export declare const MessageHtmlText: string;
            export declare const MessageWithAttachment: string;
        }

        [
            'MessageId', 
            'LineNo', 
            'AttachmentType', 
            'FileName', 
            'FileContent', 
            'FileSize', 
            'MessageCreatedBy', 
            'MessageCreatedDate', 
            'MessageRevisedBy', 
            'MessageRevisedDate', 
            'MessageSummary', 
            'MessageDetail', 
            'MessageParentId', 
            'MessagePostStatus', 
            'MessageReqId', 
            'MessageMsgTo', 
            'MessageReqmsgParentId', 
            'MessageInstanceNo', 
            'MessageHtmlText', 
            'MessageWithAttachment'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

