namespace Matrix.MasterData {
    export interface MoldRow {
        Recnum?: number;
        MoldNo?: string;
        Description?: string;
        TotalSet?: number;
        StdOutput?: number;
        Suspended?: string;
        Length?: number;
        Width?: number;
        Thickness?: number;
        Weight?: number;
        SetWeight?: number;
        Shrink?: number;
        ShotSize?: number;
        CavityFinish?: string;
        TempCtrlZone?: number;
        WtrFlowA?: number;
        WtrFlowB?: number;
        Qmc?: string;
        HyCores?: string;
        MoldCost?: number;
        EjectorRtn?: string;
        Remarks?: string;
        PictureFile?: string;
        CavSets?: number;
        CavSqInch?: number;
        RevisedDate?: string;
        RevisedBy?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        LifeTime?: number;
        JobQty?: number;
        FinQty?: number;
        BalQty?: number;
        RepQty?: number;
    }

    export namespace MoldRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'MoldNo';
        export const localTextPrefix = 'MasterData.Mold';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const MoldNo: string;
            export declare const Description: string;
            export declare const TotalSet: string;
            export declare const StdOutput: string;
            export declare const Suspended: string;
            export declare const Length: string;
            export declare const Width: string;
            export declare const Thickness: string;
            export declare const Weight: string;
            export declare const SetWeight: string;
            export declare const Shrink: string;
            export declare const ShotSize: string;
            export declare const CavityFinish: string;
            export declare const TempCtrlZone: string;
            export declare const WtrFlowA: string;
            export declare const WtrFlowB: string;
            export declare const Qmc: string;
            export declare const HyCores: string;
            export declare const MoldCost: string;
            export declare const EjectorRtn: string;
            export declare const Remarks: string;
            export declare const PictureFile: string;
            export declare const CavSets: string;
            export declare const CavSqInch: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const LifeTime: string;
            export declare const JobQty: string;
            export declare const FinQty: string;
            export declare const BalQty: string;
            export declare const RepQty: string;
        }

        [
            'Recnum', 
            'MoldNo', 
            'Description', 
            'TotalSet', 
            'StdOutput', 
            'Suspended', 
            'Length', 
            'Width', 
            'Thickness', 
            'Weight', 
            'SetWeight', 
            'Shrink', 
            'ShotSize', 
            'CavityFinish', 
            'TempCtrlZone', 
            'WtrFlowA', 
            'WtrFlowB', 
            'Qmc', 
            'HyCores', 
            'MoldCost', 
            'EjectorRtn', 
            'Remarks', 
            'PictureFile', 
            'CavSets', 
            'CavSqInch', 
            'RevisedDate', 
            'RevisedBy', 
            'CreatedDate', 
            'CreatedBy', 
            'LifeTime', 
            'JobQty', 
            'FinQty', 
            'BalQty', 
            'RepQty'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

