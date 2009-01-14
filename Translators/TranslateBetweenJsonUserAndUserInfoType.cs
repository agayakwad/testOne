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
using HirePro.Framework.UI.Windows.Business.Base.Core;

namespace HiRePro.JSONServiceLayer.UserManagement.Translators
{
    public static class TranslateBetweenJsonUserAndUserInfoType
    {
        public static JsonUser ServiceToBusiness(UserInfoType from)
        {
           
                JsonUser to = new JsonUser();
                to.LoginName = from.LoginName;
                to.Password = from.Password;
                to.PasswordQuestion = from.PasswordQuestion;
                to.PasswordAnswer = from.PasswordAnswer;
                to.Signature = from.Signature;
                to.FirstName = from.Contact.FirstName;
                to.LastName = from.Contact.LastName;
                to.MiddleName = from.Contact.MiddleName;
                to.Email1 = from.Contact.Email1;
                to.Email2 = from.Contact.Email2;
                to.PhoneOffice = from.Contact.PhoneOffice;
                to.PhoneOther = from.Contact.PhoneOther;
                to.Street = from.Contact.HomeAddress.Street;
                to.State = from.Contact.HomeAddress.State;
                to.City = from.Contact.HomeAddress.City;
                to.Country = from.Contact.HomeAddress.Country;
                to.Pincode = from.Contact.HomeAddress.Pincode;
                to.EmailPassword = from.EmailPassword;
                to.IsEmailExtractionRequired = from.IsEmailExtractionRequired;
                to.IsPop3Listener = from.IsPop3Listener;

                if (from.LastLoginTime == null)
                    to.LastLoginTime = DateTime.Now;
                else
                    to.LastLoginTime = from.LastLoginTime.Value;

                to.TypeOfUser = (HiRePro.JSONServiceLayer.CommonManagement.DataContracts.TypeOfUser)Enum.Parse(typeof(UserLoginType),from.TypeOfUser.ToString());

                return to;
                
           
        }

        public static UserInfoType BusinessToService(JsonUser from)
        {
            UserInfoType to = new UserInfoType();
            to.LoginName = from.LoginName;
            to.Id = from.Id;
            to.Password = from.Password;
            to.PasswordQuestion = from.PasswordQuestion;
            to.PasswordAnswer = from.PasswordAnswer;
            to.Signature = from.Signature;
            to.Contact = new ContactType();
            to.Contact.FirstName = from.FirstName;
            to.Contact.LastName = from.LastName;
            to.Contact.MiddleName = from.MiddleName;
            to.Contact.Email1 = from.Email1;
            to.Contact.Email2 = from.Email2;
            to.Contact.PhoneOffice = from.PhoneOffice;
            to.Contact.PhoneOther = from.PhoneOther;
            to.Contact.HomeAddress = new AddressType();
            to.Contact.HomeAddress.Street = from.Street;
            to.Contact.HomeAddress.State = from.State;
            to.Contact.HomeAddress.City = from.City;
            to.Contact.HomeAddress.Country = from.Country;
            to.Contact.HomeAddress.Pincode = from.Pincode;
            to.IsEmailExtractionRequired = from.IsEmailExtractionRequired;
            to.IsPop3Listener = from.IsPop3Listener;
            to.EmailPassword = from.EmailPassword;

            if (to.LastLoginTime == null)
            {
                to.LastLoginTime = DateTime.Now;
            }
            else
            {
                to.LastLoginTime = from.LastLoginTime;
            }
            if (from.UserTypeValue == "Hiring Manager")
            {
                to.TypeOfUser = UserLoginType.HiringManagerUser;
            }
            
            
            return to;
        }
    }
}
