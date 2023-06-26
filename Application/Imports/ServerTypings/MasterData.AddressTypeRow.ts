namespace Matrix.MasterData {
    export interface AddressTypeRow {
        Recnum?: number;
        AddressType?: string;
        Description?: string;
        Suspended?: boolean;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
    }

    export namespace AddressTypeRow {
        export const idProperty = 'AddressType';
        export const nameProperty = 'Description';
        export const localTextPrefix = 'MasterData.AddressType';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const AddressType: string;
            export declare const Description: string;
            export declare const Suspended: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
        }

        [
            'Recnum', 
            'AddressType', 
            'Description', 
            'Suspended', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

