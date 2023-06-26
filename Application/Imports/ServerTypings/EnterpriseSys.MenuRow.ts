namespace Matrix.EnterpriseSys {
    export interface MenuRow {
        Recnum?: number;
        UserGroup?: string;
        ProcessCode?: string;
        Description?: string;
        Node?: string;
        MenuCode?: string;
        MenuLevel?: number;
        ImageFile?: string;
        Suspended?: string;
        CreatedDate?: string;
        CreatedBy?: string;
        RevisedDate?: string;
        RevisedBy?: string;
        CloseIcon?: number;
        OpenIcon?: number;
        UserGroupRecnum?: number;
        UserGroupDescription?: string;
        UserGroupSuspended?: string;
        UserGroupCreatedDate?: string;
        UserGroupCreatedBy?: string;
        UserGroupRevisedDate?: string;
        UserGroupRevisedBy?: string;
        UserGroupOwnerBranch?: string;
        UserGroupSourceBranch?: string;
        UserGroupLastModuleNo?: number;
        UserGroupEmail?: string;
        UserGroupViewOnly?: boolean;
    }

    export namespace MenuRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'UserGroup';
        export const localTextPrefix = 'EnterpriseSys.Menu';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const UserGroup: string;
            export declare const ProcessCode: string;
            export declare const Description: string;
            export declare const Node: string;
            export declare const MenuCode: string;
            export declare const MenuLevel: string;
            export declare const ImageFile: string;
            export declare const Suspended: string;
            export declare const CreatedDate: string;
            export declare const CreatedBy: string;
            export declare const RevisedDate: string;
            export declare const RevisedBy: string;
            export declare const CloseIcon: string;
            export declare const OpenIcon: string;
            export declare const UserGroupRecnum: string;
            export declare const UserGroupDescription: string;
            export declare const UserGroupSuspended: string;
            export declare const UserGroupCreatedDate: string;
            export declare const UserGroupCreatedBy: string;
            export declare const UserGroupRevisedDate: string;
            export declare const UserGroupRevisedBy: string;
            export declare const UserGroupOwnerBranch: string;
            export declare const UserGroupSourceBranch: string;
            export declare const UserGroupLastModuleNo: string;
            export declare const UserGroupEmail: string;
            export declare const UserGroupViewOnly: string;
        }

        [
            'Recnum', 
            'UserGroup', 
            'ProcessCode', 
            'Description', 
            'Node', 
            'MenuCode', 
            'MenuLevel', 
            'ImageFile', 
            'Suspended', 
            'CreatedDate', 
            'CreatedBy', 
            'RevisedDate', 
            'RevisedBy', 
            'CloseIcon', 
            'OpenIcon', 
            'UserGroupRecnum', 
            'UserGroupDescription', 
            'UserGroupSuspended', 
            'UserGroupCreatedDate', 
            'UserGroupCreatedBy', 
            'UserGroupRevisedDate', 
            'UserGroupRevisedBy', 
            'UserGroupOwnerBranch', 
            'UserGroupSourceBranch', 
            'UserGroupLastModuleNo', 
            'UserGroupEmail', 
            'UserGroupViewOnly'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

