namespace Matrix.Administration {
    export interface ItemLookupRequest extends Serenity.ServiceRequest {
        LookupName?: string;
        LookupFilter?: string;
        CurrentPageIndex?: number;
        PageCount?: number;
    }
}

