namespace Matrix.Administration {
    export namespace TranslationService {
        export const baseUrl = 'Administration/Translation';

        export declare function Retrieve(request: Serenity.RetrieveRequest, onSuccess?: (response: Serenity.RetrieveResponse<TranslationRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function List(request: Serenity.ListRequest, onSuccess?: (response: Serenity.ListResponse<TranslationRow>) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;
        export declare function Lookup(request: ItemLookupRequest, onSuccess?: (response: ItemLookupResponse) => void, opt?: Q.ServiceOptions<any>): JQueryXHR;

        export namespace Methods {
            export declare const Retrieve: string;
            export declare const List: string;
            export declare const Lookup: string;
        }

        [
            'Retrieve', 
            'List', 
            'Lookup'
        ].forEach(x => {
            (<any>TranslationService)[x] = function (r, s, o) {
                return Q.serviceRequest(baseUrl + '/' + x, r, s, o);
            };
            (<any>Methods)[x] = baseUrl + '/' + x;
        });
    }
}

