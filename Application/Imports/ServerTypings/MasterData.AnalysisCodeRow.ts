namespace Matrix.MasterData {
    export interface AnalysisCodeRow {
        Recnum?: number;
        Category?: string;
        AnalysisCode?: string;
        Description?: string;
        Suspended?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        CategoryRecnum?: number;
        CategoryDescription?: string;
        CategoryCaption?: string;
        CategoryCreatedDate?: string;
        CategoryCreatedBy?: string;
        CategoryRevisedDate?: string;
        CategoryRevisedBy?: string;
        CategoryOwnerBranch?: string;
        CategorySourceBranch?: string;
    }

    export namespace AnalysisCodeRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'Category';
        export const localTextPrefix = 'MasterData.AnalysisCode';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const Category: string;
            export declare const AnalysisCode: string;
            export declare const Description: string;
            export declare const Suspended: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const CategoryRecnum: string;
            export declare const CategoryDescription: string;
            export declare const CategoryCaption: string;
            export declare const CategoryCreatedDate: string;
            export declare const CategoryCreatedBy: string;
            export declare const CategoryRevisedDate: string;
            export declare const CategoryRevisedBy: string;
            export declare const CategoryOwnerBranch: string;
            export declare const CategorySourceBranch: string;
        }

        [
            'Recnum', 
            'Category', 
            'AnalysisCode', 
            'Description', 
            'Suspended', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch', 
            'CategoryRecnum', 
            'CategoryDescription', 
            'CategoryCaption', 
            'CategoryCreatedDate', 
            'CategoryCreatedBy', 
            'CategoryRevisedDate', 
            'CategoryRevisedBy', 
            'CategoryOwnerBranch', 
            'CategorySourceBranch'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

