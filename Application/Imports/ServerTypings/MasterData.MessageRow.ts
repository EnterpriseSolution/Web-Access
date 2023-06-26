namespace Matrix.MasterData {
    export interface MessageRow {
        DetailList?: MessageAttachmentRow[];
        MessageId?: number;
        CreatedBy?: string;
        CreatedDate?: string;
        RevisedBy?: string;
        RevisedDate?: string;
        Summary?: string;
        Detail?: string;
        ParentId?: number;
        PostStatus?: string;
        ReqId?: number;
        MsgTo?: string;
        ReqmsgParentId?: number;
        InstanceNo?: number;
        HtmlText?: string;
        WithAttachment?: boolean;
    }

    export namespace MessageRow {
        export const idProperty = 'MessageId';
        export const nameProperty = 'Summary';
        export const localTextPrefix = 'MasterData.Message';

        export namespace Fields {
            export declare const DetailList: string;
            export declare const MessageId: string;
            export declare const CreatedBy: string;
            export declare const CreatedDate: string;
            export declare const RevisedBy: string;
            export declare const RevisedDate: string;
            export declare const Summary: string;
            export declare const Detail: string;
            export declare const ParentId: string;
            export declare const PostStatus: string;
            export declare const ReqId: string;
            export declare const MsgTo: string;
            export declare const ReqmsgParentId: string;
            export declare const InstanceNo: string;
            export declare const HtmlText: string;
            export declare const WithAttachment: string;
        }

        [
            'DetailList', 
            'MessageId', 
            'CreatedBy', 
            'CreatedDate', 
            'RevisedBy', 
            'RevisedDate', 
            'Summary', 
            'Detail', 
            'ParentId', 
            'PostStatus', 
            'ReqId', 
            'MsgTo', 
            'ReqmsgParentId', 
            'InstanceNo', 
            'HtmlText', 
            'WithAttachment'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

