namespace Matrix.Enterprise {
    export interface JobCategoryRow {
        Recnum?: number;
        Category?: string;
        Description?: string;
        Suspended?: boolean;
        Priority?: number;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
    }

    export namespace JobCategoryRow {
        export const idProperty = 'Category';
        export const nameProperty = 'Description';
        export const localTextPrefix = 'Enterprise.JobCategory';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const Category: string;
            export declare const Description: string;
            export declare const Suspended: string;
            export declare const Priority: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
        }

        [
            'Recnum', 
            'Category', 
            'Description', 
            'Suspended', 
            'Priority', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

