namespace Matrix.MasterData {
    export interface TabRow {
        Tabid?: number;
        Caption?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
    }

    export namespace TabRow {
        export const idProperty = 'Tabid';
        export const nameProperty = 'Caption';
        export const localTextPrefix = 'MasterData.Tab';

        export namespace Fields {
            export declare const Tabid: string;
            export declare const Caption: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
        }

        [
            'Tabid', 
            'Caption', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

