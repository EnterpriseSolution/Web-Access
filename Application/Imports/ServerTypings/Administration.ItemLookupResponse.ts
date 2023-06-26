namespace Matrix.Administration {
    export interface ItemLookupResponse extends Serenity.ServiceResponse {
        Columns?: ColumnEntity[];
        RowData?: any;
        PageCount?: number;
        CurrentPageIndex?: number;
        Description?: string;
        KeyField1?: string;
        KeyField2?: string;
        KeyField3?: string;
    }
}

