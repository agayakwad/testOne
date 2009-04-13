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
        
        public static JsonRole ServiceToBusiness(RoleType from)
        {
            JsonRole to = new JsonRole();
            if (from != null)
            {    
                to.Description = from.Description;
                to.Name = from.Name;
                to.ObjectId = from.Id;                
            }
            return to;
           
        }

    }
}
