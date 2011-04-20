using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HiRePro.JSONServiceLayer.CommonManagement.DataContracts;
using Common.ServiceProxies.UserManagement;
namespace HiRePro.JSONServiceLayer.UserManagement.Translators
{
    public class TranslateBetweenJsonLoginInformationAndLoginInformationType
    {
        public static UserNameAvailibilityRequest ServiceToBusiness(HiRePro.JSONServiceLayer.UserManagement.DataContracts.Requests.JsonValidateLoginInformationRequest from)
        {
            UserNameAvailibilityRequest to = new UserNameAvailibilityRequest();
            if(from!=null){
            to.Email1= from.Email1;
            to.TypeOfUser = HirePro.Framework.Core.Utility.Enums.EnumAdapter.GetEnumValue<UserOfType>(from.TypeOfUser);
            to.LoginName=from.LoginName;
            }
            return to;
        }
    }
}