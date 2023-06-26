namespace Matrix.Modules.Development {
    export namespace TableExplorerService {
        export const baseUrl = 'Development/TableExplorer';

        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TableExplorerColumns>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export namespace Methods {
            export declare const List: string;
        }

        [
            'List'
        ].forEach(x => {
            (<any>TableExplorerService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
            (<any>Methods)[x] = baseUrl + '/' + x;
        });
    }
}

