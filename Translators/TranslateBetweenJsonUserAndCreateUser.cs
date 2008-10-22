using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using HiRePro.JSONServiceLayer.UserManagement.DataContracts;
using Common.ServiceProxies.UserManagement;
using System.Collections.Generic;

namespace HiRePro.JSONServiceLayer.UserManagement.Translators
{
    public static class TranslateBetweenJsonUserAndCreateUser
    {
        public static JsonUser ServiceToBusiness(CreateUserRequest from)
        {
            JsonUser to = new JsonUser();
            return to;
        }

        public static CreateUserRequest BusinessToService(JsonUser from)
        {
           // List<int> groupTypes = new List<int>();
           // List<int> roleTypes = new List<int>();
           // List<UserActionSimpleType> userActionTypes = new List<UserActionSimpleType>();
            CreateUserRequest to = new CreateUserRequest();
            to.UserInfoType = TranslateBetweenJsonUserAndUserInfoType.BusinessToService(from);
            //to.Profile = TranslateBetweenJsonUserProfileAndUserProfileType.BusinessToService(from.JsonUserProfile);
            //if (from.JsonGroupCollection != null)
            //{
            //    foreach (JsonGroup group in from.JsonGroupCollection)
            //    {
            //        groupTypes.Add(group.ObjectId);
            //    }
            //}

            //if (from.JsonRoleCollection != null)
            //{
            //    foreach (JsonRole role in from.JsonRoleCollection)
            //    {
            //        roleTypes.Add(role.ObjectId);
            //    }
            //}

            //if (from.JsonUserActionCollection != null)
            //{
            //    foreach (JsonUserAction userAction in from.JsonUserActionCollection)
            //    {
            //        UserActionSimpleType type = new UserActionSimpleType();
            //        type.ActionId = userAction.ActionId;
            //        type.Enable = userAction.Enable;
            //        userActionTypes.Add(type);
            //    }
            //}

            //to.Groups = groupTypes.ToArray();
            //to.Roles = roleTypes.ToArray();
            //to.UserActions = userActionTypes.ToArray();

            return to;
        }




      
    }
}
