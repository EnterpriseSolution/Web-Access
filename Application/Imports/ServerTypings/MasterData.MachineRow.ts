namespace Matrix.MasterData {
    export interface MachineRow {
        Recnum?: number;
        MachineNo?: string;
        Description?: string;
        Suspended?: boolean;
        TemplateCode?: string;
        PictureFile?: string;
        Picture?: number[];
        Remarks?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        LastDetailNo?: number;
        WorkCentre?: string;
    }

    export namespace MachineRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'MachineNo';
        export const localTextPrefix = 'MasterData.Machine';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const MachineNo: string;
            export declare const Description: string;
            export declare const Suspended: string;
            export declare const TemplateCode: string;
            export declare const PictureFile: string;
            export declare const Picture: string;
            export declare const Remarks: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const LastDetailNo: string;
            export declare const WorkCentre: string;
        }

        [
            'Recnum', 
            'MachineNo', 
            'Description', 
            'Suspended', 
            'TemplateCode', 
            'PictureFile', 
            'Picture', 
            'Remarks', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'LastDetailNo', 
            'WorkCentre'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

