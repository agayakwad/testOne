﻿using System;
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
using HirePro.Framework.Core.Utility.Enums;
using HiRePro.JSONServiceLayer.Helper;
using HiRePro.JSONServiceLayer.UserManagement.DataContracts.Requests;

namespace HiRePro.JSONServiceLayer.UserManagement.Translators
{
    public static class TranslateBetweenJsonUserAndUserInfoType
    {
        public static JsonUser ServiceToBusiness(UserInfoType from)
        {

            JsonUser to = new JsonUser();
            if (from != null)
            {
                to.LoginName = from.LoginName;
                if (from.Password != null)
                {
                    to.Password = from.Password;

                }
                if (from.IsPasswordAutoGenerated.HasValue)
                {
                    to.IsPasswordAutoGenerated = from.IsPasswordAutoGenerated.Value;
                }
                to.PasswordQuestion = from.PasswordQuestion;
                to.PasswordAnswer = from.PasswordAnswer;
                to.Signature = from.Signature;
                to.FirstName = from.NameContact.FirstName;
                to.MiddleName = from.NameContact.MiddleName;
                to.LastName = from.NameContact.LastName;
                to.IsMasterVendorUser = from.IsMasterVendorUser;
                if (from.Contact != null)
                {
                    to.Email1 = from.Contact.Email1;
                    to.Email2 = from.Contact.Email2;
                    to.PhoneOffice = from.Contact.PhoneOffice;
                    to.PhoneOther = from.Contact.Mobile1;
                    to.Street = from.Contact.Address1;
                }
                //to.State = from.Contact.HomeAddress.State;
                //to.City = from.Contact.HomeAddress.City;
                //to.Country = from.Contact.HomeAddress.Country;
                //to.Pincode = from.Contact.HomeAddress.Pincode;
                to.EmailPassword = from.EmailPassword;
                to.IsEmailExtractionRequired = from.IsEmailExtractionRequired;
                to.IsPop3Listener = from.IsPop3Listener;
                to.Id = from.Id;
                to.IsAdmin = from.IsAdmin;
                to.RolesAssigned = from.RolesAssigned;
                to.ActivityVendorId = from.ActivityVendorId;
                if (from.LastLoginTime.HasValue)
                    to.LastLoginTime = from.LastLoginTime.Value;

                if (!string.IsNullOrEmpty(from.LastLoginIP))
                    to.LastLoginIP = from.LastLoginIP;
                //to.DepartmentId = from.DepartmentId;
                //if (from.DesignationId.HasValue) {
                //    to.DesignationId = from.DesignationId.Value;
                //}
                to.TypeOfUser = (HiRePro.JSONServiceLayer.CommonManagement.DataContracts.TypeOfUser)Enum.Parse(typeof(UserOfType), from.TypeOfUser.ToString());
            }
            return to;

        }

        public static UserInfoType BusinessToService(JsonUser from)
        {
            UserInfoType to = new UserInfoType();
            to.Contact = new ContactType();
            to.NameContact = new NameType();
            if (from != null)
            {
                if (from.Id >= 0)
                {
                    to.Id = from.Id;
                }
                else
                {
                    if ((from.CurrentUserId != null && from.CurrentUserId != ""))

                        to.Id = int.Parse(HelperUtility.MD5Decrypt(from.CurrentUserId));
                }
                if (from.Password != null)
                {
                    to.Password = from.Password;
                }

                to.LoginName = from.LoginName;
                to.IsPasswordAutoGenerated = from.IsPasswordAutoGenerated;
                to.PasswordQuestion = from.PasswordQuestion;
                to.PasswordAnswer = from.PasswordAnswer;
                to.Signature = from.Signature;
                to.IsMasterVendorUser = from.IsMasterVendorUser;
                to.ActivityVendorId = from.ActivityVendorId;
                to.LoginName = from.LoginName;
                to.IsPasswordAutoGenerated = from.IsPasswordAutoGenerated;
                to.PasswordQuestion = from.PasswordQuestion;
                to.PasswordAnswer = from.PasswordAnswer;
                to.Signature = from.Signature;
               // to.DepartmentId = from.DepartmentId;
                if (from.DesignationId.HasValue)
                {
                    //to.DesignationId = from.DesignationId.Value;
                }

                if (from.FirstName != null)
                {
                    from.FirstName = from.FirstName.Trim();
                    string[] UserName = from.FirstName.Split(' ');
                    int k = 0;
                    for (int j = 0; j < UserName.Length; j++)
                    {
                        if (UserName[j] != "")
                        {
                            switch (k)
                            {
                                case 0:
                                    to.NameContact.FirstName = UserName[j].Trim();
                                    break;
                                case 1:
                                    to.NameContact.MiddleName = UserName[j].Trim();
                                    break;
                                default:
                                    to.NameContact.LastName += UserName[j].Trim() + " ";
                                    break;
                            }
                            k++;
                        }
                    }
                }
                // to.Contact.LastName = from.LastName;
                // to.Contact.MiddleName = from.MiddleName;
                to.Contact.Email1 = from.Email1;
                to.Contact.Email2 = from.Email2;
                to.Contact.PhoneOffice = from.PhoneOffice;
                to.Contact.Mobile1 = from.PhoneOther;
                //to.Contact.HomeAddress = new AddressType();
                to.Contact.Address1 = from.Street;
                //to.Contact.HomeAddress.State = from.State;
                //to.Contact.HomeAddress.City = from.City;
                //to.Contact.HomeAddress.Country = from.Country;
                //to.Contact.HomeAddress.Pincode = from.Pincode;
                to.IsEmailExtractionRequired = from.IsEmailExtractionRequired;
                to.IsPop3Listener = from.IsPop3Listener;
                to.EmailPassword = from.EmailPassword;
                to.IsAdmin = from.IsAdmin;
                to.RolesAssigned = from.RolesAssigned;
                if (to.LastLoginTime == null)
                {
                    to.LastLoginTime = DateTime.Now;
                }
                else
                {
                    to.LastLoginTime = from.LastLoginTime;
                }

                to.TypeOfUser = EnumAdapter.GetEnumValue<UserOfType>(from.TypeOfUser);
            }
            return to;
        }
    }
}
