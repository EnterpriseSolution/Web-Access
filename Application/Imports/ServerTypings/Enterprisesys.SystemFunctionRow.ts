namespace Matrix.Enterprisesys {
    export interface SystemFunctionRow {
        Recnum?: number;
        ModuleCode?: string;
        FunctionNo?: number;
        FunctionCode?: string;
        Description?: string;
        Suspended?: string;
        SeriesOption?: string;
        SeriesCode?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        Icon?: number;
        File?: string;
        Page?: number;
        Attachment?: string;
        Extension?: string;
        ModuleCodeRecnum?: number;
        ModuleCodeDescription?: string;
        ModuleCodeDesktopBmp?: string;
        ModuleCodeInstalled?: string;
        ModuleCodeLastLineNo?: number;
        ModuleCodeCreatedDate?: string;
        ModuleCodeCreatedBy?: string;
        ModuleCodeRevisedDate?: string;
        ModuleCodeRevisedBy?: string;
        ModuleCodeOwnerBranch?: string;
        ModuleCodeSourceBranch?: string;
    }

    export namespace SystemFunctionRow {
        export const idProperty = 'FunctionCode';
        export const nameProperty = 'Description';
        export const localTextPrefix = 'Enterprisesys.SystemFunction';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const ModuleCode: string;
            export declare const FunctionNo: string;
            export declare const FunctionCode: string;
            export declare const Description: string;
            export declare const Suspended: string;
            export declare const SeriesOption: string;
            export declare const SeriesCode: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const Icon: string;
            export declare const File: string;
            export declare const Page: string;
            export declare const Attachment: string;
            export declare const Extension: string;
            export declare const ModuleCodeRecnum: string;
            export declare const ModuleCodeDescription: string;
            export declare const ModuleCodeDesktopBmp: string;
            export declare const ModuleCodeInstalled: string;
            export declare const ModuleCodeLastLineNo: string;
            export declare const ModuleCodeCreatedDate: string;
            export declare const ModuleCodeCreatedBy: string;
            export declare const ModuleCodeRevisedDate: string;
            export declare const ModuleCodeRevisedBy: string;
            export declare const ModuleCodeOwnerBranch: string;
            export declare const ModuleCodeSourceBranch: string;
        }

        [
            'Recnum', 
            'ModuleCode', 
            'FunctionNo', 
            'FunctionCode', 
            'Description', 
            'Suspended', 
            'SeriesOption', 
            'SeriesCode', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch', 
            'Icon', 
            'File', 
            'Page', 
            'Attachment', 
            'Extension', 
            'ModuleCodeRecnum', 
            'ModuleCodeDescription', 
            'ModuleCodeDesktopBmp', 
            'ModuleCodeInstalled', 
            'ModuleCodeLastLineNo', 
            'ModuleCodeCreatedDate', 
            'ModuleCodeCreatedBy', 
            'ModuleCodeRevisedDate', 
            'ModuleCodeRevisedBy', 
            'ModuleCodeOwnerBranch', 
            'ModuleCodeSourceBranch'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

