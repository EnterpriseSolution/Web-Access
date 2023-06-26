namespace Matrix.MasterData {
    export interface UnitRow {
        Recnum?: number;
        Uom?: string;
        Description?: string;
        Suspended?: boolean;
        DiscreteQty?: boolean;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
    }

    export namespace UnitRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'Uom';
        export const localTextPrefix = 'MasterData.Unit';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const Uom: string;
            export declare const Description: string;
            export declare const Suspended: string;
            export declare const DiscreteQty: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
        }

        [
            'Recnum', 
            'Uom', 
            'Description', 
            'Suspended', 
            'DiscreteQty', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

