namespace Matrix.MasterData {
    export interface LocationRow {
        Recnum?: number;
        Loc?: string;
        Description?: string;
        Suspended?: boolean;
        Address?: string;
        Address2?: string;
        Address3?: string;
        Address4?: string;
        BranchNo?: string;
        NoReservation?: boolean;
        NoWaitlist?: boolean;
        NoAvailable?: boolean;
        NoPlanning?: boolean;
        NoIssuance?: boolean;
        NoReceipts?: boolean;
        NoMatIssue?: boolean;
        NoFgReturn?: boolean;
        NoShipment?: boolean;
        NoGrn?: boolean;
        WithBacklog?: boolean;
        OnSorderCount?: number;
        OnPorderCount?: number;
        OnJorderCount?: number;
        InvtCostAvail?: number;
        InvtCostLdg?: number;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        OwnerBranch?: string;
        SourceBranch?: string;
        WithBinCtrl?: string;
        WithPackingBox?: boolean;
    }

    export namespace LocationRow {
        export const idProperty = 'Loc';
        export const nameProperty = 'Description';
        export const localTextPrefix = 'MasterData.Location';
        export const lookupKey = 'MasterData.LocationRow';

        export function getLookup(): Q.Lookup<LocationRow> {
            return Q.getLookup<LocationRow>('MasterData.LocationRow');
        }

        export namespace Fields {
            export declare const Recnum: string;
            export declare const Loc: string;
            export declare const Description: string;
            export declare const Suspended: string;
            export declare const Address: string;
            export declare const Address2: string;
            export declare const Address3: string;
            export declare const Address4: string;
            export declare const BranchNo: string;
            export declare const NoReservation: string;
            export declare const NoWaitlist: string;
            export declare const NoAvailable: string;
            export declare const NoPlanning: string;
            export declare const NoIssuance: string;
            export declare const NoReceipts: string;
            export declare const NoMatIssue: string;
            export declare const NoFgReturn: string;
            export declare const NoShipment: string;
            export declare const NoGrn: string;
            export declare const WithBacklog: string;
            export declare const OnSorderCount: string;
            export declare const OnPorderCount: string;
            export declare const OnJorderCount: string;
            export declare const InvtCostAvail: string;
            export declare const InvtCostLdg: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const OwnerBranch: string;
            export declare const SourceBranch: string;
            export declare const WithBinCtrl: string;
            export declare const WithPackingBox: string;
        }

        [
            'Recnum', 
            'Loc', 
            'Description', 
            'Suspended', 
            'Address', 
            'Address2', 
            'Address3', 
            'Address4', 
            'BranchNo', 
            'NoReservation', 
            'NoWaitlist', 
            'NoAvailable', 
            'NoPlanning', 
            'NoIssuance', 
            'NoReceipts', 
            'NoMatIssue', 
            'NoFgReturn', 
            'NoShipment', 
            'NoGrn', 
            'WithBacklog', 
            'OnSorderCount', 
            'OnPorderCount', 
            'OnJorderCount', 
            'InvtCostAvail', 
            'InvtCostLdg', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'OwnerBranch', 
            'SourceBranch', 
            'WithBinCtrl', 
            'WithPackingBox'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

