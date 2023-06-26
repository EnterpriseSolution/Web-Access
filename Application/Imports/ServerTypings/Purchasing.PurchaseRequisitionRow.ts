namespace Matrix.Purchasing {
    export interface PurchaseRequisitionRow {
        Recnum?: number;
        ReqNo?: string;
        Closed?: string;
        RequestBy?: string;
        RequestDate?: string;
        DueDate?: string;
        RemindDate?: string;
        Reminded?: string;
        Recipients?: string;
        Comments1?: string;
        Comments2?: string;
        Comments3?: string;
        Comments4?: string;
        CreatedBy?: string;
        CreatedDate?: string;
        RevisedBy?: string;
        RevisedDate?: string;
        ClosedBy?: string;
        ClosedDate?: string;
        MessageId?: number;
        Status?: string;
        Approved?: string;
        ApprovedBy?: string;
        ApprovedDate?: string;
    }

    export namespace PurchaseRequisitionRow {
        export const idProperty = 'ReqNo';
        export const nameProperty = 'ReqNo';
        export const localTextPrefix = 'Purchasing.PurchaseRequisition';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const ReqNo: string;
            export declare const Closed: string;
            export declare const RequestBy: string;
            export declare const RequestDate: string;
            export declare const DueDate: string;
            export declare const RemindDate: string;
            export declare const Reminded: string;
            export declare const Recipients: string;
            export declare const Comments1: string;
            export declare const Comments2: string;
            export declare const Comments3: string;
            export declare const Comments4: string;
            export declare const CreatedBy: string;
            export declare const CreatedDate: string;
            export declare const RevisedBy: string;
            export declare const RevisedDate: string;
            export declare const ClosedBy: string;
            export declare const ClosedDate: string;
            export declare const MessageId: string;
            export declare const Status: string;
            export declare const Approved: string;
            export declare const ApprovedBy: string;
            export declare const ApprovedDate: string;
        }

        [
            'Recnum', 
            'ReqNo', 
            'Closed', 
            'RequestBy', 
            'RequestDate', 
            'DueDate', 
            'RemindDate', 
            'Reminded', 
            'Recipients', 
            'Comments1', 
            'Comments2', 
            'Comments3', 
            'Comments4', 
            'CreatedBy', 
            'CreatedDate', 
            'RevisedBy', 
            'RevisedDate', 
            'ClosedBy', 
            'ClosedDate', 
            'MessageId', 
            'Status', 
            'Approved', 
            'ApprovedBy', 
            'ApprovedDate'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

