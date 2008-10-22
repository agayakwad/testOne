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

namespace HiRePro.JSONServiceLayer.UserManagement.Translators
{
    public static class TranslateBetweenJsonUserAndGetByIdUserType
    {
        public static JsonUser ServiceToBusiness(GetByIdUserType from)
        {
            JsonUser to = new JsonUser();
            if (from != null)
            {
                to = TranslateBetweenJsonUserAndUserInfoType.ServiceToBusiness(from.userInfoType);
            }
            return to;
        }

        public static UserType BusinessToService(JsonUser from)
        {
            UserType to = new UserType();
            return to;
        }
    }
}
