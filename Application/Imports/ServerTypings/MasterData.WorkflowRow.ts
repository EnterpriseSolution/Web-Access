namespace Matrix.MasterData {
    export interface WorkflowRow {
        Workflowname?: string;
        Description?: string;
        Tablename?: string;
        Workflowtype?: number;
        Seqno?: number;
        Xoml?: string;
        Rules?: string;
        Suspended?: boolean;
        Published?: boolean;
        Publishedxoml?: string;
        Publishedrules?: string;
        Createdby?: string;
        Createddate?: string;
        Revisedby?: string;
        Reviseddate?: string;
    }

    export namespace WorkflowRow {
        export const idProperty = 'Workflowname';
        export const nameProperty = 'Workflowname';
        export const localTextPrefix = 'MasterData.Workflow';

        export namespace Fields {
            export declare const Workflowname: string;
            export declare const Description: string;
            export declare const Tablename: string;
            export declare const Workflowtype: string;
            export declare const Seqno: string;
            export declare const Xoml: string;
            export declare const Rules: string;
            export declare const Suspended: string;
            export declare const Published: string;
            export declare const Publishedxoml: string;
            export declare const Publishedrules: string;
            export declare const Createdby: string;
            export declare const Createddate: string;
            export declare const Revisedby: string;
            export declare const Reviseddate: string;
        }

        [
            'Workflowname', 
            'Description', 
            'Tablename', 
            'Workflowtype', 
            'Seqno', 
            'Xoml', 
            'Rules', 
            'Suspended', 
            'Published', 
            'Publishedxoml', 
            'Publishedrules', 
            'Createdby', 
            'Createddate', 
            'Revisedby', 
            'Reviseddate'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

