namespace Matrix.Inventory {
    export namespace FifoControlService {
        export const baseUrl = 'Inventory/FifoControl';

        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<FifoControlRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<FifoControlRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export namespace Methods {
            export declare const Retrieve: string;
            export declare const List: string;
        }

        [
            'Retrieve', 
            'List'
        ].forEach(x => {
            (<any>FifoControlService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
            (<any>Methods)[x] = baseUrl + '/' + x;
        });
    }
}

