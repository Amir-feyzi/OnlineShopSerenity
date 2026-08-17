import { DeleteRequest, DeleteResponse, ListRequest, ListResponse, RetrieveRequest, RetrieveResponse, SaveRequest, SaveResponse, ServiceOptions, serviceRequest } from "@serenity-is/corelib";
import { ProvinceRow } from "./ProvinceRow";

export namespace ProvinceService {
    export const baseUrl = 'Province/Province';

    export declare function Create(request: SaveRequest<ProvinceRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Update(request: SaveRequest<ProvinceRow>, onSuccess?: (response: SaveResponse) => void, opt?: ServiceOptions<any>): PromiseLike<SaveResponse>;
    export declare function Delete(request: DeleteRequest, onSuccess?: (response: DeleteResponse) => void, opt?: ServiceOptions<any>): PromiseLike<DeleteResponse>;
    export declare function Retrieve(request: RetrieveRequest, onSuccess?: (response: RetrieveResponse<ProvinceRow>) => void, opt?: ServiceOptions<any>): PromiseLike<RetrieveResponse<ProvinceRow>>;
    export declare function List(request: ListRequest, onSuccess?: (response: ListResponse<ProvinceRow>) => void, opt?: ServiceOptions<any>): PromiseLike<ListResponse<ProvinceRow>>;

    export const Methods = {
        Create: "Province/Province/Create",
        Update: "Province/Province/Update",
        Delete: "Province/Province/Delete",
        Retrieve: "Province/Province/Retrieve",
        List: "Province/Province/List"
    } as const;

    [
        'Create',
        'Update',
        'Delete',
        'Retrieve',
        'List'
    ].forEach(x => {
        (<any>ProvinceService)[x] = function (r, s, o) {
            return serviceRequest(baseUrl + '/' + x, r, s, o);
        };
    });
}