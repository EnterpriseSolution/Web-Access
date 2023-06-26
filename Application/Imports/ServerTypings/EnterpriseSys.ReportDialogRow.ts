namespace Matrix.EnterpriseSys {
    export interface ReportDialogRow {
        ReportId?: string;
        Description?: string;
        Suspended?: boolean;
        CreatedBy?: string;
        CreatedDate?: string;
        RevisedBy?: string;
        RevisedDate?: string;
        FilterBySalesmanCode?: boolean;
        FilterByBuyerCode?: boolean;
        ReportType?: number;
        DataSource?: number;
        ItemDetailList?: ReportDialogOptionRow[];
    }

    export namespace ReportDialogRow {
        export const idProperty = 'ReportId';
        export const nameProperty = 'Description';
        export const localTextPrefix = 'EnterpriseSys.ReportDialog';

        export namespace Fields {
            export declare const ReportId: string;
            export declare const Description: string;
            export declare const Suspended: string;
            export declare const CreatedBy: string;
            export declare const CreatedDate: string;
            export declare const RevisedBy: string;
            export declare const RevisedDate: string;
            export declare const FilterBySalesmanCode: string;
            export declare const FilterByBuyerCode: string;
            export declare const ReportType: string;
            export declare const DataSource: string;
            export declare const ItemDetailList: string;
        }

        [
            'ReportId', 
            'Description', 
            'Suspended', 
            'CreatedBy', 
            'CreatedDate', 
            'RevisedBy', 
            'RevisedDate', 
            'FilterBySalesmanCode', 
            'FilterByBuyerCode', 
            'ReportType', 
            'DataSource', 
            'ItemDetailList'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

