namespace Matrix.EnterpriseSys {
    export interface MenuTypeRow {
        Recnum?: number;
        UserGroup?: string;
        ProcessCode?: string;
        MenuType?: string;
        Description?: string;
        MenuCode?: string;
        Suspended?: string;
        CloseIcon?: number;
        OpenIcon?: number;
    }

    export namespace MenuTypeRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'UserGroup';
        export const localTextPrefix = 'EnterpriseSys.MenuType';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const UserGroup: string;
            export declare const ProcessCode: string;
            export declare const MenuType: string;
            export declare const Description: string;
            export declare const MenuCode: string;
            export declare const Suspended: string;
            export declare const CloseIcon: string;
            export declare const OpenIcon: string;
        }

        [
            'Recnum', 
            'UserGroup', 
            'ProcessCode', 
            'MenuType', 
            'Description', 
            'MenuCode', 
            'Suspended', 
            'CloseIcon', 
            'OpenIcon'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

