#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountPage.ChangePassword.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Membership.Pages
{
    using Administration.Entities;
    using Administration.Repositories;
    using Serenity;
    using Serenity.Abstractions;
    using Serenity.Data;
    using Serenity.Services;
    using Serenity.Web.Providers;
    using System;
    using System.Web.Mvc;
    using System.Web.Security;

    public partial class AccountController : Controller
    {
        [HttpGet, Authorize]
        public ActionResult ChangePassword()
        {
            return View(MVC.Views.Membership.Account.ChangePassword.AccountChangePassword);
        }

        [HttpPost, JsonFilter]
        public Result<ServiceResponse> ChangePassword(ChangePasswordRequest request)
        {
            return this.InTransaction("Administration", uow =>
            {
                request.CheckNotNull();

                if (string.IsNullOrEmpty(request.OldPassword))
                    throw new ArgumentNullException("oldPassword");

                var username = Authorization.UserId;
                //TODO 这里要重写改写第三个参数的传递
                var user = Dependency.Resolve<IAuthenticationService>().Validate(ref username, request.OldPassword, request.ConfirmPassword);
                
            if(user==null)
                    throw new ValidationError("CurrentPasswordMismatch", Texts.Validation.CurrentPasswordMismatch);

                if (request.ConfirmPassword != request.NewPassword)
                    throw new ValidationError("PasswordConfirmMismatch", LocalText.Get("Validation.PasswordConfirm"));

                request.NewPassword = UserRepository.ValidatePassword(username, request.NewPassword, false);

                var salt = Membership.GeneratePassword(5, 1);
                var hash = SiteMembershipProvider.ComputeSHA512(request.NewPassword + salt);
                //var userId = int.Parse(Authorization.UserId);

                //UserRepository.CheckPublicDemo(userId);

                //uow.Connection.UpdateById(new UserRow
                //{
                //    UserId = userId
                //});

                BatchGenerationUpdater.OnCommit(uow, UserRow.Fields.GenerationKey);

                return new ServiceResponse();
            });
        }
    }
}