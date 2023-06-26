namespace Matrix.MasterData {
    export interface TextTypeRow {
        Recnum?: number;
        TextType?: string;
        Description?: string;
        Suspended?: boolean;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        DefaultText?: string;
    }

    export namespace TextTypeRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'TextType';
        export const localTextPrefix = 'MasterData.TextType';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const TextType: string;
            export declare const Description: string;
            export declare const Suspended: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const DefaultText: string;
        }

        [
            'Recnum', 
            'TextType', 
            'Description', 
            'Suspended', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch', 
            'DefaultText'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

