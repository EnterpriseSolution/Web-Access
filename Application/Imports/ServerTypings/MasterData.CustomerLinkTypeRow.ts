namespace Matrix.MasterData {
    export interface CustomerLinkTypeRow {
        Recnum?: number;
        LinkType?: string;
        Description?: string;
        Suspended?: boolean;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
    }

    export namespace CustomerLinkTypeRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'LinkType';
        export const localTextPrefix = 'MasterData.CustomerLinkType';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const LinkType: string;
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
            'LinkType', 
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

