// <reference path="../../../Scripts/site/Application.Web.d.ts" />  

namespace Matrix.Membership {
    //import LoginRequest = Matrix.Membership.LoginRequest;
    //import LoginForm = Matrix.Membership.LoginForm;

    @Serenity.Decorators.registerClass()
    export class LoginPanel extends Serenity.PropertyPanel<LoginRequest, any> {
        
        private form: LoginForm;

        constructor(container: JQuery) {
            super(container);
            this.form = new LoginForm(this.idPrefix);

            this.byId('LoginButton').click(e => {
                e.preventDefault();
                if (!this.validateForm()) {
                    return;
                }

                var request = this.getSaveEntity();
                Q.serviceCall({
                    url: Q.resolveUrl('~/Account/Login'),
                    request: request,
                    onSuccess: function (response) {
                        var q = Q.parseQueryString();
                        var returnUrl = q['returnUrl'] || q['ReturnUrl'];
                        if (returnUrl) {
                            window.location.href = returnUrl;
                        } else {
                            window.location.href = Q.resolveUrl('~/');
                        }
                    }
                });
            });
        }

        protected getFormKey() {
            return LoginForm.formKey;
        }

        protected getTemplateName() {
            return 'LoginPanel';
        }

        
    }
}