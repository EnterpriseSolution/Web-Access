namespace Matrix.Administration {
    export interface UserRow {
        UserId?: string;
        Username?: string;
        UserGroup?: string;
        Email?: string;
        Suspended?: boolean;
        Password?: string;
    }

    export namespace UserRow {
        export const idProperty = 'UserId';
        export const nameProperty = 'Username';
        export const localTextPrefix = 'Administration.User';
        export const lookupKey = 'Administration.User';

        export function getLookup(): Q.Lookup<UserRow> {
            return Q.getLookup<UserRow>('Administration.User');
        }

        export namespace Fields {
            export declare const UserId: string;
            export declare const Username: string;
            export declare const UserGroup: string;
            export declare const Email: string;
            export declare const Suspended: string;
            export declare const Password: string;
        }

        [
            'UserId', 
            'Username', 
            'UserGroup', 
            'Email', 
            'Suspended', 
            'Password'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

