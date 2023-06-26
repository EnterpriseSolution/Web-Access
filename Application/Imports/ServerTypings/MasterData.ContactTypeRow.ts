namespace Matrix.MasterData {
    export interface ContactTypeRow {
        Recnum?: number;
        ContactType?: string;
        Description?: string;
        Suspended?: boolean;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
    }

    export namespace ContactTypeRow {
        export const idProperty = 'ContactType';
        export const nameProperty = 'Description';
        export const localTextPrefix = 'MasterData.ContactType';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const ContactType: string;
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
            'ContactType', 
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

