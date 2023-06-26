namespace Matrix.Purchasing {
    export interface PurchaseRequisitionDetailRow {
        Recnum?: number;
        ReqNo?: string;
        LineNo?: number;
        ItemNo?: string;
        Description?: string;
        Uom?: string;
        LotSize?: number;
        Qty?: number;
        ExtDescription?: string;
        QtyAllocated?: number;
        Remark?: string;
        QtyPreAllocated?: number;
        ReqNoRecnum?: number;
        ReqNoClosed?: string;
        ReqNoRequestBy?: string;
        ReqNoRequestDate?: string;
        ReqNoDueDate?: string;
        ReqNoRemindDate?: string;
        ReqNoReminded?: string;
        ReqNoRecipients?: string;
        ReqNoComments1?: string;
        ReqNoComments2?: string;
        ReqNoComments3?: string;
        ReqNoComments4?: string;
        ReqNoCreatedBy?: string;
        ReqNoCreatedDate?: string;
        ReqNoRevisedBy?: string;
        ReqNoRevisedDate?: string;
        ReqNoClosedBy?: string;
        ReqNoClosedDate?: string;
        ReqNoMessageId?: number;
        ReqNoStatus?: string;
        ReqNoApproved?: string;
        ReqNoApprovedBy?: string;
        ReqNoApprovedDate?: string;
    }

    export namespace PurchaseRequisitionDetailRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'ReqNo';
        export const localTextPrefix = 'Purchasing.PurchaseRequisitionDetail';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const ReqNo: string;
            export declare const LineNo: string;
            export declare const ItemNo: string;
            export declare const Description: string;
            export declare const Uom: string;
            export declare const LotSize: string;
            export declare const Qty: string;
            export declare const ExtDescription: string;
            export declare const QtyAllocated: string;
            export declare const Remark: string;
            export declare const QtyPreAllocated: string;
            export declare const ReqNoRecnum: string;
            export declare const ReqNoClosed: string;
            export declare const ReqNoRequestBy: string;
            export declare const ReqNoRequestDate: string;
            export declare const ReqNoDueDate: string;
            export declare const ReqNoRemindDate: string;
            export declare const ReqNoReminded: string;
            export declare const ReqNoRecipients: string;
            export declare const ReqNoComments1: string;
            export declare const ReqNoComments2: string;
            export declare const ReqNoComments3: string;
            export declare const ReqNoComments4: string;
            export declare const ReqNoCreatedBy: string;
            export declare const ReqNoCreatedDate: string;
            export declare const ReqNoRevisedBy: string;
            export declare const ReqNoRevisedDate: string;
            export declare const ReqNoClosedBy: string;
            export declare const ReqNoClosedDate: string;
            export declare const ReqNoMessageId: string;
            export declare const ReqNoStatus: string;
            export declare const ReqNoApproved: string;
            export declare const ReqNoApprovedBy: string;
            export declare const ReqNoApprovedDate: string;
        }

        [
            'Recnum', 
            'ReqNo', 
            'LineNo', 
            'ItemNo', 
            'Description', 
            'Uom', 
            'LotSize', 
            'Qty', 
            'ExtDescription', 
            'QtyAllocated', 
            'Remark', 
            'QtyPreAllocated', 
            'ReqNoRecnum', 
            'ReqNoClosed', 
            'ReqNoRequestBy', 
            'ReqNoRequestDate', 
            'ReqNoDueDate', 
            'ReqNoRemindDate', 
            'ReqNoReminded', 
            'ReqNoRecipients', 
            'ReqNoComments1', 
            'ReqNoComments2', 
            'ReqNoComments3', 
            'ReqNoComments4', 
            'ReqNoCreatedBy', 
            'ReqNoCreatedDate', 
            'ReqNoRevisedBy', 
            'ReqNoRevisedDate', 
            'ReqNoClosedBy', 
            'ReqNoClosedDate', 
            'ReqNoMessageId', 
            'ReqNoStatus', 
            'ReqNoApproved', 
            'ReqNoApprovedBy', 
            'ReqNoApprovedDate'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

