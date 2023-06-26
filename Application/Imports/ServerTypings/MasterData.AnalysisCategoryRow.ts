namespace Matrix.MasterData {
    export interface AnalysisCategoryRow {
        Recnum?: number;
        Category?: string;
        Description?: string;
        Caption?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        DetailList?: AnalysisCodeRow[];
    }

    export namespace AnalysisCategoryRow {
        export const idProperty = 'Category';
        export const nameProperty = 'Category';
        export const localTextPrefix = 'MasterData.AnalysisCategory';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const Category: string;
            export declare const Description: string;
            export declare const Caption: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const DetailList: string;
        }

        [
            'Recnum', 
            'Category', 
            'Description', 
            'Caption', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch', 
            'DetailList'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

