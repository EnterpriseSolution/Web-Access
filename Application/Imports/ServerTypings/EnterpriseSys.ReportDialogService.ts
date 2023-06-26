namespace Matrix.EnterpriseSys {
    export namespace ReportDialogService {
        export const baseUrl = 'EnterpriseSys/ReportDialog';

        export declare function Create(request: Serenity.SaveRequest<ReportDialogRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Update(request: Serenity.SaveRequest<ReportDialogRow>, onSuccess?: (response: Serenity.SaveResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Delete(request: Serenity.DeleteRequest, onSuccess?: (response: Serenity.DeleteResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<ReportDialogRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<ReportDialogRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function ReportDetail(request: ReportDetailRequest, onSuccess?: (response: ReportDetailResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function ReportPreview(request: ReportPreviewRequest, onSuccess?: (response: ReportDetailResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export namespace Methods {
            export declare const Create: string;
            export declare const Update: string;
            export declare const Delete: string;
            export declare const Retrieve: string;
            export declare const List: string;
            export declare const ReportDetail: string;
            export declare const ReportPreview: string;
        }

        [
            'Create', 
            'Update', 
            'Delete', 
            'Retrieve', 
            'List', 
            'ReportDetail', 
            'ReportPreview'
        ].forEach(x => {
            (<any>ReportDialogService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
            (<any>Methods)[x] = baseUrl + '/' + x;
        });
    }
}

