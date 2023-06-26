#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  UserPreferenceEndpoint.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Common.Endpoints
{
    using Serenity.Data;
    using Serenity.Services;
    using System.Data;
    using System.Web.Mvc;
    using MyRepository = Repositories.UserPreferenceRepository;
    using MyRow = Entities.UserPreferenceRow;

    [RoutePrefix("Services/Common/UserPreference"), Route("{action}")]
    [ConnectionKey(typeof(MyRow))]
    public class UserPreferenceController : ServiceEndpoint
    {
        [HttpPost]
        public ServiceResponse Update(IUnitOfWork uow, UserPreferenceUpdateRequest request)
        {
            return new MyRepository().Update(uow, request);
        }

        public UserPreferenceRetrieveResponse Retrieve(IDbConnection connection, UserPreferenceRetrieveRequest request)
        {
            return new MyRepository().Retrieve(connection, request);
        }
    }
}
