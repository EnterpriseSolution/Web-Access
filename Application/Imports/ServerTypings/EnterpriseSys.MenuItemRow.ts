namespace Matrix.EnterpriseSys {
    export interface MenuItemRow {
        Recnum?: number;
        UserGroup?: string;
        ProcessCode?: string;
        FunctionCode?: string;
        Description?: string;
        MenuType?: string;
        MenuCode?: string;
        UlRow?: number;
        UlCol?: number;
        LrRow?: number;
        LrCol?: number;
        ResponseType?: string;
        PolicyCode?: string;
        Suspended?: string;
    }

    export namespace MenuItemRow {
        export const idProperty = 'Recnum';
        export const nameProperty = 'UserGroup';
        export const localTextPrefix = 'EnterpriseSys.MenuItem';

        export namespace Fields {
            export declare const Recnum: string;
            export declare const UserGroup: string;
            export declare const ProcessCode: string;
            export declare const FunctionCode: string;
            export declare const Description: string;
            export declare const MenuType: string;
            export declare const MenuCode: string;
            export declare const UlRow: string;
            export declare const UlCol: string;
            export declare const LrRow: string;
            export declare const LrCol: string;
            export declare const ResponseType: string;
            export declare const PolicyCode: string;
            export declare const Suspended: string;
        }

        [
            'Recnum', 
            'UserGroup', 
            'ProcessCode', 
            'FunctionCode', 
            'Description', 
            'MenuType', 
            'MenuCode', 
            'UlRow', 
            'UlCol', 
            'LrRow', 
            'LrCol', 
            'ResponseType', 
            'PolicyCode', 
            'Suspended'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

