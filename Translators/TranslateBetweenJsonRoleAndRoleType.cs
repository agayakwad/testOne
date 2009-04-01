using System;
using System.Data;
using System.Configuration;
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
    public static class TranslateBetweenJsonRoleAndRoleType
    {
        //public static CreateRoleRequest BusinessToService(JsonRole from)
        //{
        //    if (from != null)
        //    {
        //        CreateRoleRequest to = new CreateRoleRequest();
        //        to.Role = new RoleType();
        //        to.Role.Description = from.Description;
        //        to.Role.Name = from.Name;
                
        //    }
        //    return to;
           
        //}

        public static JsonRole ServiceToBusiness(CreateRoleRequest from)
        {
            JsonRole to = new JsonRole();
            if (from != null)
            {
                to.Description = from.Role.Description;
                to.Name = from.Role.Name;
               
            }
            return to;
           
        }

    }
}
