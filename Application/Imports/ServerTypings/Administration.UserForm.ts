namespace Matrix.Administration {
    export class UserForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.User';

    }

    export interface UserForm {
        UserId: Serenity.StringEditor;
        Username: Serenity.StringEditor;
        Email: Serenity.EmailEditor;
        Password: Serenity.PasswordEditor;
    }

    [['UserId', () => Serenity.StringEditor]
   , ['Username', () => Serenity.StringEditor]
   , ['Email', () => Serenity.EmailEditor]
   , ['Password', () => Serenity.PasswordEditor]
].forEach(x => Object.defineProperty(UserForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

