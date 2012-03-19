using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HiRePro.JSONServiceLayer.UserManagement.DataContracts.Requests;
using Common.ServiceProxies.UserManagement;
using HirePro.Framework.Core.Utility.Enums;

namespace HiRePro.JSONServiceLayer.UserManagement.Translators
{
   public static class TranslateBetweenJsonUsersNameRequestAndGetAllUserNamesRequest
    {
       public static GetAllUserNamesRequest BusinessToService(JsonUsersNameRequest from)
       {
           GetAllUserNamesRequest To = new GetAllUserNamesRequest();           
           if (from != null)
           {
               To.IncludeDeleted = from.IsDeletedEntityBeIncluded;
               To.IsUserRoleIsInterviewer = from.IsInterviewerOnly;
               To.TypeOfUser = EnumAdapter.GetEnumValue<UserOfType>(from.TypeofUser);
               if (from.IsDisabled.HasValue)
               {
                   To.IsDisabled = from.IsDisabled;
               }
               if (from.UsersExceptInTheseRolesIds != null && from.UsersExceptInTheseRolesIds.Length > 0)
               {
                   To.UsersExceptInTheseRolesIds = new int[from.UsersExceptInTheseRolesIds.Length];
                   for (int i = 0; i < from.UsersExceptInTheseRolesIds.Length; i++)
                   {
                       To.UsersExceptInTheseRolesIds[i] = from.UsersExceptInTheseRolesIds[i];
                   }
               }
               if (from.UsersInTheseRolesIds != null && from.UsersInTheseRolesIds.Length > 0)
               {
                   To.UsersInTheseRolesIds = new int[from.UsersInTheseRolesIds.Length];
                   for (int i = 0; i < from.UsersInTheseRolesIds.Length; i++)
                   {
                       To.UsersInTheseRolesIds[i] = from.UsersInTheseRolesIds[i];
                   }
               }
               
           }
           return To;
       }

    }
}
