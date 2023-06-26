namespace Matrix.MasterData {
    export interface TabDetailRow {
        Tabid?: number;
        ItemGroup?: string;
        Description?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        TabidCaption?: string;
        TabidCreatedDate?: string;
        TabidCreatedBy?: string;
        TabidRevisedDate?: string;
        TabidRevisedBy?: string;
    }

    export namespace TabDetailRow {
        export const idProperty = 'Tabid';
        export const nameProperty = 'ItemGroup';
        export const localTextPrefix = 'MasterData.TabDetail';

        export namespace Fields {
            export declare const Tabid: string;
            export declare const ItemGroup: string;
            export declare const Description: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const TabidCaption: string;
            export declare const TabidCreatedDate: string;
            export declare const TabidCreatedBy: string;
            export declare const TabidRevisedDate: string;
            export declare const TabidRevisedBy: string;
        }

        [
            'Tabid', 
            'ItemGroup', 
            'Description', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'TabidCaption', 
            'TabidCreatedDate', 
            'TabidCreatedBy', 
            'TabidRevisedDate', 
            'TabidRevisedBy'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

