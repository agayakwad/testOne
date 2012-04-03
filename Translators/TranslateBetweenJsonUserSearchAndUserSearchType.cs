using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common.ServiceProxies.UserManagement;
using HiRePro.JSONServiceLayer.UserManagement.DataContracts;

namespace HiRePro.JSONServiceLayer.UserManagement.Translators
{
    public static class TranslateBetweenJsonUserSearchAndUserSearchType
    {
        public static UserSearchType BusinessToService(JsonUserSearch from)
        {
            UserSearchType to = new UserSearchType();
            if (from != null)
            {
                if (!string.IsNullOrEmpty(from.Email))
                    to.Email = from.Email;
                if (!string.IsNullOrEmpty(from.LoginName))
                    to.LoginName = from.LoginName;
                if (!string.IsNullOrEmpty(from.UserName))
                    to.UserName = from.UserName;
                if (from.RoleIds != null && from.RoleIds.Length > 0)
                    to.RoleIds = from.RoleIds; 
                to.SourceIds = from.SourceIds;
            }
            return to;
        }
    }
}
